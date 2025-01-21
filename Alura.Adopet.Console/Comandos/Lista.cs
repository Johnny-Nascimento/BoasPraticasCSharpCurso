using Alura.Adopet.Console.Serviço;

namespace Alura.Adopet.Console.Comandos
{
    [ComandosDocumentacao(documentacao: "list comando que exibe no terminal o conteúdo cadastrado na base dae dados da AdoPet.", instrucao: "list")]
    public class Lista : IComando
    {
        HttpClientPet client;

        public Lista()
        {
            client = new HttpClientPet("http://localhost:5057");
        }

        public async Task ExecutarAsync(string[] args)
        {
            await client.ListaDadosPetAPIAsync();
        }
    }
}
