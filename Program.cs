using ProjEstacionamento.Models;

Cliente c1 = new Cliente();

Console.WriteLine("Digite o nome do condutor do veiculo:");
c1.Nome = Console.ReadLine();
Console.WriteLine("Digite o cpf do condutor do veiculo:");
c1.Cpf = Console.ReadLine();

Carro car1 = new Carro();

Console.WriteLine("Digite o marca do veiculo");
car1.Marca = Console.ReadLine();
Console.WriteLine("Digite o modelo do veiculo");
car1.Modelo = Console.ReadLine();
Console.WriteLine("Digite a placa do veiculo");
car1.Placa = Console.ReadLine();

Cliente c2 = new Cliente();

Console.WriteLine("Digite o nome do condutor do veiculo:");
c2.Nome = Console.ReadLine();
Console.WriteLine("Digite o cpf do condutor do veiculo:");
c2.Cpf = Console.ReadLine();

Carro car2 = new Carro();

Console.WriteLine("Digite o marca do veiculo");
car2.Marca = Console.ReadLine();
Console.WriteLine("Digite o modelo do veiculo");
car2.Modelo = Console.ReadLine();
Console.WriteLine("Digite a placa do veiculo");
car2.Placa = Console.ReadLine();

Cliente c3 = new Cliente();

Console.WriteLine("Digite o nome do condutor do veiculo:");
c3.Nome = Console.ReadLine();
Console.WriteLine("Digite o cpf do condutor do veiculo:");
c3.Cpf = Console.ReadLine();

Carro car3 = new Carro();

Console.WriteLine("Digite o marca do veiculo");
car3.Marca = Console.ReadLine();
Console.WriteLine("Digite o modelo do veiculo");
car3.Modelo = Console.ReadLine();
Console.WriteLine("Digite a placa do veiculo");
car3.Placa = Console.ReadLine();

Estacionamento a1 = new Estacionamento();

a1.NomeEstacionamento = "Estacionamento: A1";

a1.AdicionarVeiculoPessoa(car1, c1);
a1.AdicionarVeiculoPessoa(car2, c2);
a1.AdicionarVeiculoPessoa(car3, c3);

a1.ListarVeiculosPessoas();