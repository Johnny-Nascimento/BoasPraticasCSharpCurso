using Alura.Adopet.Console.Modelos;
using Alura.Adopet.Console.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluraAdopetTestes
{
    // Desafio 1
    // Testar:
    // Null, vazia, quantidade insuficiente de campos, guid inválido e tipo inválido

    // Desafio 2:
    // Extrair o código do contrutor do Help par auma class e criar testes para o help

    public class ConversorCsvParaPetTest
    {
        [Fact]
        public void QuandoStringForValidaDeveRetornarUmObjetoPet()
        {
            // Arrange
            string linha = "456b24f4-19e2-4423-845d-4a80e8854a41;Lima Limão;1";

            // Act
            Pet? pet = linha.ConverteDoTexto();

            // Assert
            Assert.NotNull(pet);
        }

        [Fact]
        public void QuandoStringNaoForValidaDeveRetornarNull()
        {
            // Arrange
            string linha = "";

            // Act
            Pet? pet = linha.ConverteDoTexto();

            // Assert
            Assert.Null(pet);
        }
    }
}
