//PilotosForm.Designer.cs
//diseño forms visualizacion datos
using System.Drawing;
using System.Windows.Forms;
using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.IO;
using static System.Windows.Forms.AxHost;
using System.Data;

namespace SistemaRepartoG4
{
    partial class PilotosForm
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
            this.Size = new Size(1280, 770); // Tamaño 
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
            this.dgvPilotos = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnRetroceder = new System.Windows.Forms.Button();
            this.grpContacto = new System.Windows.Forms.GroupBox();
            this.grpDireccion = new System.Windows.Forms.GroupBox();
            this.txtSexo = new System.Windows.Forms.TextBox();

            //controles
            this.Controls.Add(txtSexo);
            this.Controls.Add(txtLicencia);
            this.Controls.Add(txtTelefono);
            this.Controls.Add(txtCorreo);
            this.Controls.Add(txtCalle);
            this.Controls.Add(txtAvenida);
            this.Controls.Add(txtZona);
            this.Controls.Add(txtCiudad);
            this.Controls.Add(txtMunicipio);

            this.pnlBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPilotos)).BeginInit();
            this.SuspendLayout();

            int centerX = this.ClientSize.Width / 2;

            //header
            Panel headerPanel = new Panel();
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Height = 50; // Altura 
            headerPanel.BackColor = Color.FromArgb(141, 153, 174);
            this.Controls.Add(headerPanel);

            // Crear y configurar el ComboBox
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

            //mensajes para cada selecion del select de usuarios
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

            // Crear Label para el icono de usuario
            Label userIconLabel = new Label();
            userIconLabel.Name = "userIconLabel";
            userIconLabel.Text = "👤"; //icono porque img se buguea 
            userIconLabel.Font = new Font("Segoe UI", 14F);
            userIconLabel.AutoSize = false;
            userIconLabel.Size = new Size(32, 32);
            userIconLabel.TextAlign = ContentAlignment.MiddleCenter;
            userIconLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            userIconLabel.Location = new Point(userComboBox.Left - 35, 9);
            userIconLabel.BackColor = Color.Transparent;

            //estelizar 
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
            this.lblTitulo.Text = "PILOTOS";

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
            this.txtBuscar.Text = "Buscar por nombre";
            this.txtBuscar.ForeColor = SystemColors.GrayText;

            //para que diga para que sirve ese input
            this.txtBuscar.Enter += (sender, e) =>
            {
                if (this.txtBuscar.Text == "Buscar por nombre")
                {
                    this.txtBuscar.Text = "";
                    this.txtBuscar.ForeColor = SystemColors.WindowText; // Color normal al escribir
                }
            };

            this.txtBuscar.Leave += (sender, e) =>
            {
                if (string.IsNullOrWhiteSpace(this.txtBuscar.Text))
                {
                    this.txtBuscar.Text = "Buscar por nombre";
                    this.txtBuscar.ForeColor = SystemColors.GrayText;
                }
            };

            // cbRuta
            this.cbRuta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRuta.FormattingEnabled = true;
            cbRuta.Items.Clear();
            cbRuta.Items.AddRange(new object[] {
                "Buscar por ruta",
                "Todas las rutas",
                "Ruta Norte",
                "Ruta Sur",
                "Ruta Este",
                "Ruta Oeste"
            });
            if (cbRuta.Items.Count > 0)
                cbRuta.SelectedIndex = 0;

            this.cbRuta.Location = new Point(
                cbRutaOriginalX,
                hrLine.Bottom + espacioDespuesDeLinea
            ); this.cbRuta.Name = "cbRuta";
            this.cbRuta.Size = new System.Drawing.Size(200, 25);
            this.cbRuta.TabIndex = 2;

            // cbOrdenar
            this.cbOrdenar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOrdenar.FormattingEnabled = true;
            cbOrdenar.Items.Clear();
            cbOrdenar.Items.AddRange(new object[] {
                "Ordenar por",
                "ID",
                "Nombre",
                "Nº Entregas"
            });
            if (cbOrdenar.Items.Count > 0)
                cbOrdenar.SelectedIndex = 0;

            this.cbOrdenar.Name = "cbOrdenar";
            
            this.cbOrdenar.Location = new Point(
                cbOrdenarOriginalX,
                hrLine.Bottom + espacioDespuesDeLinea
            );
            this.cbOrdenar.Size = new System.Drawing.Size(150, 25);
            this.cbOrdenar.TabIndex = 3;

            // dgvPilotos
            this.dgvPilotos = new System.Windows.Forms.DataGridView();
            this.dgvPilotos.AutoGenerateColumns = false;

            this.dgvPilotos.AllowUserToAddRows = false;
            this.dgvPilotos.AllowUserToDeleteRows = false;
            this.dgvPilotos.BackgroundColor = System.Drawing.Color.White;
            this.dgvPilotos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPilotos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;

            this.dgvPilotos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            this.dgvPilotos.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 248, 248);
            this.dgvPilotos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPilotos.GridColor = Color.FromArgb(24, 52, 70);

            //simulación de separación de encabezado y contenido
            this.dgvPilotos.CellPainting += (sender, e) =>
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

            this.dgvPilotos.Name = "dgvPilotos";
            this.dgvPilotos.ReadOnly = true;
            this.dgvPilotos.RowHeadersVisible = false;
            this.dgvPilotos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            this.Controls.Add(this.dgvPilotos);

            //scrollbar vertical
            int marginHorizontal = 40;
            int marginTop = 170;

            this.dgvPilotos.Location = new Point(marginHorizontal, marginTop);
            this.dgvPilotos.Width = 1280 - (marginHorizontal * 2);

            this.dgvPilotos.Location = new Point(
                marginHorizontal,
                marginTop
            );

            int filasVisibles = 15;
            int alturaFilas = dgvPilotos.RowTemplate.Height * filasVisibles;
            int alturaEncabezado = dgvPilotos.ColumnHeadersHeight;
            int alturaTotal = alturaFilas + alturaEncabezado;
            this.dgvPilotos.Height = alturaTotal;

            this.dgvPilotos.ScrollBars = ScrollBars.Vertical;

            this.dgvPilotos.ColumnHeadersHeight = 55;
            this.dgvPilotos.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvPilotos.EnableHeadersVisualStyles = false;
            this.dgvPilotos.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
            {
                Font = new Font("Segoe UI", 10.5F, FontStyle.Bold),
                BackColor = Color.White,
                ForeColor = Color.Black,
                Alignment = DataGridViewContentAlignment.MiddleCenter,
                Padding = new Padding(0, 10, 0, 10)  // Más espacio vertical
            };

            this.dgvPilotos.DefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.White,
                Font = new Font("Segoe UI", 9.5F),
                SelectionBackColor = Color.FromArgb(141, 153, 174),
                SelectionForeColor = Color.Black,
                Padding = new Padding(5, 0, 5, 0)  // Espaciado interno horizontal
            };

            this.dgvPilotos.RowTemplate.Height = 38;

            this.dgvPilotos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //columas del form
            this.dgvPilotos.Columns.Clear();
            this.dgvPilotos.Columns.AddRange(
                new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "id_conductor",//variable bd
                    HeaderText = "ID", // titulo de la tabla
                    Name = "colID", //identificador del campo
                    Visible = false, //que no sa visible
                    MinimumWidth = 50 //tamaño minimo
                },
                new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "nombre_conductor",
                    HeaderText = "Nombres",
                    Name = "colNombre",
                    Width = 100,
                    MinimumWidth = 100
                },
                new DataGridViewTextBoxColumn()
                {
                    HeaderText = "Apellidos",
                    Name = "colApellidos",
                    DataPropertyName = "apellido_conductor",
                    MinimumWidth = 100
                },
                new DataGridViewTextBoxColumn()
                {
                    HeaderText = "Licencia",
                    Name = "colTipoLicencia",
                    DataPropertyName = "tipo_licencia_conductor",
                    Width = 60,
                    MinimumWidth = 60
                },
                new DataGridViewTextBoxColumn()
                {
                    HeaderText = "Sucursal",
                    Name = "colSucursal",
                    DataPropertyName = "Sucursal",
                    Width = 80,
                    MinimumWidth = 80
                },
                new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "SucursalID",
                    HeaderText = "SucursalID",
                    Name = "colSucursalID",
                    Visible = false
                },
                new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "sexo_conductor",
                    HeaderText = "Sexo",
                    Name = "colSexo",
                    Visible = false
                },
                new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "telefono_conductor",
                    HeaderText = "Teléfono",
                    Name = "colTelefono",
                    Visible = false
                },
                new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "correo_conductor",
                    HeaderText = "Correo",
                    Name = "colCorreo",
                    Visible = false
                },
                new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "calle_conductor",
                    HeaderText = "Calle",
                    Name = "colCalle",
                    Visible = false
                },
                new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "avenida_conductor",
                    HeaderText = "Avenida",
                    Name = "colAvenida",
                    Visible = false
                },
                new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "zona_conductor",
                    HeaderText = "Zona",
                    Name = "colZona",
                    Visible = false
                },
                new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "ciudad_conductor",
                    HeaderText = "Ciudad",
                    Name = "colCiudad",
                    Visible = false
                },
                new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "fecha_nacimiento_conductor",
                    HeaderText = "Fecha de Nacimiento",
                    Name = "colFechaNacimiento",
                    Visible = false
                },
                new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "municipio_conductor",
                    HeaderText = "Municipio",
                    Name = "colMunicipio",
                    Visible = false
                }
            );

            //para que identifique que tocaste
            this.dgvPilotos.SelectionChanged += (s, e) =>
            {
                if (dgvPilotos.CurrentRow == null) return;
                var row = dgvPilotos.CurrentRow;
                txtSexo.Text = row.Cells["colSexo"].Value?.ToString();
                txtLicencia.Text = row.Cells["colTipoLicencia"].Value?.ToString();
                txtTelefono.Text = row.Cells["colTelefono"].Value?.ToString();
                txtCorreo.Text = row.Cells["colCorreo"].Value?.ToString();
                txtCalle.Text = row.Cells["colCalle"].Value?.ToString();
                txtAvenida.Text = row.Cells["colAvenida"].Value?.ToString();
                txtZona.Text = row.Cells["colZona"].Value?.ToString();
                txtCiudad.Text = row.Cells["colCiudad"].Value?.ToString();
                txtMunicipio.Text = row.Cells["colMunicipio"].Value?.ToString();
            };

            //grupo de contacto y direccion porque no caben/se ven feos todos los apos juntos en una sola tabla
            // CONTACTO 
            grpContacto = new GroupBox()
            {
                Text = "Contacto",
                Location = new Point(50, 560), // 560 es para bajarlo
                Size = new Size(360, 120)
            };

            Label lblSexo = new Label() { Text = "Sexo:", Location = new Point(10, 25), AutoSize = true };
            txtSexo = new TextBox() { Location = new Point(100, 22), Width = 80, ReadOnly = true };
            Label lblLicencia = new Label() { Text = "Licencia:", Location = new Point(190, 25), AutoSize = true };
            txtLicencia = new TextBox() { Location = new Point(250, 22), Width = 80, ReadOnly = true };
            Label lblTelefono = new Label() { Text = "Teléfono:", Location = new Point(10, 60), AutoSize = true };
            txtTelefono = new TextBox() { Location = new Point(100, 57), Width = 230, ReadOnly = true };
            Label lblCorreo = new Label() { Text = "Correo:", Location = new Point(10, 90), AutoSize = true };
            txtCorreo = new TextBox() { Location = new Point(100, 87), Width = 230, ReadOnly = true };

            grpContacto.Controls.AddRange(new Control[] {
                lblSexo, txtSexo,
                lblLicencia, txtLicencia,
                lblTelefono, txtTelefono,
                lblCorreo, txtCorreo
            });
            this.Controls.Add(grpContacto);

            // DIRECCIÓN 
            grpDireccion = new GroupBox()
            {
                Text = "Dirección",
                Location = new Point(430, 560),
                Size = new Size(420, 120)
            };

            Label lblCalle = new Label() { Text = "Calle:", Location = new Point(10, 25), AutoSize = true };
            txtCalle = new TextBox() { Location = new Point(80, 22), Width = 120, ReadOnly = true };
            Label lblAvenida = new Label() { Text = "Avenida:", Location = new Point(220, 25), AutoSize = true };
            txtAvenida = new TextBox() { Location = new Point(290, 22), Width = 100, ReadOnly = true };
            Label lblZona = new Label() { Text = "Zona:", Location = new Point(10, 60), AutoSize = true };
            txtZona = new TextBox() { Location = new Point(80, 57), Width = 60, ReadOnly = true };
            Label lblCiudad = new Label() { Text = "Ciudad:", Location = new Point(150, 60), AutoSize = true };
            txtCiudad = new TextBox() { Location = new Point(220, 57), Width = 170, ReadOnly = true };
            Label lblMunicipio = new Label() { Text = "Municipio:", Location = new Point(10, 90), AutoSize = true };
            txtMunicipio = new TextBox() { Location = new Point(80, 87), Width = 310, ReadOnly = true };

            grpDireccion.Controls.AddRange(new Control[] {
                lblCalle, txtCalle,
                lblAvenida, txtAvenida,
                lblZona, txtZona,
                lblCiudad, txtCiudad,
                lblMunicipio, txtMunicipio
            });
            this.Controls.Add(grpDireccion);

            //llamamos al crud, llamamos al obtener pilotos
            PilotosCRUD crud = new PilotosCRUD();

            //Funcionalidad de buscar por nombre
            DataTable dt = new PilotosCRUD().ObtenerPilotos();
            pilotosBinding = new BindingSource();
            pilotosBinding.DataSource = dt;
            dgvPilotos.DataSource = pilotosBinding;

            // Cuando cambie el texto, aplica el filtro
            txtBuscar.TextChanged += (s, e) =>
            {
                string txt = txtBuscar.Text.Trim().Replace("'", "''");
                if (string.IsNullOrEmpty(txt))
                {
                    pilotosBinding.RemoveFilter();
                }
                else
                {
                    pilotosBinding.Filter =
                        $"nombre_conductor LIKE '%{txt}%' OR apellido_conductor LIKE '%{txt}%'";
                }
            };

            //deja el placeholder
            txtBuscar.GotFocus += (s, e) =>
            {
                if (txtBuscar.Text == "Buscar por nombre")
                {
                    txtBuscar.Text = "";
                    txtBuscar.ForeColor = SystemColors.WindowText;
                }
            };
            txtBuscar.LostFocus += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(txtBuscar.Text))
                {
                    txtBuscar.Text = "Buscar por nombre";
                    txtBuscar.ForeColor = SystemColors.GrayText;
                    pilotosBinding.RemoveFilter();
                }
            };


            //centrar los datos de la tabla
            foreach (DataGridViewColumn col in dgvPilotos.Columns)
            {
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            //separacion de columas y encabezado
            Panel separatorPanel = new Panel();
            separatorPanel.Height = 15;
            separatorPanel.BackColor = Color.White;
            separatorPanel.Dock = DockStyle.Top; //hasta el tope

            this.dgvPilotos.Controls.Add(separatorPanel);
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
            this.btnRetroceder.Font = new System.Drawing.Font("Segoe UI", 12F); //font
            this.btnRetroceder.Name = "btnRetroceder"; //nombre
            this.btnRetroceder.Size = new Size(buttonSize, buttonSize); //tamaño
            this.btnRetroceder.Text = "↩"; //texto icono 
            this.btnRetroceder.UseVisualStyleBackColor = false;
            this.btnRetroceder.Click += new System.EventHandler(this.btnRetroceder_Click); //funcion 

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
            this.Controls.Add(this.dgvPilotos);
            this.Controls.Add(this.cbOrdenar);
            this.Controls.Add(this.cbRuta);
            this.Controls.Add(this.pnlBuscar);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            this.Name = "PilotosForm";
            this.Text = "Gestión de Pilotos";
            this.pnlBuscar.ResumeLayout(false);
            this.pnlBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPilotos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void AplicarFiltroCombinado(string rutaFilter = null)
        {
            string txt = txtBuscar.Text.Trim().Replace("'", "''");
            string textFilter = string.IsNullOrEmpty(txt) || txt == "Buscar por nombre"
                ? null
                : $"(nombre_conductor LIKE '%{txt}%' OR apellido_conductor LIKE '%{txt}%')";
            if (!string.IsNullOrEmpty(textFilter) && !string.IsNullOrEmpty(rutaFilter))
                pilotosBinding.Filter = $"{textFilter} AND {rutaFilter}";
            else if (!string.IsNullOrEmpty(textFilter))
                pilotosBinding.Filter = textFilter;
            else if (!string.IsNullOrEmpty(rutaFilter))
                pilotosBinding.Filter = rutaFilter;
            else
                pilotosBinding.RemoveFilter();
        }

        #endregion
        //declaracion de variables
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlBuscar;
        private System.Windows.Forms.PictureBox pbBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ComboBox cbRuta;
        private System.Windows.Forms.ComboBox cbOrdenar;
        private System.Windows.Forms.DataGridView dgvPilotos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnRetroceder;
        private System.Windows.Forms.GroupBox grpContacto;
        private System.Windows.Forms.GroupBox grpDireccion;

        private BindingSource pilotosBinding;

        private TextBox txtSexo;
        private TextBox txtLicencia;
        private TextBox txtTelefono;
        private TextBox txtCorreo;
        private TextBox txtCalle;
        private TextBox txtAvenida;
        private TextBox txtZona;
        private TextBox txtCiudad;
        private TextBox txtMunicipio;

    }

}
