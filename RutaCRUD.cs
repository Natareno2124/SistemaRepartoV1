using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace SistemaRepartoG4
{
    public partial class RutaCRUD
    {
        // Obtener todas las rutas
        public DataTable ObtenerRutas()
        {
            using (var conn = Clases.ConectarDB.establecerConexion())
            {
                conn.Open();
                string query = "SELECT * FROM tbl_rutas";
                var adapter = new MySqlDataAdapter(query, conn);
                var table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }

        // Insertar ruta
        public void InsertarRuta(int idRuta, string nombre, DateTime fecha, TimeSpan horaInicio, TimeSpan horaFinal, int idConductor)
        {
            using (var conn = Clases.ConectarDB.establecerConexion())
            {
                conn.Open();
                string query = @"INSERT INTO tbl_rutas (id_ruta, nombre_ruta, fecha_ruta, hora_inicio_ruta, hora_final_ruta, id_conductor)
                                 VALUES (@id, @nombre, @fecha, @horaInicio, @horaFinal, @idConductor)";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", idRuta);
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@fecha", fecha);
                    cmd.Parameters.AddWithValue("@horaInicio", horaInicio);
                    cmd.Parameters.AddWithValue("@horaFinal", horaFinal);
                    cmd.Parameters.AddWithValue("@idConductor", idConductor);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Modificar ruta
        public void ModificarRuta(int idRuta, string nombre, DateTime fecha, TimeSpan horaInicio, TimeSpan horaFinal, int idConductor)
        {
            using (var conn = Clases.ConectarDB.establecerConexion())
            {
                conn.Open();
                string query = @"UPDATE tbl_rutas 
                                 SET nombre_ruta=@nombre, fecha_ruta=@fecha, hora_inicio_ruta=@horaInicio,
                                     hora_final_ruta=@horaFinal, id_conductor=@idConductor
                                 WHERE id_ruta=@id";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", idRuta);
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@fecha", fecha);
                    cmd.Parameters.AddWithValue("@horaInicio", horaInicio);
                    cmd.Parameters.AddWithValue("@horaFinal", horaFinal);
                    cmd.Parameters.AddWithValue("@idConductor", idConductor);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Eliminar ruta
        public void EliminarRuta(int idRuta)
        {
            using (var conn = Clases.ConectarDB.establecerConexion())
            {
                conn.Open();

                // Eliminar primero en detalle
                string queryDetalle = "DELETE FROM tbl_ruta_detalle WHERE id_ruta = @id";
                using (var cmdDetalle = new MySqlCommand(queryDetalle, conn))
                {
                    cmdDetalle.Parameters.AddWithValue("@id", idRuta);
                    cmdDetalle.ExecuteNonQuery();
                }

                // Luego eliminar en rutas
                string query = "DELETE FROM tbl_rutas WHERE id_ruta = @id";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", idRuta);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
