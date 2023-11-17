using CineBack.Datos.Interfaz;
using CineBack.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineBack.Datos.Implementacion
{
    public class ComprobanteDao: IComprobanteDao
    {
        public bool Crear(Comprobante oC)
        {
            bool resultado = true;
            SqlConnection conexion = HelperDB.ObtenerInstancia().ObtenerConexion();
            SqlTransaction t = null;
            try
            {
                conexion.Open();
                t = conexion.BeginTransaction();
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexion;
                comando.Transaction = t;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "SP_INSERTAR_COMPROBANTE";
                comando.Parameters.AddWithValue("@id_cliente", oC.IdCliente);
                comando.Parameters.AddWithValue("@id_forma_pago", oC.IdForma_pago);
                comando.Parameters.AddWithValue("@id_empleado", oC.IdEmpleado);
                comando.Parameters.AddWithValue("@cant_entradas", oC.CantEntradas);
                comando.ExecuteNonQuery();
                t.Commit();
            }
            catch
            {
                if (t != null)
                {
                    t.Rollback();
                    resultado = false;
                }
            }
            finally
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            return resultado;
        }

        public List<Cliente> GetClientes()
        {
            List<Cliente> lClientes = new List<Cliente>();
            DataTable tabla = HelperDB.ObtenerInstancia().Consultar("SP_CONSULTAR_CLIENTES");
            foreach (DataRow fila in tabla.Rows)
            {
                int cod = int.Parse(fila["id_cliente"].ToString());
                string nom = fila["nombre"].ToString();
                string ape = fila["apellido"].ToString();
                string correo = fila["correo"].ToString();
                int tel = int.Parse(fila["nro_tel"].ToString());
                int barrio = int.Parse(fila["cod_barrio"].ToString());
                string calle = fila["calle"].ToString();
                int calleNro = int.Parse(fila["calle_nro"].ToString());
                int dni = int.Parse(fila["dni"].ToString());
                Cliente c = new Cliente(cod,nom,ape,correo,tel,barrio,calle,calleNro,dni);
                lClientes.Add(c);
            }
            return lClientes;
        }

        public List<Empleado> GetEmpleados()
        {
            List<Empleado> lEmpleados = new List<Empleado>();
            DataTable tabla = HelperDB.ObtenerInstancia().Consultar("SP_CONSULTAR_EMPLEADOS");
            foreach (DataRow fila in tabla.Rows)
            {
                int cod = int.Parse(fila["id_empleado"].ToString());
                string nom = fila["nombre"].ToString();
                string ape = fila["apellido"].ToString();
                string correo = fila["correo"].ToString();
                int tel = int.Parse(fila["nro_tel"].ToString());
                int barrio = int.Parse(fila["cod_barrio"].ToString());
                string calle = fila["calle"].ToString();
                int calleNro = int.Parse(fila["calle_nro"].ToString());
                int dni = int.Parse(fila["dni"].ToString());
                Empleado e = new Empleado(cod, nom, ape, correo, tel, barrio, calle, calleNro, dni);
                lEmpleados.Add(e);
            }
            return lEmpleados;
        }

        public List<TipoFormaPago> GetFormasPagos()
        {
            List<TipoFormaPago> lForma = new List<TipoFormaPago>();
            DataTable tabla = HelperDB.ObtenerInstancia().Consultar("SP_CONSULTAR_FORMAS_PAGO");
            foreach (DataRow fila in tabla.Rows)
            {
                int cod = int.Parse(fila["id_forma_pago"].ToString());
                string des = fila["descripcion"].ToString();
                TipoFormaPago t = new TipoFormaPago();
                t.Descripcion = des;
                t.id = cod;
                lForma.Add(t);
            }
            return lForma;
        }
    }
}
