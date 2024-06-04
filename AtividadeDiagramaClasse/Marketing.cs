using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeDiagramaClasse
{
    public class Marketing
    {
        private int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        private double Salario { get; set; }
        public Marketing(int id, string nome, int idade, double salario)
        {
            Id = id;
            Nome = nome;
            Idade = idade;
            Salario = salario;
        }

        private void AplicarBonificacao()
        {
            double bonus = Salario * 0.6;
            Console.WriteLine($"Sua bonficacao será {bonus}");
        }
    }
}
