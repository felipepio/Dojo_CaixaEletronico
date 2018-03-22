using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilitarios;

namespace CaixaEletronico.Class
{
    public class Cliente
    {

        public string Nome { get; private set; }
        public string RG { get; private set; }
        public string CPF { get; private set; }
        public DateTime DataNascimento { get; private set; }

        public Cliente(string nome, string rg, string cpf, DateTime dataNascimento)
        {
            this.Nome = nome;
            this.RG = rg;
            this.CPF = cpf;
            this.DataNascimento = dataNascimento;
        }

        public string ExibirCPF()
        {
            return this.CPF;
        }

        public string ExibirNome()
        {
            return this.Nome;
        }

        public int ExibirIdade()
        {
            int idade;
            idade = DateTime.Now.Year - this.DataNascimento.Year;
            if (DateTime.Now.Month <= this.DataNascimento.Month && DateTime.Now.Day < this.DataNascimento.Day)
                idade--;

            return idade;
        }

        public DateTime ExibirDataNascimento()
        {
            return this.DataNascimento;
        }

        public string ExibirRG()
        {
            return this.RG;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            if (!(obj is Cliente))
                return false;

            Cliente cliente = obj as Cliente;
            return cliente.CPF == CPF;
        }

        public override int GetHashCode()
        {
            return ExibirCPF().GetHashCode();
        }

    }
}
