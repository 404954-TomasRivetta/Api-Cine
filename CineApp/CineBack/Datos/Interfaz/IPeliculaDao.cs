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

    }
}
