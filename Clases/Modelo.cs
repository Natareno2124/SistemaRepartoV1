using System;
using MySql.Data.MySqlClient;

namespace SistemaRepartoG4.Clases
{
    public class Modelo
    {
        public int Registro(UsuariosV usuario)
        {
            try
            {
                MySqlConnection conexion = ConectarDB.establecerConexion();
                conexion.Open();

                string query = "INSERT INTO tbl_usuarios (nombres_usuario, apellidos_usuario, usuario, contrasena_usuario, email_usuario, telefono_usuario, rol_usuario) " +
                               "VALUES (@nombres, @apellidos, @usuario, @contrasena, @email, @telefono, @tipo_usuario)";

                MySqlCommand cmd = new MySqlCommand(query, conexion);

                cmd.Parameters.AddWithValue("@nombres", usuario.Nombres);
                cmd.Parameters.AddWithValue("@apellidos", usuario.Apellidos);
                cmd.Parameters.AddWithValue("@usuario", usuario.Usuario);
                cmd.Parameters.AddWithValue("@contrasena", usuario.Contrasena);
                cmd.Parameters.AddWithValue("@email", usuario.Email);
                cmd.Parameters.AddWithValue("@telefono", usuario.Telefono);
                cmd.Parameters.AddWithValue("@tipo_usuario", usuario.Rol_usuario); // debe coincidir con el ID del rol

                int resultado = cmd.ExecuteNonQuery();
                conexion.Close();

                return resultado; // número de filas insertadas (1 si fue exitoso)
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al registrar usuario: " + ex.Message);
                return 0;
            }
        }


        public bool ComprobarUsuario(string usuario)
        {
            MySqlDataReader reader;
            MySqlConnection conexion = ConectarDB.establecerConexion();
            conexion.Open();

            string query = "SELECT id_usuario FROM tbl_usuarios WHERE usuario LIKE @usuario";

            MySqlCommand cmd = new MySqlCommand(query, conexion);

            cmd.Parameters.AddWithValue("@usuario", usuario);
            reader = cmd.ExecuteReader();
            if (reader.HasRows) {
                return true;
            }
            else
            {
                return false;
            }
        }

        public UsuariosV InicioSesion(string usuario)
        {
            MySqlDataReader reader;
            MySqlConnection conexion = ConectarDB.establecerConexion();
            conexion.Open();

            string query = "SELECT id_usuario, contrasena_usuario, nombres_usuario, rol_usuario FROM tbl_usuarios WHERE usuario LIKE @usuario";

            MySqlCommand cmd = new MySqlCommand(query, conexion);

            cmd.Parameters.AddWithValue("@usuario", usuario);
            reader = cmd.ExecuteReader();

            UsuariosV user = null;
            while(reader.Read())
            {
                user = new UsuariosV();
                user.Id = int.Parse(reader["id_usuario"].ToString());
                user.Contrasena= reader["contrasena_usuario"].ToString();
                user.Nombres = reader["nombres_usuario"].ToString();
                user.Rol_usuario=int.Parse(reader["rol_usuario"].ToString());

            }
            return user;

        }

        public string ModificarUsuario(UsuariosV usuario)
        {
            try
            {
                using (MySqlConnection conexion = ConectarDB.establecerConexion())
                {
                    conexion.Open();

                    string query = @"UPDATE tbl_usuarios
                             SET nombres_usuario = @nombres,
                                 apellidos_usuario = @apellidos,
                                 usuario = @usuario,
                                 contrasena_usuario = @contrasena,
                                 email_usuario = @email,
                                 telefono_usuario = @telefono
                             WHERE id_usuario = @id";

                    MySqlCommand cmd = new MySqlCommand(query, conexion);

                    cmd.Parameters.AddWithValue("@nombres", usuario.Nombres);
                    cmd.Parameters.AddWithValue("@apellidos", usuario.Apellidos);
                    cmd.Parameters.AddWithValue("@usuario", usuario.Usuario);
                    cmd.Parameters.AddWithValue("@contrasena", usuario.Contrasena); // Ya debe estar hasheada
                    cmd.Parameters.AddWithValue("@email", usuario.Email);
                    cmd.Parameters.AddWithValue("@telefono", usuario.Telefono);
                    cmd.Parameters.AddWithValue("@id", usuario.Id);

                    int filasAfectadas = cmd.ExecuteNonQuery();

                    conexion.Close();

                    if (filasAfectadas > 0)
                        return "";  // Sin error
                    else
                        return "No se encontró el usuario para actualizar";
                }
            }
            catch (Exception ex)
            {
                return "Error al actualizar usuario: " + ex.Message;
            }
        }

        public bool EliminarUsuario(int id)
        {
            try
            {
                MySqlConnection conexion = ConectarDB.establecerConexion();
                conexion.Open();

                string query = "DELETE FROM tbl_usuarios WHERE id_usuario = @id";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@id", id);

                int resultado = cmd.ExecuteNonQuery();
                conexion.Close();

                return resultado > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar usuario: " + ex.Message);
                return false;
            }
        }


    }
}
