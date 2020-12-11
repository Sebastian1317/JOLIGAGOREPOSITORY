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
    public partial class CompraPrincipal : Form
    {
        public CompraPrincipal()
        {
            InitializeComponent();
            listarCompras();
        }

        CN_Compras cncompras = null;

        private void listarCompras() {

            cncompras = new CN_Compras();
            BD_Proveedor prove = new BD_Proveedor();

            prove.nombre = "Sebastian";
            BD_DocumentoCompras compras = new BD_DocumentoCompras("1", prove.nombre, DateTime.Now,
            333, "d", "2");

            var compa = compras;

            var d = compa;

            //cncompras.listarCompras(dgvCompras);

        }

    }
}
