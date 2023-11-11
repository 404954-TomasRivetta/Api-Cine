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
        bool Modificar(Cliente cliente);
        bool Borrar(Cliente cliente);
        bool Crear(Cliente cliente);
        List<Barrio> TraerBarrios(int codBarrio);
    }
}
