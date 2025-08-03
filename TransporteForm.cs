//TransporteForm

using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using WinFormsApp1;

namespace SistemaRepartoG4
{
    public partial class TransporteForm : Form
    {
        private TransporteCRUD crud = new TransporteCRUD();

        public TransporteForm()
        {
            InitializeComponent();
            ConfigurarEstilos();
        }

        private void ConfigurarEstilos()
        {
            // Estilo general
            this.BackColor = Color.White;
            this.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);

            // Botones redondos
            foreach (Button btn in new[] { btnAgregar, btnEditar, btnGuardar, btnEliminar, btnRetroceder })
            {
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.BackColor = Color.FromArgb(44, 62, 80);
                btn.ForeColor = Color.White;
                btn.Size = new Size(40, 40);
                btn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn.Width, btn.Height, 20, 20));
            }

            // DataGridView
            dgvTransporte.BorderStyle = BorderStyle.None;
            dgvTransporte.EnableHeadersVisualStyles = false;
            dgvTransporte.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(44, 62, 80);
            dgvTransporte.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvTransporte.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvTransporte.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvTransporte.RowHeadersVisible = false;
            dgvTransporte.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, int nTopRect, int nRightRect, int nBottomRect,
            int nWidthEllipse, int nHeightEllipse);

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using (var form = new TransporteDetalleForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        crud.InsertarTransporte(
                            form.Placa,
                            form.Marca,
                            form.Modelo,
                            form.Color,
                            form.Capacidad,
                            form.IdSucursal,  // Este es el ID real
                            form.IdTipo,      // Este es el ID real
                            form.IdEstado     // Este es el ID real
                        );

                        dgvTransporte.DataSource = crud.ObtenerTransportes();

                        MessageBox.Show("Vehículo agregado correctamente");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al agregar: {ex.Message}");
                    }
                }
            }
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvTransporte.SelectedRows.Count == 0) return;

            var row = dgvTransporte.SelectedRows[0];
            int placaOriginal = Convert.ToInt32(row.Cells["Placa"].Value);

            using (var detalle = new TransporteDetalleForm())
            {
                // Inicializar campos para edición
                detalle.Placa = placaOriginal;
                detalle.Marca = row.Cells["Marca"].Value.ToString();
                detalle.Modelo = row.Cells["Modelo"].Value.ToString();
                detalle.Color = row.Cells["Color"].Value.ToString();
                detalle.Capacidad = row.Cells["Capacidad"].Value.ToString();
                detalle.IdSucursal = Convert.ToInt32(row.Cells["SucursalID"].Value);
                detalle.IdTipo = Convert.ToInt32(row.Cells["TipoID"].Value);
                detalle.IdEstado = Convert.ToInt32(row.Cells["EstadoID"].Value);

                if (detalle.ShowDialog() == DialogResult.OK)
                {
                    crud.ModificarTransporte(
                        detalle.Placa,
                        detalle.Marca,
                        detalle.Modelo,
                        detalle.Color,
                        detalle.Capacidad,
                        detalle.IdSucursal,
                        detalle.IdTipo,
                        detalle.IdEstado);

                    dgvTransporte.DataSource = crud.ObtenerTransportes();
                }
            }
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cambios guardados");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvTransporte.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un vehículo para eliminar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int placa = Convert.ToInt32(dgvTransporte.SelectedRows[0].Cells["Placa"].Value);
            if (MessageBox.Show("¿Confirma eliminación?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                crud.EliminarTransporte(placa);
                dgvTransporte.DataSource = crud.ObtenerTransportes();
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
