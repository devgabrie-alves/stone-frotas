using GerenciadorFrotas.Model;
using GerenciadorFrotas.Utils;
using GerenciadorFrotas.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorFrotas
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        //Atributos
        DateTime Login;

        //Métodos (dev)
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

        //Métodos (forms)
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

        private void mnuSobre_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmSobre());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = DateTime.Now - Login;
            lblTempo.Text = $"Tempo: {ts.Hours.ToString("00")}:" +
                $"{ts.Minutes.ToString("00")}:" +
                $"{ts.Seconds.ToString("00")}";
        }
    }
}
