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
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // cboDirectores
            // 
            cboDirectores.FormattingEnabled = true;
            cboDirectores.Location = new Point(530, 275);
            cboDirectores.Name = "cboDirectores";
            cboDirectores.Size = new Size(121, 23);
            cboDirectores.TabIndex = 2;
            // 
            // cboIdioma
            // 
            cboIdioma.FormattingEnabled = true;
            cboIdioma.Location = new Point(530, 339);
            cboIdioma.Name = "cboIdioma";
            cboIdioma.Size = new Size(121, 23);
            cboIdioma.TabIndex = 3;
            // 
            // cboTipoPublico
            // 
            cboTipoPublico.FormattingEnabled = true;
            cboTipoPublico.Location = new Point(530, 467);
            cboTipoPublico.Name = "cboTipoPublico";
            cboTipoPublico.Size = new Size(121, 23);
            cboTipoPublico.TabIndex = 4;
            // 
            // cboTipoPelicula
            // 
            cboTipoPelicula.FormattingEnabled = true;
            cboTipoPelicula.Location = new Point(530, 404);
            cboTipoPelicula.Name = "cboTipoPelicula";
            cboTipoPelicula.Size = new Size(121, 23);
            cboTipoPelicula.TabIndex = 5;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(530, 205);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(121, 23);
            txtDescripcion.TabIndex = 8;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(310, 614);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(121, 36);
            btnAceptar.TabIndex = 9;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(517, 614);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(121, 36);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // rbtSi
            // 
            rbtSi.AutoSize = true;
            rbtSi.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            rbtSi.Location = new Point(530, 527);
            rbtSi.Name = "rbtSi";
            rbtSi.Size = new Size(45, 29);
            rbtSi.TabIndex = 11;
            rbtSi.TabStop = true;
            rbtSi.Text = "Si";
            rbtSi.UseVisualStyleBackColor = true;
            rbtSi.CheckedChanged += rbtSi_CheckedChanged;
            // 
            // rbtNo
            // 
            rbtNo.AutoSize = true;
            rbtNo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            rbtNo.Location = new Point(596, 527);
            rbtNo.Name = "rbtNo";
            rbtNo.Size = new Size(55, 29);
            rbtNo.TabIndex = 12;
            rbtNo.TabStop = true;
            rbtNo.Text = "No";
            rbtNo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(412, 123);
            label1.Name = "label1";
            label1.Size = new Size(157, 30);
            label1.TabIndex = 13;
            label1.Text = "Nueva Pelicula";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(400, 205);
            label3.Name = "label3";
            label3.Size = new Size(85, 25);
            label3.TabIndex = 43;
            label3.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(375, 531);
            label2.Name = "label2";
            label2.Size = new Size(112, 25);
            label2.TabIndex = 44;
            label2.Text = "Subtitulada:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(338, 467);
            label4.Name = "label4";
            label4.Size = new Size(147, 25);
            label4.TabIndex = 45;
            label4.Text = "Tipo de Publico:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(338, 402);
            label5.Name = "label5";
            label5.Size = new Size(149, 25);
            label5.TabIndex = 46;
            label5.Text = "Tipo de Pelicula:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(403, 273);
            label6.Name = "label6";
            label6.Size = new Size(84, 25);
            label6.TabIndex = 47;
            label6.Text = "Director:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(413, 339);
            label7.Name = "label7";
            label7.Size = new Size(74, 25);
            label7.TabIndex = 48;
            label7.Text = "Idioma:";
            // 
            // FrmAltaPelicula
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1101, 684);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(rbtNo);
            Controls.Add(rbtSi);
            Controls.Add(btnCancelar);
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
        private Label label1;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}