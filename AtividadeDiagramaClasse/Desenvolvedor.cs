using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeDiagramaClasse
{
    public class Desenvolvedor
    {
        private int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        private double Salario { get; set; }
        public Desenvolvedor(int id, string nome, int idade, double salario)
        {
            Id = id;
            Nome = nome;
            Idade = idade;
            Salario = salario;
        }
        public void RealizarFechamentoAnualFuncionario()
        {
            Console.WriteLine($"------ FECHAMENTO ANUAL {DateTime.Now.Year} -----------------------");
            Console.WriteLine($"Cód Funcionario: {Id}");
            Console.WriteLine($"Funcionario: {Nome}");
            AplicarBonificacaoAnual();
            AplicarProgressaoAnual();
            Console.WriteLine($"----------------------------------------------------");
        }

        private void AplicarProgressaoAnual()
        {
            Salario = Salario + (Salario * 0.15);
            Console.WriteLine($"Seu sálario para o próximo ano será {Salario}");
        }
        private void AplicarBonificacaoAnual()
        {
            double bonus = Salario * 0.5;
            Console.WriteLine($"Sua bonficacao será {bonus}");
        }
    }
}
