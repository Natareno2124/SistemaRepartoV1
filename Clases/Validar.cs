using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRepartoG4.Clases
{
    public class Validar
    {
        public string ctrlRegistro(UsuariosV usuario)
        {
            Modelo modelo = new Modelo();
            string respuesta = "";
            

            if (string.IsNullOrEmpty(usuario.Nombres) ||
                string.IsNullOrEmpty(usuario.Apellidos) ||
                string.IsNullOrEmpty(usuario.Usuario) ||
                string.IsNullOrEmpty(usuario.Contrasena) ||
                string.IsNullOrEmpty(usuario.ConPassword) ||
                string.IsNullOrEmpty(usuario.Email) ||
                string.IsNullOrEmpty(usuario.Telefono)
                )
            {
                respuesta="Todos los campos deben estar llenos";
            }
            else
            {
                if (usuario.Contrasena == usuario.ConPassword)
                {
                    if (modelo.ComprobarUsuario(usuario.Usuario))
                    {
                        respuesta = "El usuario ya existe";
                    }
                    else
                    {
                        usuario.Contrasena = generarSHA1(usuario.Contrasena);
                        int resultado = modelo.Registro(usuario);
                    }

                }
                else { 
                    respuesta = "La contraseña no coincide, vuelve a intentar";

                }
                
            }
            return respuesta;
        }

        public string ctrlLogin(string usuario, string password) { 
            
            Modelo modelo = new Modelo();
            string respuesta = "";
            UsuariosV datosUsuario = null;

            if (string.IsNullOrEmpty(usuario)|| string.IsNullOrEmpty(password))
            {

                respuesta = "Todos los campos deben estar llenos";

            }
            else
            {
                datosUsuario = modelo.InicioSesion(usuario);
                if (datosUsuario == null)
                {
                    respuesta = "El usuario no existe";
                }
                else
                {
                    if (datosUsuario.Contrasena != generarSHA1(password)) {
                        respuesta = "Usuario y/o contraseña incorrectos";
                    }
                    else
                    {
                        Session.id = datosUsuario.Id;
                        Session.usuario = datosUsuario.Usuario;
                        Session.nombres = datosUsuario.Nombres;
                        Session.id_rol = datosUsuario.Rol_usuario;
                    }
                }
            }
            return respuesta;

        }
        private string generarSHA1(string cadena)
        {
            UTF8Encoding enc = new UTF8Encoding();
            byte[] data = enc.GetBytes(cadena);
            byte[] result;

            SHA1CryptoServiceProvider sha = new SHA1CryptoServiceProvider();

            result = sha.ComputeHash(data);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] < 16)
                {
                    sb.Append("0");
                }
                sb.Append(result[i].ToString("x"));
            }

            return sb.ToString();
        }






    }
}
