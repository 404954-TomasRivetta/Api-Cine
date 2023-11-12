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
    public class AplicacionComprobante : IAplicacionComprobante
    {
        IComprobanteDao dao;

        public AplicacionComprobante()
        {
            dao = new ComprobanteDao();
        }
        public bool SaveComprobante(Comprobante oComprobante)
        {
            return dao.Crear(oComprobante);
        }

        public List<Cliente> GetClientes()
        {
            return dao.GetClientes();
        }

        public List<Empleado> GetEmpleados()
        {
            return dao.GetEmpleados();
        }

        public List<TipoFormaPago> GetFormasPagos()
        {
            return dao.GetFormasPagos();
        }
    }
}
