using Alura.Adopet.Console.Modelos;
using Alura.Adopet.Console.Util;

namespace AluraAdopetTestes
{
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
        public void QuandoStringForVaziaDeveRetornarNull()
        {
            // Arrange
            string linha = "";

            // Act
            Pet? pet = linha.ConverteDoTexto();

            // Assert
            Assert.Null(pet);
        }

        [Fact]
        public void QuandoStringForNullDeveRetornarNull()
        {
            // Arrange
            string linha = null;

            // Act
            Pet? pet = linha.ConverteDoTexto();

            // Assert
            Assert.Null(pet);
        }

        [Fact]
        public void QuandoQuantidadeCamposFaltantesDeveRetornarNull()
        {
            // Arrange
            // Guid;Nome Pet;Tipo Pet
            string linha = "456b24f4-19e2-4423-845d-4a80e8854a41;Lima Limão";

            // Act
            Pet? pet = linha.ConverteDoTexto();

            // Assert
            Assert.Null(pet);
        }

        [Fact]
        public void QuandoStringTiverGuidInvalidoDeveRetornarNull()
        {
            // Arrange
            string linha = "123;Lima Limão;1";

            // Act
            Pet? pet = linha.ConverteDoTexto();

            // Assert
            Assert.Null(pet);
        }


        [Fact]
        public void QuandoStringTiverTipoInvalidoDeveRetornarNull()
        {
            // Arrange
            string linha = "456b24f4-19e2-4423-845d-4a80e8854a41;Lima Limão;99";

            // Act
            Pet? pet = linha.ConverteDoTexto();

            // Assert
            Assert.Null(pet);
        }
    }
}
