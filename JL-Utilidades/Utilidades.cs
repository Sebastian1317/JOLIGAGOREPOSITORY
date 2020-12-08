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
    }
}
