using CineBack.Entidades;
using CineFront.Servicio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using static System.Net.WebRequestMethods;

namespace CineFront.Presentacion.Formularios
{
    public partial class FrmAltaCliente : Form
    {
        private Cliente nuevo;
        public FrmAltaCliente()
        {
            InitializeComponent();
            nuevo = new Cliente();
        }

        private void FrmAltaCliente_Load(object sender, EventArgs e)
        {
            CargarBarriosAsync();
        }
        private async void CargarBarriosAsync()
        {
            string url = "https://localhost:7149/barrios";
            var result = await ClienteSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Barrio>>(result);
            cboBarrios.DropDownStyle = ComboBoxStyle.DropDownList;
            cboBarrios.DataSource = lst;
            cboBarrios.DisplayMember = "Descripcion";
            cboBarrios.ValueMember = "BarrioNro";
        }
        private async Task GuardarClienteAsync()
        {
            nuevo.Nombre = txtNombre.Text;
            nuevo.Apellido = txtApellido.Text;
            nuevo.NroTel = Convert.ToInt32(txtNroTel.Text);
            nuevo.Correo = txtCorreo.Text;
            nuevo.CodBarrio = Convert.ToInt32(cboBarrios.SelectedValue);
            nuevo.Calle = txtCalle.Text;
            nuevo.CalleNro = Convert.ToInt32(txtAltura.Text);
            nuevo.Dni = Convert.ToInt32(txtDni.Text);
            string bodyContent = JsonConvert.SerializeObject(nuevo);

            string url = "https://localhost:7149/cliente";
            var result = await ClienteSingleton.GetInstance().PostAsync(url, bodyContent);

            if (result.Equals("true"))
            {
                MessageBox.Show("Cliente registrado", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("ERROR. No se pudo registrar el cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnAceptar_Click(object sender, EventArgs e)
        {
            await GuardarClienteAsync();
        }
    }
}
