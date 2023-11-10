using CineBack.Datos.Implementacion;
using CineBack.Datos.Interfaz;
using CineBack.Entidades;
using CineBack.Fachada.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineBack.Fachada.Implementacion
{
    public class Aplicacion : IAplicacion
    {
        private IClienteDao dao;

        public Aplicacion()
        {
            dao = new IClienteDao();
        }


        #region MetodosCliente
        public List<Barrio> GetBarrios()
        {
            return dao.ObtenerBarrios();
        }

        public bool saveCliente(Cliente oCliente)
        {
            return dao.Crear(oCliente);
        }
        #endregion

        #region MetodosPelicula
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

        public bool savePelicula(Pelicula oPelicula)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region MetodosComprobante
        public bool SaveComprobante(Comprobante oComprobante)
        {
            throw new NotImplementedException();
        }

        public List<Cliente> GetClientes()
        {
            throw new NotImplementedException();
        }

        //public List<Empleado> GetEmpleados()
        //{
        //    throw new NotImplementedException();
        //}

        //public List<FormaPago> GetFormasPagos()
        //{
        //    throw new NotImplementedException();
        //}
        #endregion
    }
}
