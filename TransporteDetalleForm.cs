//TransporteDetalleForm
//logica de la ventana de ingreso de datos
using MySql.Data.MySqlClient;
using SistemaRepartoG4.Clases;
using System;
using System.Windows.Forms;

namespace SistemaRepartoG4
{
    public partial class TransporteDetalleForm : Form
    {
        public TransporteDetalleForm()
        {
            InitializeComponent();
            CargarSucursales();
            CargarTiposVehiculo();
            CargarEstadosVehiculo();

            btnAceptar.Click += BtnAceptar_Click;
            btnCancelar.Click += (s, e) => this.DialogResult = DialogResult.Cancel;
        }

        public class ComboboxItem
        {
            public int Value { get; set; }
            public string Text { get; set; }

            public ComboboxItem(int value, string text)
            {
                Value = value;
                Text = text;
            }

            public override string ToString()
            {
                return Text;
            }
        }

        //funciones para cargar las sucursales y completar datos
        private void CargarSucursales()
        {
            cbSucursal.Items.Clear();
            cbSucursal.Items.Add("Seleccione...");

            try
            {
                using (MySqlConnection conn = ConectarDB.establecerConexion())
                {
                    string query = "SELECT id_sucursal, codigo_sucursal FROM tbl_sucursal";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    conn.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string display = $"Sucursal {reader["codigo_sucursal"]}";
                        cbSucursal.Items.Add(new ComboboxItem(
                            (int)reader["id_sucursal"],
                            display
                        ));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cargando sucursales: " + ex.Message);
            }

            cbSucursal.DisplayMember = "Text";
            cbSucursal.ValueMember = "Value";
            cbSucursal.SelectedIndex = 0;
        }

        private void CargarTiposVehiculo()
        {
            cbTipo.Items.Clear();
            cbTipo.Items.Add("Seleccione...");

            try
            {
                using (MySqlConnection conn = ConectarDB.establecerConexion())
                {
                    string query = "SELECT id_tipo_vehiculo, nombre_tipo_vehiculo FROM tbl_tipo_vehiculo";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    conn.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        cbTipo.Items.Add(new ComboboxItem(
                            (int)reader["id_tipo_vehiculo"],
                            reader["nombre_tipo_vehiculo"].ToString()
                        ));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cargando tipos: " + ex.Message);
            }

            cbTipo.DisplayMember = "Text";
            cbTipo.ValueMember = "Value";
            cbTipo.SelectedIndex = 0;
        }


        private void CargarEstadosVehiculo()
        {
            cbEstado.Items.Clear();
            cbEstado.Items.Add("Seleccione...");

            try
            {
                using (MySqlConnection conn = ConectarDB.establecerConexion())
                {
                    string query = "SELECT id_estado_vehiculo, nombre_estado_vehiculo FROM tbl_estado_vehiculo";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    conn.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        cbEstado.Items.Add(new ComboboxItem(
                            (int)reader["id_estado_vehiculo"],
                            reader["nombre_estado_vehiculo"].ToString()
                        ));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cargando estados: " + ex.Message);
            }

            cbEstado.DisplayMember = "Text";
            cbEstado.ValueMember = "Value";
            cbEstado.SelectedIndex = 0;
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtPlaca.Text.Trim(), out int placa) || placa <= 0)
            {
                MessageBox.Show("La placa debe ser un número positivo.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtMarca.Text) ||
                string.IsNullOrWhiteSpace(txtModelo.Text) ||
                string.IsNullOrWhiteSpace(txtColor.Text) ||
                string.IsNullOrWhiteSpace(txtCapacidad.Text))
            {
                MessageBox.Show("Complete todos los campos de texto.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbSucursal.SelectedIndex <= 0 ||
                cbTipo.SelectedIndex <= 0 ||
                cbEstado.SelectedIndex <= 0)
            {
                MessageBox.Show("Seleccione sucursal, tipo y estado válidos.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                MessageBox.Show("Vehículo agregado correctamente.", "Éxito",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al insertar",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public int Placa
        {
            get => int.TryParse(txtPlaca.Text.Trim(), out var p) ? p : 0;
            set => txtPlaca.Text = value.ToString();
        }

        public string Marca
        {
            get => txtMarca.Text.Trim();
            set => txtMarca.Text = value;
        }

        public string Modelo
        {
            get => txtModelo.Text.Trim();
            set => txtModelo.Text = value;
        }

        public string Color
        {
            get => txtColor.Text.Trim();
            set => txtColor.Text = value;
        }
        public string Capacidad
        {
            get => txtCapacidad.Text.Trim();
            set => txtCapacidad.Text = value;
        }

        public int IdSucursal
        {
            get
            {
                if (cbSucursal.SelectedIndex <= 0) return 0;
                if (cbSucursal.SelectedItem is ComboboxItem item)
                    return item.Value;
                return 0;
            }
            set
            {
                foreach (var item in cbSucursal.Items)
                {
                    if (item is ComboboxItem comboItem && comboItem.Value == value)
                    {
                        cbSucursal.SelectedItem = item;
                        return;
                    }
                }
                cbSucursal.SelectedIndex = 0;
            }
        }
        public int IdTipo
        {
            get
            {
                if (cbTipo.SelectedIndex <= 0) return 0;
                if (cbTipo.SelectedItem is ComboboxItem item)
                    return item.Value;
                return 0;
            }
            set
            {
                foreach (var item in cbTipo.Items)
                {
                    if (item is ComboboxItem comboItem && comboItem.Value == value)
                    {
                        cbTipo.SelectedItem = item;
                        return;
                    }
                }
                cbTipo.SelectedIndex = 0;
            }
        }

        public int IdEstado
        {
            get
            {
                if (cbEstado.SelectedIndex <= 0) return 0;
                if (cbEstado.SelectedItem is ComboboxItem item)
                    return item.Value;
                return 0;
            }
            set
            {
                foreach (var item in cbEstado.Items)
                {
                    if (item is ComboboxItem comboItem && comboItem.Value == value)
                    {
                        cbEstado.SelectedItem = item;
                        return;
                    }
                }
                cbEstado.SelectedIndex = 0;
            }
        }
    }
}

