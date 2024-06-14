using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeDiagramaClasse
{
    public class Caixa
    {
        public int Id { get; private set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        private double Salario { get; set; }
        public double BonusAnual { get; set; }
        public Caixa(int id, string nome, int idade, double salario)
        {
            Id = id;
            Nome = nome;
            Idade = idade;
            Salario = salario;
            BonusAnual = Salario * 0.3;
        }
        public void AlterarID(int id)
        {
            Id = id;
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
            Console.WriteLine($"Id Funcionário: {Id}");
            Console.WriteLine($"Funcionario: {Nome}");
            AplicarBonificacaoAnual();
            AplicarProgressaoAnual();
        }
        public void ExibirDetalhesFuncionario()
        {
            Console.WriteLine($"------ Funcionário {Id}-----------" +
                                $"\n Nome: {Nome}" +
                                $"\n Idade: {Idade}" +
                                $"\n Salário: {Salario}" +
                              $"\n ----------------------------------");
        }
        public void AumentarSalario()
        {
            Salario = Salario + Salario * 0.1;
        }
    }
}
