using CineBack.Datos.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CineBack.Entidades;

namespace CineBack.Datos.Implementacion
{
    public class ClienteDao : IClienteDao
    {
        public List<Barrio> TraerBarrios()
        {
            List<Barrio> lBarrios = new List<Barrio>();
            DataTable tabla=HelperDB.ObtenerInstancia().Consultar("SP_CONSULTAR_BARRIOS");
            foreach (DataRow fila in tabla.Rows)
            {
                int cod = int.Parse(fila["cod_barrio"].ToString());
                string desc = fila["descripcion"].ToString();
                Barrio b = new Barrio(cod, desc);
                lBarrios.Add(b);
            }
            return lBarrios;
        }
        public bool Modificar(Cliente cliente)
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
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SP_MODIFICAR_CLIENTE";
                comando.Parameters.AddWithValue("@id_cliente", cliente.CodCliente);
                comando.Parameters.AddWithValue("@nombre", cliente.Nombre);
                comando.Parameters.AddWithValue("@apellido", cliente.Apellido);
                comando.Parameters.AddWithValue("@correo", cliente.Correo);
                comando.Parameters.AddWithValue("@nro_tel", cliente.NroTel);
                comando.Parameters.AddWithValue("@cod_barrio", cliente.CodBarrio);
                comando.Parameters.AddWithValue("@calle", cliente.Calle);
                comando.Parameters.AddWithValue("@calle_nro", cliente.CalleNro);
                comando.Parameters.AddWithValue("@dni", cliente.Dni);
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
        public bool Borrar(Cliente cliente)
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
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SP_BORRAR_CLIENTE";
                comando.Parameters.AddWithValue("@id_cliente", cliente.CodCliente);
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

        public bool Crear(Cliente cliente)
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
                comando.CommandText = "SP_INSERTAR_CLIENTE";
                comando.Parameters.AddWithValue("@nombre", cliente.Nombre);
                comando.Parameters.AddWithValue("@apellido", cliente.Apellido);
                comando.Parameters.AddWithValue("@correo", cliente.Correo);
                comando.Parameters.AddWithValue("@nro_tel", cliente.NroTel);
                comando.Parameters.AddWithValue("@cod_barrio", cliente.CodBarrio);
                comando.Parameters.AddWithValue("@calle", cliente.Calle);
                comando.Parameters.AddWithValue("@calle_nro", cliente.CalleNro);
                comando.Parameters.AddWithValue("@dni", cliente.Dni);
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

        public List<Cliente> ObtenerClientesFiltrados(DateTime FechaDesde, DateTime FechaHasta, int idBarrio, string apellido)
        {
            List<Cliente> clientes = new List<Cliente>();
            string sp = "SP_CONSULTAR_CLIENTES_CON_FILTROS";
            List<Parametro> lst = new List<Parametro>();
            lst.Add(new Parametro("@id_barrio", idBarrio != 0 ? idBarrio : DBNull.Value));
            lst.Add(new Parametro("@fechaDesde", FechaDesde));
            lst.Add(new Parametro("@fechaHasta", FechaHasta));
            lst.Add(new Parametro("@cliente", apellido != string.Empty ? apellido : DBNull.Value));
            DataTable dt = HelperDB.ObtenerInstancia().Consultar(sp, lst);

            foreach (DataRow row in dt.Rows)
            {
                Cliente c = new Cliente();
                c.CodCliente = int.Parse(row[0].ToString());
                c.NombreCompleto = row[1].ToString();
                c.Correo = row[2].ToString();
                c.NombreBarrio = row[3].ToString();
                c.NombrePelicula = row[4].ToString();
                clientes.Add(c);
            }

            return clientes;
        }
    }
}
