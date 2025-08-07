using MySqlX.XDevAPI;
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
    using SistemaRepartoG4;
    using SistemaRepartoG4.Clases;
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();

            txtNombre.Text = Session.nombres;
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            Usuarios ventanaUsuarios = new Usuarios();
            ventanaUsuarios.FormClosed += (s, args) => this.Show();
            ventanaUsuarios.Show();
            this.Hide();
        }

        private void btnTransportes_Click(object sender, EventArgs e)
        {
            TransporteForm ventanaTransporte = new TransporteForm();
            ventanaTransporte.FormClosed += (s, args) => this.Show();
            ventanaTransporte.Show();
            this.Hide();
        }

        private void btnRutas_Click(object sender, EventArgs e)
        {
            RutasForm ventanaRutasForm = new RutasForm();
            ventanaRutasForm.FormClosed += (s, args) => this.Show();
            ventanaRutasForm.Show();
            this.Hide();
        }

        private void btnBodega_Click(object sender, EventArgs e)
        {
            SistemaRepartoG4.Bodegas ventanaBodegas = new SistemaRepartoG4.Bodegas();
            ventanaBodegas.FormClosed += (s, args) => this.Show();
            ventanaBodegas.Show();
            this.Hide();
        }

        private void btnPaquetes_Click(object sender, EventArgs e)
        {
            Paquetes ventanaPaquetes = new Paquetes();
            ventanaPaquetes.FormClosed += (s, args) => this.Show();
            ventanaPaquetes.Show();
            this.Hide();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            Reporte2 ventanaReporte = new Reporte2();
            ventanaReporte.FormClosed += (s, args) => this.Show();
            ventanaReporte.Show();
            this.Hide();
        }

        private void btnPilotos_Click(object sender, EventArgs e)
        {
            PilotosForm ventanaPilotos = new PilotosForm();
            ventanaPilotos.FormClosed += (s, args) => this.Show();
            ventanaPilotos.Show();
            this.Hide();
        }

        private void btnSucursales_Click(object sender, EventArgs e)
        {
            Sucursales ventanaSucursales = new Sucursales();
            ventanaSucursales.FormClosed += (s, args) => this.Show();
            ventanaSucursales.Show();
            this.Hide();
        }

        private void btn_cerrar_sesion_Click(object sender, EventArgs e)
        {
            Login ventanaLogin = new Login();
            ventanaLogin.FormClosed += (s, args) => this.Show();
            ventanaLogin.Show();
            this.Hide();
        }
    }
}
