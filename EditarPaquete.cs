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
    public partial class EditarPaquete : Form
    {
        public EditarPaquete()
        {
            InitializeComponent();
        }

        private int idGuiaMadreOriginal; // Usado para saber qué registro actualizar

        public EditarPaquete(Paquete paquete)
        {
            InitializeComponent();

            idGuiaMadreOriginal = paquete.IdGuiaMadre;

            // Llenar los campos con la info del paquete
            id_guia_madre.Text = paquete.IdGuiaMadre.ToString();
            peso_kg_paquete.Text = paquete.PesoKg.ToString();
            largo_cm_paquete.Text = paquete.LargoCm.ToString();
           ancho_cm_paquete.Text = paquete.AnchoCm.ToString();
            alto_cm_paquete.Text = paquete.AltoCm.ToString();
            descripcion_paquete.Text = paquete.Descripcion;
           precio_paquete.Text = paquete.Precio.ToString();
            fragil_paquete.Text = paquete.Fragil;
           tiempo_entrega_paquete.Text = paquete.TiempoEntrega.ToString();
            id_bodega.Text = paquete.IdBodega.ToString();
           id_sucursal.Text = paquete.IdSucursal.ToString();
        }



        private void btn_guardar_p_Click(object sender, EventArgs e)
        {
            try
            {
                Paquete paqueteActualizado = new Paquete()
                {
                    IdGuiaMadre = idGuiaMadreOriginal, // NO permitir cambiar el ID original
                    PesoKg = float.Parse(peso_kg_paquete.Text),
                    LargoCm = float.Parse(largo_cm_paquete.Text),
                    AnchoCm = float.Parse(ancho_cm_paquete.Text),
                    AltoCm = float.Parse(alto_cm_paquete.Text),
                    Descripcion = descripcion_paquete.Text,
                    Precio = float.Parse(precio_paquete.Text),
                    Fragil = fragil_paquete.Text,
                    TiempoEntrega = int.Parse(tiempo_entrega_paquete.Text),
                    IdBodega = int.Parse(id_bodega.Text),
                    IdSucursal = int.Parse(id_sucursal.Text)
                };

                bool actualizado = PaquetesCRUD.ActualizarPaquete(paqueteActualizado);
                if (actualizado)
                {
                    MessageBox.Show("Paquete actualizado correctamente.");
                    this.Close(); // Cerrar ventana
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el paquete.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
