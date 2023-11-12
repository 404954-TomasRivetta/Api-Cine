using CineBack.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineBack.Fachada.Interfaz
{
    public interface IAplicacionPelicula
    {
        List<TipoPublico> GetTiposPublicos();
        List<Director> GetDirectores();

        List<Dialecto> GetDialectos();

        List<Actor> GetActoresPel();

        List<TipoPelicula> GetTiposPeliculas();

        bool SavePelicula(Pelicula oPelicula);
    }
}
