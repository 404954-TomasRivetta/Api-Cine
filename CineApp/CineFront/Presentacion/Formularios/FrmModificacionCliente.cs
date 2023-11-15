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
    public partial class FrmModificacionCliente : Form
    {
        public FrmModificacionCliente()
        {
            InitializeComponent();
        }

        private async void FrmModificacionCliente_Load(object sender, EventArgs e)
        {
            await CargarBarriosAsync();
            cboBarrios.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private async Task CargarBarriosAsync()
        {
            string url = "http://localhost:7149/barrios";
            var dataJson = await ClienteSingleton.GetInstance().GetAsync(url);
            List<Barrio> lBarrios = JsonConvert.DeserializeObject<List<Barrio>>(dataJson);
            cboBarrios.DataSource = lBarrios;
            cboBarrios.ValueMember = "BarrioNro";
            cboBarrios.DisplayMember = "Descripcion";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ModificarCliente();
        }

        private async void ModificarCliente()
        {
            throw new NotImplementedException();
        }
    }
}
