using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CaixaEletronico.Class;
using Utilitarios;
using CaixaEletronico.Base;

namespace CaixaEletronicoDesktop
{
    public partial class frmMenu : Form
    {
        public static GerenciadorDeContas GerenciadorDeContasBanco { get; set; }
        public static GerenciadorDeClientes GerenciadorDeClientesBanco { get; set; }
        public string tipoConta = "0";
        public Conta contaSelecionada;

        public frmMenu()
        {
            InitializeComponent();
            this.PrepararTela();

            GerenciadorDeContasBanco = new GerenciadorDeContas();
            GerenciadorDeClientesBanco = new GerenciadorDeClientes();
            CarregarClientes();
            CarregarContas();

        }

        private void PrepararTela()
        {
            this.tabMenu.Visible = false;
            this.tabMenu.Appearance = TabAppearance.FlatButtons;
            this.tabMenu.ItemSize = new Size(0, 1);
            this.tabMenu.SizeMode = TabSizeMode.Fixed;
            this.pnlCliente.Visible = false;
            this.pnlNovoCliente.Visible = false;
        }

        private void contaCorrenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaNovaConta("1");
        }

        private void contaPoupançaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaNovaConta("2");
        }

        private void contaInvestimentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaNovaConta("3");
        }

        public void TelaNovaConta(string tipo)
        {
            tipoConta = tipo;
            pnlCliente.Visible = false;
            this.tabMenu.Visible = true;
            this.tabMenu.SelectedTab = this.tabNovaConta;
            this.txtContaNumero.Text = GerenciadorDeContasBanco.ProximoNumeroConta();
            this.txtClienteCPF.Text = string.Empty;
            this.txtContaSaldo.Text = "0";
            this.txtContaSaldo.Visible = false;
            this.lblContaSaldo.Visible = false;
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

        private void btnClienteBuscar_Click(object sender, EventArgs e)
        {
            if (GerenciadorDeClientesBanco.ExisteCliente(txtClienteCPF.Text))
            {
                var cliente = GerenciadorDeClientesBanco.ConsultarClientePorCPF(txtClienteCPF.Text);
                txtClienteNome.Text = cliente.ExibirNome();
                txtClienteRG.Text = cliente.ExibirRG();
                dtpClienteDataNascimento.Value = cliente.ExibirDataNascimento();
                pnlCliente.Enabled = false;
            }
            else
            {
                txtClienteNome.Text = string.Empty;
                txtClienteRG.Text = string.Empty;
                dtpClienteDataNascimento.Value = DateTime.Now;
                pnlCliente.Enabled = true;
            }

            pnlCliente.Visible = true;
            txtContaSaldo.Visible = true;
            lblContaSaldo.Visible = true;
        }

        private void txtClienteCPF_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnClienteBuscar_Click(this, new EventArgs());
            }
        }

        private void btnCriarConta_Click(object sender, EventArgs e)
        {
            if (GerenciadorDeContasBanco.ContaValidaParaCriacao(int.Parse(txtContaNumero.Text)))
            {
                Cliente cliente;
                if (GerenciadorDeClientesBanco.ExisteCliente(txtClienteCPF.Text) == false)
                {
                    cliente = new Cliente(txtClienteNome.Text, txtClienteRG.Text, txtClienteCPF.Text, dtpClienteDataNascimento.Value);
                    GerenciadorDeClientesBanco.AdicionarCliente(cliente);
                    GerenciadorDeClientesBanco.GravarCliente(cliente);
                }
                else
                {
                    cliente = GerenciadorDeClientesBanco.ConsultarClientePorCPF(txtClienteCPF.Text);
                }

                switch (tipoConta)
                {
                    case "1":
                        CriarContas<ContaCorrente>(int.Parse(txtContaNumero.Text), cliente, double.Parse(txtContaSaldo.Text));
                        break;
                    case "2":
                        CriarContas<ContaPoupanca>(int.Parse(txtContaNumero.Text), cliente, double.Parse(txtContaSaldo.Text));
                        break;
                    case "3":
                        CriarContas<ContaInvestimento>(int.Parse(txtContaNumero.Text), cliente, double.Parse(txtContaSaldo.Text));
                        break;
                    default:
                        break;
                }
            }
            MessageBox.Show("Gravado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.PrepararTela();
        }

        private void CriarContas<T>(int numero, Cliente titular, double saldo) where T : Conta
        {
            T conta = (T)Activator.CreateInstance(typeof(T), new object[] { numero, titular, saldo });

            GerenciadorDeContasBanco.AdicionarConta(conta);
            GerenciadorDeContasBanco.GravarConta(conta);
        }

        private void btnCliBuscarCliente_Click(object sender, EventArgs e)
        {
            if (GerenciadorDeClientesBanco.ExisteCliente(txtNovoClienteCPF.Text))
            {
                var cliente = GerenciadorDeClientesBanco.ConsultarClientePorCPF(txtNovoClienteCPF.Text);
                txtNovoClienteNome.Text = cliente.ExibirNome();
                txtNovoClienteRG.Text = cliente.ExibirRG();
                dtpNovoClienteDataNascimento.Value = cliente.ExibirDataNascimento();
                pnlNovoCliente.Enabled = false;
                btnGravarCliente.Enabled = false;
                MessageBox.Show("Cliente já existente na base!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                txtNovoClienteNome.Text = string.Empty;
                txtNovoClienteRG.Text = string.Empty;
                dtpNovoClienteDataNascimento.Value = DateTime.Now;
                pnlNovoCliente.Enabled = true;
                btnGravarCliente.Enabled = true;
            }

            pnlNovoCliente.Visible = true;

        }

        private void novoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaNovoCliente();
        }

        public void TelaNovoCliente()
        {
            pnlNovoCliente.Visible = false;
            this.tabMenu.Visible = true;
            this.tabMenu.SelectedTab = this.tabNovoCliente;
            this.txtNovoClienteCPF.Text = string.Empty;
        }

        private void btnGravarCliente_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente(txtNovoClienteNome.Text, txtNovoClienteRG.Text, txtNovoClienteCPF.Text, dtpNovoClienteDataNascimento.Value);
            GerenciadorDeClientesBanco.AdicionarCliente(cliente);
            GerenciadorDeClientesBanco.GravarCliente(cliente);
            MessageBox.Show("Gravado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.PrepararTela();
        }

        private void consultarContaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaConsultarConta();
        }

        public void TelaConsultarConta()
        {
            pnlAcoesConta.Visible = false;
            pnlSaudacao.Visible = false;
            pnlInstrucao.Visible = false;
            pnlTransferencia.Visible = false;
            pnlTransfInfoConta.Visible = false;
            this.lblSaldoDisponivel.Visible = false;
            this.tabMenu.Visible = true;
            this.tabMenu.SelectedTab = this.tabConsultarConta;
            this.txtNumeroConta.Text = string.Empty;
        }

        private void txtNovoClienteCPF_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCliBuscarCliente_Click(this, new EventArgs());
            }
        }

        private void btnConsultarConta_Click(object sender, EventArgs e)
        {
            try
            {
                if (GerenciadorDeContasBanco.ExisteContaPorNumero(int.Parse(txtNumeroConta.Text)))
                {
                    contaSelecionada = GerenciadorDeContasBanco.ConsultarContaPorNumero(int.Parse(txtNumeroConta.Text));
                    lblNomeCliente.Text = contaSelecionada.ExibirTitular() + "!";
                    lblIdadeCliente.Text = contaSelecionada.RetornarIdade().ToString() + " anos";
                    lblTipoConta.Text = contaSelecionada.ExibirDescricao();
                    pnlAcoesConta.Visible = true;
                    pnlSaudacao.Visible = true;
                    pnlInstrucao.Visible = false;
                    pnlTransferencia.Visible = false;
                    btnSaldo.Text = "Ocultar Saldo";
                    btnSaldo_Click(this, new EventArgs());
                }
                else
                {
                    MessageBox.Show("Conta não encontrada! Tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNumeroConta.Text = string.Empty;
                    txtNumeroConta.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dados da conta inválidos! Tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tabConsultarConta_Click(object sender, EventArgs e)
        {

        }

        private void btnSaldo_Click(object sender, EventArgs e)
        {
            if (btnSaldo.Text == "Exibir Saldo")
            {
                lblSaldoDisponivel.Text = contaSelecionada.RetornarSaldoFormatado(true);
                lblSaldoDisponivel.Visible = true;
                btnSaldo.Text = "Ocultar Saldo";
            }
            else
            {
                lblSaldoDisponivel.Visible = false;
                btnSaldo.Text = "Exibir Saldo";
            }
        }

        private void btnSaque_Click(object sender, EventArgs e)
        {
            pnlInstrucao.Visible = true;
            pnlTransferencia.Visible = false;
            lblInstrucao.Text = "Digite o valor desejado para o saque:";
            txtInstrucao.Text = string.Empty;
            btnInstrucao.Text = "Sacar";
            txtInstrucao.Focus();
        }

        private void btnDeposito_Click(object sender, EventArgs e)
        {
            pnlInstrucao.Visible = true;
            pnlTransferencia.Visible = false;
            lblInstrucao.Text = "Digite o valor desejado para o depósito:";
            txtInstrucao.Text = string.Empty;
            btnInstrucao.Text = "Depositar";
            txtInstrucao.Focus();
        }

        private void btnInstrucao_Click(object sender, EventArgs e)
        {
            double retNum;
            bool ehNumerico = double.TryParse(txtInstrucao.Text, System.Globalization.NumberStyles.Currency, System.Globalization.NumberFormatInfo.InvariantInfo, out retNum);
            if (ehNumerico)
            {
                try
                {
                    switch (btnInstrucao.Text)
                    {
                        case "Sacar":
                            {
                                contaSelecionada.Sacar(Convert.ToDouble(txtInstrucao.Text), true);
                                MessageBox.Show("Saque efetuado com sucesso!" + Environment.NewLine + "Novo saldo: " + contaSelecionada.RetornarSaldoFormatado(false), "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                            }
                        case "Depositar":
                            {
                                contaSelecionada.Depositar(Convert.ToDouble(txtInstrucao.Text), true);
                                MessageBox.Show("Depósito efetuado com sucesso!" + Environment.NewLine + "Novo saldo: " + contaSelecionada.RetornarSaldoFormatado(false), "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                            }
                        default:
                            break;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    btnConsultarConta_Click(this, new EventArgs());
                }
            }
            else
            {
                MessageBox.Show("Valor inválido! Digite novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtInstrucao.Focus();
            }

        }

        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            GerenciadorDeClientesBanco.AtualizarBases();
            GerenciadorDeContasBanco.AtualizarBases();
        }

        private void btnTransferencia_Click(object sender, EventArgs e)
        {
            pnlInstrucao.Visible = false;
            pnlTransferencia.Visible = true;
            pnlTransfInfoConta.Visible = false;
            lblTransfValor.Visible = false;
            txtTransfValor.Visible = false;
            txtTransfValor.Text = string.Empty;
            txtTransfConta.Text = string.Empty;
        }

        private void btnTransfConsultaConta_Click(object sender, EventArgs e)
        {
            try
            {
                Conta contaTransf;
                if (GerenciadorDeContasBanco.ExisteContaPorNumero(int.Parse(txtTransfConta.Text)))
                {
                    contaTransf = GerenciadorDeContasBanco.ConsultarContaPorNumero(int.Parse(txtTransfConta.Text));
                    lblTransfTitular.Text = contaTransf.ExibirTitular();
                    lblTransfTipoConta.Text = contaTransf.ExibirDescricao();
                    pnlTransfInfoConta.Visible = true;
                    lblTransfValor.Visible = true;
                    txtTransfValor.Visible = true;
                }
                else
                {
                    MessageBox.Show("Conta não encontrada! Tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTransfConta.Text = string.Empty;
                    txtTransfConta.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dados da conta inválidos! Tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTransferir_Click(object sender, EventArgs e)
        {
            double retNum;
            bool ehNumerico = double.TryParse(txtTransfValor.Text, System.Globalization.NumberStyles.Currency, System.Globalization.NumberFormatInfo.InvariantInfo, out retNum);
            if (ehNumerico)
            {
                try
                {
                    GerenciadorDeContasBanco.Transferir(contaSelecionada.ExibirNumero(), int.Parse(txtTransfConta.Text), Convert.ToDouble(txtTransfValor.Text));
                    StringBuilder mensagem = new StringBuilder();
                    mensagem.AppendLine("Transferência efetuada com sucesso!");
                    mensagem.AppendLine("Conta Origem: " + contaSelecionada.ExibirNumero());
                    mensagem.AppendLine("Titular Origem: " + contaSelecionada.ExibirTitular());
                    mensagem.AppendLine("");
                    mensagem.AppendLine("Conta Destino: " + txtTransfConta.Text);
                    mensagem.AppendLine("Titular Destino: " + lblTransfTitular.Text);
                    mensagem.AppendLine("");
                    mensagem.AppendLine("Valor: " + String.Format("{0:C}", Convert.ToDouble(txtTransfValor.Text)));
                    MessageBox.Show(mensagem.ToString(), "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    btnConsultarConta_Click(this, new EventArgs());
                }
            }
        }

        private void consultarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaConsultarCliente();
        }

        public void TelaConsultarCliente()
        {
            this.tabMenu.Visible = true;
            this.tabMenu.SelectedTab = this.tabConsultarCliente;


        }

        private void btnConsultaCPF_Click(object sender, EventArgs e)
        {
            lstContas.Items.Clear();
            var con = lstContas.Columns.Count;
            if (GerenciadorDeClientesBanco.ExisteCliente(txtConsultaCPF.Text))
            {
                var cliente = GerenciadorDeClientesBanco.ConsultarClientePorCPF(txtConsultaCPF.Text);
                var contas = GerenciadorDeContasBanco.ConsultarContaPorCliente(cliente);
                foreach (Conta conta in contas)
                {
                    lstContas.Items.Add(new ListViewItem(new string[] {
                        conta.ExibirNumero().ToString(), 
                        conta.ExibirDescricao(), 
                        conta.RetornarSaldoFormatado(false)
                    }));
                }
            }
            else
            {
                txtNovoClienteNome.Text = string.Empty;
                txtNovoClienteRG.Text = string.Empty;
                dtpNovoClienteDataNascimento.Value = DateTime.Now;
                pnlNovoCliente.Enabled = true;
                btnGravarCliente.Enabled = true;
            }

            pnlNovoCliente.Visible = true;

        }

        private void lstContas_DoubleClick(object sender, EventArgs e)
        {
            TelaConsultarConta();
            txtNumeroConta.Text = lstContas.SelectedItems[0].Text;
            btnConsultarConta_Click(this, new EventArgs());
        }
    }
}

