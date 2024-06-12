using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeAvaliativa
{
    public class Cliente
    {
        private int Id { get; set; }
        public string Nome { get; set;}
        public int  Idade { get; set; }

        public Cliente(int id, string nome, int idade)
        {
            Id = id;
            Nome = nome;
            Idade = idade;
        }
        public void ExibirDetalhes()
        {
            Console.WriteLine("----------- Cliente ---------");
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Idade: {Idade}");
            Console.WriteLine("-----------------------------");
        }
    }
}
