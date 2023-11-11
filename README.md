# Project-Estacionamento
Projeto Beack-End, usando .Net 6.0 com a linguagem C#. 
Esse projeto é CRUD basico, usando métodos Construtores, Propiedades, Classes e Objetos e métodos.

Projeto Console de Estacionamento
Este é um simples projeto de aplicação console em C# que simula um sistema de estacionamento. Ele inclui as classes Cliente, Carro e Estacionamento, com métodos para adicionar, remover e listar veículos associados a clientes.

Funcionalidades Principais
1. Classe Cliente
Propriedades
Cpf (string): Identificador único do cliente.
Nome (string): Nome do cliente.
Veiculos (List<Carro>): Lista de veículos associados ao cliente.
Métodos
AdicionarVeiculoPessoa(Carro veiculo): Adiciona um veículo à lista de veículos do cliente.
RemoverVeiculoPessoa(Carro veiculo): Remove um veículo da lista de veículos do cliente.
ListarVeiculoPessoa(): Lista todos os veículos associados ao cliente.
3. Classe Carro
Propriedades
Placa (string): Número de placa do carro.
Modelo (string): Modelo do carro.
Marca (string): Marca do carro.
4. Classe Estacionamento
Propriedades
Clientes (List<Cliente>): Lista de clientes que estacionaram veículos.
Como Usar
Clonar o Repositório:

bash
Copy code
git clone https://github.com/vitormoraesdev/Project-Estacionamento.git
Compilar o Projeto:

bash
Copy code
dotnet build
Executar a Aplicação:

bash
Copy code
dotnet run
Utilizar os Métodos:

Após a execução, siga as instruções no console para interagir com os métodos (adicionar, remover, listar).

Contribuições
Contribuições são bem-vindas! Se você encontrar problemas ou tiver sugestões de melhorias, sinta-se à vontade para abrir uma issue ou enviar um pull request.
