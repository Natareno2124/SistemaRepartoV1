//Conexión Usuarios con Datagrid
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaRepartoG4.Clases
{
    internal class CUsuarios
    {
        // Método para mostrar los usuarios en un DataGridView llamado "DB"
        public void mostrarUsuarios(DataGridView DB)
        {
            try
            {
                using (MySqlConnection conexion = ConectarDB.establecerConexion())
                {
                    string query = "SELECT * FROM tbl_usuarios";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conexion);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    DB.DataSource = dt;
                    Console.WriteLine("Mostrando usuarios en el DataGridView 'DB'");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al mostrar usuarios: " + ex.Message);
            }
        }
    }
}
