using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineBack.Entidades
{
    public class Barrio
    { 
        public int BarrioNro { get; set; }
        public string Descripcion { get; set; }
        public override string ToString()
        {
            return Descripcion; 
        }
        public Barrio(int barrioNro,string descripcion)
        {
            BarrioNro= barrioNro;
            Descripcion=descripcion;
        }
    }
}
