﻿using System;
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

        public async Task<string> GetAsync(string urlGet)
        {

            var result = await client.GetAsync(urlGet);

            var content = "";

            if (result.IsSuccessStatusCode)
            {
                content = await result.Content.ReadAsStringAsync();
            }
            //ME DEVUELVE UN JSON
            return content;

        }

        public async Task<string> PostAsync(string urlPost, string dataJson)
        {
            StringContent content = new StringContent(dataJson, Encoding.UTF8, "application/json");

            var result = await client.PostAsync(urlPost, content);

            var response = "";

            if (result.IsSuccessStatusCode)
            {
                response = await result.Content.ReadAsStringAsync();
            }

            return response;
        }

    }
}
