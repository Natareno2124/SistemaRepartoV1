namespace SistemaRepartoG4
{
    partial class BodegaDetalleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nudCodigo = new System.Windows.Forms.NumericUpDown();
            this.nudEncargadoID = new System.Windows.Forms.NumericUpDown();
            this.nudSucursalID = new System.Windows.Forms.NumericUpDown();
            this.nudCapacidad = new System.Windows.Forms.NumericUpDown();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblEncargado = new System.Windows.Forms.Label();
            this.lblSucursal = new System.Windows.Forms.Label();
            this.lblCapacidad = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudCodigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEncargadoID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSucursalID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacidad)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(20, 20);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(113, 17);
            this.lblCodigo.Text = "Código de Bodega:";
            // 
            // nudCodigo
            // 
            this.nudCodigo.Location = new System.Drawing.Point(150, 18);
            this.nudCodigo.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            this.nudCodigo.Name = "nudCodigo";
            // 
            // lblEncargado
            // 
            this.lblEncargado.AutoSize = true;
            this.lblEncargado.Location = new System.Drawing.Point(20, 60);
            this.lblEncargado.Name = "lblEncargado";
            this.lblEncargado.Size = new System.Drawing.Size(88, 17);
            this.lblEncargado.Text = "ID Encargado:";
            // 
            // nudEncargadoID
            // 
            this.nudEncargadoID.Location = new System.Drawing.Point(150, 58);
            this.nudEncargadoID.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            this.nudEncargadoID.Name = "nudEncargadoID";
            // 
            // lblSucursal
            // 
            this.lblSucursal.AutoSize = true;
            this.lblSucursal.Location = new System.Drawing.Point(20, 100);
            this.lblSucursal.Name = "lblSucursal";
            this.lblSucursal.Size = new System.Drawing.Size(80, 17);
            this.lblSucursal.Text = "ID Sucursal:";
            // 
            // nudSucursalID
            // 
            this.nudSucursalID.Location = new System.Drawing.Point(150, 98);
            this.nudSucursalID.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            this.nudSucursalID.Name = "nudSucursalID";
            // 
            // lblCapacidad
            // 
            this.lblCapacidad.AutoSize = true;
            this.lblCapacidad.Location = new System.Drawing.Point(20, 140);
            this.lblCapacidad.Name = "lblCapacidad";
            this.lblCapacidad.Size = new System.Drawing.Size(75, 17);
            this.lblCapacidad.Text = "Capacidad:";
            // 
            // nudCapacidad
            // 
            this.nudCapacidad.Location = new System.Drawing.Point(150, 138);
            this.nudCapacidad.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            this.nudCapacidad.Name = "nudCapacidad";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(50, 190);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(80, 30);
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(150, 190);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 30);
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // BodegaDetalleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 240);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.nudCodigo);
            this.Controls.Add(this.lblEncargado);
            this.Controls.Add(this.nudEncargadoID);
            this.Controls.Add(this.lblSucursal);
            this.Controls.Add(this.nudSucursalID);
            this.Controls.Add(this.lblCapacidad);
            this.Controls.Add(this.nudCapacidad);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BodegaDetalleForm";
            this.Text = "Detalle de Bodega";
            ((System.ComponentModel.ISupportInitialize)(this.nudCodigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEncargadoID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSucursalID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudCodigo;
        private System.Windows.Forms.NumericUpDown nudEncargadoID;
        private System.Windows.Forms.NumericUpDown nudSucursalID;
        private System.Windows.Forms.NumericUpDown nudCapacidad;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblEncargado;
        private System.Windows.Forms.Label lblSucursal;
        private System.Windows.Forms.Label lblCapacidad;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}
