using Alura.Adopet.Console.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Adopet.Console.Util
{
    internal class LeitorDeArquivo
    {
        public List<Pet> RealizaLeitura(string caminhoDoArquivoASerImportado)
        {
            List<Pet> listaDePet = new List<Pet>();

            using (StreamReader sr = new StreamReader(caminhoDoArquivoASerImportado))
            {
                while (!sr.EndOfStream)
                {
                    Pet? pet = sr.ReadLine().ConverteDoTexto();

                    if (pet == null)
                    {
                        System.Console.WriteLine("Linha inválida");
                        continue;
                    }

                    System.Console.WriteLine(pet);
                    listaDePet.Add(pet);
                }
            }

            return listaDePet;
        }
    }
}
