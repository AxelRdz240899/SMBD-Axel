using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Archivos
{
    public class Registro
    {
        public List<byte[]> Informacion; 
        public long Direccion;
        public long DireccionSiguiente;

        public Registro()
        {
            Informacion = new List<byte[]>();
        }
    }
}
