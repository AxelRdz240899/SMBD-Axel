using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Proyecto_Archivos
{
    class Nodo
    {
        public char TipoNodo { get; set; }
        public long DirNodo { get; set; }
        public List<int> Llaves { get; set; }
        public List<long> DireccionLlaves { get; set; }

        public Nodo()
        {
            Llaves = new List<int>();
            DireccionLlaves = new List<long>();
            for (int i = 0; i < Arbol.GradoArbol; i++)
            {
                DireccionLlaves.Add(-1);
                if (i != Arbol.GradoArbol - 1)
                    Llaves.Add(-1);
            }
        }
        public bool InsertaOrdenadoEnHoja(int Clave, long Direccion) // Este método inserta ordenado en la hoja
        {
           if(ObtenNumeroLlavesValidas() < Arbol.GradoArbol - 1)
           {
                List<int> AuxInt = new List<int>();
                List<long> AuxLong = new List<long>();

                foreach(int i in Llaves) // Guardamos las llaves validas en una lista auxiliar para poder acomodarlas luego
                {
                    if(i != -1)
                    {
                        AuxInt.Add(i);
                    }
                }
                foreach (long l in DireccionLlaves) // Guardamos las direcciones validas en una lista auxiliar para poder acomodarlas luego
                {
                    if (l!= -1)
                    {
                        AuxLong.Add(l);
                    }
                }

                AuxInt.Add(Clave); // Se agrega la clave a insertar en el árbol
                AuxInt.Sort(); // Se ordena la lista Auxiliar
                 
                int j = 0; // Contador que nos sirve para asignar 
                for(int i = 0; i < AuxInt.Count; i++)
                {
                    Llaves[i] = AuxInt[i];
                    if(AuxInt[i] != Clave)
                    {
                        DireccionLlaves[i] = AuxLong[j++];
                    }
                    else
                    {
                        DireccionLlaves[i] = Direccion;
                    }
                }
               return true;
           }
           else
           {
               return false;
           }
        }
        public int ObtenNumeroLlavesValidas() // Este método regresa el número de llaves validas
        {
            int i = 0;
            foreach (var item in Llaves)
            {
                if (item != -1) { i++; }
            }
            return i;
        }
        public bool InsertaOrdenadoEnRaiz(int Llave, long Direccion) // Este método inserta ordenado en un nodo tipo raiz o intermedio
        {
            if(ObtenNumeroLlavesValidas() < Arbol.GradoArbol - 1)
            {
                List<int> AuxInt = new List<int>();
                List<long> AuxLong = new List<long>();
                foreach (int item in Llaves)
                {
                    if(item != -1) { AuxInt.Add(item); }
                }
                foreach(long item in DireccionLlaves)
                {
                    if(item != -1) { AuxLong.Add(item); }
                }

                if (AuxLong.Count > 1) { AuxLong.RemoveAt(0); } // Esta dirección se elimina porque nunca se pierde la primera dirección 

                AuxInt.Add(Llave);
                AuxInt.Sort();

                int j = 0;

                for (int i = 0; i < AuxInt.Count; i++)
                {
                    Llaves[i] = AuxInt[i];
                    if (AuxInt[i] != Llave)
                    {
                        DireccionLlaves[i + 1] = AuxLong[j++];
                    }
                    else
                    {
                        DireccionLlaves[i + 1] = Direccion;
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool EliminaDatoEnHoja(int Clave)
        {
            if (Llaves.Contains(Clave))
            {
                int Indice = Llaves.IndexOf(Clave);
                long SigNodo = DireccionLlaves[Arbol.GradoArbol - 1];
                DireccionLlaves[Arbol.GradoArbol - 1] = (long)-1;

                Llaves.RemoveAt(Indice);
                DireccionLlaves.RemoveAt(Indice);
                Llaves.Add(-1);
                DireccionLlaves.Add(SigNodo);
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool EliminaEnNodoRaiz(int Clave, long Direccion)
        {
            if(Llaves.Contains(Clave) && DireccionLlaves.Contains(Direccion))
            {
                DireccionLlaves.Remove(Direccion);
                Llaves.Remove(Clave);
                DireccionLlaves.Add((long)-1);
                Llaves.Add(-1);
                return true;
            }
            else
            {
                return false;
            }
        }
        public long ObtenApuntadorHoja(int dato)
        {
            return DireccionLlaves[Llaves.IndexOf(dato)];
        }

        public int ObtenIndiceClave(int Clave)
        {
            if(Llaves.Count == 1)
            {
                return 0;
            }
            int i;
            for (i = 0; i < Arbol.GradoArbol - 1; i++)
            {
                if (Clave < Llaves[i] || Llaves[i] == -1)
                {
                    return i;
                }
            }
            return i;
        }
    }
}
