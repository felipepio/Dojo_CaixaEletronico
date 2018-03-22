using CaixaEletronico.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico.Class
{
    public class ContaPoupanca : Conta, ITributavel
    {
        private const double TAXA_TRIBUTARIA = 0.05;
        
        public ContaPoupanca(int numero, Cliente titular, double saldo) : base(numero, titular, saldo)
        {
            this.descricao = "Conta Poupança";
            this.tipo = "2";
        }

        public double CalcularTributo()
        {
            return (base.RetornarSaldo(false) * TAXA_TRIBUTARIA);
        }

        public override double RetornarTaxa()
        {
            return TAXA_TRIBUTARIA;
        }
    }
}
