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

        private Cliente oCliente;

        public FrmModificacionCliente(int idCliente)
        {
            InitializeComponent();
            oCliente = new Cliente();

            oCliente.CodCliente = idCliente;
        }

        private async void FrmModificacionCliente_Load(object sender, EventArgs e)
        {
            CargarBarriosAsync();
            cboBarrios.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private async Task CargarBarriosAsync()
        {
            string url = "https://localhost:7149/barrios";
            var result = await ClienteSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Barrio>>(result);
            cboBarrios.DropDownStyle = ComboBoxStyle.DropDownList;
            cboBarrios.DataSource = lst;
            cboBarrios.DisplayMember = "Descripcion";
            cboBarrios.ValueMember = "BarrioNro";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private async void btnModificar_Click(object sender, EventArgs e)
        {
            ValidarDatos();
            await ModificarClienteAsync();
        }

        private bool ValidarDatos()
        {
            if (!int.TryParse(txtAltura.Text, out _) || string.IsNullOrEmpty(txtAltura.Text))
            {
                MessageBox.Show("Ingrese una altura valida!!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!int.TryParse(txtDni.Text, out _) || string.IsNullOrEmpty(txtDni.Text))
            {
                MessageBox.Show("Ingrese un dni valido!!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!int.TryParse(txtNroTel.Text, out _) || string.IsNullOrEmpty(txtNroTel.Text))
            {
                MessageBox.Show("Ingrese un numero de telefono valido!!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if(cboBarrios.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un barrio!!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if(string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Ingrese el nombre!!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(txtApellido.Text))
            {
                MessageBox.Show("Ingrese el apellido!!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if(string.IsNullOrEmpty(txtCorreo.Text))
            {
                MessageBox.Show("Ingrese un correo!!","Control",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private async Task ModificarClienteAsync()
        {
            try
            {
                Cliente c = new Cliente();
                c.CodCliente = oCliente.CodCliente;
                c.Nombre = txtNombre.Text;
                c.Apellido = txtApellido.Text;
                c.NroTel = Convert.ToInt32(txtNroTel.Text);
                c.Correo = txtCorreo.Text;
                c.CodBarrio = Convert.ToInt32(cboBarrios.SelectedValue);
                c.Calle = txtCalle.Text;
                c.CalleNro = Convert.ToInt32(txtAltura.Text);
                c.Dni = Convert.ToInt32(txtDni.Text);


                string bodyContent = JsonConvert.SerializeObject(c);
                string url = "https://localhost:7149/clientes_modificar/"+c.CodCliente.ToString();

                var result = await ClienteSingleton.GetInstance().PutAsync(url, bodyContent);
                if (result.Equals("true"))
                {
                    MessageBox.Show("Cliente actualizado", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("ERROR. No se pudo registrar el cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK);
            }

        }

    }
}
