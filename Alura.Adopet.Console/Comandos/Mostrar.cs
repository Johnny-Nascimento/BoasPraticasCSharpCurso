using Alura.Adopet.Console.Modelos;
using Alura.Adopet.Console.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Adopet.Console.Comandos
{
    [ComandosDocumentacao(documentacao: "show   <arquivo> comando que exibe no terminal o conteúdo do arquivo importado.", instrucao: "show")]
    internal class Mostrar
    {
        public void MostrarPets(string caminhoArquivoASerExibido)
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
