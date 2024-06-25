namespace GerenciadorFrotas.View.Controle
{
    partial class frmConsultaControle
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
            this.grpPesquisa = new System.Windows.Forms.GroupBox();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.rdbPendente = new System.Windows.Forms.RadioButton();
            this.rdbConcluido = new System.Windows.Forms.RadioButton();
            this.rdbTodos = new System.Windows.Forms.RadioButton();
            this.mskPesquisaColaborador = new System.Windows.Forms.MaskedTextBox();
            this.lblColaboradorDescricao = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblVeiculoDescricao = new System.Windows.Forms.Label();
            this.cboPesquisaColaborador = new System.Windows.Forms.ComboBox();
            this.cboPesquisaVeiculo = new System.Windows.Forms.ComboBox();
            this.txtPesquisaVeiculo = new System.Windows.Forms.TextBox();
            this.grpDados = new System.Windows.Forms.GroupBox();
            this.grdDados = new System.Windows.Forms.DataGridView();
            this.grpPesquisa.SuspendLayout();
            this.grpDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDados)).BeginInit();
            this.SuspendLayout();
            // 
            // grpPesquisa
            // 
            this.grpPesquisa.Controls.Add(this.btnExcel);
            this.grpPesquisa.Controls.Add(this.btnPesquisar);
            this.grpPesquisa.Controls.Add(this.btnCancelar);
            this.grpPesquisa.Controls.Add(this.rdbPendente);
            this.grpPesquisa.Controls.Add(this.rdbConcluido);
            this.grpPesquisa.Controls.Add(this.rdbTodos);
            this.grpPesquisa.Controls.Add(this.mskPesquisaColaborador);
            this.grpPesquisa.Controls.Add(this.lblColaboradorDescricao);
            this.grpPesquisa.Controls.Add(this.btnLimpar);
            this.grpPesquisa.Controls.Add(this.lblVeiculoDescricao);
            this.grpPesquisa.Controls.Add(this.cboPesquisaColaborador);
            this.grpPesquisa.Controls.Add(this.cboPesquisaVeiculo);
            this.grpPesquisa.Controls.Add(this.txtPesquisaVeiculo);
            this.grpPesquisa.Location = new System.Drawing.Point(12, 12);
            this.grpPesquisa.Name = "grpPesquisa";
            this.grpPesquisa.Size = new System.Drawing.Size(1510, 81);
            this.grpPesquisa.TabIndex = 19;
            this.grpPesquisa.TabStop = false;
            this.grpPesquisa.Text = "Pesquisa";
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(1070, 16);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(146, 54);
            this.btnExcel.TabIndex = 31;
            this.btnExcel.Text = "Exportar para Excel";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Image = global::GerenciadorFrotas.Properties.Resources.check;
            this.btnPesquisar.Location = new System.Drawing.Point(894, 16);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(94, 54);
            this.btnPesquisar.TabIndex = 30;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::GerenciadorFrotas.Properties.Resources.delete;
            this.btnCancelar.Location = new System.Drawing.Point(794, 15);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(94, 54);
            this.btnCancelar.TabIndex = 29;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // rdbPendente
            // 
            this.rdbPendente.AutoSize = true;
            this.rdbPendente.Location = new System.Drawing.Point(553, 50);
            this.rdbPendente.Name = "rdbPendente";
            this.rdbPendente.Size = new System.Drawing.Size(71, 17);
            this.rdbPendente.TabIndex = 28;
            this.rdbPendente.Text = "Pendente";
            this.rdbPendente.UseVisualStyleBackColor = true;
            // 
            // rdbConcluido
            // 
            this.rdbConcluido.AutoSize = true;
            this.rdbConcluido.Location = new System.Drawing.Point(553, 32);
            this.rdbConcluido.Name = "rdbConcluido";
            this.rdbConcluido.Size = new System.Drawing.Size(74, 17);
            this.rdbConcluido.TabIndex = 27;
            this.rdbConcluido.Text = "Concluído";
            this.rdbConcluido.UseVisualStyleBackColor = true;
            // 
            // rdbTodos
            // 
            this.rdbTodos.AutoSize = true;
            this.rdbTodos.Checked = true;
            this.rdbTodos.Location = new System.Drawing.Point(553, 15);
            this.rdbTodos.Name = "rdbTodos";
            this.rdbTodos.Size = new System.Drawing.Size(55, 17);
            this.rdbTodos.TabIndex = 26;
            this.rdbTodos.TabStop = true;
            this.rdbTodos.Text = "Todos";
            this.rdbTodos.UseVisualStyleBackColor = true;
            // 
            // mskPesquisaColaborador
            // 
            this.mskPesquisaColaborador.Location = new System.Drawing.Point(117, 50);
            this.mskPesquisaColaborador.Name = "mskPesquisaColaborador";
            this.mskPesquisaColaborador.Size = new System.Drawing.Size(333, 20);
            this.mskPesquisaColaborador.TabIndex = 25;
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
            // btnLimpar
            // 
            this.btnLimpar.Image = global::GerenciadorFrotas.Properties.Resources.eraser2;
            this.btnLimpar.Location = new System.Drawing.Point(685, 13);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(103, 58);
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
            // cboPesquisaColaborador
            // 
            this.cboPesquisaColaborador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPesquisaColaborador.FormattingEnabled = true;
            this.cboPesquisaColaborador.Location = new System.Drawing.Point(17, 49);
            this.cboPesquisaColaborador.Name = "cboPesquisaColaborador";
            this.cboPesquisaColaborador.Size = new System.Drawing.Size(94, 21);
            this.cboPesquisaColaborador.TabIndex = 4;
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
            // grpDados
            // 
            this.grpDados.Controls.Add(this.grdDados);
            this.grpDados.Location = new System.Drawing.Point(13, 100);
            this.grpDados.Name = "grpDados";
            this.grpDados.Size = new System.Drawing.Size(1509, 594);
            this.grpDados.TabIndex = 21;
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
            this.grdDados.Location = new System.Drawing.Point(6, 19);
            this.grdDados.MultiSelect = false;
            this.grdDados.Name = "grdDados";
            this.grdDados.ReadOnly = true;
            this.grdDados.RowHeadersVisible = false;
            this.grdDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDados.Size = new System.Drawing.Size(1497, 569);
            this.grdDados.TabIndex = 1;
            this.grdDados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDados_CellClick);
            // 
            // frmConsultaControle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1534, 706);
            this.Controls.Add(this.grpDados);
            this.Controls.Add(this.grpPesquisa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConsultaControle";
            this.Text = "Consulta de Controles";
            this.Load += new System.EventHandler(this.frmConsultaControle_Load);
            this.grpPesquisa.ResumeLayout(false);
            this.grpPesquisa.PerformLayout();
            this.grpDados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPesquisa;
        private System.Windows.Forms.MaskedTextBox mskPesquisaColaborador;
        private System.Windows.Forms.Label lblColaboradorDescricao;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblVeiculoDescricao;
        private System.Windows.Forms.ComboBox cboPesquisaColaborador;
        private System.Windows.Forms.ComboBox cboPesquisaVeiculo;
        private System.Windows.Forms.TextBox txtPesquisaVeiculo;
        private System.Windows.Forms.RadioButton rdbPendente;
        private System.Windows.Forms.RadioButton rdbConcluido;
        private System.Windows.Forms.RadioButton rdbTodos;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.GroupBox grpDados;
        private System.Windows.Forms.DataGridView grdDados;
    }
}