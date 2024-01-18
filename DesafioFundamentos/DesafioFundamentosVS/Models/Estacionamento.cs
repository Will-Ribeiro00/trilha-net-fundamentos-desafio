namespace DesafioFundamentosVS.Models
{
    public class Estacionamento
    {
        public int SenhaAcesso { get; private set; } = 010203;
        public decimal PrecoInicial { get; private set; } = 10M;
        public decimal PrecoPorHora { get; private set; } = 5M;
        public Funcionario OperadorAtual { get; private set; }
        public List<Carro> Carros { get; private set; } = [];
        public List<Moto> Motos { get; private set; } = [];
        private List<string> HistoricoAdicaoVeiculo = [];
        private List<string> HistoricoRemocaoVeiculo = [];


        public void AdicionarCarro(Carro carroASerAdicionado)
        {
            Carros.Add(carroASerAdicionado);
            HistoricoAdicaoVeiculo.Add($"ID: {OperadorAtual.Id}, Funcionário: {OperadorAtual.Nome}, Carro: {carroASerAdicionado}"); ;
        }
        public void RemoverCarro(Carro carroASerRemovido)
        {
            Carros.Remove(carroASerRemovido);
            HistoricoRemocaoVeiculo.Add($"ID: {OperadorAtual.Id}, Funcionário: {OperadorAtual.Nome}, Carro: {carroASerRemovido} ");
        }
        public void AdicionarMoto(Moto motoASerAdicionada)
        {
            Motos.Add(motoASerAdicionada);
            HistoricoAdicaoVeiculo.Add($"ID: {OperadorAtual.Id}, Funcionário: {OperadorAtual.Nome}, Moto: {motoASerAdicionada}"); ;
        }
        public void RemoverMoto(Moto motoASerRemovida)
        {
            Motos.Remove(motoASerRemovida);
            HistoricoRemocaoVeiculo.Add($"ID: {OperadorAtual.Id}, Funcionário: {OperadorAtual.Nome}, Moto: {motoASerRemovida}");
        }
        public decimal ContaAPagar(TimeSpan permanencia)
        {
            decimal valorTotal = PrecoInicial + PrecoPorHora * (decimal)permanencia.TotalHours;
            return valorTotal;
        }
        public void ListarCarros(List<Carro> carros)
        {
            if (carros.Count == 0)
            {
                Console.WriteLine($"\nNão há nenhum carro estacionado aqui !");
            }
            else
            {
                for(int i = 0; i < carros.Count; i++)
                {
                    Console.WriteLine($"{i + 1}º Carro: {carros[i]}");
                }
            }
        }
        public void ListarMotos(List<Moto> motos)
        {
            if(motos.Count == 0)
            {
                Console.WriteLine("\nNão há nenhuma moto estacionada aqui !");
            }
            else
            {
                for(int i = 0; i <motos.Count; i++) 
                {
                    Console.WriteLine($"{i +1}º Moto: {motos[i]}");
                }
            }
        }
        public string HistoricoDeOperacoes()
        {
            return $"HISTÓRICO DE ADIÇÃO:" +
                $"\n{string.Join("\n", HistoricoAdicaoVeiculo)}" +
                "\n\n----------------------------------------------------------------------------------------------------------------" +
                $"\n\nHISTÓRICO DE REMOÇÃO:" +
                $"\n{string.Join("\n", HistoricoRemocaoVeiculo)}";
        }
        public void DefinirOperado(Funcionario operador)
        {
            OperadorAtual = operador;
        }
        public bool SetPrecoInicial(decimal preco)
        {
            if (preco != PrecoInicial)
            {
                if (preco > 0)
                {
                    PrecoInicial = preco;
                    return true;
                }
                else
                {
                    MensagemErro.ValorMenorQueZero();
                    return false;
                }
            }
            else
            {
                MensagemErro.ValoresIguais();
                return false;
            }
        }
        public bool SetPrecoPorHora(decimal preco)
        {
            if (preco != PrecoPorHora)
            {
                if (preco > 0)
                {
                    PrecoPorHora = preco;
                    return true;
                }
                else
                {
                    MensagemErro.ValorMenorQueZero();
                    return false;
                }
            }
            else
            {
                MensagemErro.ValoresIguais();
                return false;
            }
        }
    }
}