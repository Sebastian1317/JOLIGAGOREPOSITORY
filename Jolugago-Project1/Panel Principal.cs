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
            
        }

        CompraPrincipal s = new CompraPrincipal();

        private void PanelContainer_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (PanelVertical.Width == 270)
            {
                PanelVertical.Width = 70;
                s.Size = new Size(1238,645);
                btnEditarP.Visible = false;
                Foto.Visible = false;
                PanelLogoArriba.Size = new Size(70, 41);
                lblPerfil.Visible = false;
                lblRol.Visible = false;
            }
            else
            {
                PanelVertical.Width = 270;
                s.Size = new Size(1038, 645);
                
                btnEditarP.Visible = true;
                Foto.Visible = true;
                lblPerfil.Visible = true;
                lblRol.Visible = true;
                PanelLogoArriba.Size = new Size(270, 41);
            }

        }

        private void btnPrueba_Click(object sender, EventArgs e)
        {
            
            s.TopLevel = false;
            PanelContainer.Controls.Add(s);
            PanelContainer.Tag = s;
            s.Show();
        }

        private void btmMiz_Click(object sender, EventArgs e)
        {
            //Codigo para minimizar
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMizT_Click(object sender, EventArgs e)
        {
            //Codigo para maximizar la la pantalla
               this.Size = Screen.PrimaryScreen.WorkingArea.Size;
               this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }


        //Codigo para restaurar
        //this.WindowState = FormWindowState.Normal;


    }
}
