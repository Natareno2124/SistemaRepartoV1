using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRepartoG4.Clases
{
    public class UsuariosV
    {
        int id_usuario,rol_usuario;
        string nombres_usuario, apellidos_usuario, usuario, contrasena_usuario,conPassword, email_usuario, telefono_usuario;

        public string Nombres { get => nombres_usuario; set => nombres_usuario = value; }
        public string Apellidos { get => apellidos_usuario; set => apellidos_usuario = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Contrasena { get => contrasena_usuario; set => contrasena_usuario = value; }
        public string ConPassword { get => conPassword; set => conPassword = value; }
        public string Email { get => email_usuario; set => email_usuario = value; }
        public string Telefono { get => telefono_usuario; set => telefono_usuario = value; }
        //-------------------------------------------------------------------------------------
        public int Id { get => id_usuario; set => id_usuario = value; }
        public int Rol_usuario { get => rol_usuario; set => rol_usuario = value; }
    }
}
