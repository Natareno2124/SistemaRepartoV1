using System;
using System.Windows.Forms;

namespace SistemaRepartoG4
{
    public partial class BodegaDetalleForm : Form
    {
        public int CodigoBodega 
        { get; set; 
        }

        public int IdEncargado
        {
            get => (int)nudEncargadoID.Value;
            set => nudEncargadoID.Value = value;
        }
        public int IdSucursal
        {
            get => (int)nudSucursalID.Value;
            set => nudSucursalID.Value = value;
        }
        public int Capacidad
        {
            get => (int)nudCapacidad.Value;
            set => nudCapacidad.Value = value;
        }

        public BodegaDetalleForm()
        {
            InitializeComponent();
            IniciarEventos();
        }

        private void IniciarEventos()
        {
            btnOK.Click += BtnOK_Click;
            btnCancel.Click += BtnCancel_Click;
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            if (nudCodigo.Value <= 0)
            {
                MessageBox.Show("El código de bodega debe ser mayor que cero.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (nudCapacidad.Value <= 0)
            {
                MessageBox.Show("La capacidad debe ser mayor que cero.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
