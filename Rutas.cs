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
//creado por Rocio Lopez 9959-23-740
namespace SistemaRepartoG4
{
    public partial class Rutas : Form
    {
        public Rutas()
        {
            InitializeComponent();
        }

        private void bntAgregar_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void bnt_Agregar_Click(object sender, EventArgs e)
        {
            RegistroRutas ventanaAgregarRuta = new RegistroRutas();
            ventanaAgregarRuta.FormClosed += (s, args) => this.Show();
            ventanaAgregarRuta.ShowDialog();
            this.Hide(); // Oculta la ventana actual (opcional)
                         // CargarUsuarios();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bnt_Editar_Click(object sender, EventArgs e)
        {
            EditarRuta ventanaEditar = new EditarRuta();
            ventanaEditar.FormClosed += (s, args) => this.Show();
            ventanaEditar.ShowDialog(); 
            this.Hide(); // Oculta la ventana actual (opcional)
                         // CargarUsuarios();

        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            EliminarRuta ventanaEliminarRuta = new EliminarRuta();
            ventanaEliminarRuta.FormClosed += (s, args) => this.Show();
            ventanaEliminarRuta.ShowDialog();
            this.Hide();
        }
    }
}
