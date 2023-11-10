using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineBack.Entidades
{
    public class Barrio
    {
        public string Descripcion { get; set; }
        public override string ToString()
        {
            return Descripcion; 
        }
    }
}
