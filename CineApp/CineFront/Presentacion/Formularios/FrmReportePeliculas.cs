using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CineFront.Presentacion.Formularios
{
    public partial class FrmReportePeliculas : Form
    {
        public FrmReportePeliculas()
        {
            InitializeComponent();
        }

        private void FrmReportePeliculas_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.ReportEmbeddedResource = "CineFront.Presentacion.Reportes.RptPeliculas.rdlc";


            string connectionString = "Data Source=localhost;Initial Catalog=lc_tpi_cine;Integrated Security=True";
            string query = "select p.descripcion as pelicula, sum(cant_entradas * pre_unitario) as Facturacion from comprobantes c join tickets t on t.id_comprobante = c.id_comprobante join butacas b on t.id_butacas = b.id_butaca join funciones f on f.id_funcion = b.id_funcion join peliculas p on p.id_pelicula = f.id_pelicula GROUP BY p.descripcion order by Facturacion  DESC";
            DataSet ds = new DataSet();
            using (SqlCommand cmd = new SqlCommand(query, new SqlConnection(connectionString)))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(ds);
                }
            }

            ReportDataSource rds = new ReportDataSource("DataSet1", ds.Tables[0]);
            reportViewer1.LocalReport.DataSources.Add(rds);

            this.reportViewer1.RefreshReport(); 
            reportViewer1.RefreshReport();
        }
    }
}
