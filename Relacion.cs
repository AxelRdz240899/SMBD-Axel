using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Archivos
{
    public class Relacion
    {
        public string NombreTablaPadre;
        public string NombreAtributoTablaPadre;
        public string NombreAtributoTablaHijo;
        /// <summary>
        /// NombreTabla = Nombre de la tabla Padre de la relación
        /// NombreAtributo = Nombre del atributo de la tabla Padre de la relación
        /// Pos = Posición del Atributo nuevo de la tabla Hija
        /// </summary>
        /// <param name="NombreTabla"></param>
        /// <param name="NombreAtributo"></param>
        /// <param name="Pos"></param>
        public Relacion(string NombreTabla, string NombreAtributo, string NombreAtributoHijo)
        {
            this.NombreTablaPadre = NombreTabla;
            this.NombreAtributoTablaPadre = NombreAtributo;
            this.NombreAtributoTablaHijo = NombreAtributoHijo;
        }
    }
}
