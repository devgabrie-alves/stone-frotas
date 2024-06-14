using GerenciadorFrotas.Model;
using GerenciadorFrotas.Utils;
using System;
using System.Windows.Forms;

namespace GerenciadorFrotas.View
{
    public partial class frmLogin : Form
    {
        //Construtor
        public frmLogin()
        {
            InitializeComponent();
        }

        //Metodos
        private string ValidarCampos()
        {
            string mensagemErro = string.Empty;

            if (txtUsuario.Text == string.Empty)
            {
                mensagemErro += "O campo USUÁRIO não pode ser vazio.\n";
            }

            if (txtSenha.Text == string.Empty)
            {
                mensagemErro += "O campo SENHA não pode ser vazio.\n";
            }

            return mensagemErro;
        }

        private Usuario ValidarLogin()
        {
            try
            {
                string senhaCriptografada = ApplicationUtils.Criptografar(txtSenha.Text);
                Usuario u = new Usuario();
                u.Login = txtUsuario.Text;
                u.Consultar();

                if (u.Id == 0)
                {
                    MessageBox.Show("Usuário e/ou senha inválidos", "Login",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;

                } else if (!u.Autenticar(senhaCriptografada))
                {
                    MessageBox.Show("Usuário e/ou senha inválidos", "Login",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;

                } else if (!u.Ativo)
                {
                    MessageBox.Show("Usuário inativo", "Login",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    return null;
                }

                return u;

            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string mensagemErro = ValidarCampos();

            if (mensagemErro != string.Empty)
            {
                MessageBox.Show(mensagemErro, "Erro de Preenchimento",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Usuario usuario = ValidarLogin();

                if (usuario == null)
                {
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
