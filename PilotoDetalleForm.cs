
// pilotoDetalleForms.cs

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
        private Button btnAceptar;
        private Button btnCancelar;


        public PilotoDetalleForm()
        {
            InitializeComponent();
            CargarSucursales();
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
            // Configuración básica del formulario
            this.Text = "Detalle de Piloto";
            this.ClientSize = new Size(300, 300);
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            Label lblNombres = new Label { Text = "Nombres:", Location = new Point(20, 20), AutoSize = true };
            txtNombres = new TextBox { Location = new Point(120, 18), Size = new Size(150, 23) };

            Label lblApellidos = new Label { Text = "Apellidos:", Location = new Point(20, 60), AutoSize = true };
            txtApellidos = new TextBox { Location = new Point(120, 58), Size = new Size(150, 23) };

            Label lblFecha = new Label { Text = "Fecha Nac.:", Location = new Point(20, 100), AutoSize = true };
            dtpFechaNacimiento = new DateTimePicker { Location = new Point(120, 98), Size = new Size(150, 23), Format = DateTimePickerFormat.Short };

            Label lblSexo = new Label { Text = "Sexo:", Location = new Point(20, 140), AutoSize = true };
            cbSexo = new ComboBox { Location = new Point(120, 138), Size = new Size(150, 23), DropDownStyle = ComboBoxStyle.DropDownList };
            cbSexo.Items.AddRange(new object[] { "Sexo", "M", "F" });

            Label lblLicencia = new Label { Text = "Tipo Licencia:", Location = new Point(20, 180), AutoSize = true };
            cbTipoLicencia = new ComboBox { Location = new Point(120, 178), Size = new Size(150, 23), DropDownStyle = ComboBoxStyle.DropDownList };
            cbTipoLicencia.Items.AddRange(new object[] { "Tipo", "A", "B", "C" });

            Label lblSucursal = new Label { Text = "Sucursal:", Location = new Point(20, 220), AutoSize = true };
            cbSucursal = new ComboBox { Location = new Point(120, 218), Size = new Size(150, 23), DropDownStyle = ComboBoxStyle.DropDownList };
            cbSucursal.Items.AddRange(new object[] { "Sucursal", "1", "2", "3" });

            btnAceptar = new Button { Text = "Aceptar", Location = new Point(60, 260), Size = new Size(80, 30) };
            btnAceptar.Click += BtnAceptar_Click;

            btnCancelar = new Button { Text = "Cancelar", Location = new Point(160, 260), Size = new Size(80, 30) };
            btnCancelar.Click += BtnCancelar_Click;

            // Agregar controles al formulario
            this.Controls.AddRange(new Control[] {
                lblNombres, txtNombres,
                lblApellidos, txtApellidos,
                lblFecha, dtpFechaNacimiento,
                lblSexo, cbSexo,
                lblLicencia, cbTipoLicencia,
                lblSucursal, cbSucursal,
                btnAceptar, btnCancelar
            });
        }



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
                                $"Sucursal {reader.GetInt32("codigo_sucursal")}" // Formato: "Sucursal 1001"
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





        private void BtnAceptar_Click(object sender, EventArgs e)
        {
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


        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

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
    }
}