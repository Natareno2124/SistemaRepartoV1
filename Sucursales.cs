using MySql.Data.MySqlClient;
using SistemaRepartoG4.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1;

namespace SistemaRepartoG4
{
    public partial class Sucursales : Form {
        public Sucursales(){
            InitializeComponent();
        }
        public void CargarSucursales()
        {
            using (MySqlConnection conn = ConectarDB.establecerConexion())
            {
                conn.Open();

                string query = @"
            SELECT 
                s.id_sucursal,
                s.codigo_sucursal,
                e.id_encargado, 
                CONCAT(e.nombre_encargado, ' ', e.apellido_encargado) AS Encargado,
                c.id_contacto_sucursal,
                c.telefono_sucursal AS Contacto,
                d.id_direccion_sucursal,
                CONCAT(d.calle_sucursal, ', ', d.avenida_sucursal, ', Zona ', d.zona_sucursal) AS Direccion
            FROM tbl_sucursal s
            JOIN tbl_encargado e ON s.id_encargado = e.id_encargado
            JOIN tbl_contacto_sucursal c ON s.id_contacto_sucursal = c.id_contacto_sucursal
            JOIN tbl_direccion_sucursal d ON s.id_direccion_sucursal = d.id_direccion_sucursal;
        ";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridViewSucursal.DataSource = dt;

                dataGridViewSucursal.Columns["id_encargado"].Visible = false;
                dataGridViewSucursal.Columns["id_contacto_sucursal"].Visible = false;
                dataGridViewSucursal.Columns["id_direccion_sucursal"].Visible = false;
            }
        }

        public static bool EliminarSucursal(int idSucursal)
        {
            try
            {
                using (MySqlConnection conn = ConectarDB.establecerConexion())
                {
                    conn.Open();
                    string query = "DELETE FROM tbl_sucursal WHERE id_sucursal = @id";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", idSucursal);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la sucursal: " + ex.Message);
                return false;
            }
        }


        public static bool ActualizarSucursal(Sucursal sucursal)
        {
            try
            {
                using (MySqlConnection conn = ConectarDB.establecerConexion())
                {
                    conn.Open();
                    string query = @"UPDATE tbl_sucursal 
                             SET codigo_sucursal = @codigo,
                                 id_encargado = @idEncargado,
                                 id_contacto_sucursal = @idContacto,
                                 id_direccion_sucursal = @idDireccion
                             WHERE id_sucursal = @id";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@codigo", sucursal.CodigoSucursal);
                    cmd.Parameters.AddWithValue("@idEncargado", sucursal.IdEncargado);
                    cmd.Parameters.AddWithValue("@idContacto", sucursal.IdContactoSucursal);
                    cmd.Parameters.AddWithValue("@idDireccion", sucursal.IdDireccionSucursal);
                    cmd.Parameters.AddWithValue("@id", sucursal.Id);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar la sucursal: " + ex.Message);
                return false;
            }
        }


        private void Btn_agregar_click(object sender, EventArgs e) { 
            RegistroSucursales registroSucursales = new RegistroSucursales();
            registroSucursales.FormClosed += (s, args) => CargarSucursales();
            registroSucursales.Show();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Sucursales_Load(object sender, EventArgs e)
        {
            CargarSucursales();
            // Cambiar los textos de encabezado visibles
            dataGridViewSucursal.Columns["id_sucursal"].HeaderText = "ID";
            dataGridViewSucursal.Columns["codigo_sucursal"].HeaderText = "Código";
            dataGridViewSucursal.Columns["Encargado"].HeaderText = "Encargado";
            dataGridViewSucursal.Columns["Contacto"].HeaderText = "Teléfono";
            dataGridViewSucursal.Columns["Direccion"].HeaderText = "Dirección";

            // Opcional: Ocultar columnas con IDs (ya deberían estar ocultas si lo hiciste antes)
            dataGridViewSucursal.Columns["id_encargado"].Visible = false;
            dataGridViewSucursal.Columns["id_contacto_sucursal"].Visible = false;
            dataGridViewSucursal.Columns["id_direccion_sucursal"].Visible = false;

            // Ajustes visuales del DataGridView
            dataGridViewSucursal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewSucursal.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewSucursal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            dataGridViewSucursal.BorderStyle = BorderStyle.None;
            dataGridViewSucursal.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewSucursal.EnableHeadersVisualStyles = false;

            dataGridViewSucursal.BackgroundColor = Color.White;

            dataGridViewSucursal.DefaultCellStyle.Font = new Font("Arial", 10);
            dataGridViewSucursal.DefaultCellStyle.ForeColor = Color.Black;
            dataGridViewSucursal.DefaultCellStyle.BackColor = Color.White;
            dataGridViewSucursal.DefaultCellStyle.SelectionBackColor = Color.FromArgb(141, 153, 174);
            dataGridViewSucursal.DefaultCellStyle.SelectionForeColor = Color.White;

            dataGridViewSucursal.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(24, 52, 70);
            dataGridViewSucursal.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewSucursal.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            dataGridViewSucursal.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            dataGridViewSucursal.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);

            dataGridViewSucursal.AllowUserToAddRows = false;

            dataGridViewSucursal.RowTemplate.Height = 28;
            dataGridViewSucursal.ColumnHeadersHeight = 35;

            // Finalmente cargas las sucursales
            

        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewSucursal.SelectedRows.Count > 0)
            {
                int idSucursal = Convert.ToInt32(dataGridViewSucursal.SelectedRows[0].Cells["id_sucursal"].Value);

                if (SucursalCRUD.EliminarSucursal(idSucursal))
                {
                    MessageBox.Show("Sucursal eliminada correctamente.");
                    CargarSucursales();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar la sucursal.");
                }
            }
            else
            {
                MessageBox.Show("Selecciona una sucursal para eliminar.");
            }
        }

        private void Btn_editar_Click(object sender, EventArgs e)
        {
            if (dataGridViewSucursal.SelectedRows.Count > 0)
            {
                // Obtener los valores desde el DataGridView
                int idSucursal = Convert.ToInt32(dataGridViewSucursal.SelectedRows[0].Cells["id_sucursal"].Value);
                int codigo = Convert.ToInt32(dataGridViewSucursal.SelectedRows[0].Cells["codigo_sucursal"].Value);
                int idEncargado = Convert.ToInt32(dataGridViewSucursal.SelectedRows[0].Cells["id_encargado"].Value);
                int idContacto = Convert.ToInt32(dataGridViewSucursal.SelectedRows[0].Cells["id_contacto_sucursal"].Value);
                int idDireccion = Convert.ToInt32(dataGridViewSucursal.SelectedRows[0].Cells["id_direccion_sucursal"].Value);

                // Abrir formulario de edición
                RegistroSucursales frm = new RegistroSucursales();

                // Indicar que es modo edición y pasar el ID
                frm.IdSucursalEditar = idSucursal;

                // Asignar valores a los controles
                frm.txtCodigoSucursal.Text = codigo.ToString();
                frm.comboEncargado.SelectedValue = idEncargado;
                frm.comboContacto.SelectedValue = idContacto;
                frm.comboDireccion.SelectedValue = idDireccion;

                // Mostrar el formulario
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecciona una sucursal para editar.");
            }
        }

    }


}

