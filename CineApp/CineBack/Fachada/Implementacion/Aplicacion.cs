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
            dao = new ClienteDao();
        }

        #region MetodosCliente
        public List<Barrio> GetBarrios(int CodBarrio)
        {
            return dao.TraerBarrios(CodBarrio);
        }

        public bool SaveCliente(Cliente oCliente)
        {
            return dao.Crear(oCliente);
        }

        public bool ModifyCliente(Cliente oCliente)
        {
            return dao.Modificar(oCliente);
        }

        public bool DeleteCliente(Cliente oCliente)
        {
            return dao.Borrar(oCliente);
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

        public bool SavePelicula(Pelicula oPelicula)
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

        public List<Empleado> GetEmpleados()
        {
            throw new NotImplementedException();
        }

        public List<TipoFormaPago> GetFormasPagos()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
