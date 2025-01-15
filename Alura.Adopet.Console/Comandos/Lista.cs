using Alura.Adopet.Console.Modelos;
using Alura.Adopet.Console.Serviço;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Adopet.Console.Comandos
{
    [ComandosDocumentacao(documentacao: "list comando que exibe no terminal o conteúdo cadastrado na base dae dados da AdoPet.", instrucao: "list")]
    internal class Lista : IComando
    {
        HttpClientPet client;

        public Lista()
        {
            client = new HttpClientPet("http://localhost:5057");
        }

        public async Task ExecutarAsync(string[] args)
        {
            await ListaDadosPetAPIAsync();
        }

        private async Task ListaDadosPetAPIAsync()
        {
            HttpResponseMessage response = await client.HttpClient.GetAsync("pet/list");
            var pets = await response.Content.ReadFromJsonAsync<IEnumerable<Pet>>();

            foreach (var pet in pets)
            {
                System.Console.WriteLine(pet);
            }
        }
    }
}
