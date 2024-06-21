﻿namespace GerenciadorFrotas.View.Controle
{
    partial class frmEntrada
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
            this.btnRecepcionar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grpControle = new System.Windows.Forms.GroupBox();
            this.cboModelo = new System.Windows.Forms.ComboBox();
            this.txtChassi = new System.Windows.Forms.TextBox();
            this.lblChassi = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.grpDados = new System.Windows.Forms.GroupBox();
            this.grdDados = new System.Windows.Forms.DataGridView();
            this.grpPesquisa = new System.Windows.Forms.GroupBox();
            this.cboPesquisaVeiculo = new System.Windows.Forms.ComboBox();
            this.txtPesquisaVeiculo = new System.Windows.Forms.TextBox();
            this.cboPesquisaColaborador = new System.Windows.Forms.ComboBox();
            this.txtPesquisaColaborador = new System.Windows.Forms.TextBox();
            this.lblVeiculoDescricao = new System.Windows.Forms.Label();
            this.lblColaboradorDescricao = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.grpControleVeiculo = new System.Windows.Forms.GroupBox();
            this.grpColaborador = new System.Windows.Forms.GroupBox();
            this.mskCelular = new System.Windows.Forms.MaskedTextBox();
            this.mskCPF = new System.Windows.Forms.MaskedTextBox();
            this.lblCelular = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.grpControle.SuspendLayout();
            this.grpDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDados)).BeginInit();
            this.grpPesquisa.SuspendLayout();
            this.grpControleVeiculo.SuspendLayout();
            this.grpColaborador.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRecepcionar
            // 
            this.btnRecepcionar.Image = global::GerenciadorFrotas.Properties.Resources.check;
            this.btnRecepcionar.Location = new System.Drawing.Point(442, 564);
            this.btnRecepcionar.Name = "btnRecepcionar";
            this.btnRecepcionar.Size = new System.Drawing.Size(114, 45);
            this.btnRecepcionar.TabIndex = 23;
            this.btnRecepcionar.Text = "Confirmar Recepção";
            this.btnRecepcionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRecepcionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRecepcionar.UseVisualStyleBackColor = true;
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
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::GerenciadorFrotas.Properties.Resources.delete;
            this.btnCancelar.Location = new System.Drawing.Point(47, 564);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(106, 45);
            this.btnCancelar.TabIndex = 21;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // grpControle
            // 
            this.grpControle.Controls.Add(this.grpColaborador);
            this.grpControle.Controls.Add(this.grpControleVeiculo);
            this.grpControle.Location = new System.Drawing.Point(12, 359);
            this.grpControle.Name = "grpControle";
            this.grpControle.Size = new System.Drawing.Size(581, 199);
            this.grpControle.TabIndex = 20;
            this.grpControle.TabStop = false;
            this.grpControle.Text = "Controle";
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
            // lblChassi
            // 
            this.lblChassi.AutoSize = true;
            this.lblChassi.Location = new System.Drawing.Point(171, 22);
            this.lblChassi.Name = "lblChassi";
            this.lblChassi.Size = new System.Drawing.Size(38, 13);
            this.lblChassi.TabIndex = 9;
            this.lblChassi.Text = "Chassi";
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
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Location = new System.Drawing.Point(20, 22);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(34, 13);
            this.lblPlaca.TabIndex = 7;
            this.lblPlaca.Text = "Placa";
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
            // grpDados
            // 
            this.grpDados.Controls.Add(this.grdDados);
            this.grpDados.Location = new System.Drawing.Point(12, 155);
            this.grpDados.Name = "grpDados";
            this.grpDados.Size = new System.Drawing.Size(581, 197);
            this.grpDados.TabIndex = 19;
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
            // 
            // grpPesquisa
            // 
            this.grpPesquisa.Controls.Add(this.btnPesquisar);
            this.grpPesquisa.Controls.Add(this.lblColaboradorDescricao);
            this.grpPesquisa.Controls.Add(this.btnLimpar);
            this.grpPesquisa.Controls.Add(this.lblVeiculoDescricao);
            this.grpPesquisa.Controls.Add(this.cboPesquisaColaborador);
            this.grpPesquisa.Controls.Add(this.txtPesquisaColaborador);
            this.grpPesquisa.Controls.Add(this.cboPesquisaVeiculo);
            this.grpPesquisa.Controls.Add(this.txtPesquisaVeiculo);
            this.grpPesquisa.Location = new System.Drawing.Point(12, 12);
            this.grpPesquisa.Name = "grpPesquisa";
            this.grpPesquisa.Size = new System.Drawing.Size(581, 126);
            this.grpPesquisa.TabIndex = 18;
            this.grpPesquisa.TabStop = false;
            this.grpPesquisa.Text = "Pesquisa";
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
            // cboPesquisaColaborador
            // 
            this.cboPesquisaColaborador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPesquisaColaborador.FormattingEnabled = true;
            this.cboPesquisaColaborador.Location = new System.Drawing.Point(17, 49);
            this.cboPesquisaColaborador.Name = "cboPesquisaColaborador";
            this.cboPesquisaColaborador.Size = new System.Drawing.Size(94, 21);
            this.cboPesquisaColaborador.TabIndex = 4;
            // 
            // txtPesquisaColaborador
            // 
            this.txtPesquisaColaborador.Location = new System.Drawing.Point(117, 49);
            this.txtPesquisaColaborador.Name = "txtPesquisaColaborador";
            this.txtPesquisaColaborador.Size = new System.Drawing.Size(333, 20);
            this.txtPesquisaColaborador.TabIndex = 3;
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
            // lblColaboradorDescricao
            // 
            this.lblColaboradorDescricao.AutoSize = true;
            this.lblColaboradorDescricao.Location = new System.Drawing.Point(456, 52);
            this.lblColaboradorDescricao.Name = "lblColaboradorDescricao";
            this.lblColaboradorDescricao.Size = new System.Drawing.Size(64, 13);
            this.lblColaboradorDescricao.TabIndex = 6;
            this.lblColaboradorDescricao.Text = "Colaborador";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Image = global::GerenciadorFrotas.Properties.Resources.eraser2;
            this.btnPesquisar.Location = new System.Drawing.Point(285, 81);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(101, 39);
            this.btnPesquisar.TabIndex = 23;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPesquisar.UseVisualStyleBackColor = true;
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
            // grpColaborador
            // 
            this.grpColaborador.Controls.Add(this.mskCelular);
            this.grpColaborador.Controls.Add(this.mskCPF);
            this.grpColaborador.Controls.Add(this.lblCelular);
            this.grpColaborador.Controls.Add(this.lblCPF);
            this.grpColaborador.Controls.Add(this.txtNome);
            this.grpColaborador.Controls.Add(this.lblNome);
            this.grpColaborador.Location = new System.Drawing.Point(7, 109);
            this.grpColaborador.Name = "grpColaborador";
            this.grpColaborador.Size = new System.Drawing.Size(569, 84);
            this.grpColaborador.TabIndex = 19;
            this.grpColaborador.TabStop = false;
            this.grpColaborador.Text = "Colaborador";
            // 
            // mskCelular
            // 
            this.mskCelular.Location = new System.Drawing.Point(228, 50);
            this.mskCelular.Mask = "(00) 00000-0000";
            this.mskCelular.Name = "mskCelular";
            this.mskCelular.ReadOnly = true;
            this.mskCelular.Size = new System.Drawing.Size(89, 20);
            this.mskCelular.TabIndex = 35;
            // 
            // mskCPF
            // 
            this.mskCPF.Location = new System.Drawing.Point(74, 50);
            this.mskCPF.Mask = "000,000,000-00";
            this.mskCPF.Name = "mskCPF";
            this.mskCPF.ReadOnly = true;
            this.mskCPF.Size = new System.Drawing.Size(90, 20);
            this.mskCPF.TabIndex = 34;
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Location = new System.Drawing.Point(183, 54);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(39, 13);
            this.lblCelular.TabIndex = 33;
            this.lblCelular.Text = "Celular";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(26, 53);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(27, 13);
            this.lblCPF.TabIndex = 32;
            this.lblCPF.Text = "CPF";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(74, 19);
            this.txtNome.MaxLength = 100;
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(275, 20);
            this.txtNome.TabIndex = 30;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(18, 22);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 31;
            this.lblNome.Text = "Nome";
            // 
            // frmEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 622);
            this.Controls.Add(this.btnRecepcionar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.grpControle);
            this.Controls.Add(this.grpDados);
            this.Controls.Add(this.grpPesquisa);
            this.Name = "frmEntrada";
            this.Text = "frmEntrada";
            this.grpControle.ResumeLayout(false);
            this.grpDados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDados)).EndInit();
            this.grpPesquisa.ResumeLayout(false);
            this.grpPesquisa.PerformLayout();
            this.grpControleVeiculo.ResumeLayout(false);
            this.grpControleVeiculo.PerformLayout();
            this.grpColaborador.ResumeLayout(false);
            this.grpColaborador.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRecepcionar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox grpControle;
        private System.Windows.Forms.ComboBox cboModelo;
        private System.Windows.Forms.TextBox txtChassi;
        private System.Windows.Forms.Label lblChassi;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.GroupBox grpDados;
        private System.Windows.Forms.DataGridView grdDados;
        private System.Windows.Forms.GroupBox grpPesquisa;
        private System.Windows.Forms.Label lblVeiculoDescricao;
        private System.Windows.Forms.ComboBox cboPesquisaColaborador;
        private System.Windows.Forms.TextBox txtPesquisaColaborador;
        private System.Windows.Forms.ComboBox cboPesquisaVeiculo;
        private System.Windows.Forms.TextBox txtPesquisaVeiculo;
        private System.Windows.Forms.Label lblColaboradorDescricao;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.GroupBox grpColaborador;
        private System.Windows.Forms.GroupBox grpControleVeiculo;
        private System.Windows.Forms.MaskedTextBox mskCelular;
        private System.Windows.Forms.MaskedTextBox mskCPF;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
    }
}