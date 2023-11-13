﻿using CineBack.Entidades;
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
    public partial class FrmAltaCliente : Form
    {
        public FrmAltaCliente()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente();
            c.Nombre = txtNombre.Text;
            c.Apellido = txtApellido.Text;
            c.Correo = txtCorreo.Text;
            c.CodBarrio = (int)cboBarrios.SelectedValue;            
            c.NroTel = Convert.ToInt32(txtNroTel.Text);
            c.Calle = txtCalle.Text;
            c.CalleNro = Convert.ToInt32(txtAltura.Text);
            c.Dni = Convert.ToInt32(txtDni.Text);
            dgvClientes.Rows.Add(new object[] { c.Nombre, c.Apellido, c.NroTel, c.Correo,c.CodBarrio,cboBarrios.Text,c.Calle, c.CalleNro, c.Dni, "Quitar" });
        }

        private async void FrmAltaCliente_Load(object sender, EventArgs e)
        {
            await CargarBarriosAsync();
        }
        private async Task CargarBarriosAsync()
        {
            string url = "http://localhost:5175/barrios";
            var dataJson = await ClienteSingleton.GetInstance().GetAsync(url);
            List<Barrio> lBarrios = JsonConvert.DeserializeObject<List<Barrio>>(dataJson);
            cboBarrios.DataSource = lBarrios;
            cboBarrios.ValueMember = "BarrioNro";
            cboBarrios.DisplayMember = "Descripcion";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.Rows.Count == 0)
            {
                MessageBox.Show("Debe ingresar al menos un cliente...", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            GrabarCliente();
        }
        private async void GrabarCliente()
        {
            foreach (DataGridViewRow row in dgvClientes.Rows)
            {
                Cliente c = new Cliente();
                c.Nombre = row.Cells["ColNombre"].Value.ToString();
                c.Apellido = row.Cells["ColApellido"].Value.ToString();
                c.NroTel = Convert.ToInt32(row.Cells["ColTelefono"].Value);
                c.Correo = row.Cells["ColCorreo"].Value.ToString().ToString();
                c.CodBarrio = (int)row.Cells["ColCodBarrio"].Value;
                c.Calle = row.Cells["ColCalle"].Value.ToString();
                c.CalleNro = (int)row.Cells["ColAltura"].Value;
                c.Dni = (int)row.Cells["ColDni"].Value;
                if(await GuardarClienteAsync(c))
                {
                    MessageBox.Show("Se registró con éxito el cliente...", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("NO se pudo registrar el cliente...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        private async Task<bool> GuardarClienteAsync(Cliente nuevo)
        {
            string url = "https://localhost:7149/clientes";
            string clienteJson = JsonConvert.SerializeObject(nuevo);
            var dataJson = await ClienteSingleton.GetInstance().PostAsync(url, clienteJson);
            if (dataJson.Equals(""))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
