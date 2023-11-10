using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineBack.Entidades
{
    internal class Comprobante
    {
        public int id_cliente { get; set; }
        public int id_forma_pago { get; set; }
        public int id_empleado { get; set; }
        public int cant_entradas { get; set; }
        public List<Tickets> tickets { get; set; }
        public Comprobante()
        {
            tickets = new List<Tickets>();
        }
        public void AgregarTicket(Tickets ticket)
        {
            tickets.Add(ticket);
        }
        public void QuitarTicket(int posicion)
        {
            tickets.RemoveAt(posicion);
        }
    }
}
