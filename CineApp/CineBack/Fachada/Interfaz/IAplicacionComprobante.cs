using CineBack.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineBack.Fachada.Interfaz
{
    public interface IAplicacionComprobante
    {
        List<Cliente> GetClientes();
        List<Empleado> GetEmpleados();
        List<TipoFormaPago> GetFormasPagos();
        bool SaveComprobante(Comprobante oComprobante);
    }
}
