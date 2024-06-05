using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeDiagramaClasse
{
    public class Caixa
    {
        private int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        private double Salario { get; set; }
        public Caixa(int id, string nome, int idade, double salario)
        {
            Id = id;
            Nome = nome;
            Idade = idade;
            Salario = salario;
        }
        private void AplicarBonificacao()
        {
            double bonus = Salario * 0.3;
            Console.WriteLine($"Sua bonficacao será {bonus}");
        }
        private void AplicarProgressaoAnual()
        {

        }
        public void RealizarBalancoAnualFuncionario()
        {

        }
    }
}
