namespace CineFront.Presentacion.Formularios
{
    partial class FrmAltaPelicula
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
            cboDirectores = new ComboBox();
            cboIdioma = new ComboBox();
            cboTipoPublico = new ComboBox();
            cboTipoPelicula = new ComboBox();
            panel1 = new Panel();
            btnDescripcion = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel2 = new Panel();
            txtDescripcion = new TextBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            rbtSi = new RadioButton();
            rbtNo = new RadioButton();
            button5 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // cboDirectores
            // 
            cboDirectores.FormattingEnabled = true;
            cboDirectores.Location = new Point(140, 170);
            cboDirectores.Name = "cboDirectores";
            cboDirectores.Size = new Size(121, 23);
            cboDirectores.TabIndex = 2;
            // 
            // cboIdioma
            // 
            cboIdioma.FormattingEnabled = true;
            cboIdioma.Location = new Point(140, 212);
            cboIdioma.Name = "cboIdioma";
            cboIdioma.Size = new Size(121, 23);
            cboIdioma.TabIndex = 3;
            // 
            // cboTipoPublico
            // 
            cboTipoPublico.FormattingEnabled = true;
            cboTipoPublico.Location = new Point(140, 301);
            cboTipoPublico.Name = "cboTipoPublico";
            cboTipoPublico.Size = new Size(121, 23);
            cboTipoPublico.TabIndex = 4;
            // 
            // cboTipoPelicula
            // 
            cboTipoPelicula.FormattingEnabled = true;
            cboTipoPelicula.Location = new Point(140, 256);
            cboTipoPelicula.Name = "cboTipoPelicula";
            cboTipoPelicula.Size = new Size(121, 23);
            cboTipoPelicula.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(11, 7, 17);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(btnDescripcion);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(121, 449);
            panel1.TabIndex = 6;
            // 
            // btnDescripcion
            // 
            btnDescripcion.Location = new Point(-3, 125);
            btnDescripcion.Name = "btnDescripcion";
            btnDescripcion.Size = new Size(134, 23);
            btnDescripcion.TabIndex = 4;
            btnDescripcion.Text = "Nombre";
            btnDescripcion.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(0, 212);
            button4.Name = "button4";
            button4.Size = new Size(134, 23);
            button4.TabIndex = 3;
            button4.Text = "Idioma";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(0, 301);
            button3.Name = "button3";
            button3.Size = new Size(134, 23);
            button3.TabIndex = 2;
            button3.Text = "Tipo de Publico";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(0, 256);
            button2.Name = "button2";
            button2.Size = new Size(134, 23);
            button2.TabIndex = 1;
            button2.Text = "Tipo de Pelicula";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(0, 169);
            button1.Name = "button1";
            button1.Size = new Size(134, 23);
            button1.TabIndex = 0;
            button1.Text = "Director";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(11, 7, 17);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(121, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(364, 100);
            panel2.TabIndex = 7;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(140, 125);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(121, 23);
            txtDescripcion.TabIndex = 8;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(136, 398);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(111, 23);
            btnAceptar.TabIndex = 9;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(268, 398);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(111, 23);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // rbtSi
            // 
            rbtSi.AutoSize = true;
            rbtSi.Location = new Point(141, 344);
            rbtSi.Name = "rbtSi";
            rbtSi.Size = new Size(34, 19);
            rbtSi.TabIndex = 11;
            rbtSi.TabStop = true;
            rbtSi.Text = "Si";
            rbtSi.UseVisualStyleBackColor = true;
            rbtSi.CheckedChanged += rbtSi_CheckedChanged;
            // 
            // rbtNo
            // 
            rbtNo.AutoSize = true;
            rbtNo.Location = new Point(181, 344);
            rbtNo.Name = "rbtNo";
            rbtNo.Size = new Size(41, 19);
            rbtNo.TabIndex = 12;
            rbtNo.TabStop = true;
            rbtNo.Text = "No";
            rbtNo.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(-3, 340);
            button5.Name = "button5";
            button5.Size = new Size(134, 23);
            button5.TabIndex = 5;
            button5.Text = "Subtitulada";
            button5.UseVisualStyleBackColor = true;
            // 
            // FrmAltaPelicula
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(485, 449);
            Controls.Add(rbtNo);
            Controls.Add(rbtSi);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txtDescripcion);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(cboTipoPelicula);
            Controls.Add(cboTipoPublico);
            Controls.Add(cboIdioma);
            Controls.Add(cboDirectores);
            Name = "FrmAltaPelicula";
            Text = "Peliculas";
            Load += FrmAltaPelicula_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cboDirectores;
        private ComboBox cboIdioma;
        private ComboBox cboTipoPublico;
        private ComboBox cboTipoPelicula;
        private Panel panel1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Panel panel2;
        private Button btnDescripcion;
        private TextBox txtDescripcion;
        private Button btnAceptar;
        private Button btnCancelar;
        private Button button5;
        private RadioButton rbtSi;
        private RadioButton rbtNo;
    }
}