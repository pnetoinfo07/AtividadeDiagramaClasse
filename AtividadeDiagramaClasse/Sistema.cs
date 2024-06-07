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
                    //Calcular Bonificacao
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
