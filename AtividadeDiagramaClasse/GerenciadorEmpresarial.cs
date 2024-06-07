using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeDiagramaClasse
{
    public class GerenciadorEmpresarial
    {
        public QuadroColaboradores Colaboradores { get; set; }
        public GerenciadorEmpresarial()
        {
            Colaboradores = new QuadroColaboradores();
        }
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
        public void ListarFuncionarios()
        {
            Colaboradores.ListarMarketing();
            Colaboradores.ListarDesenvolvedor();
            Colaboradores.ListarGerente();
            Colaboradores.ListarCaixa();
        }
        public void ListarBonificacaoAnualTodaEmpresa()
        {
            foreach(Caixa caixa in Colaboradores.FuncionariosCaixa)
            {
                CalcularBonificacao(caixa);
            }
        }
    }
}
