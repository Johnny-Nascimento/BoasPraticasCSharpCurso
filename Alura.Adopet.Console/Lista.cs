using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Adopet.Console
{
    internal class Lista
    {
        HttpClient client;

        public Lista()
        {
            client = ConfiguraHttpClient("http://localhost:5057");
        }

        public async Task ListaDadosPetAPIAsync()
        {
            HttpResponseMessage response = await client.GetAsync("pet/list");
            var pets = await response.Content.ReadFromJsonAsync<IEnumerable<Pet>>();

            foreach (var pet in pets)
            {
                System.Console.WriteLine(pet);
            }
        }

        HttpClient ConfiguraHttpClient(string url)
        {
            HttpClient _client = new HttpClient();
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            _client.BaseAddress = new Uri(url);
            return _client;
        }
    }
}
