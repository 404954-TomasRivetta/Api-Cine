using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace CineBack.Datos
{
    public class HelperDB
    {
        private SqlConnection conexion;
        private static HelperDB instance;

        public HelperDB()
        {
            conexion = new SqlConnection(@"Data Source=PCCesar;Initial Catalog=lc_tpi_cine;Integrated Security=True;Encrypt=False");
        }

        public static HelperDB ObtenerInstancia()
        {
            if (instance == null)
            {
                instance = new HelperDB();
            }
            return instance;
        }

        public SqlConnection ObtenerConexion()
        {
            return this.conexion;
        }

        public int ProximaOrden(string sentencia, string nombParam)
        {
            int aux = 0;
            conexion.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = sentencia;
            SqlParameter sqlParameter = new SqlParameter(nombParam, SqlDbType.Int);
            sqlParameter.Direction = ParameterDirection.Output;
            comando.Parameters.Add(sqlParameter);
            comando.ExecuteNonQuery();
            conexion.Close();
            aux = (int)sqlParameter.Value;
            return aux;
        }


        public DataTable Consultar(string nombreSP)
        {
            conexion.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = nombreSP;
            DataTable dt = new DataTable();
            dt.Load(comando.ExecuteReader());
            conexion.Close();
            return dt;
        }


        internal DataTable Consultar(string nombreSP, List<Parametro> lParam)
        {
            conexion.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = nombreSP;

            foreach (Parametro param in lParam)
            {
                comando.Parameters.AddWithValue(param.Nombre, param.Valor);
            }

            DataTable dt = new DataTable();
            dt.Load(comando.ExecuteReader());
            conexion.Close();
            return dt;
        }

        public int EjecutarSQL(string sp, List<Parametro> lParametros)
        {
            int filasAfectadas;
            conexion.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType= CommandType.StoredProcedure;
            comando.CommandText = sp;

            foreach (Parametro p in lParametros)
            {
                comando.Parameters.AddWithValue(p.Nombre, p.Valor);
            }
            filasAfectadas = comando.ExecuteNonQuery();
            conexion.Close();
            return filasAfectadas;
        }

    }
}
