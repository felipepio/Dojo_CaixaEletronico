using CaixaEletronico.Base;
using CaixaEletronico.Class;
using CaixaEletronico.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilitarios;

namespace CaixaEletronico
{
    class Program
    {
        public static GerenciadorDeContas GerenciadorDeContasBanco { get; set; }
        public static GerenciadorDeClientes GerenciadorDeClientesBanco { get; set; }

        static void Main(string[] args)
        {
            GerenciadorDeContasBanco = new GerenciadorDeContas();
            GerenciadorDeClientesBanco = new GerenciadorDeClientes();
            CarregarClientes();
            CarregarContas();

            var key = "";

            while (key.ToUpper() != "Q")
            {
                Console.Clear();

                Console.WriteLine("1 - Criar uma Conta Corrente.");
                Console.WriteLine("2 - Criar uma Conta Poupança.");
                Console.WriteLine("3 - Criar uma Conta Investimento.");
                Console.WriteLine("4 - Consultar Conta");
                Console.WriteLine("5 - Consultar Cliente");
                Console.WriteLine("Q - Para Sair");

                Console.WriteLine();
                Console.Write("Informe um valor: ");
                key = Convert.ToString(Console.ReadLine());

                try
                {
                    switch (key)
                    {
                        case "1":
                            var cc = CriarContas<ContaCorrente>();
                            MenuDaConta(cc, cc);
                            break;

                        case "2":
                            var cp = CriarContas<ContaPoupanca>();
                            MenuDaConta(cp, cp);
                            break;
                        case "3":
                            var ci = CriarContas<ContaInvestimento>();
                            MenuDaConta(ci, ci);
                            break;
                        case "4":
                            Console.Write("Informe o número da Conta: ");
                            int numero = Convert.ToInt32(Console.ReadLine());
                            var conta = GerenciadorDeContasBanco.ConsultarContaPorNumero(numero);
                            MenuDaConta(conta, null);
                            break;
                        case "5":
                            Console.Write("Informe o CPF do cliente: ");
                            string cpf = Convert.ToString(Console.ReadLine());
                            var cliente = GerenciadorDeClientesBanco.ConsultarClientePorCPF(cpf);
                            MenuDoCliente(cliente);
                            break;
                        default:
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    key = PressioneParaContinuar();
                }
            }
            GerenciadorDeClientesBanco.AtualizarBases();
            GerenciadorDeContasBanco.AtualizarBases();
        }

        //Exemplo clássico generico
        private static T CriarContas<T>() where T : Conta
        {
            Console.Clear();

            Console.Write("Informe o número da Conta: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (GerenciadorDeContasBanco.ContaValidaParaCriacao(numero))
            {
                var titular = CriarCliente<Cliente>();

                Console.Write("Informe o saldo da conta: ");
                double saldo = Convert.ToDouble(Console.ReadLine());

                // Cria um instancia generica, conforme o tipo!
                T conta = (T)Activator.CreateInstance(typeof(T), new object[] { numero, titular, saldo });

                GerenciadorDeContasBanco.AdicionarConta(conta);
                GerenciadorDeContasBanco.GravarConta(conta);

                return conta;
            }

            throw new ContaExistenteException();
        }

        private static T CriarCliente<T>() where T : Cliente
        {
            Console.Write("Informe o CPF do titular: ");
            string cpf = Convert.ToString(Console.ReadLine());

            if (GerenciadorDeClientesBanco.ExisteCliente(cpf))
            {
                T clienteEncontrado = (T)GerenciadorDeClientesBanco.ConsultarClientePorCPF(cpf);
                Console.WriteLine("Cliente encontrado!");
                Console.WriteLine("Nome do cliente: " + clienteEncontrado.Nome);
                Console.WriteLine("RG do cliente: " + clienteEncontrado.RG);
                Console.WriteLine("Data de nascimento: " + clienteEncontrado.DataNascimento);
                return clienteEncontrado;
            }

            Console.Write("Informe o nome do titular: ");
            string nome = Convert.ToString(Console.ReadLine());

            Console.Write("Informe o rg do titular: ");
            string rg = Convert.ToString(Console.ReadLine());

            Console.Write("Informe a data de nascimento do titular: ");
            DateTime dataNascimento = Convert.ToDateTime(Console.ReadLine());

            T cliente = (T)Activator.CreateInstance(typeof(T), new object[] { nome, rg, cpf, dataNascimento } );

            GerenciadorDeClientesBanco.AdicionarCliente(cliente);
            GerenciadorDeClientesBanco.GravarCliente(cliente);
            return cliente;
        }

        private static void MenuDaConta(Conta conta, ITributavel tributo = null)
        {
            string key = "";
            double valor = 0;

            while (key.ToUpper() != "Q")
            {
                Console.Clear();

                Console.WriteLine("Nome do Cliente: " + conta.ExibirTitular());
                Console.WriteLine("Número da Conta: " + conta.ExibirNumero());
                Console.WriteLine();
                Console.WriteLine("1 - Depositar.");
                Console.WriteLine("2 - Sacar.");
                Console.WriteLine("3 - Transferir.");
                Console.WriteLine("4 - Ver Saldo.");
                Console.WriteLine("5 - Resumo Tributário.");
                Console.WriteLine("Q - Para Sair");

                Console.WriteLine();
                Console.Write("Informe um valor: ");
                key = Convert.ToString(Console.ReadLine());

                switch (key)
                {
                    case "1":
                        Console.Clear();
                        Console.Write("Informe o valor a depositar: ");
                        valor = Convert.ToDouble(Console.ReadLine());
                        conta.Depositar(valor, true);
                        Console.WriteLine();
                        Console.WriteLine("Saldo Atual: " + conta.RetornarSaldoFormatado(false));

                        key = PressioneParaContinuar();
                        break;

                    case "2":
                        Console.Clear();
                        Console.Write("Informe o valor a sacar: ");
                        valor = Convert.ToDouble(Console.ReadLine());
                        conta.Sacar(valor, true);
                        Console.WriteLine();
                        Console.WriteLine("Saldo Atual: " + conta.RetornarSaldoFormatado(false));

                        key = PressioneParaContinuar();
                        break;

                    case "3":
                        Console.Clear();

                        if (GerenciadorDeContasBanco.ExisteContaPorNumero(conta.ExibirNumero()))
                        {
                            Console.Write("Informe o número da Conta de Depósito: ");
                            int numeroContaDeDeposito = Convert.ToInt32(Console.ReadLine());
                            if (GerenciadorDeContasBanco.ExisteContaPorNumero(numeroContaDeDeposito))
                            {
                                Console.Write("Informe o valor da transferência: ");
                                var valorTransferencia = Convert.ToDouble(Console.ReadLine());
                                string msgOperacao = "Transferência feita com sucesso!";
                                if (!GerenciadorDeContasBanco.Transferir(conta.ExibirNumero(), numeroContaDeDeposito, valorTransferencia))
                                {
                                    msgOperacao = "Transferência não foi realizada com sucesso. Tente novamente";
                                }
                                Console.WriteLine(msgOperacao);
                            }
                            else
                            {
                                throw new ContaInexistenteException();
                            }
                        }
                        else
                        {
                            throw new ContaInexistenteException();
                        }

                        key = PressioneParaContinuar();
                        break;

                    case "4":
                        Console.Clear();
                        Console.WriteLine("Saldo Atual: " + String.Format("{0:C}", conta.RetornarSaldo(true)));

                        key = PressioneParaContinuar();
                        break;

                    case "5":
                        Console.Clear();
                        Console.WriteLine("Conta: " + conta.ExibirNumero());
                        Console.WriteLine("Titular: " + conta.ExibirTitular());
                        Console.WriteLine("Total de Tributos: " + CalcularTaxaOtimizada(conta));

                        key = PressioneParaContinuar();
                        break;

                    default:
                        break;
                }
            }
        }

        private static void MenuDoCliente(Cliente cliente)
        {
            string key = "";

            while (key.ToUpper() != "Q")
            {
                Console.Clear();

                Console.WriteLine("Olá " + cliente.ExibirNome() + "! Você tem " + cliente.ExibirIdade() + " anos");
                Console.WriteLine();
                Console.WriteLine("Nome do Cliente: " + cliente.ExibirNome());
                Console.WriteLine("Número do CPF: " + cliente.ExibirCPF());
                Console.WriteLine();
                Console.WriteLine("1 - Exibir dados cadastrais completos.");
                Console.WriteLine("2 - Exibir saldos de contas.");
                Console.WriteLine("Q - Para Sair");

                Console.WriteLine();
                Console.Write("Informe um valor: ");
                key = Convert.ToString(Console.ReadLine());

                switch (key)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Nome do Cliente: " + cliente.ExibirNome());
                        Console.WriteLine("Número do CPF: " + cliente.ExibirCPF());
                        Console.WriteLine("Número do RG: " + cliente.ExibirRG());
                        Console.WriteLine("Data de Nascimento: " + cliente.ExibirDataNascimento().ToString("dd/MM/yyyy"));

                        key = PressioneParaContinuar();
                        break;

                    case "2":
                        Console.Clear();
                        IList<Conta> contasCli;
                        contasCli = GerenciadorDeContasBanco.ConsultarContaPorCliente(cliente);
                        foreach (Conta conta in contasCli)
                        {
                            Console.WriteLine("Número da conta: " + conta.ExibirNumero());
                            Console.WriteLine("Tipo da conta: " + conta.ExibirDescricao());
                            Console.WriteLine("Saldo da conta: " + conta.RetornarSaldoFormatado(false));
                            Console.WriteLine();
                        }

                        key = PressioneParaContinuar();
                        break;         

                    default:
                        break;
                }
            }
        }

        private static string PressioneParaContinuar()
        {
            Console.WriteLine();
            Console.Write("Pressione qualquer tecla para continuar...");
            return Convert.ToString(Console.ReadLine());
        }

        private static double CalcularTaxaOtimizada(Conta conta)
        {
            IList<Conta> contasCli;
            contasCli = GerenciadorDeContasBanco.ConsultarContaPorCliente(conta.ExibirCliente());
            var menorTaxa = contasCli.Min(c => c.RetornarTaxa());

            return menorTaxa * conta.RetornarSaldo(false);
        }

        public static void CarregarClientes()
        {
            LeitorArquivo arquivo = new LeitorArquivo();
            IList<string> clientes = arquivo.LerLinhasArquivo(arquivo.dirLeitura, "clientes.txt");
            foreach (var cliente in clientes)
            {
                string[] lerCliente = cliente.Split(';');
                var novoCliente = new Cliente(lerCliente[1], lerCliente[2], lerCliente[0], DateTime.Parse(lerCliente[3]));
                GerenciadorDeClientesBanco.AdicionarCliente(novoCliente);
            }
        }

        public static void CarregarContas()
        {
            LeitorArquivo arquivo = new LeitorArquivo();
            IList<string> contas = arquivo.LerLinhasArquivo(arquivo.dirLeitura, "contas.txt");
            foreach (var conta in contas)
            {
                string[] lerConta = conta.Split(';');
                var cliente = GerenciadorDeClientesBanco.ConsultarClientePorCPF(lerConta[1]);
                switch (lerConta[3])
                {
                    case "1":
                        var novaContaC = new ContaCorrente(int.Parse(lerConta[0]), cliente, Double.Parse(lerConta[2]));
                        GerenciadorDeContasBanco.AdicionarConta(novaContaC);
                        break;
                    case "2":
                        var novaContaP = new ContaPoupanca(int.Parse(lerConta[0]), cliente, Double.Parse(lerConta[2]));
                        GerenciadorDeContasBanco.AdicionarConta(novaContaP);
                        break;
                    case "3":
                        var novaContaI = new ContaInvestimento(int.Parse(lerConta[0]), cliente, Double.Parse(lerConta[2]));
                        GerenciadorDeContasBanco.AdicionarConta(novaContaI);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
