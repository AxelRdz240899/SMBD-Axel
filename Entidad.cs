using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Archivos
{
    public class Entidad
    {
        //char[] Nombre_Entidad;
        public byte[] Clave { get; set; }
        public string AuxClave { get; set; }
        public char[] Nombre_Entidad { get; set; }
        public long Direccion_Entidad { get; set; }
        public long Direccion_Atributo { get; set; }
        public long Direccion_Dato { get; set; }
        public long Dir_SigEntidad { get; set; }
        public List<Atributo> Atributos;
        public List<Registro> Registros;
        public List<Relacion> Relaciones;

        public Entidad(byte[] clave, char[] Nombre_Ent, long D_Ent, long D_Atr, long D_Dato, long D_DirSigEnt)
        {
            Clave = clave;
            AuxClave = ClaveEnString();
            Nombre_Entidad = new char[35];
            Nombre_Entidad = Nombre_Ent;
            Direccion_Entidad = D_Ent;
            Direccion_Atributo = D_Atr;
            Direccion_Dato = D_Dato;
            Dir_SigEntidad = D_DirSigEnt;
            Atributos = new List<Atributo>();
            Registros = new List<Registro>();
            Relaciones = new List<Relacion>();
        }
        public string ObtenCadenaNombre()
        {
            string Nombre = "";
            foreach (char c in Nombre_Entidad)
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
            string C = BitConverter.ToString(Clave);
            return C;
        }
    }

}
