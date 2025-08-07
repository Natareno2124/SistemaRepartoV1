using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaRepartoG4;
namespace WinFormsApp1

{
    using System.Drawing;
    using MySql.Data.MySqlClient;
    using SistemaRepartoG4.Clases;

    public partial class RegistroSucursales : Form
    {
        public int? IdSucursalEditar { get; set; }
       

        public RegistroSucursales()
        {
            InitializeComponent();
            this.Load += RegistroSucursales_Load;
            groupBox1.BackColor = ColorTranslator.FromHtml("#8D99AE");
            button1.BackColor = ColorTranslator.FromHtml("#8D99AE");
            BackColor = ColorTranslator.FromHtml("#2C546D");
        }
        private void AplicarColorATextBox(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.BackColor = ColorTranslator.FromHtml("#2C546D");
                }

                // Si el control contiene otros controles (ej. Panel, GroupBox)
                if (ctrl.HasChildren)
                {
                    AplicarColorATextBox(ctrl);
                }
            }
        }


        private void AplicarColorALabel(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                if (ctrl is Label)
                {
                    ctrl.ForeColor = ColorTranslator.FromHtml("#183446");
                }

                // Si el control contiene otros controles (ej. Panel, GroupBox)
                if (ctrl.HasChildren)
                {
                    AplicarColorALabel(ctrl);
                }
            }
        }

        private void CargarEncargados()
        {
            using (MySqlConnection conn = ConectarDB.establecerConexion())
            {
                conn.Open();
                string query = "SELECT id_encargado, CONCAT(nombre_encargado, ' ', apellido_encargado) AS nombre_completo FROM tbl_encargado";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                comboEncargado.DataSource = dt;
                comboEncargado.DisplayMember = "nombre_completo";
                comboEncargado.ValueMember = "id_encargado";
                comboEncargado.SelectedIndex = -1;
            }
        }


        private void CargarContactos()
        {
            using (MySqlConnection conn = ConectarDB.establecerConexion())
            {
                conn.Open();
                string query = @"SELECT id_contacto_sucursal, CONCAT(telefono_sucursal, ' / ', correo_sucursal) AS contacto_completo FROM tbl_contacto_sucursal";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                comboContacto.DataSource = dt;
                comboContacto.DisplayMember = "contacto_completo";
                comboContacto.ValueMember = "id_contacto_sucursal";
                comboContacto.SelectedIndex = -1;
            }
        }

        private void CargarDirecciones()
        {
            using (MySqlConnection conn = ConectarDB.establecerConexion())
            {
                conn.Open();
                string query = @"SELECT id_direccion_sucursal, CONCAT(calle_sucursal, ', ', avenida_sucursal, ', Zona ', zona_sucursal) AS direccion_completa FROM tbl_direccion_sucursal";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                comboDireccion.DataSource = dt;
                comboDireccion.DisplayMember = "direccion_completa";
                comboDireccion.ValueMember = "id_direccion_sucursal";
                comboDireccion.SelectedIndex = -1;
            }
        }


        private void RegistroSucursales_Load(object sender, EventArgs e)
        {
            AplicarColorATextBox(this);
            AplicarColorALabel(this);
            CargarEncargados();
            CargarContactos();
            CargarDirecciones();

        }






        public void btnAgregarSucursal_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que se haya seleccionado algo en los ComboBoxes
                if (comboEncargado.SelectedIndex == -1 || comboContacto.SelectedIndex == -1 || comboDireccion.SelectedIndex == -1)
                {
                    MessageBox.Show("Por favor, selecciona Encargado, Contacto y Dirección.");
                    return;
                }

                // Crear la sucursal usando el valor seleccionado en los combos
                Sucursal nuevaSucursal = new Sucursal
                {
                    CodigoSucursal = int.Parse(txtCodigoSucursal.Text),
                    IdEncargado = Convert.ToInt32(comboEncargado.SelectedValue),
                    IdContactoSucursal = Convert.ToInt32(comboContacto.SelectedValue),
                    IdDireccionSucursal = Convert.ToInt32(comboDireccion.SelectedValue)
                };

                bool agregada = SucursalCRUD.InsertarSucursal(nuevaSucursal);

                if (agregada)
                {
                    MessageBox.Show("Sucursal agregada correctamente.");
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se pudo agregar la sucursal.");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, verifica que el código de sucursal sea un número válido.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar la sucursal: " + ex.Message);
            }
        }


        private void LimpiarCampos()
        {
            txtCodigoSucursal.Clear();
            comboEncargado.SelectedIndex = -1;
            comboContacto.SelectedIndex = -1;
            comboDireccion.SelectedIndex = -1;
        }



        private void txtNombres_TextChanged(object sender, EventArgs e)
        {

        }

 
        private void button2_Click_1(object sender, EventArgs e)
        {

        }
 


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Nombre_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void txtTelefonoContacto_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RegistroSucursales_Load_1(object sender, EventArgs e)
        {

        }

        private void comboEncargado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
