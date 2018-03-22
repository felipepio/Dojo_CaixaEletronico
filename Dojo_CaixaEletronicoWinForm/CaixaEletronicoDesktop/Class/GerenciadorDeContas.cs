using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilitarios;


namespace CaixaEletronico.Class
{
    using Base;
    using Exceptions;

    public class GerenciadorDeContas
    {
        public GerenciadorDeContas()
        {
            this.Contas = new List<Conta>();
        }

        public IList<Conta> Contas { get; protected set; }

        public void AdicionarConta(Conta cc)
        {
            if (!this.Contas.Contains(cc))
            {
                this.Contas.Add(cc);
            }
            else
            {
                throw new ContaExistenteException();
            }
        }

        public void GravarConta(Conta cc)
        {
            GravadorArquivo arquivo = new GravadorArquivo();
            string registro = cc.ExibirNumero() + ";" + cc.ExibirCliente().ExibirCPF() + ";" + cc.RetornarSaldo(false) + ";" + cc.ExibirTipo();
            arquivo.EscreverArquivo(arquivo.dirGravacao, "contas.txt", registro);
        }

        public bool ContaValidaParaCriacao(int numero)
        {
            return this.Contas.All(c => c.ExibirNumero() != numero);
        }

        public bool ExisteContaPorNumero(int numero)
        {
            return this.Contas.Any(c => c.ExibirNumero() == numero);
        }

        public string ProximoNumeroConta()
        {
            return (this.Contas.Max(c => c.ExibirNumero()) + 1).ToString();
        }

        public bool Transferir(int numeroContaDeSaque, int numeroContaDeDeposito, double valorTransferencia)
        {
            var contaSaque = ConsultarContaPorNumero(numeroContaDeSaque);
            var contaDeposito = ConsultarContaPorNumero(numeroContaDeDeposito);

            contaSaque.Sacar(valorTransferencia, false);
            contaDeposito.Depositar(valorTransferencia, false);

            GravadorArquivo comprovante = new GravadorArquivo();
            comprovante.EscreverArquivo(comprovante.dirGravacao, contaSaque.arquivoTransf, "******TRANSFERÊNCIA******");
            comprovante.EscreverArquivo(comprovante.dirGravacao, contaSaque.arquivoTransf, "");
            comprovante.EscreverArquivo(comprovante.dirGravacao, contaSaque.arquivoTransf, "CONTA SAQUE: " + contaSaque.ExibirNumero());
            comprovante.EscreverArquivo(comprovante.dirGravacao, contaSaque.arquivoTransf, "CORRENTISTA SAQUE: " + contaSaque.ExibirTitular());
            comprovante.EscreverArquivo(comprovante.dirGravacao, contaSaque.arquivoTransf, "");
            comprovante.EscreverArquivo(comprovante.dirGravacao, contaSaque.arquivoTransf, "CONTA DEPÓSITO: " + contaDeposito.ExibirNumero());
            comprovante.EscreverArquivo(comprovante.dirGravacao, contaSaque.arquivoTransf, "CORRENTISTA DEPÓSITO: " + contaDeposito.ExibirTitular());
            comprovante.EscreverArquivo(comprovante.dirGravacao, contaSaque.arquivoTransf, "");
            comprovante.EscreverArquivo(comprovante.dirGravacao, contaSaque.arquivoTransf, "VALOR: " + String.Format("{0:C}", valorTransferencia));
            comprovante.EscreverArquivo(comprovante.dirGravacao, contaSaque.arquivoTransf, "");
            comprovante.EscreverArquivo(comprovante.dirGravacao, contaSaque.arquivoTransf, "Feito em " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
            comprovante.EscreverArquivo(comprovante.dirGravacao, contaSaque.arquivoTransf, "*************************");
            comprovante.EscreverArquivo(comprovante.dirGravacao, contaSaque.arquivoLog, "OPERAÇÃO TRANSFERÊNCIA feita em " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
            
            return true;
        }

        public Conta ConsultarContaPorNumero(int numero)
        {
            var conta = this.Contas.FirstOrDefault(c => c.ExibirNumero() == numero);
            if (conta == null)
                throw new ContaInexistenteException();
            return conta;
        }

        public IList<Conta> ConsultarContaPorCliente(Cliente cliente)
        {
            return this.Contas.Where(c => c.ExibirCliente() == cliente).ToList();
        }

        public void AtualizarBases()
        {
            GravadorArquivo arquivo = new GravadorArquivo();
            arquivo.SobreescreverArquivo(arquivo.dirGravacao, "contas.txt");

            foreach (var conta in this.Contas)
            {
                GravarConta(conta);
            }
        }
    }
}
 