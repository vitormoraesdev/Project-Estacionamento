using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjEstacionamento.Models
{
    public class Carro
    {
        public Carro()
        {

        }

        public Carro(string marca, string modelo, string placa)
        {
            Marca = marca;
            Modelo = modelo;
            Placa = placa;
        }

        private string marca;
        private string modelo;
        private string placa;

        public string Marca { get => marca; set { marca = value; } }
        public string Modelo { get => modelo; set { modelo = value; } }
        public string Placa { get => placa; set { placa = value; } }

        public void Demonstrar()
        {
            Console.WriteLine($"Da marca {Marca} e modelo {Modelo} com o final da placa {Placa}");
        }

    }
}
