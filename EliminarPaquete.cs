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
    public partial class EliminarPaquete : Form
    {
        public EliminarPaquete()
        {
            InitializeComponent();
        }

        private void EliminarPaquete_Load(object sender, EventArgs e)
        {

        }

        private void btn_eliminar_p_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(id_guia_madre.Text))
                {
                    MessageBox.Show("Por favor ingresa el ID de guía madre.");
                    return;
                }

                int id = int.Parse(id_guia_madre.Text);

                bool eliminado = PaquetesCRUD.EliminarPaquete(id);
                if (eliminado)
                {
                    id_guia_madre.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
