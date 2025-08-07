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


            string servidor = "localhost";
            string database = "SistemaReparto2";
            string usuario = "root";
            string password = "1234";
            string puerto = "3306";

            string cadenaConexion = "server=" + servidor + ";database=" + database + ";user=" + usuario + ";password=" + password + ";port=" + puerto + ";SslMode=none;";

            MySqlConnection conexion = new MySqlConnection(cadenaConexion);

            return conexion;



        }
    }
}
