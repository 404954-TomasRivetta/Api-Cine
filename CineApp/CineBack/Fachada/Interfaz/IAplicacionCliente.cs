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

        bool SaveCliente(Cliente oCliente);

        bool ModifyCliente(Cliente oCliente);

        bool DeleteCliente(Cliente oCliente);
    }
}
