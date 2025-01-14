using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Adopet.Console
{
    [AttributeUsage(AttributeTargets.Class)]
    internal class ComandosDocumentacao : System.Attribute
    {
        public ComandosDocumentacao(string documentacao, string instrucao)
        {
            Documentacao = documentacao;
            Instrucao = instrucao;
        }

        public string Documentacao { get; }
        public string Instrucao { get; }
    }
}
