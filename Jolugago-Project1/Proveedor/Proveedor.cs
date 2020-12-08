using JL_Capa_De_Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jolugago_Project1.Proveedor
{
    public partial class Proveedor : Form
    {
        public Proveedor()
        {
            InitializeComponent();

            CargarDatos(dwProveedores);
        }

        private CN_Proveedor cnproveedor = null;

        private void CargarDatos(DataGridView data)
        {
            cnproveedor = new CN_Proveedor();
            cnproveedor.llenarProveedores(data);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            InsertarProveedor insertar = new InsertarProveedor();

            insertar.ShowDialog();
        }

        private void bunifuTextbox1_OnTextChange(object sender, EventArgs e)
        {
            if (bunifuTextbox1.text != "")
            {
                cnproveedor = new CN_Proveedor();
                cnproveedor.llenarProveedoresPor(this.dwProveedores, bunifuTextbox1.text);
            }
            else {
                cnproveedor.llenarProveedores(this.dwProveedores);
            }
        }
    }
}
