using MySql.Data.MySqlClient;
using SistemaRepartoG4.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaRepartoG4
{
    internal class RutasCRUD
    {

        public static bool AgregarRuta(RutaModel ruta)
        {
            using (MySqlConnection conexion = ConectarDB.establecerConexion())
            {
                try
                {
                    conexion.Open();

                    string query = @"INSERT INTO tbl_rutas 
                (id_ruta, nombre_ruta, fecha_ruta, hora_inicio_ruta, hora_final_ruta, id_conductor)
                VALUES (@id, @nombre, @fecha, @inicio, @final, @conductor)";

                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@id", ruta.Id);
                    cmd.Parameters.AddWithValue("@nombre", ruta.Nombre);
                    cmd.Parameters.AddWithValue("@fecha", ruta.Fecha); // DateTime
                    cmd.Parameters.AddWithValue("@inicio", ruta.HoraInicio); // TimeSpan
                    cmd.Parameters.AddWithValue("@final", ruta.HoraFinal);   // TimeSpan
                    cmd.Parameters.AddWithValue("@conductor", ruta.IdConductor);

                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al insertar ruta: " + ex.Message);
                    return false;
                }
            }
        }






        //eliminar
        public static bool EliminarRuta(int idRuta)
        {
            using (MySqlConnection conexion = ConectarDB.establecerConexion())
            {
                try
                {
                    conexion.Open();

                    string query = "DELETE FROM tbl_rutas WHERE id_ruta = @id";

                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@id", idRuta);

                    int filasAfectadas = cmd.ExecuteNonQuery();
                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Ruta eliminada correctamente.");
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("No se encontró una ruta con ese ID.");
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar ruta: " + ex.Message);
                    return false;
                }
            }
        }



        //actualizar

        public static bool ActualizarRuta(RutaModel ruta)
        {
            using (MySqlConnection conexion = ConectarDB.establecerConexion())
            {
                try
                {
                    conexion.Open();

                    string query = @"UPDATE tbl_rutas SET 
                nombre_ruta = @nombre,
                fecha_ruta = @fecha,
                hora_inicio_ruta = @horaInicio,
                hora_final_ruta = @horaFinal,
                id_conductor = @idConductor
                WHERE id_ruta = @id";

                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@id", ruta.Id);
                    cmd.Parameters.AddWithValue("@nombre", ruta.Nombre);
                    cmd.Parameters.AddWithValue("@fecha", ruta.Fecha);
                    cmd.Parameters.AddWithValue("@horaInicio", ruta.HoraInicio);
                    cmd.Parameters.AddWithValue("@horaFinal", ruta.HoraFinal);
                    cmd.Parameters.AddWithValue("@idConductor", ruta.IdConductor);

                    int filasAfectadas = cmd.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar ruta: " + ex.Message);
                    return false;
                }
            }
        }



        //mostrando
        public static void MostrarRutas(DataGridView dgv)
        {
            using (MySqlConnection conexion = ConectarDB.establecerConexion())
            {
                try
                {
                    conexion.Open();
                    string query = "SELECT * FROM tbl_rutas";
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(query, conexion);
                    System.Data.DataTable tabla = new System.Data.DataTable();
                    adaptador.Fill(tabla);
                    dgv.DataSource = tabla;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al mostrar rutas: " + ex.Message);
                }
            }
        }









    }
}
