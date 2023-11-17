using CineBack.Entidades;
using CineFront.Servicio;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CineFront.Presentacion.Formularios
{
    public partial class FrmModificacionPelicula : Form
    {
        Pelicula peli;
        public FrmModificacionPelicula()
        {
            InitializeComponent();
            peli = new Pelicula();
        }

        private async void FrmModificacionPelicula_Load(object sender, EventArgs e)
        {
            await CargarDirectoresAsync();
            await CargarTipoPublicoAsync();
            await CargarTipoPelicula();
            await CargarIdioma();
        }
        private async Task CargarDirectoresAsync()
        {
            string url = "https://localhost:7149/directores";
            var dataJson = await ClienteSingleton.GetInstance().GetAsync(url);
            List<Director> lDirectores = JsonConvert.DeserializeObject<List<Director>>(dataJson);
            cboDirectores.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDirectores.DataSource = lDirectores;
            cboDirectores.ValueMember = "IdDirector";
            cboDirectores.DisplayMember = "Nombre";
        }
        private async Task CargarTipoPublicoAsync()
        {
            string url = "https://localhost:7149/tipos_publico";
            var dataJson = await ClienteSingleton.GetInstance().GetAsync(url);
            List<TipoPublico> lTiposPublico = JsonConvert.DeserializeObject<List<TipoPublico>>(dataJson);
            cboTipoPublico.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoPublico.DataSource = lTiposPublico;
            cboTipoPublico.ValueMember = "IdTipoPublico";
            cboTipoPublico.DisplayMember = "Descripcion";
        }
        private async Task CargarTipoPelicula()
        {
            string url = "https://localhost:7149/tipos_pelicula";
            var dataJson = await ClienteSingleton.GetInstance().GetAsync(url);
            List<TipoPelicula> lPeliculas = JsonConvert.DeserializeObject<List<TipoPelicula>>(dataJson);
            cboTipoPelicula.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoPelicula.DataSource = lPeliculas;
            cboTipoPelicula.ValueMember = "IdTipoPelicula";
            cboTipoPelicula.DisplayMember = "Descripcion";
        }
        private async Task CargarIdioma()
        {
            string url = "https://localhost:7149/dialectos";
            var dataJson = await ClienteSingleton.GetInstance().GetAsync(url);
            List<Dialecto> lDialectos = JsonConvert.DeserializeObject<List<Dialecto>>(dataJson);
            cboIdioma.DropDownStyle = ComboBoxStyle.DropDownList;
            cboIdioma.DataSource = lDialectos;
            cboIdioma.ValueMember = "IdIdioma";
            cboIdioma.DisplayMember = "Descripcion";
        }
        private bool ValidarDatos()
        {
            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                MessageBox.Show("Ingrese el nombre!!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cboTipoPelicula.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un tipo de pelicula !!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cboDirectores.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un director!!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cboTipoPublico.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un tipo de publico!!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cboIdioma.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un idioma!!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!rbtSi.Checked && !rbtNo.Checked)
            {
                MessageBox.Show("Seleccione un subtitulo!!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ValidarDatos();
            ModificarPeliculaAsync();
        }
        private async Task ModificarPeliculaAsync()
        {
            try
            {
                Pelicula p = new Pelicula();
                p.Descripcion = txtDescripcion.Text;
                p.TipoPelicula = cboTipoPelicula.SelectedValue.ToString();
                p.Director = cboDirectores.SelectedValue.ToString();
                p.TipoPublico = cboTipoPublico.SelectedValue.ToString();
                p.Idioma = cboIdioma.SelectedValue.ToString();
                if (rbtSi.Checked) { p.Subtitulada = 0; }
                else { p.Subtitulada = 1; }

                string bodyContent = JsonConvert.SerializeObject(p);
                string url = "https://localhost:7149/pelicula_modificar/{p.IdPelicula}";

                var result = await ClienteSingleton.GetInstance().PutAsync(url, bodyContent);
                if (result.Equals("true"))
                {
                    MessageBox.Show("Pelicula actualizada", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("ERROR. No se pudo registrar la pelicula", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK);
            }
        }
    }
}