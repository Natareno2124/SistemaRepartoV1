
using System;
using System.Drawing;
using System.Windows.Forms;
namespace WinFormsApp1
{
    partial class RegistroSucursales
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.Nombre = new System.Windows.Forms.Label();
            this.txtCodigoSucursal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboContacto = new System.Windows.Forms.ComboBox();
            this.comboDireccion = new System.Windows.Forms.ComboBox();
            this.comboEncargado = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(153)))), ((int)(((byte)(174)))));
            this.button1.Font = new System.Drawing.Font("Arial Black", 10.8F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(169, 491);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(264, 55);
            this.button1.TabIndex = 0;
            this.button1.Text = "REGISTRAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnAgregarSucursal_Click);
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.Nombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.Nombre.Location = new System.Drawing.Point(73, 86);
            this.Nombre.Name = "Nombre";
            this.Nombre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Nombre.Size = new System.Drawing.Size(139, 19);
            this.Nombre.TabIndex = 1;
            this.Nombre.Text = "Codigo Sucursal";
            this.Nombre.Click += new System.EventHandler(this.Nombre_Click);
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
            this.txtCodigoSucursal.TextChanged += new System.EventHandler(this.txtNombres_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.label3.Location = new System.Drawing.Point(73, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "ID Contacto ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Black", 16.2F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.label6.Location = new System.Drawing.Point(27, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(449, 40);
            this.label6.TabIndex = 13;
            this.label6.Text = "REGISTRO DE SUCURSALES";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(153)))), ((int)(((byte)(174)))));
            this.groupBox1.Controls.Add(this.comboContacto);
            this.groupBox1.Controls.Add(this.comboDireccion);
            this.groupBox1.Controls.Add(this.comboEncargado);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.Nombre);
            this.groupBox1.Controls.Add(this.txtCodigoSucursal);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.ForeColor = System.Drawing.Color.Transparent;
            this.groupBox1.Location = new System.Drawing.Point(45, 28);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(533, 420);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // comboContacto
            // 
            this.comboContacto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(84)))), ((int)(((byte)(109)))));
            this.comboContacto.ForeColor = System.Drawing.SystemColors.Window;
            this.comboContacto.FormattingEnabled = true;
            this.comboContacto.Location = new System.Drawing.Point(73, 247);
            this.comboContacto.Name = "comboContacto";
            this.comboContacto.Size = new System.Drawing.Size(383, 24);
            this.comboContacto.TabIndex = 32;
            // 
            // comboDireccion
            // 
            this.comboDireccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(84)))), ((int)(((byte)(109)))));
            this.comboDireccion.ForeColor = System.Drawing.SystemColors.Window;
            this.comboDireccion.FormattingEnabled = true;
            this.comboDireccion.Location = new System.Drawing.Point(73, 321);
            this.comboDireccion.Name = "comboDireccion";
            this.comboDireccion.Size = new System.Drawing.Size(383, 24);
            this.comboDireccion.TabIndex = 31;
            // 
            // comboEncargado
            // 
            this.comboEncargado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(84)))), ((int)(((byte)(109)))));
            this.comboEncargado.ForeColor = System.Drawing.SystemColors.Window;
            this.comboEncargado.FormattingEnabled = true;
            this.comboEncargado.Location = new System.Drawing.Point(73, 175);
            this.comboEncargado.Name = "comboEncargado";
            this.comboEncargado.Size = new System.Drawing.Size(383, 24);
            this.comboEncargado.TabIndex = 16;
            this.comboEncargado.SelectedIndexChanged += new System.EventHandler(this.comboEncargado_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.label1.Location = new System.Drawing.Point(73, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 19);
            this.label1.TabIndex = 24;
            this.label1.Text = "ID Encargado";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.label7.Location = new System.Drawing.Point(69, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 19);
            this.label7.TabIndex = 14;
            this.label7.Text = "ID Direccion";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(628, 564);
            this.panel1.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(88)))));
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(3, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(623, 559);
            this.panel2.TabIndex = 0;
            // 
            // RegistroSucursales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(88)))));
            this.ClientSize = new System.Drawing.Size(657, 596);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RegistroSucursales";
            this.Load += new System.EventHandler(this.RegistroSucursales_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        private Button button1;
        private Label Nombre;
        private Label label3;
        private Label label6;
        private GroupBox groupBox1;
        private Label label7;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        public ComboBox comboEncargado;
        public ComboBox comboContacto;
        public ComboBox comboDireccion;
        public TextBox txtCodigoSucursal;
    }
}
