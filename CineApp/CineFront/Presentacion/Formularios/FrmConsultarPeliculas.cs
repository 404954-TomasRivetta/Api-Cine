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
    public partial class FrmConsultarPeliculas : Form
    {
        public FrmConsultarPeliculas()
        {
            InitializeComponent();
        }

        private async void FrmConsultarPeliculas_Load(object sender, EventArgs e)
        {
            await CargarGenerosAsync();
            await CargarPublicosAsync();
            await CargarIdiomasAsync();
            cboGenero.SelectedIndex = -1;
            cboIdioma.SelectedIndex = -1;
            cboPublico.SelectedIndex = -1;

        }

        private async Task CargarIdiomasAsync()
        {
            string url = "https://localhost:7149/dialectos";
            var result = await ClienteSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Dialecto>>(result);
            cboIdioma.DataSource = lst;
            cboIdioma.DisplayMember = "Descripcion";
            cboIdioma.ValueMember = "IdIdioma";
        }

        private async Task CargarPublicosAsync()
        {
            string url = "https://localhost:7149/tipos_publico";
            var result = await ClienteSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<TipoPublico>>(result);
            cboPublico.DataSource = lst;
            cboPublico.DisplayMember = "Descripcion";
            cboPublico.ValueMember = "IdTipoPublico";
        }

        private async Task CargarGenerosAsync()
        {
            string url = "https://localhost:7149/tipos_pelicula";
            var result = await ClienteSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<TipoPelicula>>(result);
            cboGenero.DataSource = lst;
            cboGenero.ValueMember = "IdTipoPelicula";
            cboGenero.DisplayMember = "Descripcion";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro desea salir?", "Control", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            int genero = Convert.ToInt32(cboGenero.SelectedValue);
            int publico = Convert.ToInt32(cboPublico.SelectedValue);
            int dialecto = Convert.ToInt32(cboIdioma.SelectedValue);

            CargarPeliculasFiltradas(genero, publico, dialecto);
        }

        private async void CargarPeliculasFiltradas(int tipoPelicula, int tipoPublico, int dialecto)
        {
            string url = $"https://localhost:7149/peliculas?tipoPelicula={tipoPelicula}&tipoPublico={tipoPublico}&dialecto={dialecto}";

            var result = await ClienteSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Pelicula>>(result);
            dgvPeliculasFiltradas.Rows.Clear();
            if (lst != null)
            {
                foreach (Pelicula pelicula in lst)
                {

                    string subtitulada = "";

                    if (pelicula.Subtitulada == 1)
                    {
                        subtitulada = "SI";
                    }
                    else
                    {
                        subtitulada = "NO";
                    }

                    dgvPeliculasFiltradas.Rows.Add(new object[] {
                        pelicula.IdPelicula,
                        pelicula.Descripcion,
                        pelicula.TipoPelicula,
                        pelicula.Idioma,
                        pelicula.TipoPublico,
                        subtitulada,
                        pelicula.Director
                    });
                }
            }
            else
            {
                MessageBox.Show("Sin datos de peliculas para los filtros ingresados", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {

            int nro = int.Parse(dgvPeliculasFiltradas.CurrentRow.Cells["ColId"].Value.ToString());

            await EliminarPeliculaAsync(nro);

        }

        private async Task EliminarPeliculaAsync(int nro)
        {

            if (MessageBox.Show("Seguro que desea quitar la pelicula seleccionado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (dgvPeliculasFiltradas.CurrentRow != null)
                {
                    string url = "https://localhost:7149/DeletePelicula?idPelicula=" + nro;

                    var result = await ClienteSingleton.GetInstance().DeleteAsync(url);

                    if (result.Equals("true"))
                    {
                        MessageBox.Show("La pelicula se quitó exitosamente!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("La pelicula NO se quitó exitosamente!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
