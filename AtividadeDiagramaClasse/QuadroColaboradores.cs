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
            int novoID = FuncionariosMarketing
                        .Max(marketing => marketing.Id) + 1;
            marketing.AlterarID(novoID);
            FuncionariosMarketing.Add(marketing);
        }
        public void AdicionarCaixa(Caixa caixa)
        {
            int novoID = FuncionariosCaixa
                        .Max(caixa => caixa.Id) + 1;
            caixa.AlterarID(novoID);
            FuncionariosCaixa.Add(caixa);
        }
        public void AdicionarDesenvolvedor(Desenvolvedor desenvolvedor)
        {
            int novoID = FuncionariosDesenvolvedor
                        .Max(desenvolvedor => desenvolvedor.Id) + 1;
            desenvolvedor.AlterarID(novoID);
            FuncionariosDesenvolvedor.Add(desenvolvedor);
        }
        public void AdicionarGerente(Gerente gerente)
        {
            int novoID = FuncionariosGerente
                        .Max(gerente => gerente.Id) + 1;
            gerente.AlterarID(novoID);
            FuncionariosGerente.Add(gerente);
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
        public Caixa BuscarCaixaPorId(int id)
        {
            foreach (Caixa caixa in FuncionariosCaixa)
            {
                if(caixa.Id == id)
                {
                    return caixa;
                }
            }
            return null;
        }
        public Desenvolvedor BuscarDesenvolvedorPorId(int id)
        {
            foreach (Desenvolvedor dev in FuncionariosDesenvolvedor)
            {
                if(dev.Id == id)
                {
                    return dev;
                }
            }
            return null;
        }
        public Marketing BuscarMarketingPorId(int id)
        {
            foreach (Marketing marketing in FuncionariosMarketing)
            {
                if(marketing.Id == id)
                {
                    return marketing;
                }
            }
            return null;
        }
    }
}
