using SistemaRepartoG4.Clases;
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
            this.Load += Paquetes_Load;
        }

        private void Paquetes_Load(object sender, EventArgs e)
        {
            // esto llamara al CRUD par que se muestren los datos en el dataGridView
            PaquetesCRUD.MostrarPaquetes(dataGridViewPaquetes);
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

        private void dataGridViewPaquetes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guiamadre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscarEntrega_Click(object sender, EventArgs e)
        {
            string guiaBuscar = guiamadre.Text.Trim();

            if (string.IsNullOrEmpty(guiaBuscar))
            {
                MessageBox.Show("Por favor, ingresa un número de guía madre.");
                return;
            }

            bool encontrado = false;

            foreach (DataGridViewRow fila in dataGridViewPaquetes.Rows)
            {
                if (fila.Cells["id_guia_madre"].Value != null &&
                    fila.Cells["id_guia_madre"].Value.ToString() == guiaBuscar)
                {
                    fila.Selected = true;
                    dataGridViewPaquetes.FirstDisplayedScrollingRowIndex = fila.Index; 
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                MessageBox.Show("No se encontró una fila con esa guía madre.");
            }
        }
    }
}
