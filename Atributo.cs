using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Archivos
{
    public class Atributo
    {
        public byte[] ClaveAtributo { get; set; }
        public string AuxClave { get; set; }
        public char[] Nombre_Atributo { get; set; }
        public char Tipo_Atributo { get; set; }
        public int Longitud { get; set; }
        public long Direccion_Atributo { get; set; }
        public int Tipo_Indice { get; set; }
        public long Direccion_Indice { get; set; }
        public long Direccion_SiguienteAtributo { get; set; }
        public char Tipo_Llave { get; set; }

        public Atributo(byte[] clave, char[] Nombre, char tipo, int Long, long Dir_Atr, int Tipo_Indice, long Dir_Indice, long Dir_Sig, char TipoLlave)
        {
            ClaveAtributo = clave;
            AuxClave = ClaveEnString();
            Nombre_Atributo = new char[35];
            Nombre_Atributo = Nombre;
            Tipo_Atributo = tipo;
            Longitud = Long;
            Direccion_Atributo = Dir_Atr;
            this.Tipo_Indice = Tipo_Indice;
            Direccion_Indice = Dir_Indice;
            Direccion_SiguienteAtributo = Dir_Sig;
            Tipo_Llave = TipoLlave;
        }
        public string ObtenCadenaNombre()
        {
            string Nombre = "";
            foreach (char c in Nombre_Atributo)
            {
                if (char.IsLetterOrDigit(c))
                {
                    Nombre += c;
                }
            }
            return Nombre;
        }

        public string ClaveEnString()
        {
            string C = BitConverter.ToString(ClaveAtributo);
            return C;
        }

        public string getTipoAtributo()
        {
            string C = Tipo_Atributo.ToString();
            return C;
        }

        public string getTipoIndice()
        {
            string C = Tipo_Indice.ToString();
            return C;
        }
    }
}
