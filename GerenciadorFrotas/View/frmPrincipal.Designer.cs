namespace GerenciadorFrotas
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuColaborador = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVeiculos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOficina = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuControle = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEntradaSaida = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManutencao = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuConformidade = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExpirar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAndamento = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblServidor = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTempo = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblBanco = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCadastro,
            this.mnuControle,
            this.mnuSobre,
            this.mnuSair});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuCadastro
            // 
            this.mnuCadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuUsuario,
            this.mnuColaborador,
            this.mnuVeiculos,
            this.mnuOficina});
            this.mnuCadastro.Name = "mnuCadastro";
            this.mnuCadastro.Size = new System.Drawing.Size(66, 20);
            this.mnuCadastro.Text = "Cadastro";
            // 
            // mnuUsuario
            // 
            this.mnuUsuario.Name = "mnuUsuario";
            this.mnuUsuario.Size = new System.Drawing.Size(180, 22);
            this.mnuUsuario.Text = "Usuário";
            this.mnuUsuario.Click += new System.EventHandler(this.mnuUsuario_Click);
            // 
            // mnuColaborador
            // 
            this.mnuColaborador.Name = "mnuColaborador";
            this.mnuColaborador.Size = new System.Drawing.Size(180, 22);
            this.mnuColaborador.Text = "Colaborador";
            // 
            // mnuVeiculos
            // 
            this.mnuVeiculos.Name = "mnuVeiculos";
            this.mnuVeiculos.Size = new System.Drawing.Size(180, 22);
            this.mnuVeiculos.Text = "Veículo";
            // 
            // mnuOficina
            // 
            this.mnuOficina.Name = "mnuOficina";
            this.mnuOficina.Size = new System.Drawing.Size(180, 22);
            this.mnuOficina.Text = "Oficina";
            // 
            // mnuControle
            // 
            this.mnuControle.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEntradaSaida,
            this.mnuManutencao});
            this.mnuControle.Name = "mnuControle";
            this.mnuControle.Size = new System.Drawing.Size(65, 20);
            this.mnuControle.Text = "Controle";
            // 
            // mnuEntradaSaida
            // 
            this.mnuEntradaSaida.Name = "mnuEntradaSaida";
            this.mnuEntradaSaida.Size = new System.Drawing.Size(147, 22);
            this.mnuEntradaSaida.Text = "Entrada/Saída";
            // 
            // mnuManutencao
            // 
            this.mnuManutencao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuConformidade,
            this.menuExpirar,
            this.mnuAndamento});
            this.mnuManutencao.Name = "mnuManutencao";
            this.mnuManutencao.Size = new System.Drawing.Size(147, 22);
            this.mnuManutencao.Text = "Manutenção";
            // 
            // mnuConformidade
            // 
            this.mnuConformidade.Name = "mnuConformidade";
            this.mnuConformidade.Size = new System.Drawing.Size(169, 22);
            this.mnuConformidade.Text = "Em conformidade";
            // 
            // menuExpirar
            // 
            this.menuExpirar.Name = "menuExpirar";
            this.menuExpirar.Size = new System.Drawing.Size(169, 22);
            this.menuExpirar.Text = "Á expirar";
            // 
            // mnuAndamento
            // 
            this.mnuAndamento.Name = "mnuAndamento";
            this.mnuAndamento.Size = new System.Drawing.Size(169, 22);
            this.mnuAndamento.Text = "Em andamento";
            // 
            // mnuSobre
            // 
            this.mnuSobre.Name = "mnuSobre";
            this.mnuSobre.Size = new System.Drawing.Size(49, 20);
            this.mnuSobre.Text = "Sobre";
            this.mnuSobre.Click += new System.EventHandler(this.mnuSobre_Click);
            // 
            // mnuSair
            // 
            this.mnuSair.Name = "mnuSair";
            this.mnuSair.Size = new System.Drawing.Size(38, 20);
            this.mnuSair.Text = "Sair";
            this.mnuSair.Click += new System.EventHandler(this.mnuSair_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblServidor,
            this.lblUsuario,
            this.lblTempo,
            this.lblBanco,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblServidor
            // 
            this.lblServidor.Name = "lblServidor";
            this.lblServidor.Size = new System.Drawing.Size(196, 17);
            this.lblServidor.Spring = true;
            this.lblServidor.Text = "Servidor: ";
            this.lblServidor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUsuario
            // 
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(196, 17);
            this.lblUsuario.Spring = true;
            this.lblUsuario.Text = "Usuário: ";
            // 
            // lblTempo
            // 
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(196, 17);
            this.lblTempo.Spring = true;
            this.lblTempo.Text = "Tempo: 00:00:00";
            // 
            // lblBanco
            // 
            this.lblBanco.Name = "lblBanco";
            this.lblBanco.Size = new System.Drawing.Size(196, 17);
            this.lblBanco.Spring = true;
            this.lblBanco.Text = "Banco: ";
            this.lblBanco.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(0, 17);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "Gerenciador de Frotas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuCadastro;
        private System.Windows.Forms.ToolStripMenuItem mnuUsuario;
        private System.Windows.Forms.ToolStripMenuItem mnuColaborador;
        private System.Windows.Forms.ToolStripMenuItem mnuVeiculos;
        private System.Windows.Forms.ToolStripMenuItem mnuControle;
        private System.Windows.Forms.ToolStripMenuItem mnuEntradaSaida;
        private System.Windows.Forms.ToolStripMenuItem mnuOficina;
        private System.Windows.Forms.ToolStripMenuItem mnuManutencao;
        private System.Windows.Forms.ToolStripMenuItem mnuConformidade;
        private System.Windows.Forms.ToolStripMenuItem menuExpirar;
        private System.Windows.Forms.ToolStripMenuItem mnuSobre;
        private System.Windows.Forms.ToolStripMenuItem mnuSair;
        private System.Windows.Forms.ToolStripMenuItem mnuAndamento;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblServidor;
        private System.Windows.Forms.ToolStripStatusLabel lblUsuario;
        private System.Windows.Forms.ToolStripStatusLabel lblTempo;
        private System.Windows.Forms.ToolStripStatusLabel lblBanco;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ImageList imageList1;
    }
}

