namespace SistemaRepartoG4
{
    partial class Sucursales
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
            this.Lab_sucursales = new System.Windows.Forms.Label();
            this.Btn_filtrar = new System.Windows.Forms.Button();
            this.Btn_agregar = new System.Windows.Forms.Button();
            this.Btn_editar = new System.Windows.Forms.Button();
            this.Btn_eliminar = new System.Windows.Forms.Button();
            this.dataGridViewSucursal = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSucursal)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(153)))), ((int)(((byte)(174)))));
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1255, 78);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.panel2.Location = new System.Drawing.Point(37, 159);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1184, 16);
            this.panel2.TabIndex = 1;
            // 
            // Lab_sucursales
            // 
            this.Lab_sucursales.AutoSize = true;
            this.Lab_sucursales.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_sucursales.Location = new System.Drawing.Point(31, 119);
            this.Lab_sucursales.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lab_sucursales.Name = "Lab_sucursales";
            this.Lab_sucursales.Size = new System.Drawing.Size(222, 35);
            this.Lab_sucursales.TabIndex = 2;
            this.Lab_sucursales.Text = "SUCURSALES";
            // 
            // Btn_filtrar
            // 
            this.Btn_filtrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(153)))), ((int)(((byte)(174)))));
            this.Btn_filtrar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_filtrar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Btn_filtrar.Location = new System.Drawing.Point(324, 678);
            this.Btn_filtrar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_filtrar.Name = "Btn_filtrar";
            this.Btn_filtrar.Size = new System.Drawing.Size(155, 37);
            this.Btn_filtrar.TabIndex = 4;
            this.Btn_filtrar.Text = "Filtrar";
            this.Btn_filtrar.UseVisualStyleBackColor = false;
            // 
            // Btn_agregar
            // 
            this.Btn_agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.Btn_agregar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_agregar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_agregar.Location = new System.Drawing.Point(729, 678);
            this.Btn_agregar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_agregar.Name = "Btn_agregar";
            this.Btn_agregar.Size = new System.Drawing.Size(155, 37);
            this.Btn_agregar.TabIndex = 5;
            this.Btn_agregar.Text = "Agregar";
            this.Btn_agregar.UseVisualStyleBackColor = false;
            this.Btn_agregar.Click += new System.EventHandler(this.Btn_agregar_click);
            // 
            // Btn_editar
            // 
            this.Btn_editar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.Btn_editar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_editar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_editar.Location = new System.Drawing.Point(892, 679);
            this.Btn_editar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_editar.Name = "Btn_editar";
            this.Btn_editar.Size = new System.Drawing.Size(155, 37);
            this.Btn_editar.TabIndex = 6;
            this.Btn_editar.Text = "Editar";
            this.Btn_editar.UseVisualStyleBackColor = false;
            this.Btn_editar.Click += new System.EventHandler(this.Btn_editar_Click);
            // 
            // Btn_eliminar
            // 
            this.Btn_eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.Btn_eliminar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_eliminar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_eliminar.Location = new System.Drawing.Point(1055, 679);
            this.Btn_eliminar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_eliminar.Name = "Btn_eliminar";
            this.Btn_eliminar.Size = new System.Drawing.Size(155, 37);
            this.Btn_eliminar.TabIndex = 8;
            this.Btn_eliminar.Text = "Eliminar";
            this.Btn_eliminar.UseVisualStyleBackColor = false;
            this.Btn_eliminar.Click += new System.EventHandler(this.Btn_eliminar_Click);
            // 
            // dataGridViewSucursal
            // 
            this.dataGridViewSucursal.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.dataGridViewSucursal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSucursal.Location = new System.Drawing.Point(23, 199);
            this.dataGridViewSucursal.Name = "dataGridViewSucursal";
            this.dataGridViewSucursal.RowHeadersWidth = 51;
            this.dataGridViewSucursal.RowTemplate.Height = 24;
            this.dataGridViewSucursal.Size = new System.Drawing.Size(1198, 375);
            this.dataGridViewSucursal.TabIndex = 9;
            // 
            // Sucursales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(1256, 758);
            this.Controls.Add(this.dataGridViewSucursal);
            this.Controls.Add(this.Btn_eliminar);
            this.Controls.Add(this.Btn_editar);
            this.Controls.Add(this.Btn_agregar);
            this.Controls.Add(this.Btn_filtrar);
            this.Controls.Add(this.Lab_sucursales);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Sucursales";
            this.Text = "Sucursales";
            this.Load += new System.EventHandler(this.Sucursales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSucursal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Lab_sucursales;
        private System.Windows.Forms.Button Btn_filtrar;
        private System.Windows.Forms.Button Btn_agregar;
        private System.Windows.Forms.Button Btn_editar;
        private System.Windows.Forms.Button Btn_eliminar;
        private System.Windows.Forms.DataGridView dataGridViewSucursal;
    }
}