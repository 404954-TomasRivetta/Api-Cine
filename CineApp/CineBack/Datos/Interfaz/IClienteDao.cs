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
        int Modificar(Cliente cliente);
        bool Borrar(Cliente cliente);
<<<<<<< HEAD
        bool Crear(Cliente cliente);        
        List<Barrio> TraerBarrios();        
        Cliente TraerClienteId(int id);
=======
        bool Crear(Cliente cliente);
        List<Barrio> TraerBarrios();

        List<Cliente> ObtenerClientesFiltrados(DateTime FechaDesde, DateTime FechaHasta, int idBarrio, string apellido);
>>>>>>> f4cf6cf7b06d82b0446dc4567daf204543900e4a
    }
}
