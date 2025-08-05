//TransporteFormDESIGNER
//Visualizacion de datos
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaRepartoG4
{
    partial class TransporteForm
    {
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
            //TAMAÑOS FIJOS 
            this.Size = new Size(1280, 770); // Tamaño inicial
            this.MaximumSize = new Size(1280, 770);
            this.MinimumSize = new Size(1280, 770);
            this.StartPosition = FormStartPosition.CenterScreen; // Centrar en pantalla
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            //GENERALIDADES
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();

            //inicializar 
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlBuscar = new System.Windows.Forms.Panel();
            this.pbBuscar = new System.Windows.Forms.PictureBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.cbRuta = new System.Windows.Forms.ComboBox();
            this.cbOrdenar = new System.Windows.Forms.ComboBox();
            this.dgvTransporte = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnRetroceder = new System.Windows.Forms.Button();

            this.pnlBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransporte)).BeginInit();
            this.SuspendLayout();

            int centerX = this.ClientSize.Width / 2;

            Panel headerPanel = new Panel();
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Height = 50; // Altura 
            headerPanel.BackColor = Color.FromArgb(141, 153, 174);
            this.Controls.Add(headerPanel);


            // ComboBox de usuario
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

            // Estilizar el ComboBox
            userComboBox.BackColor = Color.White;
            userComboBox.FlatStyle = FlatStyle.Flat;
            userComboBox.Font = new Font("Segoe UI", 9F);
            userComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            userComboBox.Location = new Point(headerPanel.Width - 120 - 10, 12); // 10px de margen derecho

            userComboBox.SelectedIndexChanged += (sender, e) =>
            {
                //que mostrar dependiendo que select eligan 
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

            // Crear Label para el icono de usuario
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

            // Agregar controles al panel
            headerPanel.Controls.Add(userIconLabel);
            headerPanel.Controls.Add(userComboBox);

            int headerOffset = headerPanel.Height;

            // lblTitulo
            this.lblTitulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            this.lblTitulo.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new Point(20, 20 + headerOffset);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(99, 37);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "TRANSPORTE";

            // pnlBuscar
            this.pnlBuscar.Controls.Add(this.pbBuscar);
            this.pnlBuscar.Controls.Add(this.txtBuscar);
            this.pnlBuscar.Location = new System.Drawing.Point(20, 20 + headerOffset);
            this.pnlBuscar.Name = "pnlBuscar";
            this.pnlBuscar.Size = new System.Drawing.Size(250, 30);
            this.pnlBuscar.TabIndex = 1;

            //hr
            Label hrLine = new Label();
            hrLine.AutoSize = false;
            hrLine.Height = 2;  // Grosor de la línea
            hrLine.Width = this.ClientSize.Width - 40;
            hrLine.BackColor = Color.Gray;  // Color de la línea
            hrLine.Location = new Point(20, lblTitulo.Bottom + 10);
            this.Controls.Add(hrLine);

            // Selects
            int desplazamientoDerecha = 15;
            int espacioDespuesDeLinea = 15;
            int pnlBuscarOriginalX = 20 + desplazamientoDerecha;
            int cbRutaOriginalX = 280 + desplazamientoDerecha;
            int cbOrdenarOriginalX = 490 + desplazamientoDerecha;

            this.pnlBuscar.Location = new Point(
            pnlBuscarOriginalX,
            hrLine.Bottom + espacioDespuesDeLinea
            );

            //campo de búsqueda
            pnlBuscar.BackColor = Color.White;
            pnlBuscar.BorderStyle = BorderStyle.FixedSingle;
            pnlBuscar.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pnlBuscar.Width, pnlBuscar.Height, 15, 15));

            // pbBuscar
            this.pbBuscar.Location = new Point(pnlBuscarOriginalX, hrLine.Bottom + espacioDespuesDeLinea);
            this.pbBuscar.Name = "pbBuscar";
            this.pbBuscar.Size = new System.Drawing.Size(20, 20);
            this.pbBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBuscar.TabIndex = 1;
            this.pbBuscar.TabStop = false;

            // txtBuscar
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscar.Location = new System.Drawing.Point(40, 5);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(200, 18);
            this.txtBuscar.TabIndex = 0;
            this.txtBuscar.Text = "Buscar por placa";
            this.txtBuscar.ForeColor = SystemColors.GrayText;

            this.txtBuscar.Enter += (sender, e) =>
            {
                if (this.txtBuscar.Text == "Buscar por placa")
                {
                    this.txtBuscar.Text = "";
                    this.txtBuscar.ForeColor = SystemColors.WindowText; // Color normal al escribir
                }
            };

            this.txtBuscar.Leave += (sender, e) =>
            {
                if (string.IsNullOrWhiteSpace(this.txtBuscar.Text))
                {
                    this.txtBuscar.Text = "Buscar por placa";
                    this.txtBuscar.ForeColor = SystemColors.GrayText;
                }
            };

            // cbRuta
            this.cbRuta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRuta.FormattingEnabled = true;
            this.cbRuta.Items.AddRange(new object[] {
                "Buscar por sucursal",
                "Todas las sucursales",
                "Sucursal Norte",
                "Sucursal Sur",
                "Sucursal Este",
                "Sucursal Oeste"});
            this.cbRuta.SelectedIndex = 0;
            this.cbRuta.Location = new Point(
                cbRutaOriginalX,
                hrLine.Bottom + espacioDespuesDeLinea
            ); this.cbRuta.Name = "cbRuta";
            this.cbRuta.Size = new System.Drawing.Size(200, 25);
            this.cbRuta.TabIndex = 2;

            // cbOrdenar
            this.cbOrdenar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOrdenar.FormattingEnabled = true;
            this.cbOrdenar.Items.AddRange(new object[] {
                "Ordenar por",
                "Placa",
                "Estado"});
            this.cbOrdenar.SelectedIndex = 0;
            this.cbOrdenar.Name = "cbOrdenar";
            this.cbOrdenar.Location = new Point(
                cbOrdenarOriginalX,
                hrLine.Bottom + espacioDespuesDeLinea
            );
            this.cbOrdenar.Size = new System.Drawing.Size(150, 25);
            this.cbOrdenar.TabIndex = 3;

            // dgvPilotos
            this.dgvTransporte = new System.Windows.Forms.DataGridView();
            this.dgvTransporte.AutoGenerateColumns = false;

            this.dgvTransporte.AllowUserToAddRows = false;
            this.dgvTransporte.AllowUserToDeleteRows = false;
            this.dgvTransporte.BackgroundColor = System.Drawing.Color.White;
            this.dgvTransporte.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTransporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;

            this.dgvTransporte.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            this.dgvTransporte.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 248, 248);
            this.dgvTransporte.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTransporte.GridColor = Color.FromArgb(24, 52, 70);

            //simulación de separación de encabezado y contenido
            this.dgvTransporte.CellPainting += (sender, e) =>
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

            this.dgvTransporte.Name = "dgvTransporte";
            this.dgvTransporte.ReadOnly = true;
            this.dgvTransporte.RowHeadersVisible = false;
            this.dgvTransporte.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            this.Controls.Add(this.dgvTransporte);

            int marginHorizontal = 40;
            int marginTop = 170;
            int marginBottom = 50;

            this.dgvTransporte.Width = 1280 - (marginHorizontal * 2);

            //scrollbar vertical
            this.Controls.Add(this.dgvTransporte);

            this.dgvTransporte.Location = new Point(marginHorizontal, marginTop);
            this.dgvTransporte.Width = 1280 - (marginHorizontal * 2);

            int filasVisibles = 15;
            int alturaFilas = dgvTransporte.RowTemplate.Height * filasVisibles;
            int alturaEncabezado = dgvTransporte.ColumnHeadersHeight;
            int alturaTotal = alturaFilas + alturaEncabezado;
            this.dgvTransporte.Height = alturaTotal;
            this.dgvTransporte.ScrollBars = ScrollBars.Vertical;

            this.dgvTransporte.ColumnHeadersHeight = 55;
            this.dgvTransporte.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvTransporte.EnableHeadersVisualStyles = false;
            this.dgvTransporte.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
            {
                Font = new Font("Segoe UI", 10.5F, FontStyle.Bold),
                BackColor = Color.White,
                ForeColor = Color.Black,
                Alignment = DataGridViewContentAlignment.MiddleCenter,
                Padding = new Padding(0, 10, 0, 10)  // Más espacio vertical
            };

            this.dgvTransporte.DefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.White,
                Font = new Font("Segoe UI", 9.5F),
                SelectionBackColor = Color.FromArgb(141, 153, 174),
                SelectionForeColor = Color.Black,
                Padding = new Padding(5, 0, 5, 0)  // Espaciado interno horizontal
            };

            this.dgvTransporte.RowTemplate.Height = 38;

            this.dgvTransporte.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //columnas de la tabla 
            this.dgvTransporte.Columns.AddRange(
                new DataGridViewTextBoxColumn()
                {
                    Name = "placa", //nombre
                    HeaderText = "PLACA", //titulo de la columna
                    DataPropertyName = "Placa", //variable
                    MinimumWidth = 60
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "marca",
                    HeaderText = "MARCA",
                    DataPropertyName = "marca",
                    MinimumWidth = 200
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "modelo",
                    HeaderText = "MODELO",
                    DataPropertyName = "modelo",
                    MinimumWidth = 120
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "color",
                    HeaderText = "COLOR",
                    DataPropertyName = "color",
                    MinimumWidth = 150
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "capacidad",
                    HeaderText = "CAPACIDAD",
                    DataPropertyName = "capacidad",
                    MinimumWidth = 100
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "SucursalID",
                    HeaderText = "ID SUCURSAL",
                    DataPropertyName = "SucursalID",
                    Visible = false
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "Sucursal",
                    HeaderText = "SUCURSAL",
                    DataPropertyName = "Sucursal",
                    MinimumWidth = 150
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "TipoID",
                    HeaderText = "ID TIPO",
                    DataPropertyName = "TipoID",
                    Visible = false
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "Tipo",
                    HeaderText = "TIPO",
                    DataPropertyName = "Tipo",
                    MinimumWidth = 120
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "EstadoID",
                    HeaderText = "ID ESTADO",
                    DataPropertyName = "EstadoID",
                    Visible = false
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "estado",
                    HeaderText = "ESTADO",
                    DataPropertyName = "EstadoVehiculo",
                    MinimumWidth = 100
                }
            );

            //llamamos al crud y a obtener transporte
            TransporteCRUD crud = new TransporteCRUD();

            // Funcionalidad de buscar por placa
            DataTable dt = new TransporteCRUD().ObtenerTransportes();
            transportesBinding = new BindingSource();
            transportesBinding.DataSource = dt;
            dgvTransporte.DataSource = transportesBinding;

            // Cuando cambie el texto, aplica el filtro
            txtBuscar.TextChanged += (s, e) =>
            {
                string txt = txtBuscar.Text.Trim().Replace("'", "''");

                if (string.IsNullOrEmpty(txt) || txt == "Buscar por placa")
                {
                    transportesBinding.RemoveFilter();
                }
                else
                {
                    // Convertimos Placa (int) a string para usar LIKE
                    transportesBinding.Filter =
                        $"Convert(Placa, 'System.String') LIKE '%{txt}%'";
                }
            };
            txtBuscar.GotFocus += (s, e) =>
            {
                if (txtBuscar.Text == "Buscar por placa")
                {
                    txtBuscar.Text = "";
                    txtBuscar.ForeColor = SystemColors.WindowText;
                }
            };
            txtBuscar.LostFocus += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(txtBuscar.Text))
                {
                    txtBuscar.Text = "Buscar por placa";
                    txtBuscar.ForeColor = SystemColors.GrayText;
                    transportesBinding.RemoveFilter();
                }
            };

            //centrar los datos de la tabla 
            foreach (DataGridViewColumn col in dgvTransporte.Columns)
            {
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            //simulacion de la separacion del encabezado con las tabas 
            Panel separatorPanel = new Panel();
            separatorPanel.Height = 15;
            separatorPanel.BackColor = Color.White;
            separatorPanel.Dock = DockStyle.Top;

            this.dgvTransporte.Controls.Add(separatorPanel);
            separatorPanel.BringToFront();

            //BOTONES
            int buttonSize = 40;
            int buttonSpacing = 10;
            int marginRight = 20;
            int marginBottom2 = 20;

            int totalButtons = 5;
            int startX = this.ClientSize.Width - marginRight - (totalButtons * buttonSize + (totalButtons - 1) * buttonSpacing);
            int buttonY = this.ClientSize.Height - marginBottom2 - buttonSize;

            this.btnRetroceder.Location = new Point(startX, buttonY);
            this.btnAgregar.Location = new Point(startX + 1 * (buttonSize + buttonSpacing), buttonY);
            this.btnEditar.Location = new Point(startX + 2 * (buttonSize + buttonSpacing), buttonY);
            this.btnGuardar.Location = new Point(startX + 3 * (buttonSize + buttonSpacing), buttonY);
            this.btnEliminar.Location = new Point(startX + 4 * (buttonSize + buttonSpacing), buttonY);


            // btnRetroceder
            this.btnRetroceder.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnRetroceder.Name = "btnRetroceder";
            this.btnRetroceder.Size = new Size(buttonSize, buttonSize);
            this.btnRetroceder.Text = "↩";
            this.btnRetroceder.UseVisualStyleBackColor = false;
            this.btnRetroceder.Click += new System.EventHandler(this.btnRetroceder_Click);

            // btnAgregar
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new Size(buttonSize, buttonSize);
            this.btnAgregar.Text = "+";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);

            // btnEditar
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new Size(buttonSize, buttonSize);
            this.btnEditar.TabIndex = 7;
            this.btnEditar.Text = "✎";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);

            // btnGuardar
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new Size(buttonSize, buttonSize);
            this.btnGuardar.Text = "💾";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);

            // btnEliminar
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new Size(buttonSize, buttonSize);
            this.btnEliminar.Text = "🗑";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);

            // PilotosForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnRetroceder);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvTransporte);
            this.Controls.Add(this.cbOrdenar);
            this.Controls.Add(this.cbRuta);
            this.Controls.Add(this.pnlBuscar);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            this.Name = "TransporteForm";
            this.Text = "Gestión de Transporte";
            this.pnlBuscar.ResumeLayout(false);
            this.pnlBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransporte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        //declaracion de variables
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlBuscar;
        private System.Windows.Forms.PictureBox pbBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ComboBox cbRuta;
        private System.Windows.Forms.ComboBox cbOrdenar;
        private System.Windows.Forms.DataGridView dgvTransporte;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnRetroceder;

        private BindingSource transportesBinding;

    }

}
