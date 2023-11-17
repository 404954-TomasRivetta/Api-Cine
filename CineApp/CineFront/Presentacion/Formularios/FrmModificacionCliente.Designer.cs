namespace CineFront.Presentacion.Formularios
{
    partial class FrmModificacionCliente
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
            btnCancelar = new Button();
            btnModificar = new Button();
            SuspendLayout();
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(97, 200);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(207, 23);
            txtCorreo.TabIndex = 53;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(338, 204);
            label9.Name = "label9";
            label9.Size = new Size(27, 15);
            label9.TabIndex = 52;
            label9.Text = "DNI";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(310, 146);
            label8.Name = "label8";
            label8.Size = new Size(64, 17);
            label8.TabIndex = 51;
            label8.Text = "Nro. calle";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(34, 201);
            label7.Name = "label7";
            label7.Size = new Size(49, 17);
            label7.TabIndex = 50;
            label7.Text = "Correo";
            // 
            // cboBarrios
            // 
            cboBarrios.FormattingEnabled = true;
            cboBarrios.Location = new Point(380, 27);
            cboBarrios.Name = "cboBarrios";
            cboBarrios.Size = new Size(237, 23);
            cboBarrios.TabIndex = 49;
            // 
            // txtNroTel
            // 
            txtNroTel.Location = new Point(97, 144);
            txtNroTel.Name = "txtNroTel";
            txtNroTel.Size = new Size(207, 23);
            txtNroTel.TabIndex = 48;
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(380, 145);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(237, 23);
            txtAltura.TabIndex = 47;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(380, 201);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(237, 23);
            txtDni.TabIndex = 46;
            // 
            // txtCalle
            // 
            txtCalle.Location = new Point(380, 88);
            txtCalle.Name = "txtCalle";
            txtCalle.Size = new Size(237, 23);
            txtCalle.TabIndex = 45;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(97, 88);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(207, 23);
            txtApellido.TabIndex = 44;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(97, 32);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(207, 23);
            txtNombre.TabIndex = 43;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(329, 86);
            label6.Name = "label6";
            label6.Size = new Size(36, 17);
            label6.TabIndex = 42;
            label6.Text = "Calle";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(24, 150);
            label5.Name = "label5";
            label5.Size = new Size(58, 17);
            label5.TabIndex = 41;
            label5.Text = "Telefono";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(322, 28);
            label4.Name = "label4";
            label4.Size = new Size(43, 17);
            label4.TabIndex = 40;
            label4.Text = "Barrio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(25, 33);
            label3.Name = "label3";
            label3.Size = new Size(57, 17);
            label3.TabIndex = 39;
            label3.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(26, 89);
            label2.Name = "label2";
            label2.Size = new Size(56, 17);
            label2.TabIndex = 38;
            label2.Text = "Apellido";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(436, 283);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(135, 48);
            btnCancelar.TabIndex = 55;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(81, 283);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(132, 48);
            btnModificar.TabIndex = 54;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // FrmModificacionCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(671, 362);
            Controls.Add(btnCancelar);
            Controls.Add(btnModificar);
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
            Name = "FrmModificacionCliente";
            Text = "Modificar cliente";
            Load += FrmModificacionCliente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

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
        private Button btnCancelar;
        private Button btnModificar;
    }
}