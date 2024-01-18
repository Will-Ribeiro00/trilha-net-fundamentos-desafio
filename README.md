# DIO - Trilha .NET - Fundamentos
www.dio.me

# **Alterações e Intervenções Executadas no Projeto:**
 Além dos ajustes necessários para concluir o desafio com sucesso, realizei mais algumas mudanças no codigo base para se tornar mais fluido e corrigir alguns erros pertinentes que foram encontrados no caminho e poderiam vir a ser um problema futuro.

- **Método AdicionarVeiculo() :**
  - Implementei uma verificação para validar se a placa inserida está no formato atual MercoSul, ou no antigo formato BR;
  - Implementei uma verificação para garantir que as placas não se repitam (restrição de exclusividade);
  - Implementei a função ToUpper(); para, mesmo que seja adicionado letras em minúsculo, o sistema alterar os caracteres para maiúsculo;
- **Método RemoverVeiculo() :**
  - Implementei uma verificação para garantir que a placa inserida esteja no formato MercoSul, ou no antigo formato BR;
  - Ajustei o Layout para otimizar as informaçõe como se fosse uma pré-conta, contendo o valor inicial, valor por hora, o tempo de permanência do veiculo e o total a pagar;
  - Utilizei da Class TimeSpan, juntamente com a função ToHours para formatar o tempo de permanência em "HH:MM" e no calculo do valor total, ser considerado um horário válido HH:MM;
- **Método ListarVeiculos() :**
  - Implementei o contador utilizando o laço For() para poder interpolar a string e colocar um contador para identificar quais foram os primeios veiculos a serem estacionados e quais foram os ultimos;
  - Utilizei o método ToUpper para mostrar todos os caracteres das placas em letra maiúscula;
- **Método ValidarPlaca() :**
   - Implementei esse metodo para verificar se a placa inserida pelo usuário é valida e está no formato atual MercoSul ou no antigo BR;
- **Class Funcionario e Método DefinirOperador()**
  - Foi criada uma Class Funcionario com os atributos privados nome, id e senha
  - A partir da class Funcionario, foi instanciada uma lista Funcionarios, contendo funcionarios hipotéticos
  - O sistema exige que o funcionario informe o id e a senha do operador do programa,e a partir do metodo DefinirOperador ele reconheçe quem está operando no moment. Caso queira, o usuário poderá trocar o operador, sendo novamente solicitado o id e a senha do novo operador;
- **Método AlterarValor()**
  - Esse método altera o valor dos atributos privados valorInicial e valorPorHora, sendo obviamente solicitado uma senha de acesso privada;
- **Método HistoricoDeOperacoes()**
  - Foi criada uma list de operações, sendo adicionar e remover veiculos, e cada vez que tais operações forem executadas, ficará registrado no histórico;
  - O Método lista todas as operações realizar realizadas, contendo as seguintes informações: ID, Funcionario, Tipo de Operação, Veículo e Valor Total (Caso a operação seja de remoção) ;
   

## Desafio de projeto
Para este desafio, você precisará usar seus conhecimentos adquiridos no módulo de fundamentos, da trilha .NET da DIO.

## Contexto
Você foi contratado para construir um sistema para um estacionamento, que será usado para gerenciar os veículos estacionados e realizar suas operações, como por exemplo adicionar um veículo, remover um veículo (e exibir o valor cobrado durante o período) e listar os veículos.

## Proposta
Você precisará construir uma classe chamada "Estacionamento", conforme o diagrama abaixo:
![Diagrama de classe estacionamento](diagrama_classe_estacionamento.png)

A classe contém três variáveis, sendo:

**precoInicial**: Tipo decimal. É o preço cobrado para deixar seu veículo estacionado.

**precoPorHora**: Tipo decimal. É o preço por hora que o veículo permanecer estacionado.

**veiculos**: É uma lista de string, representando uma coleção de veículos estacionados. Contém apenas a placa do veículo.

A classe contém três métodos, sendo:

**AdicionarVeiculo**: Método responsável por receber uma placa digitada pelo usuário e guardar na variável **veiculos**.

**RemoverVeiculo**: Método responsável por verificar se um determinado veículo está estacionado, e caso positivo, irá pedir a quantidade de horas que ele permaneceu no estacionamento. Após isso, realiza o seguinte cálculo: **precoInicial** * **precoPorHora**, exibindo para o usuário.

**ListarVeiculos**: Lista todos os veículos presentes atualmente no estacionamento. Caso não haja nenhum, exibir a mensagem "Não há veículos estacionados".

Por último, deverá ser feito um menu interativo com as seguintes ações implementadas:
1. Cadastrar veículo
2. Remover veículo
3. Listar veículos
4. Encerrar


## Solução
O código está pela metade, e você deverá dar continuidade obedecendo as regras descritas acima, para que no final, tenhamos um programa funcional. Procure pela palavra comentada "TODO" no código, em seguida, implemente conforme as regras acima.
