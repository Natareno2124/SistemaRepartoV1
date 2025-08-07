using System;
using MySql.Data.MySqlClient;
using System.Data;
using SistemaRepartoG4.Clases;

namespace SistemaRepartoG4
{
    public class EncargadoCRUD
    {
        private ConectarDB conexion = new ConectarDB();

        // Mostrar encargados
        public DataTable ObtenerEncargados()
        {
            using (MySqlConnection conn = ConectarDB.establecerConexion())
            {
                string query = @"
                    SELECT 
                        id_encargado,
                        nombre_encargado,
                        apellido_encargado,
                        codigo_encargado
                    FROM tbl_encargado";

                MySqlDataAdapter adaptador = new MySqlDataAdapter(query, conn);
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                return tabla;
            }
        }

        // Insertar encargado
        public void InsertarEncargado(string nombre, string apellido, int codigo)
        {
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellido))
                throw new ArgumentException("Nombre y apellido son obligatorios.");

            if (codigo <= 0)
                throw new ArgumentException("Código inválido.");

            using (MySqlConnection conn = ConectarDB.establecerConexion())
            {
                conn.Open();

                string query = @"INSERT INTO tbl_encargado 
                    (nombre_encargado, apellido_encargado, codigo_encargado) 
                    VALUES (@nombre, @apellido, @codigo)";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@apellido", apellido);
                    cmd.Parameters.AddWithValue("@codigo", codigo);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Modificar encargado
        public void ModificarEncargado(int id, string nombre, string apellido, int codigo)
        {
            if (id <= 0)
                throw new ArgumentException("ID inválido.");

            using (MySqlConnection conn = ConectarDB.establecerConexion())
            {
                conn.Open();

                string query = @"UPDATE tbl_encargado SET 
                    nombre_encargado = @nombre,
                    apellido_encargado = @apellido,
                    codigo_encargado = @codigo
                    WHERE id_encargado = @id";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@apellido", apellido);
                    cmd.Parameters.AddWithValue("@codigo", codigo);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Eliminar encargado
        public void EliminarEncargado(int id)
        {
            try
            {
                using (MySqlConnection conn = ConectarDB.establecerConexion())
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand(
                        "DELETE FROM tbl_encargado WHERE id_encargado = @id", conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        int affectedRows = cmd.ExecuteNonQuery();

                        if (affectedRows == 0)
                            throw new Exception("No se encontró el encargado con el ID especificado.");
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
