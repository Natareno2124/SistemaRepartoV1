using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaRepartoG4.Clases;
//creado por Rocio Lopez 9959-23-740
namespace SistemaRepartoG4
{

    using System.Drawing;
    using SistemaRepartoG4.Clases;

    public partial class RegistroRutas : Form
    {

        public RegistroRutas()
        {
            InitializeComponent();
        }



     


        private void btn_guardar(object sender, EventArgs e)
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

                bool agregado = RutasCRUD.AgregarRuta(ruta);
                if (agregado)
                {
                    MessageBox.Show("Ruta agregada correctamente.");
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar ruta: " + ex.Message);
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


        private void cmb_id_conductor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_hora_inicio_ruta_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
