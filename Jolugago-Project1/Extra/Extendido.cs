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
    public partial class Extendido : Form
    {
        public Extendido()
        {
            InitializeComponent();
        }

        private void Extendido_Activated(object sender, EventArgs e)
        {
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.BackColor = Color.FromArgb(0,0,0);

        }
    }
}
