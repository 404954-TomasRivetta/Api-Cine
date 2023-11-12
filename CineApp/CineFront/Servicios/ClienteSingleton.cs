using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineFront.Servicio
{
<<<<<<< HEAD:CineApp/CineFront/Servicios/ClienteSingleton.cs
    internal class ClienteSingleton
    {
=======
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


>>>>>>> e768b01233634d4460b74e362709db828587009b:CineApp/CineFront/Servicio/ClienteSingleton.cs
    }
}
