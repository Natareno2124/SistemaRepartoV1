//diseño
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Web.WebView2.WinForms;

namespace SistemaRepartoG4
{
    partial class FormMap
    {
        private System.ComponentModel.IContainer components = null;
        private WebView2 webView;
        private Panel headerPanel;
        private TextBox txtOrigen;
        private TextBox txtDestino;
        private Button btnTrazar;
        private ComboBox userComboBox;
        private Label userIconLabel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            // Formulario
            this.Size = new Size(1280, 770); // Tamaño inicial
            this.MaximumSize = new Size(1280, 770);
            this.MinimumSize = new Size(1280, 770);
            this.StartPosition = FormStartPosition.CenterScreen; // Centrar en pantalla
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Text = "Rutas";
            this.Font = new Font("Segoe UI", 10F);

            // header
            headerPanel = new Panel
            {
                Dock = DockStyle.Top,
                Height = 50,
                BackColor = Color.FromArgb(141, 153, 174)
            };
            this.Controls.Add(headerPanel);

            int padding = 10;
            int controlHeight = 25;

            // TextBox Origen
            txtOrigen = new TextBox
            {
                Location = new Point(padding, (headerPanel.Height - controlHeight) / 2),
                Size = new Size(200, controlHeight),
                Text = "Origen (dirección)",
                ForeColor = Color.Gray
            };
            txtOrigen.GotFocus += (s, e) =>
            {
                if (txtOrigen.Text == "Origen (dirección)")
                {
                    txtOrigen.Text = "";
                    txtOrigen.ForeColor = Color.Black;
                }
            };
            txtOrigen.LostFocus += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(txtOrigen.Text))
                {
                    txtOrigen.Text = "Origen (dirección)";
                    txtOrigen.ForeColor = Color.Gray;
                }
            };
            headerPanel.Controls.Add(txtOrigen);

            // TextBox Destino
            txtDestino = new TextBox
            {
                Location = new Point(txtOrigen.Right + padding, (headerPanel.Height - controlHeight) / 2),
                Size = new Size(200, controlHeight),
                Text = "Destino (dirección)",
                ForeColor = Color.Gray
            };
            txtDestino.GotFocus += (s, e) =>
            {
                if (txtDestino.Text == "Destino (dirección)")
                {
                    txtDestino.Text = "";
                    txtDestino.ForeColor = Color.Black;
                }
            };
            txtDestino.LostFocus += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(txtDestino.Text))
                {
                    txtDestino.Text = "Destino (dirección)";
                    txtDestino.ForeColor = Color.Gray;
                }
            };
            headerPanel.Controls.Add(txtDestino);

            // Botón Trazar
            btnTrazar = new Button
            {
                Location = new Point(txtDestino.Right + padding, (headerPanel.Height - controlHeight) / 2),
                Size = new Size(120, controlHeight),
                Text = "Trazar Ruta",
                BackColor = Color.FromArgb(66, 133, 244),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };
            btnTrazar.FlatAppearance.BorderSize = 0;
            btnTrazar.Click += new System.EventHandler(this.btnTrazar_Click);
            headerPanel.Controls.Add(btnTrazar);

            // Icono usuario
            userIconLabel = new Label
            {
                Text = "👤",
                Font = new Font("Segoe UI", 14F),
                Size = new Size(32, 32),
                TextAlign = ContentAlignment.MiddleCenter,
                BackColor = Color.Transparent
            };
            headerPanel.Controls.Add(userIconLabel);

            // ComboBox usuarios
            userComboBox = new ComboBox
            {
                Name = "userComboBox",
                DropDownStyle = ComboBoxStyle.DropDownList,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 9F),
                BackColor = Color.White,
                ForeColor = Color.Black,
                Width = 140,
                Height = controlHeight
            };
            userComboBox.Items.AddRange(new string[]
            {
                "User Administrador",
                "Cambiar usuario",
                "Cerrar sesión"
            });
            userComboBox.SelectedIndex = 0;
            userComboBox.SelectedIndexChanged += (s, e) =>
            {
                switch (userComboBox.SelectedItem.ToString())
                {
                    case "Cerrar sesión":
                        MessageBox.Show("Cerrando sesión...");
                        break;
                    case "Cambiar usuario":
                        MessageBox.Show("Redirigiendo a selección de usuario...");
                        break;
                }
                userComboBox.SelectedIndex = 0;
            };
            headerPanel.Controls.Add(userComboBox);

            // Posicionar icono y combo a la derecha
            void PosicionarUsuario()
            {
                int margenDerecho = 10;
                userComboBox.Location = new Point(headerPanel.Width - userComboBox.Width - margenDerecho, (headerPanel.Height - controlHeight) / 2);
                userIconLabel.Location = new Point(userComboBox.Left - userIconLabel.Width - 5, (headerPanel.Height - userIconLabel.Height) / 2);
            }
            PosicionarUsuario();
            headerPanel.Resize += (s, e) => PosicionarUsuario();

            // mapa
            webView = new WebView2
            {
                Location = new Point(0, headerPanel.Bottom),
                Size = new Size(this.ClientSize.Width, this.ClientSize.Height - headerPanel.Height),
                Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right
            };
            this.Controls.Add(webView);

            // Ajustar tamaño webView al redimensionar formulario
            this.Resize += (s, e) =>
            {
                webView.Size = new Size(this.ClientSize.Width, this.ClientSize.Height - headerPanel.Height);
            };
        }
    }
}