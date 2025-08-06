// pilotoDetalleForms.cs
//estructura del forms ingreso y edicion de datos
using MySql.Data.MySqlClient;
using SistemaRepartoG4.Clases;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaRepartoG4
{
    public class PilotoDetalleForm : Form
    {
        // Declaración de controles
        private TextBox txtNombres;
        private TextBox txtApellidos;
        private DateTimePicker dtpFechaNacimiento;
        private ComboBox cbSexo;
        private ComboBox cbTipoLicencia;
        private ComboBox cbSucursal;
        private TextBox txtTelefono;
        private TextBox txtCorreo;
        private TextBox txtCalle;
        private TextBox txtAvenida;
        private TextBox txtZona;
        private TextBox txtCiudad;
        private TextBox txtMunicipio;
        private Button btnAceptar;
        private Button btnCancelar;


        public PilotoDetalleForm()
        {
            InitializeComponent();
            CargarSucursales();
        }

        private void SetPlaceholder(TextBox textBox, string placeholder)
        {
            textBox.Text = placeholder;
            textBox.ForeColor = SystemColors.GrayText;

            textBox.Enter += (s, e) =>
            {
                if (textBox.Text == placeholder)
                {
                    textBox.Text = "";
                    textBox.ForeColor = SystemColors.WindowText;
                }
            };
            textBox.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = placeholder;
                    textBox.ForeColor = SystemColors.GrayText;
                }
            };
        }

        private class ComboItem
        {
            public int Value { get; set; }
            public string Text { get; set; }

            public ComboItem(int value, string text)
            {
                Value = value;
                Text = text;
            }

            public override string ToString()
            {
                return Text;
            }
        }


        private void InitializeComponent()
        {

            this.Text = "Detalle de Piloto";
            this.ClientSize = new Size(500, 380); //ancho largo
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterParent;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            int top = 20;

            this.MinimizeBox = false;

            //variables para colocar las dos columnas
            int leftColX = 20;
            int rightColX = 260;
            int labelWidth = 80;
            int inputWidth = 130;
            int spacing = 40;

            // Columna izquierda
            Label lblNombres = new Label { Text = "Nombres:", Location = new Point(leftColX, top), Size = new Size(labelWidth, 23) };
            txtNombres = new TextBox { Location = new Point(leftColX + labelWidth, top), Size = new Size(inputWidth, 23) };

            top += spacing;
            Label lblApellidos = new Label { Text = "Apellidos:", Location = new Point(leftColX, top), Size = new Size(labelWidth, 23) };
            txtApellidos = new TextBox { Location = new Point(leftColX + labelWidth, top), Size = new Size(inputWidth, 23) };

            top += spacing;
            Label lblFecha = new Label { Text = "Fecha Nac.:", Location = new Point(leftColX, top), Size = new Size(labelWidth, 23) };
            dtpFechaNacimiento = new DateTimePicker { Location = new Point(leftColX + labelWidth, top), Size = new Size(inputWidth, 23), Format = DateTimePickerFormat.Short };

            top += spacing;
            Label lblSexo = new Label { Text = "Sexo:", Location = new Point(leftColX, top), Size = new Size(labelWidth, 23) };
            cbSexo = new ComboBox { Location = new Point(leftColX + labelWidth, top), Size = new Size(inputWidth, 23), DropDownStyle = ComboBoxStyle.DropDownList };
            //OPCIONES DEL select de sexo
            cbSexo.Items.Add("Seleccione...");
            cbSexo.Items.Add("M");
            cbSexo.Items.Add("F");
            cbSexo.SelectedIndex = 0;

            top += spacing;
            Label lblLicencia = new Label { Text = "Licencia:", Location = new Point(leftColX, top), Size = new Size(labelWidth, 23) };
            cbTipoLicencia = new ComboBox { Location = new Point(leftColX + labelWidth, top), Size = new Size(inputWidth, 23), DropDownStyle = ComboBoxStyle.DropDownList };
            //opciones tipos de licencias
            cbTipoLicencia.Items.Add("Seleccione...");
            cbTipoLicencia.Items.Add("A");
            cbTipoLicencia.Items.Add("B");
            cbTipoLicencia.Items.Add("C");
            cbTipoLicencia.SelectedIndex = 0;

            top += spacing;
            Label lblSucursal = new Label { Text = "Sucursal:", Location = new Point(leftColX, top), Size = new Size(labelWidth, 23) };
            cbSucursal = new ComboBox { Location = new Point(leftColX + labelWidth, top), Size = new Size(inputWidth, 23), DropDownStyle = ComboBoxStyle.DropDownList };

            // Reiniciar top para columna derecha
            top = 20;

            // Columna derecha
            Label lblTelefono = new Label { Text = "Teléfono:", Location = new Point(rightColX, top), Size = new Size(labelWidth, 23) };
            txtTelefono = new TextBox { Location = new Point(rightColX + labelWidth, top), Size = new Size(inputWidth, 23) };

            top += spacing;
            Label lblCorreo = new Label { Text = "Correo:", Location = new Point(rightColX, top), Size = new Size(labelWidth, 23) };
            txtCorreo = new TextBox { Location = new Point(rightColX + labelWidth, top), Size = new Size(inputWidth, 23) };

            top += spacing;
            Label lblCalle = new Label { Text = "Calle:", Location = new Point(rightColX, top), Size = new Size(labelWidth, 23) };
            txtCalle = new TextBox { Location = new Point(rightColX + labelWidth, top), Size = new Size(inputWidth, 23) };

            top += spacing;
            Label lblAvenida = new Label { Text = "Avenida:", Location = new Point(rightColX, top), Size = new Size(labelWidth, 23) };
            txtAvenida = new TextBox { Location = new Point(rightColX + labelWidth, top), Size = new Size(inputWidth, 23) };

            top += spacing;
            Label lblZona = new Label { Text = "Zona:", Location = new Point(rightColX, top), Size = new Size(labelWidth, 23) };
            txtZona = new TextBox { Location = new Point(rightColX + labelWidth, top), Size = new Size(inputWidth, 23) };

            top += spacing;
            Label lblCiudad = new Label { Text = "Ciudad:", Location = new Point(rightColX, top), Size = new Size(labelWidth, 23) };
            txtCiudad = new TextBox { Location = new Point(rightColX + labelWidth, top), Size = new Size(inputWidth, 23) };

            top += spacing;
            Label lblMunicipio = new Label { Text = "Municipio:", Location = new Point(rightColX, top), Size = new Size(labelWidth, 23) };
            txtMunicipio = new TextBox { Location = new Point(rightColX + labelWidth, top), Size = new Size(inputWidth, 23) };

            // Botones centrados
            btnAceptar = new Button
            {
                Text = "Aceptar",
                Location = new Point((this.ClientSize.Width / 2) - 100, 310), //310 sube px
                Size = new Size(80, 30)
            };
            //llamar funcion
            btnAceptar.Click += BtnAceptar_Click;

            btnCancelar = new Button
            {
                Text = "Cancelar",
                Location = new Point((this.ClientSize.Width / 2) + 20, 310), //310 sube px
                Size = new Size(80, 30)
            };
            //llamar funcion
            btnCancelar.Click += BtnCancelar_Click;

            // Agregar controles al formulario
            this.Controls.AddRange(new Control[] {
                lblNombres, txtNombres,
                lblApellidos, txtApellidos,
                lblFecha, dtpFechaNacimiento,
                lblSexo, cbSexo,
                lblLicencia, cbTipoLicencia,
                lblSucursal, cbSucursal,
                lblTelefono, txtTelefono,
                lblCorreo, txtCorreo,
                lblCalle, txtCalle,
                lblAvenida, txtAvenida,
                lblZona, txtZona,
                lblCiudad, txtCiudad,
                lblMunicipio, txtMunicipio,
                btnAceptar, btnCancelar
            });
        }

        //cargar las sucursales para las opiones
        private void CargarSucursales()
        {
            try
            {
                cbSucursal.Items.Clear();
                cbSucursal.Items.Add(new ComboItem(0, "Seleccione sucursal..."));

                using (var conn = ConectarDB.establecerConexion())
                {
                    conn.Open();
                    string query = "SELECT id_sucursal, codigo_sucursal FROM tbl_sucursal";
                    using (var cmd = new MySqlCommand(query, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cbSucursal.Items.Add(new ComboItem(
                                reader.GetInt32("id_sucursal"),
                                $"Sucursal {reader.GetInt32("codigo_sucursal")}" // "Sucursal 1001"
                            ));
                        }
                    }
                }

                cbSucursal.DisplayMember = "Text";
                cbSucursal.ValueMember = "Value";
                cbSucursal.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error cargando sucursales: {ex.Message}");
            }
        }


        //boton de aceptar
        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            //valida que se ingreesen los datos
            if (string.IsNullOrWhiteSpace(txtNombres.Text) || string.IsNullOrWhiteSpace(txtApellidos.Text))
            {
                MessageBox.Show("Nombres y apellidos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbSexo.SelectedIndex <= 0 || cbTipoLicencia.SelectedIndex <= 0 || cbSucursal.SelectedIndex <= 0)
            {
                MessageBox.Show("Debe seleccionar sexo, tipo de licencia y sucursal.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dtpFechaNacimiento.Value > DateTime.Now)
            {
                MessageBox.Show("La fecha de nacimiento no puede ser futura.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }


        // boton de cancelar, nomas cierra el forms 
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }


        //para habilitar la escritura en los inputs y que sepan que variable es 
        public string Nombres
        {
            get => txtNombres.Text;
            set => txtNombres.Text = value;
        }

        public string Apellidos
        {
            get => txtApellidos.Text;
            set => txtApellidos.Text = value;
        }

        public DateTime FechaNacimiento
        {
            get => dtpFechaNacimiento.Value;
            set => dtpFechaNacimiento.Value = value;
        }

        public string Sexo
        {
            get => cbSexo.SelectedItem?.ToString();
            set => cbSexo.SelectedItem = value;
        }

        public string TipoLicencia
        {
            get => cbTipoLicencia.SelectedItem?.ToString();
            set => cbTipoLicencia.SelectedItem = value;
        }

        //aqui hay una conversionn porque si no no me funcionaba xd
        public int IdSucursal
        {
            get => (cbSucursal.SelectedItem as ComboItem)?.Value ?? 0;
            set
            {
                for (int i = 0; i < cbSucursal.Items.Count; i++)
                {
                    if (cbSucursal.Items[i] is ComboItem item && item.Value == value)
                    {
                        cbSucursal.SelectedIndex = i;
                        return;
                    }
                }
                cbSucursal.SelectedIndex = 0;
            }
        }


        public string Telefono
        {
            get => txtTelefono.Text.Trim();
            set => txtTelefono.Text = value;
        }

        public string Correo
        {
            get => txtCorreo.Text.Trim();
            set => txtCorreo.Text = value;
        }

        public string Calle
        {
            get => txtCalle.Text.Trim();
            set => txtCalle.Text = value;
        }

        public string Avenida
        {
            get => txtAvenida.Text.Trim();
            set => txtAvenida.Text = value;
        }

        public string Zona
        {
            get => txtZona.Text.Trim();
            set => txtZona.Text = value;
        }

        public string Ciudad
        {
            get => txtCiudad.Text.Trim();
            set => txtCiudad.Text = value;
        }

        public string Municipio
        {
            get => txtMunicipio.Text.Trim();
            set => txtMunicipio.Text = value;
        }
    }
}