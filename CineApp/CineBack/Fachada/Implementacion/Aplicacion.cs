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
        IComprobanteDao daoComprobante;

        public Aplicacion()
        {
            dao = new ClienteDao();
            daoComprobante = new ComprobanteDao();
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
            return daoComprobante.Crear(oComprobante);
        }

        public List<Cliente> GetClientes()
        {
            return daoComprobante.GetClientes();
        }

        public List<Empleado> GetEmpleados()
        {
            return daoComprobante.GetEmpleados();
        }

        public List<TipoFormaPago> GetFormasPagos()
        {
            return daoComprobante.GetFormasPagos();
        }
        #endregion
    }
}
