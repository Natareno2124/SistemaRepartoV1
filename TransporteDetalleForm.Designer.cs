//TransporteDetalleDESIGNER
//ventana de ingreso de datos DISEÑO
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaRepartoG4
{
    partial class TransporteDetalleForm
    {
        private TextBox txtPlaca;
        private TextBox txtMarca;
        private TextBox txtModelo;
        private TextBox txtColor;
        private TextBox txtCapacidad;
        private ComboBox cbSucursal;
        private ComboBox cbTipo;
        private ComboBox cbEstado;
        private Button btnAceptar;
        private Button btnCancelar;

        private void InitializeComponent()
        {
            this.txtPlaca = new TextBox();
            this.txtMarca = new TextBox();
            this.txtModelo = new TextBox();
            this.txtColor = new TextBox();
            this.txtCapacidad = new TextBox();
            this.cbSucursal = new ComboBox();
            this.cbTipo = new ComboBox();
            this.cbEstado = new ComboBox();
            this.btnAceptar = new Button();
            this.btnCancelar = new Button();

            // Propiedades del formulario
            this.Text = "Detalle de Transporte";
            this.ClientSize = new Size(350, 380);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterParent;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            // Labels y posiciones
            var lblPlaca = new Label { Text = "Placa:", Location = new Point(20, 20), AutoSize = true };
            var lblMarca = new Label { Text = "Marca:", Location = new Point(20, 60), AutoSize = true };
            var lblModelo = new Label { Text = "Modelo:", Location = new Point(20, 100), AutoSize = true };
            var lblColor = new Label { Text = "Color:", Location = new Point(20, 140), AutoSize = true };
            var lblCapac = new Label { Text = "Capacidad:", Location = new Point(20, 180), AutoSize = true };
            var lblSucursal = new Label { Text = "Sucursal:", Location = new Point(20, 220), AutoSize = true };
            var lblTipo = new Label { Text = "Tipo:", Location = new Point(20, 260), AutoSize = true };
            var lblEstado = new Label { Text = "Estado:", Location = new Point(20, 300), AutoSize = true };

            // Posicionar TextBoxes
            txtPlaca.Location = new Point(140, 18); txtPlaca.Size = new Size(180, 23);
            txtMarca.Location = new Point(140, 58); txtMarca.Size = new Size(180, 23);
            txtModelo.Location = new Point(140, 98); txtModelo.Size = new Size(180, 23);
            txtColor.Location = new Point(140, 138); txtColor.Size = new Size(180, 23);
            txtCapacidad.Location = new Point(140, 178); txtCapacidad.Size = new Size(180, 23);

            // Posicionar ComboBoxes
            cbSucursal.Location = new Point(140, 218); cbSucursal.Size = new Size(180, 23); cbSucursal.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTipo.Location = new Point(140, 258); cbTipo.Size = new Size(180, 23); cbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEstado.Location = new Point(140, 298); cbEstado.Size = new Size(180, 23); cbEstado.DropDownStyle = ComboBoxStyle.DropDownList;

            // Posicionar Botones
            btnAceptar.Text = "Aceptar"; btnAceptar.Location = new Point(60, 330); btnAceptar.Size = new Size(100, 30);
            btnCancelar.Text = "Cancelar"; btnCancelar.Location = new Point(180, 330); btnCancelar.Size = new Size(100, 30);

            // Agregar todo al formulario
            this.Controls.AddRange(new Control[] {
                    lblPlaca, txtPlaca,
                    lblMarca, txtMarca,
                    lblModelo, txtModelo,
                    lblColor, txtColor,
                    lblCapac, txtCapacidad,
                    lblSucursal, cbSucursal,
                    lblTipo, cbTipo,
                    lblEstado, cbEstado,
                    btnAceptar, btnCancelar
                });
        }
    }
}
