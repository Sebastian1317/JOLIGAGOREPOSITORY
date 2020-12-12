using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JL_Utilidades
{
   public class MostrarFormularios
    {

        public static Form MostrarFormulario(Panel panel,Form formulario) {

            if (panel.Controls.Count > 0)
            {
                panel.Controls.Clear();
            }
            
            formulario.TopLevel = false;
            panel.Controls.Add(formulario);
            panel.Tag = formulario;            
            formulario.Show();

            return formulario;

        }

    }
}
