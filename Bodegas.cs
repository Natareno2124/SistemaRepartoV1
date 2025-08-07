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
    public partial class Bodegas : Form
    {
        public Bodegas()
        {
            InitializeComponent();
        }

        public void CargarBodegas()
        {
            using (MySqlConnection conn = ConectarDB.establecerConexion())
            {
                conn.Open();

                string query = @"
                    SELECT 
                        b.id_bodega,
                        b.codigo_bodega,
                        b.capacidad_bodega,
                        e.id_encargado,
                        CONCAT(e.nombre_encargado, ' ', e.apellido_encargado) AS Encargado,
                        s.id_sucursal,
                        s.codigo_sucursal AS Sucursal
                    FROM tbl_bodega b
                    JOIN tbl_encargado e ON b.id_encargado = e.id_encargado
                    JOIN tbl_sucursal s ON b.id_sucursal = s.id_sucursal;
    ";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridBodegas.DataSource = dt;

                // Ocultar columnas de IDs si no son necesarias visualmente
                dataGridBodegas.Columns["id_encargado"].Visible = false;
                dataGridBodegas.Columns["id_sucursal"].Visible = false;
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Bodegas_Load(object sender, EventArgs e)
        {
            CargarBodegas();
        }

        private void Btn_agregar_Click(object sender, EventArgs e)
        {
            RegistroBodegas detallesForm = new RegistroBodegas(); 
            detallesForm.Show(); 
        }
    }
}
