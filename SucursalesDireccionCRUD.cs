using System;
using MySql.Data.MySqlClient;
using System.Data;
using SistemaRepartoG4.Clases;

namespace SistemaRepartoG4
{
    public class DireccionSucursalCRUD
    {
        private ConectarDB conexion = new ConectarDB();

        // Mostrar direcciones de sucursales
        public DataTable ObtenerDirecciones()
        {
            using (MySqlConnection conn = ConectarDB.establecerConexion())
            {
                string query = @"
                    SELECT 
                        id_direccion_sucursal,
                        calle_sucursal,
                        avenida_sucursal,
                        zona_sucursal,
                        ciudad_sucursal,
                        municipio_sucursal
                    FROM tbl_direccion_sucursal";

                MySqlDataAdapter adaptador = new MySqlDataAdapter(query, conn);
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                return tabla;
            }
        }

        // Insertar dirección
        public void InsertarDireccion(string calle, string avenida, int zona, string ciudad, string municipio)
        {
            if (string.IsNullOrWhiteSpace(calle) || string.IsNullOrWhiteSpace(avenida) ||
                string.IsNullOrWhiteSpace(ciudad) || string.IsNullOrWhiteSpace(municipio))
                throw new ArgumentException("Todos los campos son obligatorios.");

            if (zona <= 0)
                throw new ArgumentException("Zona inválida.");

            using (MySqlConnection conn = ConectarDB.establecerConexion())
            {
                conn.Open();

                string query = @"INSERT INTO tbl_direccion_sucursal 
                    (calle_sucursal, avenida_sucursal, zona_sucursal, ciudad_sucursal, municipio_sucursal) 
                    VALUES (@calle, @avenida, @zona, @ciudad, @municipio)";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@calle", calle);
                    cmd.Parameters.AddWithValue("@avenida", avenida);
                    cmd.Parameters.AddWithValue("@zona", zona);
                    cmd.Parameters.AddWithValue("@ciudad", ciudad);
                    cmd.Parameters.AddWithValue("@municipio", municipio);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Modificar dirección
        public void ModificarDireccion(int id, string calle, string avenida, int zona, string ciudad, string municipio)
        {
            if (id <= 0)
                throw new ArgumentException("ID inválido.");

            using (MySqlConnection conn = ConectarDB.establecerConexion())
            {
                conn.Open();

                string query = @"UPDATE tbl_direccion_sucursal SET 
                    calle_sucursal = @calle,
                    avenida_sucursal = @avenida,
                    zona_sucursal = @zona,
                    ciudad_sucursal = @ciudad,
                    municipio_sucursal = @municipio
                    WHERE id_direccion_sucursal = @id";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@calle", calle);
                    cmd.Parameters.AddWithValue("@avenida", avenida);
                    cmd.Parameters.AddWithValue("@zona", zona);
                    cmd.Parameters.AddWithValue("@ciudad", ciudad);
                    cmd.Parameters.AddWithValue("@municipio", municipio);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Eliminar dirección
        public void EliminarDireccion(int id)
        {
            try
            {
                using (MySqlConnection conn = ConectarDB.establecerConexion())
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand(
                        "DELETE FROM tbl_direccion_sucursal WHERE id_direccion_sucursal = @id", conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        int affectedRows = cmd.ExecuteNonQuery();

                        if (affectedRows == 0)
                            throw new Exception("No se encontró la dirección con el ID especificado.");
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
