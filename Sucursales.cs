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
    public partial class Sucursales : Form {
        public Sucursales(){
            InitializeComponent();
        }

        private void Btn_agregar_click(object sender, EventArgs e) { 
            RegistroSucursales registroSucursales = new RegistroSucursales();
            registroSucursales.Show();
        }
    }
}
