//TransporteCRUD

using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SistemaRepartoG4.Clases;

namespace SistemaRepartoG4
{
    public class TransporteCRUD
    {
        //archivo de conecion y su funcion
        private ConectarDB conexion = new ConectarDB();

        public DataTable ObtenerTransportes()
        {
            using (MySqlConnection conn = ConectarDB.establecerConexion())
            {
                string query = @"
                    SELECT
                        v.id_placa AS Placa,
                        v.marca_vehiculo AS Marca,
                        v.modelo_vehiculo AS Modelo,
                        v.color_vehiculo AS Color,
                        v.capacidad_vehiculo AS Capacidad,
                        v.id_sucursal AS SucursalID,
                        s.codigo_sucursal AS Sucursal,
                        v.id_tipo_vehiculo AS TipoID,
                        tv.nombre_tipo_vehiculo AS Tipo,
                        v.id_estado_vehiculo AS EstadoID,
                        ev.nombre_estado_vehiculo AS EstadoVehiculo
                    FROM tbl_vehiculos v
                    LEFT JOIN tbl_sucursal s ON v.id_sucursal = s.id_sucursal
                    LEFT JOIN tbl_tipo_vehiculo tv ON v.id_tipo_vehiculo = tv.id_tipo_vehiculo
                    LEFT JOIN tbl_estado_vehiculo ev ON v.id_estado_vehiculo = ev.id_estado_vehiculo";

                var adaptador = new MySqlDataAdapter(query, conn);
                var tabla = new DataTable();
                adaptador.Fill(tabla);
                return tabla;
            }
        }
        public void InsertarTransporte(int placa, string marca, string modelo, string color, string capacidad,
                                      int idSucursal, int idTipo, int idEstado)
        {
            if (placa <= 0)
                //validaciones
                throw new ArgumentException("La placa debe ser un número positivo.");
            if (string.IsNullOrWhiteSpace(marca))
                throw new ArgumentException("La marca es obligatoria.");
            if (string.IsNullOrWhiteSpace(modelo))
                throw new ArgumentException("El modelo es obligatorio.");
            if (string.IsNullOrWhiteSpace(color))
                throw new ArgumentException("El color es obligatorio.");
            if (string.IsNullOrWhiteSpace(capacidad))
                throw new ArgumentException("La capacidad es obligatoria.");
            if (idSucursal <= 0)
                throw new ArgumentException("El ID de la sucursal debe ser válido.");
            if (idTipo <= 0)
                throw new ArgumentException("El ID del tipo debe ser válido.");
            if (idEstado <= 0)
                throw new ArgumentException("El ID del estado debe ser válido.");

            using (MySqlConnection conn = ConectarDB.establecerConexion())
            {
                //ABRIMOS LA CONEXION CON ESTO IMPORTANTE 
                conn.Open();

                string query = @"INSERT INTO tbl_vehiculos 
                    (id_placa, marca_vehiculo, modelo_vehiculo, color_vehiculo, capacidad_vehiculo, 
                     id_sucursal, id_tipo_vehiculo, id_estado_vehiculo)
                VALUES (@placa, @marca, @modelo, @color, @capacidad, @idSucursal, @idTipo, @idEstado)";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@placa", placa);
                    cmd.Parameters.AddWithValue("@marca", marca);
                    cmd.Parameters.AddWithValue("@modelo", modelo);
                    cmd.Parameters.AddWithValue("@color", color);
                    cmd.Parameters.AddWithValue("@capacidad", capacidad);
                    cmd.Parameters.AddWithValue("@idSucursal", idSucursal);
                    cmd.Parameters.AddWithValue("@idTipo", idTipo);
                    cmd.Parameters.AddWithValue("@idEstado", idEstado);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Modificar
        public void ModificarTransporte(int placa, string marca, string modelo, string color, string capacidad,
                                        int idSucursal, int idTipo, int idEstado)
        {
            //VALIDACIONES
            if (placa <= 0) throw new ArgumentException("La placa debe ser un número positivo.");
            if (string.IsNullOrWhiteSpace(marca)) throw new ArgumentException("La marca es obligatoria.");
            if (string.IsNullOrWhiteSpace(modelo)) throw new ArgumentException("El modelo es obligatorio.");
            if (string.IsNullOrWhiteSpace(color)) throw new ArgumentException("El color es obligatorio.");
            if (string.IsNullOrWhiteSpace(capacidad)) throw new ArgumentException("La capacidad es obligatoria.");
            if (idSucursal <= 0) throw new ArgumentException("El ID de la sucursal debe ser válido.");
            if (idTipo <= 0) throw new ArgumentException("El ID del tipo debe ser válido.");
            if (idEstado <= 0) throw new ArgumentException("El ID del estado debe ser válido.");

            using (MySqlConnection conn = ConectarDB.establecerConexion())
            {
                if (conn == null)
                    throw new Exception("No se pudo establecer conexión con la base de datos.");
                //abir conexion
                conn.Open();

                string query = @"UPDATE tbl_vehiculos SET
                        marca_vehiculo = @marca,
                        modelo_vehiculo = @modelo,
                        color_vehiculo = @color,
                        capacidad_vehiculo = @capacidad,
                        id_sucursal = @sucursal,
                        id_tipo_vehiculo = @tipo,
                        id_estado_vehiculo = @estado
                    WHERE id_placa = @placa";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@placa", placa);
                    cmd.Parameters.AddWithValue("@marca", marca);
                    cmd.Parameters.AddWithValue("@modelo", modelo);
                    cmd.Parameters.AddWithValue("@color", color);
                    cmd.Parameters.AddWithValue("@capacidad", capacidad);
                    cmd.Parameters.AddWithValue("@sucursal", idSucursal);
                    cmd.Parameters.AddWithValue("@tipo", idTipo);
                    cmd.Parameters.AddWithValue("@estado", idEstado);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected == 0)
                    {
                        throw new Exception("No se encontró ningún vehículo con la placa especificada.");
                    }
                }
            }
        }

        // Eliminar vehículo
        public void EliminarTransporte(int placa)
        {
            if (placa <= 0)
                throw new ArgumentException("La placa debe ser un número positivo.");

            using (MySqlConnection conn = ConectarDB.establecerConexion())
            {
                if (conn == null)
                    throw new Exception("No se pudo establecer conexión con la base de datos.");

                conn.Open();

                string query = "DELETE FROM tbl_vehiculos WHERE id_placa = @placa";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@placa", placa);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected == 0)
                    {
                        throw new Exception("No se encontró ningún vehículo con la placa especificada.");
                    }
                }
            }
        }

    }
}