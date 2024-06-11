using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeDiagramaClasse
{
    public class QuadroColaboradores
    {
        public List<Marketing> FuncionariosMarketing { get; private set; }
        public List<Caixa> FuncionariosCaixa { get; private set; }
        public List<Desenvolvedor> FuncionariosDesenvolvedor { get; private set; }
        public List<Gerente> FuncionariosGerente { get; private set; }
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
        public void ListarGerente()
        {
            Console.WriteLine("-------------------- Lista Gerente --------------------");
            foreach (Gerente gerente in FuncionariosGerente)
            {
                gerente.ExibirDetalhesFuncionario();
            }
        }
        public void ListarDesenvolvedor()
        {
            Console.WriteLine("-------------------- Lista Desenvolvedor --------------------");
            foreach (Desenvolvedor dev in FuncionariosDesenvolvedor)
            {
                dev.ExibirDetalhesFuncionario();
            }
        }
        public void ListarMarketing()
        {
            Console.WriteLine("-------------------- Lista Marketing --------------------");
            foreach (Marketing marketing in FuncionariosMarketing)
            {
                marketing.ExibirDetalhesFuncionario();
            }
        }
        public void ListarCaixa()
        {
            Console.WriteLine("-------------------- Lista Caixa --------------------");
            foreach (Caixa caixa in FuncionariosCaixa)
            {
                caixa.ExibirDetalhesFuncionario();
            }
        }
        public Gerente BuscarGerentePorId(int id)
        {
            foreach (Gerente ger in FuncionariosGerente)
            {
                if(ger.Id == id)
                {
                    return ger;
                }
            }
            return null;
        }
    }
}
