//MAPA FORMS LOFICA
using System;
using System.Windows.Forms;

namespace SistemaRepartoG4
{
    public partial class FormMap : Form
    {
        public FormMap()
        {
            InitializeComponent();
            InicializarWebView();
        }

        private async void InicializarWebView()
        {
            try
            {
                await webView.EnsureCoreWebView2Async();
                webView.Source = new Uri("https://www.google.com/maps");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inicializando WebView2: " + ex.Message);
            }
        }

        private void btnTrazar_Click(object sender, EventArgs e)
        {
            string origen = txtOrigen.Text.Trim();
            string destino = txtDestino.Text.Trim();

            if (origen == "Origen (dirección)" || string.IsNullOrEmpty(origen) ||
                destino == "Destino (dirección)" || string.IsNullOrEmpty(destino))
            {
                MessageBox.Show("Escribe direcciones válidas para origen y destino.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string url = "https://www.google.com/maps/dir/?api=1" +
                         "&origin=" + Uri.EscapeDataString(origen) +
                         "&destination=" + Uri.EscapeDataString(destino) +
                         "&travelmode=driving";
            webView.Source = new Uri(url);
        }
    }
}

