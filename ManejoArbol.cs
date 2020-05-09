using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
namespace Proyecto_Archivos
{
    class ManejoArbol
    {
        /*
         * Esta clase la utilizo para hacer el manejo eficaz de los arboles
        */
        Archivo ManejadorArchivo;
        FileStream archivo;
        public ManejoArbol()
        {
            ManejadorArchivo = new Archivo();
        }


        /*
         *  Este es el método que mando llamar  para insertar una Clave en un arbol Primario
        */
        public void InsertaEnArbolPrimario(Atributo atributo, string Ruta, int Clave, long Direccion, string RutaArchivoDicc)
        {
            Arbol ArbolP = new Arbol(ManejadorArchivo.ObtenNodos(atributo, archivo, Ruta), atributo);
            InsercionArbol(ArbolP, Clave, Direccion, Ruta, atributo, RutaArchivoDicc);
        }

        /*
         * 
         * Este es el método que mando a llamar para insertar una Clave en un Arbol Secundario
         * 
         */
        public void InsertaEnArbolSecundario(Atributo atributo, string Ruta, int Clave, long Direccion, string RutaArchivoDicc)
        {
            Arbol ArbolS = new Arbol(ManejadorArchivo.ObtenNodos(atributo, archivo, Ruta), atributo); // Obtengo todos los nodos del arbol en cuestión
            if (ArbolS.ContieneClaveEnHojas(Clave)) // Si el árbol ya contiene la clave en sus hojas ( No es necesario crear el bloque, solo agregar la dirección al bloque)
            {
                long DireccionBloque = ArbolS.ObtenDireccionDeHoja(Clave); // Obtenemos la dirección del bloque
                List<long> BloqueLectura = ManejadorArchivo.LeeCajonIndiceSecundario(Ruta, archivo, DireccionBloque); // Leemos el bloque

                //MessageBox.Show("EL bloque tiene: " + BloqueLectura.Count);
                BloqueLectura.Add(Direccion); // Agregamos la dirección nueva al bloque que leimos anteriormente
                BloqueLectura.Sort(); // Ordenamos el bloque
                ManejadorArchivo.EscribeCajonSecundario(Ruta, archivo, DireccionBloque, BloqueLectura); // Volvemos a escribir el bloque ya con la dirección agregada y ordenada
            }
            else // Si no existe la Clave en el árbol (Necesitamos hacer una inserción en el árbol)
            {
                long DireccionBloque = ManejadorArchivo.ObtenUltimaDireccion(Ruta, archivo); // Obtenemos la dirección del bloque
                ManejadorArchivo.EscribeCajonInicialIndiceSecundario(Ruta, archivo, DireccionBloque); // Escribimos el cajón de 2048 bytes lleno de * en el archivo
                InsercionArbol(ArbolS, Clave, DireccionBloque, Ruta, atributo, RutaArchivoDicc); // Insertamos la clave en el árbol
                List<long> Bloque = ManejadorArchivo.LeeCajonIndiceSecundario(Ruta, archivo, DireccionBloque); // Leemos el cajón recién creado (Obviamente no va a tener nada)
                Bloque.Add(Direccion); // Agregamos la dirección del registro al bloque
                Bloque.Sort(); // Ordenamos el bloque
                ManejadorArchivo.EscribeCajonSecundario(Ruta, archivo, DireccionBloque, Bloque); // Escribimos el bloque en el cajón secundario
            }
        }

        public void EliminaEnArbolSecundario(Atributo atributo, string Ruta, int Clave, string RutaArchivoDicc, long Direccion)
        {
            Arbol ArbolS = new Arbol(ManejadorArchivo.ObtenNodos(atributo, archivo, Ruta), atributo); // Obtenemos los nodos del árbol secundario
            Nodo Nodo = ArbolS.ObtenNodoConLaClave(Clave); // Creamos un nodo que va a servir como auxiliar para 
            long Dir = ArbolS.ObtenDireccionDeHoja(Clave);
            List<long> Bloque = ManejadorArchivo.LeeCajonIndiceSecundario(Ruta, archivo, Dir);
            Bloque.Remove(Direccion);
            if(Bloque.Count == 0)
            {
                EliminaEnArbol(ArbolS, Nodo, Clave, Direccion, Ruta, atributo, RutaArchivoDicc);
            }
            else
            {
                ManejadorArchivo.EscribeCajonSecundario(Ruta, archivo, Dir, Bloque);
            }
            if(ArbolS.Nodos.Count == 0)
            {
                ManejadorArchivo.CreaArchivo(Ruta, archivo);
            }
        }
        public void EliminaEnArbolPrimario(Atributo atributo, string Ruta, int Clave,string RutaArchivoDicc)
        {
            Arbol ArbolP = new Arbol(ManejadorArchivo.ObtenNodos(atributo, archivo, Ruta), atributo);
            Nodo NodoDondeSevaAEliminar = ArbolP.ObtenNodoConLaClave(Clave);
            long DireccionDondeEliminar = NodoDondeSevaAEliminar.ObtenApuntadorHoja(Clave);
            EliminaEnArbol(ArbolP, NodoDondeSevaAEliminar, Clave, DireccionDondeEliminar, Ruta, atributo, RutaArchivoDicc);
        }

        /*
         * 
         *      Función recursiva para eliminar una Clave en el árbol, empezamos con el caso base de que sea una hoja, en caso de que no checamos las condiciones buscando si tenemos raiz.
         *      En este método checamos los nodos vecinos de la hoja y vemos si alguno puede realizar algún prestamo, en caso de que no sea posible
         *      
         */
        public bool EliminaEnArbol(Arbol arbol, Nodo nodo, int clave, long direccion, string Ruta, Atributo A, string RutaDicc)
        { 
            int DatosMinimos = (Arbol.GradoArbol - 1) / 2;
            char tipo = nodo.TipoNodo;

            if (tipo == 'H')
            {
                if (!nodo.EliminaDatoEnHoja(clave))
                    return false;
            }
            else
            {
                if (!nodo.EliminaEnNodoRaiz(clave, direccion))
                    return false;
            }
            ManejadorArchivo.EscribeNodo(nodo, archivo, Ruta);
            if (tipo != 'R')
            {
                if (nodo.ObtenNumeroLlavesValidas() < DatosMinimos)
                {
                    Nodo VecinoD = arbol.ObtenNodoVecinoDer(nodo);
                    Nodo VecinoI = arbol.ObtenNodoVecinoIzq(nodo);
                    Nodo NodoPadre = arbol.ObtenNodoPadre(nodo);
                    if (VecinoD != null && arbol.ChecaSiTienenElMismoPadre(nodo, VecinoD) && VecinoD.ObtenNumeroLlavesValidas() - 1 >= DatosMinimos)
                    {
                        if (tipo == 'H')
                        {
                            long DirPrestada = VecinoD.DireccionLlaves[0];
                            int CvePrestada = VecinoD.Llaves[0];

                            if (!VecinoD.EliminaDatoEnHoja(CvePrestada))
                                return false;
                            ManejadorArchivo.EscribeNodo(VecinoD, archivo, Ruta);

                            nodo.InsertaOrdenadoEnHoja(CvePrestada, DirPrestada);
                            ManejadorArchivo.EscribeNodo(nodo, archivo, Ruta);

                            int IndiceActualizarPadre = NodoPadre.DireccionLlaves.IndexOf(nodo.DirNodo);
                            NodoPadre.Llaves[IndiceActualizarPadre] = VecinoD.Llaves[0];
                            ManejadorArchivo.EscribeNodo(NodoPadre, archivo, Ruta);
                        }
                        else
                        {
                            long DirVecino = VecinoD.DireccionLlaves[0];
                            int CveVecino = VecinoD.Llaves[0];
                            int IndiceCvePadre = NodoPadre.DireccionLlaves.IndexOf(nodo.DirNodo);
                            int CveNodoPadre = NodoPadre.Llaves[IndiceCvePadre];

                            if (!VecinoD.EliminaEnNodoRaiz(CveVecino, DirVecino))
                                return false;
                            ManejadorArchivo.EscribeNodo(VecinoD, archivo, Ruta);

                            NodoPadre.Llaves[IndiceCvePadre] = CveVecino;
                            ManejadorArchivo.EscribeNodo(NodoPadre, archivo, Ruta);

                            nodo.InsertaOrdenadoEnRaiz(CveNodoPadre, DirVecino);
                            ManejadorArchivo.EscribeNodo(nodo, archivo, Ruta);
                        }
                    }
                    else if (VecinoI != null && arbol.ChecaSiTienenElMismoPadre(nodo, VecinoI) && VecinoI.ObtenNumeroLlavesValidas() - 1 >= DatosMinimos)
                    {
                        if (tipo == 'H')
                        {
                            int CvePrestada = VecinoI.Llaves[VecinoI.ObtenNumeroLlavesValidas() - 1];
                            long DirPrestada = VecinoI.DireccionLlaves[VecinoI.ObtenNumeroLlavesValidas() - 1];

                            if (!VecinoI.EliminaDatoEnHoja(CvePrestada))
                                return false;
                            ManejadorArchivo.EscribeNodo(VecinoI, archivo, Ruta);
                            nodo.InsertaOrdenadoEnHoja(CvePrestada, DirPrestada);
                            ManejadorArchivo.EscribeNodo(nodo, archivo, Ruta);

                            int IndiceActualizarPadre = NodoPadre.DireccionLlaves.IndexOf(VecinoI.DirNodo);
                            NodoPadre.Llaves[IndiceActualizarPadre] = CvePrestada;
                            ManejadorArchivo.EscribeNodo(NodoPadre, archivo, Ruta);
                        }
                        else
                        {
                            long DirVecino = VecinoI.DireccionLlaves[VecinoI.ObtenNumeroLlavesValidas()];
                            int CveVecino = VecinoI.Llaves[VecinoI.ObtenNumeroLlavesValidas() - 1];
                            int IndiceCvePadre = NodoPadre.DireccionLlaves.IndexOf(VecinoI.DirNodo);
                            int CveNodoPadre = NodoPadre.Llaves[IndiceCvePadre];

                            if (!VecinoI.EliminaEnNodoRaiz(CveVecino, DirVecino))
                                return false;
                            ManejadorArchivo.EscribeNodo(VecinoI, archivo, Ruta);

                            NodoPadre.Llaves[IndiceCvePadre] = CveVecino;
                            ManejadorArchivo.EscribeNodo(NodoPadre, archivo, Ruta);

                            nodo.InsertaOrdenadoEnRaiz(CveNodoPadre, DirVecino);
                            ManejadorArchivo.EscribeNodo(nodo, archivo, Ruta);
                        }
                    }
                    else if (VecinoD != null && arbol.ChecaSiTienenElMismoPadre(nodo, VecinoD))
                    {
                        if (tipo == 'H')
                        {
                            for (int i = 0; i < VecinoD.ObtenNumeroLlavesValidas(); i++)
                                nodo.InsertaOrdenadoEnHoja(VecinoD.Llaves[i], VecinoD.DireccionLlaves[i]);
                            ManejadorArchivo.EscribeNodo(nodo, archivo, Ruta);
                            if (NodoPadre.TipoNodo == 'R' && NodoPadre.ObtenNumeroLlavesValidas() == 1)
                            {
                                A.Direccion_Indice = VecinoD.DirNodo;
                                ManejadorArchivo.ModificaAtributo(A, RutaDicc, archivo);
                            }
                            else
                            {
                                int idx_eliminar_NodoPadre = NodoPadre.DireccionLlaves.IndexOf(VecinoD.DirNodo);
                                int NuevaCve = NodoPadre.Llaves[idx_eliminar_NodoPadre - 1];
                                long NuevaDir = NodoPadre.DireccionLlaves[idx_eliminar_NodoPadre];

                                return EliminaEnArbol(arbol, NodoPadre, NuevaCve, NuevaDir,Ruta, A,RutaDicc);
                            }
                        }
                        else
                        {
                            int CveNodoPadre = NodoPadre.Llaves[NodoPadre.DireccionLlaves.IndexOf(nodo.DirNodo)];
                            long Dir0Vecino = VecinoD.DireccionLlaves[0];

                            VecinoD.InsertaOrdenadoEnRaiz(CveNodoPadre, Dir0Vecino);

                            for (int i = 0; i < nodo.ObtenNumeroLlavesValidas(); i++)
                                VecinoD.InsertaOrdenadoEnRaiz(nodo.Llaves[i], nodo.DireccionLlaves[i + 1]);
                            VecinoD.DireccionLlaves[0] = nodo.DireccionLlaves[0];

                            if (NodoPadre.TipoNodo == 'R' && NodoPadre.ObtenNumeroLlavesValidas() == 1)
                            {
                                VecinoD.TipoNodo = 'R';
                                ManejadorArchivo.EscribeNodo(VecinoD, archivo, Ruta);
                                A.Direccion_Indice = VecinoD.DirNodo;
                                ManejadorArchivo.ModificaAtributo(A, RutaDicc, archivo);
                            }
                            else
                            {
                                ManejadorArchivo.EscribeNodo(VecinoD,archivo, Ruta);
                                return EliminaEnArbol(arbol, NodoPadre, CveNodoPadre, nodo.DirNodo, Ruta, A, RutaDicc);
                            }
                        }
                    }
                    else if (VecinoI != null && arbol.ChecaSiTienenElMismoPadre(nodo, VecinoI))
                    {
                        if (tipo == 'H')
                        {
                            for (int i = 0; i < nodo.ObtenNumeroLlavesValidas(); i++)
                                VecinoI.InsertaOrdenadoEnHoja(nodo.Llaves[i], nodo.DireccionLlaves[i]);
                            ManejadorArchivo.EscribeNodo(VecinoI,archivo, Ruta);
                            if (NodoPadre.TipoNodo == 'R' && NodoPadre.ObtenNumeroLlavesValidas() == 1)
                            {
                                VecinoI.TipoNodo = 'R';
                                A.Direccion_Indice = VecinoI.DirNodo;
                                ManejadorArchivo.ModificaAtributo(A, RutaDicc, archivo);
                            }
                            else
                            {
                                int idx_eliminar_NodoPadre = NodoPadre.DireccionLlaves.IndexOf(nodo.DirNodo);
                                int NuevaCve = NodoPadre.Llaves[idx_eliminar_NodoPadre - 1];
                                long NuevaDir = NodoPadre.DireccionLlaves[idx_eliminar_NodoPadre];

                                return EliminaEnArbol(arbol, NodoPadre, NuevaCve, NuevaDir, Ruta, A, RutaDicc);
                            }
                        }
                        else
                        {
                            int CveNodoPadre = NodoPadre.Llaves[NodoPadre.DireccionLlaves.IndexOf(VecinoI.DirNodo)];
                            long Dir0NodoHijo = nodo.DireccionLlaves[0];

                            VecinoI.InsertaOrdenadoEnRaiz(CveNodoPadre, Dir0NodoHijo);

                            for (int i = 0; i < nodo.ObtenNumeroLlavesValidas(); i++)
                                VecinoI.InsertaOrdenadoEnRaiz(nodo.Llaves[i], nodo.DireccionLlaves[i + 1]);

                            if (NodoPadre.TipoNodo == 'R' && NodoPadre.ObtenNumeroLlavesValidas() == 1)
                            {
                                VecinoI.TipoNodo = 'R';
                                ManejadorArchivo.EscribeNodo(VecinoI,archivo, Ruta);
                                A.Direccion_Indice = VecinoI.DirNodo;
                                ManejadorArchivo.ModificaAtributo(A, RutaDicc, archivo);
                            }
                            else
                            {
                                ManejadorArchivo.EscribeNodo(VecinoI, archivo, Ruta);
                                return EliminaEnArbol(arbol, NodoPadre, CveNodoPadre, nodo.DirNodo, Ruta, A, RutaDicc);
                            }
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public void InsercionArbol(Arbol arbol, int Clave, long Direccion, string Ruta, Atributo atributo, string RutaArchDicc)
        {
            if (arbol.Nodos.Count == 0) // En caso de que no haya ningún nodo en el árbol(Ni siquiera una hoja)
            {
                //MessageBox.Show("No hay ningún nodo en el archivo");
                Nodo NuevaHoja = CreaNodo('H', ManejadorArchivo.ObtenUltimaDireccion(Ruta, archivo));
                NuevaHoja.Llaves[0] = Clave; // Agregamos la clave
                NuevaHoja.DireccionLlaves[0] = Direccion; // Agregamos la dirección
                ManejadorArchivo.EscribeNodo(NuevaHoja, archivo, Ruta); // Escribimos el nodo en el archivo de indice
                atributo.Direccion_Indice = NuevaHoja.DirNodo; // Modificamos el atributo para que apunte al unico nodo
                ManejadorArchivo.ModificaAtributo(atributo, RutaArchDicc, archivo); // Escribimos el atributo en el archivo
            }
            else if (!arbol.TieneRaiz()) // En caso de que no tenga Raiz(Solamente una hoja)
            {
                Nodo Hoja = arbol.Nodos[0]; // Como ya leímos el archivo de indices anteriormente ya sabemos que solo hay un nodo en la lista de Nodos del arbol
                List<Nodo> nodos = InsertaEnHoja(Hoja, Ruta, Clave, Direccion); //Llamamos al método que inserta la clave y la dirección en una hoja
                if (nodos.Count == 2) // Como InsertaEnHoja regresa una lista si solo regresa un nodo no se dividió el nodo, si son 2 ocurrió una división
                {
                    //MessageBox.Show("Dividí la hoja unica al momento de la inserción, creando nodo Raiz");
                    Nodo NuevaRaiz = CreaNodo('R', ManejadorArchivo.ObtenUltimaDireccion(Ruta, archivo)); // Creamos el nodo Raiz que va a apuntar a las 2 hojhas
                    NuevaRaiz.DireccionLlaves[0] = nodos[0].DirNodo; // La primera direccion de la raiz va a apuntar a la hoja de la izquierda
                    NuevaRaiz.DireccionLlaves[1] = nodos[1].DirNodo; // La segunda direccion de la raiz va a apuntar a la hoja de la derecha
                    NuevaRaiz.Llaves[0] = nodos[1].Llaves[0]; // Se agrega la llave que se sube a la Raiz a la raiz
                    atributo.Direccion_Indice = NuevaRaiz.DirNodo; // Modificamos la dirección a la que va a apuntar el Ap del indice del atributo
                    ManejadorArchivo.EscribeNodo(NuevaRaiz, archivo, Ruta); // Se escribe el nodo raiz
                    ManejadorArchivo.ModificaAtributo(atributo, RutaArchDicc, archivo); // Se escribe el atributo modificado en el Diccionario de Datos
                }
            }
            else // Ya existe una raíz ( Y puede que existan intermedios también)
            {
                //MessageBox.Show("YA EXISTE RAIZ!");
                Nodo Padre = new Nodo();// Creamos un nodo que va a figurar como el padre
                Nodo Hijo = arbol.ObtenRaiz(); ; // Obtenemos la raiz y por el momento se lo asignamos al nodo Hijo
                do
                {
                    Padre = Hijo; // Lo inicializamos así para que podamos obtener el Padre dependiendo del valor en eñ qie se quedó el hijo
                    int i = Padre.ObtenIndiceClave(Clave);
                    Hijo = arbol.GetNodo(Padre.DireccionLlaves[i]);
                } while (Hijo.TipoNodo != 'H');
                List<Nodo> Res = InsertaEnHoja(Hijo, Ruta, Clave, Direccion);
                if (Res.Count == 2) // En caso de que la hoja se dividió (Es necesario subir una clave al nodo Padre en cuestión)
                {
                    ActualizaNodoPadre(Padre, Res[1].Llaves[0],Res[1].DirNodo , arbol, Ruta, RutaArchDicc,atributo); // Actualizamos los valores del nodo padre con la dir de la nueva hoja y su llave
                }
            }
        }

        public List<Nodo> InsertaEnHoja(Nodo Hoja, string Ruta, int Clave, long Direccion)
        {
            List<Nodo> Nodos = new List<Nodo>();
            if (!Hoja.InsertaOrdenadoEnHoja(Clave, Direccion)) // Ya no hay espacio en la hoja (No se pudo realizar la inserción)
            {
                //MessageBox.Show("Estoy dividiendo la hoja");
                List<Nodo> NodosDivision = DivideHoja(Hoja, Clave, Direccion, Ruta);
                ManejadorArchivo.EscribeNodo(NodosDivision[0], archivo, Ruta);
                ManejadorArchivo.EscribeNodo(NodosDivision[1], archivo, Ruta);
                return NodosDivision;
            }
            else
            {
                ManejadorArchivo.EscribeNodo(Hoja, archivo, Ruta);
                Nodos.Add(Hoja);
                return Nodos;
            }
        }

        public List<Nodo> DivideHoja(Nodo Nodo, int Clave, long Direccion, string Ruta)
        {
            Nodo Nuevo = CreaNodo('H', ManejadorArchivo.ObtenUltimaDireccion(Ruta, archivo)); // Creamos el nodo que es la nueva hoja
            int iDivisor = ((Arbol.GradoArbol - 1 ) / 2) - 1; // Este es el indice del item que va a dividir la hoja(La posición 2)
            List<long> AuxLong = new List<long>(); //Lista Auxiliar de llaves validas
            List<int> AuxInt = new List<int>(); // Lista Auxiliar de apuntadores validos

            foreach (int i in Nodo.Llaves)
            {
                AuxInt.Add(i);
            }
            foreach (long l in Nodo.DireccionLlaves)
            {
                AuxLong.Add(l);
            }
   
            AuxInt.Add(Clave); // Se agrega la llave a insertar
            AuxInt.Sort(); // Se ordena

            Nodo N1 = new Nodo(); // Se crea un nuevo Nodo que va a ser la hoja a dividir
            N1.TipoNodo = Nodo.TipoNodo; 
            N1.DirNodo = Nodo.DirNodo;
            N1.DireccionLlaves[Arbol.GradoArbol - 1] = Nodo.DireccionLlaves[Arbol.GradoArbol - 1];

            int AuxViejo = 0;
            int AuxNuevo = 0; // Variables que nos sirven para hacer el recorrido en las listas y copiar los datos
            int AuxTemp = 0;
            for (int i = 0; i < Arbol.GradoArbol; i++) 
            {
                if (i <= iDivisor) // Si i es menor que la llave en la posición que divide la hoja
                {
                    if (AuxInt[i] == Clave)
                    {
                        N1.DireccionLlaves[AuxViejo] = Direccion;
                    }
                        
                    else
                    {
                        N1.DireccionLlaves[AuxViejo] = AuxLong[AuxTemp];
                        AuxTemp++;
                    }    
                    N1.Llaves[AuxViejo++] = AuxInt[i];
                }
                else // Si ya estamos en los datos que se deben de copiar a la hoja nueva
                {
                    if (AuxInt[i] == Clave)
                    {
                        Nuevo.DireccionLlaves[AuxNuevo] = Direccion;
                    }

                    else
                    {
                        Nuevo.DireccionLlaves[AuxNuevo] = AuxLong[AuxTemp];
                        AuxTemp++;
                    }
                    Nuevo.Llaves[AuxNuevo++] = AuxInt[i];
                }
            }

            Nuevo.DireccionLlaves[Arbol.GradoArbol - 1] = N1.DireccionLlaves[Arbol.GradoArbol - 1];
            N1.DireccionLlaves[Arbol.GradoArbol - 1] = Nuevo.DirNodo;

            return new List<Nodo> { N1, Nuevo }; // Regresamos la lista de nodos nuevos(La hoja dividida y la nueva hoja)
        }

        /*
         *  Método para crear un nuevo Nodo
         * 
         */
        public Nodo CreaNodo(char Tipo, long Direccion)
        {
            Nodo Nuevo = new Nodo();
            Nuevo.TipoNodo = Tipo;
            Nuevo.DirNodo = Direccion;
            return Nuevo;
        }

        public void ActualizaNodoPadre(Nodo Padre, int Clave, long Direccion, Arbol a, string Ruta, string RutaArchDicc, Atributo A)
        {
            if(Padre.InsertaOrdenadoEnRaiz(Clave, Direccion)) // En caso de que el padre todavía tenga espacio
            {
                ManejadorArchivo.EscribeNodo(Padre, archivo, Ruta);
            }
            else
            {
                char TipoNodo = Padre.TipoNodo;
                if(TipoNodo == 'R') // El padre se vuelve intermedio
                {
                    Padre.TipoNodo = 'I';
                }
                List<int> AuxInt = new List<int>();
                foreach(int i in Padre.Llaves)
                {
                    AuxInt.Add(i);
                }
                AuxInt.Add(Clave); // Se inserta la primera clave del nuevo nodo
                AuxInt.Sort();
                int IndiceDivisorio = (Arbol.GradoArbol - 1) / 2;
                int ClaveASubir = AuxInt[IndiceDivisorio];
                List<Nodo> Intermedios = DivideRaiz(Clave, Direccion, AuxInt, Padre, Ruta);

                ManejadorArchivo.EscribeNodo(Intermedios[0], archivo, Ruta);
                ManejadorArchivo.EscribeNodo(Intermedios[1], archivo, Ruta);

                if(TipoNodo == 'R') // En caso de que el nodo que se dividió era raiz
                {
                    Nodo NuevaRaiz = CreaNodo('R', ManejadorArchivo.ObtenUltimaDireccion(Ruta, archivo));
                    NuevaRaiz.DireccionLlaves[0] = Intermedios[0].DirNodo;
                    NuevaRaiz.DireccionLlaves[1] = Intermedios[1].DirNodo;
                    NuevaRaiz.Llaves[0] = ClaveASubir;
                    A.Direccion_Indice = NuevaRaiz.DirNodo;
                    ManejadorArchivo.ModificaAtributo(A, RutaArchDicc, archivo);
                    ManejadorArchivo.EscribeNodo(NuevaRaiz, archivo, Ruta);
                }
                else
                {
                    Nodo PadreTemp = a.ObtenNodoPadre(Intermedios[0]);
                    ActualizaNodoPadre(PadreTemp, ClaveASubir, Intermedios[1].DirNodo,
                        new Arbol(ManejadorArchivo.ObtenNodos(A, archivo, Ruta),A), Ruta, RutaArchDicc, A);
                }
            }
        }

        public List<Nodo> DivideRaiz(int Clave, long Direccion, List<int> ClavesOrdenadas, Nodo nodo, string Ruta)
        {
            Nodo Nuevo = CreaNodo(nodo.TipoNodo, ManejadorArchivo.ObtenUltimaDireccion(Ruta, archivo));
            int IndiceDivisor = (Arbol.GradoArbol - 1) / 2;
            Nodo N1 = new Nodo();
            List<long> AuxLong = new List<long>();

            foreach(long l in nodo.DireccionLlaves)
            {
                AuxLong.Add(l);
            }
            N1.TipoNodo = nodo.TipoNodo;
            N1.DirNodo = nodo.DirNodo;

            int IndiceValorCentral = nodo.Llaves.IndexOf(ClavesOrdenadas[IndiceDivisor]) + 1; // Aquí obtenemos el dato que vamos a subir

            N1.DireccionLlaves[0] = AuxLong[0];
            Nuevo.DireccionLlaves[0] = AuxLong[IndiceValorCentral];

            AuxLong.RemoveAt(IndiceValorCentral);
            AuxLong.RemoveAt(0);
            int AuxViejo = 0, AuxNuevo = 0, AuxTemp = 0;
            for (int i = 0; i < Arbol.GradoArbol; i++)
            {
                if (i < IndiceDivisor)
                {
                    if (ClavesOrdenadas[i] == Clave)
                        N1.DireccionLlaves[AuxViejo + 1] = Direccion;
                    else
                        N1.DireccionLlaves[AuxViejo + 1] = AuxLong[AuxTemp++];
                    N1.Llaves[AuxViejo++] = ClavesOrdenadas[i];
                }
                else if(i > IndiceDivisor)
                {
                    if (ClavesOrdenadas[i] == Clave)
                        Nuevo.DireccionLlaves[AuxNuevo + 1] = Direccion;
                    else
                        Nuevo.DireccionLlaves[AuxNuevo + 1] = AuxLong[AuxTemp++];
                    Nuevo.Llaves[AuxNuevo++] = ClavesOrdenadas[i];
                }
            }
            return new List<Nodo> { N1, Nuevo };
        }
    }
}
