using CineBack.Datos;
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
    public partial class FrmConsultarCliente : Form
    {
        public FrmConsultarCliente()
        {
            InitializeComponent();
        }

        private void FrmConsultarCliente_Load(object sender, EventArgs e)
        {
            CargarBarriosAsync();
        }

        private async void CargarBarriosAsync()
        {
            string url = "https://localhost:7149/barrios";
            var result = await ClienteSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Barrio>>(result);
            cboBarrio.DataSource = lst;
            cboBarrio.DisplayMember = "Descripcion";
            cboBarrio.ValueMember = "BarrioNro";
            cboBarrio.SelectedIndex = -1;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            int idBarrio = Convert.ToInt32(cboBarrio.SelectedValue);
            String apelli;
            apelli = Uri.EscapeDataString(txtApellido.Text);
            cargarClientesFiltrados(idBarrio, apelli);
        }

        private async void cargarClientesFiltrados(int idBarrio, string apellido)
        {
            string url = $"https://localhost:7149/clientesFiltrados?idBarrio={idBarrio}&apellido={apellido}";
            var result = await ClienteSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Cliente>>(result);

            dgvClientes.Rows.Clear();
            if (lst != null)
            {
                foreach (Cliente c in lst)
                {
                    dgvClientes.Rows.Add(new object[]
                    {
                    c.CodCliente,
                    c.NombreCompleto,
                    c.Correo,
                    c.NombreBarrio,
                    c.NroTel
                    });
                }
            }
            else
            {
                MessageBox.Show("Sin datos de Clientes para los filtros ingresados", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Control", "Seguro desea salir?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int nro = int.Parse(dgvClientes.CurrentRow.Cells["Column1"].Value.ToString());
            new FrmModificacionCliente(nro).ShowDialog();
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            int nro = int.Parse(dgvClientes.CurrentRow.Cells["Column1"].Value.ToString());

            await EliminarClienteAsync(nro);
        }

        private async Task EliminarClienteAsync(int nro)
        {
            if (MessageBox.Show("Seguro que desea quitar el cliente seleccionado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (dgvClientes.CurrentRow != null)
                {
                    string url = "https://localhost:7149/DeleteCliente?idCliente=" + nro;

                    var result = await ClienteSingleton.GetInstance().DeleteAsync(url);

                    if (result.Equals("true"))
                    {
                        MessageBox.Show("El cliente se quitó exitosamente!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        int idBarrio = Convert.ToInt32(cboBarrio.SelectedValue);
                        String apelli;
                        apelli = Uri.EscapeDataString(txtApellido.Text);
                        cargarClientesFiltrados(idBarrio, apelli);
                    }
                    else
                    {
                        MessageBox.Show("El cliente NO se quitó exitosamente!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
