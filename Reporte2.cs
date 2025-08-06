// Reporte2.cs
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SistemaRepartoG4.Clases;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

namespace SistemaRepartoG4
{
    public partial class Reporte2 : Form
    {
        public Reporte2()
        {
            InitializeComponent();
            CargarConductores();
            ConfigurarTablaReportes();
            AplicarEstiloBotones();
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,     
            int nTopRect,     
            int nRightRect,   
            int nBottomRect,   
            int nWidthEllipse,
            int nHeightEllipse 
        );

        private void AplicarEstiloBotones()
        {
            foreach (Button btn in new[] { btnRetroceder }) 
            {
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.BackColor = Color.FromArgb(44, 62, 80);
                btn.ForeColor = Color.White;
                btn.Size = new Size(40, 40);
                btn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn.Width, btn.Height, 20, 20));
            }
        }

        private void CargarConductores()
        {
            try
            {
                using (var conexion = ConectarDB.establecerConexion())
                {
                    conexion.Open();
                    string query = "SELECT id_conductor, CONCAT(nombre_conductor, ' ', apellido_conductor) AS NombreCompleto FROM tbl_conductores";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conexion);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    DataRow row = dt.NewRow();
                    row["id_conductor"] = 0;
                    row["NombreCompleto"] = "Todos";
                    dt.Rows.InsertAt(row, 0);

                    comboConductores.DataSource = dt;
                    comboConductores.DisplayMember = "NombreCompleto";
                    comboConductores.ValueMember = "id_conductor";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar conductores: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (comboConductores.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un conductor.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idConductor = Convert.ToInt32(comboConductores.SelectedValue);
            DateTime fechaInicio = dtInicio.Value.Date;
            DateTime fechaFin = dtFin.Value.Date;

            if (fechaInicio > fechaFin)
            {
                MessageBox.Show("La fecha de inicio no puede ser mayor a la fecha final.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection conn = ConectarDB.establecerConexion())
                {
                    conn.Open();
                    string query = @"
                        SELECT 
                            c.nombre_conductor AS NombreConductor,
                            c.apellido_conductor AS ApellidoConductor,
                            c.tipo_licencia_conductor AS TipoLicencia,
                            s.codigo_sucursal AS Sucursal,
                            r.nombre_ruta AS NombreRuta,
                            r.fecha_ruta AS FechaRuta,
                            r.hora_inicio_ruta AS HoraInicio,
                            r.hora_final_ruta AS HoraFin,
                            p.estado_pedido AS EstadoPedido,
                            cl.nombre_cliente AS NombreCliente,
                            cl.apellido_cliente AS ApellidoCliente,
                            pk.peso_kg_paquete AS PesoKg,
                            pk.fragil_paquete AS Fragil,
                            pk.precio_paquete AS PrecioPaquete
                        FROM tbl_rutas r
                        INNER JOIN tbl_conductores c ON r.id_conductor = c.id_conductor
                        INNER JOIN tbl_ruta_detalle rd ON r.id_ruta = rd.id_ruta
                        INNER JOIN tbl_pedido p ON rd.id_pedido = p.id_pedido
                        INNER JOIN tbl_clientes cl ON p.id_cliente = cl.id_cliente
                        INNER JOIN tbl_paquete pk ON p.id_guia_madre = pk.id_guia_madre
                        INNER JOIN tbl_sucursal s ON c.id_sucursal = s.id_sucursal
                        WHERE r.fecha_ruta BETWEEN @fechaInicio AND @fechaFin
                        AND (@idConductor = 0 OR r.id_conductor = @idConductor)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@idConductor", idConductor);
                        cmd.Parameters.AddWithValue("@fechaInicio", fechaInicio);
                        cmd.Parameters.AddWithValue("@fechaFin", fechaFin);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dgvReportes.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el reporte: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } 


private void btnRetroceder_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            if (dgvReportes.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Excel.Application excelApp = null;
            Excel.Workbook workbook = null;
            Excel._Worksheet worksheet = null;

            try
            {
                excelApp = new Excel.Application();
                workbook = excelApp.Workbooks.Add(Type.Missing);
                worksheet = workbook.ActiveSheet;
                worksheet.Name = "Reporte";

                // Encabezados
                for (int i = 0; i < dgvReportes.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1] = dgvReportes.Columns[i].HeaderText;
                }

                // Datos
                for (int i = 0; i < dgvReportes.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvReportes.Columns.Count; j++)
                    {
                        var cellValue = dgvReportes.Rows[i].Cells[j].Value;
                        worksheet.Cells[i + 2, j + 1] = cellValue != null ? cellValue.ToString() : "";
                    }
                }
                worksheet.Columns.AutoFit();

                // Guardar archivo
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Excel Files|*.xlsx";
                    saveFileDialog.Title = "Guardar Reporte en Excel";
                    saveFileDialog.FileName = $"Reporte_{DateTime.Now:yyyyMMdd_HHmm}.xlsx";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        workbook.SaveAs(saveFileDialog.FileName);
                        MessageBox.Show("Reporte exportado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al exportar a Excel: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Liberar recursos COM
                if (workbook != null)
                {
                    workbook.Close(false);
                    Marshal.ReleaseComObject(workbook);
                    workbook = null;
                }
                if (worksheet != null)
                {
                    Marshal.ReleaseComObject(worksheet);
                    worksheet = null;
                }
                if (excelApp != null)
                {
                    excelApp.Quit();
                    Marshal.ReleaseComObject(excelApp);
                    excelApp = null;
                }
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }
    }
}
