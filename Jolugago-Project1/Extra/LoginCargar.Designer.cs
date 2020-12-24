namespace Jolugago_Project1.Extra
{
    partial class LoginCargar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tCargar = new System.Windows.Forms.Timer(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pbImageGift = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImageGift)).BeginInit();
            this.SuspendLayout();
            // 
            // tCargar
            // 
            this.tCargar.Tick += new System.EventHandler(this.tCargar_Tick);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pbImageGift
            // 
            this.pbImageGift.Location = new System.Drawing.Point(0, 0);
            this.pbImageGift.Name = "pbImageGift";
            this.pbImageGift.Size = new System.Drawing.Size(298, 194);
            this.pbImageGift.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbImageGift.TabIndex = 4;
            this.pbImageGift.TabStop = false;
            // 
            // LoginCargar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(299, 194);
            this.Controls.Add(this.pbImageGift);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginCargar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginCargar";
            ((System.ComponentModel.ISupportInitialize)(this.pbImageGift)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer tCargar;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox pbImageGift;
    }
}