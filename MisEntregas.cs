using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaRepartoG4
{
    public partial class MisEntregas : Form
    {
        public MisEntregas()
        {
            InitializeComponent();
        }

        private void btnReportar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Problema Reportado", "Reportar un problema", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MisEntregas_Load(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            MenuPiloto ventanaMenuPiloto = new MenuPiloto();
            ventanaMenuPiloto.FormClosed += (s, args) => this.Show();
            ventanaMenuPiloto.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cmReportar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
