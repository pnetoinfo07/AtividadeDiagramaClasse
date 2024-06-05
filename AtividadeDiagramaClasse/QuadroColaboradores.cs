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
        public GerenciadorEmpresarial gerenciador { get; set; }
        public QuadroColaboradores()
        {
            FuncionariosMarketing = new List<Marketing>();
            FuncionariosCaixa = new List<Caixa>();
            FuncionariosDesenvolvedor = new List<Desenvolvedor>();
            FuncionariosGerente= new List<Gerente>();
            InicializarSistema();
            gerenciador = new GerenciadorEmpresarial();
        }

        private void InicializarSistema()
        {
            FuncionariosMarketing.Add(new Marketing(1, "Paulo", 24, 1500));
            FuncionariosMarketing.Add(new Marketing(2, "Marcela", 24, 2000));
            FuncionariosMarketing.Add(new Marketing(3, "Ana", 24, 1300));
        }

        public void AdicionarMarketing(Marketing marketing)
        {
            throw new NotImplementedException();
        }
        public void AdicionarCaixa(Caixa caixa)
        {
            throw new NotImplementedException();
        }
        public void AdicionarDesenvolvedor(Desenvolvedor desenvolvedor)
        {
            throw new NotImplementedException();
        }
        public void AdicionarGerente(Gerente gerente)
        {
            throw new NotImplementedException();
        }
        public void AplicarBonificacao(int tipoFuncionario, int idFuncionario)
        {
            throw new NotImplementedException();
        }

    }
}
