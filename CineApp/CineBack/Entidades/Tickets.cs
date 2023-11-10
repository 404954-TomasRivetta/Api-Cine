using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineBack.Entidades
{
    internal class Tickets
    {
        public int id_comprobante { get; set; }
        public int id_butaca { get; set; }
        public double pre_unitario { get; set; }

        public Tickets()
        {
            id_comprobante = 0;
            id_butaca = 0;
            pre_unitario = 0;
        }
        public Tickets(int com,int but,decimal pre)
        {
            id_comprobante = com;
            id_butaca = but;
            pre_unitario = pre;
        }
    }
}
