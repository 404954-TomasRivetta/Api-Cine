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
    public class PeliculaDao : IPeliculaDao
    {
        public bool Borrar(int id_pel)
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
                comando.CommandText = "SP_BORRAR_PELICULA";
                comando.Parameters.AddWithValue("@id_pelicula", id_pel);
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

        public bool Crear(Pelicula pelicula)
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
                comando.CommandText = "SP_INSERTAR_PELICULA";
                comando.Parameters.AddWithValue("@descripcion", pelicula.Descripcion);
                comando.Parameters.AddWithValue("@id_tipo_pelicula", pelicula.IdTipoPelicula);
                comando.Parameters.AddWithValue("@id_idioma", pelicula.IdIdioma) ;
                comando.Parameters.AddWithValue("@id_tipo_publico", pelicula.IdTipoPublico);
                comando.Parameters.AddWithValue("@subtitulada", pelicula.Subtitulada);
                comando.Parameters.AddWithValue("@id_director", pelicula.IdDirector);
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
            return resultado; ;
        }

        public bool Modificar(Pelicula pelicula)
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
                comando.CommandText = "SP_MODIFICAR_PELICULA";
                comando.Parameters.AddWithValue("@descripcion", pelicula.Descripcion);
                comando.Parameters.AddWithValue("@id_tipo_pelicula", pelicula.IdTipoPelicula);
                comando.Parameters.AddWithValue("@id_idioma ", pelicula.IdIdioma);
                comando.Parameters.AddWithValue("@id_tipo_publico ", pelicula.IdTipoPublico);
                comando.Parameters.AddWithValue("@subtitulada ", pelicula.Subtitulada);
                comando.Parameters.AddWithValue("@id_director ", pelicula.IdDirector);
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

        public List<Pelicula> TraerPeliculas()
        {
            
                List<Pelicula> lPeliculas = new List<Pelicula>();
                DataTable tabla = HelperDB.ObtenerInstancia().Consultar("SP_CONSULTAR_PELICULAS");
                foreach (DataRow fila in tabla.Rows)
                {
                
                 string desc = fila["descripcion"].ToString();
                 int id_tipo_pelicula = int.Parse(fila["id_tipo_pelicula "].ToString());
                 int id_idioma = int.Parse(fila["id_idioma "].ToString());
                int id_tipo_publico = int.Parse(fila["id_tipo_publico "].ToString());
                bool subtitulada = Convert.ToBoolean(int.Parse(fila["id_tipo_pelicula "].ToString()));
                int id_director = int.Parse(fila["id_tipo_pelicula "].ToString());




                Pelicula peli = new Pelicula(desc,id_tipo_pelicula,id_idioma,id_tipo_publico,subtitulada,id_director);
                    lPeliculas.Add(peli);
                }
                return lPeliculas;
            
        }
    }
}
