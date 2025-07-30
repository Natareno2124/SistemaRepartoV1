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
            this.Deco1 = new System.Windows.Forms.Panel();
            this.Deco2 = new System.Windows.Forms.Panel();
            this.Deco3 = new System.Windows.Forms.Panel();
            this.Deco4 = new System.Windows.Forms.Panel();
            this.LabelUsuarios = new System.Windows.Forms.Label();
            this.LabelID = new System.Windows.Forms.Label();
            this.LabelNombre = new System.Windows.Forms.Label();
            this.LabelFN = new System.Windows.Forms.Label();
            this.LabelContacto = new System.Windows.Forms.Label();
            this.LabelRol = new System.Windows.Forms.Label();
            this.DBID = new System.Windows.Forms.DataGridView();
            this.DBNombre = new System.Windows.Forms.DataGridView();
            this.DBFecha_Nc = new System.Windows.Forms.DataGridView();
            this.DBContacto = new System.Windows.Forms.DataGridView();
            this.DBRol = new System.Windows.Forms.DataGridView();
            this.BuscarNmbr = new System.Windows.Forms.TextBox();
            this.Deco = new System.Windows.Forms.Panel();
            this.ListRol = new System.Windows.Forms.ComboBox();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.Deco2.SuspendLayout();
            this.Deco3.SuspendLayout();
            this.Deco4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DBID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBFecha_Nc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBContacto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBRol)).BeginInit();
            this.SuspendLayout();
            // 
            // Deco1
            // 
            this.Deco1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(153)))), ((int)(((byte)(174)))));
            this.Deco1.Location = new System.Drawing.Point(233, 110);
            this.Deco1.Name = "Deco1";
            this.Deco1.Size = new System.Drawing.Size(1017, 15);
            this.Deco1.TabIndex = 0;
            // 
            // Deco2
            // 
            this.Deco2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Deco2.Controls.Add(this.ListRol);
            this.Deco2.Controls.Add(this.BuscarNmbr);
            this.Deco2.Location = new System.Drawing.Point(233, 131);
            this.Deco2.Name = "Deco2";
            this.Deco2.Size = new System.Drawing.Size(1017, 48);
            this.Deco2.TabIndex = 1;
            // 
            // Deco3
            // 
            this.Deco3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Deco3.Controls.Add(this.LabelRol);
            this.Deco3.Controls.Add(this.LabelContacto);
            this.Deco3.Controls.Add(this.LabelFN);
            this.Deco3.Controls.Add(this.LabelNombre);
            this.Deco3.Controls.Add(this.LabelID);
            this.Deco3.Location = new System.Drawing.Point(233, 185);
            this.Deco3.Name = "Deco3";
            this.Deco3.Size = new System.Drawing.Size(1017, 39);
            this.Deco3.TabIndex = 2;
            // 
            // Deco4
            // 
            this.Deco4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.Deco4.Controls.Add(this.DBRol);
            this.Deco4.Controls.Add(this.DBContacto);
            this.Deco4.Controls.Add(this.DBFecha_Nc);
            this.Deco4.Controls.Add(this.DBNombre);
            this.Deco4.Controls.Add(this.DBID);
            this.Deco4.Location = new System.Drawing.Point(233, 230);
            this.Deco4.Name = "Deco4";
            this.Deco4.Size = new System.Drawing.Size(1017, 382);
            this.Deco4.TabIndex = 3;
            // 
            // LabelUsuarios
            // 
            this.LabelUsuarios.AutoSize = true;
            this.LabelUsuarios.BackColor = System.Drawing.SystemColors.Control;
            this.LabelUsuarios.Font = new System.Drawing.Font("Arial Black", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUsuarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.LabelUsuarios.Location = new System.Drawing.Point(236, 45);
            this.LabelUsuarios.Name = "LabelUsuarios";
            this.LabelUsuarios.Size = new System.Drawing.Size(240, 62);
            this.LabelUsuarios.TabIndex = 4;
            this.LabelUsuarios.Text = "Usuarios";
            // 
            // LabelID
            // 
            this.LabelID.AutoSize = true;
            this.LabelID.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(84)))), ((int)(((byte)(109)))));
            this.LabelID.Location = new System.Drawing.Point(29, 2);
            this.LabelID.Name = "LabelID";
            this.LabelID.Size = new System.Drawing.Size(43, 33);
            this.LabelID.TabIndex = 5;
            this.LabelID.Text = "ID";
            // 
            // LabelNombre
            // 
            this.LabelNombre.AutoSize = true;
            this.LabelNombre.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(84)))), ((int)(((byte)(109)))));
            this.LabelNombre.Location = new System.Drawing.Point(184, 2);
            this.LabelNombre.Name = "LabelNombre";
            this.LabelNombre.Size = new System.Drawing.Size(122, 33);
            this.LabelNombre.TabIndex = 6;
            this.LabelNombre.Text = "Nombre";
            // 
            // LabelFN
            // 
            this.LabelFN.AutoSize = true;
            this.LabelFN.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(84)))), ((int)(((byte)(109)))));
            this.LabelFN.Location = new System.Drawing.Point(434, 8);
            this.LabelFN.Name = "LabelFN";
            this.LabelFN.Size = new System.Drawing.Size(207, 24);
            this.LabelFN.TabIndex = 7;
            this.LabelFN.Text = "Fecha de Nacimiento";
            // 
            // LabelContacto
            // 
            this.LabelContacto.AutoSize = true;
            this.LabelContacto.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelContacto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(84)))), ((int)(((byte)(109)))));
            this.LabelContacto.Location = new System.Drawing.Point(683, 5);
            this.LabelContacto.Name = "LabelContacto";
            this.LabelContacto.Size = new System.Drawing.Size(136, 33);
            this.LabelContacto.TabIndex = 8;
            this.LabelContacto.Text = "Contacto";
            // 
            // LabelRol
            // 
            this.LabelRol.AutoSize = true;
            this.LabelRol.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(84)))), ((int)(((byte)(109)))));
            this.LabelRol.Location = new System.Drawing.Point(899, 2);
            this.LabelRol.Name = "LabelRol";
            this.LabelRol.Size = new System.Drawing.Size(60, 33);
            this.LabelRol.TabIndex = 9;
            this.LabelRol.Text = "Rol";
            // 
            // DBID
            // 
            this.DBID.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DBID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DBID.Location = new System.Drawing.Point(6, 6);
            this.DBID.Name = "DBID";
            this.DBID.RowHeadersWidth = 51;
            this.DBID.Size = new System.Drawing.Size(83, 368);
            this.DBID.TabIndex = 0;
            // 
            // DBNombre
            // 
            this.DBNombre.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DBNombre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DBNombre.Location = new System.Drawing.Point(93, 6);
            this.DBNombre.Name = "DBNombre";
            this.DBNombre.RowHeadersWidth = 51;
            this.DBNombre.Size = new System.Drawing.Size(320, 368);
            this.DBNombre.TabIndex = 1;
            // 
            // DBFecha_Nc
            // 
            this.DBFecha_Nc.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DBFecha_Nc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DBFecha_Nc.Location = new System.Drawing.Point(417, 6);
            this.DBFecha_Nc.Name = "DBFecha_Nc";
            this.DBFecha_Nc.RowHeadersWidth = 51;
            this.DBFecha_Nc.Size = new System.Drawing.Size(240, 368);
            this.DBFecha_Nc.TabIndex = 2;
            // 
            // DBContacto
            // 
            this.DBContacto.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DBContacto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DBContacto.Location = new System.Drawing.Point(661, 6);
            this.DBContacto.Name = "DBContacto";
            this.DBContacto.RowHeadersWidth = 51;
            this.DBContacto.Size = new System.Drawing.Size(180, 368);
            this.DBContacto.TabIndex = 3;
            // 
            // DBRol
            // 
            this.DBRol.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DBRol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DBRol.Location = new System.Drawing.Point(844, 6);
            this.DBRol.Name = "DBRol";
            this.DBRol.RowHeadersWidth = 51;
            this.DBRol.Size = new System.Drawing.Size(166, 368);
            this.DBRol.TabIndex = 4;
            // 
            // BuscarNmbr
            // 
            this.BuscarNmbr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(162)))), ((int)(((byte)(190)))));
            this.BuscarNmbr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BuscarNmbr.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarNmbr.ForeColor = System.Drawing.SystemColors.Menu;
            this.BuscarNmbr.Location = new System.Drawing.Point(93, 8);
            this.BuscarNmbr.Name = "BuscarNmbr";
            this.BuscarNmbr.Size = new System.Drawing.Size(292, 30);
            this.BuscarNmbr.TabIndex = 0;
            this.BuscarNmbr.Text = "Buscar por Nombre";
            // 
            // Deco
            // 
            this.Deco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(153)))), ((int)(((byte)(174)))));
            this.Deco.Location = new System.Drawing.Point(233, -6);
            this.Deco.Name = "Deco";
            this.Deco.Size = new System.Drawing.Size(1017, 61);
            this.Deco.TabIndex = 1;
            // 
            // ListRol
            // 
            this.ListRol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(162)))), ((int)(((byte)(190)))));
            this.ListRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListRol.ForeColor = System.Drawing.SystemColors.Menu;
            this.ListRol.FormattingEnabled = true;
            this.ListRol.Location = new System.Drawing.Point(595, 6);
            this.ListRol.Name = "ListRol";
            this.ListRol.Size = new System.Drawing.Size(246, 33);
            this.ListRol.TabIndex = 5;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.BtnAgregar.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnAgregar.Location = new System.Drawing.Point(664, 649);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(142, 42);
            this.BtnAgregar.TabIndex = 5;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.BtnEliminar.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnEliminar.Location = new System.Drawing.Point(812, 649);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(142, 42);
            this.BtnEliminar.TabIndex = 6;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            // 
            // BtnModificar
            // 
            this.BtnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.BtnModificar.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificar.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnModificar.Location = new System.Drawing.Point(960, 649);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(142, 42);
            this.BtnModificar.TabIndex = 7;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = false;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.BtnGuardar.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnGuardar.Location = new System.Drawing.Point(1108, 649);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(142, 42);
            this.BtnGuardar.TabIndex = 8;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 723);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.Deco);
            this.Controls.Add(this.LabelUsuarios);
            this.Controls.Add(this.Deco4);
            this.Controls.Add(this.Deco3);
            this.Controls.Add(this.Deco2);
            this.Controls.Add(this.Deco1);
            this.Name = "Usuarios";
            this.Text = "Usuarios";
            this.Deco2.ResumeLayout(false);
            this.Deco2.PerformLayout();
            this.Deco3.ResumeLayout(false);
            this.Deco3.PerformLayout();
            this.Deco4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DBID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBFecha_Nc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBContacto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBRol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Deco1;
        private System.Windows.Forms.Panel Deco2;
        private System.Windows.Forms.Panel Deco3;
        private System.Windows.Forms.Panel Deco4;
        private System.Windows.Forms.Label LabelID;
        private System.Windows.Forms.Label LabelUsuarios;
        private System.Windows.Forms.Label LabelRol;
        private System.Windows.Forms.Label LabelContacto;
        private System.Windows.Forms.Label LabelFN;
        private System.Windows.Forms.Label LabelNombre;
        private System.Windows.Forms.DataGridView DBRol;
        private System.Windows.Forms.DataGridView DBContacto;
        private System.Windows.Forms.DataGridView DBFecha_Nc;
        private System.Windows.Forms.DataGridView DBNombre;
        private System.Windows.Forms.DataGridView DBID;
        private System.Windows.Forms.TextBox BuscarNmbr;
        private System.Windows.Forms.Panel Deco;
        private System.Windows.Forms.ComboBox ListRol;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnGuardar;
    }
}