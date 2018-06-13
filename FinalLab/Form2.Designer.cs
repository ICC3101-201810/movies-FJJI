namespace FinalLab
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPeliculas = new System.Windows.Forms.Button();
            this.buttonActores = new System.Windows.Forms.Button();
            this.buttonDirectores = new System.Windows.Forms.Button();
            this.buttonProductores = new System.Windows.Forms.Button();
            this.buttonEstudios = new System.Windows.Forms.Button();
            this.textBoxBusqueda = new System.Windows.Forms.TextBox();
            this.botonSalir = new System.Windows.Forms.Button();
            this.listBoxWoa = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(252, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // buttonPeliculas
            // 
            this.buttonPeliculas.Location = new System.Drawing.Point(109, 78);
            this.buttonPeliculas.Name = "buttonPeliculas";
            this.buttonPeliculas.Size = new System.Drawing.Size(74, 36);
            this.buttonPeliculas.TabIndex = 1;
            this.buttonPeliculas.Text = "Peliculas";
            this.buttonPeliculas.UseVisualStyleBackColor = true;
            this.buttonPeliculas.Click += new System.EventHandler(this.buttonPeliculas_Click);
            // 
            // buttonActores
            // 
            this.buttonActores.Location = new System.Drawing.Point(189, 78);
            this.buttonActores.Name = "buttonActores";
            this.buttonActores.Size = new System.Drawing.Size(74, 36);
            this.buttonActores.TabIndex = 2;
            this.buttonActores.Text = "Actores";
            this.buttonActores.UseVisualStyleBackColor = true;
            this.buttonActores.Click += new System.EventHandler(this.buttonActores_Click);
            // 
            // buttonDirectores
            // 
            this.buttonDirectores.Location = new System.Drawing.Point(269, 78);
            this.buttonDirectores.Name = "buttonDirectores";
            this.buttonDirectores.Size = new System.Drawing.Size(74, 36);
            this.buttonDirectores.TabIndex = 3;
            this.buttonDirectores.Text = "Directores";
            this.buttonDirectores.UseVisualStyleBackColor = true;
            this.buttonDirectores.Click += new System.EventHandler(this.buttonDirectores_Click);
            // 
            // buttonProductores
            // 
            this.buttonProductores.Location = new System.Drawing.Point(349, 78);
            this.buttonProductores.Name = "buttonProductores";
            this.buttonProductores.Size = new System.Drawing.Size(74, 36);
            this.buttonProductores.TabIndex = 4;
            this.buttonProductores.Text = "Productores";
            this.buttonProductores.UseVisualStyleBackColor = true;
            this.buttonProductores.Click += new System.EventHandler(this.buttonProductores_Click);
            // 
            // buttonEstudios
            // 
            this.buttonEstudios.Location = new System.Drawing.Point(429, 78);
            this.buttonEstudios.Name = "buttonEstudios";
            this.buttonEstudios.Size = new System.Drawing.Size(74, 36);
            this.buttonEstudios.TabIndex = 1;
            this.buttonEstudios.Text = "Estudios";
            this.buttonEstudios.UseVisualStyleBackColor = true;
            this.buttonEstudios.Click += new System.EventHandler(this.buttonEstudios_Click);
            // 
            // textBoxBusqueda
            // 
            this.textBoxBusqueda.AccessibleDescription = "";
            this.textBoxBusqueda.Location = new System.Drawing.Point(109, 52);
            this.textBoxBusqueda.Name = "textBoxBusqueda";
            this.textBoxBusqueda.Size = new System.Drawing.Size(394, 20);
            this.textBoxBusqueda.TabIndex = 5;
            // 
            // botonSalir
            // 
            this.botonSalir.Location = new System.Drawing.Point(12, 402);
            this.botonSalir.Name = "botonSalir";
            this.botonSalir.Size = new System.Drawing.Size(74, 36);
            this.botonSalir.TabIndex = 6;
            this.botonSalir.Text = "Salir";
            this.botonSalir.UseVisualStyleBackColor = true;
            this.botonSalir.Click += new System.EventHandler(this.botonSalir_Click);
            // 
            // listBoxWoa
            // 
            this.listBoxWoa.FormattingEnabled = true;
            this.listBoxWoa.Location = new System.Drawing.Point(113, 142);
            this.listBoxWoa.Name = "listBoxWoa";
            this.listBoxWoa.Size = new System.Drawing.Size(389, 251);
            this.listBoxWoa.TabIndex = 7;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxWoa);
            this.Controls.Add(this.botonSalir);
            this.Controls.Add(this.textBoxBusqueda);
            this.Controls.Add(this.buttonDirectores);
            this.Controls.Add(this.buttonProductores);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonActores);
            this.Controls.Add(this.buttonEstudios);
            this.Controls.Add(this.buttonPeliculas);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDirectores;
        private System.Windows.Forms.Button buttonActores;
        private System.Windows.Forms.Button buttonPeliculas;
        private System.Windows.Forms.Button buttonProductores;
        private System.Windows.Forms.Button buttonEstudios;
        private System.Windows.Forms.TextBox textBoxBusqueda;
        private System.Windows.Forms.Button botonSalir;
        private System.Windows.Forms.ListBox listBoxWoa;
    }
}