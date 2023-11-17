using CineBack.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineBack.Fachada.Interfaz
{
    public interface IAplicacionCliente
    {
        List<Barrio> GetBarrios();
        Task<Cliente> GetClientesIdAsync(int id);
        bool SaveCliente(Cliente oCliente);

        bool ModifyCliente(int id, Cliente oCliente);

        bool DeleteCliente(int idCliente);


        List<Cliente> GetClientesFiltrados2(DateTime FechaDesde, DateTime FechaHasta, int idBarrio, string apellido);
    }
}
