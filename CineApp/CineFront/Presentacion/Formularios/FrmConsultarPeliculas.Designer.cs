namespace CineFront.Presentacion.Formularios
{
    partial class FrmConsultarPeliculas
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
            btnEditar = new Button();
            btnEliminar = new Button();
            btnSalir = new Button();
            grpFiltros = new GroupBox();
            label3 = new Label();
            cboIdioma = new ComboBox();
            cboPublico = new ComboBox();
            label2 = new Label();
            cboGenero = new ComboBox();
            label1 = new Label();
            btnConsultar = new Button();
            dataGridView1 = new DataGridView();
            grpFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(25, 386);
            btnEditar.Margin = new Padding(4, 3, 4, 3);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(136, 35);
            btnEditar.TabIndex = 13;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(192, 386);
            btnEliminar.Margin = new Padding(4, 3, 4, 3);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(136, 35);
            btnEliminar.TabIndex = 14;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(639, 386);
            btnSalir.Margin = new Padding(4, 3, 4, 3);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(136, 35);
            btnSalir.TabIndex = 15;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // grpFiltros
            // 
            grpFiltros.Controls.Add(label3);
            grpFiltros.Controls.Add(cboIdioma);
            grpFiltros.Controls.Add(cboPublico);
            grpFiltros.Controls.Add(label2);
            grpFiltros.Controls.Add(cboGenero);
            grpFiltros.Controls.Add(label1);
            grpFiltros.Controls.Add(btnConsultar);
            grpFiltros.Location = new Point(25, 30);
            grpFiltros.Margin = new Padding(4, 3, 4, 3);
            grpFiltros.Name = "grpFiltros";
            grpFiltros.Padding = new Padding(4, 3, 4, 3);
            grpFiltros.Size = new Size(750, 122);
            grpFiltros.TabIndex = 12;
            grpFiltros.TabStop = false;
            grpFiltros.Text = "Filtros";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(403, 30);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 21;
            label3.Text = "Idioma: ";
            // 
            // cboIdioma
            // 
            cboIdioma.FormattingEnabled = true;
            cboIdioma.Location = new Point(460, 27);
            cboIdioma.Name = "cboIdioma";
            cboIdioma.Size = new Size(121, 23);
            cboIdioma.TabIndex = 20;
            // 
            // cboPublico
            // 
            cboPublico.FormattingEnabled = true;
            cboPublico.Location = new Point(260, 27);
            cboPublico.Name = "cboPublico";
            cboPublico.Size = new Size(121, 23);
            cboPublico.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(201, 30);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 17;
            label2.Text = "Publico: ";
            // 
            // cboGenero
            // 
            cboGenero.FormattingEnabled = true;
            cboGenero.Location = new Point(64, 27);
            cboGenero.Name = "cboGenero";
            cboGenero.Size = new Size(121, 23);
            cboGenero.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 30);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 17;
            label1.Text = "Genero: ";
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(607, 72);
            btnConsultar.Margin = new Padding(4, 3, 4, 3);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(136, 35);
            btnConsultar.TabIndex = 1;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(25, 172);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(750, 150);
            dataGridView1.TabIndex = 16;
            // 
            // FrmConsultarPeliculas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(btnEditar);
            Controls.Add(btnEliminar);
            Controls.Add(btnSalir);
            Controls.Add(grpFiltros);
            Name = "FrmConsultarPeliculas";
            Text = "Consulta de Peliculas";
            Load += FrmConsultarPeliculas_Load;
            grpFiltros.ResumeLayout(false);
            grpFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnEditar;
        private Button btnEliminar;
        private Button btnSalir;
        private GroupBox grpFiltros;
        private Button btnConsultar;
        private DataGridView dataGridView1;
        private Label label3;
        private ComboBox cboIdioma;
        private ComboBox cboPublico;
        private Label label2;
        private ComboBox cboGenero;
        private Label label1;
    }
}