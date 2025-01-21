using Alura.Adopet.Console.Modelos;
using Alura.Adopet.Console.Util;

namespace Alura.Adopet.Console.Comandos
{
    [ComandosDocumentacao(documentacao: "show   <arquivo> comando que exibe no terminal o conteúdo do arquivo importado.", instrucao: "show")]
    public class Mostrar : IComando
    {
        public Task ExecutarAsync(string[] args)
        {
            MostrarPets(args[1]);

            return Task.CompletedTask;
        }

        private void MostrarPets(string caminhoArquivoASerExibido)
        {
            LeitorDeArquivo leitorDeArquivo = new LeitorDeArquivo();
            List<Pet> listaDePet = leitorDeArquivo.RealizaLeitura(caminhoArquivoASerExibido);

            foreach (var pet in listaDePet)
            {
                System.Console.WriteLine(pet);
            }
        }
    }
}
