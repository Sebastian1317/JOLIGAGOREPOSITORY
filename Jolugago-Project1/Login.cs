using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jolugago_Project1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            panel1.Width = (Screen.PrimaryScreen.WorkingArea.Size.Width-400);
            this.panelPos.Width = (Screen.PrimaryScreen.WorkingArea.Size.Width - panel1.Width);
            controles();


        }
        public void controles()
        {
            
            int posH = (this.panelPos.Size.Height / 2)+10;
            txtContraseña.Location = new Point(txtContraseña.Location.X,posH);
 
            int posHN = txtContraseña.Location.Y+100;
            txtNombre.Location = new Point(txtNombre.Location.X, posHN);

            int posHLabelNombre = (this.panelPos.Size.Height / 2) + 10;
            lblNombre.Location = new Point(txtContraseña.Location.X, posH);

            int posHLabelContraseña = (this.panelPos.Size.Height / 2) + 10;
            lblContraseña.Location = new Point(txtContraseña.Location.X, posH);

        }

    }
}
