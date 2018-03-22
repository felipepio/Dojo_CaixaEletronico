using System.Collections.Generic;
using System.Linq;
using Utilitarios;


namespace CaixaEletronico.Class
{

    public class GerenciadorDeClientes
    {
        public GerenciadorDeClientes()
        {
            this.Clientes = new List<Cliente>();
        }

        public IList<Cliente> Clientes { get; protected set; }

        public void AdicionarCliente(Cliente cliente)
        {
            this.Clientes.Add(cliente);
        }

        public void GravarCliente(Cliente cliente)
        {
            GravadorArquivo arquivo = new GravadorArquivo();
            string registro = cliente.ExibirCPF() + ";" + cliente.ExibirNome() + ";" + cliente.ExibirRG() + ";" + cliente.ExibirDataNascimento();
            arquivo.EscreverArquivo(arquivo.dirGravacao, "clientes.txt", registro);
        }

        public bool ExisteCliente(string cpf)
        {
            return this.Clientes.Any(c => c.CPF == cpf);
        }

        public Cliente ConsultarClientePorCPF(string cpf)
        {
            var cliente = this.Clientes.FirstOrDefault(c => c.CPF == cpf);
            return cliente;
        }

        public void AtualizarBases()
        {
            GravadorArquivo arquivo = new GravadorArquivo();
            arquivo.SobreescreverArquivo(arquivo.dirGravacao, "clientes.txt");

            foreach (var cliente in this.Clientes)
            {
                GravarCliente(cliente);
            }
        }
    }
}
