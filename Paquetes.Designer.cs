namespace SistemaRepartoG4
{
    partial class Paquetes
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
            this.btnAdministrador = new System.Windows.Forms.Button();
            this.lineadecorativa = new System.Windows.Forms.Label();
            this.labelpaquetes = new System.Windows.Forms.Label();
            this.dataGridViewPaquetes = new System.Windows.Forms.DataGridView();
            this.Btn_eliminar_paquete = new System.Windows.Forms.Button();
            this.Btn_editar_paquete = new System.Windows.Forms.Button();
            this.Btn_agregar_paquete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPaquetes)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(153)))), ((int)(((byte)(174)))));
            this.panel1.Location = new System.Drawing.Point(-2, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1265, 56);
            this.panel1.TabIndex = 0;
            // 
            // btnAdministrador
            // 
            this.btnAdministrador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(153)))), ((int)(((byte)(174)))));
            this.btnAdministrador.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdministrador.ForeColor = System.Drawing.Color.White;
            this.btnAdministrador.Location = new System.Drawing.Point(967, 14);
            this.btnAdministrador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdministrador.Name = "btnAdministrador";
            this.btnAdministrador.Size = new System.Drawing.Size(235, 31);
            this.btnAdministrador.TabIndex = 20;
            this.btnAdministrador.Text = "User Administrador";
            this.btnAdministrador.UseVisualStyleBackColor = false;
            // 
            // lineadecorativa
            // 
            this.lineadecorativa.AutoSize = true;
            this.lineadecorativa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lineadecorativa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.lineadecorativa.Location = new System.Drawing.Point(75, 125);
            this.lineadecorativa.Name = "lineadecorativa";
            this.lineadecorativa.Size = new System.Drawing.Size(1125, 29);
            this.lineadecorativa.TabIndex = 22;
            this.lineadecorativa.Text = "---------------------------------------------------------------------------------" +
    "----------------------------------------------------------";
            // 
            // labelpaquetes
            // 
            this.labelpaquetes.AutoSize = true;
            this.labelpaquetes.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpaquetes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.labelpaquetes.Location = new System.Drawing.Point(72, 77);
            this.labelpaquetes.Name = "labelpaquetes";
            this.labelpaquetes.Size = new System.Drawing.Size(223, 48);
            this.labelpaquetes.TabIndex = 21;
            this.labelpaquetes.Text = "PAQUETES";
            // 
            // dataGridViewPaquetes
            // 
            this.dataGridViewPaquetes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPaquetes.Location = new System.Drawing.Point(80, 186);
            this.dataGridViewPaquetes.Name = "dataGridViewPaquetes";
            this.dataGridViewPaquetes.RowHeadersWidth = 51;
            this.dataGridViewPaquetes.RowTemplate.Height = 24;
            this.dataGridViewPaquetes.Size = new System.Drawing.Size(1120, 399);
            this.dataGridViewPaquetes.TabIndex = 23;
            this.dataGridViewPaquetes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPaquetes_CellContentClick);
            // 
            // Btn_eliminar_paquete
            // 
            this.Btn_eliminar_paquete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.Btn_eliminar_paquete.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_eliminar_paquete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_eliminar_paquete.Location = new System.Drawing.Point(1047, 635);
            this.Btn_eliminar_paquete.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_eliminar_paquete.Name = "Btn_eliminar_paquete";
            this.Btn_eliminar_paquete.Size = new System.Drawing.Size(155, 37);
            this.Btn_eliminar_paquete.TabIndex = 27;
            this.Btn_eliminar_paquete.Text = "Eliminar";
            this.Btn_eliminar_paquete.UseVisualStyleBackColor = false;
            this.Btn_eliminar_paquete.Click += new System.EventHandler(this.Btn_eliminar_paquete_Click);
            // 
            // Btn_editar_paquete
            // 
            this.Btn_editar_paquete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.Btn_editar_paquete.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_editar_paquete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_editar_paquete.Location = new System.Drawing.Point(884, 635);
            this.Btn_editar_paquete.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_editar_paquete.Name = "Btn_editar_paquete";
            this.Btn_editar_paquete.Size = new System.Drawing.Size(155, 37);
            this.Btn_editar_paquete.TabIndex = 25;
            this.Btn_editar_paquete.Text = "Editar";
            this.Btn_editar_paquete.UseVisualStyleBackColor = false;
            this.Btn_editar_paquete.Click += new System.EventHandler(this.Btn_editar_paquete_Click);
            // 
            // Btn_agregar_paquete
            // 
            this.Btn_agregar_paquete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.Btn_agregar_paquete.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_agregar_paquete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_agregar_paquete.Location = new System.Drawing.Point(722, 634);
            this.Btn_agregar_paquete.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_agregar_paquete.Name = "Btn_agregar_paquete";
            this.Btn_agregar_paquete.Size = new System.Drawing.Size(155, 37);
            this.Btn_agregar_paquete.TabIndex = 24;
            this.Btn_agregar_paquete.Text = "Agregar";
            this.Btn_agregar_paquete.UseVisualStyleBackColor = false;
            this.Btn_agregar_paquete.Click += new System.EventHandler(this.Btn_agregar_paquete_Click);
            // 
            // Paquetes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 723);
            this.Controls.Add(this.Btn_eliminar_paquete);
            this.Controls.Add(this.Btn_editar_paquete);
            this.Controls.Add(this.Btn_agregar_paquete);
            this.Controls.Add(this.dataGridViewPaquetes);
            this.Controls.Add(this.lineadecorativa);
            this.Controls.Add(this.labelpaquetes);
            this.Controls.Add(this.btnAdministrador);
            this.Controls.Add(this.panel1);
            this.Name = "Paquetes";
            this.Text = "Paquetes";
            this.Load += new System.EventHandler(this.Paquetes_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPaquetes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAdministrador;
        private System.Windows.Forms.Label lineadecorativa;
        private System.Windows.Forms.Label labelpaquetes;
        private System.Windows.Forms.DataGridView dataGridViewPaquetes;
        private System.Windows.Forms.Button Btn_eliminar_paquete;
        private System.Windows.Forms.Button Btn_editar_paquete;
        private System.Windows.Forms.Button Btn_agregar_paquete;
    }
}