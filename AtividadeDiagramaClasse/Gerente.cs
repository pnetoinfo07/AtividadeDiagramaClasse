using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeDiagramaClasse
{
    public class Gerente : Funcionario
    {
        public Gerente(int id, string nome, int idade, double salario)
        : base(id, nome, idade, salario)
        {
            BonusAnual = Salario;
        }
    }
}
