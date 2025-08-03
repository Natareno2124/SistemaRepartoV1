//PilotosForm.cs

using System;
using System.Drawing;
using System.Windows.Forms;
using System.Reflection;
using System.Runtime.InteropServices;
using WinFormsApp1;
using MySql.Data.MySqlClient;

namespace SistemaRepartoG4
{
    partial class PilotosForm : Form
    {
        private PilotosCRUD crud = new PilotosCRUD();

        public PilotosForm()
        {
            InitializeComponent();
            ConfigurarEstilos();

        }

        private void ConfigurarEstilos()
        {
            // Estilo general 
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
            dgvPilotos.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                using (var detalle = new PilotoDetalleForm())
                {
                    if (detalle.ShowDialog() == DialogResult.OK)
                    {
                        if (string.IsNullOrWhiteSpace(detalle.Nombres) || string.IsNullOrWhiteSpace(detalle.Apellidos))
                        {
                            MessageBox.Show("Nombre y apellido son campos obligatorios", "Error",
                                          MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        if (detalle.IdSucursal <= 0)
                        {
                            MessageBox.Show("Debe seleccionar una sucursal válida", "Error",
                                          MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        // Insertar el nuevo piloto
                        crud.InsertarPiloto(
                            detalle.Nombres.Trim(),
                            detalle.Apellidos.Trim(),
                            detalle.FechaNacimiento,
                            detalle.Sexo,
                            detalle.TipoLicencia,
                            detalle.IdSucursal
                        );

                        var datosActualizados = crud.ObtenerPilotos();
                        dgvPilotos.DataSource = datosActualizados;

                        MessageBox.Show("Piloto agregado correctamente", "Éxito",
                                      MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (dgvPilotos.Rows.Count > 0)
                        {
                            dgvPilotos.ClearSelection();
                            dgvPilotos.Rows[dgvPilotos.Rows.Count - 1].Selected = true;
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error de base de datos: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvPilotos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un piloto para editar", "Advertencia",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var requiredColumns = new[] { "colID", "colNombre", "colApellidos", "colFechaNacimiento",
                                 "colSexo", "colTipoLicencia", "colSucursalID" };

            foreach (var col in requiredColumns)
            {
                if (!dgvPilotos.Columns.Contains(col))
                {
                    MessageBox.Show($"Falta la columna requerida: {col}", "Error de configuración",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            var row = dgvPilotos.SelectedRows[0];

            using (var detalle = new PilotoDetalleForm())
            {
                try
                {
                    detalle.Nombres = GetCellValue(row, "colID");
                    detalle.Apellidos = GetCellValue(row, "colApellidos");

                    if (DateTime.TryParse(GetCellValue(row, "colFechaNacimiento"), out var fecha))
                        detalle.FechaNacimiento = fecha;

                    detalle.Sexo = GetCellValue(row, "colSexo");
                    detalle.TipoLicencia = GetCellValue(row, "colTipoLicencia");

                    if (int.TryParse(GetCellValue(row, "colSucursalID"), out var sucursalId))
                        detalle.IdSucursal = sucursalId;

                    if (detalle.ShowDialog() == DialogResult.OK)
                    {
                        if (int.TryParse(GetCellValue(row, "colID"), out var pilotoId))
                        {
                            crud.ModificarPiloto(
                                pilotoId,
                                detalle.Nombres,
                                detalle.Apellidos,
                                detalle.FechaNacimiento,
                                detalle.Sexo,
                                detalle.TipoLicencia,
                                detalle.IdSucursal);

                            int firstVisibleRow = dgvPilotos.FirstDisplayedScrollingRowIndex;
                            dgvPilotos.DataSource = crud.ObtenerPilotos();
                            if (firstVisibleRow >= 0 && firstVisibleRow < dgvPilotos.Rows.Count)
                                dgvPilotos.FirstDisplayedScrollingRowIndex = firstVisibleRow;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al editar piloto: {ex.Message}", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private string GetCellValue(DataGridViewRow row, string columnName)
        {
            return row.Cells[columnName].Value?.ToString() ?? "";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cambios guardados");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvPilotos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un piloto para eliminar", "Advertencia",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int id = Convert.ToInt32(dgvPilotos.SelectedRows[0].Cells["ID"].Value);
            if (MessageBox.Show("¿Confirma eliminación?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                crud.EliminarPiloto(id);
                dgvPilotos.DataSource = crud.ObtenerPilotos();
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