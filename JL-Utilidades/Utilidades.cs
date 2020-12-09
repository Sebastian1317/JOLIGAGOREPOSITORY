using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JL_Utilidades
{
   public class Utilidades
    {

        public static DataGridView cargarGrid<T>(List<T> entidad, DataGridView datagrid) where T : class
        {
            if (entidad != null) {
                datagrid.DataSource = null;
                datagrid.DataSource = entidad;
                return datagrid;
            }
            else {
                return null;
            }
        }

        public static ComboBox cargarComboBox<T>(List<T> entidad, ComboBox comboBox,
            String id,String nombre) where T : class{


            if (entidad.Count > 0)
            {   
                comboBox.DisplayMember = nombre;
                comboBox.ValueMember = id;
                comboBox.DataSource = entidad;

                return comboBox;
            }
            else {

                return comboBox;
            }



        }



    }
}
