using Xunit;
using DesafioFundamentosVS.Models;
using System.Runtime.ConstrainedExecution;
namespace DesafioFundamentosVSTest
{
    public class MensagemErroTest
    {
        [Fact]
        public void DeveLerAMensagemNumaStringEVerificarSeEhIgualAoMetodoM_PlacaInvalida()
        {
            //Arrange
            string mensagem = "\nErro: Placa inválida ! \nEx.Placa Merco Sul(ABC1D23) \nEx.Placa Brasil Antiga(ABC1234)";

            //Assert
            Assert.Equal(mensagem, MensagemErro.PlacaInvalida());
        }
        [Fact]
        public void DeveLerAMensagemNumaStringEVerificarSeEhIgualAoMetodoM_HoraInvalida()
        {
            //Arrange
            string mensagem = "\nErro: Hora inválida, por favor insira uma hora no formato (hh:mm): ";

            //Assert
            Assert.Equal(mensagem, MensagemErro.HoraInvalida());
        }
        [Fact]
        public void DeveLerAMensagemNumaStringEVerificarSeEhIgualAoMetodoM_VeiculoJaAdicionado()
        {
            //Arrange
            string mensagem = "\nErro: Veículo já adicionado no estacionamento !";

            //Assert
            Assert.Equal(mensagem, MensagemErro.VeiculoJaAdicionado());
        }
        [Fact]
        public void DeveLerAMensagemNumaStringEVerificarSeEhIgualAoMetodoM_VeiculoInexistente()
        {
            //Arrange
            string mensagem = "\nErro: Veículo não estacionado aqui. Confira se digitou a placa corretamente";

            //Assert
            Assert.Equal(mensagem, MensagemErro.VeiculoInexistente());
        }
        [Fact]
        public void DeveLerAMensagemNumaStringEVerificarSeEhIgualAoMetodoM_ValorMenorQue0()
        {
            //Arrange
            string mensagem = "\nErro: O valor não pode ser menor que 0 !";

            //Assert
            Assert.Equal(mensagem, MensagemErro.ValorMenorQueZero());
        }
        [Fact]
        public void DeveLerAMensagemNumaStringEVerificarSeEhIgualAoMetodoM_ValoresIguais()
        {
            //Arrange
            string mensagem = "\nErro: Novo valor não pode ser idêntico ao valor atual !";

            //Assert
            Assert.Equal(mensagem, MensagemErro.ValoresIguais());
        }
        [Fact]
        public void DeveLerAMensagemNumaStringEVerificarSeEhIgualAoMetodoM_ValorDecimal()
        {
            //Arrange
            string mensagem = "\nErro: Valor inválido ! O novo valor deve ser um número decimal\nInforme o novo valor: ";

            //Assert
            Assert.Equal(mensagem, MensagemErro.ValorDecimal());
        }
        [Fact]
        public void DeveLerAMensagemNumaStringEVerificarSeEhIgualAoMetodoM_IdInvalido()
        {
            //Arrange
            string mensagem = "\nErro: ID inválido ! \nInforme o número do id do funcionário: ";

            //Assert
            Assert.Equal(mensagem, MensagemErro.IdInvalido());
        }
        [Fact]
        public void DeveLerAMensagemNumaStringEVerificarSeEhIgualAoMetodoM_SenhaFuncionarioInvalida()
        {
            //Arrange
            string mensagem = "\nErro: Senha inválida ! \nInforme o número da senha do funcionário: ";

            //Assert
            Assert.Equal(mensagem, MensagemErro.SenhaFuncioarioInvalida());
        }
        [Fact]
        public void DeveLerAMensagemNumaStringEVerificarSeEhIgualAoMetodoM_CredencialInvalida()
        {
            //Arrange
            string mensagem = "\nErro: ID do funcionário ou senha incorreto !";

            //Assert
            Assert.Equal(mensagem, MensagemErro.CredencialInvalida());
        }
        [Fact]
        public void DeveLerAMensagemNumaStringEVerificarSeEhIgualAoMetodoM_SenhaMestreInvalida()
        {
            //Arrange
            string mensagem = "\nErro: Senha inválida! A senha de acesso deve ser numérica\nInforme a senha de acesso: ";

            //Assert
            Assert.Equal(mensagem, MensagemErro.SenhaMestreInvalida());
        }
        [Fact]
        public void DeveLerAMensagemNumaStringEVerificarSeEhIgualAoMetodoM_SenhaMestreErrada()
        {
            //Arrange
            string mensagem = "\nErro: Senha inválida !";

            //Assert
            Assert.Equal(mensagem, MensagemErro.SenhaMestreErrada());
        }
        [Fact]
        public void DeveLerAMensagemNumaStringEVerificarSeEhIgualAoMetodoM_OpcaoInvalida()
        {
            //Arrange
            string mensagem = "\nErro: Opção Inválida !";

            //Assert
            Assert.Equal(mensagem, MensagemErro.OpcaoInvalida());
        }
    }
}
