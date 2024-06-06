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
        public QuadroColaboradores()
        {
            FuncionariosMarketing = new List<Marketing>();
            FuncionariosCaixa = new List<Caixa>();
            FuncionariosDesenvolvedor = new List<Desenvolvedor>();
            FuncionariosGerente= new List<Gerente>();
            InicializarDados();
        }

        private void InicializarDados()
        {
            FuncionariosMarketing.Add(new Marketing(1, "Paulo", 24, 1500));
            FuncionariosMarketing.Add(new Marketing(2, "Antonio", 24, 2000));
            FuncionariosMarketing.Add(new Marketing(3, "Ana", 24, 1300));

            FuncionariosCaixa.Add(new Caixa(1, "José", 24, 1500));
            FuncionariosCaixa.Add(new Caixa(2, "Marcela", 24, 2000));
            FuncionariosCaixa.Add(new Caixa(3, "Ana", 24, 1300));

            FuncionariosDesenvolvedor.Add(new Desenvolvedor(1, "Joana", 24, 1500));
            FuncionariosDesenvolvedor.Add(new Desenvolvedor(2, "Fernanda", 24, 2000));
            FuncionariosDesenvolvedor.Add(new Desenvolvedor(3, "João", 24, 1300));

            FuncionariosGerente.Add(new Gerente(1, "Carlos", 24, 1500));
            FuncionariosGerente.Add(new Gerente(2, "Manoel", 24, 2000));
            FuncionariosGerente.Add(new Gerente(3, "Carlos", 24, 1300));
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
    }
}
