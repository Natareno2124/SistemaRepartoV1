//PilotosCRUD.cs

using System;
using MySql.Data.MySqlClient;
using System.Data;
using SistemaRepartoG4.Clases;
using System.Windows.Forms;

namespace SistemaRepartoG4
{
    public class PilotosCRUD
    {
        private ConectarDB conexion = new ConectarDB();

        // mostrar
        public DataTable ObtenerPilotos()
        {
            using (MySqlConnection conn = ConectarDB.establecerConexion())
            {
                string query = @"
            SELECT 
                c.id_conductor,
                c.nombre_conductor,
                c.apellido_conductor,
                c.fecha_nacimiento_conductor,
                c.sexo_conductor,
                c.tipo_licencia_conductor,
                c.id_sucursal AS SucursalID, 
                s.codigo_sucursal AS Sucursal
            FROM tbl_conductores c
            LEFT JOIN tbl_sucursal s ON c.id_sucursal = s.id_sucursal";

                MySqlDataAdapter adaptador = new MySqlDataAdapter(query, conn);
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                return tabla;
            }
        }

        // agregar
        public void InsertarPiloto(string nombre_conductor, string apellido_conductor, DateTime fecha_nacimiento_conductor, string sexo_conductor, string tipo_licencia_conductor, int id_sucursal)
        {
            if (string.IsNullOrWhiteSpace(nombre_conductor) || string.IsNullOrWhiteSpace(apellido_conductor))
                throw new ArgumentException("Nombres y apellidos son obligatorios.");

            if (fecha_nacimiento_conductor > DateTime.Now)
                throw new ArgumentException("La fecha de nacimiento no puede ser en el futuro.");

            if (sexo_conductor != "M" && sexo_conductor != "F")
                throw new ArgumentException("Sexo inválido.");

            if (string.IsNullOrWhiteSpace(tipo_licencia_conductor))
                throw new ArgumentException("El tipo de licencia es obligatorio.");

            if (id_sucursal <= 0)
                throw new ArgumentException("Sucursal inválida.");

            using (MySqlConnection conn = ConectarDB.establecerConexion())
            {
                if (conn == null)
                    throw new Exception("Error de conexión a la base de datos");

                conn.Open();

                string query = @"INSERT INTO tbl_conductores 
            (nombre_conductor, apellido_conductor, fecha_nacimiento_conductor, sexo_conductor, tipo_licencia_conductor, id_sucursal) 
            VALUES (@nombre_conductor, @apellido_conductor, @fecha_nacimiento_conductor, @sexo_conductor, @tipo_licencia_conductor, @id_sucursal)";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    // Parámetros CORREGIDOS (sin espacios y todos incluidos):
                    cmd.Parameters.AddWithValue("@nombre_conductor", nombre_conductor);
                    cmd.Parameters.AddWithValue("@apellido_conductor", apellido_conductor);
                    cmd.Parameters.AddWithValue("@fecha_nacimiento_conductor", fecha_nacimiento_conductor);
                    cmd.Parameters.AddWithValue("@sexo_conductor", sexo_conductor);
                    cmd.Parameters.AddWithValue("@tipo_licencia_conductor", tipo_licencia_conductor);
                    cmd.Parameters.AddWithValue("@id_sucursal", id_sucursal);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        // modificar
        public void ModificarPiloto(int id, string nombre_conductor, string apellido_conductor, DateTime fecha_nacimiento_conductor, string sexo_conductor, string tipo_licencia_conductor, int id_sucursal)
        {
            using (MySqlConnection conn = ConectarDB.establecerConexion())
            {
                conn.Open();

                string query = @"UPDATE tbl_conductores SET 
            nombre_conductor = @nombre_conductor, 
            apellido_conductor = @apellido_conductor,
            fecha_nacimiento_conductor = @fecha_nacimiento_conductor,
            sexo_conductor = @sexo_conductor,
            tipo_licencia_conductor = @tipo_licencia_conductor,
            id_sucursal = @id_sucursal
        WHERE id_conductor = @id";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@nombre_conductor", nombre_conductor);
                    cmd.Parameters.AddWithValue("@apellido_conductor", apellido_conductor);
                    cmd.Parameters.AddWithValue("@fecha_nacimiento_conductor", fecha_nacimiento_conductor);
                    cmd.Parameters.AddWithValue("@sexo_conductor", sexo_conductor);
                    cmd.Parameters.AddWithValue("@tipo_licencia_conductor", tipo_licencia_conductor);
                    cmd.Parameters.AddWithValue("@id_sucursal", id_sucursal);

                    cmd.ExecuteNonQuery();

                }
            }
        }

        // eliminar
        public void EliminarPiloto(int id_conductor)
        {
            try
            {
                using (MySqlConnection conn = ConectarDB.establecerConexion())
                {
                    if (conn == null)
                        throw new Exception("Error: La conexión a la base de datos es nula.");

                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand(
                        "DELETE FROM tbl_conductores WHERE id_conductor = @id_conductor",
                        conn))
                    {
                        cmd.Parameters.AddWithValue("@id_conductor", id_conductor);
                        int affectedRows = cmd.ExecuteNonQuery();

                        if (affectedRows == 0)
                            throw new Exception("No se encontró el piloto con el ID especificado.");
                    }
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception($"Error de MySQL: {ex.Message}");
            }
            catch (Exception ex)
            {
                throw new Exception($"Error inesperado: {ex.Message}");
            }
        }
    }
}