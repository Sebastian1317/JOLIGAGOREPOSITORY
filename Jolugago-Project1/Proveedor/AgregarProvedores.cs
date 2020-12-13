using JL_Capa_De_Negocio;
using JL_Entidades;
using JL_Utilidades;
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
    public partial class AgregarProvedores : Form
    {


        private BD_Proveedor proveedor = null;
        private CN_Proveedor cnproveedor = null;
        private int id_Proveedor=0;

        public AgregarProvedores()
        {
            InitializeComponent();
            cbActivo.Checked = true;
            cbDes.Checked = false;
        }
        public AgregarProvedores(BD_Proveedor _Proveedor) {

            InitializeComponent();

            btnRegistrar.ButtonText = "Actualizar";
            id_Proveedor = _Proveedor.idProvee;
            ModificarProveedor(_Proveedor);

        }

        
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            cnproveedor = new CN_Proveedor();
            if (btnRegistrar.ButtonText != "Registrar")
            {
                if (
                    cnproveedor.actualizarProveedor(new BD_Proveedor(id_Proveedor, txtNombre.Text, txtDireccion.Text, txtNumTel.Text,
            "Rubro", txtRFC.Text,
            txtCorreo.Text, txtContacto.Text, txtLogo.Text.Trim(), ((cbActivo.Checked) ? "Activo" : "Desactivado")))
                    
                    ) {
                    MessageBox.Show("Se actualizo el proveedor correctamente");
                    Proveedor proveedor = new Proveedor();
                    MostrarFormularios.MostrarFormulario(Panel_Principal.panelCargar, proveedor);
                    this.Dispose();
                }
            }
            else { 
            
            if (
            cnproveedor.insertarProveedor(
            proveedor = new BD_Proveedor(0, txtNombre.Text, txtDireccion.Text, txtNumTel.Text,
            "Rubro", txtRFC.Text,
            txtCorreo.Text, txtContacto.Text, txtLogo.Text.Trim(), ((cbActivo.Checked) ? "Activo" : "Desactivado"))
                ))
            {
                MessageBox.Show("Se inserto correctamente");
                Proveedor proveedor = new Proveedor();
                MostrarFormularios.MostrarFormulario(Panel_Principal.panelCargar, proveedor);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("No se inserto correctamente");

            }
            }
        }

        private void cbActivo_Click(object sender, EventArgs e)
        {
            if (this.cbActivo.Checked)
            {
                cbDes.Checked = false;

            }
        }

        private void cbDes_Click(object sender, EventArgs e)
        {
            if (this.cbDes.Checked)
            {

                cbActivo.Checked = false;
            }
        }

        private void btnBuscador_Click(object sender, EventArgs e)
        {
            txtLogo.Text =Utilidades.urlArchvio();

            if (txtLogo.Text != "")
            {
                pbProveedor.Image = new System.Drawing.Bitmap(txtLogo.Text);
                pbProveedor.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else {
                MessageBox.Show("No se cargo ninguna imagen");
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            
            Proveedor proveedor = new Proveedor();
            MostrarFormularios.MostrarFormulario(Panel_Principal.panelCargar, proveedor);
            this.Dispose();

        }

        private void ModificarProveedor(BD_Proveedor proveedor) {
            txtNombre.Text = proveedor.nombre;
            txtCorreo.Text = proveedor.correo;
            txtContacto.Text = proveedor.contacto;
            txtRFC.Text = proveedor.rfc;
            txtLogo.Text = proveedor.foto_logo;
            if (txtLogo.Text != "") {
                pbProveedor.Image = new System.Drawing.Bitmap(txtLogo.Text);
                pbProveedor.SizeMode = PictureBoxSizeMode.Zoom;
            }
            txtNombre.Text = proveedor.nombre;
            txtDireccion.Text = proveedor.direccion;
            txtNumTel.Text = proveedor.telefono;
            if (proveedor.estado_provdr == "Activo")
            {
                cbActivo.Checked = true;
                cbDes.Checked = false;
            }
            else {
                cbActivo.Checked = false;
                cbDes.Checked = true;
            }
        }


    }
}
