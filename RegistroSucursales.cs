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

        private void guardarSucursal_Click(object sender, EventArgs e) { 
            Sucursal sucursal = new Sucursal();
            ContactoSucursal contactoSucursal = new ContactoSucursal();
            DireccionSucursal direccionSucursal = new DireccionSucursal();
            Validar validar = new Validar();
            Boolean contactoSucursalValido = validar.validarContactoSucursal(contactoSucursal);

            if (!contactoSucursalValido) {
                MessageBox.Show("Todos los campos de contacto de sucursal son requeridos");
                return;
            }

            contactoSucursal.TelefonoSucursal = txtTelefonoContacto.Text;
            contactoSucursal.CorreoSucursal = txtCorreoContacto.Text;

            Boolean direccionSucursalValido = validar.validarDireccionSucursal(direccionSucursal);

            if (!contactoSucursalValido)
            {
                MessageBox.Show("Todos los campos de direccion de sucursal son requeridos");
                return;
            }

            direccionSucursal.Zona = Int32.Parse(txtZona.Text);
            direccionSucursal.Avenida = txtAvenida.Text;
            direccionSucursal.Ciudad = txtCiudad.Text;
            direccionSucursal.Municipo = txtMunicipio.Text;


            sucursal.CodigoSucursal = Int32.Parse(txtCodigoSucursal.Text);


            MessageBox.Show("Creado Exitosamente");

            
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
    }
}
