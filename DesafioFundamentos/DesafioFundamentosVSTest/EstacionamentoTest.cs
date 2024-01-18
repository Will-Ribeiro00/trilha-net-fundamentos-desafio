using Xunit;
using DesafioFundamentosVS.Models;
namespace DesafioFundamentosVSTest
{
    public class EstacionamentoTest
    {
        [Theory]
        [InlineData("Fiat", "Uno", "ABC-1234")]
        [InlineData("Ford", "Mustang", "PQR-1234")]
        [InlineData("Chevrolet", "Camaro", "STU5678")]
        [InlineData("BMW", "M3", "ytq-9012")]
        [InlineData("Audi", "R8", "zkp-3456")]
        public void UtilizaOMetodoAdicionarCarroNosObjetosERestornaSeOObjetoFoiDeFatoAdicionado(string marca, string modelo, string placa)
        {
            //Arrange
            Estacionamento e = new();
            Funcionario f = new("William", 01, 4564);
            e.DefinirOperado(f);
            Carro carroASerTestado = new(marca, modelo, placa);
            //Act
            e.AdicionarCarro(carroASerTestado);
            //Assert
            Assert.Contains(carroASerTestado, e.Carros);
        }

        [Theory]
        [InlineData("Fiat", "Uno", "ABC-1234")]
        [InlineData("Ford", "Mustang", "PQR-1234")]
        [InlineData("Chevrolet", "Camaro", "STU5678")]
        [InlineData("BMW", "M3", "ytq-9012")]
        [InlineData("Audi", "R8", "zkp-3456")]
        public void UtilizaOMetodoRemoverCarroNosObjetosERetornaSeOOjetoFoiDeFatoRemovido(string marca, string modelo, string placa)
        {
            //Arrange
            Estacionamento e = new();
            Funcionario f = new("William", 01, 4564);
            e.DefinirOperado(f);
            Carro carroASerTestado = new(marca, modelo, placa);

            //Act
            e.RemoverCarro(carroASerTestado);

            //Assert
            Assert.DoesNotContain(carroASerTestado, e.Carros);
        }

        [Theory]
        [InlineData("Honda", "CBR 600RR", "ABC1D23")]
        [InlineData("Yamaha", "YZF-R1", "DKL2E78")]
        [InlineData("Suzuki", "GSX-R1000", "ghi3f12")]
        [InlineData("Kawasaki", "Ninja ZX-10R", "JKL4G56")]
        [InlineData("Ducati", "Panigale V4", "mmp5h90")]
        public void UtilizaOMetodoRemoverMotoNosObjetosERestornaSeOObjetoFoiDeFatoRemovido(string marca, string modelo, string placa)
        {
            //Arrange
            Estacionamento e = new();
            Funcionario f = new("William", 01, 4564);
            e.DefinirOperado(f);
            Moto motoASerTestada = new(marca, modelo, placa);
            //Act
            e.RemoverMoto(motoASerTestada);
            //Assert
            Assert.DoesNotContain(motoASerTestada, e.Motos);
        }

        [Theory]
        [InlineData("Honda", "CBR 600RR", "ABC1D23")]
        [InlineData("Yamaha", "YZF-R1", "DKL2E78")]
        [InlineData("Suzuki", "GSX-R1000", "ghi3f12")]
        [InlineData("Kawasaki", "Ninja ZX-10R", "JKL4G56")]
        [InlineData("Ducati", "Panigale V4", "mmp5h90")]
        public void UtilizaOMetodoAdicionarMotoNosObjetosERestornaSeOObjetoFoiDeFatoAdicionado(string marca, string modelo, string placa)
        {
            //Arrange
            Estacionamento e = new();
            Funcionario f = new("William", 01, 4564);
            e.DefinirOperado(f);
            Moto motoASerTestada = new(marca, modelo, placa);
            //Act
            e.AdicionarMoto(motoASerTestada);
            //Assert
            Assert.Contains(motoASerTestada, e.Motos);
        }

        [Theory]
        [InlineData(10.01)]
        [InlineData(7)]
        [InlineData(11.50)]
        [InlineData(5.25)]
        public void UtilizaOMetodoSetPrecoInicialParaAlterarOvalorDoAtributoPrecoInicialERetornarTrue(decimal preco)
        {
            //Arrange
            Estacionamento e = new();
            //Act
            var resultado = e.SetPrecoInicial(preco);
            //Assert
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(10)]
        [InlineData(-5.50)]
        [InlineData(-10+10)]
        [InlineData(0.00)]
        public void UtilizaOMetodoSetPrecoInicialParaAlterarOvalorDoAtributoPrecoInicialERetornarFalse(decimal preco)
        {
            //Arrange
            Estacionamento e = new();
            //Act
            var resultado = e.SetPrecoInicial(preco);
            //Assert
            Assert.False(resultado);
        }

        [Theory]
        [InlineData(2)]
        [InlineData(15.25)]
        [InlineData(236.33)]
        public void UtilizaOMetodoSetPrecoPorHoraParaAlterarOvalorDoAtributoPrecoInicialERetornarTrue(decimal preco)
        {
            //Arrange
            Estacionamento e = new();   
            //Act
            var resultado = e.SetPrecoPorHora(preco);
            //Assert
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(5)]
        [InlineData(-1)]
        [InlineData(-10-5.55)]
        public void UtilizaOMetodoSetPrecoPorHoraParaAlterarOvalorDoAtributoPrecoInicialERetornarFalse(decimal preco)
        {
            //Arrange
            Estacionamento e = new();
            //Act
            var resultado = e.SetPrecoPorHora(preco);
            //Assert
            Assert.False(resultado);
        }

        [Theory]
        [InlineData("William", 01, 1234)]
        [InlineData("Jhennyfer", 02, 2345)]
        [InlineData("Luan", 04, 4567)]
        [InlineData("Isabelly", 05, 5678)]
        [InlineData("Anna", 06, 6789)]
        public void VerificaSeOMetodoDefinirOperadorlRetornaOFuncionarioCorreto(string nome, int id, int senha)
        {
            //arrange
            Estacionamento e = new();
            Funcionario f = new(nome, id, senha);
            //Act
            e.DefinirOperado(f);
            //Assert
            Assert.Equal(f, e.OperadorAtual);
        }
    }
}