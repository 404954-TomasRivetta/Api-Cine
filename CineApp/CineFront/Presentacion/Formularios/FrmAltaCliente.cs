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
    public partial class FrmAltaCliente2 : Form
    {
        public FrmAltaCliente2()
        {
            InitializeComponent();
        }
        private async void FrmAltaCliente_Load(object sender, EventArgs e)
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

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            GrabarCliente();
        }
        private async void GrabarCliente()
        {
            Cliente c = new Cliente();
            c.Nombre = txtNombre.Text;
            c.Apellido = txtApellido.Text;
            c.NroTel = Convert.ToInt32(txtNroTel.Text);
            c.Correo = txtCorreo.Text;
            c.CodBarrio = Convert.ToInt32(cboBarrios.SelectedValue);
            c.Calle = txtCalle.Text;
            c.CalleNro = Convert.ToInt32(txtAltura.Text);
            c.Dni = Convert.ToInt32(txtDni.Text);
            if (await GuardarClienteAsync(c))
            {
                MessageBox.Show("Se registró con éxito el cliente...", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("NO se pudo registrar el cliente...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private async Task<bool> GuardarClienteAsync(Cliente nuevo)
        {
            string url = "https://localhost:7149/clientes";
            string clienteJson = JsonConvert.SerializeObject(nuevo);
            var dataJson = await ClienteSingleton.GetInstance().PostAsync(url, clienteJson);
            if (dataJson.Equals(""))
                return true;
            else
                return false;
        }

        private void FrmAltaCliente2_Load(object sender, EventArgs e)
        {

        }
    }
}
