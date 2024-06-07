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
            SolicitarAcaoUsuario();
        }

        private int SolicitarAcaoUsuario()
        {           

            Console.WriteLine("Digite qual a ação que deseja realizar?");
            int acao = int.Parse(Console.ReadLine());

            if(acao > 5 || acao < 0)
            {
                Console.WriteLine("Número inválido!!\nFavor digite um número válido!!");
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
