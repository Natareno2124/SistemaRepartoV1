using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//creada por Rocio Lopez 9959-23-740
//Creando la clase modelo RutaV.cs
namespace SistemaRepartoG4.Clases
{
    internal class RutaV
    {

        MySqlConnection conex = new MySqlConnection();

        static string servidor = "localhost";
        static string database = "SistemaReparto";
        static string usuario   = "root";   
        static string password = "root1234";
        static string puerto = "3306";

        string cadenaConexion = "server=" + servidor + ";database=" + database + ";user=" + usuario + ";password=" + password + ";port=" + puerto + ";SslMode=none;";



        //metodo para establecer la conexion    est es puublico
        public MySqlConnection establecerConexion()
        {

            //Esto es para manejar excepciones si es que fallara y nose salga el programa
            try
            {
                conex.ConnectionString = cadenaConexion;
                //abre la conexión
                conex.Open();
                //mensaje si esexitosa la conexión
                MessageBox.Show("Conexión exitosa a la base de datos", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al establecer la conexión a la base de datos: " + ex.ToString());
            }
           // conex = new MySqlConnection(cadenaConexion);
            return conex;
        }


        //metodo para cerrar la conexion
        public void cerrarConexion()
        {
            
            try
            {
                if (conex.State == System.Data.ConnectionState.Open)
                {
                    conex.Close();
                    MessageBox.Show("Conexión cerrada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cerrar la conexión a la base de datos: " + ex.ToString());
            }
        }

    }
}




