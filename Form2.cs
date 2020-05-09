using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Archivos
{
    public partial class Form2 : Form
    {
        public bool Finalizado = false;
        List<Entidad> Entidades;
        public Form2(List<Entidad> ListaEntidades, Entidad EntidadActual)
        {
            InitializeComponent();
            Entidades = ListaEntidades;
            CargaEntidades(EntidadActual);
        }

        private void CargaEntidades(Entidad Actual)
        {
            foreach (Entidad e in Entidades)
            {
                if(e.ObtenCadenaNombre() != Actual.ObtenCadenaNombre())
                {
                    foreach (Atributo a in e.Atributos)
                    {
                        if (a.Tipo_Llave == 'P')
                        {
                            ComboB_EntidadFK.Items.Add(e.ObtenCadenaNombre());
                        }
                    }
                }
            }
        }

        private void ComboB_EntidadFK_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboB_AtributosFK.Items.Clear();
            foreach (Atributo a in Entidades.ElementAt(ComboB_EntidadFK.SelectedIndex).Atributos)
            {
                if (a.Tipo_Llave == 'P')
                {
                    ComboB_AtributosFK.Items.Add(a.ObtenCadenaNombre());
                }
            }
        }
        public Atributo ObtenAtributo()
        {
            Atributo ARes = null;
            if (ComboB_EntidadFK.SelectedIndex != -1)
            {
                if (ComboB_AtributosFK.SelectedIndex != -1)
                {
                    
                    ARes = ObtenEntidad().Atributos.ElementAt(ComboB_AtributosFK.SelectedIndex);
                }
            }
            return ARes;
        }
        public Entidad ObtenEntidad()
        {
            Entidad ERes = null;
            if (ComboB_EntidadFK.SelectedIndex != -1)
            {
                if (ComboB_AtributosFK.SelectedIndex != -1)
                {
                    foreach (Entidad e in Entidades)
                    {
                        if(e.ObtenCadenaNombre() == ComboB_EntidadFK.Text)
                        {
                            ERes = e;
                        }
                    }
                }
            }
            return ERes;
        }
    }
}
