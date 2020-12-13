using JL_Capa_De_Negocio;
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

namespace Jolugago_Project1.Productos
{
    public partial class ListarProductos : Form
    {


        CN_Producto cnproducto = null;
        public ListarProductos()
        {
            InitializeComponent();
            llenarTabla();
        }

        private void llenarTabla() {

            cnproducto = new CN_Producto();
            cnproducto.obtenerProductos(dgvProductos);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Productos productos = new Productos();
            MostrarFormularios.MostrarFormulario(Panel_Principal.panelCargar,productos);
        }
    }
}
