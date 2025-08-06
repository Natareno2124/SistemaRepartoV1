//PilotoDetalleFormDESIGNE
// ingreso y edicion de datos
using System;
using System.Drawing;
using System.Windows.Forms;

partial class PilotoDetalleForm : Form
{
    private TextBox txtNombres;
    private TextBox txtApellidos;
    private DateTimePicker dtpFechaNacimiento;
    private ComboBox cbSexo;
    private ComboBox cbTipoLicencia;
    private ComboBox cbSucursal;
    private TextBox txtTelefono;
    private TextBox txtCorreo;
    private TextBox txtCalle;
    private TextBox txtAvenida;
    private TextBox txtZona;
    private TextBox txtCiudad;
    private TextBox txtMunicipio;

    private Button btnAceptar;
    private Button btnCancelar;


    //para que nos deje usar placeholder por la version que estamos usando
    private void SetPlaceholder(TextBox textBox, string placeholder)
    {
        textBox.Text = placeholder;
        textBox.ForeColor = SystemColors.GrayText;

        textBox.Enter += (s, e) =>
        {
            if (textBox.Text == placeholder)
            {
                textBox.Text = "";
                textBox.ForeColor = SystemColors.WindowText;
            }
        };
        textBox.Leave += (s, e) =>
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = placeholder;
                textBox.ForeColor = SystemColors.GrayText;
            }
        };
    }

    public PilotoDetalleForm()
    {
        int leftMargin = 30;
        int top = 20;
        int spacing = 30;
        int fieldWidth = 220;

        txtTelefono = new TextBox { Left = leftMargin, Top = top, Width = fieldWidth };
        SetPlaceholder(txtTelefono, "Teléfono");
        top += spacing;

        txtCorreo = new TextBox { Left = leftMargin, Top = top, Width = fieldWidth };
        SetPlaceholder(txtCorreo, "Correo");
        top += spacing;

        txtCalle = new TextBox { Left = leftMargin, Top = top, Width = fieldWidth };
        SetPlaceholder(txtCalle, "Calle");
        top += spacing;

        txtAvenida = new TextBox { Left = leftMargin, Top = top, Width = fieldWidth };
        SetPlaceholder(txtAvenida, "Avenida");
        top += spacing;

        txtZona = new TextBox { Left = leftMargin, Top = top, Width = fieldWidth };
        SetPlaceholder(txtZona, "Zona");
        top += spacing;

        txtCiudad = new TextBox { Left = leftMargin, Top = top, Width = fieldWidth };
        SetPlaceholder(txtCiudad, "Ciudad");
        top += spacing;

        txtMunicipio = new TextBox { Left = leftMargin, Top = top, Width = fieldWidth };
        SetPlaceholder(txtMunicipio, "Municipio");
        top += spacing + 10;

        btnAceptar = new Button
        {
            Text = "Aceptar",
            Left = leftMargin,
            Top = 190,
            Width = 100,
            DialogResult = DialogResult.OK
        };


        btnCancelar = new Button
        {
            Text = "Cancelar",
            Left = leftMargin + 120,
            Top = 190,
            Width = 100,
            DialogResult = DialogResult.Cancel
        };

        Controls.AddRange(new Control[] {
            txtNombres, txtApellidos, dtpFechaNacimiento,
            cbSexo, cbTipoLicencia, cbSucursal,
            txtTelefono, txtCorreo, txtCalle,
            txtAvenida, txtZona, txtCiudad, txtMunicipio,
            btnAceptar, btnCancelar
        });

        this.Text = "Detalle de Piloto";
        this.StartPosition = FormStartPosition.CenterParent;
        this.FormBorderStyle = FormBorderStyle.FixedDialog;
        this.AutoSize = false;

        this.MinimizeBox = false;
    }
}




