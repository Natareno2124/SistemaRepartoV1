namespace SistemaRepartoG4
{
    partial class RutaDetalleForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtIdRuta;
        private System.Windows.Forms.TextBox txtNombreRuta;
        private System.Windows.Forms.DateTimePicker dtpFechaRuta;
        private System.Windows.Forms.DateTimePicker dtpHoraInicio;
        private System.Windows.Forms.DateTimePicker dtpHoraFinal;
        private System.Windows.Forms.TextBox txtIdConductor;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtIdRuta = new System.Windows.Forms.TextBox();
            this.txtNombreRuta = new System.Windows.Forms.TextBox();
            this.dtpFechaRuta = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraFinal = new System.Windows.Forms.DateTimePicker();
            this.txtIdConductor = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // ID Ruta
            var lblIdRuta = new System.Windows.Forms.Label { Text = "ID Ruta:", Location = new System.Drawing.Point(20, 20), AutoSize = true };
            txtIdRuta.Location = new System.Drawing.Point(140, 20);
            txtIdRuta.Size = new System.Drawing.Size(180, 23);

            // Nombre Ruta
            var lblNombreRuta = new System.Windows.Forms.Label { Text = "Nombre Ruta:", Location = new System.Drawing.Point(20, 60), AutoSize = true };
            txtNombreRuta.Location = new System.Drawing.Point(140, 60);
            txtNombreRuta.Size = new System.Drawing.Size(180, 23);

            // Fecha
            var lblFecha = new System.Windows.Forms.Label { Text = "Fecha:", Location = new System.Drawing.Point(20, 100), AutoSize = true };
            dtpFechaRuta.Location = new System.Drawing.Point(140, 100);
            dtpFechaRuta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtpFechaRuta.Size = new System.Drawing.Size(180, 23);

            // Hora Inicio
            var lblHoraInicio = new System.Windows.Forms.Label { Text = "Hora Inicio:", Location = new System.Drawing.Point(20, 140), AutoSize = true };
            dtpHoraInicio.Location = new System.Drawing.Point(140, 140);
            dtpHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            dtpHoraInicio.ShowUpDown = true;
            dtpHoraInicio.Size = new System.Drawing.Size(180, 23);

            // Hora Final
            var lblHoraFinal = new System.Windows.Forms.Label { Text = "Hora Final:", Location = new System.Drawing.Point(20, 180), AutoSize = true };
            dtpHoraFinal.Location = new System.Drawing.Point(140, 180);
            dtpHoraFinal.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            dtpHoraFinal.ShowUpDown = true;
            dtpHoraFinal.Size = new System.Drawing.Size(180, 23);

            // Id Conductor
            var lblIdConductor = new System.Windows.Forms.Label { Text = "ID Conductor:", Location = new System.Drawing.Point(20, 220), AutoSize = true };
            txtIdConductor.Location = new System.Drawing.Point(140, 220);
            txtIdConductor.Size = new System.Drawing.Size(180, 23);

            // Botón Aceptar
            btnAceptar.Text = "Aceptar";
            btnAceptar.Location = new System.Drawing.Point(60, 260);
            btnAceptar.Size = new System.Drawing.Size(100, 30);
            btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);

            // Botón Cancelar
            btnCancelar.Text = "Cancelar";
            btnCancelar.Location = new System.Drawing.Point(180, 260);
            btnCancelar.Size = new System.Drawing.Size(100, 30);
            btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);

            this.ClientSize = new System.Drawing.Size(350, 320);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                lblIdRuta, txtIdRuta,
                lblNombreRuta, txtNombreRuta,
                lblFecha, dtpFechaRuta,
                lblHoraInicio, dtpHoraInicio,
                lblHoraFinal, dtpHoraFinal,
                lblIdConductor, txtIdConductor,
                btnAceptar, btnCancelar
            });
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Detalle de Ruta";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
