namespace GerenciadorFrotas.View.Manutencao
{
    partial class frmConsultaVeiculos
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
            this.grpDados = new System.Windows.Forms.GroupBox();
            this.grdDados = new System.Windows.Forms.DataGridView();
            this.grpPesquisa = new System.Windows.Forms.GroupBox();
            this.rdbTodos = new System.Windows.Forms.RadioButton();
            this.rdmEmManutencao = new System.Windows.Forms.RadioButton();
            this.rdbManutencaoPendente = new System.Windows.Forms.RadioButton();
            this.rdbManutencaoAExpirar = new System.Windows.Forms.RadioButton();
            this.rdbEmConformidade = new System.Windows.Forms.RadioButton();
            this.cboPesquisa = new System.Windows.Forms.ComboBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grpDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDados)).BeginInit();
            this.grpPesquisa.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDados
            // 
            this.grpDados.Controls.Add(this.grdDados);
            this.grpDados.Location = new System.Drawing.Point(12, 101);
            this.grpDados.Name = "grpDados";
            this.grpDados.Size = new System.Drawing.Size(632, 314);
            this.grpDados.TabIndex = 15;
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
            this.grdDados.Size = new System.Drawing.Size(619, 288);
            this.grdDados.TabIndex = 0;
            // 
            // grpPesquisa
            // 
            this.grpPesquisa.Controls.Add(this.rdbTodos);
            this.grpPesquisa.Controls.Add(this.rdmEmManutencao);
            this.grpPesquisa.Controls.Add(this.rdbManutencaoPendente);
            this.grpPesquisa.Controls.Add(this.rdbManutencaoAExpirar);
            this.grpPesquisa.Controls.Add(this.rdbEmConformidade);
            this.grpPesquisa.Controls.Add(this.cboPesquisa);
            this.grpPesquisa.Controls.Add(this.btnPesquisar);
            this.grpPesquisa.Controls.Add(this.txtPesquisa);
            this.grpPesquisa.Location = new System.Drawing.Point(12, 12);
            this.grpPesquisa.Name = "grpPesquisa";
            this.grpPesquisa.Size = new System.Drawing.Size(632, 83);
            this.grpPesquisa.TabIndex = 14;
            this.grpPesquisa.TabStop = false;
            this.grpPesquisa.Text = "Pesquisa";
            // 
            // rdbTodos
            // 
            this.rdbTodos.AutoSize = true;
            this.rdbTodos.Location = new System.Drawing.Point(17, 60);
            this.rdbTodos.Name = "rdbTodos";
            this.rdbTodos.Size = new System.Drawing.Size(55, 17);
            this.rdbTodos.TabIndex = 7;
            this.rdbTodos.TabStop = true;
            this.rdbTodos.Text = "Todos";
            this.rdbTodos.UseVisualStyleBackColor = true;
            // 
            // rdmEmManutencao
            // 
            this.rdmEmManutencao.AutoSize = true;
            this.rdmEmManutencao.Location = new System.Drawing.Point(507, 60);
            this.rdmEmManutencao.Name = "rdmEmManutencao";
            this.rdmEmManutencao.Size = new System.Drawing.Size(103, 17);
            this.rdmEmManutencao.TabIndex = 6;
            this.rdmEmManutencao.TabStop = true;
            this.rdmEmManutencao.Text = "Em Manutenção";
            this.rdmEmManutencao.UseVisualStyleBackColor = true;
            // 
            // rdbManutencaoPendente
            // 
            this.rdbManutencaoPendente.AutoSize = true;
            this.rdbManutencaoPendente.Location = new System.Drawing.Point(353, 60);
            this.rdbManutencaoPendente.Name = "rdbManutencaoPendente";
            this.rdbManutencaoPendente.Size = new System.Drawing.Size(134, 17);
            this.rdbManutencaoPendente.TabIndex = 5;
            this.rdbManutencaoPendente.TabStop = true;
            this.rdbManutencaoPendente.Text = "Manutenção Pendente";
            this.rdbManutencaoPendente.UseVisualStyleBackColor = true;
            // 
            // rdbManutencaoAExpirar
            // 
            this.rdbManutencaoAExpirar.AutoSize = true;
            this.rdbManutencaoAExpirar.Location = new System.Drawing.Point(199, 60);
            this.rdbManutencaoAExpirar.Name = "rdbManutencaoAExpirar";
            this.rdbManutencaoAExpirar.Size = new System.Drawing.Size(129, 17);
            this.rdbManutencaoAExpirar.TabIndex = 4;
            this.rdbManutencaoAExpirar.TabStop = true;
            this.rdbManutencaoAExpirar.Text = "Manutenção á Expirar";
            this.rdbManutencaoAExpirar.UseVisualStyleBackColor = true;
            // 
            // rdbEmConformidade
            // 
            this.rdbEmConformidade.AutoSize = true;
            this.rdbEmConformidade.Location = new System.Drawing.Point(78, 60);
            this.rdbEmConformidade.Name = "rdbEmConformidade";
            this.rdbEmConformidade.Size = new System.Drawing.Size(108, 17);
            this.rdbEmConformidade.TabIndex = 3;
            this.rdbEmConformidade.TabStop = true;
            this.rdbEmConformidade.Text = "Em Conformidade";
            this.rdbEmConformidade.UseVisualStyleBackColor = true;
            // 
            // cboPesquisa
            // 
            this.cboPesquisa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPesquisa.FormattingEnabled = true;
            this.cboPesquisa.Location = new System.Drawing.Point(17, 22);
            this.cboPesquisa.Name = "cboPesquisa";
            this.cboPesquisa.Size = new System.Drawing.Size(137, 21);
            this.cboPesquisa.TabIndex = 2;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(523, 20);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(87, 23);
            this.btnPesquisar.TabIndex = 1;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(160, 21);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(357, 20);
            this.txtPesquisa.TabIndex = 0;
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(650, 325);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(73, 84);
            this.btnExcel.TabIndex = 16;
            this.btnExcel.Text = "Exportar para Excel";
            this.btnExcel.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(650, 224);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(73, 84);
            this.btnLimpar.TabIndex = 17;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(650, 121);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(73, 84);
            this.btnCancelar.TabIndex = 18;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // frmConsultaVeiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 420);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.grpDados);
            this.Controls.Add(this.grpPesquisa);
            this.Name = "frmConsultaVeiculos";
            this.Text = "frmConsultaVeiculos";
            this.grpDados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDados)).EndInit();
            this.grpPesquisa.ResumeLayout(false);
            this.grpPesquisa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDados;
        private System.Windows.Forms.DataGridView grdDados;
        private System.Windows.Forms.GroupBox grpPesquisa;
        private System.Windows.Forms.ComboBox cboPesquisa;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.RadioButton rdbManutencaoPendente;
        private System.Windows.Forms.RadioButton rdbManutencaoAExpirar;
        private System.Windows.Forms.RadioButton rdbEmConformidade;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.RadioButton rdmEmManutencao;
        private System.Windows.Forms.RadioButton rdbTodos;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCancelar;
    }
}