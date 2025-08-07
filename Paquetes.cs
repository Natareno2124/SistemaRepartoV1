using MySql.Data.MySqlClient;
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
using WinFormsApp1;


namespace SistemaRepartoG4
{
    public partial class Paquetes : Form
    {


        public Paquetes()
        {
            InitializeComponent();
            this.Load += Paquetes_Load;
        }


        private void Paquetes_Load(object sender, EventArgs e)
        {
            // esto llamara al CRUD par que se muestren los datos en el dataGridView
            PaquetesCRUD.MostrarPaquetes(dataGridViewPaquetes);
        }
        

        // aqui solo es para redirigir a la ventana de agregar
        private void Btn_agregar_paquete_Click(object sender, EventArgs e)
        {
            AgregarPaquete ventanaAgregarPaquete = new AgregarPaquete();
            ventanaAgregarPaquete.FormClosed += (s, args) => this.Show();
            ventanaAgregarPaquete.Show();
        }

        // aqui solo es para redirigir a la ventana de eliminar
        private void Btn_eliminar_paquete_Click(object sender, EventArgs e)
        {
            EliminarPaquete ventanaEliminarPaquete = new EliminarPaquete();
            ventanaEliminarPaquete.FormClosed += (s, args) => this.Show();
            ventanaEliminarPaquete.Show();
        }

        private void dataGridViewPaquetes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EditarPaquete ventanaEditarPaquete = new EditarPaquete();
            ventanaEditarPaquete.FormClosed += (s, args) => this.Show();
            ventanaEditarPaquete.Show();
        }

        private void Btn_editar_paquete_Click(object sender, EventArgs e)
        {
            // al seleccionar la fila que querramos, podremos editar su informacion
            if (dataGridViewPaquetes.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = dataGridViewPaquetes.SelectedRows[0];


                // con esto se toman en cuenta los datos que se muestran en el dataGridView ya ingresados
                Paquete paquete = new Paquete()
                {
                    IdGuiaMadre = Convert.ToInt32(fila.Cells["id_guia_madre"].Value),
                    PesoKg = Convert.ToSingle(fila.Cells["peso_kg_paquete"].Value),
                    LargoCm = Convert.ToSingle(fila.Cells["largo_cm_paquete"].Value),
                    AnchoCm = Convert.ToSingle(fila.Cells["ancho_cm_paquete"].Value),
                    AltoCm = Convert.ToSingle(fila.Cells["alto_cm_paquete"].Value),
                    Descripcion = fila.Cells["descripcion_paquete"].Value.ToString(),
                    Precio = Convert.ToSingle(fila.Cells["precio_paquete"].Value),
                    Fragil = fila.Cells["fragil_paquete"].Value.ToString(),
                    TiempoEntrega = Convert.ToInt32(fila.Cells["tiempo_entrega_paquete"].Value),
                    IdBodega = Convert.ToInt32(fila.Cells["id_bodega"].Value),
                    IdSucursal = Convert.ToInt32(fila.Cells["id_sucursal"].Value)
                };

                EditarPaquete ventanaEditar = new EditarPaquete(paquete);
                ventanaEditar.FormClosed += (s, args) => PaquetesCRUD.MostrarPaquetes(dataGridViewPaquetes); 
                ventanaEditar.Show();
            }
            else
            {
                MessageBox.Show("Selecciona un paquete para editar.");
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            MenuPrincipal ventanaMenuPrincipal = new MenuPrincipal();
            ventanaMenuPrincipal.FormClosed += (s, args) => this.Show();
            ventanaMenuPrincipal.Show();
            this.Hide();
        }
    }
}
