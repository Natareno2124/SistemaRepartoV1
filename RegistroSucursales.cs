using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaRepartoG4;
namespace WinFormsApp1

{
    using System.Drawing;
    using SistemaRepartoG4.Clases;

    public partial class RegistroSucursales : Form
    {
        public RegistroSucursales()
        {
            InitializeComponent();
            groupBox1.BackColor = ColorTranslator.FromHtml("#8D99AE");
            button1.BackColor = ColorTranslator.FromHtml("#8D99AE");
            BackColor = ColorTranslator.FromHtml("#2C546D");
        }
        private void AplicarColorATextBox(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.BackColor = ColorTranslator.FromHtml("#2C546D");
                }

                // Si el control contiene otros controles (ej. Panel, GroupBox)
                if (ctrl.HasChildren)
                {
                    AplicarColorATextBox(ctrl);
                }
            }
        }


        private void AplicarColorALabel(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                if (ctrl is Label)
                {
                    ctrl.ForeColor = ColorTranslator.FromHtml("#183446");
                }

                // Si el control contiene otros controles (ej. Panel, GroupBox)
                if (ctrl.HasChildren)
                {
                    AplicarColorALabel(ctrl);
                }
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            AplicarColorATextBox(this);
            AplicarColorALabel(this);
        }

        private void btnAgregarSucursal_Click(object sender, EventArgs e) {
            try
            {
                // Creamos la sucursal con los valores del formulario
                Sucursal nuevaSucursal = new Sucursal
                {
                    CodigoSucursal = int.Parse(txtCodigoSucursal.Text),
                    IdEncargado = int.Parse(txt_IdEncargado.Text),
                    IdContactoSucursal = int.Parse(txt_IDContacto.Text),
                    IdDireccionSucursal = int.Parse(txt_IDDireccion.Text)
                };

                // Insertamos la sucursal usando el CRUD
                bool agregada = SucursalCRUD.InsertarSucursal(nuevaSucursal);

                if (agregada)
                {
                    MessageBox.Show("Sucursal agregada correctamente.");
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se pudo agregar la sucursal.");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, verifica que todos los campos sean números válidos.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar la sucursal: " + ex.Message);
            }
        }
        private void LimpiarCampos()
        {
            txtCodigoSucursal.Clear();
            txt_IdEncargado.Clear();
            txt_IDContacto.Clear();
            txt_IDDireccion.Clear();
        }


        private void txtNombres_TextChanged(object sender, EventArgs e)
        {

        }

 
        private void button2_Click_1(object sender, EventArgs e)
        {

        }
 


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Nombre_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void txtTelefonoContacto_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
