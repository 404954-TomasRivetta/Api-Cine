namespace CineFront.Presentacion.Formularios
{
    partial class FrmAltaCliente
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
<<<<<<< HEAD
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAltaCliente));
            btnCancelar = new Button();
            btnAceptar = new Button();
            txtCorreo = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            cboBarrios = new ComboBox();
            txtNroTel = new TextBox();
            txtAltura = new TextBox();
            txtDni = new TextBox();
            txtCalle = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Black;
            btnCancelar.ForeColor = SystemColors.ButtonFace;
            btnCancelar.Location = new Point(467, 506);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(108, 36);
            btnCancelar.TabIndex = 58;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.Black;
            btnAceptar.ForeColor = SystemColors.ButtonFace;
            btnAceptar.Location = new Point(269, 506);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(108, 36);
            btnAceptar.TabIndex = 57;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // txtCorreo
            // 
            txtCorreo.BackColor = Color.Gray;
            txtCorreo.Location = new Point(380, 206);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(100, 23);
            txtCorreo.TabIndex = 56;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Black;
            label9.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ButtonFace;
            label9.Location = new Point(309, 400);
            label9.Name = "label9";
            label9.Size = new Size(48, 25);
            label9.TabIndex = 55;
            label9.Text = "DNI:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Black;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ButtonFace;
            label8.Location = new Point(290, 351);
            label8.Name = "label8";
            label8.Size = new Size(67, 25);
            label8.TabIndex = 54;
            label8.Text = "Altura:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Black;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(280, 201);
            label7.Name = "label7";
            label7.Size = new Size(74, 25);
            label7.TabIndex = 53;
            label7.Text = "Correo:";
            // 
            // cboBarrios
            // 
            cboBarrios.BackColor = Color.Gray;
            cboBarrios.FormattingEnabled = true;
            cboBarrios.Location = new Point(380, 257);
            cboBarrios.Name = "cboBarrios";
            cboBarrios.Size = new Size(285, 23);
            cboBarrios.TabIndex = 52;
            // 
            // txtNroTel
            // 
            txtNroTel.BackColor = Color.Gray;
            txtNroTel.Location = new Point(380, 161);
            txtNroTel.Name = "txtNroTel";
            txtNroTel.Size = new Size(112, 23);
            txtNroTel.TabIndex = 51;
            // 
            // txtAltura
            // 
            txtAltura.BackColor = Color.Gray;
            txtAltura.Location = new Point(380, 356);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(93, 23);
            txtAltura.TabIndex = 50;
            // 
            // txtDni
            // 
            txtDni.BackColor = Color.Gray;
            txtDni.Location = new Point(380, 405);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(123, 23);
            txtDni.TabIndex = 49;
            // 
            // txtCalle
            // 
            txtCalle.BackColor = Color.Gray;
            txtCalle.Location = new Point(380, 308);
            txtCalle.Name = "txtCalle";
            txtCalle.Size = new Size(285, 23);
            txtCalle.TabIndex = 48;
            // 
            // txtApellido
            // 
            txtApellido.BackColor = Color.Gray;
            txtApellido.Location = new Point(380, 115);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(207, 23);
            txtApellido.TabIndex = 47;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.Gray;
            txtNombre.ForeColor = SystemColors.ButtonFace;
            txtNombre.Location = new Point(380, 60);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(207, 23);
            txtNombre.TabIndex = 46;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Black;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(297, 303);
            label6.Name = "label6";
            label6.Size = new Size(58, 25);
            label6.TabIndex = 45;
            label6.Text = "Calle:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Black;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(269, 156);
            label5.Name = "label5";
            label5.Size = new Size(88, 25);
            label5.TabIndex = 44;
            label5.Text = "Telefono:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Black;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(287, 252);
            label4.Name = "label4";
            label4.Size = new Size(67, 25);
            label4.TabIndex = 43;
            label4.Text = "Barrio:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Black;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(269, 58);
            label3.Name = "label3";
            label3.Size = new Size(85, 25);
            label3.TabIndex = 42;
            label3.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(269, 110);
            label2.Name = "label2";
            label2.Size = new Size(86, 25);
            label2.TabIndex = 41;
            label2.Text = "Apellido:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Unispace", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(80, 9);
            label1.Name = "label1";
            label1.Size = new Size(208, 29);
            label1.TabIndex = 40;
            label1.Text = "NUEVO CLIENTE";
=======
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cboBarrios = new System.Windows.Forms.ComboBox();
            this.txtNroTel = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(339, 543);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(113, 31);
            this.btnCancelar.TabIndex = 58;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(79, 543);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(113, 31);
            this.btnAceptar.TabIndex = 57;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(127, 237);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(114, 27);
            this.txtCorreo.TabIndex = 56;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(79, 468);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 20);
            this.label9.TabIndex = 55;
            this.label9.Text = "DNI";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(62, 411);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 23);
            this.label8.TabIndex = 54;
            this.label8.Text = "Altura";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(55, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 23);
            this.label7.TabIndex = 53;
            this.label7.Text = "Correo";
            // 
            // cboBarrios
            // 
            this.cboBarrios.FormattingEnabled = true;
            this.cboBarrios.Location = new System.Drawing.Point(127, 295);
            this.cboBarrios.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboBarrios.Name = "cboBarrios";
            this.cboBarrios.Size = new System.Drawing.Size(325, 28);
            this.cboBarrios.TabIndex = 52;
            // 
            // txtNroTel
            // 
            this.txtNroTel.Location = new System.Drawing.Point(127, 183);
            this.txtNroTel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNroTel.Name = "txtNroTel";
            this.txtNroTel.Size = new System.Drawing.Size(127, 27);
            this.txtNroTel.TabIndex = 51;
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(127, 409);
            this.txtAltura.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(106, 27);
            this.txtAltura.TabIndex = 50;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(127, 464);
            this.txtDni.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(140, 27);
            this.txtDni.TabIndex = 49;
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(127, 351);
            this.txtCalle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(325, 27);
            this.txtCalle.TabIndex = 48;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(127, 129);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(236, 27);
            this.txtApellido.TabIndex = 47;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(127, 76);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(236, 27);
            this.txtNombre.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(69, 352);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 23);
            this.label6.TabIndex = 45;
            this.label6.Text = "Calle";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(43, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 23);
            this.label5.TabIndex = 44;
            this.label5.Text = "Telefono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(61, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 23);
            this.label4.TabIndex = 43;
            this.label4.Text = "Barrio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(45, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 23);
            this.label3.TabIndex = 42;
            this.label3.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(46, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 23);
            this.label2.TabIndex = 41;
            this.label2.Text = "Apellido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(14, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 28);
            this.label1.TabIndex = 40;
            this.label1.Text = "NUEVO CLIENTE";
>>>>>>> f4cf6cf7b06d82b0446dc4567daf204543900e4a
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(884, 616);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 59;
            pictureBox1.TabStop = false;
            // 
            // FrmAltaCliente
            // 
<<<<<<< HEAD
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(865, 562);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txtCorreo);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(cboBarrios);
            Controls.Add(txtNroTel);
            Controls.Add(txtAltura);
            Controls.Add(txtDni);
            Controls.Add(txtCalle);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Name = "FrmAltaCliente";
            Text = "FrmAltaCliente";
            Load += FrmAltaCliente_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
=======
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 603);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cboBarrios);
            this.Controls.Add(this.txtNroTel);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.txtCalle);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmAltaCliente";
            this.Text = "FrmAltaCliente";
            this.Load += new System.EventHandler(this.FrmAltaCliente_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

>>>>>>> f4cf6cf7b06d82b0446dc4567daf204543900e4a
        }

        #endregion

        private Button btnCancelar;
        private Button btnAceptar;
        private TextBox txtCorreo;
        private Label label9;
        private Label label8;
        private Label label7;
        private ComboBox cboBarrios;
        private TextBox txtNroTel;
        private TextBox txtAltura;
        private TextBox txtDni;
        private TextBox txtCalle;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
    }
}