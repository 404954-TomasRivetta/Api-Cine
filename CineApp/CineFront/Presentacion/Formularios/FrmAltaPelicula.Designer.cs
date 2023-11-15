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
            txtDescripcion = new TextBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            rbtSi = new RadioButton();
            rbtNo = new RadioButton();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            btnDescripcion = new Button();
            button5 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // cboDirectores
            // 
            cboDirectores.FormattingEnabled = true;
            cboDirectores.Location = new Point(140, 121);
            cboDirectores.Name = "cboDirectores";
            cboDirectores.Size = new Size(121, 23);
            cboDirectores.TabIndex = 2;
            // 
            // cboIdioma
            // 
            cboIdioma.FormattingEnabled = true;
            cboIdioma.Location = new Point(140, 169);
            cboIdioma.Name = "cboIdioma";
            cboIdioma.Size = new Size(121, 23);
            cboIdioma.TabIndex = 3;
            // 
            // cboTipoPublico
            // 
            cboTipoPublico.FormattingEnabled = true;
            cboTipoPublico.Location = new Point(140, 262);
            cboTipoPublico.Name = "cboTipoPublico";
            cboTipoPublico.Size = new Size(121, 23);
            cboTipoPublico.TabIndex = 4;
            // 
            // cboTipoPelicula
            // 
            cboTipoPelicula.FormattingEnabled = true;
            cboTipoPelicula.Location = new Point(140, 216);
            cboTipoPelicula.Name = "cboTipoPelicula";
            cboTipoPelicula.Size = new Size(121, 23);
            cboTipoPelicula.TabIndex = 5;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(140, 73);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(121, 23);
            txtDescripcion.TabIndex = 8;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(12, 366);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(111, 23);
            btnAceptar.TabIndex = 9;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(158, 366);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(111, 23);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // rbtSi
            // 
            rbtSi.AutoSize = true;
            rbtSi.Location = new Point(140, 311);
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
            rbtNo.Location = new Point(191, 311);
            rbtNo.Name = "rbtNo";
            rbtNo.Size = new Size(41, 19);
            rbtNo.TabIndex = 12;
            rbtNo.TabStop = true;
            rbtNo.Text = "No";
            rbtNo.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(2, 121);
            button1.Name = "button1";
            button1.Size = new Size(134, 23);
            button1.TabIndex = 0;
            button1.Text = "Director";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(2, 216);
            button2.Name = "button2";
            button2.Size = new Size(134, 23);
            button2.TabIndex = 1;
            button2.Text = "Tipo de Pelicula";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(2, 262);
            button3.Name = "button3";
            button3.Size = new Size(134, 23);
            button3.TabIndex = 2;
            button3.Text = "Tipo de Publico";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(2, 169);
            button4.Name = "button4";
            button4.Size = new Size(134, 23);
            button4.TabIndex = 3;
            button4.Text = "Idioma";
            button4.UseVisualStyleBackColor = true;
            // 
            // btnDescripcion
            // 
            btnDescripcion.Location = new Point(2, 72);
            btnDescripcion.Name = "btnDescripcion";
            btnDescripcion.Size = new Size(134, 23);
            btnDescripcion.TabIndex = 4;
            btnDescripcion.Text = "Nombre";
            btnDescripcion.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(2, 307);
            button5.Name = "button5";
            button5.Size = new Size(134, 23);
            button5.TabIndex = 5;
            button5.Text = "Subtitulada";
            button5.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(22, 12);
            label1.Name = "label1";
            label1.Size = new Size(114, 21);
            label1.TabIndex = 13;
            label1.Text = "Nueva Pelicula";
            // 
            // FrmAltaPelicula
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(281, 399);
            Controls.Add(label1);
            Controls.Add(button5);
            Controls.Add(rbtNo);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(btnDescripcion);
            Controls.Add(rbtSi);
            Controls.Add(btnCancelar);
            Controls.Add(button1);
            Controls.Add(btnAceptar);
            Controls.Add(txtDescripcion);
            Controls.Add(cboTipoPelicula);
            Controls.Add(cboTipoPublico);
            Controls.Add(cboIdioma);
            Controls.Add(cboDirectores);
            Name = "FrmAltaPelicula";
            Text = "Peliculas";
            Load += FrmAltaPelicula_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cboDirectores;
        private ComboBox cboIdioma;
        private ComboBox cboTipoPublico;
        private ComboBox cboTipoPelicula;
        private TextBox txtDescripcion;
        private Button btnAceptar;
        private Button btnCancelar;
        private RadioButton rbtSi;
        private RadioButton rbtNo;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button btnDescripcion;
        private Button button5;
        private Label label1;
    }
}