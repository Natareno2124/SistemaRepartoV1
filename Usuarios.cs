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
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            RegistroUsuarios ventana = new RegistroUsuarios();
            ventana.ShowDialog();
            CargarUsuarios();
        }


        private void CargarUsuarios()
        {
            var cUsuarios = new SistemaRepartoG4.Clases.CUsuarios();
            cUsuarios.mostrarUsuarios(DB);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            var cUsuarios = new SistemaRepartoG4.Clases.CUsuarios();
            cUsuarios.mostrarUsuarios(DB);

            // ENCABEZADO DE LAS COLUMNAS DEL DATAGRIDVIEW
            DB.Columns["id_usuario"].HeaderText = "ID";
            DB.Columns["nombres_usuario"].HeaderText = "Nombres";
            DB.Columns["apellidos_usuario"].HeaderText = "Apellidos";
            DB.Columns["usuario"].HeaderText = "Usuario";
            DB.Columns["contrasena_usuario"].HeaderText = "Contraseña";
            DB.Columns["email_usuario"].HeaderText = "Correo";
            DB.Columns["telefono_usuario"].HeaderText = "Teléfono";
            DB.Columns["rol_usuario"].HeaderText = "Rol";

            // VISUALIZACIÓN DEL DATAGRIDVIEW
            DB.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DB.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DB.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            DB.BorderStyle = BorderStyle.None;
            DB.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DB.EnableHeadersVisualStyles = false;

            DB.BackgroundColor = Color.White;

            DB.DefaultCellStyle.Font = new Font("Arial", 10);
            DB.DefaultCellStyle.ForeColor = Color.Black;
            DB.DefaultCellStyle.BackColor = Color.White;
            DB.DefaultCellStyle.SelectionBackColor = Color.FromArgb(141, 153, 174);
            DB.DefaultCellStyle.SelectionForeColor = Color.White;

            DB.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(24, 52, 70);
            DB.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            DB.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            DB.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            DB.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);

            DB.AllowUserToAddRows = false;

            DB.RowTemplate.Height = 28;
            DB.ColumnHeadersHeight = 35;
        }

        private void Btn_editar_Click(object sender, EventArgs e)
        {
            if (DB.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = DB.SelectedRows[0];

                UsuariosV usuario = new UsuariosV
                {
                    Id = Convert.ToInt32(fila.Cells["id_usuario"].Value),
                    Nombres = fila.Cells["nombres_usuario"].Value.ToString(),
                    Apellidos = fila.Cells["apellidos_usuario"].Value.ToString(),
                    Usuario = fila.Cells["usuario"].Value.ToString(),
                    Contrasena = fila.Cells["contrasena_usuario"].Value.ToString(),
                    ConPassword = fila.Cells["contrasena_usuario"].Value.ToString(),
                    Email = fila.Cells["email_usuario"].Value.ToString(),
                    Telefono = fila.Cells["telefono_usuario"].Value.ToString()
                };

                RegistroUsuarios editarForm = new RegistroUsuarios(usuario);
                editarForm.ShowDialog();

                // Refrescar DataGridView
                var cUsuarios = new Clases.CUsuarios();
                cUsuarios.mostrarUsuarios(DB);
            }
            else
            {
                MessageBox.Show("Selecciona un usuario para editar");
            }
        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            if (DB.SelectedRows.Count > 0)
            {
                DialogResult confirm = MessageBox.Show("¿Estás seguro de que deseas eliminar este usuario?", "Confirmar eliminación", MessageBoxButtons.YesNo);

                if (confirm == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(DB.SelectedRows[0].Cells["id_usuario"].Value);
                    Modelo modelo = new Modelo();
                    bool eliminado = modelo.EliminarUsuario(id);

                    if (eliminado)
                    {
                        MessageBox.Show("Usuario eliminado correctamente");
                        new CUsuarios().mostrarUsuarios(DB);
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el usuario");
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecciona un usuario para eliminar");
            }
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            MenuPrincipal ventanaMenuPrincipal = new MenuPrincipal();
            ventanaMenuPrincipal.FormClosed += (s, args) => this.Show();
            ventanaMenuPrincipal.Show();
            this.Hide();
        }
    }
}
