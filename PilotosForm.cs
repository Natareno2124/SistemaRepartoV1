using System;
using System.Drawing;
using System.Windows.Forms;
using System.Reflection;
using System.Runtime.InteropServices;
using WinFormsApp1;

namespace SistemaRepartoG4
{
    partial class PilotosForm : Form
    {
        public PilotosForm()
        {
            InitializeComponent();
            ConfigurarEstilos();
            CargarDatosEjemplo();
        }




        private void ConfigurarEstilos()
        {
            // Estilo general del formulario
            this.BackColor = Color.White;
            this.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);

            // Estilo de los botones redondos
            foreach (Button btn in new[] { btnAgregar, btnEditar, btnGuardar, btnEliminar, btnRetroceder })
            {
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.BackColor = Color.FromArgb(44, 62, 80);
                btn.ForeColor = Color.White;
                btn.Size = new Size(40, 40);
                btn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn.Width, btn.Height, 20, 20));
            }

            // Estilo del DataGridView
            dgvPilotos.BorderStyle = BorderStyle.None;
            dgvPilotos.EnableHeadersVisualStyles = false;
            dgvPilotos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(44, 62, 80);
            dgvPilotos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvPilotos.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            dgvPilotos.RowHeadersVisible = false;
            dgvPilotos.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, int nTopRect, int nRightRect, int nBottomRect,
            int nWidthEllipse, int nHeightEllipse);

        private void CargarDatosEjemplo()
        {
            // Datos de ejemplo
            dgvPilotos.Rows.Add(2, "María López", "1990-05-10", "R2", "Sucursal B", 8, "555-5678");
            dgvPilotos.Rows.Add(1, "Juan Perez", "1980-01-01", "R1", "Sucursal A", 12, "555-1234");

        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidad de Agregar piloto");
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvPilotos.SelectedRows.Count > 0)
                MessageBox.Show("Editar piloto seleccionado");
            else
                MessageBox.Show("Seleccione un piloto para editar", "Advertencia",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cambios guardados");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvPilotos.SelectedRows.Count > 0)
                MessageBox.Show("Piloto eliminado");
            else
                MessageBox.Show("Seleccione un piloto para eliminar", "Advertencia",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }


        private void btnRetroceder_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            menu.Show();
            this.Close();
        }



    }
}