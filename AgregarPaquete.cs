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

    using System.Drawing;
    using SistemaRepartoG4.Clases;
    public partial class AgregarPaquete : Form
    {
        public AgregarPaquete()
        {
            InitializeComponent();
        }

        private void AgregarPaquete_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void id_guia_madre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_agregar_p_Click(object sender, EventArgs e)
        {
            try
            {
                Paquete paquete = new Paquete
                {

                    // aqui puse todas las variables con las que se llenan el fomulario
                    IdGuiaMadre = int.Parse(id_guia_madre.Text),
                    PesoKg = float.Parse(peso_kg_paquete.Text),
                    LargoCm = float.Parse(largo_cm_paquete.Text),
                    AnchoCm = float.Parse(ancho_cm_paquete.Text),
                    AltoCm = float.Parse(alto_cm_paquete.Text),
                    Descripcion = descripcion_paquete.Text,
                    Precio = float.Parse(precio_paquete.Text),
                    Fragil = fragil_paquete.Text, 
                    TiempoEntrega = int.Parse(tiempo_entrega_paquete.Text),
                    IdBodega = int.Parse(id_bodega.Text),
                    IdSucursal = int.Parse(id_sucursal.Text),
                };

                // con esto se afirma que se agrego el paquete
                bool agregado = PaquetesCRUD.AgregarPaquete(paquete);
                if (agregado)
                {
                    MessageBox.Show("Paquete agregado correctamente.");
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void LimpiarCampos()
        {
            // aqui se van a limpiar los campos cuando ya se ingresen los datos
           id_guia_madre.Clear();
            peso_kg_paquete.Clear();
            largo_cm_paquete.Clear();
            ancho_cm_paquete.Clear();
           alto_cm_paquete.Clear();
            descripcion_paquete.Clear();
           precio_paquete.Clear();
            tiempo_entrega_paquete.Clear();
            fragil_paquete.Clear();
            id_bodega.Clear();
            id_sucursal.Clear();
        }

        private void ancho_cm_paquete_TextChanged(object sender, EventArgs e)
        {

        }

        private void descripcion_paquete_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
