namespace GerenciadorFrotas.View.Manutencao
{
    partial class frmEnviarManutencao
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
            this.cboModelo = new System.Windows.Forms.ComboBox();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.txtQuilometragem = new System.Windows.Forms.TextBox();
            this.lblQuilometragem = new System.Windows.Forms.Label();
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
            this.grpPesquisa = new System.Windows.Forms.GroupBox();
            this.cboPesquisa = new System.Windows.Forms.ComboBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.lblStatusVeiculo = new System.Windows.Forms.Label();
            this.rdbPesquisaTodos = new System.Windows.Forms.RadioButton();
            this.rdbPesquisaAtivo = new System.Windows.Forms.RadioButton();
            this.rdbPesquisaInativo = new System.Windows.Forms.RadioButton();
            this.grpOficina = new System.Windows.Forms.GroupBox();
            this.mskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.mskCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.txtSite = new System.Windows.Forms.TextBox();
            this.lblUrlSite = new System.Windows.Forms.Label();
            this.txtNomeFantasia = new System.Windows.Forms.TextBox();
            this.lblNomeFantasia = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCNPJ = new System.Windows.Forms.Label();
            this.txtRazaoSocial = new System.Windows.Forms.TextBox();
            this.lblRazaoSocial = new System.Windows.Forms.Label();
            this.grpDados = new System.Windows.Forms.GroupBox();
            this.grdOficinas = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mskPesquisa = new System.Windows.Forms.MaskedTextBox();
            this.rdbCNPJ = new System.Windows.Forms.RadioButton();
            this.rdbNome = new System.Windows.Forms.RadioButton();
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.grpManutencao = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblOrcamento = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnLiberar = new System.Windows.Forms.Button();
            this.grpVeículo.SuspendLayout();
            this.grpStatus.SuspendLayout();
            this.grpVeiculos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdVeiculos)).BeginInit();
            this.grpPesquisa.SuspendLayout();
            this.grpOficina.SuspendLayout();
            this.grpDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdOficinas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grpManutencao.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpVeículo
            // 
            this.grpVeículo.Controls.Add(this.cboModelo);
            this.grpVeículo.Controls.Add(this.cboCategoria);
            this.grpVeículo.Controls.Add(this.lblCategoria);
            this.grpVeículo.Controls.Add(this.lblMarca);
            this.grpVeículo.Controls.Add(this.cboMarca);
            this.grpVeículo.Controls.Add(this.txtQuilometragem);
            this.grpVeículo.Controls.Add(this.lblQuilometragem);
            this.grpVeículo.Controls.Add(this.txtChassi);
            this.grpVeículo.Controls.Add(this.lblChassi);
            this.grpVeículo.Controls.Add(this.txtPlaca);
            this.grpVeículo.Controls.Add(this.lblPlaca);
            this.grpVeículo.Controls.Add(this.grpStatus);
            this.grpVeículo.Controls.Add(this.lblModelo);
            this.grpVeículo.Location = new System.Drawing.Point(12, 335);
            this.grpVeículo.Name = "grpVeículo";
            this.grpVeículo.Size = new System.Drawing.Size(581, 131);
            this.grpVeículo.TabIndex = 20;
            this.grpVeículo.TabStop = false;
            this.grpVeículo.Text = "Veículo";
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
            this.cboCategoria.Location = new System.Drawing.Point(265, 60);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(121, 21);
            this.cboCategoria.TabIndex = 16;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(207, 65);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(52, 13);
            this.lblCategoria.TabIndex = 15;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(16, 65);
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
            this.cboMarca.Location = new System.Drawing.Point(71, 60);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(121, 21);
            this.cboMarca.TabIndex = 12;
            // 
            // txtQuilometragem
            // 
            this.txtQuilometragem.Location = new System.Drawing.Point(127, 98);
            this.txtQuilometragem.MaxLength = 10;
            this.txtQuilometragem.Name = "txtQuilometragem";
            this.txtQuilometragem.ReadOnly = true;
            this.txtQuilometragem.Size = new System.Drawing.Size(97, 20);
            this.txtQuilometragem.TabIndex = 10;
            // 
            // lblQuilometragem
            // 
            this.lblQuilometragem.AutoSize = true;
            this.lblQuilometragem.Location = new System.Drawing.Point(14, 101);
            this.lblQuilometragem.Name = "lblQuilometragem";
            this.lblQuilometragem.Size = new System.Drawing.Size(107, 13);
            this.lblQuilometragem.TabIndex = 11;
            this.lblQuilometragem.Text = "Quilometragem Inicial";
            // 
            // txtChassi
            // 
            this.txtChassi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtChassi.Location = new System.Drawing.Point(219, 28);
            this.txtChassi.MaxLength = 17;
            this.txtChassi.Name = "txtChassi";
            this.txtChassi.ReadOnly = true;
            this.txtChassi.Size = new System.Drawing.Size(167, 20);
            this.txtChassi.TabIndex = 8;
            // 
            // lblChassi
            // 
            this.lblChassi.AutoSize = true;
            this.lblChassi.Location = new System.Drawing.Point(165, 31);
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
            this.txtPlaca.Size = new System.Drawing.Size(75, 20);
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
            this.grpStatus.Location = new System.Drawing.Point(411, 28);
            this.grpStatus.Name = "grpStatus";
            this.grpStatus.Size = new System.Drawing.Size(149, 50);
            this.grpStatus.TabIndex = 5;
            this.grpStatus.TabStop = false;
            this.grpStatus.Text = "Status";
            // 
            // rdbInativo
            // 
            this.rdbInativo.AutoSize = true;
            this.rdbInativo.Enabled = false;
            this.rdbInativo.Location = new System.Drawing.Point(71, 21);
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
            this.grpVeiculos.Location = new System.Drawing.Point(12, 99);
            this.grpVeiculos.Name = "grpVeiculos";
            this.grpVeiculos.Size = new System.Drawing.Size(581, 237);
            this.grpVeiculos.TabIndex = 19;
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
            this.grdVeiculos.Size = new System.Drawing.Size(568, 210);
            this.grdVeiculos.TabIndex = 0;
            // 
            // grpPesquisa
            // 
            this.grpPesquisa.Controls.Add(this.rdbPesquisaInativo);
            this.grpPesquisa.Controls.Add(this.rdbPesquisaAtivo);
            this.grpPesquisa.Controls.Add(this.rdbPesquisaTodos);
            this.grpPesquisa.Controls.Add(this.lblStatusVeiculo);
            this.grpPesquisa.Controls.Add(this.cboPesquisa);
            this.grpPesquisa.Controls.Add(this.btnPesquisar);
            this.grpPesquisa.Controls.Add(this.txtPesquisa);
            this.grpPesquisa.Location = new System.Drawing.Point(12, 12);
            this.grpPesquisa.Name = "grpPesquisa";
            this.grpPesquisa.Size = new System.Drawing.Size(581, 81);
            this.grpPesquisa.TabIndex = 18;
            this.grpPesquisa.TabStop = false;
            this.grpPesquisa.Text = "Pesquisa";
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
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(117, 22);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(333, 20);
            this.txtPesquisa.TabIndex = 0;
            // 
            // lblStatusVeiculo
            // 
            this.lblStatusVeiculo.AutoSize = true;
            this.lblStatusVeiculo.Location = new System.Drawing.Point(227, 55);
            this.lblStatusVeiculo.Name = "lblStatusVeiculo";
            this.lblStatusVeiculo.Size = new System.Drawing.Size(43, 13);
            this.lblStatusVeiculo.TabIndex = 3;
            this.lblStatusVeiculo.Text = "Status: ";
            // 
            // rdbPesquisaTodos
            // 
            this.rdbPesquisaTodos.AutoSize = true;
            this.rdbPesquisaTodos.Checked = true;
            this.rdbPesquisaTodos.Location = new System.Drawing.Point(276, 53);
            this.rdbPesquisaTodos.Name = "rdbPesquisaTodos";
            this.rdbPesquisaTodos.Size = new System.Drawing.Size(55, 17);
            this.rdbPesquisaTodos.TabIndex = 4;
            this.rdbPesquisaTodos.TabStop = true;
            this.rdbPesquisaTodos.Text = "Todos";
            this.rdbPesquisaTodos.UseVisualStyleBackColor = true;
            // 
            // rdbPesquisaAtivo
            // 
            this.rdbPesquisaAtivo.AutoSize = true;
            this.rdbPesquisaAtivo.Location = new System.Drawing.Point(337, 53);
            this.rdbPesquisaAtivo.Name = "rdbPesquisaAtivo";
            this.rdbPesquisaAtivo.Size = new System.Drawing.Size(49, 17);
            this.rdbPesquisaAtivo.TabIndex = 5;
            this.rdbPesquisaAtivo.Text = "Ativo";
            this.rdbPesquisaAtivo.UseVisualStyleBackColor = true;
            // 
            // rdbPesquisaInativo
            // 
            this.rdbPesquisaInativo.AutoSize = true;
            this.rdbPesquisaInativo.Location = new System.Drawing.Point(392, 53);
            this.rdbPesquisaInativo.Name = "rdbPesquisaInativo";
            this.rdbPesquisaInativo.Size = new System.Drawing.Size(57, 17);
            this.rdbPesquisaInativo.TabIndex = 6;
            this.rdbPesquisaInativo.Text = "Inativo";
            this.rdbPesquisaInativo.UseVisualStyleBackColor = true;
            // 
            // grpOficina
            // 
            this.grpOficina.Controls.Add(this.mskTelefone);
            this.grpOficina.Controls.Add(this.mskCNPJ);
            this.grpOficina.Controls.Add(this.txtSite);
            this.grpOficina.Controls.Add(this.lblUrlSite);
            this.grpOficina.Controls.Add(this.txtNomeFantasia);
            this.grpOficina.Controls.Add(this.lblNomeFantasia);
            this.grpOficina.Controls.Add(this.lblTelefone);
            this.grpOficina.Controls.Add(this.txtEmail);
            this.grpOficina.Controls.Add(this.lblEmail);
            this.grpOficina.Controls.Add(this.lblCNPJ);
            this.grpOficina.Controls.Add(this.txtRazaoSocial);
            this.grpOficina.Controls.Add(this.lblRazaoSocial);
            this.grpOficina.Location = new System.Drawing.Point(599, 335);
            this.grpOficina.Name = "grpOficina";
            this.grpOficina.Size = new System.Drawing.Size(526, 131);
            this.grpOficina.TabIndex = 22;
            this.grpOficina.TabStop = false;
            this.grpOficina.Text = "Dados para Cadastro";
            // 
            // mskTelefone
            // 
            this.mskTelefone.Location = new System.Drawing.Point(428, 62);
            this.mskTelefone.Mask = "(00) 0000-0000";
            this.mskTelefone.Name = "mskTelefone";
            this.mskTelefone.ReadOnly = true;
            this.mskTelefone.Size = new System.Drawing.Size(91, 20);
            this.mskTelefone.TabIndex = 30;
            // 
            // mskCNPJ
            // 
            this.mskCNPJ.Location = new System.Drawing.Point(67, 94);
            this.mskCNPJ.Mask = "00,000,000/0000-00";
            this.mskCNPJ.Name = "mskCNPJ";
            this.mskCNPJ.ReadOnly = true;
            this.mskCNPJ.Size = new System.Drawing.Size(115, 20);
            this.mskCNPJ.TabIndex = 28;
            // 
            // txtSite
            // 
            this.txtSite.Location = new System.Drawing.Point(96, 62);
            this.txtSite.MaxLength = 100;
            this.txtSite.Name = "txtSite";
            this.txtSite.ReadOnly = true;
            this.txtSite.Size = new System.Drawing.Size(251, 20);
            this.txtSite.TabIndex = 26;
            // 
            // lblUrlSite
            // 
            this.lblUrlSite.AutoSize = true;
            this.lblUrlSite.Location = new System.Drawing.Point(15, 65);
            this.lblUrlSite.Name = "lblUrlSite";
            this.lblUrlSite.Size = new System.Drawing.Size(65, 13);
            this.lblUrlSite.TabIndex = 27;
            this.lblUrlSite.Text = "URL do Site";
            // 
            // txtNomeFantasia
            // 
            this.txtNomeFantasia.Location = new System.Drawing.Point(353, 26);
            this.txtNomeFantasia.MaxLength = 50;
            this.txtNomeFantasia.Name = "txtNomeFantasia";
            this.txtNomeFantasia.ReadOnly = true;
            this.txtNomeFantasia.Size = new System.Drawing.Size(166, 20);
            this.txtNomeFantasia.TabIndex = 24;
            // 
            // lblNomeFantasia
            // 
            this.lblNomeFantasia.AutoSize = true;
            this.lblNomeFantasia.Location = new System.Drawing.Point(269, 29);
            this.lblNomeFantasia.Name = "lblNomeFantasia";
            this.lblNomeFantasia.Size = new System.Drawing.Size(78, 13);
            this.lblNomeFantasia.TabIndex = 25;
            this.lblNomeFantasia.Text = "Nome Fantasia";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(373, 65);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(49, 13);
            this.lblTelefone.TabIndex = 23;
            this.lblTelefone.Text = "Telefone";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(245, 94);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(274, 20);
            this.txtEmail.TabIndex = 3;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(204, 97);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "E-mail";
            // 
            // lblCNPJ
            // 
            this.lblCNPJ.AutoSize = true;
            this.lblCNPJ.Location = new System.Drawing.Point(11, 97);
            this.lblCNPJ.Name = "lblCNPJ";
            this.lblCNPJ.Size = new System.Drawing.Size(34, 13);
            this.lblCNPJ.TabIndex = 4;
            this.lblCNPJ.Text = "CNPJ";
            // 
            // txtRazaoSocial
            // 
            this.txtRazaoSocial.Location = new System.Drawing.Point(96, 26);
            this.txtRazaoSocial.MaxLength = 50;
            this.txtRazaoSocial.Name = "txtRazaoSocial";
            this.txtRazaoSocial.ReadOnly = true;
            this.txtRazaoSocial.Size = new System.Drawing.Size(166, 20);
            this.txtRazaoSocial.TabIndex = 0;
            // 
            // lblRazaoSocial
            // 
            this.lblRazaoSocial.AutoSize = true;
            this.lblRazaoSocial.Location = new System.Drawing.Point(12, 29);
            this.lblRazaoSocial.Name = "lblRazaoSocial";
            this.lblRazaoSocial.Size = new System.Drawing.Size(70, 13);
            this.lblRazaoSocial.TabIndex = 0;
            this.lblRazaoSocial.Text = "Razão Social";
            // 
            // grpDados
            // 
            this.grpDados.Controls.Add(this.grdOficinas);
            this.grpDados.Location = new System.Drawing.Point(599, 99);
            this.grpDados.Name = "grpDados";
            this.grpDados.Size = new System.Drawing.Size(526, 236);
            this.grpDados.TabIndex = 23;
            this.grpDados.TabStop = false;
            this.grpDados.Text = "Oficinas";
            // 
            // grdOficinas
            // 
            this.grdOficinas.AllowUserToAddRows = false;
            this.grdOficinas.AllowUserToDeleteRows = false;
            this.grdOficinas.AllowUserToResizeColumns = false;
            this.grdOficinas.AllowUserToResizeRows = false;
            this.grdOficinas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdOficinas.Location = new System.Drawing.Point(6, 20);
            this.grdOficinas.MultiSelect = false;
            this.grdOficinas.Name = "grdOficinas";
            this.grdOficinas.ReadOnly = true;
            this.grdOficinas.RowHeadersVisible = false;
            this.grdOficinas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdOficinas.Size = new System.Drawing.Size(514, 210);
            this.grdOficinas.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mskPesquisa);
            this.groupBox1.Controls.Add(this.rdbCNPJ);
            this.groupBox1.Controls.Add(this.rdbNome);
            this.groupBox1.Controls.Add(this.lblPesquisa);
            this.groupBox1.Location = new System.Drawing.Point(599, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(526, 81);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados para Pesquisa";
            // 
            // mskPesquisa
            // 
            this.mskPesquisa.Location = new System.Drawing.Point(83, 34);
            this.mskPesquisa.Name = "mskPesquisa";
            this.mskPesquisa.Size = new System.Drawing.Size(306, 20);
            this.mskPesquisa.TabIndex = 3;
            // 
            // rdbCNPJ
            // 
            this.rdbCNPJ.AutoSize = true;
            this.rdbCNPJ.Location = new System.Drawing.Point(410, 46);
            this.rdbCNPJ.Name = "rdbCNPJ";
            this.rdbCNPJ.Size = new System.Drawing.Size(52, 17);
            this.rdbCNPJ.TabIndex = 2;
            this.rdbCNPJ.Text = "CNPJ";
            this.rdbCNPJ.UseVisualStyleBackColor = true;
            // 
            // rdbNome
            // 
            this.rdbNome.AutoSize = true;
            this.rdbNome.Checked = true;
            this.rdbNome.Location = new System.Drawing.Point(410, 30);
            this.rdbNome.Name = "rdbNome";
            this.rdbNome.Size = new System.Drawing.Size(96, 17);
            this.rdbNome.TabIndex = 1;
            this.rdbNome.TabStop = true;
            this.rdbNome.Text = "Nome Fantasia";
            this.rdbNome.UseVisualStyleBackColor = true;
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.AutoSize = true;
            this.lblPesquisa.Location = new System.Drawing.Point(24, 37);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(53, 13);
            this.lblPesquisa.TabIndex = 0;
            this.lblPesquisa.Text = "Pesquisar";
            // 
            // grpManutencao
            // 
            this.grpManutencao.Controls.Add(this.textBox2);
            this.grpManutencao.Controls.Add(this.lblOrcamento);
            this.grpManutencao.Controls.Add(this.textBox1);
            this.grpManutencao.Controls.Add(this.lblDescricao);
            this.grpManutencao.Location = new System.Drawing.Point(54, 490);
            this.grpManutencao.Name = "grpManutencao";
            this.grpManutencao.Size = new System.Drawing.Size(497, 139);
            this.grpManutencao.TabIndex = 24;
            this.grpManutencao.TabStop = false;
            this.grpManutencao.Text = "Manutenção";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(199, 104);
            this.textBox2.MaxLength = 255;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(162, 20);
            this.textBox2.TabIndex = 3;
            // 
            // lblOrcamento
            // 
            this.lblOrcamento.AutoSize = true;
            this.lblOrcamento.Location = new System.Drawing.Point(138, 107);
            this.lblOrcamento.Name = "lblOrcamento";
            this.lblOrcamento.Size = new System.Drawing.Size(59, 13);
            this.lblOrcamento.TabIndex = 2;
            this.lblOrcamento.Text = "Orçamento";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(77, 26);
            this.textBox1.MaxLength = 255;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(401, 72);
            this.textBox1.TabIndex = 1;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(16, 29);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(55, 13);
            this.lblDescricao.TabIndex = 0;
            this.lblDescricao.Text = "Descrição";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::GerenciadorFrotas.Properties.Resources.delete;
            this.btnCancelar.Location = new System.Drawing.Point(682, 503);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(125, 111);
            this.btnCancelar.TabIndex = 27;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Image = global::GerenciadorFrotas.Properties.Resources.eraser2;
            this.btnLimpar.Location = new System.Drawing.Point(815, 503);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(125, 111);
            this.btnLimpar.TabIndex = 26;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnLiberar
            // 
            this.btnLiberar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLiberar.Image = global::GerenciadorFrotas.Properties.Resources.check;
            this.btnLiberar.Location = new System.Drawing.Point(952, 503);
            this.btnLiberar.Name = "btnLiberar";
            this.btnLiberar.Size = new System.Drawing.Size(125, 111);
            this.btnLiberar.TabIndex = 25;
            this.btnLiberar.Text = "&Liberar";
            this.btnLiberar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLiberar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLiberar.UseVisualStyleBackColor = true;
            // 
            // frmEnviarManutencao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 669);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnLiberar);
            this.Controls.Add(this.grpManutencao);
            this.Controls.Add(this.grpOficina);
            this.Controls.Add(this.grpDados);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpVeículo);
            this.Controls.Add(this.grpVeiculos);
            this.Controls.Add(this.grpPesquisa);
            this.Name = "frmEnviarManutencao";
            this.Text = "frmEnviarManutencao";
            this.grpVeículo.ResumeLayout(false);
            this.grpVeículo.PerformLayout();
            this.grpStatus.ResumeLayout(false);
            this.grpStatus.PerformLayout();
            this.grpVeiculos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdVeiculos)).EndInit();
            this.grpPesquisa.ResumeLayout(false);
            this.grpPesquisa.PerformLayout();
            this.grpOficina.ResumeLayout(false);
            this.grpOficina.PerformLayout();
            this.grpDados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdOficinas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpManutencao.ResumeLayout(false);
            this.grpManutencao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpVeículo;
        private System.Windows.Forms.ComboBox cboModelo;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.TextBox txtQuilometragem;
        private System.Windows.Forms.Label lblQuilometragem;
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
        private System.Windows.Forms.GroupBox grpPesquisa;
        private System.Windows.Forms.RadioButton rdbPesquisaAtivo;
        private System.Windows.Forms.RadioButton rdbPesquisaTodos;
        private System.Windows.Forms.Label lblStatusVeiculo;
        private System.Windows.Forms.ComboBox cboPesquisa;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.RadioButton rdbPesquisaInativo;
        private System.Windows.Forms.GroupBox grpOficina;
        private System.Windows.Forms.MaskedTextBox mskTelefone;
        private System.Windows.Forms.MaskedTextBox mskCNPJ;
        private System.Windows.Forms.TextBox txtSite;
        private System.Windows.Forms.Label lblUrlSite;
        private System.Windows.Forms.TextBox txtNomeFantasia;
        private System.Windows.Forms.Label lblNomeFantasia;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCNPJ;
        private System.Windows.Forms.TextBox txtRazaoSocial;
        private System.Windows.Forms.Label lblRazaoSocial;
        private System.Windows.Forms.GroupBox grpDados;
        private System.Windows.Forms.DataGridView grdOficinas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox mskPesquisa;
        private System.Windows.Forms.RadioButton rdbCNPJ;
        private System.Windows.Forms.RadioButton rdbNome;
        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.GroupBox grpManutencao;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblOrcamento;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnLiberar;
    }
}