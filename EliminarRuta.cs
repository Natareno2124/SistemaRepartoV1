using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//creado por Rocio Lopez 9959-23-740
namespace SistemaRepartoG4
{
    public partial class EliminarRuta : Form
    {
        public EliminarRuta()
        {
            InitializeComponent();
        }

        private void btn_eliminar_p_Click(object sender, EventArgs e)
        {


            try
            {
                if (string.IsNullOrWhiteSpace(txt_Id_Ruta.Text))
                {
                    MessageBox.Show("Por favor ingresa el ID de la ruta.");
                    return;
                }

                int id = int.Parse(txt_Id_Ruta.Text);

                bool eliminado = RutasCRUD.EliminarRuta(id);
                if (eliminado)
                {
                    txt_Id_Ruta.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }
    }
}
