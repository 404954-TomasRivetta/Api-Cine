namespace prueba
{
    partial class FormMainMenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainMenu));
            panelMenu = new Panel();
            button2 = new Button();
            button1 = new Button();
            btnIntegrantes = new Button();
            BtnRutaDiaria = new Button();
            BtnServicios = new Button();
            btnCustomers = new Button();
            btnOrders = new Button();
            btnProducts = new Button();
            panelLogo = new Panel();
            label1 = new Label();
            panelTitleBar = new Panel();
            Btnsalir = new Button();
            btnCloseChildForm = new Button();
            lblTitle = new Label();
            panelDesktopPane = new Panel();
            LblSlogan = new Label();
            pictureBox1 = new PictureBox();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            panelTitleBar.SuspendLayout();
            panelDesktopPane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.White;
            panelMenu.Controls.Add(button2);
            panelMenu.Controls.Add(button1);
            panelMenu.Controls.Add(btnIntegrantes);
            panelMenu.Controls.Add(BtnRutaDiaria);
            panelMenu.Controls.Add(BtnServicios);
            panelMenu.Controls.Add(btnCustomers);
            panelMenu.Controls.Add(btnOrders);
            panelMenu.Controls.Add(btnProducts);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 684);
            panelMenu.TabIndex = 0;
            panelMenu.Paint += panelMenu_Paint;
            // 
            // button2
            // 
            button2.BackColor = Color.MediumTurquoise;
            button2.Dock = DockStyle.Bottom;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.Black;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(0, 538);
            button2.Name = "button2";
            button2.Size = new Size(220, 53);
            button2.TabIndex = 9;
            button2.Text = "Reporte Peliculas";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // button1
            // 
            button1.BackColor = Color.MediumTurquoise;
            button1.Dock = DockStyle.Bottom;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Black;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(0, 591);
            button1.Name = "button1";
            button1.Size = new Size(220, 43);
            button1.TabIndex = 8;
            button1.Text = "Reporte Generos";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_3;
            // 
            // btnIntegrantes
            // 
            btnIntegrantes.BackColor = Color.MediumTurquoise;
            btnIntegrantes.Dock = DockStyle.Bottom;
            btnIntegrantes.FlatAppearance.BorderSize = 0;
            btnIntegrantes.FlatStyle = FlatStyle.Flat;
            btnIntegrantes.ForeColor = Color.Black;
            btnIntegrantes.Image = (Image)resources.GetObject("btnIntegrantes.Image");
            btnIntegrantes.ImageAlign = ContentAlignment.MiddleLeft;
            btnIntegrantes.Location = new Point(0, 634);
            btnIntegrantes.Name = "btnIntegrantes";
            btnIntegrantes.Size = new Size(220, 50);
            btnIntegrantes.TabIndex = 7;
            btnIntegrantes.Text = "Integrantes";
            btnIntegrantes.TextAlign = ContentAlignment.MiddleLeft;
            btnIntegrantes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnIntegrantes.UseVisualStyleBackColor = false;
            btnIntegrantes.Click += button1_Click_2;
            // 
            // BtnRutaDiaria
            // 
            BtnRutaDiaria.BackColor = Color.MediumTurquoise;
            BtnRutaDiaria.Dock = DockStyle.Top;
            BtnRutaDiaria.FlatAppearance.BorderSize = 0;
            BtnRutaDiaria.FlatStyle = FlatStyle.Flat;
            BtnRutaDiaria.ForeColor = Color.Black;
            BtnRutaDiaria.Image = (Image)resources.GetObject("BtnRutaDiaria.Image");
            BtnRutaDiaria.ImageAlign = ContentAlignment.MiddleLeft;
            BtnRutaDiaria.Location = new Point(0, 474);
            BtnRutaDiaria.Name = "BtnRutaDiaria";
            BtnRutaDiaria.Size = new Size(220, 76);
            BtnRutaDiaria.TabIndex = 6;
            BtnRutaDiaria.Text = "Crear Comprobante";
            BtnRutaDiaria.TextAlign = ContentAlignment.MiddleLeft;
            BtnRutaDiaria.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnRutaDiaria.UseVisualStyleBackColor = false;
            BtnRutaDiaria.Click += button1_Click_1;
            // 
            // BtnServicios
            // 
            BtnServicios.BackColor = Color.MediumTurquoise;
            BtnServicios.Dock = DockStyle.Top;
            BtnServicios.FlatAppearance.BorderSize = 0;
            BtnServicios.FlatStyle = FlatStyle.Flat;
            BtnServicios.ForeColor = Color.Black;
            BtnServicios.Image = (Image)resources.GetObject("BtnServicios.Image");
            BtnServicios.ImageAlign = ContentAlignment.MiddleLeft;
            BtnServicios.Location = new Point(0, 414);
            BtnServicios.Name = "BtnServicios";
            BtnServicios.Size = new Size(220, 60);
            BtnServicios.TabIndex = 4;
            BtnServicios.Text = "   Consulta de Clientes";
            BtnServicios.TextAlign = ContentAlignment.MiddleLeft;
            BtnServicios.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnServicios.UseVisualStyleBackColor = false;
            BtnServicios.Click += BtnServicios_Click;
            // 
            // btnCustomers
            // 
            btnCustomers.BackColor = Color.MediumTurquoise;
            btnCustomers.Dock = DockStyle.Top;
            btnCustomers.FlatAppearance.BorderSize = 0;
            btnCustomers.FlatStyle = FlatStyle.Flat;
            btnCustomers.ForeColor = SystemColors.ActiveCaptionText;
            btnCustomers.Image = (Image)resources.GetObject("btnCustomers.Image");
            btnCustomers.ImageAlign = ContentAlignment.MiddleLeft;
            btnCustomers.Location = new Point(0, 354);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Size = new Size(220, 60);
            btnCustomers.TabIndex = 3;
            btnCustomers.Text = "   Consulta de Peliculas";
            btnCustomers.TextAlign = ContentAlignment.MiddleLeft;
            btnCustomers.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCustomers.UseVisualStyleBackColor = false;
            btnCustomers.Click += button2_Click;
            // 
            // btnOrders
            // 
            btnOrders.BackColor = Color.MediumTurquoise;
            btnOrders.Dock = DockStyle.Top;
            btnOrders.FlatAppearance.BorderSize = 0;
            btnOrders.FlatStyle = FlatStyle.Flat;
            btnOrders.ForeColor = Color.Black;
            btnOrders.Image = (Image)resources.GetObject("btnOrders.Image");
            btnOrders.ImageAlign = ContentAlignment.MiddleLeft;
            btnOrders.Location = new Point(0, 300);
            btnOrders.Name = "btnOrders";
            btnOrders.Size = new Size(220, 54);
            btnOrders.TabIndex = 2;
            btnOrders.Text = "Peliculas";
            btnOrders.TextAlign = ContentAlignment.MiddleLeft;
            btnOrders.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnOrders.UseVisualStyleBackColor = false;
            btnOrders.Click += button1_Click;
            // 
            // btnProducts
            // 
            btnProducts.BackColor = Color.MediumTurquoise;
            btnProducts.Dock = DockStyle.Top;
            btnProducts.FlatAppearance.BorderSize = 0;
            btnProducts.FlatStyle = FlatStyle.Flat;
            btnProducts.ForeColor = Color.Black;
            btnProducts.Image = (Image)resources.GetObject("btnProducts.Image");
            btnProducts.ImageAlign = ContentAlignment.MiddleLeft;
            btnProducts.Location = new Point(0, 240);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(220, 60);
            btnProducts.TabIndex = 1;
            btnProducts.Text = "     Clientes";
            btnProducts.TextAlign = ContentAlignment.MiddleLeft;
            btnProducts.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProducts.UseVisualStyleBackColor = false;
            btnProducts.Click += btnProducts_Click_1;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(255, 255, 192);
            panelLogo.BackgroundImage = (Image)resources.GetObject("panelLogo.BackgroundImage");
            panelLogo.Controls.Add(label1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.ForeColor = SystemColors.Desktop;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(220, 240);
            panelLogo.TabIndex = 0;
            panelLogo.Paint += panelLogo_Paint;
            panelLogo.MouseDown += panelLogo_MouseDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(42, 9);
            label1.Name = "label1";
            label1.Size = new Size(127, 25);
            label1.TabIndex = 1;
            label1.Text = "Cines Pato";
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.DarkSlateGray;
            panelTitleBar.Controls.Add(Btnsalir);
            panelTitleBar.Controls.Add(btnCloseChildForm);
            panelTitleBar.Controls.Add(lblTitle);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(220, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(881, 80);
            panelTitleBar.TabIndex = 1;
            panelTitleBar.Paint += panelTitleBar_Paint;
            panelTitleBar.MouseDown += panelTitleBar_MouseDown_1;
            // 
            // Btnsalir
            // 
            Btnsalir.Dock = DockStyle.Right;
            Btnsalir.FlatStyle = FlatStyle.Flat;
            Btnsalir.Image = (Image)resources.GetObject("Btnsalir.Image");
            Btnsalir.Location = new Point(806, 0);
            Btnsalir.Name = "Btnsalir";
            Btnsalir.Size = new Size(75, 80);
            Btnsalir.TabIndex = 2;
            Btnsalir.UseVisualStyleBackColor = true;
            Btnsalir.Click += Btnsalir_Click;
            // 
            // btnCloseChildForm
            // 
            btnCloseChildForm.Dock = DockStyle.Left;
            btnCloseChildForm.FlatStyle = FlatStyle.Flat;
            btnCloseChildForm.Image = (Image)resources.GetObject("btnCloseChildForm.Image");
            btnCloseChildForm.Location = new Point(0, 0);
            btnCloseChildForm.Name = "btnCloseChildForm";
            btnCloseChildForm.Size = new Size(75, 80);
            btnCloseChildForm.TabIndex = 1;
            btnCloseChildForm.UseVisualStyleBackColor = true;
            btnCloseChildForm.Click += btnCloseChildForm_Click_1;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = SystemColors.ButtonFace;
            lblTitle.Location = new Point(296, 30);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(68, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Inicio";
            // 
            // panelDesktopPane
            // 
            panelDesktopPane.Controls.Add(LblSlogan);
            panelDesktopPane.Controls.Add(pictureBox1);
            panelDesktopPane.Location = new Point(220, 80);
            panelDesktopPane.Name = "panelDesktopPane";
            panelDesktopPane.Size = new Size(881, 604);
            panelDesktopPane.TabIndex = 2;
            // 
            // LblSlogan
            // 
            LblSlogan.AutoSize = true;
            LblSlogan.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            LblSlogan.Location = new Point(372, 570);
            LblSlogan.Name = "LblSlogan";
            LblSlogan.Size = new Size(125, 25);
            LblSlogan.TabIndex = 1;
            LblSlogan.Text = "Cines pato";
            LblSlogan.Click += LblSlogan_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(887, 604);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // FormMainMenu
            // 
            ClientSize = new Size(1101, 684);
            Controls.Add(panelDesktopPane);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            ForeColor = SystemColors.Desktop;
            Name = "FormMainMenu";
            Load += FormMainMenu_Load;
            MouseDown += FormMainMenu_MouseDown;
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            panelDesktopPane.ResumeLayout(false);
            panelDesktopPane.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelDesktopPane;
        private System.Windows.Forms.Button btnCloseChildForm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LblSlogan;
        private System.Windows.Forms.Button BtnServicios;
        private System.Windows.Forms.Button Btnsalir;
        private System.Windows.Forms.Button BtnRutaDiaria;
        private Label label1;
        private Button btnIntegrantes;
        private Button button2;
        private Button button1;
    }
}

