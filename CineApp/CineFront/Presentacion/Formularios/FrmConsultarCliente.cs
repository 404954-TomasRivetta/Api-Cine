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
            if (dtpFechaHasta.Value > DateTime.Now)
            {
                MessageBox.Show("La fecha hasta no puede ser mayor al dia de hoy", "ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            if (string.IsNullOrEmpty(txtApellido.Text))
            {
                MessageBox.Show("El apellido no puede estar vacio", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            int idBarrio = Convert.ToInt32(cboBarrio.SelectedValue);
            String fecDesde, fecHasta, apelli;
            fecDesde = Uri.EscapeDataString(dtpFechaDesde.Value.ToString("yyyy/MM/dd"));
            fecHasta = Uri.EscapeDataString(dtpFechaHasta.Value.ToString("yyyy/MM/dd"));
            apelli = Uri.EscapeDataString(txtApellido.Text);
            cargarClientesFiltrados(idBarrio, fecDesde, fecHasta, apelli);


        }

        private async void cargarClientesFiltrados(int idBarrio, string fechaDesde, string fechaHasta, string apellido)
        {
            string url = $"https://localhost:7149/clientesFiltrados?FechaDesde={fechaDesde}&FechaHasta={fechaHasta}&idBarrio={idBarrio}&apellido={apellido}";
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
                    c.NombrePelicula
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
    }
}
