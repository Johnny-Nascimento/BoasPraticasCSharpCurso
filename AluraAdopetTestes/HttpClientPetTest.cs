using Alura.Adopet.Console.Modelos;
using Alura.Adopet.Console.Serviço;

namespace AluraAdopetTestes
{
    public class HttpClientPetTest
    {
        [Fact]
        public async Task ListaPetsDeveRetornarUmaListaNaoNullaENaoVazia()
        {
            HttpClientPet clientAdopet = new HttpClientPet(uri:"http://localhost:5057");

            IEnumerable<Pet> pets = await clientAdopet.ListaDadosPetAPIAsync();

            Assert.NotNull(pets);
            Assert.NotEmpty(pets);
        }

        [Fact]
        public async Task QuandoAPIForaDeveRetornarExcecao()
        {
            HttpClientPet clientAdopet = new HttpClientPet(uri:"http://localhost:1111");
            await Assert.ThrowsAnyAsync<Exception>(() => clientAdopet.ListaDadosPetAPIAsync());
        }
    }
}