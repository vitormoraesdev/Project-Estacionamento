using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjEstacionamento.Models
{
    public class Cliente
    {
        public Cliente()
        {

        }
        public Cliente(string nome, string cpf)
        {
            nome = Nome;
            cpf = Cpf;
        }
        private string nome;
        private string cpf;

        public string Nome { get => nome; set{nome = value;} }
        public string Cpf { get => cpf; set{cpf = value;} }

        public void Apresentar()
        {
            Console.WriteLine($"O cliente do nome {Nome} e do cpf {Cpf} tem o veiculo:");
        }
    }
}