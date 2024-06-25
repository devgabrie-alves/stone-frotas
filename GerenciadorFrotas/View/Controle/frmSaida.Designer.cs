namespace GerenciadorFrotas.View.Controle
{
    partial class frmSaida
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
            this.grpVeículo = new System.Windows.Forms.GroupBox();
            this.txtQuilometragemAtual = new System.Windows.Forms.TextBox();
            this.lblQuilometragemAtual = new System.Windows.Forms.Label();
            this.cboModelo = new System.Windows.Forms.ComboBox();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.txtQuilometragemInicial = new System.Windows.Forms.TextBox();
            this.lblQuilometragemInicial = new System.Windows.Forms.Label();
            this.txtChassi = new System.Windows.Forms.TextBox();
            this.lblChassi = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.grpStatus = new System.Windows.Forms.GroupBox();
            this.rdbInativo = new System.Windows.Forms.RadioButton();
            this.rdbAtivo = new System.Windows.Forms.RadioButton();
            this.lblModelo = new System.Windows.Forms.Label();
            this.grpVeiculos = new System.Windows.Forms.GroupBox();
            this.grdVeiculos = new System.Windows.Forms.DataGridView();
            this.grpPesquisaVeiculo = new System.Windows.Forms.GroupBox();
            this.cboPesquisa = new System.Windows.Forms.ComboBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.grpColaboradores = new System.Windows.Forms.GroupBox();
            this.grdColaboradores = new System.Windows.Forms.DataGridView();
            this.grpPesquisaColaborador = new System.Windows.Forms.GroupBox();
            this.mskPesquisa = new System.Windows.Forms.MaskedTextBox();
            this.rdbCPF = new System.Windows.Forms.RadioButton();
            this.rdbNome = new System.Windows.Forms.RadioButton();
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.grpColaborador = new System.Windows.Forms.GroupBox();
            this.mskCelular = new System.Windows.Forms.MaskedTextBox();
            this.mskCPF = new System.Windows.Forms.MaskedTextBox();
            this.cboSexo = new System.Windows.Forms.ComboBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblCelular = new System.Windows.Forms.Label();
            this.dtpDataAdmissao = new System.Windows.Forms.DateTimePicker();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblDataAdmissao = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnLiberar = new System.Windows.Forms.Button();
            this.grpVeículo.SuspendLayout();
            this.grpStatus.SuspendLayout();
            this.grpVeiculos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdVeiculos)).BeginInit();
            this.grpPesquisaVeiculo.SuspendLayout();
            this.grpColaboradores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdColaboradores)).BeginInit();
            this.grpPesquisaColaborador.SuspendLayout();
            this.grpColaborador.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpVeículo
            // 
            this.grpVeículo.Controls.Add(this.txtQuilometragemAtual);
            this.grpVeículo.Controls.Add(this.lblQuilometragemAtual);
            this.grpVeículo.Controls.Add(this.cboModelo);
            this.grpVeículo.Controls.Add(this.cboCategoria);
            this.grpVeículo.Controls.Add(this.lblCategoria);
            this.grpVeículo.Controls.Add(this.lblMarca);
            this.grpVeículo.Controls.Add(this.cboMarca);
            this.grpVeículo.Controls.Add(this.txtQuilometragemInicial);
            this.grpVeículo.Controls.Add(this.lblQuilometragemInicial);
            this.grpVeículo.Controls.Add(this.txtChassi);
            this.grpVeículo.Controls.Add(this.lblChassi);
            this.grpVeículo.Controls.Add(this.txtPlaca);
            this.grpVeículo.Controls.Add(this.lblPlaca);
            this.grpVeículo.Controls.Add(this.grpStatus);
            this.grpVeículo.Controls.Add(this.lblModelo);
            this.grpVeículo.Location = new System.Drawing.Point(12, 306);
            this.grpVeículo.Name = "grpVeículo";
            this.grpVeículo.Size = new System.Drawing.Size(581, 131);
            this.grpVeículo.TabIndex = 17;
            this.grpVeículo.TabStop = false;
            this.grpVeículo.Text = "Veículo";
            // 
            // txtQuilometragemAtual
            // 
            this.txtQuilometragemAtual.Location = new System.Drawing.Point(127, 63);
            this.txtQuilometragemAtual.MaxLength = 10;
            this.txtQuilometragemAtual.Name = "txtQuilometragemAtual";
            this.txtQuilometragemAtual.ReadOnly = true;
            this.txtQuilometragemAtual.Size = new System.Drawing.Size(67, 20);
            this.txtQuilometragemAtual.TabIndex = 18;
            // 
            // lblQuilometragemAtual
            // 
            this.lblQuilometragemAtual.AutoSize = true;
            this.lblQuilometragemAtual.Location = new System.Drawing.Point(14, 66);
            this.lblQuilometragemAtual.Name = "lblQuilometragemAtual";
            this.lblQuilometragemAtual.Size = new System.Drawing.Size(104, 13);
            this.lblQuilometragemAtual.TabIndex = 19;
            this.lblQuilometragemAtual.Text = "Quilometragem Atual";
            // 
            // cboModelo
            // 
            this.cboModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboModelo.Enabled = false;
            this.cboModelo.FormattingEnabled = true;
            this.cboModelo.Location = new System.Drawing.Point(325, 97);
            this.cboModelo.Name = "cboModelo";
            this.cboModelo.Size = new System.Drawing.Size(235, 21);
            this.cboModelo.TabIndex = 17;
            // 
            // cboCategoria
            // 
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.Enabled = false;
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(458, 61);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(121, 21);
            this.cboCategoria.TabIndex = 16;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(400, 66);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(52, 13);
            this.lblCategoria.TabIndex = 15;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(209, 66);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 13;
            this.lblMarca.Text = "Marca";
            // 
            // cboMarca
            // 
            this.cboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMarca.Enabled = false;
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(264, 61);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(121, 21);
            this.cboMarca.TabIndex = 12;
            // 
            // txtQuilometragemInicial
            // 
            this.txtQuilometragemInicial.Location = new System.Drawing.Point(127, 98);
            this.txtQuilometragemInicial.MaxLength = 10;
            this.txtQuilometragemInicial.Name = "txtQuilometragemInicial";
            this.txtQuilometragemInicial.ReadOnly = true;
            this.txtQuilometragemInicial.Size = new System.Drawing.Size(67, 20);
            this.txtQuilometragemInicial.TabIndex = 10;
            // 
            // lblQuilometragemInicial
            // 
            this.lblQuilometragemInicial.AutoSize = true;
            this.lblQuilometragemInicial.Location = new System.Drawing.Point(14, 101);
            this.lblQuilometragemInicial.Name = "lblQuilometragemInicial";
            this.lblQuilometragemInicial.Size = new System.Drawing.Size(107, 13);
            this.lblQuilometragemInicial.TabIndex = 11;
            this.lblQuilometragemInicial.Text = "Quilometragem Inicial";
            // 
            // txtChassi
            // 
            this.txtChassi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtChassi.Location = new System.Drawing.Point(265, 28);
            this.txtChassi.MaxLength = 17;
            this.txtChassi.Name = "txtChassi";
            this.txtChassi.ReadOnly = true;
            this.txtChassi.Size = new System.Drawing.Size(120, 20);
            this.txtChassi.TabIndex = 8;
            // 
            // lblChassi
            // 
            this.lblChassi.AutoSize = true;
            this.lblChassi.Location = new System.Drawing.Point(210, 31);
            this.lblChassi.Name = "lblChassi";
            this.lblChassi.Size = new System.Drawing.Size(38, 13);
            this.lblChassi.TabIndex = 9;
            this.lblChassi.Text = "Chassi";
            // 
            // txtPlaca
            // 
            this.txtPlaca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPlaca.Location = new System.Drawing.Point(69, 28);
            this.txtPlaca.MaxLength = 7;
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.ReadOnly = true;
            this.txtPlaca.Size = new System.Drawing.Size(125, 20);
            this.txtPlaca.TabIndex = 6;
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Location = new System.Drawing.Point(14, 31);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(34, 13);
            this.lblPlaca.TabIndex = 7;
            this.lblPlaca.Text = "Placa";
            // 
            // grpStatus
            // 
            this.grpStatus.Controls.Add(this.rdbInativo);
            this.grpStatus.Controls.Add(this.rdbAtivo);
            this.grpStatus.Location = new System.Drawing.Point(426, 10);
            this.grpStatus.Name = "grpStatus";
            this.grpStatus.Size = new System.Drawing.Size(149, 38);
            this.grpStatus.TabIndex = 5;
            this.grpStatus.TabStop = false;
            this.grpStatus.Text = "Status";
            // 
            // rdbInativo
            // 
            this.rdbInativo.AutoSize = true;
            this.rdbInativo.Enabled = false;
            this.rdbInativo.Location = new System.Drawing.Point(73, 19);
            this.rdbInativo.Name = "rdbInativo";
            this.rdbInativo.Size = new System.Drawing.Size(57, 17);
            this.rdbInativo.TabIndex = 1;
            this.rdbInativo.Text = "Inativo";
            this.rdbInativo.UseVisualStyleBackColor = true;
            // 
            // rdbAtivo
            // 
            this.rdbAtivo.AutoSize = true;
            this.rdbAtivo.Enabled = false;
            this.rdbAtivo.Location = new System.Drawing.Point(7, 19);
            this.rdbAtivo.Name = "rdbAtivo";
            this.rdbAtivo.Size = new System.Drawing.Size(49, 17);
            this.rdbAtivo.TabIndex = 0;
            this.rdbAtivo.Text = "Ativo";
            this.rdbAtivo.UseVisualStyleBackColor = true;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(248, 101);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(70, 13);
            this.lblModelo.TabIndex = 2;
            this.lblModelo.Text = "Modelo - Ano";
            // 
            // grpVeiculos
            // 
            this.grpVeiculos.Controls.Add(this.grdVeiculos);
            this.grpVeiculos.Location = new System.Drawing.Point(12, 69);
            this.grpVeiculos.Name = "grpVeiculos";
            this.grpVeiculos.Size = new System.Drawing.Size(581, 231);
            this.grpVeiculos.TabIndex = 16;
            this.grpVeiculos.TabStop = false;
            this.grpVeiculos.Text = "Veículos";
            // 
            // grdVeiculos
            // 
            this.grdVeiculos.AllowUserToAddRows = false;
            this.grdVeiculos.AllowUserToDeleteRows = false;
            this.grdVeiculos.AllowUserToResizeColumns = false;
            this.grdVeiculos.AllowUserToResizeRows = false;
            this.grdVeiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdVeiculos.Location = new System.Drawing.Point(7, 20);
            this.grdVeiculos.MultiSelect = false;
            this.grdVeiculos.Name = "grdVeiculos";
            this.grdVeiculos.ReadOnly = true;
            this.grdVeiculos.RowHeadersVisible = false;
            this.grdVeiculos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdVeiculos.Size = new System.Drawing.Size(568, 205);
            this.grdVeiculos.TabIndex = 0;
            this.grdVeiculos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdVeiculos_CellClick);
            // 
            // grpPesquisaVeiculo
            // 
            this.grpPesquisaVeiculo.Controls.Add(this.cboPesquisa);
            this.grpPesquisaVeiculo.Controls.Add(this.btnPesquisar);
            this.grpPesquisaVeiculo.Controls.Add(this.txtPesquisa);
            this.grpPesquisaVeiculo.Location = new System.Drawing.Point(12, 12);
            this.grpPesquisaVeiculo.Name = "grpPesquisaVeiculo";
            this.grpPesquisaVeiculo.Size = new System.Drawing.Size(581, 51);
            this.grpPesquisaVeiculo.TabIndex = 15;
            this.grpPesquisaVeiculo.TabStop = false;
            this.grpPesquisaVeiculo.Text = "Pesquisa de Veículos";
            // 
            // cboPesquisa
            // 
            this.cboPesquisa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPesquisa.FormattingEnabled = true;
            this.cboPesquisa.Location = new System.Drawing.Point(17, 22);
            this.cboPesquisa.Name = "cboPesquisa";
            this.cboPesquisa.Size = new System.Drawing.Size(94, 21);
            this.cboPesquisa.TabIndex = 2;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(469, 19);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(87, 23);
            this.btnPesquisar.TabIndex = 1;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(117, 22);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(333, 20);
            this.txtPesquisa.TabIndex = 0;
            // 
            // grpColaboradores
            // 
            this.grpColaboradores.Controls.Add(this.grdColaboradores);
            this.grpColaboradores.Location = new System.Drawing.Point(599, 73);
            this.grpColaboradores.Name = "grpColaboradores";
            this.grpColaboradores.Size = new System.Drawing.Size(526, 227);
            this.grpColaboradores.TabIndex = 20;
            this.grpColaboradores.TabStop = false;
            this.grpColaboradores.Text = "Colaboradores";
            // 
            // grdColaboradores
            // 
            this.grdColaboradores.AllowUserToAddRows = false;
            this.grdColaboradores.AllowUserToDeleteRows = false;
            this.grdColaboradores.AllowUserToResizeColumns = false;
            this.grdColaboradores.AllowUserToResizeRows = false;
            this.grdColaboradores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdColaboradores.Location = new System.Drawing.Point(6, 19);
            this.grdColaboradores.MultiSelect = false;
            this.grdColaboradores.Name = "grdColaboradores";
            this.grdColaboradores.ReadOnly = true;
            this.grdColaboradores.RowHeadersVisible = false;
            this.grdColaboradores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdColaboradores.Size = new System.Drawing.Size(514, 202);
            this.grdColaboradores.TabIndex = 10;
            this.grdColaboradores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdColaboradores_CellClick);
            // 
            // grpPesquisaColaborador
            // 
            this.grpPesquisaColaborador.Controls.Add(this.mskPesquisa);
            this.grpPesquisaColaborador.Controls.Add(this.rdbCPF);
            this.grpPesquisaColaborador.Controls.Add(this.rdbNome);
            this.grpPesquisaColaborador.Controls.Add(this.lblPesquisa);
            this.grpPesquisaColaborador.Location = new System.Drawing.Point(599, 12);
            this.grpPesquisaColaborador.Name = "grpPesquisaColaborador";
            this.grpPesquisaColaborador.Size = new System.Drawing.Size(526, 54);
            this.grpPesquisaColaborador.TabIndex = 18;
            this.grpPesquisaColaborador.TabStop = false;
            this.grpPesquisaColaborador.Text = "Pesquisa de Colaboradores";
            // 
            // mskPesquisa
            // 
            this.mskPesquisa.Location = new System.Drawing.Point(68, 19);
            this.mskPesquisa.Name = "mskPesquisa";
            this.mskPesquisa.Size = new System.Drawing.Size(308, 20);
            this.mskPesquisa.TabIndex = 3;
            this.mskPesquisa.TextChanged += new System.EventHandler(this.mskPesquisa_TextChanged);
            // 
            // rdbCPF
            // 
            this.rdbCPF.AutoSize = true;
            this.rdbCPF.Location = new System.Drawing.Point(454, 20);
            this.rdbCPF.Name = "rdbCPF";
            this.rdbCPF.Size = new System.Drawing.Size(45, 17);
            this.rdbCPF.TabIndex = 2;
            this.rdbCPF.Text = "CPF";
            this.rdbCPF.UseVisualStyleBackColor = true;
            this.rdbCPF.CheckedChanged += new System.EventHandler(this.rdbCPF_CheckedChanged);
            // 
            // rdbNome
            // 
            this.rdbNome.AutoSize = true;
            this.rdbNome.Checked = true;
            this.rdbNome.Location = new System.Drawing.Point(395, 20);
            this.rdbNome.Name = "rdbNome";
            this.rdbNome.Size = new System.Drawing.Size(53, 17);
            this.rdbNome.TabIndex = 1;
            this.rdbNome.TabStop = true;
            this.rdbNome.Text = "Nome";
            this.rdbNome.UseVisualStyleBackColor = true;
            this.rdbNome.CheckedChanged += new System.EventHandler(this.rdbNome_CheckedChanged);
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.AutoSize = true;
            this.lblPesquisa.Location = new System.Drawing.Point(9, 22);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(53, 13);
            this.lblPesquisa.TabIndex = 0;
            this.lblPesquisa.Text = "Pesquisar";
            // 
            // grpColaborador
            // 
            this.grpColaborador.Controls.Add(this.mskCelular);
            this.grpColaborador.Controls.Add(this.mskCPF);
            this.grpColaborador.Controls.Add(this.cboSexo);
            this.grpColaborador.Controls.Add(this.lblSexo);
            this.grpColaborador.Controls.Add(this.cboStatus);
            this.grpColaborador.Controls.Add(this.lblStatus);
            this.grpColaborador.Controls.Add(this.lblCelular);
            this.grpColaborador.Controls.Add(this.dtpDataAdmissao);
            this.grpColaborador.Controls.Add(this.txtEmail);
            this.grpColaborador.Controls.Add(this.lblEmail);
            this.grpColaborador.Controls.Add(this.lblCPF);
            this.grpColaborador.Controls.Add(this.lblDataAdmissao);
            this.grpColaborador.Controls.Add(this.txtNome);
            this.grpColaborador.Controls.Add(this.lblNome);
            this.grpColaborador.Location = new System.Drawing.Point(599, 306);
            this.grpColaborador.Name = "grpColaborador";
            this.grpColaborador.Size = new System.Drawing.Size(526, 131);
            this.grpColaborador.TabIndex = 11;
            this.grpColaborador.TabStop = false;
            this.grpColaborador.Text = "Colaborador";
            // 
            // mskCelular
            // 
            this.mskCelular.Location = new System.Drawing.Point(208, 58);
            this.mskCelular.Mask = "(00) 00000-0000";
            this.mskCelular.Name = "mskCelular";
            this.mskCelular.ReadOnly = true;
            this.mskCelular.Size = new System.Drawing.Size(89, 20);
            this.mskCelular.TabIndex = 29;
            // 
            // mskCPF
            // 
            this.mskCPF.Location = new System.Drawing.Point(53, 57);
            this.mskCPF.Mask = "000,000,000-00";
            this.mskCPF.Name = "mskCPF";
            this.mskCPF.ReadOnly = true;
            this.mskCPF.Size = new System.Drawing.Size(90, 20);
            this.mskCPF.TabIndex = 28;
            // 
            // cboSexo
            // 
            this.cboSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSexo.Enabled = false;
            this.cboSexo.FormattingEnabled = true;
            this.cboSexo.Location = new System.Drawing.Point(383, 26);
            this.cboSexo.Name = "cboSexo";
            this.cboSexo.Size = new System.Drawing.Size(121, 21);
            this.cboSexo.TabIndex = 27;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(339, 29);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(31, 13);
            this.lblSexo.TabIndex = 26;
            this.lblSexo.Text = "Sexo";
            // 
            // cboStatus
            // 
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.Enabled = false;
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(386, 61);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(118, 21);
            this.cboStatus.TabIndex = 25;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(339, 64);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 24;
            this.lblStatus.Text = "Status";
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Location = new System.Drawing.Point(162, 61);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(39, 13);
            this.lblCelular.TabIndex = 23;
            this.lblCelular.Text = "Celular";
            // 
            // dtpDataAdmissao
            // 
            this.dtpDataAdmissao.Enabled = false;
            this.dtpDataAdmissao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataAdmissao.Location = new System.Drawing.Point(416, 94);
            this.dtpDataAdmissao.Name = "dtpDataAdmissao";
            this.dtpDataAdmissao.Size = new System.Drawing.Size(88, 20);
            this.dtpDataAdmissao.TabIndex = 1;
            this.dtpDataAdmissao.Value = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(53, 97);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(244, 20);
            this.txtEmail.TabIndex = 3;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(12, 100);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "E-mail";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(12, 61);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(27, 13);
            this.lblCPF.TabIndex = 4;
            this.lblCPF.Text = "CPF";
            // 
            // lblDataAdmissao
            // 
            this.lblDataAdmissao.AutoSize = true;
            this.lblDataAdmissao.Location = new System.Drawing.Point(318, 97);
            this.lblDataAdmissao.Name = "lblDataAdmissao";
            this.lblDataAdmissao.Size = new System.Drawing.Size(93, 13);
            this.lblDataAdmissao.TabIndex = 2;
            this.lblDataAdmissao.Text = "Data de Admissão";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(53, 26);
            this.txtNome.MaxLength = 100;
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(275, 20);
            this.txtNome.TabIndex = 0;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 29);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::GerenciadorFrotas.Properties.Resources.delete;
            this.btnCancelar.Location = new System.Drawing.Point(333, 443);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(143, 47);
            this.btnCancelar.TabIndex = 23;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Image = global::GerenciadorFrotas.Properties.Resources.eraser2;
            this.btnLimpar.Location = new System.Drawing.Point(518, 443);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(143, 47);
            this.btnLimpar.TabIndex = 22;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnLiberar
            // 
            this.btnLiberar.Enabled = false;
            this.btnLiberar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLiberar.Image = global::GerenciadorFrotas.Properties.Resources.check;
            this.btnLiberar.Location = new System.Drawing.Point(716, 443);
            this.btnLiberar.Name = "btnLiberar";
            this.btnLiberar.Size = new System.Drawing.Size(143, 47);
            this.btnLiberar.TabIndex = 21;
            this.btnLiberar.Text = "&Liberar";
            this.btnLiberar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLiberar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLiberar.UseVisualStyleBackColor = true;
            this.btnLiberar.Click += new System.EventHandler(this.btnLiberar_Click);
            // 
            // frmSaida
            // 
            this.AcceptButton = this.btnLiberar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(1143, 501);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnLiberar);
            this.Controls.Add(this.grpColaborador);
            this.Controls.Add(this.grpColaboradores);
            this.Controls.Add(this.grpPesquisaColaborador);
            this.Controls.Add(this.grpVeículo);
            this.Controls.Add(this.grpVeiculos);
            this.Controls.Add(this.grpPesquisaVeiculo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSaida";
            this.ShowIcon = false;
            this.Text = "Controle - Saída";
            this.Load += new System.EventHandler(this.frmSaida_Load);
            this.grpVeículo.ResumeLayout(false);
            this.grpVeículo.PerformLayout();
            this.grpStatus.ResumeLayout(false);
            this.grpStatus.PerformLayout();
            this.grpVeiculos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdVeiculos)).EndInit();
            this.grpPesquisaVeiculo.ResumeLayout(false);
            this.grpPesquisaVeiculo.PerformLayout();
            this.grpColaboradores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdColaboradores)).EndInit();
            this.grpPesquisaColaborador.ResumeLayout(false);
            this.grpPesquisaColaborador.PerformLayout();
            this.grpColaborador.ResumeLayout(false);
            this.grpColaborador.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpVeículo;
        private System.Windows.Forms.ComboBox cboModelo;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.TextBox txtQuilometragemInicial;
        private System.Windows.Forms.Label lblQuilometragemInicial;
        private System.Windows.Forms.TextBox txtChassi;
        private System.Windows.Forms.Label lblChassi;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.GroupBox grpStatus;
        private System.Windows.Forms.RadioButton rdbInativo;
        private System.Windows.Forms.RadioButton rdbAtivo;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.GroupBox grpVeiculos;
        private System.Windows.Forms.DataGridView grdVeiculos;
        private System.Windows.Forms.GroupBox grpPesquisaVeiculo;
        private System.Windows.Forms.ComboBox cboPesquisa;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.GroupBox grpColaboradores;
        private System.Windows.Forms.DataGridView grdColaboradores;
        private System.Windows.Forms.GroupBox grpPesquisaColaborador;
        private System.Windows.Forms.MaskedTextBox mskPesquisa;
        private System.Windows.Forms.RadioButton rdbCPF;
        private System.Windows.Forms.RadioButton rdbNome;
        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.GroupBox grpColaborador;
        private System.Windows.Forms.MaskedTextBox mskCelular;
        private System.Windows.Forms.MaskedTextBox mskCPF;
        private System.Windows.Forms.ComboBox cboSexo;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.DateTimePicker dtpDataAdmissao;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblDataAdmissao;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnLiberar;
        private System.Windows.Forms.TextBox txtQuilometragemAtual;
        private System.Windows.Forms.Label lblQuilometragemAtual;
    }
}