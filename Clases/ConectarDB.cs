using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRepartoG4.Clases
{
    internal class ConectarDB
    {
        public static MySqlConnection establecerConexion()
        {


            string servidor = "192.168.0.8";

            string database = "SistemaReparto";
            string usuario = "usuprueba";
            string password = "123456";

            string puerto = "3306";

            string cadenaConexion = "server=" + servidor + ";database=" + database + ";user=" + usuario + ";password=" + password + ";port=" + puerto + ";SslMode=none;";

            MySqlConnection conexion = new MySqlConnection(cadenaConexion);

            return conexion;



        }
    }
}
