using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineBack.Entidades
{
    public class Empleado
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public override string ToString()
        {
            return Nombre+' '+Apellido;
        }
    }
}
