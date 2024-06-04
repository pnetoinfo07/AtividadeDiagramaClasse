using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeDiagramaClasse
{
    public class QuadroColaboradores
    {
        private List<Marketing> FuncionariosMarketing { get; set; }
        private List<Caixa> FuncionariosCaixa { get; set; }
        private List<Desenvolvedor> FuncionariosDesenvolvedor { get; set; }
        private List<Gerente> FuncionariosGerente { get; set; }
        private GerenciadorEmpresarial gerenciador { get; set; }

        public QuadroColaboradores()
        {
            FuncionariosMarketing = new List<Marketing>();
            FuncionariosCaixa = new List<Caixa>();
            FuncionariosDesenvolvedor = new List<Desenvolvedor>();
            FuncionariosGerente= new List<Gerente>();
            gerenciador = new GerenciadorEmpresarial();
        }
        public void AdicionarMarketing(Marketing marketing)
        {
            throw new NotImplementedException();
        }
        public void AdicionarMarketing(Caixa caixa)
        {
            throw new NotImplementedException();
        }
        public void AdicionarMarketing(Desenvolvedor desenvolvedor)
        {
            throw new NotImplementedException();
        }
        public void AdicionarMarketing(Gerente gerente)
        {
            throw new NotImplementedException();
        }

        public void AplicarBonificacao(int tipoFuncionario, int idFuncionario)
        {
            throw new NotImplementedException();
        }

    }
}
