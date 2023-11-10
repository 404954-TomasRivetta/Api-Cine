using CineBack.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineBack.Fachada.Interfaz
{
    public interface IAplicacion
    {
        #region MetodosCliente
        List<Barrio> GetBarrios();
        bool SaveCliente(Cliente oCliente);
        #endregion

        #region MetodosPelicula
        List<TipoPublico> GetTiposPublicos();
        List<Director> GetDirectores();

        List<Dialecto> GetDialectos();

        List<Actor> GetActoresPel();

        List<TipoPelicula> GetTiposPeliculas();

        bool SavePelicula(Pelicula oPelicula);

        #endregion

        #region MetodosComprobante
        List<Cliente> GetClientes();
        //List<Empleado> GetEmpleados();
        //List<FormaPago> GetFormasPagos();
        bool SaveComprobante(Comprobante oComprobante);
        #endregion
    }
}
