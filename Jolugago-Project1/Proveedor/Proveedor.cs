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
    public partial class Proveedor : Form
    {
        public Proveedor()
        {
            InitializeComponent();

            CargarDatos(dgvProveedores);
        }

        private CN_Proveedor cnproveedor = null;

        private void CargarDatos(DataGridView data)
        {
            cnproveedor = new CN_Proveedor();
            cnproveedor.llenarProveedores(data);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //AgregarProvedores insertar = new AgregarProvedores();

            //insertar.ShowDialog();
        }

        private void bunifuTextbox1_OnTextChange(object sender, EventArgs e)
        {
            if (bunifuTextbox1.text != "")
            {
                cnproveedor = new CN_Proveedor();
                cnproveedor.llenarProveedoresPor(this.dgvProveedores, bunifuTextbox1.text);
            }
            else {
                cnproveedor.llenarProveedores(this.dgvProveedores);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Aqui guarda los datos
            //Extra.Extendido ex = new Extra.Extendido();
            //ex.Show();


            AgregarProvedores insertarProveedor = new AgregarProvedores();
            
            MostrarFormularios.MostrarFormulario(Panel_Principal.panelCargar,insertarProveedor);

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

           int id_proveedor = int.Parse(dgvProveedores.SelectedRows[0].Cells[0].Value.ToString());
            if (id_proveedor > 0) {

                
                cnproveedor = new CN_Proveedor();

                BD_Proveedor proveedor = cnproveedor.seleccionaProveedorProId(id_proveedor);

                AgregarProvedores insertarProveedor = new AgregarProvedores(proveedor);

                MostrarFormularios.MostrarFormulario(Panel_Principal.panelCargar, insertarProveedor);

            }
        }

        

    }
}
