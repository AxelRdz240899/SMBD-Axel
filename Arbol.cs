using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
namespace Proyecto_Archivos
{
    class Arbol
    {
        public const int GradoArbol = 5;
        //Archivo ManejadorArchivo;
        public Atributo AtributoArbol;
        public List<Nodo> Nodos;
        public Arbol(List<Nodo> Nodos, Atributo A)
        {
            this.Nodos = Nodos;
            AtributoArbol = A;
        }

        public bool TieneRaiz()
        {
            foreach (Nodo n in Nodos)
            {
                if (n.TipoNodo == 'R')
                {
                    return true;
                }
            }
            return false;
        }

        public Nodo ObtenRaiz()
        {
            foreach (Nodo n in Nodos)
            {
                if (n.TipoNodo == 'R')
                {
                    return n;
                }
            }
            return null;
        }


        public Nodo GetNodo(long Direccion)
        {
            foreach (Nodo n in Nodos)
            {
                if (n.DirNodo == Direccion)
                {
                    return n;
                }
            }
            return null;
        }

        public Nodo ObtenNodoPadre(Nodo Hijo)
        {
            foreach(var nodo in Nodos)
            {
                foreach(long item in nodo.DireccionLlaves)
                {
                    if(item == Hijo.DirNodo)
                    {
                        return nodo;
                    }
                }
            }
            return null;
        }

        public bool ContieneClaveEnHojas(int Clave)
        {
            foreach(Nodo nodo in Nodos)
            {
                if(nodo.TipoNodo == 'H' && nodo.Llaves.Contains(Clave))
                {
                    return true;
                }
            }
            return false;
        }

        public long ObtenDireccionDeHoja(int Clave)
        {
            foreach(Nodo nodo in Nodos)
            {
                if(nodo.TipoNodo == 'H' && nodo.Llaves.Contains(Clave))
                {
                    int indice = nodo.Llaves.IndexOf(Clave);
                    return nodo.DireccionLlaves[indice];
                }
            }
            return -1;
        }

        public Nodo ObtenNodoConLaClave(int Clave)
        {
            foreach(Nodo nodo in Nodos)
            {
                if(nodo.TipoNodo == 'H' && nodo.Llaves.Contains(Clave))
                {
                    return nodo;
                }
            }
            return null;
        }

        public Nodo ObtenNodoVecinoIzq(Nodo nodo)
        {
            Nodo NodoPadre = ObtenNodoPadre(nodo);
            int indice = NodoPadre.DireccionLlaves.IndexOf(nodo.DirNodo);
            if (indice != 0)
            {
                return GetNodo(NodoPadre.DireccionLlaves[indice - 1]);
            }
            else
            {
                return null;
            }
        }

        public Nodo ObtenNodoVecinoDer(Nodo nodo)
        {
            Nodo NodoPadre = ObtenNodoPadre(nodo);
            int indice = NodoPadre.DireccionLlaves.IndexOf(nodo.DirNodo);
            if(indice < NodoPadre.DireccionLlaves.Count - 1)
            {
                return GetNodo(NodoPadre.DireccionLlaves[indice + 1]);
            }
            else
            {
                return null;
            }
        }

        public bool ChecaSiTienenElMismoPadre(Nodo N1, Nodo N2)
        {
            Nodo NodoPadre = ObtenNodoPadre(N1);
            return NodoPadre.DireccionLlaves.Contains(N2.DirNodo);
        }
    }
}