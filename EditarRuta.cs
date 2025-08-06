using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaRepartoG4
{
    public partial class EditarRuta : Form
    {
        public EditarRuta()
        {
            InitializeComponent();
        }



        private void btn_buscar_ruta_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Id_Ruta.Text))
            {
                MessageBox.Show("Por favor ingresa el ID de la ruta.");
                return;
            }

            int id = int.Parse(txt_Id_Ruta.Text);
            RutaModel ruta = RutasCRUD.ObtenerRutaPorId(id); // Este método lo hacemos abajo

            if (ruta != null)
            {
                txt_Nombre_de_Ruta.Text = ruta.Nombre;
                txtFecha_Ruta.Text = ruta.Fecha.ToString("yyyy-MM-dd");
                txt_hora_inicio_ruta.Text = ruta.HoraInicio.ToString();
                txt_hora_final_ruta.Text = ruta.HoraFinal.ToString();
                txt_id_conductor.Text = ruta.IdConductor.ToString();
            }
            else
            {
                MessageBox.Show("Ruta no encontrada.");
            }
        }



        private void btn_modificar_Click(object sender, EventArgs e)
        {
            try
            {
                RutaModel ruta = new RutaModel
                {
                    Id = int.Parse(txt_Id_Ruta.Text),
                    Nombre = txt_Nombre_de_Ruta.Text,
                    Fecha = DateTime.Parse(txtFecha_Ruta.Text),
                    HoraInicio = TimeSpan.Parse(txt_hora_inicio_ruta.Text),
                    HoraFinal = TimeSpan.Parse(txt_hora_final_ruta.Text),
                    IdConductor = int.Parse(txt_id_conductor.Text)
                };

                bool actualizado = RutasCRUD.ActualizarRuta(ruta);
                if (actualizado)
                {
                    MessageBox.Show("Ruta actualizada correctamente.");
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Error al actualizar. Asegúrate de que el ID exista.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void LimpiarCampos()
        {
            txt_Id_Ruta.Clear();
            txt_Nombre_de_Ruta.Clear();
            txtFecha_Ruta.Clear();
            txt_hora_inicio_ruta.Clear();
            txt_hora_final_ruta.Clear();
            txt_id_conductor.Clear();
        }
    }
}
