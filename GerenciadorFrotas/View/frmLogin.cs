using GerenciadorFrotas.Model;
using GerenciadorFrotas.Utils;
using System;
using System.Windows.Forms;

namespace GerenciadorFrotas.View
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                string senhaCriptografada = ApplicationUtils.Criptografar(txtSenha.Text);
                Usuario usuario = new Usuario();
                usuario.Login = txtUsuario.Text;
                usuario.Consultar();
                if (usuario.Id == 0)
                {
                    MessageBox.Show("Usuário e/ou senha inválidos", "Login",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!usuario.Autenticar(senhaCriptografada))
                {
                    MessageBox.Show("Usuário e/ou senha inválidos", "Login",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!usuario.Ativo)
                {
                    MessageBox.Show("Usuário inativo", "Login",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show($"Bem vindo {usuario.Nome}.", "Login",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                DatabaseUtils.IdUsuarioLogado = usuario.Id;
                DialogResult = DialogResult.OK;
                Close();
            } catch (Exception ex)
            {
                MessageBox.Show("Erro --> " + ex.Message, "Login",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
