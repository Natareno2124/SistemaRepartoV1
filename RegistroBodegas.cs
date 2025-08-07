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

namespace SistemaRepartoG4
{
    public partial class RegistroBodegas : Form
    {
        public RegistroBodegas()
        {
            InitializeComponent();
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

        private void CargarSucursal()
        {
            using (MySqlConnection conn = ConectarDB.establecerConexion())
            {
                conn.Open();
                string query = "SELECT id_sucursal, codigo_sucursal AS Codigo FROM tbl_sucursal";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                comboSucursal.DataSource = dt;
                comboSucursal.DisplayMember = "nombre_completo";
                comboSucursal.ValueMember = "id_sucursal";
                comboSucursal.SelectedIndex = -1;
            }
        }


        private void RegistroBodegas_Load(object sender, EventArgs e)
        {
            CargarEncargados();
            CargarSucursal();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
