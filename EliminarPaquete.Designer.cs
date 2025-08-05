namespace SistemaRepartoG4
{
    partial class EliminarPaquete
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
            this.lineadecorativa = new System.Windows.Forms.Label();
            this.labelpaquetes = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_eliminar_p = new System.Windows.Forms.Button();
            this.id_guia_madre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lineadecorativa
            // 
            this.lineadecorativa.AutoSize = true;
            this.lineadecorativa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lineadecorativa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.lineadecorativa.Location = new System.Drawing.Point(54, 109);
            this.lineadecorativa.Name = "lineadecorativa";
            this.lineadecorativa.Size = new System.Drawing.Size(693, 29);
            this.lineadecorativa.TabIndex = 27;
            this.lineadecorativa.Text = "---------------------------------------------------------------------------------" +
    "----";
            // 
            // labelpaquetes
            // 
            this.labelpaquetes.AutoSize = true;
            this.labelpaquetes.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpaquetes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.labelpaquetes.Location = new System.Drawing.Point(52, 70);
            this.labelpaquetes.Name = "labelpaquetes";
            this.labelpaquetes.Size = new System.Drawing.Size(350, 42);
            this.labelpaquetes.TabIndex = 26;
            this.labelpaquetes.Text = "ELIMINAR PAQUETE";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(153)))), ((int)(((byte)(174)))));
            this.panel1.Location = new System.Drawing.Point(-5, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(811, 60);
            this.panel1.TabIndex = 25;
            // 
            // btn_eliminar_p
            // 
            this.btn_eliminar_p.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.btn_eliminar_p.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar_p.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_eliminar_p.Location = new System.Drawing.Point(593, 257);
            this.btn_eliminar_p.Margin = new System.Windows.Forms.Padding(4);
            this.btn_eliminar_p.Name = "btn_eliminar_p";
            this.btn_eliminar_p.Size = new System.Drawing.Size(155, 37);
            this.btn_eliminar_p.TabIndex = 28;
            this.btn_eliminar_p.Text = "Eliminar";
            this.btn_eliminar_p.UseVisualStyleBackColor = false;
            this.btn_eliminar_p.Click += new System.EventHandler(this.btn_eliminar_p_Click);
            // 
            // id_guia_madre
            // 
            this.id_guia_madre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.id_guia_madre.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_guia_madre.Location = new System.Drawing.Point(59, 217);
            this.id_guia_madre.Name = "id_guia_madre";
            this.id_guia_madre.Size = new System.Drawing.Size(261, 21);
            this.id_guia_madre.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(84)))), ((int)(((byte)(109)))));
            this.label1.Location = new System.Drawing.Point(55, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 21);
            this.label1.TabIndex = 29;
            this.label1.Text = "Guía Madre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(84)))), ((int)(((byte)(109)))));
            this.label2.Location = new System.Drawing.Point(55, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 21);
            this.label2.TabIndex = 31;
            this.label2.Text = "Ingrese Guía Madre";
            // 
            // EliminarPaquete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 340);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.id_guia_madre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_eliminar_p);
            this.Controls.Add(this.lineadecorativa);
            this.Controls.Add(this.labelpaquetes);
            this.Controls.Add(this.panel1);
            this.Name = "EliminarPaquete";
            this.Text = "EliminarPaquete";
            this.Load += new System.EventHandler(this.EliminarPaquete_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lineadecorativa;
        private System.Windows.Forms.Label labelpaquetes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_eliminar_p;
        private System.Windows.Forms.TextBox id_guia_madre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}