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
            //llamamos el archivo de la conexion y su funcion
            using (MySqlConnection conn = ConectarDB.establecerConexion())
            {
                //sentencia sql para llamar todos los datos que necesitamos
                string query = @"
                    SELECT 
                        c.id_conductor,
                        c.nombre_conductor,
                        c.apellido_conductor,
                        c.fecha_nacimiento_conductor,
                        c.sexo_conductor,
                        c.tipo_licencia_conductor,
                        c.id_sucursal AS SucursalID, 
                        s.codigo_sucursal AS Sucursal,
                        cc.telefono_conductor,
                        cc.correo_conductor,
                        cd.calle_conductor,
                        cd.avenida_conductor,
                        cd.zona_conductor,
                        cd.ciudad_conductor,
                        cd.municipio_conductor
                    FROM tbl_conductores c
                    LEFT JOIN tbl_sucursal s ON c.id_sucursal = s.id_sucursal
                    LEFT JOIN tbl_conductor_contacto cc ON c.id_conductor = cc.id_conductor
                    LEFT JOIN tbl_conductor_direccion cd ON c.id_conductor = cd.id_conductor";
                //configuracion de conexion
                MySqlDataAdapter adaptador = new MySqlDataAdapter(query, conn);
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                return tabla;
            }
        }


        // agregar
        public void InsertarPiloto(
            //variables
            string nombre_conductor,
            string apellido_conductor,
            DateTime fecha_nacimiento_conductor,
            string sexo_conductor,
            string tipo_licencia_conductor,
            int id_sucursal,
            string telefono_conductor,
            string correo_conductor,
            string calle_conductor,
            string avenida_conductor,
            int zona_conductor,
            string ciudad_conductor,
            string municipio_conductor
        )
        {
            //validamos ingreso de datos
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

                //ESTO ABRE LA CONEXION CON MYSQL IMPORTANTE
                conn.Open();

                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        // Insertar en conductores
                        string queryConductor = @"
                            INSERT INTO tbl_conductores 
                            (nombre_conductor, apellido_conductor, fecha_nacimiento_conductor, sexo_conductor, tipo_licencia_conductor, id_sucursal)
                            VALUES (@nombre, @apellido, @fecha_nac, @sexo, @licencia, @id_sucursal);
                            SELECT LAST_INSERT_ID();";

                        int nuevoIdConductor;

                        using (MySqlCommand cmd = new MySqlCommand(queryConductor, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@nombre", nombre_conductor);
                            cmd.Parameters.AddWithValue("@apellido", apellido_conductor);
                            cmd.Parameters.AddWithValue("@fecha_nac", fecha_nacimiento_conductor);
                            cmd.Parameters.AddWithValue("@sexo", sexo_conductor);
                            cmd.Parameters.AddWithValue("@licencia", tipo_licencia_conductor);
                            cmd.Parameters.AddWithValue("@id_sucursal", id_sucursal);

                            nuevoIdConductor = Convert.ToInt32(cmd.ExecuteScalar());
                        }

                        // Insertar en conductor contacto
                        string queryContacto = @"
                            INSERT INTO tbl_conductor_contacto
                            (id_conductor, telefono_conductor, correo_conductor)
                            VALUES (@id_conductor, @telefono, @correo);";

                        using (MySqlCommand cmd = new MySqlCommand(queryContacto, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@id_conductor", nuevoIdConductor);
                            cmd.Parameters.AddWithValue("@telefono", telefono_conductor);
                            cmd.Parameters.AddWithValue("@correo", correo_conductor);

                            cmd.ExecuteNonQuery();
                        }

                        // Insertar en conductor direccion
                        string queryDireccion = @"
                            INSERT INTO tbl_conductor_direccion
                            (id_conductor, calle_conductor, avenida_conductor, zona_conductor, ciudad_conductor, municipio_conductor)
                            VALUES (@id_conductor, @calle, @avenida, @zona, @ciudad, @municipio);";

                        using (MySqlCommand cmd = new MySqlCommand(queryDireccion, conn, transaction))
                        {
                            //relacionamos
                            cmd.Parameters.AddWithValue("@id_conductor", nuevoIdConductor);
                            cmd.Parameters.AddWithValue("@calle", calle_conductor);
                            cmd.Parameters.AddWithValue("@avenida", avenida_conductor);
                            cmd.Parameters.AddWithValue("@zona", zona_conductor);
                            cmd.Parameters.AddWithValue("@ciudad", ciudad_conductor);
                            cmd.Parameters.AddWithValue("@municipio", municipio_conductor);

                            cmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }



        // modificar
        public void ModificarPiloto(
            //VARIABLES
            int id,
            string nombre_conductor,
            string apellido_conductor,
            DateTime fecha_nacimiento_conductor,
            string sexo_conductor,
            string tipo_licencia_conductor,
            int id_sucursal,
            string telefono_conductor,
            string correo_conductor,
            string calle_conductor,
            string avenida_conductor,
            string zona_conductor,
            string ciudad_conductor,
            string municipio_conductor)
        {
            //archivo de conexion y funcion
            using (MySqlConnection conn = ConectarDB.establecerConexion())
            {
                //ABRIMOS CONEXIONS
                conn.Open();

                using (MySqlTransaction transaction = conn.BeginTransaction())
                {
                    try
                    {
                        // conductores
                        string queryConductor = @"UPDATE tbl_conductores SET 
                            nombre_conductor = @nombre_conductor, 
                            apellido_conductor = @apellido_conductor,
                            fecha_nacimiento_conductor = @fecha_nacimiento_conductor,
                            sexo_conductor = @sexo_conductor,
                            tipo_licencia_conductor = @tipo_licencia_conductor,
                            id_sucursal = @id_sucursal
                        WHERE id_conductor = @id";

                        using (MySqlCommand cmd1 = new MySqlCommand(queryConductor, conn, transaction))
                        {
                            cmd1.Parameters.AddWithValue("@id", id);
                            cmd1.Parameters.AddWithValue("@nombre_conductor", nombre_conductor);
                            cmd1.Parameters.AddWithValue("@apellido_conductor", apellido_conductor);
                            cmd1.Parameters.AddWithValue("@fecha_nacimiento_conductor", fecha_nacimiento_conductor);
                            cmd1.Parameters.AddWithValue("@sexo_conductor", sexo_conductor);
                            cmd1.Parameters.AddWithValue("@tipo_licencia_conductor", tipo_licencia_conductor);
                            cmd1.Parameters.AddWithValue("@id_sucursal", id_sucursal);
                            cmd1.ExecuteNonQuery();
                        }

                        // Actualizar contacto
                        string queryContacto = @"UPDATE tbl_conductor_contacto SET 
                    telefono_conductor = @telefono_conductor,
                    correo_conductor = @correo_conductor
                WHERE id_conductor = @id";

                        using (MySqlCommand cmd2 = new MySqlCommand(queryContacto, conn, transaction))
                        {
                            cmd2.Parameters.AddWithValue("@id", id);
                            cmd2.Parameters.AddWithValue("@telefono_conductor", telefono_conductor);
                            cmd2.Parameters.AddWithValue("@correo_conductor", correo_conductor);
                            cmd2.ExecuteNonQuery();
                        }

                        // Actualizar direccion
                        string queryDireccion = @"UPDATE tbl_conductor_direccion SET 
                    calle_conductor = @calle_conductor,
                    avenida_conductor = @avenida_conductor,
                    zona_conductor = @zona_conductor,
                    ciudad_conductor = @ciudad_conductor,
                    municipio_conductor = @municipio_conductor
                WHERE id_conductor = @id";

                        using (MySqlCommand cmd3 = new MySqlCommand(queryDireccion, conn, transaction))
                        {
                            cmd3.Parameters.AddWithValue("@id", id);
                            cmd3.Parameters.AddWithValue("@calle_conductor", calle_conductor);
                            cmd3.Parameters.AddWithValue("@avenida_conductor", avenida_conductor);
                            cmd3.Parameters.AddWithValue("@zona_conductor", zona_conductor);
                            cmd3.Parameters.AddWithValue("@ciudad_conductor", ciudad_conductor);
                            cmd3.Parameters.AddWithValue("@municipio_conductor", municipio_conductor);
                            cmd3.ExecuteNonQuery();
                        }

                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Error al modificar piloto: " + ex.Message);
                    }
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
                    //ABRIR CONXION 
                    conn.Open();

                    using (MySqlTransaction transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            //3 direfentes porque se relacionan
                            // Eliminar dirección
                            using (MySqlCommand cmdDireccion = new MySqlCommand(
                                "DELETE FROM tbl_conductor_direccion WHERE id_conductor = @id_conductor", conn, transaction))
                            {
                                cmdDireccion.Parameters.AddWithValue("@id_conductor", id_conductor);
                                cmdDireccion.ExecuteNonQuery();
                            }

                            // Eliminar contacto
                            using (MySqlCommand cmdContacto = new MySqlCommand(
                                "DELETE FROM tbl_conductor_contacto WHERE id_conductor = @id_conductor", conn, transaction))
                            {
                                cmdContacto.Parameters.AddWithValue("@id_conductor", id_conductor);
                                cmdContacto.ExecuteNonQuery();
                            }

                            // Eliminar piloto
                            using (MySqlCommand cmdPiloto = new MySqlCommand(
                                "DELETE FROM tbl_conductores WHERE id_conductor = @id_conductor", conn, transaction))
                            {
                                cmdPiloto.Parameters.AddWithValue("@id_conductor", id_conductor);
                                int affectedRows = cmdPiloto.ExecuteNonQuery();

                                if (affectedRows == 0)
                                    throw new Exception("No se encontró el piloto con el ID especificado.");
                            }

                            transaction.Commit();
                        }
                        catch
                        {
                            transaction.Rollback();
                            throw;
                        }
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