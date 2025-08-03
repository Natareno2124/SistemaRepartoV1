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
    public partial class RutasPiloto : Form
    {
        public RutasPiloto()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            MenuPiloto ventanaMenuPiloto = new MenuPiloto();
            ventanaMenuPiloto.FormClosed += (s, args) => this.Show();
            ventanaMenuPiloto.Show();
            this.Hide();
        }
    }
}
