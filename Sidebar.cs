using SistemaRepartoG4;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Sidebar : UserControl
    {
        public Sidebar()
        {
            InitializeComponent();
            CrearMenuLateral();
        }
        private void CrearMenuLateral()
        {
            this.BackColor = ColorTranslator.FromHtml("#183446"); //fondo color
            this.Dock = DockStyle.Left;
            this.Width = 200;

            // TÍTULO DEL SIDEBAR
            Label titulo = new Label();
            titulo.Text = "SISTEMA\nREPARTO";
            titulo.ForeColor = Color.White;
            titulo.BackColor = ColorTranslator.FromHtml("#183446"); //fondo color
            titulo.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            titulo.Dock = DockStyle.Top;  // Ocupa todo el ancho automáticamente
            titulo.Height = 80;
            titulo.TextAlign = ContentAlignment.MiddleLeft;
            titulo.Padding = new Padding(10, 0, 0, 50); //izquierda, superior, derecha iferior

            // Forzar texto blanco
            titulo.Paint += (s, e) =>
            {
                e.Graphics.Clear(ColorTranslator.FromHtml("#183446"));
                TextRenderer.DrawText(
                    e.Graphics,
                    titulo.Text,
                    titulo.Font,
                    new Point(10, 15),
                    Color.White);
            };

            this.Controls.Add(titulo);

            // Contenedor para los botones
            FlowLayoutPanel contenedorBotones = new FlowLayoutPanel();
            contenedorBotones.Dock = DockStyle.Fill;
            contenedorBotones.FlowDirection = FlowDirection.TopDown;
            contenedorBotones.WrapContents = false;
            contenedorBotones.AutoScroll = true;
            contenedorBotones.Padding = new Padding(0, titulo.Height + 20, 0, 0); //izquierda, superior, derecha iferior
            contenedorBotones.BackColor = ColorTranslator.FromHtml("#183446");
            this.Controls.Add(contenedorBotones);

            // Botones del menú
            string[] nombresBotones =
            {
                "usuarios", "rutas", "paquetes", "bodegas", "reportes", "transportes", "repartidores",
                "pilotos", "sucursales"
            };

            string[] rutasIconos =
             {
                "usuario.png", "ruta.png", "paquete.png", "bodega.png", "reporte.png", "transporte.png", "repartidor.png",
                "piloto.png", "sucursal.png"
            };

            for (int i = 0; i < nombresBotones.Length; i++)
            {
                Button btn = new Button();
                btn.Text = nombresBotones[i];
                btn.Width = 200;
                btn.Height = 40;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.BackColor = ColorTranslator.FromHtml("#183446");
                btn.ForeColor = Color.White;
                btn.TextAlign = ContentAlignment.MiddleLeft;
                btn.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                btn.Margin = new Padding(0, 10, 0, 10);


                string nombreBoton = nombresBotones[i];
                btn.Click += (s, e) => AbrirVentana(nombreBoton);

                contenedorBotones.Controls.Add(btn);

                contenedorBotones.Controls.Add(btn);
            }
        }

        private void AbrirVentana(string nombre)
        {
            Form ventana = null;
            switch (nombre)
            {
                case "usuarios":
                    // ventana = new UsuariosForm();
                    break;
                case "rutas":
                    // ventana = new RutasForm();
                    break;
                case "paquetes":
                    // ventana = new PaquetesForm();
                    break;
                case "bodegas":
                    // ventana = new BodegasForm();
                    break;
                case "reportes":
                    // ventana = new ReportesForm();
                    break;
                case "transportes":
                    // ventana = new TransportesForm();
                    break;
                case "repartidores":
                    // ventana = new RepartidoresForm();
                    break;
                case "pilotos":
                    ventana = new PilotosForm();
                    break;
                case "sucursales":
                    // ventana = new SucursalesForm();
                    break;
                default:
                    MessageBox.Show("ERROR, CONTACTE A SERVICIO TECNICO");
                    break;
            }

            if (ventana != null)
            {
                ventana.Show();
            }
        }

    }
}