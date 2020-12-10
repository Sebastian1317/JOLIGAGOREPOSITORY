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

namespace Jolugago_Project1.Productos
{
    public partial class Productos : Form
    {

        CN_Producto cn_producto = new CN_Producto();

        public Productos()
        {
            InitializeComponent();
            cargarComboBox();
        }

        private void cargarComboBox()
        {
            
            cn_producto.listarMarca(ddlMarca1);
            cn_producto.listarCategoria(ddlCategoria);
            cn_producto.listarProveedores(ddlProveedor);
            cn_producto.listarUnidadMedida(ddlUnidadMedida);
            
        }


    }
}
