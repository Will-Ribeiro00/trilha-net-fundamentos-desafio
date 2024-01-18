using Xunit;
using DesafioFundamentosVS.Models;
namespace DesafioFundamentosVSTest
{

    public class VeiculoTest
    {
        [Theory]
        [InlineData("ABC1D23")]
        [InlineData("EFG4H56")]
        [InlineData("IJK7L89")]
        [InlineData("MNO2P34")]
        [InlineData("QRS5T67")]
        [InlineData("ABC1234")]
        [InlineData("DEF5678")]
        [InlineData("GHI9012")]
        [InlineData("JKL3456")]
        [InlineData("MNO7890")]
        public void VerificaSeAsPlacasEstaoNoFormatoMercoSulOuAntigoBrasilERetornarTrue(string placa)
        {
            //act
            var resultado = Veiculo.ValidarPlaca(placa);

            //Assert
            Assert.True(resultado);
        }
        [Theory]
        [InlineData("AB1C23")]
        [InlineData("DE4F5674")]
        [InlineData("GH7II89")]
        [InlineData("5JK0L12")]
        [InlineData("MN3O45")]
        [InlineData("ABC123")]
        [InlineData("CD5678")]
        [InlineData("9EF901")]
        [InlineData("WILL1001")]
        [InlineData("1234ABC")]
        public void VerificaSeAsPlacasEstaoNoFormatoMercoSulOuAntigoBrasilERetornarFalse(string placa)
        {
            //act
            var resultado = Veiculo.ValidarPlaca(placa);

            //Assert
            Assert.False(resultado);
        }

        [Theory]
        [InlineData("Honda", "CBR 600RR", "ABC1D23")]
        [InlineData("Yamaha", "YZF-R1", "DKL2E78")]
        [InlineData("Suzuki", "GSX-R1000", "ghi3f12")]
        [InlineData("Kawasaki", "Ninja ZX-10R", "JKL4G56")]
        [InlineData("Ducati", "Panigale V4", "mmp5h90")]
        [InlineData("Ford", "Mustang", "PQR-1234")]
        [InlineData("Chevrolet", "Camaro", "STU5678")]
        [InlineData("BMW", "M3", "ytq-9012")]
        [InlineData("Audi", "R8", "zkp-3456")]
        [InlineData("Mercedes-Benz", "AMG GT", "BCD7890")]
        public void VerificaSeOObjetoEstaSendoConstruidoCorretamenteESeOMetodoToStringRetornaOValorMarcaModeloEPlacaCorretamente(string marca, string modelo, string placa)
        {
            // Arrange
            var veiculo = new Veiculo(marca, modelo, placa);

            // Act
            var resultado = veiculo.ToString();

            // Assert
            Assert.Equal($"Marca: {marca}, Modelo: {modelo}, Placa: {placa.ToUpper()}", resultado);
        }

    }
}
