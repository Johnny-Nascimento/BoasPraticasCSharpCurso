using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Adopet.Console
{
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
