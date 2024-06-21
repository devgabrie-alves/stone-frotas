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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuColaborador = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVeiculo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVeiculoPrincipal = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuModelo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMarca = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCategoria = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOficina = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuControle = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSaida = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEntrada = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManutencao = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuConsultaVeiculos = new System.Windows.Forms.ToolStripMenuItem();
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
            this.mnuManutencao,
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
            this.mnuVeiculo,
            this.mnuOficina});
            this.mnuCadastro.Name = "mnuCadastro";
            this.mnuCadastro.Size = new System.Drawing.Size(66, 20);
            this.mnuCadastro.Text = "Cadastro";
            // 
            // mnuUsuario
            // 
            this.mnuUsuario.Image = global::GerenciadorFrotas.Properties.Resources.businessman;
            this.mnuUsuario.Name = "mnuUsuario";
            this.mnuUsuario.Size = new System.Drawing.Size(140, 22);
            this.mnuUsuario.Text = "Usuário";
            this.mnuUsuario.Click += new System.EventHandler(this.mnuUsuario_Click);
            // 
            // mnuColaborador
            // 
            this.mnuColaborador.Image = global::GerenciadorFrotas.Properties.Resources.businesspeople2;
            this.mnuColaborador.Name = "mnuColaborador";
            this.mnuColaborador.Size = new System.Drawing.Size(140, 22);
            this.mnuColaborador.Text = "Colaborador";
            this.mnuColaborador.Click += new System.EventHandler(this.mnuColaborador_Click);
            // 
            // mnuVeiculo
            // 
            this.mnuVeiculo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuVeiculoPrincipal,
            this.mnuModelo,
            this.mnuMarca,
            this.mnuCategoria});
            this.mnuVeiculo.Image = global::GerenciadorFrotas.Properties.Resources.car_13260;
            this.mnuVeiculo.Name = "mnuVeiculo";
            this.mnuVeiculo.Size = new System.Drawing.Size(140, 22);
            this.mnuVeiculo.Text = "Veículo";
            // 
            // mnuVeiculoPrincipal
            // 
            this.mnuVeiculoPrincipal.Image = global::GerenciadorFrotas.Properties.Resources.components;
            this.mnuVeiculoPrincipal.Name = "mnuVeiculoPrincipal";
            this.mnuVeiculoPrincipal.Size = new System.Drawing.Size(125, 22);
            this.mnuVeiculoPrincipal.Text = "Principal";
            this.mnuVeiculoPrincipal.Click += new System.EventHandler(this.mnuVeiculoPrincipal_Click);
            // 
            // mnuModelo
            // 
            this.mnuModelo.Image = global::GerenciadorFrotas.Properties.Resources.component_blue;
            this.mnuModelo.Name = "mnuModelo";
            this.mnuModelo.Size = new System.Drawing.Size(125, 22);
            this.mnuModelo.Text = "Modelo";
            this.mnuModelo.Click += new System.EventHandler(this.mnuModelo_Click);
            // 
            // mnuMarca
            // 
            this.mnuMarca.Image = global::GerenciadorFrotas.Properties.Resources.component_green;
            this.mnuMarca.Name = "mnuMarca";
            this.mnuMarca.Size = new System.Drawing.Size(125, 22);
            this.mnuMarca.Text = "Marca";
            this.mnuMarca.Click += new System.EventHandler(this.mnuMarca_Click);
            // 
            // mnuCategoria
            // 
            this.mnuCategoria.Image = global::GerenciadorFrotas.Properties.Resources.component_yellow;
            this.mnuCategoria.Name = "mnuCategoria";
            this.mnuCategoria.Size = new System.Drawing.Size(125, 22);
            this.mnuCategoria.Text = "Categoria";
            this.mnuCategoria.Click += new System.EventHandler(this.mnuCategoria_Click);
            // 
            // mnuOficina
            // 
            this.mnuOficina.Image = global::GerenciadorFrotas.Properties.Resources.briefcase2;
            this.mnuOficina.Name = "mnuOficina";
            this.mnuOficina.Size = new System.Drawing.Size(140, 22);
            this.mnuOficina.Text = "Oficina";
            this.mnuOficina.Click += new System.EventHandler(this.mnuOficina_Click);
            // 
            // mnuControle
            // 
            this.mnuControle.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSaida,
            this.mnuEntrada});
            this.mnuControle.Name = "mnuControle";
            this.mnuControle.Size = new System.Drawing.Size(65, 20);
            this.mnuControle.Text = "Controle";
            // 
            // mnuSaida
            // 
            this.mnuSaida.Name = "mnuSaida";
            this.mnuSaida.Size = new System.Drawing.Size(114, 22);
            this.mnuSaida.Text = "Saída";
            // 
            // mnuEntrada
            // 
            this.mnuEntrada.Name = "mnuEntrada";
            this.mnuEntrada.Size = new System.Drawing.Size(114, 22);
            this.mnuEntrada.Text = "Entrada";
            // 
            // mnuManutencao
            // 
            this.mnuManutencao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuConsultaVeiculos});
            this.mnuManutencao.Name = "mnuManutencao";
            this.mnuManutencao.Size = new System.Drawing.Size(86, 20);
            this.mnuManutencao.Text = "Manutenção";
            // 
            // mnuConsultaVeiculos
            // 
            this.mnuConsultaVeiculos.Name = "mnuConsultaVeiculos";
            this.mnuConsultaVeiculos.Size = new System.Drawing.Size(167, 22);
            this.mnuConsultaVeiculos.Text = "Consulta Veículos";
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
            this.BackgroundImage = global::GerenciadorFrotas.Properties.Resources.Captura_de_tela_2024_06_19_210626_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.ToolStripMenuItem mnuVeiculo;
        private System.Windows.Forms.ToolStripMenuItem mnuControle;
        private System.Windows.Forms.ToolStripMenuItem mnuOficina;
        private System.Windows.Forms.ToolStripMenuItem mnuSair;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblServidor;
        private System.Windows.Forms.ToolStripStatusLabel lblUsuario;
        private System.Windows.Forms.ToolStripStatusLabel lblTempo;
        private System.Windows.Forms.ToolStripStatusLabel lblBanco;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripMenuItem mnuVeiculoPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mnuModelo;
        private System.Windows.Forms.ToolStripMenuItem mnuMarca;
        private System.Windows.Forms.ToolStripMenuItem mnuCategoria;
        private System.Windows.Forms.ToolStripMenuItem mnuSaida;
        private System.Windows.Forms.ToolStripMenuItem mnuEntrada;
        private System.Windows.Forms.ToolStripMenuItem mnuManutencao;
        private System.Windows.Forms.ToolStripMenuItem mnuConsultaVeiculos;
    }
}

