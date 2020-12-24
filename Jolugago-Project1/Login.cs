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

namespace Jolugago_Project1
{
    public partial class Login : Form
    {

        private BD_Usuario usuario;
        private CN_Usuario cnusuario;

        private int contador = 0;
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
            int posH = (200);
            txtNombre.Location = new Point(txtNombre.Location.X,posH);
 
            int posHN = txtNombre.Location.Y+100;
            txtContraseña.Location = new Point(txtContraseña.Location.X, posHN);

            int posHLabelNombre = (txtNombre.Location.Y - 35);
            lblNombre.Location = new Point(txtNombre.Location.X, posHLabelNombre);

            int posHLabelContraseña = (txtContraseña.Location.Y - 35);
            lblContraseña.Location = new Point(txtContraseña.Location.X, posHLabelContraseña);

            int m = (this.txtContraseña.Width)/2;
            int mitadLocation = (this.txtContraseña.Location.X + 100); 
            lblOlvideC.Location = new Point(mitadLocation, this.txtContraseña.Location.Y + 60);

            btnIngresar.Location = new Point(lblOlvideC.Location.X,lblOlvideC.Location.Y +50);

            lblBienvendio.Location = new Point(lblOlvideC.Location.X-15, 45);
            plLine.Location = new Point(lblBienvendio.Location.X-35, lblBienvendio.Location.Y+40);
        }
        
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtContraseña.Text !="")
            {
                cnusuario = new CN_Usuario();
                usuario = cnusuario.accesarLoginC(txtNombre.Text, txtContraseña.Text);
                Extra.LoginCargar cargarL = new Extra.LoginCargar(usuario);
                cargarL.ShowDialog();
                if (usuario != null)
                {
                    Panel_Principal principal = new Panel_Principal(usuario);
                    principal.Show();
                }
                else
                {
                    txtContraseña.BorderColorFocused = Color.Red;
                    txtNombre.BorderColorFocused = Color.Red;
                }
            }
            
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tEntrar_Tick(object sender, EventArgs e)
        {
            
            
            
        }
    }
}
