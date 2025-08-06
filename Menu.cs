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
            
        }

        private void btnRutas_Click(object sender, EventArgs e)
        {
            Rutas ventanaRutas = new Rutas();
            ventanaRutas.FormClosed += (s, args) => this.Show();
            ventanaRutas.Show();
            this.Hide();
        }

        private void btnBodega_Click(object sender, EventArgs e)
        {

        }
    }
}
