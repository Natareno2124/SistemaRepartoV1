

using System;
using System.Windows.Forms;
using WinFormsApp1;

namespace SistemaRepartoG4.Clases
{
    public class Login : Form
    {
        private Label lblUsuario;
        private Label lblPassWord;
        private TextBox txtUsuario;
        private TextBox txtPassWord;
        private Button btnIngresar;

        public Login()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.btnIngresar = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblPassWord = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(293, 261);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(224, 88);
            this.btnIngresar.TabIndex = 0;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(164, 91);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(54, 16);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblPassWord
            // 
            this.lblPassWord.AutoSize = true;
            this.lblPassWord.Location = new System.Drawing.Point(164, 156);
            this.lblPassWord.Name = "lblPassWord";
            this.lblPassWord.Size = new System.Drawing.Size(76, 16);
            this.lblPassWord.TabIndex = 2;
            this.lblPassWord.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(246, 91);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(169, 22);
            this.txtUsuario.TabIndex = 3;
            // 
            // txtPassWord
            // 
            this.txtPassWord.Location = new System.Drawing.Point(246, 156);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.Size = new System.Drawing.Size(169, 22);
            this.txtPassWord.TabIndex = 4;
            // 
            // Login
            // 
            this.ClientSize = new System.Drawing.Size(1280, 585);
            this.Controls.Add(this.txtPassWord);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblPassWord);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.btnIngresar);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string password = txtPassWord.Text;
            try{
                Validar val = new Validar();
                string respuesta = val.ctrlLogin(usuario, password);
                if (respuesta.Length > 0)
                {
                    MessageBox.Show(respuesta, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if(Session.id_rol == 1) // Verifica si el rol es de administrador
                    {
                        MessageBox.Show("Bienvenido " + Session.nombres, "Inicio de sesión exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MenuPrincipal menu = new MenuPrincipal();
                        menu.Visible = true;
                        this.Visible = false;
                    }
                    else// Verifica si el rol es de piloto
                    {
                        MessageBox.Show("Bienvenido " + Session.nombres, "Inicio de sesión exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MenuPiloto menu = new MenuPiloto();
                        menu.Visible = true;
                        this.Visible = false;
                    }
                    
                }
            }
            catch(Exception ex){
                MessageBox.Show("Error al iniciar sesión: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
