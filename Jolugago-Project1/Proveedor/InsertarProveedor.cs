using JL_Capa_De_Negocio;
using JL_Entidades;
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
    public partial class InsertarProveedor : Form
    {
        public InsertarProveedor()
        {
            InitializeComponent();

            cbActivo.Checked = true;
            cbDes.Checked = false;
        }

        private BD_Proveedor proveedor = null;
        private CN_Proveedor cnproveedor = null;

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            cnproveedor = new CN_Proveedor();
            if (
            cnproveedor.insertarProveedor(
            proveedor = new BD_Proveedor(0, txtNombre.Text, txtDireccion.Text, txtNumTel.Text,
            "Rubro", txtRFC.Text,
            txtCorreo.Text, txtContacto.Text, txtLogo.Text.Trim(), ((cbActivo.Checked)?"Activo":"Desactivado"))
                ))
            {
                MessageBox.Show("Se inserto correctamente");
            }
            else {
                MessageBox.Show("No se inserto correctamente");

            }

        }

        private void cbDes_Click(object sender, EventArgs e)
        {
            if (this.cbDes.Checked) {

                cbActivo.Checked = false;
            }
        }

        private void cbActivo_Click(object sender, EventArgs e)
        {
            if (this.cbActivo.Checked)
            {
                cbDes.Checked = false;

            }
        }
    }
}
