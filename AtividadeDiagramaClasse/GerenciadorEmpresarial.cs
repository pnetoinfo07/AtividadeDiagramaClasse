using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeDiagramaClasse
{
    public class GerenciadorEmpresarial
    {
        public void CalcularBonificacao(Gerente gerente)
        {
            gerente.RealizarBalancoAnualFuncionario();
        }
        public void CalcularBonificacao(Caixa caixa)
        {
            caixa.RealizarBalancoAnualFuncionario();
        }
        public void CalcularBonificacao(Marketing marketing)
        {
            marketing.RealizarBalancoAnualFuncionario();
        }
        public void CalcularBonificacao(Desenvolvedor desenvolvedor)
        {
            desenvolvedor.RealizarBalancoAnualFuncionario();
        }
    }
}
