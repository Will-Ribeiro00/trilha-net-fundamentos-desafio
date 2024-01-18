namespace DesafioFundamentosVS.Models
{
    public class Funcionario
    {
        public string Nome { get; private set; }
        public int Id { get; private set; }
        public int Senha { get; private set; }

        public Funcionario(string nome, int id, int senha)
        {
            Nome = nome;
            Id = id;
            Senha = senha;
        }
        public override string ToString()
        {
            return $"ID: #{Id} - Nome: {Nome}";
        }
    }
}
