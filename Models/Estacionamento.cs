using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjEstacionamento.Models
{
    public class Estacionamento
    {
        public Estacionamento()
        {
            Pessoas = new List<Cliente>();
            Veiculos = new List<Carro>();
        }


        public string NomeEstacionamento { get; set; }
        public List<Cliente> Pessoas { get; set; }
        public List<Carro> Veiculos { get; set; }

        public void AdicionarVeiculoPessoa(Carro veiculo, Cliente pessoa)
        {
            Veiculos.Add(veiculo);
            Pessoas.Add(pessoa);
        }

        public void RemoverVeiculoPessoa(Carro veiculo, Cliente pessoa)
        {
            Veiculos.Remove(veiculo);
            Pessoas.Remove(pessoa);
        }

        public void ListarVeiculosPessoas()
        {
            int tamanhoLista = Math.Min(Veiculos.Count, Pessoas.Count);

            for (int i = 0; i < tamanhoLista; i++)
            {
                Console.WriteLine($"O cliente do nome {Pessoas[i].Nome} e do cpf {Pessoas[i].Cpf} tem o veiculo:");
                Console.WriteLine($"Marca:{Veiculos[i].Marca}; Modelo:{Veiculos[i].Modelo}; Placa:{Veiculos[i].Placa};");
            }
            // foreach (Carro veiculo in Veiculos)
            // {
            //     Console.WriteLine($"Marca:{veiculo.Marca}; Modelo:{veiculo.Modelo}; Placa:{veiculo.Placa};");
            // }


        }

    }
}