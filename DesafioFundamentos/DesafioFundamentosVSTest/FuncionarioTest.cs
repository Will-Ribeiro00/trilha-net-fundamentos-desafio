using DesafioFundamentosVS.Models;
using Xunit;

namespace DesafioFundamentosVSTest
{
    public class FuncionarioTest
    {
        [Theory]
        [InlineData("William", 01, 1234)]
        [InlineData("Lilian", 02, 2345)]
        [InlineData("Rafael", 03, 3456)]
        [InlineData("Pedro", 04, 4567)]
        [InlineData("Isabelly", 05, 5678)]
        [InlineData("Anna", 06, 6789)]
        [InlineData("Felipe", 07, 7890)]
        [InlineData("Elaine", 08, 8901)]
        [InlineData("Cleber", 09, 9012)]
        [InlineData("Giovanna", 10, 1012)]
        public void VerificaSeOObjetoEstaSendoConstruidoCorretamenteEOMetodoToStringEstaRetornandoOValorEsperadoIdENome(string nome, int id, int senha)
        {
            //Arrange
            var funcionario = new Funcionario(nome, id, senha);
            //Act
            var resultado = funcionario.ToString();
            //Assert
            Assert.Equal($"ID: #{id} - Nome: {nome}", resultado);
        }
    }
}
