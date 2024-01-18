using System.Text.RegularExpressions;
namespace DesafioFundamentosVS.Models
{
    public class Veiculo
    {
        public string Marca { get; private set; }
        public string Modelo { get; private set; }
        public string Placa { get; private set; }

        private static readonly Regex PlacaMercoSul = new(@"^[A-Za-z]{3}[0-9]{1}[A-Za-z]{1}[A-Za-z0-9]{2}$");
        private static readonly Regex PlacaAntigaBrasil = new(@"^[A-Za-z]{3}[0-9]{4}$");

        public Veiculo(string marca, string modelo, string placa)
        {
            Marca = FirstToUpper(marca);
            Modelo = FirstToUpper(modelo);
            Placa = placa.ToUpper();
        }
        public static bool ValidarPlaca(string placa)
        {
            if (!PlacaMercoSul.IsMatch(placa) && !PlacaAntigaBrasil.IsMatch(placa))
            {
                MensagemErro.PlacaInvalida();
                return false;
            }
            else
            {
                return true;
            }
        }
        public override string ToString()
        {
            return $"Marca: {Marca}, Modelo: {Modelo}, Placa: {Placa}";
        }
        public static string FirstToUpper(string input)
        {
            return input.First().ToString().ToUpper() + input.Substring(1);
        }

    }
}
