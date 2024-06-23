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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEnviarManutencao));
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
            this.grpPesquisa = new System.Windows.Forms.GroupBox();
            this.cboPesquisa = new System.Windows.Forms.ComboBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
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
            this.txtOrcamento = new System.Windows.Forms.TextBox();
            this.lblOrcamento = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
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
            resources.ApplyResources(this.grpVeículo, "grpVeículo");
            this.grpVeículo.Name = "grpVeículo";
            this.grpVeículo.TabStop = false;
            // 
            // txtQuilometragemAtual
            // 
            resources.ApplyResources(this.txtQuilometragemAtual, "txtQuilometragemAtual");
            this.txtQuilometragemAtual.Name = "txtQuilometragemAtual";
            this.txtQuilometragemAtual.ReadOnly = true;
            // 
            // lblQuilometragemAtual
            // 
            resources.ApplyResources(this.lblQuilometragemAtual, "lblQuilometragemAtual");
            this.lblQuilometragemAtual.Name = "lblQuilometragemAtual";
            // 
            // cboModelo
            // 
            this.cboModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cboModelo, "cboModelo");
            this.cboModelo.FormattingEnabled = true;
            this.cboModelo.Name = "cboModelo";
            // 
            // cboCategoria
            // 
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cboCategoria, "cboCategoria");
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Name = "cboCategoria";
            // 
            // lblCategoria
            // 
            resources.ApplyResources(this.lblCategoria, "lblCategoria");
            this.lblCategoria.Name = "lblCategoria";
            // 
            // lblMarca
            // 
            resources.ApplyResources(this.lblMarca, "lblMarca");
            this.lblMarca.Name = "lblMarca";
            // 
            // cboMarca
            // 
            this.cboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cboMarca, "cboMarca");
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Name = "cboMarca";
            // 
            // txtQuilometragemInicial
            // 
            resources.ApplyResources(this.txtQuilometragemInicial, "txtQuilometragemInicial");
            this.txtQuilometragemInicial.Name = "txtQuilometragemInicial";
            this.txtQuilometragemInicial.ReadOnly = true;
            // 
            // lblQuilometragemInicial
            // 
            resources.ApplyResources(this.lblQuilometragemInicial, "lblQuilometragemInicial");
            this.lblQuilometragemInicial.Name = "lblQuilometragemInicial";
            // 
            // txtChassi
            // 
            this.txtChassi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            resources.ApplyResources(this.txtChassi, "txtChassi");
            this.txtChassi.Name = "txtChassi";
            this.txtChassi.ReadOnly = true;
            // 
            // lblChassi
            // 
            resources.ApplyResources(this.lblChassi, "lblChassi");
            this.lblChassi.Name = "lblChassi";
            // 
            // txtPlaca
            // 
            this.txtPlaca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            resources.ApplyResources(this.txtPlaca, "txtPlaca");
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.ReadOnly = true;
            // 
            // lblPlaca
            // 
            resources.ApplyResources(this.lblPlaca, "lblPlaca");
            this.lblPlaca.Name = "lblPlaca";
            // 
            // grpStatus
            // 
            this.grpStatus.Controls.Add(this.rdbInativo);
            this.grpStatus.Controls.Add(this.rdbAtivo);
            resources.ApplyResources(this.grpStatus, "grpStatus");
            this.grpStatus.Name = "grpStatus";
            this.grpStatus.TabStop = false;
            // 
            // rdbInativo
            // 
            resources.ApplyResources(this.rdbInativo, "rdbInativo");
            this.rdbInativo.Name = "rdbInativo";
            this.rdbInativo.UseVisualStyleBackColor = true;
            // 
            // rdbAtivo
            // 
            resources.ApplyResources(this.rdbAtivo, "rdbAtivo");
            this.rdbAtivo.Name = "rdbAtivo";
            this.rdbAtivo.UseVisualStyleBackColor = true;
            // 
            // lblModelo
            // 
            resources.ApplyResources(this.lblModelo, "lblModelo");
            this.lblModelo.Name = "lblModelo";
            // 
            // grpVeiculos
            // 
            this.grpVeiculos.Controls.Add(this.grdVeiculos);
            resources.ApplyResources(this.grpVeiculos, "grpVeiculos");
            this.grpVeiculos.Name = "grpVeiculos";
            this.grpVeiculos.TabStop = false;
            // 
            // grdVeiculos
            // 
            this.grdVeiculos.AllowUserToAddRows = false;
            this.grdVeiculos.AllowUserToDeleteRows = false;
            this.grdVeiculos.AllowUserToResizeColumns = false;
            this.grdVeiculos.AllowUserToResizeRows = false;
            this.grdVeiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.grdVeiculos, "grdVeiculos");
            this.grdVeiculos.MultiSelect = false;
            this.grdVeiculos.Name = "grdVeiculos";
            this.grdVeiculos.ReadOnly = true;
            this.grdVeiculos.RowHeadersVisible = false;
            this.grdVeiculos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdVeiculos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdVeiculos_CellClick);
            // 
            // grpPesquisa
            // 
            this.grpPesquisa.Controls.Add(this.cboPesquisa);
            this.grpPesquisa.Controls.Add(this.btnPesquisar);
            this.grpPesquisa.Controls.Add(this.txtPesquisa);
            resources.ApplyResources(this.grpPesquisa, "grpPesquisa");
            this.grpPesquisa.Name = "grpPesquisa";
            this.grpPesquisa.TabStop = false;
            // 
            // cboPesquisa
            // 
            this.cboPesquisa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPesquisa.FormattingEnabled = true;
            resources.ApplyResources(this.cboPesquisa, "cboPesquisa");
            this.cboPesquisa.Name = "cboPesquisa";
            // 
            // btnPesquisar
            // 
            resources.ApplyResources(this.btnPesquisar, "btnPesquisar");
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtPesquisa
            // 
            resources.ApplyResources(this.txtPesquisa, "txtPesquisa");
            this.txtPesquisa.Name = "txtPesquisa";
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
            resources.ApplyResources(this.grpOficina, "grpOficina");
            this.grpOficina.Name = "grpOficina";
            this.grpOficina.TabStop = false;
            // 
            // mskTelefone
            // 
            resources.ApplyResources(this.mskTelefone, "mskTelefone");
            this.mskTelefone.Name = "mskTelefone";
            this.mskTelefone.ReadOnly = true;
            // 
            // mskCNPJ
            // 
            resources.ApplyResources(this.mskCNPJ, "mskCNPJ");
            this.mskCNPJ.Name = "mskCNPJ";
            this.mskCNPJ.ReadOnly = true;
            // 
            // txtSite
            // 
            resources.ApplyResources(this.txtSite, "txtSite");
            this.txtSite.Name = "txtSite";
            this.txtSite.ReadOnly = true;
            // 
            // lblUrlSite
            // 
            resources.ApplyResources(this.lblUrlSite, "lblUrlSite");
            this.lblUrlSite.Name = "lblUrlSite";
            // 
            // txtNomeFantasia
            // 
            resources.ApplyResources(this.txtNomeFantasia, "txtNomeFantasia");
            this.txtNomeFantasia.Name = "txtNomeFantasia";
            this.txtNomeFantasia.ReadOnly = true;
            // 
            // lblNomeFantasia
            // 
            resources.ApplyResources(this.lblNomeFantasia, "lblNomeFantasia");
            this.lblNomeFantasia.Name = "lblNomeFantasia";
            // 
            // lblTelefone
            // 
            resources.ApplyResources(this.lblTelefone, "lblTelefone");
            this.lblTelefone.Name = "lblTelefone";
            // 
            // txtEmail
            // 
            resources.ApplyResources(this.txtEmail, "txtEmail");
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            // 
            // lblEmail
            // 
            resources.ApplyResources(this.lblEmail, "lblEmail");
            this.lblEmail.Name = "lblEmail";
            // 
            // lblCNPJ
            // 
            resources.ApplyResources(this.lblCNPJ, "lblCNPJ");
            this.lblCNPJ.Name = "lblCNPJ";
            // 
            // txtRazaoSocial
            // 
            resources.ApplyResources(this.txtRazaoSocial, "txtRazaoSocial");
            this.txtRazaoSocial.Name = "txtRazaoSocial";
            this.txtRazaoSocial.ReadOnly = true;
            // 
            // lblRazaoSocial
            // 
            resources.ApplyResources(this.lblRazaoSocial, "lblRazaoSocial");
            this.lblRazaoSocial.Name = "lblRazaoSocial";
            // 
            // grpDados
            // 
            this.grpDados.Controls.Add(this.grdOficinas);
            resources.ApplyResources(this.grpDados, "grpDados");
            this.grpDados.Name = "grpDados";
            this.grpDados.TabStop = false;
            // 
            // grdOficinas
            // 
            this.grdOficinas.AllowUserToAddRows = false;
            this.grdOficinas.AllowUserToDeleteRows = false;
            this.grdOficinas.AllowUserToResizeColumns = false;
            this.grdOficinas.AllowUserToResizeRows = false;
            this.grdOficinas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.grdOficinas, "grdOficinas");
            this.grdOficinas.MultiSelect = false;
            this.grdOficinas.Name = "grdOficinas";
            this.grdOficinas.ReadOnly = true;
            this.grdOficinas.RowHeadersVisible = false;
            this.grdOficinas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdOficinas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdOficinas_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mskPesquisa);
            this.groupBox1.Controls.Add(this.rdbCNPJ);
            this.groupBox1.Controls.Add(this.rdbNome);
            this.groupBox1.Controls.Add(this.lblPesquisa);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // mskPesquisa
            // 
            resources.ApplyResources(this.mskPesquisa, "mskPesquisa");
            this.mskPesquisa.Name = "mskPesquisa";
            this.mskPesquisa.TextChanged += new System.EventHandler(this.mskPesquisa_TextChanged);
            // 
            // rdbCNPJ
            // 
            resources.ApplyResources(this.rdbCNPJ, "rdbCNPJ");
            this.rdbCNPJ.Name = "rdbCNPJ";
            this.rdbCNPJ.UseVisualStyleBackColor = true;
            this.rdbCNPJ.CheckedChanged += new System.EventHandler(this.rdbCNPJ_CheckedChanged);
            // 
            // rdbNome
            // 
            resources.ApplyResources(this.rdbNome, "rdbNome");
            this.rdbNome.Checked = true;
            this.rdbNome.Name = "rdbNome";
            this.rdbNome.TabStop = true;
            this.rdbNome.UseVisualStyleBackColor = true;
            this.rdbNome.CheckedChanged += new System.EventHandler(this.rdbNome_CheckedChanged);
            // 
            // lblPesquisa
            // 
            resources.ApplyResources(this.lblPesquisa, "lblPesquisa");
            this.lblPesquisa.Name = "lblPesquisa";
            // 
            // grpManutencao
            // 
            this.grpManutencao.Controls.Add(this.txtOrcamento);
            this.grpManutencao.Controls.Add(this.lblOrcamento);
            this.grpManutencao.Controls.Add(this.txtDescricao);
            this.grpManutencao.Controls.Add(this.lblDescricao);
            resources.ApplyResources(this.grpManutencao, "grpManutencao");
            this.grpManutencao.Name = "grpManutencao";
            this.grpManutencao.TabStop = false;
            // 
            // txtOrcamento
            // 
            resources.ApplyResources(this.txtOrcamento, "txtOrcamento");
            this.txtOrcamento.Name = "txtOrcamento";
            this.txtOrcamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOrcamento_KeyPress);
            // 
            // lblOrcamento
            // 
            resources.ApplyResources(this.lblOrcamento, "lblOrcamento");
            this.lblOrcamento.Name = "lblOrcamento";
            // 
            // txtDescricao
            // 
            resources.ApplyResources(this.txtDescricao, "txtDescricao");
            this.txtDescricao.Name = "txtDescricao";
            // 
            // lblDescricao
            // 
            resources.ApplyResources(this.lblDescricao, "lblDescricao");
            this.lblDescricao.Name = "lblDescricao";
            // 
            // btnCancelar
            // 
            resources.ApplyResources(this.btnCancelar, "btnCancelar");
            this.btnCancelar.Image = global::GerenciadorFrotas.Properties.Resources.delete;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnLimpar
            // 
            resources.ApplyResources(this.btnLimpar, "btnLimpar");
            this.btnLimpar.Image = global::GerenciadorFrotas.Properties.Resources.eraser2;
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnLiberar
            // 
            resources.ApplyResources(this.btnLiberar, "btnLiberar");
            this.btnLiberar.Image = global::GerenciadorFrotas.Properties.Resources.check;
            this.btnLiberar.Name = "btnLiberar";
            this.btnLiberar.UseVisualStyleBackColor = true;
            this.btnLiberar.Click += new System.EventHandler(this.btnLiberar_Click);
            // 
            // frmEnviarManutencao
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEnviarManutencao";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.frmEnviarManutencao_Load);
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
        private System.Windows.Forms.GroupBox grpVeiculos;
        private System.Windows.Forms.DataGridView grdVeiculos;
        private System.Windows.Forms.GroupBox grpPesquisa;
        private System.Windows.Forms.ComboBox cboPesquisa;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisa;
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
        private System.Windows.Forms.TextBox txtOrcamento;
        private System.Windows.Forms.Label lblOrcamento;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnLiberar;
        private System.Windows.Forms.TextBox txtQuilometragemAtual;
        private System.Windows.Forms.Label lblQuilometragemAtual;
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
    }
}