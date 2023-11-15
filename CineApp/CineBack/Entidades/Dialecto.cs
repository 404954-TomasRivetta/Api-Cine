using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineBack.Entidades
{
    public class Dialecto
    {
        public int IdIdioma { get; set; }
        public string Descripcion { get; set; }

        public override string ToString()
        {
            return Descripcion;
        }
        public Dialecto(int id,string desc)
        {
            IdIdioma = id;
            Descripcion = desc;
        }
    }
}
