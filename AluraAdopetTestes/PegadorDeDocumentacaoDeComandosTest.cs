using Alura.Adopet.Console.Comandos;
using Alura.Adopet.Console.Modelos;
using Alura.Adopet.Console.Serviço;
using Alura.Adopet.Console.Util;
using System;
using System.Collections.Generic;
using System.Windows.Input;

namespace AluraAdopetTestes
{
    [ComandosDocumentacao(documentacao: "DocumentacaoMock", instrucao: "mock")]
    public class Mock
    {
    }

    public class PegadorDeDocumentacaoDeComandosTest
    {
        Mock mock;
        public PegadorDeDocumentacaoDeComandosTest()
        {
            mock = new Mock();
        }

        [Fact]
        public void PegaDocumentacaoMock()
        {
            PegadorDeDocumentacaoDeComandos pegadorDeDocumentacaoDeComandos = new PegadorDeDocumentacaoDeComandos();

            Dictionary<string, ComandosDocumentacao> comandoDoc = pegadorDeDocumentacaoDeComandos.PegaTodasAsDocumentacoes();

            Assert.Equal("DocumentacaoMock", comandoDoc["mock"].Documentacao);
        }
    }
}
