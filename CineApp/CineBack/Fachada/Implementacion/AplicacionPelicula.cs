using CineBack.Datos.Implementacion;
using CineBack.Entidades;
using CineBack.Fachada.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineBack.Fachada.Implementacion
{
    public class AplicacionPelicula : IAplicacionPelicula
    {
        private ClienteDao dao;
        public List<Actor> GetActoresPel()
        {
            throw new NotImplementedException();
        }

        public List<Dialecto> GetDialectos()
        {
            throw new NotImplementedException();
        }

        public List<Director> GetDirectores()
        {
            throw new NotImplementedException();
        }

        public List<TipoPelicula> GetTiposPeliculas()
        {
            throw new NotImplementedException();
        }

        public List<TipoPublico> GetTiposPublicos()
        {
            throw new NotImplementedException();
        }

        public bool SavePelicula(Pelicula oPelicula)
        {
            throw new NotImplementedException();
        }
    }
}
