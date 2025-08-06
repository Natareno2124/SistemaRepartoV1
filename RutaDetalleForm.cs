using System;
using System.Windows.Forms;

namespace SistemaRepartoG4
{
    public partial class RutaDetalleForm : Form
    {
        public RutaDetalleForm()
        {
            InitializeComponent();
        }

        public int IdRuta
        {
            get => int.TryParse(txtIdRuta.Text.Trim(), out var val) ? val : 0;
            set => txtIdRuta.Text = value.ToString();
        }

        public string NombreRuta
        {
            get => txtNombreRuta.Text.Trim();
            set => txtNombreRuta.Text = value;
        }

        public DateTime FechaRuta
        {
            get => dtpFechaRuta.Value;
            set => dtpFechaRuta.Value = value;
        }

        public TimeSpan HoraInicio
        {
            get => dtpHoraInicio.Value.TimeOfDay;
            set => dtpHoraInicio.Value = DateTime.Today.Add(value);
        }

        public TimeSpan HoraFinal
        {
            get => dtpHoraFinal.Value.TimeOfDay;
            set => dtpHoraFinal.Value = DateTime.Today.Add(value);
        }

        public int IdConductor
        {
            get => int.TryParse(txtIdConductor.Text.Trim(), out var val) ? val : 0;
            set => txtIdConductor.Text = value.ToString();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NombreRuta))
            {
                MessageBox.Show("Ingrese el nombre de la ruta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (IdConductor <= 0)
            {
                MessageBox.Show("Ingrese un ID de conductor válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
