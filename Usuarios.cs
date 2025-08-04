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
            RegistroUsuarios ventana = new RegistroUsuarios(); // Instanciar la ventana
            ventana.Show(); // Mostrarla
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
    }
}
