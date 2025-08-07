namespace SistemaRepartoG4
{
    partial class MisEntregas
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
            this.lineadecorativa = new System.Windows.Forms.Label();
            this.labelentregaspiloto = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUserPiloto = new System.Windows.Forms.Button();
            this.guiamadre = new System.Windows.Forms.TextBox();
            this.btnReportar = new System.Windows.Forms.Button();
            this.rptproblema = new System.Windows.Forms.Label();
            this.cmReportar = new System.Windows.Forms.ComboBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnBuscarEntrega = new System.Windows.Forms.Button();
            this.dataGridViewPaquetes = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPaquetes)).BeginInit();
            this.SuspendLayout();
            // 
            // lineadecorativa
            // 
            this.lineadecorativa.AutoSize = true;
            this.lineadecorativa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lineadecorativa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.lineadecorativa.Location = new System.Drawing.Point(75, 125);
            this.lineadecorativa.Name = "lineadecorativa";
            this.lineadecorativa.Size = new System.Drawing.Size(1125, 29);
            this.lineadecorativa.TabIndex = 9;
            this.lineadecorativa.Text = "---------------------------------------------------------------------------------" +
    "----------------------------------------------------------";
            // 
            // labelentregaspiloto
            // 
            this.labelentregaspiloto.AutoSize = true;
            this.labelentregaspiloto.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelentregaspiloto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.labelentregaspiloto.Location = new System.Drawing.Point(72, 77);
            this.labelentregaspiloto.Name = "labelentregaspiloto";
            this.labelentregaspiloto.Size = new System.Drawing.Size(309, 48);
            this.labelentregaspiloto.TabIndex = 8;
            this.labelentregaspiloto.Text = "MIS ENTREGAS";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(153)))), ((int)(((byte)(174)))));
            this.panel1.Controls.Add(this.btnUserPiloto);
            this.panel1.Location = new System.Drawing.Point(-2, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1265, 56);
            this.panel1.TabIndex = 7;
            // 
            // btnUserPiloto
            // 
            this.btnUserPiloto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(153)))), ((int)(((byte)(174)))));
            this.btnUserPiloto.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserPiloto.ForeColor = System.Drawing.Color.White;
            this.btnUserPiloto.Location = new System.Drawing.Point(1018, 14);
            this.btnUserPiloto.Name = "btnUserPiloto";
            this.btnUserPiloto.Size = new System.Drawing.Size(172, 31);
            this.btnUserPiloto.TabIndex = 0;
            this.btnUserPiloto.Text = "User Repartidor";
            this.btnUserPiloto.UseVisualStyleBackColor = false;
            // 
            // guiamadre
            // 
            this.guiamadre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(162)))), ((int)(((byte)(190)))));
            this.guiamadre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.guiamadre.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guiamadre.ForeColor = System.Drawing.Color.White;
            this.guiamadre.Location = new System.Drawing.Point(80, 172);
            this.guiamadre.Name = "guiamadre";
            this.guiamadre.Size = new System.Drawing.Size(615, 32);
            this.guiamadre.TabIndex = 13;
            this.guiamadre.TextChanged += new System.EventHandler(this.guiamadre_TextChanged);
            // 
            // btnReportar
            // 
            this.btnReportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(84)))), ((int)(((byte)(109)))));
            this.btnReportar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportar.ForeColor = System.Drawing.Color.White;
            this.btnReportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportar.Location = new System.Drawing.Point(523, 658);
            this.btnReportar.Name = "btnReportar";
            this.btnReportar.Size = new System.Drawing.Size(172, 43);
            this.btnReportar.TabIndex = 14;
            this.btnReportar.Text = "Reportar";
            this.btnReportar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportar.UseVisualStyleBackColor = false;
            this.btnReportar.Click += new System.EventHandler(this.btnReportar_Click);
            // 
            // rptproblema
            // 
            this.rptproblema.AutoSize = true;
            this.rptproblema.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rptproblema.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(84)))), ((int)(((byte)(109)))));
            this.rptproblema.Location = new System.Drawing.Point(80, 620);
            this.rptproblema.Name = "rptproblema";
            this.rptproblema.Size = new System.Drawing.Size(249, 28);
            this.rptproblema.TabIndex = 15;
            this.rptproblema.Text = "Reportar un problema";
            // 
            // cmReportar
            // 
            this.cmReportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(162)))), ((int)(((byte)(190)))));
            this.cmReportar.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmReportar.ForeColor = System.Drawing.Color.White;
            this.cmReportar.FormattingEnabled = true;
            this.cmReportar.Items.AddRange(new object[] {
            "Cliente no se encontraba",
            "Paquete dañado",
            "Dirección incorrecta",
            "Otro"});
            this.cmReportar.Location = new System.Drawing.Point(80, 661);
            this.cmReportar.Name = "cmReportar";
            this.cmReportar.Size = new System.Drawing.Size(398, 34);
            this.cmReportar.TabIndex = 16;
            this.cmReportar.SelectedIndexChanged += new System.EventHandler(this.cmReportar_SelectedIndexChanged);
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(153)))), ((int)(((byte)(174)))));
            this.btnRegresar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnRegresar.ForeColor = System.Drawing.Color.White;
            this.btnRegresar.Location = new System.Drawing.Point(1016, 658);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(172, 43);
            this.btnRegresar.TabIndex = 17;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnBuscarEntrega
            // 
            this.btnBuscarEntrega.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.btnBuscarEntrega.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnBuscarEntrega.ForeColor = System.Drawing.Color.White;
            this.btnBuscarEntrega.Location = new System.Drawing.Point(707, 167);
            this.btnBuscarEntrega.Name = "btnBuscarEntrega";
            this.btnBuscarEntrega.Size = new System.Drawing.Size(138, 43);
            this.btnBuscarEntrega.TabIndex = 30;
            this.btnBuscarEntrega.Text = "Buscar";
            this.btnBuscarEntrega.UseVisualStyleBackColor = false;
            this.btnBuscarEntrega.Click += new System.EventHandler(this.btnBuscarEntrega_Click);
            // 
            // dataGridViewPaquetes
            // 
            this.dataGridViewPaquetes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPaquetes.Location = new System.Drawing.Point(80, 240);
            this.dataGridViewPaquetes.Name = "dataGridViewPaquetes";
            this.dataGridViewPaquetes.RowHeadersWidth = 51;
            this.dataGridViewPaquetes.RowTemplate.Height = 24;
            this.dataGridViewPaquetes.Size = new System.Drawing.Size(1108, 360);
            this.dataGridViewPaquetes.TabIndex = 31;
            this.dataGridViewPaquetes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPaquetes_CellContentClick);
            // 
            // MisEntregas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 723);
            this.Controls.Add(this.dataGridViewPaquetes);
            this.Controls.Add(this.btnBuscarEntrega);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.cmReportar);
            this.Controls.Add(this.rptproblema);
            this.Controls.Add(this.btnReportar);
            this.Controls.Add(this.guiamadre);
            this.Controls.Add(this.lineadecorativa);
            this.Controls.Add(this.labelentregaspiloto);
            this.Controls.Add(this.panel1);
            this.Name = "MisEntregas";
            this.Text = "MisEntregas";
            this.Load += new System.EventHandler(this.MisEntregas_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPaquetes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lineadecorativa;
        private System.Windows.Forms.Label labelentregaspiloto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUserPiloto;
        private System.Windows.Forms.TextBox guiamadre;
        private System.Windows.Forms.Button btnReportar;
        private System.Windows.Forms.Label rptproblema;
        private System.Windows.Forms.ComboBox cmReportar;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnBuscarEntrega;
        private System.Windows.Forms.DataGridView dataGridViewPaquetes;
    }
}