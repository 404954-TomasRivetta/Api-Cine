using CineBack.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineBack.Datos.Interfaz
{
    public interface IClienteDao
    {
        bool Modificar(int id,Cliente cliente);
        bool Borrar(int IdCliente);

        bool Crear(Cliente cliente);        
        List<Barrio> TraerBarrios();        
        Cliente TraerClienteId(int id);

        List<Cliente> ObtenerClientesFiltrados(DateTime FechaDesde, DateTime FechaHasta, int idBarrio, string apellido);

    }
}
