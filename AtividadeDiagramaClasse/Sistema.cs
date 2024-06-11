using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeDiagramaClasse
{
    public class Sistema
    {
        public GerenciadorEmpresarial Gerenciador { get; set; }

        public Sistema()
        {
            Gerenciador = new GerenciadorEmpresarial();
        }

        public void IniciarSistema()
        {
            ExibirMenu();
            int acaoSelecionada = SolicitarAcaoUsuario();
            RealizarAcaoSelecionado(acaoSelecionada);
        }
        private void RealizarAcaoSelecionado(int acaoSelecionada)
        {
            //if (acaoSelecionada == 1)
            //{

            //}
            //else if (acaoSelecionada == 2)
            //{

            //}
            //else if (acaoSelecionada == 3)
            //{

            //}
            //else if (acaoSelecionada == 4)
            //{

            //}
            //else if (acaoSelecionada == 5)
            //{

            //}

            switch (acaoSelecionada)
            {
                case 1:
                    Gerenciador.ListarFuncionarios();
                    break;
                case 2:
                    CalcularBonificacao();
                    break;
                case 3:
                    //Adicionar
                    break;
                case 4:
                    //Remover
                    break;
                case 5:
                    //Editar
                    break;
            }
        }
        private void CalcularBonificacao()
        {
            Console.WriteLine("Deseja Realizar o calculo de:");
            Console.WriteLine("1 - Todos os funcionários");
            Console.WriteLine("2 - Funcionário por Id");
            int opcaoSelecionada = int.Parse(Console.ReadLine());

            if(opcaoSelecionada == 1)
            {
                Gerenciador.ListarBonificacaoAnualTodaEmpresa();
            }
            else if(opcaoSelecionada == 2)
            {
                CalcularBonificacaoPorIdFuncionario();
            }
            else
            {
                Console.WriteLine("Erro opção inválida");
            }
        }
        private void CalcularBonificacaoPorIdFuncionario()
        {
            Console.WriteLine("------------------ PROFISSÕES ------------------");
            Console.WriteLine("1 - Gerente");
            Console.WriteLine("2 - Caixa");
            Console.WriteLine("3 - Marketing");
            Console.WriteLine("4 - Desenvolvedor");
            Console.WriteLine("Digite qual profissão deseja alterar?");
            int profissaoSelecionada = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Id do Funcionário que deseja calcular: ");
            int idFuncionario = int.Parse(Console.ReadLine());

            Gerenciador.CalcularBonificacaoPorIdFuncionario(profissaoSelecionada, idFuncionario);
        }

        private int SolicitarAcaoUsuario()
        {
            int acao = -1;
            while (acao <= 0 || acao > 5)
            {
                Console.WriteLine("Digite qual a ação que deseja realizar?");
                acao = int.Parse(Console.ReadLine());

                if (acao > 5 || acao <= 0)
                {
                    Console.WriteLine("Número inválido!!\nFavor digite um número válido!!");
                }
            }
            return acao;
        }

        public void ExibirMenu()
        {
            Console.WriteLine($"----------  Menu Ações ----------" +
                              $"\n 1 - Listar Funcionários" +
                              $"\n 2 - Calcular Bonificação Anual" +
                              $"\n 3 - Adicionar" +
                              $"\n 4 - Remover" +
                              $"\n 5 - Editar" +
                              $"\n --------------------------------");
        }
    }
}
