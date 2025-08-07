using MySql.Data.MySqlClient;
using SistemaRepartoG4.Clases;
using System;
using System.Data;
using System.Windows.Forms;

namespace SistemaRepartoG4
{
    public partial class RegistroBodegas : Form
    {
        public RegistroBodegas()
        {
            InitializeComponent();
        }

        private void RegistroBodegas_Load(object sender, EventArgs e)
        {
            CargarEncargados();
            CargarSucursales();
        }

        private void CargarEncargados()
        {
            using (MySqlConnection conn = ConectarDB.establecerConexion())
            {
                conn.Open();
                string query = "SELECT id_encargado, CONCAT(nombre_encargado, ' ', apellido_encargado) AS nombre_completo FROM tbl_encargado";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                comboEncargado.DataSource = dt;
                comboEncargado.DisplayMember = "nombre_completo";
                comboEncargado.ValueMember = "id_encargado";
                comboEncargado.SelectedIndex = -1; // No seleccionado por defecto
            }
        }

        private void CargarSucursales()
        {
            using (MySqlConnection conn = ConectarDB.establecerConexion())
            {
                conn.Open();
                string query = "SELECT id_sucursal, codigo_sucursal FROM tbl_sucursal";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                comboSucursal.DataSource = dt;
                comboSucursal.DisplayMember = "codigo_sucursal";
                comboSucursal.ValueMember = "id_sucursal";
                comboSucursal.SelectedIndex = -1;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Validar campos
            if (string.IsNullOrWhiteSpace(txtCodigoBodega.Text) ||
                string.IsNullOrWhiteSpace(txtCapacidad.Text) ||
                comboEncargado.SelectedIndex == -1 ||
                comboSucursal.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, completa todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtCodigoBodega.Text, out int codigoBodega))
            {
                MessageBox.Show("El Código de Bodega debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtCapacidad.Text, out int capacidadBodega))
            {
                MessageBox.Show("La Capacidad debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int idEncargado = Convert.ToInt32(comboEncargado.SelectedValue);
            int idSucursal = Convert.ToInt32(comboSucursal.SelectedValue);

            try
            {
                using (MySqlConnection conn = ConectarDB.establecerConexion())
                {
                    conn.Open();

                    string query = @"INSERT INTO tbl_bodega (codigo_bodega, id_encargado, id_sucursal, capacidad_bodega)
                                     VALUES (@codigo, @encargado, @sucursal, @capacidad)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@codigo", codigoBodega);
                        cmd.Parameters.AddWithValue("@encargado", idEncargado);
                        cmd.Parameters.AddWithValue("@sucursal", idSucursal);
                        cmd.Parameters.AddWithValue("@capacidad", capacidadBodega);

                        int filasAfectadas = cmd.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Bodega registrada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpiarCampos();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo registrar la bodega.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            txtCodigoBodega.Clear();
            txtCapacidad.Clear();
            comboEncargado.SelectedIndex = -1;
            comboSucursal.SelectedIndex = -1;
        }
    }
}
