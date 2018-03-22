using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico.Exceptions
{
    public class SaldoInsuficienteException : Exception
    {
        public SaldoInsuficienteException()
            : base("Saldo insuficiente")
        {
        }
    }
}
