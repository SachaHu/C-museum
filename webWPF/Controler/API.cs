using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;


using Newtonsoft.Json;

namespace webWPF.Controler
{
    public sealed class API
    {
        private static readonly HttpClient client = new HttpClient();
        private API()
        {
            client.BaseAddress = new Uri("http://localhost:5000/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        private static readonly object padlock = new object();
        private static API instance = null;
    }
}
