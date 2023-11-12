using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineFront.Servicio
{
    public class ClienteSingleton
    {
        private static ClienteSingleton instancia;

        private HttpClient client;

        private ClienteSingleton()
        {
            client = new HttpClient();
        }

        public static ClienteSingleton getInstance()
        {

            if (instancia == null)
            {
                instancia = new ClienteSingleton();
            }
            return instancia;

        }


    }
}
