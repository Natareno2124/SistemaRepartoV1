using MySql.Data.MySqlClient;
using SistemaRepartoG4.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SistemaRepartoG4.Clases
{
    public class PaquetesCRUD
    {
        // agregar paquete
        public static bool AgregarPaquete(Paquete paquete)
        {
            using (MySqlConnection conexion = ConectarDB.establecerConexion())
            {
                try
                {
                    conexion.Open();


                    // con esto se insertaran los datos, tomando en cuenta las variables
                    string query = @"INSERT INTO tbl_paquete 
                    (id_guia_madre, peso_kg_paquete, largo_cm_paquete, ancho_cm_paquete, alto_cm_paquete, 
                    descripcion_paquete, precio_paquete, fragil_paquete, tiempo_entrega_paquete, 
                    id_bodega, id_sucursal)
                    VALUES (@id, @peso, @largo, @ancho, @alto, @descripcion, @precio, @fragil, @tiempo, @bodega, @sucursal)";

                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@id", paquete.IdGuiaMadre);
                    cmd.Parameters.AddWithValue("@peso", paquete.PesoKg);
                    cmd.Parameters.AddWithValue("@largo", paquete.LargoCm);
                     cmd.Parameters.AddWithValue("@ancho", paquete.AnchoCm);
                    cmd.Parameters.AddWithValue("@alto", paquete.AltoCm);
                     cmd.Parameters.AddWithValue("@descripcion", paquete.Descripcion);
                    cmd.Parameters.AddWithValue("@precio", paquete.Precio);
                    cmd.Parameters.AddWithValue("@fragil", paquete.Fragil);
                     cmd.Parameters.AddWithValue("@tiempo", paquete.TiempoEntrega);
                    cmd.Parameters.AddWithValue("@bodega", paquete.IdBodega);
                    cmd.Parameters.AddWithValue("@sucursal", paquete.IdSucursal);

                    cmd.ExecuteNonQuery();
                    return true;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al insertar paquete: " + ex.Message);
                    return false;
                }


            }
        }

        // eliminar paquete

        public static bool EliminarPaquete(int idGuiaMadre)
        {
            using (MySqlConnection conexion = ConectarDB.establecerConexion())
            {
                try
                {
                    conexion.Open();

                    // al igual que en insertar, aqui los eliminara al ingresar el id (guia madre)
                    string query = "DELETE FROM tbl_paquete WHERE id_guia_madre = @id";

                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@id", idGuiaMadre);

                    int filasAfectadas = cmd.ExecuteNonQuery();
                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Paquete eliminado correctamente.");
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("No se encontró un paquete con ese ID.");
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar paquete: " + ex.Message);
                    return false;
                }
            }
        }


        // actualizar paquete
        public static bool ActualizarPaquete(Paquete paquete)
        {
            using (MySqlConnection conexion = ConectarDB.establecerConexion())
            {
                try
                {
                    conexion.Open();


                    // como los anteriores dos, aqui se actualizara tomando en cuenta las variables
                    string query = @"UPDATE tbl_paquete SET 
                peso_kg_paquete = @peso,
                largo_cm_paquete = @largo,
                ancho_cm_paquete = @ancho,
                alto_cm_paquete = @alto,
                descripcion_paquete = @descripcion,
                precio_paquete = @precio,
                fragil_paquete = @fragil,
                tiempo_entrega_paquete = @tiempo,
                id_bodega = @bodega,
                id_sucursal = @sucursal
                WHERE id_guia_madre = @id";

                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@id", paquete.IdGuiaMadre);
                    cmd.Parameters.AddWithValue("@peso", paquete.PesoKg);
                    cmd.Parameters.AddWithValue("@largo", paquete.LargoCm);
                    cmd.Parameters.AddWithValue("@ancho", paquete.AnchoCm);
                    cmd.Parameters.AddWithValue("@alto", paquete.AltoCm);
                    cmd.Parameters.AddWithValue("@descripcion", paquete.Descripcion);
                    cmd.Parameters.AddWithValue("@precio", paquete.Precio);
                    cmd.Parameters.AddWithValue("@fragil", paquete.Fragil);
                    cmd.Parameters.AddWithValue("@tiempo", paquete.TiempoEntrega);
                    cmd.Parameters.AddWithValue("@bodega", paquete.IdBodega);
                    cmd.Parameters.AddWithValue("@sucursal", paquete.IdSucursal);

                    int filasAfectadas = cmd.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar paquete: " + ex.Message);
                    return false;
                }
            }
        }

        // con esto se mostraran los datos dentro de la BD
        public static void MostrarPaquetes(DataGridView dgv)
        {
            using (MySqlConnection conexion = ConectarDB.establecerConexion())
            {
                try
                {
                    conexion.Open();
                    string query = "SELECT * FROM tbl_paquete";
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(query, conexion);
                    System.Data.DataTable tabla = new System.Data.DataTable();
                    adaptador.Fill(tabla);
                    dgv.DataSource = tabla;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al mostrar paquetes: " + ex.Message);
                }
            }

        }

    }
}