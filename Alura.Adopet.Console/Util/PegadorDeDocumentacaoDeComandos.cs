using Alura.Adopet.Console.Comandos;
using System;
using System.Reflection;

namespace Alura.Adopet.Console.Util
{
    public class PegadorDeDocumentacaoDeComandos
    {
        public Dictionary<string, ComandosDocumentacao> PegaTodasAsDocumentacoes()
        {
            return AppDomain.CurrentDomain.GetAssemblies().AsParallel()
                .SelectMany(assembly => assembly.GetTypes())
                .Where(type => type.GetCustomAttributes(typeof(ComandosDocumentacao), false).Any())
                .SelectMany(t => t.GetCustomAttributes<ComandosDocumentacao>()!)
                .ToDictionary(d => d.Instrucao, d => d);
        }
    }
}
