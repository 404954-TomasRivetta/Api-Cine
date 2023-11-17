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

        private void FrmConsultarPeliculas_Load(object sender, EventArgs e)
        {
            CargarGenerosAsync();
            CargarPublicosAsync();
            CargarIdiomasAsync();
        }

        private async void CargarIdiomasAsync()
        {
            string url = "http://localhost:7149/idiomas";
            var result = await ClienteSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Dialecto>>(result);
            cboPublico.DataSource = lst;
            cboPublico.DisplayMember = "Descripcion";
            cboPublico.ValueMember = "IdIdioma";
        }

        private async void CargarPublicosAsync()
        {
            string url = "http://localhost:7149/publico";
            var result = await ClienteSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Dialecto>>(result);
            cboPublico.DataSource = lst;
            cboPublico.DisplayMember = "Descripcion";
            cboPublico.ValueMember = "IdTipoPublico";
        }

        private async void CargarGenerosAsync()
        {
            string url = "http://localhost:7149/generos";
            var result = await ClienteSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Dialecto>>(result);
            cboGenero.DataSource = lst;
            cboGenero.DisplayMember = "Descripcion";
            cboGenero.ValueMember = "IdTipoPelicula";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Control", "Seguro desea salir?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

        }
    }
}
