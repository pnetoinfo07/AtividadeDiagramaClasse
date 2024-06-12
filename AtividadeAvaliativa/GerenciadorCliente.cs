using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeAvaliativa
{
    public class GerenciadorCliente
    {
        public List<Cliente> Clientes { get; set; }

        public GerenciadorCliente()
        {
            Clientes = new List<Cliente>();
        }
        public void AdicionarCliente(Cliente c)
        {
            Clientes.Add(c);
        }
        public void RemoverCliente(Cliente c)
        {
            Clientes.Remove(c);
        }

        public void ListarClientes()
        {
            foreach (Cliente c in Clientes)
            {
                c.ExibirDetalhes();
            }
        }
    }
}
