using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1;

namespace SistemaRepartoG4
{
    public partial class MenuPiloto : Form
    {
        public MenuPiloto()
        {
            InitializeComponent();
            
        }

        private void labelmenupiloto_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MisEntregas ventanaEntregas = new MisEntregas(); 
            ventanaEntregas.FormClosed += (s, args) => this.Show(); 
            ventanaEntregas.Show(); 
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnRutasPiloto_Click(object sender, EventArgs e)
        {
            FormMap mapa = new FormMap();
            mapa.ShowDialog();
        }
    }
}
