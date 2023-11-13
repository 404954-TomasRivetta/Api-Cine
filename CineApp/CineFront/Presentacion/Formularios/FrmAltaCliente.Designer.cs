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
            dgvClientes = new DataGridView();
            btnAgregar = new Button();
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
            ColNombre = new DataGridViewTextBoxColumn();
            ColApellido = new DataGridViewTextBoxColumn();
            ColTelefono = new DataGridViewTextBoxColumn();
            ColCorreo = new DataGridViewTextBoxColumn();
            ColCodBarrio = new DataGridViewTextBoxColumn();
            ColBarrio = new DataGridViewTextBoxColumn();
            ColCalle = new DataGridViewTextBoxColumn();
            ColAltura = new DataGridViewTextBoxColumn();
            ColDni = new DataGridViewTextBoxColumn();
            ColAcciones = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToDeleteRows = false;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Columns.AddRange(new DataGridViewColumn[] { ColNombre, ColApellido, ColTelefono, ColCorreo, ColCodBarrio, ColBarrio, ColCalle, ColAltura, ColDni, ColAcciones });
            dgvClientes.Location = new Point(7, 380);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.RowTemplate.Height = 25;
            dgvClientes.Size = new Size(499, 163);
            dgvClientes.TabIndex = 41;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(364, 351);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 40;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(262, 549);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(99, 23);
            btnCancelar.TabIndex = 39;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(121, 549);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(99, 23);
            btnAceptar.TabIndex = 38;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(154, 179);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(100, 23);
            txtCorreo.TabIndex = 37;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(112, 352);
            label9.Name = "label9";
            label9.Size = new Size(27, 15);
            label9.TabIndex = 36;
            label9.Text = "DNI";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(97, 309);
            label8.Name = "label8";
            label8.Size = new Size(42, 17);
            label8.TabIndex = 35;
            label8.Text = "Altura";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(91, 180);
            label7.Name = "label7";
            label7.Size = new Size(49, 17);
            label7.TabIndex = 34;
            label7.Text = "Correo";
            // 
            // cboBarrios
            // 
            cboBarrios.FormattingEnabled = true;
            cboBarrios.Location = new Point(154, 222);
            cboBarrios.Name = "cboBarrios";
            cboBarrios.Size = new Size(285, 23);
            cboBarrios.TabIndex = 33;
            // 
            // txtNroTel
            // 
            txtNroTel.Location = new Point(154, 138);
            txtNroTel.Name = "txtNroTel";
            txtNroTel.Size = new Size(112, 23);
            txtNroTel.TabIndex = 32;
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(154, 308);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(93, 23);
            txtAltura.TabIndex = 31;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(154, 349);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(123, 23);
            txtDni.TabIndex = 30;
            // 
            // txtCalle
            // 
            txtCalle.Location = new Point(154, 264);
            txtCalle.Name = "txtCalle";
            txtCalle.Size = new Size(285, 23);
            txtCalle.TabIndex = 29;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(154, 98);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(207, 23);
            txtApellido.TabIndex = 28;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(154, 58);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(207, 23);
            txtNombre.TabIndex = 27;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(103, 265);
            label6.Name = "label6";
            label6.Size = new Size(36, 17);
            label6.TabIndex = 26;
            label6.Text = "Calle";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(81, 144);
            label5.Name = "label5";
            label5.Size = new Size(58, 17);
            label5.TabIndex = 25;
            label5.Text = "Telefono";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(96, 223);
            label4.Name = "label4";
            label4.Size = new Size(43, 17);
            label4.TabIndex = 24;
            label4.Text = "Barrio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(82, 59);
            label3.Name = "label3";
            label3.Size = new Size(57, 17);
            label3.TabIndex = 23;
            label3.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(83, 99);
            label2.Name = "label2";
            label2.Size = new Size(56, 17);
            label2.TabIndex = 22;
            label2.Text = "Apellido";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(13, 9);
            label1.Name = "label1";
            label1.Size = new Size(134, 21);
            label1.TabIndex = 21;
            label1.Text = "NUEVO CLIENTE";
            // 
            // ColNombre
            // 
            ColNombre.HeaderText = "Nombre";
            ColNombre.Name = "ColNombre";
            ColNombre.ReadOnly = true;
            // 
            // ColApellido
            // 
            ColApellido.HeaderText = "Apellido";
            ColApellido.Name = "ColApellido";
            ColApellido.ReadOnly = true;
            // 
            // ColTelefono
            // 
            ColTelefono.HeaderText = "Telefono";
            ColTelefono.Name = "ColTelefono";
            ColTelefono.ReadOnly = true;
            // 
            // ColCorreo
            // 
            ColCorreo.HeaderText = "Correo";
            ColCorreo.Name = "ColCorreo";
            ColCorreo.ReadOnly = true;
            // 
            // ColCodBarrio
            // 
            ColCodBarrio.HeaderText = "Cod. Barrio";
            ColCodBarrio.Name = "ColCodBarrio";
            ColCodBarrio.ReadOnly = true;
            ColCodBarrio.Visible = false;
            // 
            // ColBarrio
            // 
            ColBarrio.HeaderText = "Barrio";
            ColBarrio.Name = "ColBarrio";
            ColBarrio.ReadOnly = true;
            // 
            // ColCalle
            // 
            ColCalle.HeaderText = "Calle";
            ColCalle.Name = "ColCalle";
            ColCalle.ReadOnly = true;
            // 
            // ColAltura
            // 
            ColAltura.HeaderText = "Altura";
            ColAltura.Name = "ColAltura";
            ColAltura.ReadOnly = true;
            // 
            // ColDni
            // 
            ColDni.HeaderText = "Dni";
            ColDni.Name = "ColDni";
            ColDni.ReadOnly = true;
            // 
            // ColAcciones
            // 
            ColAcciones.HeaderText = "Quitar";
            ColAcciones.Name = "ColAcciones";
            ColAcciones.ReadOnly = true;
            ColAcciones.Visible = false;
            // 
            // FrmAltaCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(518, 621);
            Controls.Add(dgvClientes);
            Controls.Add(btnAgregar);
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
            Controls.Add(label1);
            Name = "FrmAltaCliente";
            Text = "FrmAltaCliente2";
            Load += FrmAltaCliente_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvClientes;
        private Button btnAgregar;
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
        private DataGridViewTextBoxColumn ColNombre;
        private DataGridViewTextBoxColumn ColApellido;
        private DataGridViewTextBoxColumn ColTelefono;
        private DataGridViewTextBoxColumn ColCorreo;
        private DataGridViewTextBoxColumn ColCodBarrio;
        private DataGridViewTextBoxColumn ColBarrio;
        private DataGridViewTextBoxColumn ColCalle;
        private DataGridViewTextBoxColumn ColAltura;
        private DataGridViewTextBoxColumn ColDni;
        private DataGridViewButtonColumn ColAcciones;
    }
}