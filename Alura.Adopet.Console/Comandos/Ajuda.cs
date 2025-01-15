using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Adopet.Console.Comandos
{
    [ComandosDocumentacao(documentacao: "help [comando] para obter mais informações sobre um comando.\nhelp <NOME DO COMANDO> para acessar a ajuda de um comando especifico", instrucao: "help")]
    internal class Ajuda : IComando
    {
        private Dictionary<string, ComandosDocumentacao> ComandosDocumentacao;
        public Ajuda()
        {
            ComandosDocumentacao = Assembly.GetExecutingAssembly().GetTypes()
                .Where(t => t.GetCustomAttributes<ComandosDocumentacao>().Any())
                .SelectMany(t => t.GetCustomAttributes<ComandosDocumentacao>()!)
                .ToDictionary(d => d.Instrucao, d => d);

        }

        public Task ExecutarAsync(string[] args)
        {
            MostraInformacoesDeAjuda(opcaoDeAjuda: args.Length == 2 ? args[1] : string.Empty);

            return Task.CompletedTask;
        }

        private void MostraInformacoesDeAjuda(string opcaoDeAjuda)
        {
            System.Console.WriteLine("Lista de comandos.");

            if (opcaoDeAjuda == string.Empty)
            {
                System.Console.WriteLine("adopet help <parametro> ous simplemente adopet help  " +
                     "comando que exibe informações de ajuda dos comandos.");
                System.Console.WriteLine("Adopet (1.0) - Aplicativo de linha de comando (CLI).");
                System.Console.WriteLine("Realiza a importação em lote de um arquivos de pets.");

                System.Console.WriteLine("Comando possíveis: ");

                foreach (var documentacao in ComandosDocumentacao.Values)
                {
                    System.Console.WriteLine(documentacao.Documentacao);
                }
            }
            else
            {
                ComandosDocumentacao? comandoDocumentacao;
                ComandosDocumentacao.TryGetValue(opcaoDeAjuda, out comandoDocumentacao);

                if (comandoDocumentacao == null)
                    System.Console.WriteLine($"Não existe documentação para {opcaoDeAjuda}");
                else
                    System.Console.WriteLine(comandoDocumentacao.Documentacao);
            }
        }
    }
}
