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

namespace Jolugago_Project1.Compras
{
    public partial class GenerarCompra : Form
    {


        public GenerarCompra()
        {
            InitializeComponent();
            codigo_de_prueba();
        }

        private BD_DocumentoCompras compra = null;
        private CN_Compras cncompras = null;
        private BD_Usuario usuarioId = new BD_Usuario();
        private void codigo_de_prueba() {


            List<BD_Producto> productos = new List<BD_Producto>();

            productos.Add(new BD_Producto(3, 3, 130));
            
            cncompras = new CN_Compras();
            usuarioId.id_Usu = 4;
            compra = new BD_DocumentoCompras("", '1',
            new BD_Proveedor(1), 150, DateTime.Now,
            5,usuarioId ,"Efectivo",
            2, DateTime.Now, "Bien", true, "Producto en buen estado",
            "sale",productos);

            cncompras.insertarCompra(compra);


        }
       

    }
}
