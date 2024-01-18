using DesafioFundamentosVS.Models;
using System;

Console.OutputEncoding = System.Text.Encoding.UTF8;
bool programa = true;
int id, senha, senhaAcesso = 0;
List<Funcionario> funcionarios =
[
    new Funcionario("William", 001, 4564),
    new Funcionario("Isabelly", 002, 9055),
    new Funcionario("Felipe", 003, 4876)
];

Estacionamento es = new();

while (programa)
{
    Console.Write("\nInforme o ID do funcionaro: ");
    while (!int.TryParse(Console.ReadLine(), out id))
    {
        Console.WriteLine(MensagemErro.IdInvalido());
        Console.ReadKey();
    }
    Console.Write("Informe a senha: ");
    while (!int.TryParse(Console.ReadLine(), out senha))
    {
        Console.WriteLine(MensagemErro.SenhaFuncioarioInvalida());
        Console.ReadKey();
    }

    Funcionario funcionarioLogado = funcionarios.FirstOrDefault(f => f.Id == id && f.Senha == senha);
    if (funcionarioLogado != null)
    {
        es.DefinirOperado(funcionarioLogado);

        bool exibirMenu = true;

        while (exibirMenu)
        {
            Console.Clear();
            Console.WriteLine($"Operador {funcionarioLogado}\n");
            Console.WriteLine("Digite a sua opção:");
            Console.WriteLine("1 - Adicionar veículo");
            Console.WriteLine("2 - Remover veículo");
            Console.WriteLine("3 - Listar veículos");
            Console.WriteLine("4 - Histórico de operações");
            Console.WriteLine("5 - Trocar operador");
            Console.WriteLine("6 - Alterar Valor");
            Console.WriteLine("7 - Encerrar");
            Console.WriteLine("--------------------------------");

            switch (Console.ReadLine())
            {
                case "1":

                    {
                        Console.WriteLine("Informe qual veículo você quer adicionar:");
                        Console.WriteLine("1 - Carro");
                        Console.WriteLine("2 - Moto");
                        string marca, modelo, placa;
                        switch (Console.ReadLine())
                        {
                            case "1":
                                Console.Write("Digite a placa do carro: ");
                                placa = Console.ReadLine();
                                if (!Carro.ValidarPlaca(placa)) { }
                                if (es.Carros.Any(c => c.Placa == placa.ToUpper()) || es.Motos.Any(m => m.Placa == placa.ToUpper()))
                                {
                                    Console.WriteLine(MensagemErro.VeiculoJaAdicionado());
                                    Console.ReadKey();
                                }
                                else
                                {
                                    Console.Write("Digite a marca do carro: ");
                                    marca = Console.ReadLine();
                                    Console.Write("Digite o modelo do carro: ");
                                    modelo = Console.ReadLine();
                                    Carro carroASerAdicionado = new(marca, modelo, placa);
                                    es.AdicionarCarro(carroASerAdicionado);
                                }
                                Console.ReadKey();
                                break;

                            case "2":
                                Console.Write("Digite a placa da moto: ");
                                placa = Console.ReadLine();
                                if (!Moto.ValidarPlaca(placa)) { }
                                if (es.Motos.Any(m => m.Placa == placa.ToUpper()) || es.Carros.Any(c => c.Placa == placa.ToUpper()))
                                {
                                    Console.WriteLine(MensagemErro.VeiculoJaAdicionado());
                                    Console.ReadKey();
                                }
                                else
                                {
                                    Console.Write("Digite a marca da moto: ");
                                    marca = Console.ReadLine();
                                    Console.Write("Digite o modelo da moto: ");
                                    modelo = Console.ReadLine();
                                    Moto motoASerAdicionado = new(marca, modelo, placa);
                                    es.AdicionarMoto(motoASerAdicionado);
                                }
                                Console.ReadKey();
                                break;

                            default:
                                Console.WriteLine(MensagemErro.OpcaoInvalida());
                                Console.ReadKey();
                                break;
                        }
                    }
                    break;

                case "2":
                    {
                        Console.WriteLine("Informe qual veículo você quer remover:");
                        Console.WriteLine("1 - Carro");
                        Console.WriteLine("2 - Moto");
                        string marca, modelo, placa;
                        decimal valorTotal;
                        TimeSpan permanencia;
                        switch (Console.ReadLine())
                        {
                            case "1":
                                Console.Write("Digite a placa do carro: ");
                                placa = Console.ReadLine();
                                if (!Carro.ValidarPlaca(placa)) { }

                                Carro carroASerRemovido = es.Carros.FirstOrDefault(c => c.Placa == placa.ToUpper());
                                if (carroASerRemovido == null)
                                {
                                    Console.ReadKey();
                                    Console.WriteLine(MensagemErro.VeiculoInexistente());
                                }
                                else
                                {
                                    Console.Write("Digite a quantidade de horas que o carro permaneceu estacionado (hh:mm): ");
                                    while (!TimeSpan.TryParse(Console.ReadLine(), out permanencia) || permanencia.Days > 0)
                                    {
                                        Console.WriteLine(MensagemErro.HoraInvalida());
                                        Console.ReadKey();
                                    }
                                    es.RemoverCarro(carroASerRemovido);
                                    valorTotal = es.ContaAPagar(permanencia);
                                    Console.WriteLine($"O carro {carroASerRemovido} foi removido !\n\n" +
                                    $"Valor inicial {es.PrecoInicial:C}\n" +
                                    $"Valor por hora: {es.PrecoPorHora:C}\n" +
                                    $"Permanencia no estacionamento: {permanencia:hh\\:mm}h\n" +
                                    $"Valor total a pagar: {valorTotal:C}");
                                }
                                Console.ReadKey();
                                break;

                            case "2":
                                Console.Write("Digite a placa da moto: ");
                                placa = Console.ReadLine();
                                if (!Moto.ValidarPlaca(placa)) { }

                                Moto motoASerRemovida = es.Motos.FirstOrDefault(m => m.Placa == placa.ToUpper());
                                if (motoASerRemovida == null)
                                {
                                    Console.WriteLine(MensagemErro.VeiculoInexistente());
                                    Console.ReadKey();
                                }
                                else
                                {
                                    Console.Write("Digite a quantidade de horas que a moto permaneceu estacionada (hh:mm): ");
                                    while (!TimeSpan.TryParse(Console.ReadLine(), out permanencia) || permanencia.Days > 0)
                                    {
                                        Console.WriteLine(MensagemErro.HoraInvalida());
                                        Console.ReadKey();
                                    }
                                    es.RemoverMoto(motoASerRemovida);
                                    valorTotal = es.ContaAPagar(permanencia);
                                    Console.WriteLine($"A moto {motoASerRemovida} foi removida !\n\n" +
                                    $"Valor inicial {es.PrecoInicial:C}\n" +
                                    $"Valor por hora: {es.PrecoPorHora:C}\n" +
                                    $"Permanencia no estacionamento: {permanencia:hh\\:mm}h\n" +
                                    $"Valor total a pagar: {valorTotal:C}");
                                }
                                Console.ReadKey();
                                break;

                            default:
                                Console.WriteLine(MensagemErro.OpcaoInvalida());
                                Console.ReadKey();
                                break;
                        }
                    }
                    break;

                case "3":
                    if (es.Carros.Count > 0 || es.Motos.Count > 0)
                    {
                        Console.WriteLine("Os Veículos estácionados são:\n");
                        es.ListarCarros(es.Carros);
                        Console.WriteLine("-----------------------------------------------------------------------------------------------------");
                        es.ListarMotos(es.Motos);
                    }
                    else
                    {
                        Console.WriteLine("\nNenhum veículo estacionado no momento !");
                    }
                    Console.ReadKey();
                    break;

                case "4":
                    Console.WriteLine(es.HistoricoDeOperacoes());
                    Console.ReadKey();
                    break;

                case "5":
                    exibirMenu = false;
                    break;

                case "6":
                    Console.Write("Informe a senha de acesso:");
                    while (!int.TryParse(Console.ReadLine(), out senhaAcesso))
                    {
                        Console.WriteLine(MensagemErro.SenhaMestre());
                        Console.ReadKey();
                    }
                    if (senhaAcesso == es.SenhaAcesso)
                    {
                        Console.WriteLine("Qual valor deseja atualizar ?");
                        Console.WriteLine("1 - Preço Inicial");
                        Console.WriteLine("2 - Preço por Hora");
                        switch (Console.ReadLine())
                        {
                            case "1":
                                {
                                    decimal valorAntigo, valorAtual;
                                    Console.Write("informe o novo valor: ");
                                    valorAntigo = es.PrecoInicial;
                                    while (!decimal.TryParse(Console.ReadLine(), out valorAtual))
                                    {
                                        Console.Write(MensagemErro.ValorDecimal());
                                        Console.ReadKey();
                                    }
                                    if (es.SetPrecoInicial(valorAtual))
                                    {
                                        Console.WriteLine($"\nPreço alterado com sucesso:\nValor antigo: {valorAntigo} \nValor atual: {es.PrecoInicial}");
                                        Console.ReadKey();
                                    }

                                }
                                break;
                            case "2":
                                {
                                    decimal valorAntigo, valorAtual;
                                    Console.Write("informe o novo valor: ");
                                    valorAntigo = es.PrecoPorHora;
                                    while (!decimal.TryParse(Console.ReadLine(), out valorAtual))
                                    {
                                        Console.Write(MensagemErro.ValorDecimal());
                                        Console.ReadKey();
                                    }
                                    if (es.SetPrecoPorHora(valorAtual))
                                    {
                                        Console.WriteLine($"\nPreço alterado com sucesso:\nValor antigo: {valorAntigo} \nValor atual: {es.PrecoPorHora}");
                                        Console.ReadKey();
                                    }

                                }
                                break;
                            default:
                                Console.WriteLine(MensagemErro.OpcaoInvalida());
                                Console.ReadKey();
                                break;
                        }

                    }
                    else
                    {
                        Console.WriteLine(MensagemErro.SenhaMestreErrada());
                        Console.ReadKey();
                    }
                    break;

                case "7":
                    exibirMenu = false;
                    programa = false;
                    break;

                default:
                    Console.WriteLine(MensagemErro.OpcaoInvalida());
                    Console.ReadKey();
                    break;
            }
        }
    }
    else
    {
        Console.WriteLine(MensagemErro.CredencialInvalida());
        Console.ReadKey();
    }
}
Console.WriteLine("O programa se encerrou");
