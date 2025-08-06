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

namespace SistemaRepartoG4
{

    using SistemaRepartoG4.Clases;

    public partial class RegistroRutas : Form
    {

        private int? idRuta = null;
        private bool esEdicion = false;

        public RegistroRutas()
        {
            InitializeComponent();
            EstablecerEstilos();
        }

        public RegistroRutas(RutaModel ruta)
        {
            InitializeComponent();
            EstablecerEstilos();

            esEdicion = true;
            idRuta = ruta.Id;

            txt_Nombre_de_Ruta.Text = ruta.Nombre;
            txtFecha_Ruta.Text = ruta.Fecha;
                //.Value = ruta.Fecha;
            txt_hora_inicio_ruta.Text = ruta.HoraInicio;
            //.Value = DateTime.Today.Add(ruta.HoraInicio);
            txt_hora_inicio_ruta.Text = ruta.HoraInicio;
                //.Value = DateTime.Today.Add(ruta.HoraInicio);
            //pHoraFinal.Value = DateTime.Today.Add(ruta.HoraFinal);
            txt_id_conductor.Text = ruta.IdConductor.ToString();
            //.SelectedValue = ruta.IdConductor;
        }

        private void EstablecerEstilos()
        {
            groupBox1.BackColor = ColorTranslator.FromHtml("#8D99AE");
            btn_registra.BackColor = ColorTranslator.FromHtml("#8D99AE");
            BackColor = ColorTranslator.FromHtml("#2C546D");

            AplicarColorATextBox(this);
            AplicarColorALabel(this);
        }

        private void AplicarColorATextBox(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                if (ctrl is TextBox)
                    ctrl.BackColor = ColorTranslator.FromHtml("#2C546D");

                if (ctrl.HasChildren)
                    AplicarColorATextBox(ctrl);
            }
        }

        private void AplicarColorALabel(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                if (ctrl is Label)
                    ctrl.ForeColor = ColorTranslator.FromHtml("#183446");

                if (ctrl.HasChildren)
                    AplicarColorALabel(ctrl);
            }
        }

 private void RegistroRutas_Load(object sender, EventArgs e)
{
    try
    {
        PilotosCRUD crud = new PilotosCRUD(); // Crear instancia
        DataTable conductores = crud.ObtenerPilotos();

        // Agregar columna combinada para mostrar nombre completo
        conductores.Columns.Add("nombre_completo", typeof(string), "nombre_conductor + ' ' + apellido_conductor");

        cmb_id_conductor.DataSource = conductores;
        cmb_id_conductor.DisplayMember = "nombre_completo";
        cmb_id_conductor.ValueMember = "id_conductor";
    }
    catch (Exception ex)
    {
        MessageBox.Show("Error al cargar conductores: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}


        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Nombre_de_Ruta.Text))
            {
                MessageBox.Show("El nombre de la ruta es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            RutaModel ruta = new RutaModel
            {
                Id = int.Parse(txt_Id_Ruta.Text),
                Nombre = txt_Nombre_de_Ruta.Text,
                Fecha = txtFecha_Ruta.Text,
                HoraInicio = txt_hora_inicio_ruta.Text,
                HoraFinal = txt_hora_final_ruta.Text,
                IdConductor = int.Parse(txt_id_conductor.Text)
            };

            try
            {
                ValidarRuta validar = new ValidarRuta();
                string respuesta;

                if (esEdicion)
                {
                    respuesta = validar.ctrlActualizar(ruta);
                }
                else
                {
                    respuesta = validar.ctrlRegistro(ruta);
                }

                if (!string.IsNullOrEmpty(respuesta))
                {
                    MessageBox.Show(respuesta, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(esEdicion ? "Ruta actualizada correctamente" : "Ruta registrada correctamente",
                                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_guardar(object sender, EventArgs e)
        {

        }

        private void cmb_id_conductor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
