namespace DesafioFundamentosVS.Models
{
    public class MensagemErro
    {
        // Erros do veiculos:
        public static string PlacaInvalida()
        {
            return "\nErro: Placa inválida ! \nEx.Placa Merco Sul(ABC1D23) \nEx.Placa Brasil Antiga(ABC1234)";
        }
        // Erros de hora:
        public static string HoraInvalida()
        {
            return "\nErro: Hora inválida, por favor insira uma hora no formato (hh:mm): " ;
        }
        // Erros de lista Adicionados/Removidos:
        public static string VeiculoJaAdicionado()
        {
            return "\nErro: Veículo já adicionado no estacionamento !";
        }
        public static string VeiculoInexistente()
        {
            return "\nErro: Veículo não estacionado aqui. Confira se digitou a placa corretamente";
        }
        //Erros de valores:
        public static string ValorMenorQueZero()
        {
            return "\nErro: O valor não pode ser menor que 0 !";
        }   
        public static string ValoresIguais()
        {
            return "\nErro: Novo valor não pode ser idêntico ao valor atual !";
        }
        public static string ValorDecimal()
        {
            return "\nErro: Valor inválido ! O novo valor deve ser um número decimal\nInforme o novo valor: ";
        }
        //Erros de funcionário:
        public static string IdInvalido()
        {
            return "\nErro: ID inválido ! \nInforme o número do id do funcionário: ";
        }
        public static string SenhaFuncioarioInvalida()
        {
            return "\nErro: Senha inválida ! \nInforme o número da senha do funcionário: ";
        }
        public static string CredencialInvalida()
        {
            return "\nErro: ID do funcionário ou senha incorreto !";
        }
        //Erro da Senha Mestre
        public static string SenhaMestreInvalida()
        {
            return "\nErro: Senha inválida! A senha de acesso deve ser numérica\nInforme a senha de acesso: ";
        }
        public static string SenhaMestreErrada()
        {
            return "\nErro: Senha inválida !";
        }
        //Erro switch 
        public static string OpcaoInvalida()
        {
            return "\nErro: Opção Inválida !";
        }
    }
}
