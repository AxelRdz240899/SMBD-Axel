using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_Archivos
{
    class Archivo
    {
        public Archivo()
        {

        }

        #region Métodos para Entidad
        public void GuardaEntidad(Entidad e, string Ruta, FileStream archivo)
        {
            archivo = File.Open(Ruta, FileMode.Open, FileAccess.Write, FileShare.None);
            archivo.Position = archivo.Length;
            BinaryWriter Escritor = new BinaryWriter(archivo);
            Escritor.Write(e.Clave);
            Escritor.Write(e.Nombre_Entidad);
            Escritor.Write(e.Direccion_Entidad);
            Escritor.Write(e.Direccion_Atributo);
            Escritor.Write(e.Direccion_Dato);
            Escritor.Write(e.Dir_SigEntidad);
            archivo.Close();
        }

        public void ModificaEntidad(Entidad e, string Ruta, FileStream archivo)
        {
            archivo = File.Open(Ruta, FileMode.Open, FileAccess.Write, FileShare.None);
            archivo.Seek(e.Direccion_Entidad, SeekOrigin.Begin);
            BinaryWriter Escritor = new BinaryWriter(archivo);
            Escritor.Write(e.Clave);
            Escritor.Write(e.Nombre_Entidad);
            Escritor.Write(e.Direccion_Entidad);
            Escritor.Write(e.Direccion_Atributo);
            Escritor.Write(e.Direccion_Dato);
            Escritor.Write(e.Dir_SigEntidad);
            archivo.Close();
        }
        public long ObtenCabecera(string Ruta, FileStream archivo)
        {
            archivo = File.Open(Ruta, FileMode.Open, FileAccess.Read, FileShare.None);
            archivo.Seek(0, SeekOrigin.Begin);
            BinaryReader lector = new BinaryReader(archivo);
            long cabecera = lector.ReadInt64();
            archivo.Close();
            //MessageBox.Show("Estoy obteniendo la cabecera");
            return cabecera;
        }

        public void ActualizaCabecera(string Ruta, FileStream archivo, long direccion)
        {
            archivo = File.Open(Ruta, FileMode.Open, FileAccess.Write, FileShare.None);
            archivo.Seek(0, SeekOrigin.Begin);
            BinaryWriter Escritor = new BinaryWriter(archivo);
            Escritor.Write(direccion);
            archivo.Close();
        }
        #endregion

        #region Métodos para atributo
        public void ModificaAtributo(Atributo a, string Ruta, FileStream archivo)
        {
            archivo = File.Open(Ruta, FileMode.Open, FileAccess.Write, FileShare.None);
            archivo.Seek(a.Direccion_Atributo, SeekOrigin.Begin);
            BinaryWriter Escritor = new BinaryWriter(archivo);
            Escritor.Write(a.ClaveAtributo);
            Escritor.Write(a.Nombre_Atributo);
            Escritor.Write(a.Tipo_Atributo);
            Escritor.Write(a.Longitud);
            Escritor.Write(a.Direccion_Atributo);
            Escritor.Write(a.Tipo_Indice);
            Escritor.Write(a.Direccion_Indice);
            Escritor.Write(a.Tipo_Llave);
            Escritor.Write(a.Direccion_SiguienteAtributo);
            archivo.Close();
        }

        public void AgregaAtributo(Atributo a, string Ruta, FileStream archivo)
        {
            archivo = File.Open(Ruta, FileMode.Open, FileAccess.Write, FileShare.None);
            archivo.Position = archivo.Length;
            BinaryWriter Escritor = new BinaryWriter(archivo);
            Escritor.Write(a.ClaveAtributo);
            Escritor.Write(a.Nombre_Atributo);
            Escritor.Write(a.Tipo_Atributo);
            Escritor.Write(a.Longitud);
            Escritor.Write(a.Direccion_Atributo);
            Escritor.Write(a.Tipo_Indice);
            Escritor.Write(a.Direccion_Indice);
            Escritor.Write(a.Tipo_Llave);
            Escritor.Write(a.Direccion_SiguienteAtributo);
            archivo.Close();
        }


        #endregion

        #region Métodos Generales
        public void CreaArchivo(string ruta, FileStream archivo)
        {
            try
            {
                archivo = File.Create(ruta);
                archivo.Close();
            }
            catch (IOException)
            {
                MessageBox.Show("Al parecer el archivo ya existe");
            }
        }

        public List<Entidad> LeeArchivo(long direccionBusqueda, string ruta, FileStream archivo)
        {
            archivo = File.OpenRead(ruta);
            //MessageBox.Show("Estoy leyendo el archivo");
            long DirAux = direccionBusqueda;
            List<Entidad> ListaEntidadesEncontradas = new List<Entidad>();
            while (DirAux != -1)
            {
                archivo.Seek(DirAux, SeekOrigin.Begin);
                BinaryReader lector = new BinaryReader(archivo);
                byte[] Clave = lector.ReadBytes(5);
                char[] NombreEntidad = lector.ReadChars(35);
                long direccionEntidad = lector.ReadInt64();
                long dirA = lector.ReadInt64();
                long dirDat = lector.ReadInt64();
                long DirSigEnt = lector.ReadInt64();
                Entidad NuevaEntidad = new Entidad(Clave, NombreEntidad, direccionEntidad, dirA, dirDat, DirSigEnt);
                ListaEntidadesEncontradas.Add(NuevaEntidad);
                if (dirA != -1) // Si tenemos atributos guardados para esa entidad
                {
                    LeeAtributos(NuevaEntidad, archivo);
                }
                DirAux = DirSigEnt;
            }
            archivo.Close();
            return ListaEntidadesEncontradas;
        }

        public void LeeAtributos(Entidad ent, FileStream archivo)
        {
            long DirAux = ent.Direccion_Atributo;
            while (DirAux != -1)
            {
                archivo.Seek(DirAux, SeekOrigin.Begin);
                BinaryReader lector = new BinaryReader(archivo);
                byte[] Clave = lector.ReadBytes(5);
                char[] NombreAtributo = lector.ReadChars(35);
                char tipoAtributo = lector.ReadChar();
                int longitud = lector.ReadInt32();
                long DirAtributo = lector.ReadInt64();
                int TipoIndice = lector.ReadInt32();
                long DireccionIndice = lector.ReadInt64();
                char TipoLlave = lector.ReadChar();
                long DirSigAtr = lector.ReadInt64();
                Atributo NuevoAtributo = new Atributo(Clave, NombreAtributo, tipoAtributo, longitud, DirAtributo, TipoIndice, DireccionIndice, DirSigAtr, TipoLlave);
                ent.Atributos.Add(NuevoAtributo);
                DirAux = DirSigAtr;
            }
        }

        public void LeeDatos(Entidad ent, string ruta, FileStream archivo)
        {
            ent.Registros.Clear();
            archivo = File.Open(ruta, FileMode.Open, FileAccess.Read, FileShare.None);
            BinaryReader lector = new BinaryReader(archivo);
            long DirAux = ent.Direccion_Dato;
            if (DirAux == -1)
            {
                archivo.Position = 0;
            }
            else
            {
                archivo.Position = DirAux;
            }

            Registro nuevo = new Registro();
            int LongitudRegistro = 0;
            foreach (Atributo A in ent.Atributos)
            {
                LongitudRegistro += A.Longitud;
            }
            LongitudRegistro += 16;
            long NumRegistros = archivo.Length / LongitudRegistro;
            if (archivo.Length >= LongitudRegistro)
            {
                while (DirAux != -1)
                {
                    archivo.Seek(DirAux, SeekOrigin.Begin);
                    long Direccion = lector.ReadInt64();
                    nuevo.Direccion = Direccion;
                    foreach (Atributo A in ent.Atributos)
                    {
                        if (A.getTipoAtributo() == "E")
                        {
                            byte[] NB = lector.ReadBytes(4);
                            nuevo.Informacion.Add(NB);
                            int Numero = BitConverter.ToInt32(NB, 0);
                        }
                        else if (A.getTipoAtributo() == "C")
                        {
                            byte[] CB = lector.ReadBytes(A.Longitud);
                            nuevo.Informacion.Add(CB);
                        }
                        else if (A.getTipoAtributo() == "D")
                        {
                            byte[] NB = lector.ReadBytes(4);
                            nuevo.Informacion.Add(NB);
                        }
                    }
                    DirAux = lector.ReadInt64();
                    nuevo.DireccionSiguiente = DirAux;
                    ent.Registros.Add(nuevo);
                    nuevo = new Registro();
                }
            }
            archivo.Close();
        }
        public long ObtenUltimaDireccion(string ruta, FileStream archivo)
        {
            archivo = File.Open(ruta, FileMode.Open, FileAccess.Read, FileShare.None);
            long direccion = archivo.Length;
            archivo.Close();
            return direccion;
        }
        public void CreaCabecera(string Ruta, FileStream archivo)
        {
            archivo = File.Open(Ruta, FileMode.Open, FileAccess.Write, FileShare.None);
            archivo.Seek(0, SeekOrigin.Begin);
            BinaryWriter Escritor = new BinaryWriter(archivo);
            long direccion = -1;
            Escritor.Write(direccion);
            archivo.Close();
        }

        #endregion

        #region Métodos para registros
        public void AgregaRegistro(Registro R, string Ruta, FileStream archivo)
        {
            archivo = File.Open(Ruta, FileMode.Open, FileAccess.Write, FileShare.None);
            archivo.Position = archivo.Length;
            BinaryWriter Escritor = new BinaryWriter(archivo);
            MessageBox.Show(R.Direccion.ToString());
            Escritor.Write(R.Direccion);
            foreach (byte[] b in R.Informacion)
            {
                Escritor.Write(b);
                //MessageBox.Show("Estoy agregando información del registro con la siguiente longitud: " + b.Length.ToString());
            }
            //MessageBox.Show("Estoy agregando un registro con la siguiente dirección: " + R.DireccionSiguiente.ToString());
            Escritor.Write(R.DireccionSiguiente);
            archivo.Close();
        }
        public void ModificaRegistro(Registro R, string Ruta, FileStream archivo)
        {
            archivo = File.Open(Ruta, FileMode.Open, FileAccess.Write, FileShare.None);
            archivo.Seek(R.Direccion, SeekOrigin.Begin);
            BinaryWriter Escritor = new BinaryWriter(archivo);
            Escritor.Write(R.Direccion);
            foreach (byte[] b in R.Informacion)
            {
                Escritor.Write(b);
            }
            Escritor.Write(R.DireccionSiguiente);
            archivo.Close();
        }
        #endregion
        #region Métodos para indices
        public void EscribeBytesInicialesArchivoIndice(string Ruta, FileStream archivo, long Posicion)
        {
            archivo = File.Open(Ruta, FileMode.Open, FileAccess.Write, FileShare.None);
            archivo.Position = Posicion;
            BinaryWriter Escritor = new BinaryWriter(archivo);
            byte[] Bytes = new byte[2048];
            char[] Caracter = new char[1];
            Caracter[0] = '*';
            for (int i = 0; i < 2048; i++)
            {
                Bytes[i] = Convert.ToByte(Caracter[0]);
            }
            Escritor.Write(Bytes);
            archivo.Close();
        }

        public List<Indice> LeeIndiceBloquePrincipal(string Ruta, FileStream archivo, int TipoDatoIndice, int LongitudDatoIndice) //TipoDatoIndice :1 si es entero , 2 si es cadena.
        {
            List<Indice> Indices = new List<Indice>();
            archivo = File.Open(Ruta, FileMode.Open, FileAccess.Read, FileShare.None);
            archivo.Position = 0;
            BinaryReader Lector = new BinaryReader(archivo);
            bool HayRegistro = false;
            if (Encoding.UTF8.GetString(Lector.ReadBytes(1)) != "*")
            {
                HayRegistro = true;
            }
            while (HayRegistro)
            {
                archivo.Position = archivo.Position - 1;
                Indice NuevoIndice = new Indice();
                NuevoIndice.Desplazamiento = Lector.ReadInt64();
                if (TipoDatoIndice == 1) // Si la llave es un entero
                {
                    int Numero = Lector.ReadInt32();
                    byte[] NumeroEnBytes = BitConverter.GetBytes(Numero);
                    NuevoIndice.Llave = NumeroEnBytes;
                }
                else if (TipoDatoIndice == 2) // SI la llave es una cadena
                {
                    char[] Cadena = Lector.ReadChars(LongitudDatoIndice);
                    byte[] CadenaEnBytes = Encoding.UTF8.GetBytes(Cadena);
                    string c = "";
                    foreach (char C in Cadena)
                    {
                        c += C;
                    }
                    NuevoIndice.Llave = CadenaEnBytes;
                }
                else if (TipoDatoIndice == 3)
                {
                    float Numero = Lector.ReadSingle();
                    byte[] NumeroFEnBytes = BitConverter.GetBytes(Numero);
                    NuevoIndice.Llave = NumeroFEnBytes;
                }
                Indices.Add(NuevoIndice);
                if (Encoding.UTF8.GetString(Lector.ReadBytes(1)) == "*")
                {
                    HayRegistro = false;
                }
            }
            archivo.Close();
            return Indices;
        }


        public long EscribeCajonInicialIndiceSecundario(string Ruta, FileStream archivo, long Posicion)
        {
            long PosicionDireccion;
            archivo = File.Open(Ruta, FileMode.Open, FileAccess.Write, FileShare.None);
            archivo.Position = Posicion;
            PosicionDireccion = archivo.Position;
            BinaryWriter Escritor = new BinaryWriter(archivo);
            byte[] Bytes = new byte[2048];
            char[] Caracter = new char[1];
            Caracter[0] = '*';
            for (int i = 0; i < 2048; i++)
            {
                Bytes[i] = Convert.ToByte(Caracter[0]);
            }
            Escritor.Write(Bytes);
            archivo.Close();
            return PosicionDireccion;
        }

        public List<long> LeeCajonIndiceSecundario(string Ruta, FileStream archivo, long Posicion)
        {
            List<long> Direcciones = new List<long>();
            archivo = File.Open(Ruta, FileMode.Open, FileAccess.Read, FileShare.None);
            archivo.Position = Posicion;
            BinaryReader Lector = new BinaryReader(archivo);
            bool HayDireccion = false;
            if (Encoding.UTF8.GetString(Lector.ReadBytes(1)) != "*")
            {
                HayDireccion = true;
            }
            while (HayDireccion)
            {
                archivo.Position = archivo.Position - 1;
                long Direccion = Lector.ReadInt64();
                Direcciones.Add(Direccion);
                if (Encoding.UTF8.GetString(Lector.ReadBytes(1)) == "*")
                {
                    HayDireccion = false;
                }
            }
            archivo.Close();
            return Direcciones;
        }

        public void EscribeCajonSecundario(string Ruta, FileStream archivo, long Posicion, List<long> Direcciones)
        {
            EscribeCajonInicialIndiceSecundario(Ruta, archivo, Posicion);
            archivo = File.Open(Ruta, FileMode.Open, FileAccess.Write, FileShare.None);
            BinaryWriter Escritor = new BinaryWriter(archivo);
            archivo.Position = Posicion;
            foreach (long l in Direcciones)
            {
                Escritor.Write(l);
            }
            archivo.Close();
        }

        public void EscribeBloqueIndices(string Ruta, FileStream archivo, List<Indice> BloqueIndices, long Posicion)
        {
            if (BloqueIndices.Count > 0)
            {
                EscribeBytesInicialesArchivoIndice(Ruta, archivo, Posicion);
                archivo = File.Open(Ruta, FileMode.Open, FileAccess.Write, FileShare.None);
                BinaryWriter Escritor = new BinaryWriter(archivo);
                archivo.Position = 0;
                foreach (Indice i in BloqueIndices)
                {
                    Escritor.Write(i.Desplazamiento);
                    Escritor.Write(i.Llave);
                }
                archivo.Close();
            }
        }
        #endregion


        #region Métodos para el árbol

        public bool EscribeNodo(Nodo N, FileStream archivo, string RutaArchivoArbol)
        {
            //MessageBox.Show("Estoy escribiendo un nodo en la posicion: " + N.DirNodo);
            archivo = File.Open(RutaArchivoArbol, FileMode.Open, FileAccess.Write, FileShare.None);
            BinaryWriter Escritor = new BinaryWriter(archivo);
            archivo.Position = N.DirNodo;
            Escritor.Write(N.TipoNodo);
            Escritor.Write(N.DirNodo);
            for (int i = 0; i < Arbol.GradoArbol; i++)
            {
                Escritor.Write(N.DireccionLlaves[i]);
                if (i != Arbol.GradoArbol - 1)
                {
                    Escritor.Write(N.Llaves[i]);
                }
            }
            archivo.Close();
            return true;
        }
        public List<Nodo> ObtenNodos(Atributo A, FileStream Archivo, string Ruta)
        {
            List<Nodo> nodos = new List<Nodo>();
            long Dir = A.Direccion_Indice;
            Archivo = File.Open(Ruta, FileMode.Open, FileAccess.Read, FileShare.None);
            BinaryReader Lector = new BinaryReader(Archivo);
            if (Dir != -1)
            {
                Archivo.Position = Dir;
                Nodo Nodo = new Nodo();
                Nodo.TipoNodo = Lector.ReadChar();
                Nodo.DirNodo = Lector.ReadInt64();
                Nodo.DireccionLlaves = new List<long>(); ;
                Nodo.Llaves = new List<int>();

                for (int i = 0; i < Arbol.GradoArbol - 1; i++)
                {
                    Nodo.DireccionLlaves.Add(Lector.ReadInt64());
                    Nodo.Llaves.Add(Lector.ReadInt32());
                }
                Nodo.DireccionLlaves.Add(Lector.ReadInt64());
                nodos.Add(Nodo);
                Archivo.Close();
            }

            else
            {
                Archivo.Close();
                return nodos;
            }


            if (nodos[0].TipoNodo == 'H') // Esto significa que solo hay una hoja
            {
                return nodos;
            }
            else
            {
                List<Nodo> Temporal = ObtenNodosRecursivo(nodos[0], Archivo, Ruta);
                foreach (Nodo n in Temporal)
                {
                    nodos.Add(n);
                }
            }
            return nodos;
        }

        public List<Nodo> ObtenNodosRecursivo(Nodo Nodo, FileStream archivo, string Ruta)
        {
            List<Nodo> Nodos = new List<Nodo>();
            archivo = File.Open(Ruta, FileMode.Open, FileAccess.Read);
            BinaryReader Lector = new BinaryReader(archivo);

            foreach (long Item in Nodo.DireccionLlaves)
            {
                if (Item == -1) break;
                archivo.Position = Item;

                Nodo NuevoNodo = new Nodo();
                NuevoNodo.TipoNodo = Lector.ReadChar();
                NuevoNodo.DirNodo = Lector.ReadInt64();
                NuevoNodo.Llaves = new List<int>();
                NuevoNodo.DireccionLlaves = new List<long>();

                for (int i = 0; i < Arbol.GradoArbol - 1; i++)
                {
                    NuevoNodo.DireccionLlaves.Add(Lector.ReadInt64());
                    NuevoNodo.Llaves.Add(Lector.ReadInt32());
                }
                NuevoNodo.DireccionLlaves.Add(Lector.ReadInt64());
                Nodos.Add(NuevoNodo);
            }
            archivo.Close();
            int NumDensos = Nodos.Count;

            for (int i = 0; i < NumDensos; i++)
            {
                Nodo item = Nodos[i];
                if (item.TipoNodo != 'H')
                {
                    List<Nodo> ListaTemporal;
                    ListaTemporal = ObtenNodosRecursivo(item, archivo, Ruta);
                    foreach (Nodo n in ListaTemporal)
                    {
                        Nodos.Add(n);
                    }
                }
            }
            return Nodos;
        }
        #endregion

        #region Métodos para Relaciones

        public void GuardaRelaciones(List<Entidad> Entidades, string RutaArchivoRelaciones)
        {
            StreamWriter fichero; //Clase que representa un fichero
            fichero = new StreamWriter(RutaArchivoRelaciones, false);
            string CadenaAux = "";
            foreach (Entidad e in Entidades)
            {
                foreach (Relacion r in e.Relaciones)
                {
                    CadenaAux = "";
                    CadenaAux += e.ObtenCadenaNombre() + "\\" + r.NombreAtributoTablaHijo + "\\" + r.NombreTablaPadre + "\\" + r.NombreAtributoTablaPadre;
                    fichero.WriteLine(CadenaAux);
                }
            }
            fichero.Close();
        }

        public void CargaRelaciones(List<Entidad> Entidades, FileStream Archivo, string RutaArchivoRelaciones)
        {
            StreamReader Lector;
            Lector = new StreamReader(RutaArchivoRelaciones);
            string Linea = "";

            while ((Linea = Lector.ReadLine()) != null)
            {
                string[] CadenaAux = Linea.Split('\\');
                foreach (Entidad e in Entidades)
                {
                    if (e.ObtenCadenaNombre() == CadenaAux[0])
                    {
                        e.Relaciones.Add(new Relacion(CadenaAux[2], CadenaAux[3], CadenaAux[1]));
                    }
                }
            }
            #endregion
        }
    }
}
