using GerenciadorFrotas.Model;
using GerenciadorFrotas.Utils;
using GerenciadorFrotas.View;
using GerenciadorFrotas.View.Cadastro.Veiculo;
using System;
using System.Windows.Forms;

namespace GerenciadorFrotas
{
    public partial class frmPrincipal : Form
    {
        //Atributos
        DateTime Login;

        //Construtor
        public frmPrincipal()
        {
            InitializeComponent();
        }

        //Metodos
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            Login = DateTime.Now;
            timer1.Enabled = true;
            Left = 0;
            Top = 0;
            Width = Screen.PrimaryScreen.WorkingArea.Width;
            Height = Screen.PrimaryScreen.WorkingArea.Height;

            Usuario usuario = new Usuario()
            {
                Id = DatabaseUtils.IdUsuarioLogado
            };
            usuario.Consultar();
            lblUsuario.Text = $"Usuário: {usuario.Nome}";
            lblServidor.Text = $"Servidor: {DatabaseUtils.Servidor}";
            lblBanco.Text = $"Banco: {DatabaseUtils.Banco}";
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja encerrar a aplicação?", "Gerenciador de Frotas",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void mnuSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = DateTime.Now - Login;
            lblTempo.Text = $"Tempo: {ts.Hours.ToString("00")}:" +
                $"{ts.Minutes.ToString("00")}:" +
                $"{ts.Seconds.ToString("00")}";
        }

        //Abrir Forms
        private void AbrirForm(Form form)
        {
            foreach (Form filho in this.MdiChildren)
            {
                if (filho.Name == form.Name)
                {
                    filho.Activate();
                    return;
                }
            }
            form.MdiParent = this;
            form.Show();
        }

        //Cadastro
        private void mnuUsuario_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmUsuario());
        }

        private void mnuColaborador_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmColaborador());
        }

        //Veiculo
        private void mnuVeiculoPrincipal_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmVeiculo());
        }

        private void mnuModelo_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmModelo());
        }

        private void mnuMarca_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmMarca());
        }

        private void mnuCategoria_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmCategoria());
        }
        //

        private void mnuOficina_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmOficina());
        }
    }
}
