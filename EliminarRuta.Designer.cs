namespace SistemaRepartoG4
{
    partial class EliminarRuta
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
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Id_Ruta = new System.Windows.Forms.TextBox();
            this.btn_eliminar_p = new System.Windows.Forms.Button();
            this.lineadecorativa = new System.Windows.Forms.Label();
            this.labelpaquetes = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(84)))), ((int)(((byte)(109)))));
            this.label2.Location = new System.Drawing.Point(72, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 21);
            this.label2.TabIndex = 38;
            this.label2.Text = "Ingrese Id Ruta";
            // 
            // txt_Id_Ruta
            // 
            this.txt_Id_Ruta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Id_Ruta.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Id_Ruta.Location = new System.Drawing.Point(76, 198);
            this.txt_Id_Ruta.Name = "txt_Id_Ruta";
            this.txt_Id_Ruta.Size = new System.Drawing.Size(261, 21);
            this.txt_Id_Ruta.TabIndex = 37;
            // 
            // btn_eliminar_p
            // 
            this.btn_eliminar_p.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.btn_eliminar_p.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar_p.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_eliminar_p.Location = new System.Drawing.Point(610, 271);
            this.btn_eliminar_p.Margin = new System.Windows.Forms.Padding(4);
            this.btn_eliminar_p.Name = "btn_eliminar_p";
            this.btn_eliminar_p.Size = new System.Drawing.Size(155, 37);
            this.btn_eliminar_p.TabIndex = 35;
            this.btn_eliminar_p.Text = "Eliminar";
            this.btn_eliminar_p.UseVisualStyleBackColor = false;
            this.btn_eliminar_p.Click += new System.EventHandler(this.btn_eliminar_p_Click);
            // 
            // lineadecorativa
            // 
            this.lineadecorativa.AutoSize = true;
            this.lineadecorativa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lineadecorativa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.lineadecorativa.Location = new System.Drawing.Point(71, 123);
            this.lineadecorativa.Name = "lineadecorativa";
            this.lineadecorativa.Size = new System.Drawing.Size(693, 29);
            this.lineadecorativa.TabIndex = 34;
            this.lineadecorativa.Text = "---------------------------------------------------------------------------------" +
    "----";
            // 
            // labelpaquetes
            // 
            this.labelpaquetes.AutoSize = true;
            this.labelpaquetes.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpaquetes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.labelpaquetes.Location = new System.Drawing.Point(69, 84);
            this.labelpaquetes.Name = "labelpaquetes";
            this.labelpaquetes.Size = new System.Drawing.Size(283, 42);
            this.labelpaquetes.TabIndex = 33;
            this.labelpaquetes.Text = "ELIMINAR RUTA";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(153)))), ((int)(((byte)(174)))));
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(811, 60);
            this.panel1.TabIndex = 32;
            // 
            // EliminarRuta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 343);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Id_Ruta);
            this.Controls.Add(this.btn_eliminar_p);
            this.Controls.Add(this.lineadecorativa);
            this.Controls.Add(this.labelpaquetes);
            this.Controls.Add(this.panel1);
            this.Name = "EliminarRuta";
            this.Text = "EliminarRuta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Id_Ruta;
        private System.Windows.Forms.Button btn_eliminar_p;
        private System.Windows.Forms.Label lineadecorativa;
        private System.Windows.Forms.Label labelpaquetes;
        private System.Windows.Forms.Panel panel1;
    }
}