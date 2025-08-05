using MySql.Data.MySqlClient;
using SistemaRepartoG4.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//creado por Rocio Lopez 9959-23-740

namespace SistemaRepartoG4
{
    internal class RutasCRUD
    {
        private ConectarDB conexion = new ConectarDB();

        // MOSTRAR

        //Para mostrar las rutas en el DataGridView
        public DataTable ObtenerRutas()
        {
            using (MySqlConnection conn = ConectarDB.establecerConexion())
            {
                string query = @"
                SELECT 
                    r.id_ruta,
                    r.nombre_ruta,
                    r.fecha_ruta,
                    r.hora_inicio_ruta,
                    r.hora_final_ruta,
                    r.id_conductor,
                    CONCAT(c.nombre_conductor, ' ', c.apellido_conductor) AS nombre_completo_conductor
                FROM tbl_rutas r
                LEFT JOIN tbl_conductores c ON r.id_conductor = c.id_conductor";

                MySqlDataAdapter adaptador = new MySqlDataAdapter(query, conn);
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                return tabla;
            }
        }

        // AGREGAR
        //Crear una nueva ruta, validando datos y que no esten vacio
        public void InsertarRuta(int id_ruta, string nombre_ruta, DateTime fecha_ruta, TimeSpan hora_inicio_ruta, TimeSpan hora_final_ruta, int id_conductor)
        {
            if (string.IsNullOrWhiteSpace(nombre_ruta))
                throw new ArgumentException("El nombre de la ruta es obligatorio.");

            if (id_conductor <= 0)
                throw new ArgumentException("Conductor inválido.");

            using (MySqlConnection conn = ConectarDB.establecerConexion())
            {
                conn.Open();

                string query = @"INSERT INTO tbl_rutas 
                (id_ruta, nombre_ruta, fecha_ruta, hora_inicio_ruta, hora_final_ruta, id_conductor) 
                VALUES (@id_ruta, @nombre_ruta, @fecha_ruta, @hora_inicio_ruta, @hora_final_ruta, @id_conductor)";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id_ruta", id_ruta);
                    cmd.Parameters.AddWithValue("@nombre_ruta", nombre_ruta);
                    cmd.Parameters.AddWithValue("@fecha_ruta", fecha_ruta);
                    cmd.Parameters.AddWithValue("@hora_inicio_ruta", hora_inicio_ruta);
                    cmd.Parameters.AddWithValue("@hora_final_ruta", hora_final_ruta);
                    cmd.Parameters.AddWithValue("@id_conductor", id_conductor);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        // MODIFICAR

        //actualiza una ruta existente, validando que los datos no esten vacios
        public void ModificarRuta(int id_ruta, string nombre_ruta, DateTime fecha_ruta, TimeSpan hora_inicio_ruta, TimeSpan hora_final_ruta, int id_conductor)
        {
            using (MySqlConnection conn = ConectarDB.establecerConexion())
            {
                conn.Open();

                string query = @"UPDATE tbl_rutas SET 
                    nombre_ruta = @nombre_ruta,
                    fecha_ruta = @fecha_ruta,
                    hora_inicio_ruta = @hora_inicio_ruta,
                    hora_final_ruta = @hora_final_ruta,
                    id_conductor = @id_conductor
                WHERE id_ruta = @id_ruta";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id_ruta", id_ruta);
                    cmd.Parameters.AddWithValue("@nombre_ruta", nombre_ruta);
                    cmd.Parameters.AddWithValue("@fecha_ruta", fecha_ruta);
                    cmd.Parameters.AddWithValue("@hora_inicio_ruta", hora_inicio_ruta);
                    cmd.Parameters.AddWithValue("@hora_final_ruta", hora_final_ruta);
                    cmd.Parameters.AddWithValue("@id_conductor", id_conductor);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        // ELIMINAR
        public void EliminarRuta(int id_ruta)
        {
            using (MySqlConnection conn = ConectarDB.establecerConexion())
            {
                conn.Open();

                string query = "DELETE FROM tbl_rutas WHERE id_ruta = @id_ruta";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id_ruta", id_ruta);
                    int affectedRows = cmd.ExecuteNonQuery();

                    if (affectedRows == 0)
                        throw new Exception("No se encontró la ruta con el ID especificado.");
                }
            }
        }
    }
}
