using System;
using MySql.Data.MySqlClient;
using System.Data;
using SistemaRepartoG4.Clases;

namespace SistemaRepartoG4
{
    public class SucursalCRUD
    {
        private ConectarDB conexion = new ConectarDB();

        // Mostrar sucursales
        public DataTable ObtenerSucursales()
        {
            using (MySqlConnection conn = ConectarDB.establecerConexion())
            {
                string query = @"
                    SELECT 
                        s.id_sucursal,
                        s.codigo_sucursal,
                        s.id_encargado,
                        s.id_direccion_sucursal,
                        s.id_contacto_sucursal
                    FROM tbl_sucursal s";

                MySqlDataAdapter adaptador = new MySqlDataAdapter(query, conn);
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                return tabla;
            }
        }

        // ✅ Insertar sucursal (USANDO OBJETO)
        public static bool InsertarSucursal(Sucursal sucursal)
        {
            if (sucursal.CodigoSucursal <= 0)
                throw new ArgumentException("Código de sucursal inválido.");

            if (sucursal.IdEncargado <= 0 || sucursal.IdDireccionSucursal <= 0 || sucursal.IdContactoSucursal <= 0)
                throw new ArgumentException("Todos los ID deben ser válidos.");

            using (MySqlConnection conn = ConectarDB.establecerConexion())
            {
                conn.Open();
                string query = @"INSERT INTO tbl_sucursal 
                    (codigo_sucursal, id_encargado, id_direccion_sucursal, id_contacto_sucursal) 
                    VALUES (@codigo, @encargado, @direccion, @contacto)";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@codigo", sucursal.CodigoSucursal);
                    cmd.Parameters.AddWithValue("@encargado", sucursal.IdEncargado);
                    cmd.Parameters.AddWithValue("@direccion", sucursal.IdDireccionSucursal);
                    cmd.Parameters.AddWithValue("@contacto", sucursal.IdContactoSucursal);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        // ✅ Modificar sucursal (USANDO OBJETO)
        public static bool ModificarSucursal(Sucursal sucursal)
        {
            if (sucursal.Id <= 0)
                throw new ArgumentException("ID de sucursal inválido.");

            using (MySqlConnection conn = ConectarDB.establecerConexion())
            {
                conn.Open();

                string query = @"UPDATE tbl_sucursal SET 
                    codigo_sucursal = @codigo,
                    id_encargado = @encargado,
                    id_direccion_sucursal = @direccion,
                    id_contacto_sucursal = @contacto
                    WHERE id_sucursal = @id";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", sucursal.Id);
                    cmd.Parameters.AddWithValue("@codigo", sucursal.CodigoSucursal);
                    cmd.Parameters.AddWithValue("@encargado", sucursal.IdEncargado);
                    cmd.Parameters.AddWithValue("@direccion", sucursal.IdDireccionSucursal);
                    cmd.Parameters.AddWithValue("@contacto", sucursal.IdContactoSucursal);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        // Eliminar sucursal
        public static bool EliminarSucursal(int id_sucursal)
        {
            try
            {
                using (MySqlConnection conn = ConectarDB.establecerConexion())
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand(
                        "DELETE FROM tbl_sucursal WHERE id_sucursal = @id", conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id_sucursal);
                        int affectedRows = cmd.ExecuteNonQuery();

                        return affectedRows > 0;
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

        // Listar encargados disponibles
        public DataTable ObtenerEncargados()
        {
            using (MySqlConnection conn = ConectarDB.establecerConexion())
            {
                string query = @"
                    SELECT 
                        id_usuario,
                        CONCAT(nombres_usuario, ' ', apellidos_usuario) AS nombre_completo
                    FROM tbl_usuarios
                    WHERE rol_usuario = 2";

                MySqlDataAdapter adaptador = new MySqlDataAdapter(query, conn);
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                return tabla;
            }
        }

        // Listar direcciones disponibles
        public DataTable ObtenerDirecciones()
        {
            using (MySqlConnection conn = ConectarDB.establecerConexion())
            {
                string query = @"
                    SELECT 
                        id_direccion_sucursal,
                        CONCAT('Calle ', calle_sucursal, ', Avenida ', avenida_sucursal, ', Zona ', zona_sucursal, ', ', ciudad_sucursal, ', ', municipio_sucursal) AS direccion_completa
                    FROM tbl_direccion_sucursal";

                MySqlDataAdapter adaptador = new MySqlDataAdapter(query, conn);
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                return tabla;
            }
        }
    }
}
