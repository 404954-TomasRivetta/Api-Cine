using prueba;
using System.Runtime.InteropServices;

namespace CineFront.Presentacion.Formularios
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            btncerrar = new PictureBox();
            btnlogin = new Button();
            label1 = new Label();
            txtpass = new TextBox();
            txtuser = new TextBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)btncerrar).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btncerrar
            // 
            btncerrar.BackColor = Color.Black;
            btncerrar.Image = (Image)resources.GetObject("btncerrar.Image");
            btncerrar.Location = new Point(824, 45);
            btncerrar.Margin = new Padding(4, 3, 4, 3);
            btncerrar.Name = "btncerrar";
            btncerrar.Size = new Size(28, 29);
            btncerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btncerrar.TabIndex = 11;
            btncerrar.TabStop = false;
            btncerrar.Click += btncerrar_Click_1;
            // 
            // btnlogin
            // 
            btnlogin.BackColor = Color.FromArgb(40, 40, 40);
            btnlogin.FlatAppearance.BorderSize = 0;
            btnlogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnlogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnlogin.FlatStyle = FlatStyle.Flat;
            btnlogin.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnlogin.ForeColor = Color.LightGray;
            btnlogin.Location = new Point(358, 313);
            btnlogin.Margin = new Padding(4, 3, 4, 3);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(443, 46);
            btnlogin.TabIndex = 7;
            btnlogin.Text = "Acceder";
            btnlogin.UseVisualStyleBackColor = false;
            btnlogin.Click += btnlogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(379, 45);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(260, 38);
            label1.TabIndex = 10;
            label1.Text = "Entrada de Usuario";
            // 
            // txtpass
            // 
            txtpass.BackColor = Color.FromArgb(15, 15, 15);
            txtpass.BorderStyle = BorderStyle.None;
            txtpass.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtpass.ForeColor = Color.DimGray;
            txtpass.Location = new Point(379, 202);
            txtpass.Margin = new Padding(4, 3, 4, 3);
            txtpass.Name = "txtpass";
            txtpass.Size = new Size(304, 27);
            txtpass.TabIndex = 9;
            txtpass.Text = "Contraseña";
            txtpass.UseWaitCursor = true;
            txtpass.TextChanged += txtpass_TextChanged;
            txtpass.Enter += txtpass_Enter;
            txtpass.Leave += txtpass_Leave;
            // 
            // txtuser
            // 
            txtuser.BackColor = Color.FromArgb(15, 15, 15);
            txtuser.BorderStyle = BorderStyle.None;
            txtuser.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtuser.ForeColor = Color.DimGray;
            txtuser.Location = new Point(379, 139);
            txtuser.Margin = new Padding(4, 3, 4, 3);
            txtuser.Name = "txtuser";
            txtuser.Size = new Size(304, 27);
            txtuser.TabIndex = 8;
            txtuser.Text = "Usuario";
            txtuser.UseWaitCursor = true;
            txtuser.TextChanged += textBox1_TextChanged;
            txtuser.Enter += txtuser_Enter;
            txtuser.Leave += txtuser_Leave;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 255, 128);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(274, 385);
            panel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._a933ab13_2d6e_43f7_bc4e_ac1c74111c0c2;
            pictureBox1.Location = new Point(0, 45);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(274, 252);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(903, 385);
            Controls.Add(btncerrar);
            Controls.Add(btnlogin);
            Controls.Add(label1);
            Controls.Add(txtpass);
            Controls.Add(txtuser);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmLogin";
            Opacity = 0.85D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "form";
            Load += form_Load;
            MouseDown += LOGIN_MouseDown;
            ((System.ComponentModel.ISupportInitialize)btncerrar).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox btncerrar;
        private Button btnlogin;
        private Label label1;
        private TextBox txtpass;
        private TextBox txtuser;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}