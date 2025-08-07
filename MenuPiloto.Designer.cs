namespace SistemaRepartoG4
{
    partial class MenuPiloto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPiloto));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUserPiloto = new System.Windows.Forms.Button();
            this.labelmenupiloto = new System.Windows.Forms.Label();
            this.lineadecorativa = new System.Windows.Forms.Label();
            this.btnMisEntregas = new System.Windows.Forms.Button();
            this.btnRutasPiloto = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(153)))), ((int)(((byte)(174)))));
            this.panel1.Controls.Add(this.btnUserPiloto);
            this.panel1.Location = new System.Drawing.Point(-2, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1265, 56);
            this.panel1.TabIndex = 0;
            // 
            // btnUserPiloto
            // 
            this.btnUserPiloto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(153)))), ((int)(((byte)(174)))));
            this.btnUserPiloto.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserPiloto.ForeColor = System.Drawing.Color.White;
            this.btnUserPiloto.Location = new System.Drawing.Point(1030, 14);
            this.btnUserPiloto.Name = "btnUserPiloto";
            this.btnUserPiloto.Size = new System.Drawing.Size(172, 31);
            this.btnUserPiloto.TabIndex = 0;
            this.btnUserPiloto.Text = "User Repartidor";
            this.btnUserPiloto.UseVisualStyleBackColor = false;
            this.btnUserPiloto.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // labelmenupiloto
            // 
            this.labelmenupiloto.AutoSize = true;
            this.labelmenupiloto.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelmenupiloto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.labelmenupiloto.Location = new System.Drawing.Point(72, 77);
            this.labelmenupiloto.Name = "labelmenupiloto";
            this.labelmenupiloto.Size = new System.Drawing.Size(346, 48);
            this.labelmenupiloto.TabIndex = 1;
            this.labelmenupiloto.Text = "MENÚ PRINCIPAL";
            this.labelmenupiloto.Click += new System.EventHandler(this.labelmenupiloto_Click);
            // 
            // lineadecorativa
            // 
            this.lineadecorativa.AutoSize = true;
            this.lineadecorativa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lineadecorativa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.lineadecorativa.Location = new System.Drawing.Point(75, 125);
            this.lineadecorativa.Name = "lineadecorativa";
            this.lineadecorativa.Size = new System.Drawing.Size(1125, 29);
            this.lineadecorativa.TabIndex = 2;
            this.lineadecorativa.Text = "---------------------------------------------------------------------------------" +
    "----------------------------------------------------------";
            this.lineadecorativa.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnMisEntregas
            // 
            this.btnMisEntregas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(162)))), ((int)(((byte)(190)))));
            this.btnMisEntregas.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMisEntregas.ForeColor = System.Drawing.Color.White;
            this.btnMisEntregas.Location = new System.Drawing.Point(80, 172);
            this.btnMisEntregas.Name = "btnMisEntregas";
            this.btnMisEntregas.Size = new System.Drawing.Size(539, 94);
            this.btnMisEntregas.TabIndex = 3;
            this.btnMisEntregas.Text = "Mis entregas";
            this.btnMisEntregas.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnMisEntregas.UseVisualStyleBackColor = false;
            this.btnMisEntregas.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRutasPiloto
            // 
            this.btnRutasPiloto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(162)))), ((int)(((byte)(190)))));
            this.btnRutasPiloto.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRutasPiloto.ForeColor = System.Drawing.Color.White;
            this.btnRutasPiloto.Location = new System.Drawing.Point(656, 172);
            this.btnRutasPiloto.Name = "btnRutasPiloto";
            this.btnRutasPiloto.Size = new System.Drawing.Size(539, 94);
            this.btnRutasPiloto.TabIndex = 4;
            this.btnRutasPiloto.Text = "Rutas";
            this.btnRutasPiloto.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnRutasPiloto.UseVisualStyleBackColor = false;
            this.btnRutasPiloto.Click += new System.EventHandler(this.btnRutasPiloto_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(162)))), ((int)(((byte)(190)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(1069, 183);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(95, 76);
            this.panel2.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(162)))), ((int)(((byte)(190)))));
            this.panel5.Controls.Add(this.pictureBox4);
            this.panel5.Location = new System.Drawing.Point(480, 183);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(106, 68);
            this.panel5.TabIndex = 15;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(12, 1);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(84, 67);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // MenuPiloto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 723);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnRutasPiloto);
            this.Controls.Add(this.btnMisEntregas);
            this.Controls.Add(this.lineadecorativa);
            this.Controls.Add(this.labelmenupiloto);
            this.Controls.Add(this.panel1);
            this.Name = "MenuPiloto";
            this.Text = "MenuPiloto";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelmenupiloto;
        private System.Windows.Forms.Label lineadecorativa;
        private System.Windows.Forms.Button btnMisEntregas;
        private System.Windows.Forms.Button btnRutasPiloto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnUserPiloto;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}