using CineBack.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineBack.Datos.Interfaz
{
    public interface IComprobanteDao
    {
        bool Crear(Comprobante oC);
        List<Cliente> GetClientes();
        List<Empleado> GetEmpleados();
        List<TipoFormaPago> GetFormasPagos();
    }
}
