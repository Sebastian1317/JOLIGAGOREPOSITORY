using JL_Utilidades;
using Jolugago_Project1.Compras;
using Jolugago_Project1.MenusBarras;
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
    public partial class Panel_Principal : Form
    {
        public Panel_Principal()
        {
            InitializeComponent();
            panelCargar = PanelContainer; 
        }


        public static Panel panelCargar = null;
        Form formularioR = new Form();
        

        private void PanelContainer_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (PanelVertical.Width == 270)
            {
                PanelVertical.Width = 70;
                formularioR.Size = this.PanelContainer.Size;
                btnEditarP.Visible = false;
                Foto.Visible = false;
                PanelLogoArriba.Size = new Size(70, 41);
                lblPerfil.Visible = false;
                lblRol.Visible = false;
            }
            else
            {
                PanelVertical.Width = 270;
                formularioR.Size = this.PanelContainer.Size;
                btnEditarP.Visible = true;
                Foto.Visible = true;
                lblPerfil.Visible = true;
                lblRol.Visible = true;
                PanelLogoArriba.Size = new Size(270, 41);
            }

        }

        private void btnPrueba_Click(object sender, EventArgs e)
        {
            CompraPrincipal s = new CompraPrincipal();
            EscogerMenu(s);

        }

        private void btmMiz_Click(object sender, EventArgs e)
        {
            //Codigo para minimizar
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMizT_Click(object sender, EventArgs e)
        {

            if (this.Size == Screen.PrimaryScreen.WorkingArea.Size)
            {
                //Codigo para restaurar
                this.Size= new Size(1308, 762);
                formularioR.Size = this.PanelContainer.Size;
                btnClose.Location = new Point(this.PanelArriba.Size.Width - 72, 0);
                btnMizT.Location = new Point(this.PanelArriba.Size.Width - 112, 0);
                btmMiz.Location = new Point(this.PanelArriba.Size.Width - 180, 0);

            }
            else {
                //Codigo para maximizar la la pantalla
                this.Size = Screen.PrimaryScreen.WorkingArea.Size;
                this.Location = Screen.PrimaryScreen.WorkingArea.Location;
                formularioR.Size= this.PanelContainer.Size;
                btnClose.Location = new Point(this.PanelArriba.Size.Width - 72, 0);
                btnMizT.Location = new Point(this.PanelArriba.Size.Width - 112, 0);
                btmMiz.Location = new Point(this.PanelArriba.Size.Width - 180, 0);
            }
        }

        private void PanelArriba_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGraficas_Click(object sender, EventArgs e)
        {
            BarrasMenus b = new BarrasMenus();
            EscogerMenu(b);
        }

        public void EscogerMenu(Form formulario) {

            
            formularioR = MostrarFormularios.MostrarFormulario(this.PanelContainer, formulario);
            formularioR.Size = this.PanelContainer.Size;
        }

    }
}
