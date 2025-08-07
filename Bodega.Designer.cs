//registro bodegas designer

namespace SistemaRepartoG4
{
    partial class RegistroBodegas
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.txtCodigoSucursal = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.comboSucursal = new System.Windows.Forms.ComboBox();
            this.comboEncargado = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCapacidad = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(15, 14);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(620, 666);
            this.panel1.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(88)))));
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.btnRegistrar);
            this.panel2.Location = new System.Drawing.Point(3, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(615, 661);
            this.panel2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(153)))), ((int)(((byte)(174)))));
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCapacidad);
            this.groupBox1.Controls.Add(this.comboSucursal);
            this.groupBox1.Controls.Add(this.comboEncargado);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.Nombre);
            this.groupBox1.Controls.Add(this.txtCodigoSucursal);
            this.groupBox1.ForeColor = System.Drawing.Color.Transparent;
            this.groupBox1.Location = new System.Drawing.Point(45, 28);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(523, 540);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Black", 16.2F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.label6.Location = new System.Drawing.Point(27, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(390, 40);
            this.label6.TabIndex = 13;
            this.label6.Text = "REGISTRO DE BODEGAS";
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.Nombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.Nombre.Location = new System.Drawing.Point(73, 86);
            this.Nombre.Name = "Nombre";
            this.Nombre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Nombre.Size = new System.Drawing.Size(130, 19);
            this.Nombre.TabIndex = 1;
            this.Nombre.Text = "Codigo Bodega";
            // 
            // txtCodigoSucursal
            // 
            this.txtCodigoSucursal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(84)))), ((int)(((byte)(109)))));
            this.txtCodigoSucursal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodigoSucursal.Font = new System.Drawing.Font("Arial", 16.2F);
            this.txtCodigoSucursal.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.txtCodigoSucursal.Location = new System.Drawing.Point(73, 107);
            this.txtCodigoSucursal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodigoSucursal.Name = "txtCodigoSucursal";
            this.txtCodigoSucursal.Size = new System.Drawing.Size(383, 32);
            this.txtCodigoSucursal.TabIndex = 2;
            // 
// txtCodigoBodega
// 
this.txtCodigoBodega = new System.Windows.Forms.TextBox();
this.txtCodigoBodega.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(84)))), ((int)(((byte)(109)))));
this.txtCodigoBodega.BorderStyle = System.Windows.Forms.BorderStyle.None;
this.txtCodigoBodega.Font = new System.Drawing.Font("Arial", 16.2F);
this.txtCodigoBodega.ForeColor = System.Drawing.SystemColors.HighlightText;
this.txtCodigoBodega.Location = new System.Drawing.Point(73, 145); // Ajusta la posición según necesites
this.txtCodigoBodega.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
this.txtCodigoBodega.Name = "txtCodigoBodega";
this.txtCodigoBodega.Size = new System.Drawing.Size(383, 32);
this.txtCodigoBodega.TabIndex = 41;

            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(153)))), ((int)(((byte)(174)))));
            this.btnRegistrar.Font = new System.Drawing.Font("Arial Black", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnRegistrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRegistrar.Location = new System.Drawing.Point(156, 584);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(264, 55);
            this.btnRegistrar.TabIndex = 0;
            this.btnRegistrar.Text = "REGISTRAR";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            // 
            // comboSucursal
            // 
            this.comboSucursal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(84)))), ((int)(((byte)(109)))));
            this.comboSucursal.ForeColor = System.Drawing.SystemColors.Window;
            this.comboSucursal.FormattingEnabled = true;
            this.comboSucursal.Location = new System.Drawing.Point(73, 265);
            this.comboSucursal.Name = "comboSucursal";
            this.comboSucursal.Size = new System.Drawing.Size(383, 24);
            this.comboSucursal.TabIndex = 38;
            // 
            // comboEncargado
            // 
            this.comboEncargado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(84)))), ((int)(((byte)(109)))));
            this.comboEncargado.ForeColor = System.Drawing.SystemColors.Window;
            this.comboEncargado.FormattingEnabled = true;
            this.comboEncargado.Location = new System.Drawing.Point(73, 193);
            this.comboEncargado.Name = "comboEncargado";
            this.comboEncargado.Size = new System.Drawing.Size(383, 24);
            this.comboEncargado.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.label1.Location = new System.Drawing.Point(73, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 19);
            this.label1.TabIndex = 36;
            this.label1.Text = "ID Encargado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.label3.Location = new System.Drawing.Point(73, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 19);
            this.label3.TabIndex = 33;
            this.label3.Text = "Sucursal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.label2.Location = new System.Drawing.Point(73, 310);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(156, 19);
            this.label2.TabIndex = 39;
            this.label2.Text = "Capacidad Bodega";
            // 
            // txtCapacidad
            // 
            this.txtCapacidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(84)))), ((int)(((byte)(109)))));
            this.txtCapacidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCapacidad.Font = new System.Drawing.Font("Arial", 16.2F);
            this.txtCapacidad.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.txtCapacidad.Location = new System.Drawing.Point(73, 331);
            this.txtCapacidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCapacidad.Name = "txtCapacidad";
            this.txtCapacidad.Size = new System.Drawing.Size(383, 32);
            this.txtCapacidad.TabIndex = 40;
            // 
            // RegistroBodegas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(88)))));
            this.ClientSize = new System.Drawing.Size(647, 695);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RegistroBodegas";
            this.Text = "RegistroBodegas";
            this.Load += new System.EventHandler(this.RegistroBodegas_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.TextBox txtCodigoSucursal;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.TextBox txtCodigoBodega;
        private System.Windows.Forms.TextBox txtCapacidad;

        public System.Windows.Forms.ComboBox comboSucursal;
        public System.Windows.Forms.ComboBox comboEncargado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}