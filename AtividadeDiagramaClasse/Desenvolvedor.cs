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
        public double BonusAnual { get; set; }
        public Desenvolvedor(int id, string nome, int idade, double salario)
        {
            Id = id;
            Nome = nome;
            Idade = idade;
            Salario = salario;
            BonusAnual = Salario * 0.5;
        }
        private void AplicarBonificacaoAnual()
        {
            Console.WriteLine($"Sua bonficacao será {BonusAnual}");
        }
        private void AplicarProgressaoAnual()
        {
            Salario = Salario + (Salario * 0.20);
            Console.WriteLine($"Seu novo sálario é {Salario}");
        }
        public void RealizarBalancoAnualFuncionario()
        {
            Console.WriteLine("---------- Balanço Anual ----------");
            AplicarBonificacaoAnual();
            AplicarProgressaoAnual();
        }
        public void ExibirDetalhesFuncionario()
        {
            Console.WriteLine($"------ Funcionário {Id}-----------" +
                                $"Nome: {Nome}" +
                                $"Idade: {Idade}" +
                                $"Salário: {Salario}" +
                              $"----------------------------------");
        }
    }
}
