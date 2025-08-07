// BodegaCRUD.cs
using System;
using System.Data;
using MySql.Data.MySqlClient;
using SistemaRepartoG4.Clases;

namespace SistemaRepartoG4
{
    public class BodegaCRUD
    {
        private ConectarDB conexion = new ConectarDB();

        public DataTable ObtenerBodegas()
        {
            using (MySqlConnection conn = ConectarDB.establecerConexion())
            {
                string query = @"
                    SELECT
                        b.id_bodega AS ID_Bodega,
                        b.codigo_bodega AS Código,
                        b.id_encargado AS EncargadoID,
                        e.nombre_encargado AS Encargado,
                        b.id_sucursal AS SucursalID,
                        s.codigo_sucursal AS Sucursal,
                        b.capacidad_bodega AS Capacidad
                    FROM tbl_bodega b
                    LEFT JOIN tbl_encargado e ON b.id_encargado = e.id_encargado
                    LEFT JOIN tbl_sucursal s ON b.id_sucursal = s.id_sucursal";

                var adaptador = new MySqlDataAdapter(query, conn);
                var tabla = new DataTable();
                adaptador.Fill(tabla);
                return tabla;
            }
        }

        public void InsertarBodega(int codigo, int idEncargado, int idSucursal, int capacidad)
        {
            

            string query = @"INSERT INTO tbl_bodega
                            (codigo_bodega, id_encargado, id_sucursal, capacidad_bodega)
                            VALUES (@codigo, @encargado, @sucursal, @capacidad)";

            try
            {
                using (MySqlConnection conn = ConectarDB.establecerConexion())
                {
                    conn.Open();
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@codigo", codigo);
                        cmd.Parameters.AddWithValue("@encargado", idEncargado);
                        cmd.Parameters.AddWithValue("@sucursal", idSucursal);
                        cmd.Parameters.AddWithValue("@capacidad", capacidad);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (MySqlException ex)
            {
                    if (ex.Number == 1452)
                {
                    throw new Exception("No se puede agregar la bodega. El encargado o la sucursal especificada no existen.", ex);
                }
                else
                {
                    throw new Exception("Ocurrió un error en la base de datos al insertar la bodega.", ex);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error inesperado al intentar agregar la bodega.", ex);
            }
        }

        public void ModificarBodega(int id, int codigo, int idEncargado, int idSucursal, int capacidad)
        {
            if (id <= 0)
                throw new ArgumentException("El ID de bodega debe ser un número positivo.", nameof(id));
            if (codigo <= 0)
                throw new ArgumentException("El código de bodega debe ser un número positivo.", nameof(codigo));
            if (idEncargado <= 0)
                throw new ArgumentException("El ID de encargado debe ser válido.", nameof(idEncargado));
            if (idSucursal <= 0)
                throw new ArgumentException("El ID de sucursal debe ser válido.", nameof(idSucursal));
            if (capacidad <= 0)
                throw new ArgumentException("La capacidad debe ser un número positivo.", nameof(capacidad));
            string query = @"UPDATE tbl_bodega SET
                                codigo_bodega = @codigo,
                                id_encargado = @encargado,
                                id_sucursal = @sucursal,
                                capacidad_bodega = @capacidad
                            WHERE id_bodega = @id";

            try
            {
                using (MySqlConnection conn = ConectarDB.establecerConexion())
                {
                    conn.Open();
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@codigo", codigo);
                        cmd.Parameters.AddWithValue("@encargado", idEncargado);
                        cmd.Parameters.AddWithValue("@sucursal", idSucursal);
                        cmd.Parameters.AddWithValue("@capacidad", capacidad);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected == 0)
                        {
                            throw new Exception("No se encontró la bodega con el ID especificado para actualizar.");
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1452)
                {
                    throw new Exception("No se puede actualizar la bodega. El encargado o la sucursal especificada no existen.", ex);
                }
                else
                {
                    throw new Exception("Ocurrió un error en la base de datos al actualizar la bodega.", ex);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error inesperado al intentar actualizar la bodega.", ex);
            }
        }

        public void EliminarBodega(int id)
        {
            if (id <= 0) throw new ArgumentException("El ID de bodega debe ser válido.");

            using (MySqlConnection conn = ConectarDB.establecerConexion())
            {
                conn.Open();
                string query = "DELETE FROM tbl_bodega WHERE id_bodega = @id";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    int rows = cmd.ExecuteNonQuery();
                    if (rows == 0) throw new Exception("No se encontró la bodega especificada.");
                }
            }
        }
    }
}
