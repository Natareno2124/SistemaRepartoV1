namespace SistemaRepartoG4
{
    partial class Bodegas
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Encargado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ruta_Recoleccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ruta_Entrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btn_eliminar = new System.Windows.Forms.Button();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.Btn_editar = new System.Windows.Forms.Button();
            this.Btn_agregar = new System.Windows.Forms.Button();
            this.Btn_filtrar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Lab_sucursal = new System.Windows.Forms.Label();
            this.Lab_rutasEntrega = new System.Windows.Forms.Label();
            this.Lab_rutasRecoleccion = new System.Windows.Forms.Label();
            this.Lab_encargado = new System.Windows.Forms.Label();
            this.Lab_codigo = new System.Windows.Forms.Label();
            this.Lab_bodegas = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(153)))), ((int)(((byte)(174)))));
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(940, 63);
            this.panel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.Encargado,
            this.Ruta_Recoleccion,
            this.Ruta_Entrega,
            this.Sucursal});
            this.dataGridView1.Location = new System.Drawing.Point(26, 235);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(880, 310);
            this.dataGridView1.TabIndex = 18;
            // 
            // codigo
            // 
            this.codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.codigo.FillWeight = 150F;
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.Width = 65;
            // 
            // Encargado
            // 
            this.Encargado.HeaderText = "Encargado";
            this.Encargado.Name = "Encargado";
            // 
            // Ruta_Recoleccion
            // 
            this.Ruta_Recoleccion.HeaderText = "Ruta_Recoleccion";
            this.Ruta_Recoleccion.Name = "Ruta_Recoleccion";
            // 
            // Ruta_Entrega
            // 
            this.Ruta_Entrega.HeaderText = "Ruta_Entrega";
            this.Ruta_Entrega.Name = "Ruta_Entrega";
            // 
            // Sucursal
            // 
            this.Sucursal.HeaderText = "Sucursal";
            this.Sucursal.Name = "Sucursal";
            // 
            // Btn_eliminar
            // 
            this.Btn_eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.Btn_eliminar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_eliminar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_eliminar.Location = new System.Drawing.Point(791, 552);
            this.Btn_eliminar.Name = "Btn_eliminar";
            this.Btn_eliminar.Size = new System.Drawing.Size(116, 30);
            this.Btn_eliminar.TabIndex = 17;
            this.Btn_eliminar.Text = "Eliminar";
            this.Btn_eliminar.UseVisualStyleBackColor = false;
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.Btn_guardar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_guardar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_guardar.Location = new System.Drawing.Point(669, 552);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(116, 30);
            this.Btn_guardar.TabIndex = 16;
            this.Btn_guardar.Text = "Guardar";
            this.Btn_guardar.UseVisualStyleBackColor = false;
            // 
            // Btn_editar
            // 
            this.Btn_editar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.Btn_editar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_editar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_editar.Location = new System.Drawing.Point(550, 552);
            this.Btn_editar.Name = "Btn_editar";
            this.Btn_editar.Size = new System.Drawing.Size(116, 30);
            this.Btn_editar.TabIndex = 15;
            this.Btn_editar.Text = "Editar";
            this.Btn_editar.UseVisualStyleBackColor = false;
            // 
            // Btn_agregar
            // 
            this.Btn_agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.Btn_agregar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_agregar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_agregar.Location = new System.Drawing.Point(428, 551);
            this.Btn_agregar.Name = "Btn_agregar";
            this.Btn_agregar.Size = new System.Drawing.Size(116, 30);
            this.Btn_agregar.TabIndex = 14;
            this.Btn_agregar.Text = "Agregar";
            this.Btn_agregar.UseVisualStyleBackColor = false;
            // 
            // Btn_filtrar
            // 
            this.Btn_filtrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(153)))), ((int)(((byte)(174)))));
            this.Btn_filtrar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_filtrar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Btn_filtrar.Location = new System.Drawing.Point(37, 561);
            this.Btn_filtrar.Name = "Btn_filtrar";
            this.Btn_filtrar.Size = new System.Drawing.Size(116, 30);
            this.Btn_filtrar.TabIndex = 13;
            this.Btn_filtrar.Text = "Filtrar";
            this.Btn_filtrar.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Lab_sucursal);
            this.panel3.Controls.Add(this.Lab_rutasEntrega);
            this.panel3.Controls.Add(this.Lab_rutasRecoleccion);
            this.panel3.Controls.Add(this.Lab_encargado);
            this.panel3.Controls.Add(this.Lab_codigo);
            this.panel3.Location = new System.Drawing.Point(26, 167);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(881, 45);
            this.panel3.TabIndex = 12;
            // 
            // Lab_sucursal
            // 
            this.Lab_sucursal.AutoSize = true;
            this.Lab_sucursal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_sucursal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.Lab_sucursal.Location = new System.Drawing.Point(548, 12);
            this.Lab_sucursal.Name = "Lab_sucursal";
            this.Lab_sucursal.Size = new System.Drawing.Size(77, 19);
            this.Lab_sucursal.TabIndex = 5;
            this.Lab_sucursal.Text = "Sucursal";
            // 
            // Lab_rutasEntrega
            // 
            this.Lab_rutasEntrega.AutoSize = true;
            this.Lab_rutasEntrega.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_rutasEntrega.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.Lab_rutasEntrega.Location = new System.Drawing.Point(401, 12);
            this.Lab_rutasEntrega.Name = "Lab_rutasEntrega";
            this.Lab_rutasEntrega.Size = new System.Drawing.Size(141, 19);
            this.Lab_rutasEntrega.TabIndex = 4;
            this.Lab_rutasEntrega.Text = "Rutas de Entrega";
            // 
            // Lab_rutasRecoleccion
            // 
            this.Lab_rutasRecoleccion.AutoSize = true;
            this.Lab_rutasRecoleccion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_rutasRecoleccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.Lab_rutasRecoleccion.Location = new System.Drawing.Point(211, 12);
            this.Lab_rutasRecoleccion.Name = "Lab_rutasRecoleccion";
            this.Lab_rutasRecoleccion.Size = new System.Drawing.Size(170, 19);
            this.Lab_rutasRecoleccion.TabIndex = 3;
            this.Lab_rutasRecoleccion.Text = "Rutas de recoleccion";
            this.Lab_rutasRecoleccion.Click += new System.EventHandler(this.label5_Click);
            // 
            // Lab_encargado
            // 
            this.Lab_encargado.AutoSize = true;
            this.Lab_encargado.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_encargado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.Lab_encargado.Location = new System.Drawing.Point(102, 12);
            this.Lab_encargado.Name = "Lab_encargado";
            this.Lab_encargado.Size = new System.Drawing.Size(93, 19);
            this.Lab_encargado.TabIndex = 2;
            this.Lab_encargado.Text = "Encargado";
            // 
            // Lab_codigo
            // 
            this.Lab_codigo.AutoSize = true;
            this.Lab_codigo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_codigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.Lab_codigo.Location = new System.Drawing.Point(18, 12);
            this.Lab_codigo.Name = "Lab_codigo";
            this.Lab_codigo.Size = new System.Drawing.Size(65, 19);
            this.Lab_codigo.TabIndex = 1;
            this.Lab_codigo.Text = "Código";
            // 
            // Lab_bodegas
            // 
            this.Lab_bodegas.AutoSize = true;
            this.Lab_bodegas.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_bodegas.Location = new System.Drawing.Point(20, 97);
            this.Lab_bodegas.Name = "Lab_bodegas";
            this.Lab_bodegas.Size = new System.Drawing.Size(133, 29);
            this.Lab_bodegas.TabIndex = 11;
            this.Lab_bodegas.Text = "BODEGAS";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.panel2.Location = new System.Drawing.Point(25, 129);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(881, 10);
            this.panel2.TabIndex = 10;
            // 
            // Bodegas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 616);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Btn_eliminar);
            this.Controls.Add(this.Btn_guardar);
            this.Controls.Add(this.Btn_editar);
            this.Controls.Add(this.Btn_agregar);
            this.Controls.Add(this.Btn_filtrar);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Lab_bodegas);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Bodegas";
            this.Text = "Bodegas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Btn_eliminar;
        private System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.Button Btn_editar;
        private System.Windows.Forms.Button Btn_agregar;
        private System.Windows.Forms.Button Btn_filtrar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label Lab_sucursal;
        private System.Windows.Forms.Label Lab_rutasEntrega;
        private System.Windows.Forms.Label Lab_rutasRecoleccion;
        private System.Windows.Forms.Label Lab_encargado;
        private System.Windows.Forms.Label Lab_codigo;
        private System.Windows.Forms.Label Lab_bodegas;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Encargado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ruta_Recoleccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ruta_Entrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sucursal;
    }
}