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

        public static void MostrarFormulario<T>(Panel panel,Form formulario)where T : Form {

            
            //formulario = new T();
            formulario.TopLevel = false;
            panel.Controls.Add(formulario);
            panel.Tag = formulario;
            formulario.Show();

        }

    }
}
