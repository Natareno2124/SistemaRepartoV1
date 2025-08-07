// BodegasForm.cs
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using WinFormsApp1;

namespace SistemaRepartoG4
{
    public partial class BodegasForm : Form
    {
        private BodegaCRUD crud = new BodegaCRUD();

        public BodegasForm()
        {
            InitializeComponent();
            ConfigurarEstilos();
            CargarDatos();
        }

        private void ConfigurarEstilos()
        {
            this.BackColor = Color.White;
            this.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);

            foreach (Button btn in new[] { btnAgregar, btnEditar, btnGuardar, btnEliminar, btnRetroceder })
            {
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.BackColor = Color.FromArgb(44, 62, 80);
                btn.ForeColor = Color.White;
                btn.Size = new Size(40, 40);
                btn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn.Width, btn.Height, 20, 20));
            }

            dgvBodegas.BorderStyle = BorderStyle.None;
            dgvBodegas.EnableHeadersVisualStyles = false;
            dgvBodegas.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(44, 62, 80);
            dgvBodegas.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvBodegas.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvBodegas.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvBodegas.RowHeadersVisible = false;
            dgvBodegas.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
        }

        private void CargarDatos()
        {
            dgvBodegas.DataSource = crud.ObtenerBodegas();
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, int nTopRect, int nRightRect, int nBottomRect,
            int nWidthEllipse, int nHeightEllipse);

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using (var form = new BodegaDetalleForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    crud.InsertarBodega(
                        form.CodigoBodega,
                        form.IdEncargado,
                        form.IdSucursal,
                        form.Capacidad
                    );
                    CargarDatos();
                    MessageBox.Show("Bodega agregada correctamente");
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
                    CargarDatos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvBodegas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una bodega para eliminar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int id = Convert.ToInt32(dgvBodegas.SelectedRows[0].Cells["ID_Bodega"].Value);
            if (MessageBox.Show("¿Confirma eliminación de la bodega?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                crud.EliminarBodega(id);
                CargarDatos();
            }
        }

        private void btnRetroceder_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            menu.Show();
            this.Close();
        }
    }
}
