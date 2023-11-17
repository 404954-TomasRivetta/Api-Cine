namespace CineFront.Presentacion.Formularios
{
    partial class FrmAltaComprobante
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
            label1 = new Label();
            btnAceptar = new Button();
            cboEmpleado = new ComboBox();
            cboFormasP = new ComboBox();
            label2 = new Label();
            cboClientes = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtCant = new TextBox();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(60, 15);
            label1.Name = "label1";
            label1.Size = new Size(222, 30);
            label1.TabIndex = 29;
            label1.Text = "Nuevo Comprobante";
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.LightSalmon;
            btnAceptar.FlatAppearance.BorderSize = 0;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAceptar.Location = new Point(42, 261);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(111, 37);
            btnAceptar.TabIndex = 25;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // cboEmpleado
            // 
            cboEmpleado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEmpleado.FormattingEnabled = true;
            cboEmpleado.Location = new Point(181, 164);
            cboEmpleado.Name = "cboEmpleado";
            cboEmpleado.Size = new Size(121, 23);
            cboEmpleado.TabIndex = 19;
            // 
            // cboFormasP
            // 
            cboFormasP.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFormasP.FormattingEnabled = true;
            cboFormasP.Location = new Point(181, 116);
            cboFormasP.Name = "cboFormasP";
            cboFormasP.Size = new Size(121, 23);
            cboFormasP.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(102, 73);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 30;
            label2.Text = "Cliente:";
            // 
            // cboClientes
            // 
            cboClientes.DropDownStyle = ComboBoxStyle.DropDownList;
            cboClientes.FormattingEnabled = true;
            cboClientes.Location = new Point(181, 70);
            cboClientes.Margin = new Padding(3, 2, 3, 2);
            cboClientes.Name = "cboClientes";
            cboClientes.Size = new Size(121, 23);
            cboClientes.TabIndex = 31;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 118);
            label3.Name = "label3";
            label3.Size = new Size(90, 15);
            label3.TabIndex = 32;
            label3.Text = "Forma de pago:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(83, 166);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 33;
            label4.Text = "Empleado:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 213);
            label5.Name = "label5";
            label5.Size = new Size(122, 15);
            label5.TabIndex = 34;
            label5.Text = "Cantidad de entradas:";
            // 
            // txtCant
            // 
            txtCant.Location = new Point(181, 213);
            txtCant.Margin = new Padding(3, 2, 3, 2);
            txtCant.Name = "txtCant";
            txtCant.Size = new Size(121, 23);
            txtCant.TabIndex = 35;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.LightSalmon;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.Location = new Point(181, 261);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(111, 37);
            btnCancelar.TabIndex = 36;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // FrmAltaComprobante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(345, 322);
            Controls.Add(btnCancelar);
            Controls.Add(txtCant);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cboClientes);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAceptar);
            Controls.Add(cboEmpleado);
            Controls.Add(cboFormasP);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmAltaComprobante";
            Text = "Alta Comprobante";
            Load += FrmAltaComprobante_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnAceptar;
        private ComboBox cboEmpleado;
        private ComboBox cboFormasP;
        private Label label2;
        private ComboBox cboClientes;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtCant;
        private Button btnCancelar;
    }
}