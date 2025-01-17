using Alura.Adopet.Console.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Adopet.Console.Serviço
{
    public class HttpClientPet
    {
        public HttpClient HttpClient { get; set; }

        public HttpClientPet(string uri)
        {
            HttpClient = ConfiguraHttpClient(uri);
        }

        public Task<HttpResponseMessage> CreatePetAsync(Pet pet)
        {
            HttpResponseMessage? response = null;
            using (response = new HttpResponseMessage())
            {
                return HttpClient.PostAsJsonAsync("pet/add", pet);
            }
        }

        public async Task<IEnumerable<Pet>> ListaDadosPetAPIAsync()
        {
            HttpResponseMessage response = await HttpClient.GetAsync("pet/list");
            var pets = await response.Content.ReadFromJsonAsync<IEnumerable<Pet>>();

            foreach (var pet in pets)
            {
                System.Console.WriteLine(pet);
            }

            return pets;
        }

        private HttpClient ConfiguraHttpClient(string url)
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
