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
            Console.WriteLine("------------ Bonificação Caixa --------------");
            foreach (Caixa caixa in Colaboradores.FuncionariosCaixa)
            {                
                CalcularBonificacao(caixa);
            }
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("------------ Bonificação Maketing --------------");
            foreach (Marketing marketing in Colaboradores.FuncionariosMarketing)
            {               
                CalcularBonificacao(marketing);
            }
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("------------ Bonificação Desenvolvedor --------------");
            foreach (Desenvolvedor dev in Colaboradores.FuncionariosDesenvolvedor)
            {                
                CalcularBonificacao(dev);
            }
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("------------ Bonificação Gerente --------------");
            foreach (Gerente gerente in Colaboradores.FuncionariosGerente)
            {                
                CalcularBonificacao(gerente);
            }
            Console.WriteLine("---------------------------------------------");
        }

        public void CalcularBonificacaoPorIdFuncionario(int profissao, int idFuncionario)
        {
            if(profissao == 1)
            {
               Gerente gerente = Colaboradores.BuscarGerentePorId(idFuncionario);
                if(gerente == null)
                {
                    Console.WriteLine("Id gerente inválido");
                }
                else
                {
                    gerente.RealizarBalancoAnualFuncionario();
                }
            }
            else if(profissao == 2)
            {
                Caixa caixa = Colaboradores.BuscarCaixaPorId(idFuncionario);
                if(caixa == null)
                {
                    Console.WriteLine("Id gerente inválido");
                }
                else
                {
                    caixa.RealizarBalancoAnualFuncionario();
                }
            }
            else if(profissao == 3)
            {
               Marketing marketing = Colaboradores.BuscarMarketingPorId(idFuncionario);
                if(marketing == null)
                {
                    Console.WriteLine("Id gerente inválido");
                }
                else
                {
                    marketing.RealizarBalancoAnualFuncionario();
                }
            }
            else if(profissao == 4)
            {
               Desenvolvedor dev = Colaboradores.BuscarDesenvolvedorPorId(idFuncionario);
                if(dev == null)
                {
                    Console.WriteLine("Id gerente inválido");
                }
                else
                {
                    dev.RealizarBalancoAnualFuncionario();
                }
            }
        }
        public void AdicionarFuncionarios(int profissaoSelecionada)
        {
            if(profissaoSelecionada == 1)
            {
                Gerente ger = CriadorFuncionarios.CriarGerente();
                Colaboradores.AdicionarGerente(ger);
            }
            else if(profissaoSelecionada == 2)
            {
                Caixa caixa = CriadorFuncionarios.CriarCaixa();
                Colaboradores.AdicionarCaixa(caixa);
            }
            else if(profissaoSelecionada == 3)
            {
                Marketing marketing = CriadorFuncionarios.CriarMarketing();
                Colaboradores.AdicionarMarketing(marketing);
            }
            else if(profissaoSelecionada == 4)
            {
                Desenvolvedor dev = CriadorFuncionarios.CriarDesenvolvedor();
                Colaboradores.AdicionarDesenvolvedor(dev);
            }
        }
    }
}
