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

    public partial class RegistroUsuarios : Form
    {
        public RegistroUsuarios()
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Form2 frmUsuarios = new Form2();
            //frmUsuarios.Show(); // abre en ventana separada
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UsuariosV usuario = new UsuariosV();
            usuario.Nombres = txtNombres.Text;
            usuario.Apellidos = txtApellidos.Text;
            usuario.Usuario = txtUserName.Text;
            usuario.Contrasena = txtPassword.Text;
            usuario.ConPassword = conPassword.Text;
            usuario.Email = txtEmail.Text;
            usuario.Telefono = txtTel.Text;


            try
            {

                Validar validar = new Validar();
                string respuesta = validar.ctrlRegistro(usuario);

                if (respuesta.Length > 0)
                {

                    MessageBox.Show(respuesta, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Usuario registrado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }




            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
