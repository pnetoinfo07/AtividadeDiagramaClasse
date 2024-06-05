using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeDiagramaClasse
{
    public class Gerente
    {
        private int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        private double Salario { get; set; }
        public Gerente(int id, string nome, int idade, double salario)
        {
            Id = id;
            Nome = nome;
            Idade = idade;
            Salario = salario;
        }

        private void AplicarBonificacao()
        {
            Console.WriteLine($"Sua bonficacao será {Salario}");
        }
        private void AplicarProgressaoAnual()
        {

        }
        public void RealizarBalancoAnualFuncionario()
        {

        }
    }
}
