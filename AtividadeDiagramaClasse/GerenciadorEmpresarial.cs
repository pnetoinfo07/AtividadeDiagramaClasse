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
            gerente.RealizarFechamentoAnualFuncionario();
        }
        public void CalcularBonificacao(Caixa caixa)
        {
            caixa.RealizarFechamentoAnualFuncionario();
        }
        public void CalcularBonificacao(Marketing marketing)
        {
            marketing.RealizarFechamentoAnualFuncionario();
        }
        public void CalcularBonificacao(Desenvolvedor desenvolvedor)
        {
            desenvolvedor.RealizarFechamentoAnualFuncionario();
        }
    }
}
