using CineBack.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineBack.Datos.Interfaz
{
    public interface IPeliculaDao
    {
        bool Modificar(Pelicula pelicula);
        bool Borrar(int id_pel);
        bool Crear(Pelicula pelicula);
        List<Pelicula> TraerPeliculas();
        List<Dialecto> TraerDialectos();
        List<TipoPelicula> TraerTiposPelicula();
        List<TipoPublico> TraerTiposPublico();
        List<Director> TraerDirectores();

        List<Pelicula> ObtenerPeliculasFiltradas(int tipoPelicula, int tipoPublico, int dialecto);


    }
}
