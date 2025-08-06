//RUTAS 2 DESIGNER
//DISEÑO FORMS DE VIZZUALIZACION

using System;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaRepartoG4
{
    partial class RutasForm
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitulo;
        private DataGridView dgvRutas;

        private Button btnAgregar;
        private Button btnEditar;
        private Button btnGuardar;
        private Button btnEliminar;
        private Button btnRetroceder;
        private DateTimePicker dtpHoraInicio;
        private DateTimePicker dtpHoraFinal;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.Size = new Size(1280, 770);
            this.MaximumSize = new Size(1280, 770);
            this.MinimumSize = new Size(1280, 770);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            // Header panel
            Panel headerPanel = new Panel();
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Height = 50;
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

            userComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            userComboBox.Location = new Point(headerPanel.Width - userComboBox.Width - 10, 12);

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

            // Icono de usuario 
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


            // lblTitulo
            this.lblTitulo = new Label();
            this.lblTitulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            this.lblTitulo.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new Point(20, headerPanel.Height + 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Text = "RUTAS";
            this.Controls.Add(this.lblTitulo);

            //HR
            Label hrLine = new Label();
            hrLine.AutoSize = false;
            hrLine.Height = 2;
            hrLine.Width = this.ClientSize.Width - 40;
            hrLine.BackColor = Color.Gray;
            hrLine.Location = new Point(20, this.lblTitulo.Bottom + 10);
            this.Controls.Add(hrLine);

            // DataGridView
            this.dgvRutas = new DataGridView();
            this.dgvRutas.AutoGenerateColumns = false;
            this.dgvRutas.AllowUserToAddRows = false;
            this.dgvRutas.AllowUserToDeleteRows = false;
            this.dgvRutas.BackgroundColor = Color.White;
            this.dgvRutas.BorderStyle = BorderStyle.None;
            this.dgvRutas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvRutas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            this.dgvRutas.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 248, 248);
            this.dgvRutas.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvRutas.GridColor = Color.FromArgb(24, 52, 70);
            this.dgvRutas.Name = "dgvRutas";
            this.dgvRutas.ReadOnly = true;
            this.dgvRutas.RowHeadersVisible = false;
            this.dgvRutas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvRutas.Location = new Point(40, hrLine.Bottom + 20);
            this.dgvRutas.Width = 1200;

            int filasVisibles = 15;
            int alturaFilas = dgvRutas.RowTemplate.Height * filasVisibles;
            int alturaEncabezado = dgvRutas.ColumnHeadersHeight;
            this.dgvRutas.Height = alturaFilas + alturaEncabezado;
            this.dgvRutas.ScrollBars = ScrollBars.Vertical;
            this.dgvRutas.ColumnHeadersHeight = 55;
            this.dgvRutas.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvRutas.EnableHeadersVisualStyles = false;
            this.dgvRutas.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
            {
                Font = new Font("Segoe UI", 10.5F, FontStyle.Bold),
                BackColor = Color.White,
                ForeColor = Color.Black,
                Alignment = DataGridViewContentAlignment.MiddleCenter,
                Padding = new Padding(0, 10, 0, 10)
            };
            this.dgvRutas.DefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.White,
                Font = new Font("Segoe UI", 9.5F),
                SelectionBackColor = Color.FromArgb(141, 153, 174),
                SelectionForeColor = Color.Black,
                Padding = new Padding(5, 0, 5, 0)
            };
            this.dgvRutas.RowTemplate.Height = 38;
            this.dgvRutas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            this.dgvRutas.Columns.AddRange(
                new DataGridViewTextBoxColumn()
                {
                    Name = "id_ruta",
                    HeaderText = "ID RUTA",
                    DataPropertyName = "id_ruta",
                    MinimumWidth = 80
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "nombre_ruta",
                    HeaderText = "NOMBRE RUTA",
                    DataPropertyName = "nombre_ruta",
                    MinimumWidth = 180
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "fecha_ruta",
                    HeaderText = "FECHA",
                    DataPropertyName = "fecha_ruta",
                    MinimumWidth = 120
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "hora_inicio_ruta",
                    HeaderText = "HORA INICIO",
                    DataPropertyName = "hora_inicio_ruta",
                    MinimumWidth = 100
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "hora_final_ruta",
                    HeaderText = "HORA FINAL",
                    DataPropertyName = "hora_final_ruta",
                    MinimumWidth = 100
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "id_conductor",
                    HeaderText = "ID CONDUCTOR",
                    DataPropertyName = "id_conductor",
                    MinimumWidth = 100
                }
            );

            this.Controls.Add(this.dgvRutas);

            // Botones
            int buttonSize = 40;
            int buttonSpacing = 10;
            int marginRight = 20;
            int marginBottom2 = 20;
            int totalButtons = 5;
            int startX = this.ClientSize.Width - marginRight - (totalButtons * buttonSize + (totalButtons - 1) * buttonSpacing);
            int buttonY = this.ClientSize.Height - marginBottom2 - buttonSize;

            // btnRetroceder
            this.btnRetroceder = new Button();
            this.btnRetroceder.Font = new Font("Segoe UI", 12F);
            this.btnRetroceder.Name = "btnRetroceder";
            this.btnRetroceder.Size = new Size(buttonSize, buttonSize);
            this.btnRetroceder.Text = "↩";
            this.btnRetroceder.UseVisualStyleBackColor = false;
            this.btnRetroceder.Location = new Point(startX, buttonY);
            this.Controls.Add(this.btnRetroceder);

            // btnAgregar
            this.btnAgregar = new Button();
            this.btnAgregar.Font = new Font("Segoe UI", 12F);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new Size(buttonSize, buttonSize);
            this.btnAgregar.Text = "+";
            this.btnAgregar.Location = new Point(startX + 1 * (buttonSize + buttonSpacing), buttonY);
            this.Controls.Add(this.btnAgregar);

            // btnEditar
            this.btnEditar = new Button();
            this.btnEditar.Font = new Font("Segoe UI", 12F);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new Size(buttonSize, buttonSize);
            this.btnEditar.Text = "✎";
            this.btnEditar.Location = new Point(startX + 2 * (buttonSize + buttonSpacing), buttonY);
            this.Controls.Add(this.btnEditar);

            // btnGuardar
            this.btnGuardar = new Button();
            this.btnGuardar.Font = new Font("Segoe UI", 12F);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new Size(buttonSize, buttonSize);
            this.btnGuardar.Text = "💾";
            this.btnGuardar.Location = new Point(startX + 3 * (buttonSize + buttonSpacing), buttonY);
            this.Controls.Add(this.btnGuardar);

            // btnEliminar
            this.btnEliminar = new Button();
            this.btnEliminar.Font = new Font("Segoe UI", 12F);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new Size(buttonSize, buttonSize);
            this.btnEliminar.Text = "🗑";
            this.btnEliminar.Location = new Point(startX + 4 * (buttonSize + buttonSpacing), buttonY);
            this.Controls.Add(this.btnEliminar);

            // Centrar textos 
            foreach (DataGridViewColumn col in dgvRutas.Columns)
            {
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }
    }
}
