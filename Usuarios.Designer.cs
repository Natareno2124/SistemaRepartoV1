namespace SistemaRepartoG4
{
    partial class Usuarios
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
            this.Pnl_lineaSuperior = new System.Windows.Forms.Panel();
            this.Btn_salir = new System.Windows.Forms.Button();
            this.Pnl_lineaUsuario = new System.Windows.Forms.Panel();
            this.DB = new System.Windows.Forms.DataGridView();
            this.Txt_buscarNombre = new System.Windows.Forms.TextBox();
            this.Cbo_rol = new System.Windows.Forms.ComboBox();
            this.Btn_agregar = new System.Windows.Forms.Button();
            this.Lbl_usuarios = new System.Windows.Forms.Label();
            this.Btn_editar = new System.Windows.Forms.Button();
            this.Btn_eliminar = new System.Windows.Forms.Button();
            this.Pnl_lineaSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DB)).BeginInit();
            this.SuspendLayout();
            // 
            // Pnl_lineaSuperior
            // 
            this.Pnl_lineaSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(153)))), ((int)(((byte)(174)))));
            this.Pnl_lineaSuperior.Controls.Add(this.Btn_salir);
            this.Pnl_lineaSuperior.Location = new System.Drawing.Point(0, 0);
            this.Pnl_lineaSuperior.Name = "Pnl_lineaSuperior";
            this.Pnl_lineaSuperior.Size = new System.Drawing.Size(1262, 50);
            this.Pnl_lineaSuperior.TabIndex = 0;
            this.Pnl_lineaSuperior.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Btn_salir
            // 
            this.Btn_salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.Btn_salir.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_salir.ForeColor = System.Drawing.SystemColors.Control;
            this.Btn_salir.Location = new System.Drawing.Point(12, 6);
            this.Btn_salir.Name = "Btn_salir";
            this.Btn_salir.Size = new System.Drawing.Size(66, 36);
            this.Btn_salir.TabIndex = 0;
            this.Btn_salir.Text = "Salir";
            this.Btn_salir.UseVisualStyleBackColor = false;
            // 
            // Pnl_lineaUsuario
            // 
            this.Pnl_lineaUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(153)))), ((int)(((byte)(174)))));
            this.Pnl_lineaUsuario.Location = new System.Drawing.Point(1, 114);
            this.Pnl_lineaUsuario.Name = "Pnl_lineaUsuario";
            this.Pnl_lineaUsuario.Size = new System.Drawing.Size(1261, 14);
            this.Pnl_lineaUsuario.TabIndex = 1;
            // 
            // DB
            // 
            this.DB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DB.Location = new System.Drawing.Point(25, 203);
            this.DB.Name = "DB";
            this.DB.RowHeadersWidth = 51;
            this.DB.Size = new System.Drawing.Size(1225, 444);
            this.DB.TabIndex = 2;
            this.DB.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Txt_buscarNombre
            // 
            this.Txt_buscarNombre.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_buscarNombre.Location = new System.Drawing.Point(25, 158);
            this.Txt_buscarNombre.Name = "Txt_buscarNombre";
            this.Txt_buscarNombre.Size = new System.Drawing.Size(244, 22);
            this.Txt_buscarNombre.TabIndex = 4;
            this.Txt_buscarNombre.Text = "Buscar por Nombre";
            // 
            // Cbo_rol
            // 
            this.Cbo_rol.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_rol.FormattingEnabled = true;
            this.Cbo_rol.Location = new System.Drawing.Point(296, 158);
            this.Cbo_rol.Name = "Cbo_rol";
            this.Cbo_rol.Size = new System.Drawing.Size(200, 24);
            this.Cbo_rol.TabIndex = 5;
            this.Cbo_rol.Text = "Rol";
            // 
            // Btn_agregar
            // 
            this.Btn_agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.Btn_agregar.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_agregar.ForeColor = System.Drawing.SystemColors.Control;
            this.Btn_agregar.Location = new System.Drawing.Point(1049, 653);
            this.Btn_agregar.Name = "Btn_agregar";
            this.Btn_agregar.Size = new System.Drawing.Size(63, 58);
            this.Btn_agregar.TabIndex = 9;
            this.Btn_agregar.Text = "Agregar";
            this.Btn_agregar.UseVisualStyleBackColor = false;
            this.Btn_agregar.Click += new System.EventHandler(this.button5_Click);
            // 
            // Lbl_usuarios
            // 
            this.Lbl_usuarios.AutoSize = true;
            this.Lbl_usuarios.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_usuarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.Lbl_usuarios.Location = new System.Drawing.Point(2, 55);
            this.Lbl_usuarios.Name = "Lbl_usuarios";
            this.Lbl_usuarios.Size = new System.Drawing.Size(258, 56);
            this.Lbl_usuarios.TabIndex = 10;
            this.Lbl_usuarios.Text = "USUARIOS";
            // 
            // Btn_editar
            // 
            this.Btn_editar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.Btn_editar.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_editar.ForeColor = System.Drawing.SystemColors.Control;
            this.Btn_editar.Location = new System.Drawing.Point(1118, 653);
            this.Btn_editar.Name = "Btn_editar";
            this.Btn_editar.Size = new System.Drawing.Size(63, 58);
            this.Btn_editar.TabIndex = 11;
            this.Btn_editar.Text = "Editar";
            this.Btn_editar.UseVisualStyleBackColor = false;
            // 
            // Btn_eliminar
            // 
            this.Btn_eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.Btn_eliminar.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_eliminar.ForeColor = System.Drawing.SystemColors.Control;
            this.Btn_eliminar.Location = new System.Drawing.Point(1187, 653);
            this.Btn_eliminar.Name = "Btn_eliminar";
            this.Btn_eliminar.Size = new System.Drawing.Size(63, 58);
            this.Btn_eliminar.TabIndex = 13;
            this.Btn_eliminar.Text = "Eliminar";
            this.Btn_eliminar.UseVisualStyleBackColor = false;
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 723);
            this.Controls.Add(this.Btn_eliminar);
            this.Controls.Add(this.Btn_editar);
            this.Controls.Add(this.Lbl_usuarios);
            this.Controls.Add(this.Btn_agregar);
            this.Controls.Add(this.Cbo_rol);
            this.Controls.Add(this.Txt_buscarNombre);
            this.Controls.Add(this.DB);
            this.Controls.Add(this.Pnl_lineaUsuario);
            this.Controls.Add(this.Pnl_lineaSuperior);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Usuarios";
            this.Text = "Usuarios";
            this.Pnl_lineaSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_lineaSuperior;
        private System.Windows.Forms.Panel Pnl_lineaUsuario;
        private System.Windows.Forms.DataGridView DB;
        private System.Windows.Forms.Button Btn_salir;
        private System.Windows.Forms.TextBox Txt_buscarNombre;
        private System.Windows.Forms.ComboBox Cbo_rol;
        private System.Windows.Forms.Button Btn_agregar;
        private System.Windows.Forms.Label Lbl_usuarios;
        private System.Windows.Forms.Button Btn_editar;
        private System.Windows.Forms.Button Btn_eliminar;
    }
}