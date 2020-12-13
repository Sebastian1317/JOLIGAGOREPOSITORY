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

        public static void cargarCabecera<T>(String[] cabeceras,DataGridView dataGridView)where T : class {


            foreach (var cabecera in cabeceras)
            {
                dataGridView.Columns.Add(cabecera, cabecera);
            }
        }

        public static void cargarComboBox<T>(List<T> entidad, ComboBox comboBox,
            String id,String nombre) where T : class{
            
            if (entidad.Count > 0)
            {   
                comboBox.DisplayMember = nombre;
                comboBox.ValueMember = id;
                comboBox.DataSource = entidad;

            }
            
        }

        public static void cargarComboSinBaseDatos<T>(Dictionary<T,T>entidad,ComboBox comboBox)where T :class {

            if (entidad.Count > 0 ) {

                comboBox.DisplayMember ="Value";
                comboBox.ValueMember = "Key";
                comboBox.DataSource = new BindingSource(entidad,null);

            }
        }

        public static String urlArchvio()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                //openFileDialog.Filter = "*.png|*.jpg|*.jpeg|*.gif";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    return openFileDialog.FileName;

                }
                else {

                    return "";
                }

            }

    }
        public static String urlCarpetas()
        {
            using (var fd = new FolderBrowserDialog())
            {

                if (fd.ShowDialog() == System.Windows.Forms.DialogResult.OK && !string.IsNullOrWhiteSpace(fd.SelectedPath))
                {
                    return fd.SelectedPath;
                }
                else
                {

                    return "";
                }
            }

        }

    }
}
