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
    public partial class FrmAltaComprobante : Form
    {
        private Comprobante nuevo;
        public FrmAltaComprobante()
        {
            InitializeComponent();
            nuevo = new Comprobante();  
        }

        private async void FrmAltaComprobante_Load(object sender, EventArgs e)
        {
            await CargarClientesAsync();
            await CargarFormasPagoAsync();
            await CargarEmpleadosAsync();
            txtCant.Text = "1";
        }

        private async Task CargarFormasPagoAsync()
        {
            string url = "https://localhost:7149/formas_pago";
            var bodyJson = await ClienteSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<TipoFormaPago>>(bodyJson);
            //cargar combo
            cboFormasP.DataSource = lst;
            cboFormasP.ValueMember = "id";
            cboFormasP.DisplayMember = "Descripcion";
        }

        private async Task CargarEmpleadosAsync()
        {
            string url = "https://localhost:7149/empleados";
            var bodyJson = await ClienteSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Empleado>>(bodyJson);
            //cargar combo
            cboEmpleado.DataSource = lst;
            cboEmpleado.ValueMember = "CodEmpleado";
            cboEmpleado.DisplayMember = "Apellido";
        }

        private async Task CargarClientesAsync()
        {
            string url = "https://localhost:7149/clientes";
            var bodyJson = await ClienteSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Cliente>>(bodyJson);
            //cargar combo
            cboClientes.DataSource = lst;
            cboClientes.ValueMember = "CodCliente";
            cboClientes.DisplayMember = "Apellido";
        }

        private async void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtCant.Text == "")
            {
                MessageBox.Show("Debe ingresar una cantidad!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            await GuardarComprobanteAsync();
        }

       private async Task GuardarComprobanteAsync()
        {
            TipoFormaPago t = (TipoFormaPago) cboFormasP.SelectedItem;
            Cliente c = (Cliente) cboClientes.SelectedItem;
            Empleado e = (Empleado)cboEmpleado.SelectedItem;
            nuevo.IdCliente = c.CodCliente;
            nuevo.IdForma_pago = t.id;
            nuevo.IdEmpleado = e.CodEmpleado;
            nuevo.CantEntradas = Convert.ToInt32(txtCant.Text);
            string bodyContent = JsonConvert.SerializeObject(nuevo);

            string url = "https://localhost:7149/api/Comprobante";
            var result = await ClienteSingleton.GetInstance().PostAsync(url, bodyContent);

            if (result.Equals("true"))//servicio.CrearPresupuesto(nuevo)    
            {
                MessageBox.Show("Presupuesto registrado", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("ERROR. No se pudo registrar el presupuesto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
