
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
            this.txt_IDContacto = new System.Windows.Forms.TextBox();
            this.txt_IDDireccion = new System.Windows.Forms.TextBox();
            this.txt_IdEncargado = new System.Windows.Forms.TextBox();
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
            this.button1.Location = new System.Drawing.Point(127, 399);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 45);
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
            this.Nombre.Location = new System.Drawing.Point(55, 70);
            this.Nombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Nombre.Name = "Nombre";
            this.Nombre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Nombre.Size = new System.Drawing.Size(122, 16);
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
            this.txtCodigoSucursal.Location = new System.Drawing.Point(55, 87);
            this.txtCodigoSucursal.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigoSucursal.Name = "txtCodigoSucursal";
            this.txtCodigoSucursal.Size = new System.Drawing.Size(287, 25);
            this.txtCodigoSucursal.TabIndex = 2;
            this.txtCodigoSucursal.TextChanged += new System.EventHandler(this.txtNombres_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.label3.Location = new System.Drawing.Point(55, 181);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "ID Contacto ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Black", 16.2F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.label6.Location = new System.Drawing.Point(20, 24);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(354, 31);
            this.label6.TabIndex = 13;
            this.label6.Text = "REGISTRO DE SUCURSALES";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(153)))), ((int)(((byte)(174)))));
            this.groupBox1.Controls.Add(this.txt_IDContacto);
            this.groupBox1.Controls.Add(this.txt_IDDireccion);
            this.groupBox1.Controls.Add(this.txt_IdEncargado);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.Nombre);
            this.groupBox1.Controls.Add(this.txtCodigoSucursal);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.ForeColor = System.Drawing.Color.Transparent;
            this.groupBox1.Location = new System.Drawing.Point(34, 23);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(400, 341);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txt_IDContacto
            // 
            this.txt_IDContacto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(84)))), ((int)(((byte)(109)))));
            this.txt_IDContacto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_IDContacto.Font = new System.Drawing.Font("Arial", 16.2F);
            this.txt_IDContacto.Location = new System.Drawing.Point(55, 199);
            this.txt_IDContacto.Margin = new System.Windows.Forms.Padding(2);
            this.txt_IDContacto.Name = "txt_IDContacto";
            this.txt_IDContacto.Size = new System.Drawing.Size(287, 25);
            this.txt_IDContacto.TabIndex = 30;
            // 
            // txt_IDDireccion
            // 
            this.txt_IDDireccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(84)))), ((int)(((byte)(109)))));
            this.txt_IDDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_IDDireccion.Font = new System.Drawing.Font("Arial", 16.2F);
            this.txt_IDDireccion.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.txt_IDDireccion.Location = new System.Drawing.Point(55, 256);
            this.txt_IDDireccion.Margin = new System.Windows.Forms.Padding(2);
            this.txt_IDDireccion.Name = "txt_IDDireccion";
            this.txt_IDDireccion.Size = new System.Drawing.Size(287, 25);
            this.txt_IDDireccion.TabIndex = 29;
            // 
            // txt_IdEncargado
            // 
            this.txt_IdEncargado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(84)))), ((int)(((byte)(109)))));
            this.txt_IdEncargado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_IdEncargado.Font = new System.Drawing.Font("Arial", 16.2F);
            this.txt_IdEncargado.Location = new System.Drawing.Point(55, 142);
            this.txt_IdEncargado.Margin = new System.Windows.Forms.Padding(2);
            this.txt_IdEncargado.Name = "txt_IdEncargado";
            this.txt_IdEncargado.Size = new System.Drawing.Size(287, 25);
            this.txt_IdEncargado.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.label1.Location = new System.Drawing.Point(55, 124);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "ID Encargado";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.label7.Location = new System.Drawing.Point(52, 238);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "ID Direccion";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(9, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(471, 458);
            this.panel1.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(88)))));
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(467, 454);
            this.panel2.TabIndex = 0;
            // 
            // RegistroSucursales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(88)))));
            this.ClientSize = new System.Drawing.Size(492, 484);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RegistroSucursales";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void guardarSucursal_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Button button1;
        private Label Nombre;
        private TextBox txtCodigoSucursal;
        private Label label3;
        private Label label6;
        private GroupBox groupBox1;
        private Label label7;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private TextBox txt_IdEncargado;
        private TextBox txt_IDContacto;
        private TextBox txt_IDDireccion;
    }
}
