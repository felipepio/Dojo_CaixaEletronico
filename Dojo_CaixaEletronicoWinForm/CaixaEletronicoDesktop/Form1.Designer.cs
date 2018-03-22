namespace CaixaEletronicoDesktop
{
    partial class frmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.contaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaContaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contaCorrenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contaPoupançaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contaInvestimentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarContaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabMenu = new System.Windows.Forms.TabControl();
            this.tabNovaConta = new System.Windows.Forms.TabPage();
            this.txtContaSaldo = new System.Windows.Forms.MaskedTextBox();
            this.lblContaSaldo = new System.Windows.Forms.Label();
            this.btnCriarConta = new System.Windows.Forms.Button();
            this.btnClienteBuscar = new System.Windows.Forms.Button();
            this.pnlCliente = new System.Windows.Forms.Panel();
            this.lblClienteDataNascimento = new System.Windows.Forms.Label();
            this.dtpClienteDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.lblClienteRG = new System.Windows.Forms.Label();
            this.lblClienteNome = new System.Windows.Forms.Label();
            this.txtClienteRG = new System.Windows.Forms.TextBox();
            this.txtClienteNome = new System.Windows.Forms.TextBox();
            this.lblClienteCPF = new System.Windows.Forms.Label();
            this.txtClienteCPF = new System.Windows.Forms.TextBox();
            this.lblContaNumero = new System.Windows.Forms.Label();
            this.txtContaNumero = new System.Windows.Forms.TextBox();
            this.tabNovoCliente = new System.Windows.Forms.TabPage();
            this.btnGravarCliente = new System.Windows.Forms.Button();
            this.pnlNovoCliente = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpNovoClienteDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNovoClienteRG = new System.Windows.Forms.TextBox();
            this.txtNovoClienteNome = new System.Windows.Forms.TextBox();
            this.btnCliBuscarCliente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNovoClienteCPF = new System.Windows.Forms.TextBox();
            this.tabConsultarConta = new System.Windows.Forms.TabPage();
            this.pnlTransferencia = new System.Windows.Forms.Panel();
            this.btnTransfConsultaConta = new System.Windows.Forms.Button();
            this.lblTransfValor = new System.Windows.Forms.Label();
            this.txtTransfValor = new System.Windows.Forms.TextBox();
            this.pnlTransfInfoConta = new System.Windows.Forms.Panel();
            this.btnTransferir = new System.Windows.Forms.Button();
            this.lblTransfTipoConta = new System.Windows.Forms.Label();
            this.lblTransfTitular = new System.Windows.Forms.Label();
            this.lblTransfConta = new System.Windows.Forms.Label();
            this.txtTransfConta = new System.Windows.Forms.TextBox();
            this.pnlInstrucao = new System.Windows.Forms.Panel();
            this.btnInstrucao = new System.Windows.Forms.Button();
            this.lblInstrucao = new System.Windows.Forms.Label();
            this.txtInstrucao = new System.Windows.Forms.TextBox();
            this.pnlSaudacao = new System.Windows.Forms.Panel();
            this.lblTipoConta = new System.Windows.Forms.Label();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.lblIdadeCliente = new System.Windows.Forms.Label();
            this.lblSaudacao = new System.Windows.Forms.Label();
            this.btnConsultarConta = new System.Windows.Forms.Button();
            this.pnlAcoesConta = new System.Windows.Forms.Panel();
            this.btnDeposito = new System.Windows.Forms.Button();
            this.btnTransferencia = new System.Windows.Forms.Button();
            this.btnSaque = new System.Windows.Forms.Button();
            this.lblSaldoDisponivel = new System.Windows.Forms.Label();
            this.btnSaldo = new System.Windows.Forms.Button();
            this.lblNumeroConta = new System.Windows.Forms.Label();
            this.txtNumeroConta = new System.Windows.Forms.TextBox();
            this.tabConsultarCliente = new System.Windows.Forms.TabPage();
            this.lstContas = new System.Windows.Forms.ListView();
            this.clnConta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnDescricao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnSaldo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnConsultaCPF = new System.Windows.Forms.Button();
            this.lblConsultaCPF = new System.Windows.Forms.Label();
            this.txtConsultaCPF = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.tabMenu.SuspendLayout();
            this.tabNovaConta.SuspendLayout();
            this.pnlCliente.SuspendLayout();
            this.tabNovoCliente.SuspendLayout();
            this.pnlNovoCliente.SuspendLayout();
            this.tabConsultarConta.SuspendLayout();
            this.pnlTransferencia.SuspendLayout();
            this.pnlTransfInfoConta.SuspendLayout();
            this.pnlInstrucao.SuspendLayout();
            this.pnlSaudacao.SuspendLayout();
            this.pnlAcoesConta.SuspendLayout();
            this.tabConsultarCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contaToolStripMenuItem,
            this.clienteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(558, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // contaToolStripMenuItem
            // 
            this.contaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novaContaToolStripMenuItem,
            this.consultarContaToolStripMenuItem});
            this.contaToolStripMenuItem.Name = "contaToolStripMenuItem";
            this.contaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.contaToolStripMenuItem.Text = "Conta";
            // 
            // novaContaToolStripMenuItem
            // 
            this.novaContaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contaCorrenteToolStripMenuItem,
            this.contaPoupançaToolStripMenuItem,
            this.contaInvestimentoToolStripMenuItem});
            this.novaContaToolStripMenuItem.Name = "novaContaToolStripMenuItem";
            this.novaContaToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.novaContaToolStripMenuItem.Text = "Nova Conta";
            // 
            // contaCorrenteToolStripMenuItem
            // 
            this.contaCorrenteToolStripMenuItem.Name = "contaCorrenteToolStripMenuItem";
            this.contaCorrenteToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.contaCorrenteToolStripMenuItem.Text = "Conta Corrente";
            this.contaCorrenteToolStripMenuItem.Click += new System.EventHandler(this.contaCorrenteToolStripMenuItem_Click);
            // 
            // contaPoupançaToolStripMenuItem
            // 
            this.contaPoupançaToolStripMenuItem.Name = "contaPoupançaToolStripMenuItem";
            this.contaPoupançaToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.contaPoupançaToolStripMenuItem.Text = "Conta Poupança";
            this.contaPoupançaToolStripMenuItem.Click += new System.EventHandler(this.contaPoupançaToolStripMenuItem_Click);
            // 
            // contaInvestimentoToolStripMenuItem
            // 
            this.contaInvestimentoToolStripMenuItem.Name = "contaInvestimentoToolStripMenuItem";
            this.contaInvestimentoToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.contaInvestimentoToolStripMenuItem.Text = "Conta Investimento";
            this.contaInvestimentoToolStripMenuItem.Click += new System.EventHandler(this.contaInvestimentoToolStripMenuItem_Click);
            // 
            // consultarContaToolStripMenuItem
            // 
            this.consultarContaToolStripMenuItem.Name = "consultarContaToolStripMenuItem";
            this.consultarContaToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.consultarContaToolStripMenuItem.Text = "Consultar Conta";
            this.consultarContaToolStripMenuItem.Click += new System.EventHandler(this.consultarContaToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoClienteToolStripMenuItem,
            this.consultarClienteToolStripMenuItem});
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.clienteToolStripMenuItem.Text = "Cliente";
            // 
            // novoClienteToolStripMenuItem
            // 
            this.novoClienteToolStripMenuItem.Name = "novoClienteToolStripMenuItem";
            this.novoClienteToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.novoClienteToolStripMenuItem.Text = "Novo Cliente";
            this.novoClienteToolStripMenuItem.Click += new System.EventHandler(this.novoClienteToolStripMenuItem_Click);
            // 
            // consultarClienteToolStripMenuItem
            // 
            this.consultarClienteToolStripMenuItem.Name = "consultarClienteToolStripMenuItem";
            this.consultarClienteToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.consultarClienteToolStripMenuItem.Text = "Consultar Cliente";
            this.consultarClienteToolStripMenuItem.Click += new System.EventHandler(this.consultarClienteToolStripMenuItem_Click);
            // 
            // tabMenu
            // 
            this.tabMenu.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabMenu.Controls.Add(this.tabNovaConta);
            this.tabMenu.Controls.Add(this.tabNovoCliente);
            this.tabMenu.Controls.Add(this.tabConsultarConta);
            this.tabMenu.Controls.Add(this.tabConsultarCliente);
            this.tabMenu.Location = new System.Drawing.Point(12, 27);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.SelectedIndex = 0;
            this.tabMenu.Size = new System.Drawing.Size(534, 432);
            this.tabMenu.TabIndex = 1;
            // 
            // tabNovaConta
            // 
            this.tabNovaConta.BackColor = System.Drawing.Color.White;
            this.tabNovaConta.Controls.Add(this.txtContaSaldo);
            this.tabNovaConta.Controls.Add(this.lblContaSaldo);
            this.tabNovaConta.Controls.Add(this.btnCriarConta);
            this.tabNovaConta.Controls.Add(this.btnClienteBuscar);
            this.tabNovaConta.Controls.Add(this.pnlCliente);
            this.tabNovaConta.Controls.Add(this.lblClienteCPF);
            this.tabNovaConta.Controls.Add(this.txtClienteCPF);
            this.tabNovaConta.Controls.Add(this.lblContaNumero);
            this.tabNovaConta.Controls.Add(this.txtContaNumero);
            this.tabNovaConta.Location = new System.Drawing.Point(4, 25);
            this.tabNovaConta.Name = "tabNovaConta";
            this.tabNovaConta.Padding = new System.Windows.Forms.Padding(3);
            this.tabNovaConta.Size = new System.Drawing.Size(526, 372);
            this.tabNovaConta.TabIndex = 0;
            this.tabNovaConta.Text = "Nova Conta";
            // 
            // txtContaSaldo
            // 
            this.txtContaSaldo.Location = new System.Drawing.Point(35, 259);
            this.txtContaSaldo.Name = "txtContaSaldo";
            this.txtContaSaldo.Size = new System.Drawing.Size(116, 20);
            this.txtContaSaldo.TabIndex = 11;
            this.txtContaSaldo.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lblContaSaldo
            // 
            this.lblContaSaldo.AutoSize = true;
            this.lblContaSaldo.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContaSaldo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblContaSaldo.Location = new System.Drawing.Point(32, 242);
            this.lblContaSaldo.Name = "lblContaSaldo";
            this.lblContaSaldo.Size = new System.Drawing.Size(67, 15);
            this.lblContaSaldo.TabIndex = 10;
            this.lblContaSaldo.Text = "Saldo Inicial:";
            // 
            // btnCriarConta
            // 
            this.btnCriarConta.Location = new System.Drawing.Point(429, 290);
            this.btnCriarConta.Name = "btnCriarConta";
            this.btnCriarConta.Size = new System.Drawing.Size(75, 23);
            this.btnCriarConta.TabIndex = 6;
            this.btnCriarConta.Text = "Criar Conta";
            this.btnCriarConta.UseVisualStyleBackColor = true;
            this.btnCriarConta.Click += new System.EventHandler(this.btnCriarConta_Click);
            // 
            // btnClienteBuscar
            // 
            this.btnClienteBuscar.Location = new System.Drawing.Point(159, 88);
            this.btnClienteBuscar.Name = "btnClienteBuscar";
            this.btnClienteBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnClienteBuscar.TabIndex = 5;
            this.btnClienteBuscar.Text = "Consultar";
            this.btnClienteBuscar.UseVisualStyleBackColor = true;
            this.btnClienteBuscar.Click += new System.EventHandler(this.btnClienteBuscar_Click);
            // 
            // pnlCliente
            // 
            this.pnlCliente.Controls.Add(this.lblClienteDataNascimento);
            this.pnlCliente.Controls.Add(this.dtpClienteDataNascimento);
            this.pnlCliente.Controls.Add(this.lblClienteRG);
            this.pnlCliente.Controls.Add(this.lblClienteNome);
            this.pnlCliente.Controls.Add(this.txtClienteRG);
            this.pnlCliente.Controls.Add(this.txtClienteNome);
            this.pnlCliente.Location = new System.Drawing.Point(20, 122);
            this.pnlCliente.Name = "pnlCliente";
            this.pnlCliente.Size = new System.Drawing.Size(484, 114);
            this.pnlCliente.TabIndex = 4;
            // 
            // lblClienteDataNascimento
            // 
            this.lblClienteDataNascimento.AutoSize = true;
            this.lblClienteDataNascimento.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteDataNascimento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblClienteDataNascimento.Location = new System.Drawing.Point(131, 57);
            this.lblClienteDataNascimento.Name = "lblClienteDataNascimento";
            this.lblClienteDataNascimento.Size = new System.Drawing.Size(101, 15);
            this.lblClienteDataNascimento.TabIndex = 8;
            this.lblClienteDataNascimento.Text = "Data de Nascimento:";
            // 
            // dtpClienteDataNascimento
            // 
            this.dtpClienteDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpClienteDataNascimento.Location = new System.Drawing.Point(134, 73);
            this.dtpClienteDataNascimento.MinDate = new System.DateTime(1940, 1, 1, 0, 0, 0, 0);
            this.dtpClienteDataNascimento.Name = "dtpClienteDataNascimento";
            this.dtpClienteDataNascimento.Size = new System.Drawing.Size(200, 20);
            this.dtpClienteDataNascimento.TabIndex = 7;
            // 
            // lblClienteRG
            // 
            this.lblClienteRG.AutoSize = true;
            this.lblClienteRG.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteRG.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblClienteRG.Location = new System.Drawing.Point(12, 57);
            this.lblClienteRG.Name = "lblClienteRG";
            this.lblClienteRG.Size = new System.Drawing.Size(74, 15);
            this.lblClienteRG.TabIndex = 6;
            this.lblClienteRG.Text = "RG do Cliente:";
            // 
            // lblClienteNome
            // 
            this.lblClienteNome.AutoSize = true;
            this.lblClienteNome.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblClienteNome.Location = new System.Drawing.Point(12, 12);
            this.lblClienteNome.Name = "lblClienteNome";
            this.lblClienteNome.Size = new System.Drawing.Size(87, 15);
            this.lblClienteNome.TabIndex = 6;
            this.lblClienteNome.Text = "Nome do Cliente:";
            // 
            // txtClienteRG
            // 
            this.txtClienteRG.Location = new System.Drawing.Point(15, 73);
            this.txtClienteRG.Name = "txtClienteRG";
            this.txtClienteRG.Size = new System.Drawing.Size(100, 20);
            this.txtClienteRG.TabIndex = 5;
            // 
            // txtClienteNome
            // 
            this.txtClienteNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtClienteNome.Location = new System.Drawing.Point(15, 28);
            this.txtClienteNome.Name = "txtClienteNome";
            this.txtClienteNome.Size = new System.Drawing.Size(453, 20);
            this.txtClienteNome.TabIndex = 5;
            // 
            // lblClienteCPF
            // 
            this.lblClienteCPF.AutoSize = true;
            this.lblClienteCPF.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteCPF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblClienteCPF.Location = new System.Drawing.Point(32, 72);
            this.lblClienteCPF.Name = "lblClienteCPF";
            this.lblClienteCPF.Size = new System.Drawing.Size(79, 15);
            this.lblClienteCPF.TabIndex = 3;
            this.lblClienteCPF.Text = "CPF do Cliente:";
            // 
            // txtClienteCPF
            // 
            this.txtClienteCPF.Location = new System.Drawing.Point(35, 88);
            this.txtClienteCPF.Name = "txtClienteCPF";
            this.txtClienteCPF.Size = new System.Drawing.Size(100, 20);
            this.txtClienteCPF.TabIndex = 2;
            this.txtClienteCPF.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtClienteCPF_KeyDown);
            // 
            // lblContaNumero
            // 
            this.lblContaNumero.AutoSize = true;
            this.lblContaNumero.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContaNumero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblContaNumero.Location = new System.Drawing.Point(32, 26);
            this.lblContaNumero.Name = "lblContaNumero";
            this.lblContaNumero.Size = new System.Drawing.Size(91, 15);
            this.lblContaNumero.TabIndex = 1;
            this.lblContaNumero.Text = "Número da Conta:";
            // 
            // txtContaNumero
            // 
            this.txtContaNumero.Enabled = false;
            this.txtContaNumero.Location = new System.Drawing.Point(35, 42);
            this.txtContaNumero.Name = "txtContaNumero";
            this.txtContaNumero.Size = new System.Drawing.Size(100, 20);
            this.txtContaNumero.TabIndex = 0;
            // 
            // tabNovoCliente
            // 
            this.tabNovoCliente.BackColor = System.Drawing.Color.White;
            this.tabNovoCliente.Controls.Add(this.btnGravarCliente);
            this.tabNovoCliente.Controls.Add(this.pnlNovoCliente);
            this.tabNovoCliente.Controls.Add(this.btnCliBuscarCliente);
            this.tabNovoCliente.Controls.Add(this.label1);
            this.tabNovoCliente.Controls.Add(this.txtNovoClienteCPF);
            this.tabNovoCliente.Location = new System.Drawing.Point(4, 25);
            this.tabNovoCliente.Name = "tabNovoCliente";
            this.tabNovoCliente.Padding = new System.Windows.Forms.Padding(3);
            this.tabNovoCliente.Size = new System.Drawing.Size(526, 372);
            this.tabNovoCliente.TabIndex = 1;
            this.tabNovoCliente.Text = "Novo Cliente";
            // 
            // btnGravarCliente
            // 
            this.btnGravarCliente.Location = new System.Drawing.Point(420, 200);
            this.btnGravarCliente.Name = "btnGravarCliente";
            this.btnGravarCliente.Size = new System.Drawing.Size(75, 23);
            this.btnGravarCliente.TabIndex = 19;
            this.btnGravarCliente.Text = "Criar Cliente";
            this.btnGravarCliente.UseVisualStyleBackColor = true;
            this.btnGravarCliente.Click += new System.EventHandler(this.btnGravarCliente_Click);
            // 
            // pnlNovoCliente
            // 
            this.pnlNovoCliente.Controls.Add(this.label5);
            this.pnlNovoCliente.Controls.Add(this.dtpNovoClienteDataNascimento);
            this.pnlNovoCliente.Controls.Add(this.label6);
            this.pnlNovoCliente.Controls.Add(this.label7);
            this.pnlNovoCliente.Controls.Add(this.txtNovoClienteRG);
            this.pnlNovoCliente.Controls.Add(this.txtNovoClienteNome);
            this.pnlNovoCliente.Location = new System.Drawing.Point(11, 62);
            this.pnlNovoCliente.Name = "pnlNovoCliente";
            this.pnlNovoCliente.Size = new System.Drawing.Size(484, 114);
            this.pnlNovoCliente.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(131, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Data de Nascimento:";
            // 
            // dtpNovoClienteDataNascimento
            // 
            this.dtpNovoClienteDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNovoClienteDataNascimento.Location = new System.Drawing.Point(134, 73);
            this.dtpNovoClienteDataNascimento.MinDate = new System.DateTime(1940, 1, 1, 0, 0, 0, 0);
            this.dtpNovoClienteDataNascimento.Name = "dtpNovoClienteDataNascimento";
            this.dtpNovoClienteDataNascimento.Size = new System.Drawing.Size(200, 20);
            this.dtpNovoClienteDataNascimento.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(12, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "RG do Cliente:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(12, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Nome do Cliente:";
            // 
            // txtNovoClienteRG
            // 
            this.txtNovoClienteRG.Location = new System.Drawing.Point(15, 73);
            this.txtNovoClienteRG.Name = "txtNovoClienteRG";
            this.txtNovoClienteRG.Size = new System.Drawing.Size(100, 20);
            this.txtNovoClienteRG.TabIndex = 5;
            // 
            // txtNovoClienteNome
            // 
            this.txtNovoClienteNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNovoClienteNome.Location = new System.Drawing.Point(15, 28);
            this.txtNovoClienteNome.Name = "txtNovoClienteNome";
            this.txtNovoClienteNome.Size = new System.Drawing.Size(453, 20);
            this.txtNovoClienteNome.TabIndex = 5;
            // 
            // btnCliBuscarCliente
            // 
            this.btnCliBuscarCliente.Location = new System.Drawing.Point(145, 34);
            this.btnCliBuscarCliente.Name = "btnCliBuscarCliente";
            this.btnCliBuscarCliente.Size = new System.Drawing.Size(75, 23);
            this.btnCliBuscarCliente.TabIndex = 17;
            this.btnCliBuscarCliente.Text = "Consultar";
            this.btnCliBuscarCliente.UseVisualStyleBackColor = true;
            this.btnCliBuscarCliente.Click += new System.EventHandler(this.btnCliBuscarCliente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(23, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "CPF do Cliente:";
            // 
            // txtNovoClienteCPF
            // 
            this.txtNovoClienteCPF.Location = new System.Drawing.Point(26, 36);
            this.txtNovoClienteCPF.Name = "txtNovoClienteCPF";
            this.txtNovoClienteCPF.Size = new System.Drawing.Size(100, 20);
            this.txtNovoClienteCPF.TabIndex = 9;
            this.txtNovoClienteCPF.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNovoClienteCPF_KeyDown);
            // 
            // tabConsultarConta
            // 
            this.tabConsultarConta.BackColor = System.Drawing.Color.White;
            this.tabConsultarConta.Controls.Add(this.pnlTransferencia);
            this.tabConsultarConta.Controls.Add(this.pnlInstrucao);
            this.tabConsultarConta.Controls.Add(this.pnlSaudacao);
            this.tabConsultarConta.Controls.Add(this.btnConsultarConta);
            this.tabConsultarConta.Controls.Add(this.pnlAcoesConta);
            this.tabConsultarConta.Controls.Add(this.lblNumeroConta);
            this.tabConsultarConta.Controls.Add(this.txtNumeroConta);
            this.tabConsultarConta.Location = new System.Drawing.Point(4, 25);
            this.tabConsultarConta.Name = "tabConsultarConta";
            this.tabConsultarConta.Padding = new System.Windows.Forms.Padding(3);
            this.tabConsultarConta.Size = new System.Drawing.Size(526, 403);
            this.tabConsultarConta.TabIndex = 2;
            this.tabConsultarConta.Text = "Consultar Conta";
            this.tabConsultarConta.Click += new System.EventHandler(this.tabConsultarConta_Click);
            // 
            // pnlTransferencia
            // 
            this.pnlTransferencia.Controls.Add(this.btnTransfConsultaConta);
            this.pnlTransferencia.Controls.Add(this.lblTransfValor);
            this.pnlTransferencia.Controls.Add(this.txtTransfValor);
            this.pnlTransferencia.Controls.Add(this.pnlTransfInfoConta);
            this.pnlTransferencia.Controls.Add(this.lblTransfConta);
            this.pnlTransferencia.Controls.Add(this.txtTransfConta);
            this.pnlTransferencia.Location = new System.Drawing.Point(21, 294);
            this.pnlTransferencia.Name = "pnlTransferencia";
            this.pnlTransferencia.Size = new System.Drawing.Size(484, 85);
            this.pnlTransferencia.TabIndex = 24;
            // 
            // btnTransfConsultaConta
            // 
            this.btnTransfConsultaConta.Location = new System.Drawing.Point(134, 19);
            this.btnTransfConsultaConta.Name = "btnTransfConsultaConta";
            this.btnTransfConsultaConta.Size = new System.Drawing.Size(75, 23);
            this.btnTransfConsultaConta.TabIndex = 27;
            this.btnTransfConsultaConta.Text = "Consultar";
            this.btnTransfConsultaConta.UseVisualStyleBackColor = true;
            this.btnTransfConsultaConta.Click += new System.EventHandler(this.btnTransfConsultaConta_Click);
            // 
            // lblTransfValor
            // 
            this.lblTransfValor.AutoSize = true;
            this.lblTransfValor.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransfValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblTransfValor.Location = new System.Drawing.Point(12, 42);
            this.lblTransfValor.Name = "lblTransfValor";
            this.lblTransfValor.Size = new System.Drawing.Size(112, 15);
            this.lblTransfValor.TabIndex = 27;
            this.lblTransfValor.Text = "Valor da Transferência:";
            // 
            // txtTransfValor
            // 
            this.txtTransfValor.Location = new System.Drawing.Point(15, 58);
            this.txtTransfValor.Name = "txtTransfValor";
            this.txtTransfValor.Size = new System.Drawing.Size(100, 20);
            this.txtTransfValor.TabIndex = 26;
            // 
            // pnlTransfInfoConta
            // 
            this.pnlTransfInfoConta.Controls.Add(this.btnTransferir);
            this.pnlTransfInfoConta.Controls.Add(this.lblTransfTipoConta);
            this.pnlTransfInfoConta.Controls.Add(this.lblTransfTitular);
            this.pnlTransfInfoConta.Location = new System.Drawing.Point(231, 3);
            this.pnlTransfInfoConta.Name = "pnlTransfInfoConta";
            this.pnlTransfInfoConta.Size = new System.Drawing.Size(253, 75);
            this.pnlTransfInfoConta.TabIndex = 24;
            // 
            // btnTransferir
            // 
            this.btnTransferir.Location = new System.Drawing.Point(93, 48);
            this.btnTransferir.Name = "btnTransferir";
            this.btnTransferir.Size = new System.Drawing.Size(75, 23);
            this.btnTransferir.TabIndex = 28;
            this.btnTransferir.Text = "Transferir";
            this.btnTransferir.UseVisualStyleBackColor = true;
            this.btnTransferir.Click += new System.EventHandler(this.btnTransferir_Click);
            // 
            // lblTransfTipoConta
            // 
            this.lblTransfTipoConta.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransfTipoConta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblTransfTipoConta.Location = new System.Drawing.Point(3, 22);
            this.lblTransfTipoConta.Name = "lblTransfTipoConta";
            this.lblTransfTipoConta.Size = new System.Drawing.Size(231, 21);
            this.lblTransfTipoConta.TabIndex = 23;
            this.lblTransfTipoConta.Text = "Tipo da Conta";
            this.lblTransfTipoConta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTransfTitular
            // 
            this.lblTransfTitular.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransfTitular.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblTransfTitular.Location = new System.Drawing.Point(6, 2);
            this.lblTransfTitular.Name = "lblTransfTitular";
            this.lblTransfTitular.Size = new System.Drawing.Size(228, 20);
            this.lblTransfTitular.TabIndex = 21;
            this.lblTransfTitular.Text = "Nome";
            this.lblTransfTitular.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTransfConta
            // 
            this.lblTransfConta.AutoSize = true;
            this.lblTransfConta.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransfConta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblTransfConta.Location = new System.Drawing.Point(12, 3);
            this.lblTransfConta.Name = "lblTransfConta";
            this.lblTransfConta.Size = new System.Drawing.Size(75, 15);
            this.lblTransfConta.TabIndex = 25;
            this.lblTransfConta.Text = "Conta Destino:";
            // 
            // txtTransfConta
            // 
            this.txtTransfConta.Location = new System.Drawing.Point(15, 19);
            this.txtTransfConta.Name = "txtTransfConta";
            this.txtTransfConta.Size = new System.Drawing.Size(100, 20);
            this.txtTransfConta.TabIndex = 24;
            // 
            // pnlInstrucao
            // 
            this.pnlInstrucao.Controls.Add(this.btnInstrucao);
            this.pnlInstrucao.Controls.Add(this.lblInstrucao);
            this.pnlInstrucao.Controls.Add(this.txtInstrucao);
            this.pnlInstrucao.Location = new System.Drawing.Point(21, 240);
            this.pnlInstrucao.Name = "pnlInstrucao";
            this.pnlInstrucao.Size = new System.Drawing.Size(484, 56);
            this.pnlInstrucao.TabIndex = 26;
            // 
            // btnInstrucao
            // 
            this.btnInstrucao.Location = new System.Drawing.Point(134, 26);
            this.btnInstrucao.Name = "btnInstrucao";
            this.btnInstrucao.Size = new System.Drawing.Size(75, 23);
            this.btnInstrucao.TabIndex = 28;
            this.btnInstrucao.Text = "Instrucao";
            this.btnInstrucao.UseVisualStyleBackColor = true;
            this.btnInstrucao.Click += new System.EventHandler(this.btnInstrucao_Click);
            // 
            // lblInstrucao
            // 
            this.lblInstrucao.AutoSize = true;
            this.lblInstrucao.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstrucao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblInstrucao.Location = new System.Drawing.Point(12, 10);
            this.lblInstrucao.Name = "lblInstrucao";
            this.lblInstrucao.Size = new System.Drawing.Size(53, 15);
            this.lblInstrucao.TabIndex = 25;
            this.lblInstrucao.Text = "Instrução:";
            // 
            // txtInstrucao
            // 
            this.txtInstrucao.Location = new System.Drawing.Point(15, 26);
            this.txtInstrucao.Name = "txtInstrucao";
            this.txtInstrucao.Size = new System.Drawing.Size(100, 20);
            this.txtInstrucao.TabIndex = 24;
            // 
            // pnlSaudacao
            // 
            this.pnlSaudacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.pnlSaudacao.Controls.Add(this.lblTipoConta);
            this.pnlSaudacao.Controls.Add(this.lblNomeCliente);
            this.pnlSaudacao.Controls.Add(this.lblIdadeCliente);
            this.pnlSaudacao.Controls.Add(this.lblSaudacao);
            this.pnlSaudacao.Location = new System.Drawing.Point(36, 74);
            this.pnlSaudacao.Name = "pnlSaudacao";
            this.pnlSaudacao.Size = new System.Drawing.Size(450, 44);
            this.pnlSaudacao.TabIndex = 23;
            // 
            // lblTipoConta
            // 
            this.lblTipoConta.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoConta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblTipoConta.Location = new System.Drawing.Point(200, 19);
            this.lblTipoConta.Name = "lblTipoConta";
            this.lblTipoConta.Size = new System.Drawing.Size(247, 21);
            this.lblTipoConta.TabIndex = 23;
            this.lblTipoConta.Text = "Tipo da Conta";
            this.lblTipoConta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblNomeCliente.Location = new System.Drawing.Point(11, 18);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(244, 20);
            this.lblNomeCliente.TabIndex = 21;
            this.lblNomeCliente.Text = "Nome";
            this.lblNomeCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblIdadeCliente
            // 
            this.lblIdadeCliente.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdadeCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblIdadeCliente.Location = new System.Drawing.Point(200, 1);
            this.lblIdadeCliente.Name = "lblIdadeCliente";
            this.lblIdadeCliente.Size = new System.Drawing.Size(247, 21);
            this.lblIdadeCliente.TabIndex = 22;
            this.lblIdadeCliente.Text = "Idade";
            this.lblIdadeCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSaudacao
            // 
            this.lblSaudacao.AutoSize = true;
            this.lblSaudacao.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaudacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblSaudacao.Location = new System.Drawing.Point(12, 4);
            this.lblSaudacao.Name = "lblSaudacao";
            this.lblSaudacao.Size = new System.Drawing.Size(25, 15);
            this.lblSaudacao.TabIndex = 6;
            this.lblSaudacao.Text = "Olá,";
            this.lblSaudacao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnConsultarConta
            // 
            this.btnConsultarConta.Location = new System.Drawing.Point(191, 32);
            this.btnConsultarConta.Name = "btnConsultarConta";
            this.btnConsultarConta.Size = new System.Drawing.Size(75, 23);
            this.btnConsultarConta.TabIndex = 17;
            this.btnConsultarConta.Text = "Consultar";
            this.btnConsultarConta.UseVisualStyleBackColor = true;
            this.btnConsultarConta.Click += new System.EventHandler(this.btnConsultarConta_Click);
            // 
            // pnlAcoesConta
            // 
            this.pnlAcoesConta.Controls.Add(this.btnDeposito);
            this.pnlAcoesConta.Controls.Add(this.btnTransferencia);
            this.pnlAcoesConta.Controls.Add(this.btnSaque);
            this.pnlAcoesConta.Controls.Add(this.lblSaldoDisponivel);
            this.pnlAcoesConta.Controls.Add(this.btnSaldo);
            this.pnlAcoesConta.Location = new System.Drawing.Point(21, 121);
            this.pnlAcoesConta.Name = "pnlAcoesConta";
            this.pnlAcoesConta.Size = new System.Drawing.Size(484, 113);
            this.pnlAcoesConta.TabIndex = 16;
            // 
            // btnDeposito
            // 
            this.btnDeposito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDeposito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeposito.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeposito.ForeColor = System.Drawing.Color.White;
            this.btnDeposito.Location = new System.Drawing.Point(170, 60);
            this.btnDeposito.Name = "btnDeposito";
            this.btnDeposito.Size = new System.Drawing.Size(141, 39);
            this.btnDeposito.TabIndex = 26;
            this.btnDeposito.Text = "Depósito";
            this.btnDeposito.UseVisualStyleBackColor = false;
            this.btnDeposito.Click += new System.EventHandler(this.btnDeposito_Click);
            // 
            // btnTransferencia
            // 
            this.btnTransferencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnTransferencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransferencia.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransferencia.ForeColor = System.Drawing.Color.White;
            this.btnTransferencia.Location = new System.Drawing.Point(324, 60);
            this.btnTransferencia.Name = "btnTransferencia";
            this.btnTransferencia.Size = new System.Drawing.Size(141, 39);
            this.btnTransferencia.TabIndex = 25;
            this.btnTransferencia.Text = "Transferência";
            this.btnTransferencia.UseVisualStyleBackColor = false;
            this.btnTransferencia.Click += new System.EventHandler(this.btnTransferencia_Click);
            // 
            // btnSaque
            // 
            this.btnSaque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSaque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaque.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaque.ForeColor = System.Drawing.Color.White;
            this.btnSaque.Location = new System.Drawing.Point(15, 60);
            this.btnSaque.Name = "btnSaque";
            this.btnSaque.Size = new System.Drawing.Size(141, 39);
            this.btnSaque.TabIndex = 24;
            this.btnSaque.Text = "Saque";
            this.btnSaque.UseVisualStyleBackColor = false;
            this.btnSaque.Click += new System.EventHandler(this.btnSaque_Click);
            // 
            // lblSaldoDisponivel
            // 
            this.lblSaldoDisponivel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblSaldoDisponivel.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoDisponivel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblSaldoDisponivel.Location = new System.Drawing.Point(170, 15);
            this.lblSaldoDisponivel.Name = "lblSaldoDisponivel";
            this.lblSaldoDisponivel.Size = new System.Drawing.Size(141, 39);
            this.lblSaldoDisponivel.TabIndex = 23;
            this.lblSaldoDisponivel.Text = "Saldo";
            this.lblSaldoDisponivel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSaldo
            // 
            this.btnSaldo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSaldo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaldo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaldo.ForeColor = System.Drawing.Color.White;
            this.btnSaldo.Location = new System.Drawing.Point(324, 15);
            this.btnSaldo.Name = "btnSaldo";
            this.btnSaldo.Size = new System.Drawing.Size(141, 39);
            this.btnSaldo.TabIndex = 18;
            this.btnSaldo.Text = "Exibir Saldo";
            this.btnSaldo.UseVisualStyleBackColor = false;
            this.btnSaldo.Click += new System.EventHandler(this.btnSaldo_Click);
            // 
            // lblNumeroConta
            // 
            this.lblNumeroConta.AutoSize = true;
            this.lblNumeroConta.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroConta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblNumeroConta.Location = new System.Drawing.Point(33, 19);
            this.lblNumeroConta.Name = "lblNumeroConta";
            this.lblNumeroConta.Size = new System.Drawing.Size(91, 15);
            this.lblNumeroConta.TabIndex = 13;
            this.lblNumeroConta.Text = "Número da Conta:";
            // 
            // txtNumeroConta
            // 
            this.txtNumeroConta.Location = new System.Drawing.Point(36, 35);
            this.txtNumeroConta.Name = "txtNumeroConta";
            this.txtNumeroConta.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroConta.TabIndex = 12;
            // 
            // tabConsultarCliente
            // 
            this.tabConsultarCliente.BackColor = System.Drawing.Color.White;
            this.tabConsultarCliente.Controls.Add(this.lstContas);
            this.tabConsultarCliente.Controls.Add(this.btnConsultaCPF);
            this.tabConsultarCliente.Controls.Add(this.lblConsultaCPF);
            this.tabConsultarCliente.Controls.Add(this.txtConsultaCPF);
            this.tabConsultarCliente.Location = new System.Drawing.Point(4, 25);
            this.tabConsultarCliente.Name = "tabConsultarCliente";
            this.tabConsultarCliente.Padding = new System.Windows.Forms.Padding(3);
            this.tabConsultarCliente.Size = new System.Drawing.Size(526, 372);
            this.tabConsultarCliente.TabIndex = 3;
            this.tabConsultarCliente.Text = "Consultar Cliente";
            // 
            // lstContas
            // 
            this.lstContas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clnConta,
            this.clnDescricao,
            this.clnSaldo});
            this.lstContas.Location = new System.Drawing.Point(19, 78);
            this.lstContas.MultiSelect = false;
            this.lstContas.Name = "lstContas";
            this.lstContas.Size = new System.Drawing.Size(483, 97);
            this.lstContas.TabIndex = 19;
            this.lstContas.UseCompatibleStateImageBehavior = false;
            this.lstContas.View = System.Windows.Forms.View.Details;
            this.lstContas.DoubleClick += new System.EventHandler(this.lstContas_DoubleClick);
            // 
            // clnConta
            // 
            this.clnConta.Text = "Conta";
            this.clnConta.Width = 50;
            // 
            // clnDescricao
            // 
            this.clnDescricao.Text = "Descrição";
            this.clnDescricao.Width = 150;
            // 
            // clnSaldo
            // 
            this.clnSaldo.Text = "Saldo";
            this.clnSaldo.Width = 100;
            // 
            // btnConsultaCPF
            // 
            this.btnConsultaCPF.Location = new System.Drawing.Point(138, 24);
            this.btnConsultaCPF.Name = "btnConsultaCPF";
            this.btnConsultaCPF.Size = new System.Drawing.Size(75, 23);
            this.btnConsultaCPF.TabIndex = 18;
            this.btnConsultaCPF.Text = "Consultar";
            this.btnConsultaCPF.UseVisualStyleBackColor = true;
            this.btnConsultaCPF.Click += new System.EventHandler(this.btnConsultaCPF_Click);
            // 
            // lblConsultaCPF
            // 
            this.lblConsultaCPF.AutoSize = true;
            this.lblConsultaCPF.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultaCPF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblConsultaCPF.Location = new System.Drawing.Point(16, 11);
            this.lblConsultaCPF.Name = "lblConsultaCPF";
            this.lblConsultaCPF.Size = new System.Drawing.Size(79, 15);
            this.lblConsultaCPF.TabIndex = 12;
            this.lblConsultaCPF.Text = "CPF do Cliente:";
            // 
            // txtConsultaCPF
            // 
            this.txtConsultaCPF.Location = new System.Drawing.Point(19, 27);
            this.txtConsultaCPF.Name = "txtConsultaCPF";
            this.txtConsultaCPF.Size = new System.Drawing.Size(100, 20);
            this.txtConsultaCPF.TabIndex = 11;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(558, 471);
            this.Controls.Add(this.tabMenu);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmMenu";
            this.Text = "Caixa Eletrônico";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMenu_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabMenu.ResumeLayout(false);
            this.tabNovaConta.ResumeLayout(false);
            this.tabNovaConta.PerformLayout();
            this.pnlCliente.ResumeLayout(false);
            this.pnlCliente.PerformLayout();
            this.tabNovoCliente.ResumeLayout(false);
            this.tabNovoCliente.PerformLayout();
            this.pnlNovoCliente.ResumeLayout(false);
            this.pnlNovoCliente.PerformLayout();
            this.tabConsultarConta.ResumeLayout(false);
            this.tabConsultarConta.PerformLayout();
            this.pnlTransferencia.ResumeLayout(false);
            this.pnlTransferencia.PerformLayout();
            this.pnlTransfInfoConta.ResumeLayout(false);
            this.pnlInstrucao.ResumeLayout(false);
            this.pnlInstrucao.PerformLayout();
            this.pnlSaudacao.ResumeLayout(false);
            this.pnlSaudacao.PerformLayout();
            this.pnlAcoesConta.ResumeLayout(false);
            this.tabConsultarCliente.ResumeLayout(false);
            this.tabConsultarCliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem contaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novaContaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contaCorrenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contaPoupançaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contaInvestimentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarClienteToolStripMenuItem;
        private System.Windows.Forms.TabControl tabMenu;
        private System.Windows.Forms.TabPage tabNovaConta;
        private System.Windows.Forms.Label lblContaNumero;
        private System.Windows.Forms.TextBox txtContaNumero;
        private System.Windows.Forms.Label lblClienteCPF;
        private System.Windows.Forms.TextBox txtClienteCPF;
        private System.Windows.Forms.Panel pnlCliente;
        private System.Windows.Forms.Label lblClienteNome;
        private System.Windows.Forms.TextBox txtClienteNome;
        private System.Windows.Forms.Label lblClienteRG;
        private System.Windows.Forms.TextBox txtClienteRG;
        private System.Windows.Forms.Label lblClienteDataNascimento;
        private System.Windows.Forms.DateTimePicker dtpClienteDataNascimento;
        private System.Windows.Forms.Button btnClienteBuscar;
        private System.Windows.Forms.Button btnCriarConta;
        private System.Windows.Forms.Label lblContaSaldo;
        private System.Windows.Forms.MaskedTextBox txtContaSaldo;
        private System.Windows.Forms.TabPage tabNovoCliente;
        private System.Windows.Forms.Panel pnlNovoCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpNovoClienteDataNascimento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNovoClienteRG;
        private System.Windows.Forms.TextBox txtNovoClienteNome;
        private System.Windows.Forms.Button btnCliBuscarCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNovoClienteCPF;
        private System.Windows.Forms.Button btnGravarCliente;
        private System.Windows.Forms.TabPage tabConsultarConta;
        private System.Windows.Forms.ToolStripMenuItem consultarContaToolStripMenuItem;
        private System.Windows.Forms.Button btnSaldo;
        private System.Windows.Forms.Button btnConsultarConta;
        private System.Windows.Forms.Panel pnlAcoesConta;
        private System.Windows.Forms.Label lblSaudacao;
        private System.Windows.Forms.Label lblNumeroConta;
        private System.Windows.Forms.TextBox txtNumeroConta;
        private System.Windows.Forms.Label lblIdadeCliente;
        private System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.Button btnDeposito;
        private System.Windows.Forms.Button btnTransferencia;
        private System.Windows.Forms.Button btnSaque;
        private System.Windows.Forms.Label lblSaldoDisponivel;
        private System.Windows.Forms.Panel pnlSaudacao;
        private System.Windows.Forms.Label lblTipoConta;
        private System.Windows.Forms.Panel pnlTransferencia;
        private System.Windows.Forms.Button btnTransfConsultaConta;
        private System.Windows.Forms.Label lblTransfValor;
        private System.Windows.Forms.TextBox txtTransfValor;
        private System.Windows.Forms.Panel pnlTransfInfoConta;
        private System.Windows.Forms.Label lblTransfTipoConta;
        private System.Windows.Forms.Label lblTransfTitular;
        private System.Windows.Forms.Label lblTransfConta;
        private System.Windows.Forms.TextBox txtTransfConta;
        private System.Windows.Forms.Panel pnlInstrucao;
        private System.Windows.Forms.Label lblInstrucao;
        private System.Windows.Forms.TextBox txtInstrucao;
        private System.Windows.Forms.Button btnInstrucao;
        private System.Windows.Forms.Button btnTransferir;
        private System.Windows.Forms.TabPage tabConsultarCliente;
        private System.Windows.Forms.Button btnConsultaCPF;
        private System.Windows.Forms.Label lblConsultaCPF;
        private System.Windows.Forms.TextBox txtConsultaCPF;
        private System.Windows.Forms.ListView lstContas;
        private System.Windows.Forms.ColumnHeader clnConta;
        private System.Windows.Forms.ColumnHeader clnDescricao;
        private System.Windows.Forms.ColumnHeader clnSaldo;

    }
}

