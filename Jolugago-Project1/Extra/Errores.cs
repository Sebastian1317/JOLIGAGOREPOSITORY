using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jolugago_Project1.Extra
{
    public partial class Errores : Form
    {
        public Errores()
        {
            InitializeComponent();
            lblTextoDes.Text = "Datos incorrectos, por favor" + Environment.NewLine 
                + "ingresa el usuario o contraseña";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
