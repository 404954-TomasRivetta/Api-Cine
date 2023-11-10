using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineBack.Entidades
{
    public class Actor
    {
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public override string ToString()
        {
            return Nombre + " " + Apellido;
        }
    }
}
