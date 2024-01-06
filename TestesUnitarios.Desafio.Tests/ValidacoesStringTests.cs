using TestesUnitarios.Desafio.Console.Services;
using Xunit;  // Assuming you have XUnit installed

namespace TestesUnitarios.DesafioTests
{
    public class ValidacoesStringTests
    {
        private readonly ValidacoesString _validacoes = new ValidacoesString();  // Instantiate the class

        [Fact]
        public void DeveRetornar6QuantidadeCaracteresDaPalavraMatrix()
        {
            // Arrange
            var texto = "Matrix";
            var resultadoEsperado = 6;

            // Act
            var resultado = _validacoes.RetornarQuantidadeCaracteres(texto);

            // Assert
            Assert.Equal(resultadoEsperado, resultado);
        }

        // ... other test methods ...
    }
}
