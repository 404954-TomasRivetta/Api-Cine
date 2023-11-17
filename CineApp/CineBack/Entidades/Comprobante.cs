using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineBack.Entidades
{
    public class Comprobante
    {
        public int IdCliente { get; set; }
        public int IdForma_pago { get; set; }
        public int IdEmpleado { get; set; }
        public int CantEntradas { get; set; }
    }
}
