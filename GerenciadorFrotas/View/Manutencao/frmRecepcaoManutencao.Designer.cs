namespace GerenciadorFrotas.View.Manutencao
{
    partial class frmRecepcaoManutencao
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
            this.grpControle = new System.Windows.Forms.GroupBox();
            this.grpOficina = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.mskCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.txtNomeFantasia = new System.Windows.Forms.TextBox();
            this.lblNomeFantasia = new System.Windows.Forms.Label();
            this.lblCNPJ = new System.Windows.Forms.Label();
            this.txtRazaoSocial = new System.Windows.Forms.TextBox();
            this.lblRazaoSocial = new System.Windows.Forms.Label();
            this.grpControleVeiculo = new System.Windows.Forms.GroupBox();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.cboModelo = new System.Windows.Forms.ComboBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.txtChassi = new System.Windows.Forms.TextBox();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.lblChassi = new System.Windows.Forms.Label();
            this.grpDados = new System.Windows.Forms.GroupBox();
            this.grdDados = new System.Windows.Forms.DataGridView();
            this.grpPesquisa = new System.Windows.Forms.GroupBox();
            this.mskPesquisaOficina = new System.Windows.Forms.MaskedTextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.lblOficinaDescricao = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblVeiculoDescricao = new System.Windows.Forms.Label();
            this.cboPesquisaOficina = new System.Windows.Forms.ComboBox();
            this.cboPesquisaVeiculo = new System.Windows.Forms.ComboBox();
            this.txtPesquisaVeiculo = new System.Windows.Forms.TextBox();
            this.btnRecepcionar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grpControle.SuspendLayout();
            this.grpOficina.SuspendLayout();
            this.grpControleVeiculo.SuspendLayout();
            this.grpDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDados)).BeginInit();
            this.grpPesquisa.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpControle
            // 
            this.grpControle.Controls.Add(this.grpOficina);
            this.grpControle.Controls.Add(this.grpControleVeiculo);
            this.grpControle.Location = new System.Drawing.Point(12, 354);
            this.grpControle.Name = "grpControle";
            this.grpControle.Size = new System.Drawing.Size(581, 189);
            this.grpControle.TabIndex = 26;
            this.grpControle.TabStop = false;
            this.grpControle.Text = "Controle";
            // 
            // grpOficina
            // 
            this.grpOficina.Controls.Add(this.txtEmail);
            this.grpOficina.Controls.Add(this.lblEmail);
            this.grpOficina.Controls.Add(this.mskCNPJ);
            this.grpOficina.Controls.Add(this.txtNomeFantasia);
            this.grpOficina.Controls.Add(this.lblNomeFantasia);
            this.grpOficina.Controls.Add(this.lblCNPJ);
            this.grpOficina.Controls.Add(this.txtRazaoSocial);
            this.grpOficina.Controls.Add(this.lblRazaoSocial);
            this.grpOficina.Location = new System.Drawing.Point(7, 109);
            this.grpOficina.Name = "grpOficina";
            this.grpOficina.Size = new System.Drawing.Size(569, 74);
            this.grpOficina.TabIndex = 19;
            this.grpOficina.TabStop = false;
            this.grpOficina.Text = "Oficina";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(265, 48);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(274, 20);
            this.txtEmail.TabIndex = 35;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(224, 51);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 36;
            this.lblEmail.Text = "E-mail";
            // 
            // mskCNPJ
            // 
            this.mskCNPJ.Location = new System.Drawing.Point(96, 45);
            this.mskCNPJ.Mask = "00,000,000/0000-00";
            this.mskCNPJ.Name = "mskCNPJ";
            this.mskCNPJ.ReadOnly = true;
            this.mskCNPJ.Size = new System.Drawing.Size(115, 20);
            this.mskCNPJ.TabIndex = 34;
            // 
            // txtNomeFantasia
            // 
            this.txtNomeFantasia.Location = new System.Drawing.Point(353, 19);
            this.txtNomeFantasia.MaxLength = 50;
            this.txtNomeFantasia.Name = "txtNomeFantasia";
            this.txtNomeFantasia.ReadOnly = true;
            this.txtNomeFantasia.Size = new System.Drawing.Size(186, 20);
            this.txtNomeFantasia.TabIndex = 32;
            // 
            // lblNomeFantasia
            // 
            this.lblNomeFantasia.AutoSize = true;
            this.lblNomeFantasia.Location = new System.Drawing.Point(269, 22);
            this.lblNomeFantasia.Name = "lblNomeFantasia";
            this.lblNomeFantasia.Size = new System.Drawing.Size(78, 13);
            this.lblNomeFantasia.TabIndex = 33;
            this.lblNomeFantasia.Text = "Nome Fantasia";
            // 
            // lblCNPJ
            // 
            this.lblCNPJ.AutoSize = true;
            this.lblCNPJ.Location = new System.Drawing.Point(40, 48);
            this.lblCNPJ.Name = "lblCNPJ";
            this.lblCNPJ.Size = new System.Drawing.Size(34, 13);
            this.lblCNPJ.TabIndex = 31;
            this.lblCNPJ.Text = "CNPJ";
            // 
            // txtRazaoSocial
            // 
            this.txtRazaoSocial.Location = new System.Drawing.Point(96, 19);
            this.txtRazaoSocial.MaxLength = 50;
            this.txtRazaoSocial.Name = "txtRazaoSocial";
            this.txtRazaoSocial.ReadOnly = true;
            this.txtRazaoSocial.Size = new System.Drawing.Size(166, 20);
            this.txtRazaoSocial.TabIndex = 29;
            // 
            // lblRazaoSocial
            // 
            this.lblRazaoSocial.AutoSize = true;
            this.lblRazaoSocial.Location = new System.Drawing.Point(12, 22);
            this.lblRazaoSocial.Name = "lblRazaoSocial";
            this.lblRazaoSocial.Size = new System.Drawing.Size(70, 13);
            this.lblRazaoSocial.TabIndex = 30;
            this.lblRazaoSocial.Text = "Razão Social";
            // 
            // grpControleVeiculo
            // 
            this.grpControleVeiculo.Controls.Add(this.lblPlaca);
            this.grpControleVeiculo.Controls.Add(this.cboModelo);
            this.grpControleVeiculo.Controls.Add(this.lblModelo);
            this.grpControleVeiculo.Controls.Add(this.txtChassi);
            this.grpControleVeiculo.Controls.Add(this.txtPlaca);
            this.grpControleVeiculo.Controls.Add(this.lblChassi);
            this.grpControleVeiculo.Location = new System.Drawing.Point(6, 19);
            this.grpControleVeiculo.Name = "grpControleVeiculo";
            this.grpControleVeiculo.Size = new System.Drawing.Size(569, 84);
            this.grpControleVeiculo.TabIndex = 18;
            this.grpControleVeiculo.TabStop = false;
            this.grpControleVeiculo.Text = "Veículo";
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Location = new System.Drawing.Point(20, 22);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(34, 13);
            this.lblPlaca.TabIndex = 7;
            this.lblPlaca.Text = "Placa";
            // 
            // cboModelo
            // 
            this.cboModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboModelo.Enabled = false;
            this.cboModelo.FormattingEnabled = true;
            this.cboModelo.Location = new System.Drawing.Point(97, 49);
            this.cboModelo.Name = "cboModelo";
            this.cboModelo.Size = new System.Drawing.Size(235, 21);
            this.cboModelo.TabIndex = 17;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(19, 52);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(70, 13);
            this.lblModelo.TabIndex = 2;
            this.lblModelo.Text = "Modelo - Ano";
            // 
            // txtChassi
            // 
            this.txtChassi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtChassi.Location = new System.Drawing.Point(225, 19);
            this.txtChassi.MaxLength = 17;
            this.txtChassi.Name = "txtChassi";
            this.txtChassi.ReadOnly = true;
            this.txtChassi.Size = new System.Drawing.Size(167, 20);
            this.txtChassi.TabIndex = 8;
            // 
            // txtPlaca
            // 
            this.txtPlaca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPlaca.Location = new System.Drawing.Point(75, 19);
            this.txtPlaca.MaxLength = 7;
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.ReadOnly = true;
            this.txtPlaca.Size = new System.Drawing.Size(75, 20);
            this.txtPlaca.TabIndex = 6;
            // 
            // lblChassi
            // 
            this.lblChassi.AutoSize = true;
            this.lblChassi.Location = new System.Drawing.Point(171, 22);
            this.lblChassi.Name = "lblChassi";
            this.lblChassi.Size = new System.Drawing.Size(38, 13);
            this.lblChassi.TabIndex = 9;
            this.lblChassi.Text = "Chassi";
            // 
            // grpDados
            // 
            this.grpDados.Controls.Add(this.grdDados);
            this.grpDados.Location = new System.Drawing.Point(12, 150);
            this.grpDados.Name = "grpDados";
            this.grpDados.Size = new System.Drawing.Size(581, 197);
            this.grpDados.TabIndex = 25;
            this.grpDados.TabStop = false;
            this.grpDados.Text = "Dados";
            // 
            // grdDados
            // 
            this.grdDados.AllowUserToAddRows = false;
            this.grdDados.AllowUserToDeleteRows = false;
            this.grdDados.AllowUserToResizeColumns = false;
            this.grdDados.AllowUserToResizeRows = false;
            this.grdDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDados.Location = new System.Drawing.Point(7, 20);
            this.grdDados.MultiSelect = false;
            this.grdDados.Name = "grdDados";
            this.grdDados.ReadOnly = true;
            this.grdDados.RowHeadersVisible = false;
            this.grdDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDados.Size = new System.Drawing.Size(568, 170);
            this.grdDados.TabIndex = 0;
            this.grdDados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDados_CellClick);
            // 
            // grpPesquisa
            // 
            this.grpPesquisa.Controls.Add(this.mskPesquisaOficina);
            this.grpPesquisa.Controls.Add(this.btnPesquisar);
            this.grpPesquisa.Controls.Add(this.lblOficinaDescricao);
            this.grpPesquisa.Controls.Add(this.btnLimpar);
            this.grpPesquisa.Controls.Add(this.lblVeiculoDescricao);
            this.grpPesquisa.Controls.Add(this.cboPesquisaOficina);
            this.grpPesquisa.Controls.Add(this.cboPesquisaVeiculo);
            this.grpPesquisa.Controls.Add(this.txtPesquisaVeiculo);
            this.grpPesquisa.Location = new System.Drawing.Point(12, 7);
            this.grpPesquisa.Name = "grpPesquisa";
            this.grpPesquisa.Size = new System.Drawing.Size(581, 126);
            this.grpPesquisa.TabIndex = 24;
            this.grpPesquisa.TabStop = false;
            this.grpPesquisa.Text = "Pesquisa";
            // 
            // mskPesquisaOficina
            // 
            this.mskPesquisaOficina.Location = new System.Drawing.Point(118, 50);
            this.mskPesquisaOficina.Name = "mskPesquisaOficina";
            this.mskPesquisaOficina.Size = new System.Drawing.Size(332, 20);
            this.mskPesquisaOficina.TabIndex = 24;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(285, 81);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(101, 39);
            this.btnPesquisar.TabIndex = 23;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // lblOficinaDescricao
            // 
            this.lblOficinaDescricao.AutoSize = true;
            this.lblOficinaDescricao.Location = new System.Drawing.Point(456, 52);
            this.lblOficinaDescricao.Name = "lblOficinaDescricao";
            this.lblOficinaDescricao.Size = new System.Drawing.Size(40, 13);
            this.lblOficinaDescricao.TabIndex = 6;
            this.lblOficinaDescricao.Text = "Oficina";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Image = global::GerenciadorFrotas.Properties.Resources.eraser2;
            this.btnLimpar.Location = new System.Drawing.Point(168, 81);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(99, 39);
            this.btnLimpar.TabIndex = 22;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblVeiculoDescricao
            // 
            this.lblVeiculoDescricao.AutoSize = true;
            this.lblVeiculoDescricao.Location = new System.Drawing.Point(456, 25);
            this.lblVeiculoDescricao.Name = "lblVeiculoDescricao";
            this.lblVeiculoDescricao.Size = new System.Drawing.Size(44, 13);
            this.lblVeiculoDescricao.TabIndex = 5;
            this.lblVeiculoDescricao.Text = "Veículo";
            // 
            // cboPesquisaOficina
            // 
            this.cboPesquisaOficina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPesquisaOficina.FormattingEnabled = true;
            this.cboPesquisaOficina.Location = new System.Drawing.Point(17, 49);
            this.cboPesquisaOficina.Name = "cboPesquisaOficina";
            this.cboPesquisaOficina.Size = new System.Drawing.Size(94, 21);
            this.cboPesquisaOficina.TabIndex = 4;
            // 
            // cboPesquisaVeiculo
            // 
            this.cboPesquisaVeiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPesquisaVeiculo.FormattingEnabled = true;
            this.cboPesquisaVeiculo.Location = new System.Drawing.Point(17, 22);
            this.cboPesquisaVeiculo.Name = "cboPesquisaVeiculo";
            this.cboPesquisaVeiculo.Size = new System.Drawing.Size(94, 21);
            this.cboPesquisaVeiculo.TabIndex = 2;
            // 
            // txtPesquisaVeiculo
            // 
            this.txtPesquisaVeiculo.Location = new System.Drawing.Point(117, 22);
            this.txtPesquisaVeiculo.Name = "txtPesquisaVeiculo";
            this.txtPesquisaVeiculo.Size = new System.Drawing.Size(333, 20);
            this.txtPesquisaVeiculo.TabIndex = 0;
            // 
            // btnRecepcionar
            // 
            this.btnRecepcionar.Enabled = false;
            this.btnRecepcionar.Image = global::GerenciadorFrotas.Properties.Resources.check;
            this.btnRecepcionar.Location = new System.Drawing.Point(444, 549);
            this.btnRecepcionar.Name = "btnRecepcionar";
            this.btnRecepcionar.Size = new System.Drawing.Size(114, 45);
            this.btnRecepcionar.TabIndex = 28;
            this.btnRecepcionar.Text = "Confirmar Recepção";
            this.btnRecepcionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRecepcionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRecepcionar.UseVisualStyleBackColor = true;
            this.btnRecepcionar.Click += new System.EventHandler(this.btnRecepcionar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::GerenciadorFrotas.Properties.Resources.delete;
            this.btnCancelar.Location = new System.Drawing.Point(49, 549);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(106, 45);
            this.btnCancelar.TabIndex = 27;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmRecepcaoManutencao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 603);
            this.Controls.Add(this.btnRecepcionar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.grpControle);
            this.Controls.Add(this.grpDados);
            this.Controls.Add(this.grpPesquisa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRecepcaoManutencao";
            this.ShowIcon = false;
            this.Text = "Manutenção - Recepção";
            this.Load += new System.EventHandler(this.frmRecepcaoManutencao_Load);
            this.grpControle.ResumeLayout(false);
            this.grpOficina.ResumeLayout(false);
            this.grpOficina.PerformLayout();
            this.grpControleVeiculo.ResumeLayout(false);
            this.grpControleVeiculo.PerformLayout();
            this.grpDados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDados)).EndInit();
            this.grpPesquisa.ResumeLayout(false);
            this.grpPesquisa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRecepcionar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox grpControle;
        private System.Windows.Forms.GroupBox grpOficina;
        private System.Windows.Forms.GroupBox grpControleVeiculo;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.ComboBox cboModelo;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.TextBox txtChassi;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Label lblChassi;
        private System.Windows.Forms.GroupBox grpDados;
        private System.Windows.Forms.DataGridView grdDados;
        private System.Windows.Forms.GroupBox grpPesquisa;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label lblOficinaDescricao;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblVeiculoDescricao;
        private System.Windows.Forms.ComboBox cboPesquisaOficina;
        private System.Windows.Forms.ComboBox cboPesquisaVeiculo;
        private System.Windows.Forms.TextBox txtPesquisaVeiculo;
        private System.Windows.Forms.MaskedTextBox mskCNPJ;
        private System.Windows.Forms.TextBox txtNomeFantasia;
        private System.Windows.Forms.Label lblNomeFantasia;
        private System.Windows.Forms.Label lblCNPJ;
        private System.Windows.Forms.TextBox txtRazaoSocial;
        private System.Windows.Forms.Label lblRazaoSocial;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.MaskedTextBox mskPesquisaOficina;
    }
}