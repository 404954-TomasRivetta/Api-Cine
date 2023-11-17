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
            string sp = "SP_ELIMINAR_PELICULA";
            List<Parametro> lst = new List<Parametro>();
            lst.Add(new Parametro("@idPelicula", id_pel));
            int afectadas = HelperDB.ObtenerInstancia().EjecutarSQL(sp, lst);
            return afectadas > 0;
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

        public List<Dialecto> TraerDialectos()
        {
            List<Dialecto>lDialectos=new List<Dialecto> ();
            DataTable tabla = HelperDB.ObtenerInstancia().Consultar("SP_CONSULTAR_DIALECTOS");
            foreach (DataRow fila in tabla.Rows)
            {
                int id = int.Parse(fila["id_idioma"].ToString());
                string desc = fila["descripcion"].ToString();
                Dialecto d=new Dialecto(id, desc);
                lDialectos.Add(d);
            }
            return lDialectos;
        }

        public List<Director> TraerDirectores()
        {
            List<Director>lDirectores=new List<Director>();
            DataTable tabla = HelperDB.ObtenerInstancia().Consultar("SP_CONSULTAR_DIRECTORES");
            foreach(DataRow fila in tabla.Rows)
            {
                int id= int.Parse(fila["id_director"].ToString());
                string nom = fila["nombre"].ToString();
                string ape = fila["apellido"].ToString();
                Director d = new Director(id,nom,ape);
                lDirectores.Add(d);
            }
            return lDirectores;
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
                    int subtitulada = int.Parse(fila["id_tipo_pelicula "].ToString());
                    int id_director = int.Parse(fila["id_tipo_pelicula "].ToString());
                    Pelicula peli = new Pelicula(desc,id_tipo_pelicula,id_idioma,id_tipo_publico,subtitulada,id_director);
                    lPeliculas.Add(peli);
                }
                return lPeliculas;            
        }

        public List<TipoPelicula> TraerTiposPelicula()
        {
            List<TipoPelicula>lPeliculas= new List<TipoPelicula>();
            DataTable tabla = HelperDB.ObtenerInstancia().Consultar("SP_CONSULTAR_TIPOS_PELICULAS");
            foreach (DataRow fila in tabla.Rows)
            {
                int id = int.Parse(fila["id_tipo_pelicula"].ToString());
                string desc = fila["descripcion"].ToString();
                TipoPelicula t = new TipoPelicula(id, desc);
                lPeliculas.Add(t);
            }
            return lPeliculas;
        }

        public List<TipoPublico> TraerTiposPublico()
        {
            List <TipoPublico> lTipoPublicos =new List<TipoPublico>();
            DataTable tabla = HelperDB.ObtenerInstancia().Consultar("SP_CONSULTAR_TIPOS_PUBLICO");
            foreach (DataRow fila in tabla.Rows)
            {
                int id = int.Parse(fila["id_tipo_publico"].ToString());
                string desc = fila["descripcion"].ToString();
                TipoPublico t=new TipoPublico(id, desc);
                lTipoPublicos.Add(t);
            }
            return lTipoPublicos;
        }

        public List<Pelicula> ObtenerPeliculasFiltradas(int tipoPelicula, int tipoPublico, int dialecto)
        {
            List<Pelicula> peliculas = new List<Pelicula>();
            string sp = "[dbo].[SP_FILTRAR_PELICULA]";

            List<Parametro> lst = new List<Parametro>();

            lst.Add(new Parametro("@genero", tipoPelicula != 0 ? tipoPelicula : DBNull.Value));
            lst.Add(new Parametro("@publico", tipoPublico != 0 ? tipoPublico : DBNull.Value));
            lst.Add(new Parametro("@dialecto", dialecto != 0 ? dialecto : DBNull.Value));

            DataTable dt = HelperDB.ObtenerInstancia().Consultar(sp, lst);

            foreach (DataRow row in dt.Rows)
            {
                Pelicula pelicula = new Pelicula();

                pelicula.IdPelicula = Convert.ToInt32(row[0].ToString());
                pelicula.Descripcion = row[1].ToString();
                pelicula.TipoPelicula = row[2].ToString();
                pelicula.Idioma = row[3].ToString();
                pelicula.TipoPublico = row[4].ToString();
                pelicula.Subtitulada = Convert.ToInt32(row[5].ToString());
                pelicula.Director = row[6].ToString();

                peliculas.Add(pelicula);
            }

            return peliculas;
        }
    }
}
