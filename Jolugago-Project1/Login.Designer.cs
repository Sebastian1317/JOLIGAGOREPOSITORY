namespace Jolugago_Project1
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelPos = new System.Windows.Forms.Panel();
            this.plLine = new System.Windows.Forms.Panel();
            this.lblOlvideC = new System.Windows.Forms.LinkLabel();
            this.lblBienvendio = new System.Windows.Forms.Label();
            this.btnIngresar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtContraseña = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtNombre = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.tEntrar = new System.Windows.Forms.Timer(this.components);
            this.panelPos.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 1;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(106)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(498, 450);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panelPos
            // 
            this.panelPos.Controls.Add(this.plLine);
            this.panelPos.Controls.Add(this.lblOlvideC);
            this.panelPos.Controls.Add(this.lblBienvendio);
            this.panelPos.Controls.Add(this.btnIngresar);
            this.panelPos.Controls.Add(this.lblContraseña);
            this.panelPos.Controls.Add(this.lblNombre);
            this.panelPos.Controls.Add(this.txtContraseña);
            this.panelPos.Controls.Add(this.txtNombre);
            this.panelPos.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelPos.Location = new System.Drawing.Point(497, 0);
            this.panelPos.Name = "panelPos";
            this.panelPos.Size = new System.Drawing.Size(303, 450);
            this.panelPos.TabIndex = 1;
            // 
            // plLine
            // 
            this.plLine.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("plLine.BackgroundImage")));
            this.plLine.Location = new System.Drawing.Point(22, 92);
            this.plLine.Name = "plLine";
            this.plLine.Size = new System.Drawing.Size(254, 35);
            this.plLine.TabIndex = 9;
            // 
            // lblOlvideC
            // 
            this.lblOlvideC.AutoSize = true;
            this.lblOlvideC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblOlvideC.Location = new System.Drawing.Point(67, 337);
            this.lblOlvideC.Name = "lblOlvideC";
            this.lblOlvideC.Size = new System.Drawing.Size(155, 20);
            this.lblOlvideC.TabIndex = 7;
            this.lblOlvideC.TabStop = true;
            this.lblOlvideC.Text = "Olvide la Contraseña";
            // 
            // lblBienvendio
            // 
            this.lblBienvendio.AutoSize = true;
            this.lblBienvendio.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold);
            this.lblBienvendio.Location = new System.Drawing.Point(88, 26);
            this.lblBienvendio.Name = "lblBienvendio";
            this.lblBienvendio.Size = new System.Drawing.Size(197, 39);
            this.lblBienvendio.TabIndex = 6;
            this.lblBienvendio.Text = "Bienvenido";
            // 
            // btnIngresar
            // 
            this.btnIngresar.ActiveBorderThickness = 1;
            this.btnIngresar.ActiveCornerRadius = 20;
            this.btnIngresar.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(239)))));
            this.btnIngresar.ActiveForecolor = System.Drawing.Color.White;
            this.btnIngresar.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(239)))));
            this.btnIngresar.BackColor = System.Drawing.Color.White;
            this.btnIngresar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIngresar.BackgroundImage")));
            this.btnIngresar.ButtonText = "Ingresar";
            this.btnIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIngresar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(239)))));
            this.btnIngresar.IdleBorderThickness = 1;
            this.btnIngresar.IdleCornerRadius = 20;
            this.btnIngresar.IdleFillColor = System.Drawing.Color.White;
            this.btnIngresar.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(239)))));
            this.btnIngresar.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(239)))));
            this.btnIngresar.Location = new System.Drawing.Point(51, 395);
            this.btnIngresar.Margin = new System.Windows.Forms.Padding(5);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(181, 41);
            this.btnIngresar.TabIndex = 4;
            this.btnIngresar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblContraseña.Location = new System.Drawing.Point(7, 248);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(111, 24);
            this.lblContraseña.TabIndex = 3;
            this.lblContraseña.Text = "Contraseña:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblNombre.Location = new System.Drawing.Point(7, 156);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(84, 24);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContraseña.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(189)))), ((int)(((byte)(255)))));
            this.txtContraseña.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(212)))), ((int)(((byte)(218)))));
            this.txtContraseña.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(189)))), ((int)(((byte)(255)))));
            this.txtContraseña.BorderThickness = 3;
            this.txtContraseña.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContraseña.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtContraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtContraseña.isPassword = false;
            this.txtContraseña.Location = new System.Drawing.Point(4, 276);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(4);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(276, 39);
            this.txtContraseña.TabIndex = 1;
            this.txtContraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(189)))), ((int)(((byte)(255)))));
            this.txtNombre.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(212)))), ((int)(((byte)(218)))));
            this.txtNombre.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(189)))), ((int)(((byte)(255)))));
            this.txtNombre.BorderThickness = 3;
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNombre.isPassword = false;
            this.txtNombre.Location = new System.Drawing.Point(3, 184);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(276, 39);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tEntrar
            // 
            this.tEntrar.Tick += new System.EventHandler(this.tEntrar_Tick);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelPos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelPos.ResumeLayout(false);
            this.panelPos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelPos;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtContraseña;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtNombre;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblNombre;
        private Bunifu.Framework.UI.BunifuThinButton2 btnIngresar;
        private System.Windows.Forms.LinkLabel lblOlvideC;
        private System.Windows.Forms.Label lblBienvendio;
        private System.Windows.Forms.Panel plLine;
        private System.Windows.Forms.Timer tEntrar;
    }
}

