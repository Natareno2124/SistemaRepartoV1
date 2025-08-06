using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using WinFormsApp1;

namespace SistemaRepartoG4
{
    public partial class RutasForm : Form
    {
        private RutaCRUD crud = new RutaCRUD();

        public RutasForm()
        {
            InitializeComponent();
            ConfigurarEstilos();
            CargarDatos();
            AsignarEventos();
            this.btnMapa.Click += btnMapa_Click;

        }

        private void ConfigurarEstilos()
        {
            this.BackColor = Color.White;
            this.Font = new Font("Segoe UI", 9.75F);

            foreach (Button btn in new[] { btnAgregar, btnEditar, btnGuardar, btnEliminar, btnRetroceder, btnMapa })
            {
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.BackColor = Color.FromArgb(44, 62, 80);
                btn.ForeColor = Color.White;
                btn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn.Width, btn.Height, 20, 20));
            }

            dgvRutas.BorderStyle = BorderStyle.None;
            dgvRutas.EnableHeadersVisualStyles = false;
            dgvRutas.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(44, 62, 80);
            dgvRutas.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvRutas.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvRutas.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvRutas.RowHeadersVisible = false;
            dgvRutas.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, int nTopRect, int nRightRect, int nBottomRect,
            int nWidthEllipse, int nHeightEllipse);

        private void CargarDatos()
        {
            dgvRutas.DataSource = crud.ObtenerRutas();
        }

        private void AsignarEventos()
        {
            btnAgregar.Click += BtnAgregar_Click;
            btnEditar.Click += BtnEditar_Click;
            btnGuardar.Click += BtnGuardar_Click;
            btnEliminar.Click += BtnEliminar_Click;
            btnRetroceder.Click += BtnRetroceder_Click;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            using (var form = new RutaDetalleForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        crud.InsertarRuta(form.IdRuta, form.NombreRuta, form.FechaRuta, form.HoraInicio, form.HoraFinal, form.IdConductor);
                        CargarDatos();
                        MessageBox.Show("Ruta agregada correctamente");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al agregar ruta: {ex.Message}");
                    }
                }
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (dgvRutas.SelectedRows.Count == 0) return;

            var row = dgvRutas.SelectedRows[0];

            using (var form = new RutaDetalleForm())
            {
                form.IdRuta = Convert.ToInt32(row.Cells["id_ruta"].Value);
                form.NombreRuta = row.Cells["nombre_ruta"].Value.ToString();
                form.FechaRuta = Convert.ToDateTime(row.Cells["fecha_ruta"].Value);
                form.HoraInicio = TimeSpan.Parse(row.Cells["hora_inicio_ruta"].Value.ToString());
                form.HoraFinal = TimeSpan.Parse(row.Cells["hora_final_ruta"].Value.ToString());
                form.IdConductor = Convert.ToInt32(row.Cells["id_conductor"].Value);

                if (form.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        crud.ModificarRuta(form.IdRuta, form.NombreRuta, form.FechaRuta, form.HoraInicio, form.HoraFinal, form.IdConductor);
                        CargarDatos();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al modificar ruta: {ex.Message}");
                    }
                }
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidad Guardar no implementada.");
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvRutas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una ruta para eliminar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idRuta = Convert.ToInt32(dgvRutas.SelectedRows[0].Cells["id_ruta"].Value);
            if (MessageBox.Show("¿Confirma eliminación de la ruta?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    crud.EliminarRuta(idRuta);
                    CargarDatos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar ruta: {ex.Message}");
                }
            }
        }
        private void btnMapa_Click(object sender, EventArgs e)
        {
            FormMap mapa = new FormMap();
            mapa.ShowDialog();
        }

        private void BtnRetroceder_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            menu.Show();
            this.Close();
        }
    }
}
