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

namespace Jolugago_Project1.Extra
{
    public partial class LoginCargar : Form
    {
        Extra.Errores error = new Errores();
        private BD_Usuario busuario;
        private int c =0;
        String valoresD = "0.";
        public LoginCargar(BD_Usuario usuario)
        {
            
            InitializeComponent();
            this.Opacity = 0;
            tCargar.Start();
            pbImageGift.Image = Image.FromFile(@"C:\Users\Antonio\Source\Repos\Sebastian1317\JOLIGAGOREPOSITORY2\JL-Utilidades\Imagenes\cargando.gif");
            busuario = usuario;
        }

        private void tCargar_Tick(object sender, EventArgs e)
        {
            if (c == 10 && busuario == null) {
                
                    tCargar.Stop();
                    error.ShowDialog();
                    this.Dispose();
                
            }
            else if (c==10 && busuario.nombres == null)
            {
                tCargar.Stop();
                error.ShowDialog();
                this.Dispose();
            }
            else if (c==25) {
                tCargar.Stop();
                this.Dispose();
            } else {

                valoresD = "0."+c.ToString();
                if (valoresD =="0.9")
                     valoresD = "1";
    
                this.Opacity = Double.Parse((this.Opacity == 1) ? "1" : valoresD);

            }
            c++;

        }
    }
}
