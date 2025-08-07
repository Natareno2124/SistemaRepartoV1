// Reporte2.Designer.cs
using System.Drawing;
using System.Windows.Forms;

namespace SistemaRepartoG4
{
    partial class Reporte2
    {
        private ComboBox comboConductores;
        private DateTimePicker dtInicio;
        private DateTimePicker dtFin;
        private Button btnBuscar;
        private DataGridView dgvReportes;
        private Button btnExportarExcel;
        private Button btnRetroceder;

        private Label lblTitulo;
        private Panel pnlBuscar;
        private PictureBox pbBuscar;
        private TextBox txtBuscar;

        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            // Tamaños fijos
            this.Size = new Size(1280, 770);
            this.MaximumSize = new Size(1280, 770);
            this.MinimumSize = new Size(1280, 770);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            // Inicializar controles
            this.lblTitulo = new Label();
            this.pnlBuscar = new Panel();
            this.pbBuscar = new PictureBox();
            this.txtBuscar = new TextBox();

            this.comboConductores = new ComboBox();
            this.dtInicio = new DateTimePicker();
            this.dtFin = new DateTimePicker();
            this.btnBuscar = new Button();
            this.dgvReportes = new DataGridView();
            this.btnExportarExcel = new Button();
            this.btnRetroceder = new Button();

            // header
            Panel headerPanel = new Panel();
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Height = 50;
            headerPanel.BackColor = Color.FromArgb(141, 153, 174);
            this.Controls.Add(headerPanel);

            // ComboBox
            ComboBox userComboBox = new ComboBox();
            userComboBox.Name = "userComboBox";
            userComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            userComboBox.FlatStyle = FlatStyle.Flat;
            userComboBox.Font = new Font("Segoe UI", 9F);
            userComboBox.BackColor = Color.White;
            userComboBox.ForeColor = Color.Black;
            userComboBox.Width = 120;
            userComboBox.Height = 25;

            userComboBox.Items.AddRange(new string[] {
                "User Administrador",
                "Cambiar usuario",
                "Cerrar sesión"
            });
            userComboBox.SelectedIndex = 0;

            userComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            userComboBox.Location = new Point(headerPanel.Width - 120 - 10, 12);

            userComboBox.SelectedIndexChanged += (sender, e) =>
            {
                switch (userComboBox.SelectedItem.ToString())
                {
                    case "Cerrar sesión":
                        MessageBox.Show("Cerrando sesión...");
                        break;
                    case "Cambiar usuario":
                        MessageBox.Show("Redirigiendo a selección de usuario...");
                        break;
                }
                userComboBox.SelectedIndex = 0;
            };
            headerPanel.Controls.Add(userComboBox);

            // Icono usuario
            Label userIconLabel = new Label();
            userIconLabel.Name = "userIconLabel";
            userIconLabel.Text = "👤";
            userIconLabel.Font = new Font("Segoe UI", 14F);
            userIconLabel.AutoSize = false;
            userIconLabel.Size = new Size(32, 32);
            userIconLabel.TextAlign = ContentAlignment.MiddleCenter;
            userIconLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            userIconLabel.Location = new Point(userComboBox.Left - 35, 9);
            userIconLabel.BackColor = Color.Transparent;
            userIconLabel.Click += (sender, e) => userComboBox.DroppedDown = true;
            userIconLabel.Cursor = Cursors.Hand;
            headerPanel.Controls.Add(userIconLabel);

            int headerOffset = headerPanel.Height;

            // Título
            this.lblTitulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            this.lblTitulo.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new Point(20, 20 + headerOffset);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new Size(300, 37);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "REPORTE DE ENTREGAS";
            this.Controls.Add(this.lblTitulo);

            // hr
            Label hrLine = new Label();
            hrLine.AutoSize = false;
            hrLine.Height = 2;
            hrLine.Width = this.ClientSize.Width - 40;
            hrLine.BackColor = Color.Gray;
            hrLine.Location = new Point(20, lblTitulo.Bottom + 10);
            this.Controls.Add(hrLine);

            // comboConductores
            this.comboConductores.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboConductores.FormattingEnabled = true;
            this.comboConductores.Location = new Point(20, lblTitulo.Bottom + 40);
            this.comboConductores.Name = "comboConductores";
            this.comboConductores.Size = new Size(200, 21);
            this.comboConductores.TabIndex = 0;
            this.Controls.Add(this.comboConductores);

            // dtInicio
            this.dtInicio.Format = DateTimePickerFormat.Short;
            this.dtInicio.Location = new Point(240, lblTitulo.Bottom + 40);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new Size(100, 20);
            this.dtInicio.TabIndex = 1;
            this.Controls.Add(this.dtInicio);

            // dtFin
            this.dtFin.Format = DateTimePickerFormat.Short;
            this.dtFin.Location = new Point(360, lblTitulo.Bottom + 40);
            this.dtFin.Name = "dtFin";
            this.dtFin.Size = new Size(100, 20);
            this.dtFin.TabIndex = 2;
            this.Controls.Add(this.dtFin);

            Color colorHeader = Color.FromArgb(24, 52, 70); // #183446

            // btnBuscar
            this.btnBuscar.Location = new Point(480, lblTitulo.Bottom + 40);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new Size(80, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.BackColor = colorHeader;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            this.Controls.Add(this.btnBuscar);

            // btnExportarExcel
            this.btnExportarExcel.Location = new Point(580, lblTitulo.Bottom + 40);
            this.btnExportarExcel.Name = "btnExportarExcel";
            this.btnExportarExcel.Size = new Size(120, 23);
            this.btnExportarExcel.TabIndex = 5;
            this.btnExportarExcel.Text = "Exportar a Excel";
            this.btnExportarExcel.BackColor = colorHeader;
            this.btnExportarExcel.UseVisualStyleBackColor = true;
            this.btnExportarExcel.Click += new System.EventHandler(this.btnExportarExcel_Click);
            this.Controls.Add(this.btnExportarExcel);

            // dgvReportes
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportes)).BeginInit();

            this.dgvReportes.Location = new Point(40, 170);
            this.dgvReportes.Size = new Size(1200, 550);
            this.dgvReportes.Name = "dgvReportes";
            this.dgvReportes.TabIndex = 6;

            this.Controls.Add(this.dgvReportes);

            ((System.ComponentModel.ISupportInitialize)(this.dgvReportes)).EndInit();

            // btnRetroceder
            this.btnRetroceder.Location = new Point(this.ClientSize.Width - 60, this.ClientSize.Height - 60);
            this.btnRetroceder.Size = new Size(40, 40);
            this.btnRetroceder.Font = new Font("Segoe UI", 12F);
            this.btnRetroceder.Text = "↩";
            this.btnRetroceder.UseVisualStyleBackColor = true;
            this.btnRetroceder.Click += new System.EventHandler(this.btnRetroceder_Click);
            this.Controls.Add(this.btnRetroceder);

            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(1280, 770);
            this.Name = "Reporte2";
            this.Text = "Reporte de Entregas por Conductor";

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void ConfigurarTablaReportes()
        {
            if (this.dgvReportes == null)
            {
                MessageBox.Show("Error: dgvReportes no está inicializado.");
                return;
            }

            // Configuración básica
            this.dgvReportes.EnableHeadersVisualStyles = false; 
            this.dgvReportes.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.FromArgb(24, 52, 70),  
                ForeColor = Color.White,               
                Font = new Font("Segoe UI", 10.5F, FontStyle.Bold),
                Alignment = DataGridViewContentAlignment.MiddleCenter,
                Padding = new Padding(0, 5, 0, 5)
            };

            this.dgvReportes.DefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.White,
                Font = new Font("Segoe UI", 9.5F),
                SelectionBackColor = Color.FromArgb(141, 153, 174),
                SelectionForeColor = Color.Black,
                Padding = new Padding(5, 0, 5, 0)
            };

            this.dgvReportes.AutoGenerateColumns = false;
            this.dgvReportes.AllowUserToAddRows = false;
            this.dgvReportes.AllowUserToDeleteRows = false;
            this.dgvReportes.BackgroundColor = Color.White;
            this.dgvReportes.BorderStyle = BorderStyle.None;
            this.dgvReportes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvReportes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            this.dgvReportes.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 248, 248);
            this.dgvReportes.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvReportes.GridColor = Color.FromArgb(24, 52, 70);

            this.dgvReportes.CellPainting += (sender, e) =>
            {
                if (e.RowIndex == -1 && e.ColumnIndex >= 0)
                {
                    e.PaintBackground(e.CellBounds, true);
                    e.PaintContent(e.CellBounds);

                    Rectangle spaceRect = new Rectangle(
                        e.CellBounds.Left,
                        e.CellBounds.Bottom - 10,
                        e.CellBounds.Width,
                        10);
                    e.Graphics.FillRectangle(Brushes.White, spaceRect);

                    e.Handled = true;
                }
            };

            this.dgvReportes.ReadOnly = true;
            this.dgvReportes.RowHeadersVisible = false;
            this.dgvReportes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            int marginHorizontal = 40;
            int marginTop = 210;
            this.dgvReportes.Width = 1280 - (marginHorizontal * 2);
            this.dgvReportes.Location = new Point(marginHorizontal, marginTop);

            //ffilas visilbles y scrollbar
            int filasVisibles = 15;
            int alturaFilas = dgvReportes.RowTemplate.Height * filasVisibles;
            int alturaEncabezado = dgvReportes.ColumnHeadersHeight;
            int alturaTotal = alturaFilas + alturaEncabezado;
            this.dgvReportes.Height = alturaTotal;

            this.dgvReportes.Width = 1280 - (marginHorizontal * 2);

            this.dgvReportes.ScrollBars = ScrollBars.Vertical;

            this.dgvReportes.ColumnHeadersHeight = 45;
            this.dgvReportes.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            this.dgvReportes.DefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.White,
                Font = new Font("Segoe UI", 9.5F),
                SelectionBackColor = Color.FromArgb(141, 153, 174),
                SelectionForeColor = Color.Black,
                Padding = new Padding(5, 0, 5, 0)
            };

            this.dgvReportes.RowTemplate.Height = 38;
            this.dgvReportes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Columnas
            this.dgvReportes.Columns.Clear();
            this.dgvReportes.Columns.AddRange(
                new DataGridViewTextBoxColumn() { 
                    Name = "NombreConductor", 
                    HeaderText = "CONDUCTOR", 
                    DataPropertyName = "NombreConductor", 
                    Width = 120 },
                new DataGridViewTextBoxColumn() { 
                    Name = "ApellidoConductor", 
                    HeaderText = "APELLIDO", 
                    DataPropertyName = "ApellidoConductor", 
                    MinimumWidth = 120 },
                new DataGridViewTextBoxColumn() { 
                    Name = "TipoLicencia", 
                    HeaderText = "LICENCIA", 
                    DataPropertyName = "TipoLicencia", 
                    MinimumWidth = 80 },
                new DataGridViewTextBoxColumn() { 
                    Name = "Sucursal", 
                    HeaderText = "SUCURSAL", 
                    DataPropertyName = "Sucursal", 
                    MinimumWidth = 80 },
                new DataGridViewTextBoxColumn() { 
                    Name = "NombreRuta", 
                    HeaderText = "RUTA", 
                    DataPropertyName = "NombreRuta", 
                    MinimumWidth = 150 },
                new DataGridViewTextBoxColumn() { 
                    Name = "FechaRuta", 
                    HeaderText = "FECHA", 
                    DataPropertyName = "FechaRuta", 
                    MinimumWidth = 90 },
                new DataGridViewTextBoxColumn() { 
                    Name = "HoraInicio", 
                    HeaderText = "HORA INICIO", 
                    DataPropertyName = "HoraInicio", 
                    MinimumWidth = 90 },
                new DataGridViewTextBoxColumn() { 
                    Name = "HoraFin", 
                    HeaderText = "HORA FIN", 
                    DataPropertyName = "HoraFin", 
                    MinimumWidth = 90 },
                new DataGridViewTextBoxColumn() { 
                    Name = "EstadoPedido", 
                    HeaderText = "ESTADO", 
                    DataPropertyName = "EstadoPedido",
                    MinimumWidth = 80 },
                new DataGridViewTextBoxColumn() { 
                    Name = "NombreCliente", 
                    HeaderText = "CLIENTE", 
                    DataPropertyName = "NombreCliente", 
                    MinimumWidth = 150 },
                new DataGridViewTextBoxColumn() { 
                    Name = "PrecioPaquete", 
                    HeaderText = "PRECIO", 
                    DataPropertyName = "PrecioPaquete", 
                    MinimumWidth = 80 }
            );

            // Centrar columnas
            foreach (DataGridViewColumn col in dgvReportes.Columns)
            {
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }
        #endregion
    }
}
