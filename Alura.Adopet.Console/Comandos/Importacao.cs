using Alura.Adopet.Console.Modelos;
using Alura.Adopet.Console.Serviço;
using Alura.Adopet.Console.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Adopet.Console.Comandos
{
    [ComandosDocumentacao(documentacao: "import <arquivo> comando que realiza a importação do arquivo de pets.", instrucao: "import")]
    internal class Importacao : IComando
    {
        HttpClientPet client;

        public Importacao()
        {
            client = new HttpClientPet("http://localhost:5057");
        }

        public async Task ExecutarAsync(string[] args)
        {
            await FazImportacaoAsync(caminhoDoArquivoASerImportado:args[1]);
        }

        private async Task FazImportacaoAsync(string caminhoDoArquivoASerImportado)
        {
            LeitorDeArquivo leitorDeArquivo = new LeitorDeArquivo();
            List<Pet> listaDePet = leitorDeArquivo.RealizaLeitura(caminhoDoArquivoASerImportado);

            foreach (var pet in listaDePet)
            {
                try
                {
                    var resposta = await client.CreatePetAsync(pet);
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine(ex.Message);
                }
            }

            System.Console.WriteLine("Importação concluída!");
        }
    }
}
