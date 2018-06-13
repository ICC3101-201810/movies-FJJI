namespace FinalLab
{
    partial class Form3
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
            this.button1 = new System.Windows.Forms.Button();
            this.Titulo = new System.Windows.Forms.Label();
            this.BiografiaPerfil = new System.Windows.Forms.Label();
            this.NacimietoPerfil = new System.Windows.Forms.Label();
            this.ApellidoPerfil = new System.Windows.Forms.Label();
            this.NombrePerfil = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(662, 407);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(265, 20);
            this.Titulo.Name = "Titulo";
            this.Titulo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Titulo.Size = new System.Drawing.Size(86, 31);
            this.Titulo.TabIndex = 18;
            this.Titulo.Text = "label5";
            // 
            // BiografiaPerfil
            // 
            this.BiografiaPerfil.AutoSize = true;
            this.BiografiaPerfil.Location = new System.Drawing.Point(333, 192);
            this.BiografiaPerfil.Name = "BiografiaPerfil";
            this.BiografiaPerfil.Size = new System.Drawing.Size(45, 13);
            this.BiografiaPerfil.TabIndex = 17;
            this.BiografiaPerfil.Text = "textoBio";
            // 
            // NacimietoPerfil
            // 
            this.NacimietoPerfil.AutoSize = true;
            this.NacimietoPerfil.Location = new System.Drawing.Point(333, 154);
            this.NacimietoPerfil.Name = "NacimietoPerfil";
            this.NacimietoPerfil.Size = new System.Drawing.Size(34, 13);
            this.NacimietoPerfil.TabIndex = 16;
            this.NacimietoPerfil.Text = "fecha";
            this.NacimietoPerfil.Click += new System.EventHandler(this.NacimietoPerfil_Click);
            // 
            // ApellidoPerfil
            // 
            this.ApellidoPerfil.AutoSize = true;
            this.ApellidoPerfil.Location = new System.Drawing.Point(330, 118);
            this.ApellidoPerfil.Name = "ApellidoPerfil";
            this.ApellidoPerfil.Size = new System.Drawing.Size(35, 13);
            this.ApellidoPerfil.TabIndex = 15;
            this.ApellidoPerfil.Text = "label6";
            // 
            // NombrePerfil
            // 
            this.NombrePerfil.AutoSize = true;
            this.NombrePerfil.Location = new System.Drawing.Point(330, 80);
            this.NombrePerfil.Name = "NombrePerfil";
            this.NombrePerfil.Size = new System.Drawing.Size(35, 13);
            this.NombrePerfil.TabIndex = 14;
            this.NombrePerfil.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Biografia:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Apellido:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Fecha de nacimiento:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.ForeColor = System.Drawing.Color.Black;
            this.Label1.Location = new System.Drawing.Point(64, 80);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(47, 13);
            this.Label1.TabIndex = 10;
            this.Label1.Text = "Nombre:";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.BiografiaPerfil);
            this.Controls.Add(this.NacimietoPerfil);
            this.Controls.Add(this.ApellidoPerfil);
            this.Controls.Add(this.NombrePerfil);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Label BiografiaPerfil;
        private System.Windows.Forms.Label NacimietoPerfil;
        private System.Windows.Forms.Label ApellidoPerfil;
        private System.Windows.Forms.Label NombrePerfil;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Label1;
    }
}