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
    using static System.Windows.Forms.VisualStyles.VisualStyleElement;

    public partial class RegistroUsuarios : Form
    {
        private int? idUsuario = null;
        private bool esEdicion = false;

        public RegistroUsuarios()
        {
            InitializeComponent();
            groupBox1.BackColor = ColorTranslator.FromHtml("#8D99AE");
            button1.BackColor = ColorTranslator.FromHtml("#8D99AE");
            BackColor = ColorTranslator.FromHtml("#2C546D");
        }

        public RegistroUsuarios(UsuariosV usuario)
        {
            InitializeComponent();

            esEdicion = true;
            idUsuario = usuario.Id;

            txtNombres.Text = usuario.Nombres;
            txtApellidos.Text = usuario.Apellidos;
            txtUserName.Text = usuario.Usuario;
            txtPassword.Text = usuario.Contrasena;
            conPassword.Text = usuario.Contrasena;
            txtEmail.Text = usuario.Email;
            txtTel.Text = usuario.Telefono;

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
            if (comboRol.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un rol.");
                return;
            }
            int rol = comboRol.SelectedIndex == 0 ? 1 : 2;
            UsuariosV usuario = new UsuariosV
            {

                Nombres = txtNombres.Text,
                Apellidos = txtApellidos.Text,
                Usuario = txtUserName.Text,
                Contrasena = txtPassword.Text,
                ConPassword = conPassword.Text,
                Email = txtEmail.Text,
                Telefono = txtTel.Text,
                Rol_usuario = rol
            };

            try
            {
                Validar validar = new Validar();
                string respuesta;

                if (esEdicion)
                {
                    usuario.Id = idUsuario.Value;
                    respuesta = validar.ctrlActualizar(usuario);
                }
                else
                {
                    respuesta = validar.ctrlRegistro(usuario);
                }

                if (!string.IsNullOrEmpty(respuesta))
                {
                    MessageBox.Show(respuesta, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(esEdicion ? "Usuario actualizado correctamente" : "Usuario registrado correctamente",
                                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // cerrar formulario luego de guardar
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void RegistroUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
