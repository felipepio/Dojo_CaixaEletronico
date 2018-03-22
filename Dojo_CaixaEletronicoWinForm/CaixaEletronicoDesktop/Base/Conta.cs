using CaixaEletronico.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CaixaEletronico.Exceptions;
using Utilitarios;

namespace CaixaEletronico.Base
{
    public abstract class Conta
    {

        private int numero;
        private Cliente titular;
        private double saldo;
        public abstract double RetornarTaxa();
        public string arquivoDeposito = "deposito.txt";
        public string arquivoSaque = "saque.txt";
        public string arquivoSaldo = "saldo.txt";
        public string arquivoTransf = "transferencia.txt";
        public string arquivoLog = "log.txt";
        public string tipo;
        public string descricao;


        public Conta(int numero, Cliente titular, double saldo)
        {
            this.numero = numero;
            this.titular = titular;
            this.saldo = saldo;
        }

        public void Sacar(double valor, bool emiteComprovante)
        {
            if (TemSaldo(valor))
            {
                this.saldo -= valor;
                if (emiteComprovante)
                {
                    GravadorArquivo comprovante = new GravadorArquivo();

                    StringBuilder log = new StringBuilder();
                    log.AppendLine("**********SAQUE**********");
                    log.AppendLine("");
                    log.AppendLine("CONTA: " + this.ExibirNumero());
                    log.AppendLine("CORRENTISTA: " + this.ExibirTitular());
                    log.AppendLine("VALOR BRUTO: " + String.Format("{0:C}", valor));
                    log.AppendLine("");
                    log.AppendLine("TRIBUTOS: " + String.Format("{0:C}", this.RetornarTaxa() * valor));
                    log.AppendLine("");
                    log.AppendLine("SALDO DISPONÍVEL: " + this.RetornarSaldoFormatado(false));
                    log.AppendLine("");
                    log.AppendLine("Feito em " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                    log.AppendLine("*************************");

                    comprovante.EscreverArquivo(comprovante.dirGravacao, arquivoSaque, log.ToString());
                    comprovante.EscreverArquivo(comprovante.dirGravacao, arquivoLog, "OPERAÇÃO SAQUE feita em " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                }                
            }
            else
                throw new SaldoInsuficienteException();
        }

        public void Depositar(double valor, bool emiteComprovante)
        {
            this.saldo += valor;
            if (emiteComprovante)
            {
                GravadorArquivo comprovante = new GravadorArquivo();

                StringBuilder log = new StringBuilder();
                log.AppendLine("********DEPÓSITO********");
                log.AppendLine("");
                log.AppendLine("CONTA: " + this.ExibirNumero());
                log.AppendLine("CORRENTISTA: " + this.ExibirTitular());
                log.AppendLine("VALOR: " + string.Format("{0:C}", valor));
                log.AppendLine("");
                log.AppendLine("Feito em " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                log.AppendLine("*************************");

                comprovante.EscreverArquivo(comprovante.dirGravacao, arquivoDeposito, log.ToString());
                comprovante.EscreverArquivo(comprovante.dirGravacao, arquivoLog, "OPERAÇÃO DEPÓSITO feita em " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
            }
        }


        public void Transferir(Conta destino, double valor)
        {
            this.saldo -= valor;
            destino.saldo += valor;
        }

        public double RetornarSaldo(bool emiteComprovante)
        {
            if (emiteComprovante)
            {
                GravadorArquivo comprovante = new GravadorArquivo();

                StringBuilder log = new StringBuilder();
                log.AppendLine("**********SALDO**********");
                log.AppendLine("");
                log.AppendLine("CONTA: " + this.ExibirNumero());
                log.AppendLine("CORRENTISTA: " + this.ExibirTitular());
                log.AppendLine("");
                log.AppendLine("SALDO DISPONÍVEL: " + this.RetornarSaldoFormatado(false));
                log.AppendLine("");
                log.AppendLine("Feito em " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                log.AppendLine("*************************");

                comprovante.EscreverArquivo(comprovante.dirGravacao, arquivoSaldo, log.ToString());
                comprovante.EscreverArquivo(comprovante.dirGravacao, arquivoLog, "OPERAÇÃO SALDO feita em " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
            }
            
            return this.saldo;
        }

        public int RetornarIdade()
        {
            return titular.ExibirIdade();
        }

        public string RetornarSaldoFormatado(bool emiteComprovante)
        {
            if (emiteComprovante)
            {
                GravadorArquivo comprovante = new GravadorArquivo();

                StringBuilder log = new StringBuilder();
                log.AppendLine("**********SALDO**********");
                log.AppendLine("");
                log.AppendLine("CONTA: " + this.ExibirNumero());
                log.AppendLine("CORRENTISTA: " + this.ExibirTitular());
                log.AppendLine("");
                log.AppendLine("SALDO DISPONÍVEL: " + this.RetornarSaldoFormatado(false));
                log.AppendLine("");
                log.AppendLine("Feito em " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                log.AppendLine("*************************");

                comprovante.EscreverArquivo(comprovante.dirGravacao, arquivoSaldo, log.ToString());
                comprovante.EscreverArquivo(comprovante.dirGravacao, arquivoLog, "OPERAÇÃO SALDO feita em " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
            }

            return String.Format("{0:C}", this.saldo);
        }

        public string ExibirTitular()
        {
            return this.titular.Nome;
        }

        public Cliente ExibirCliente()
        {
            return this.titular;
        }

        public String ExibirTipo()
        {
            return this.tipo;
        }

        public String ExibirDescricao()
        {
            return this.descricao;
        }

        public int ExibirNumero()
        {
            return this.numero;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            if (!(obj is Conta))
                return false;

            Conta conta = obj as Conta;
            return conta.ExibirNumero() == ExibirNumero();
        }

        public override int GetHashCode()
        {
            return ExibirNumero().GetHashCode();
        }

        public bool TemSaldo(double saque)
        {
            if (this.saldo >= saque)
                return true;

            return false;
        }
    }
}
