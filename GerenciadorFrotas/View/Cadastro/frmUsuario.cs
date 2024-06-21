using GerenciadorFrotas.Model;
using GerenciadorFrotas.Utils;
using System;
using System.Net.Mail;
using System.Windows.Forms;

namespace GerenciadorFrotas.View
{
    public partial class frmUsuario : Form
    {

        //Atributos
        Usuario usuario = new Usuario();

        //Construtor
        public frmUsuario()
        {
            InitializeComponent();
        }

        //Metodos
        private void CarregarGrid()
        {
            try
            {
                grdDados.DataSource = usuario.Consultar();
                grdDados.Columns[0].Visible = false;
                grdDados.Columns[4].Visible = false;
                grdDados.Columns[5].Visible = false;

                //Cabeçalho das colunas
                grdDados.Columns[1].HeaderText = "Usuário";
                grdDados.Columns[2].HeaderText = "Nome";
                grdDados.Columns[3].HeaderText = "E-mail";

                //Largura das colunas
                grdDados.Columns[1].Width = 100;
                grdDados.Columns[2].Width = 250;
                grdDados.Columns[3].Width = 303;
            } catch (Exception ex)
            {
                MessageBox.Show("Erro-->" + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PreencherClasse()
        {
            usuario.Login = txtLogin.Text;
            usuario.Nome = txtNome.Text;
            usuario.Email = txtEmail.Text;
            usuario.Senha = ApplicationUtils.Criptografar(txtSenha.Text);
            usuario.Ativo = rdbAtivo.Checked;
        }

        private void PreencherFormulario()
        {
            txtLogin.Text = usuario.Login;
            txtNome.Text = usuario.Nome;
            txtEmail.Text = usuario.Email;
            txtSenha.Text = usuario.Senha;
            txtRepetirSenha.Text = usuario.Senha;
            rdbAtivo.Checked = usuario.Ativo;
            rdbInativo.Checked = !usuario.Ativo;
        }

        private void LimparCampos()
        {
            usuario = new Usuario();
            ApplicationUtils.LimparFormulario(this);
            GetFormDefault();
        }

        private void GetFormDefault()
        {
            rdbAtivo.Checked = true;
            btnCadastrar.Text = "Cadastrar";
            txtPesquisa.Focus();
        }

        private string ValidarCampos()
        {
            try
            {
                string mensagemErro = string.Empty;

                if (txtLogin.Text == string.Empty)
                {
                    mensagemErro += "O campo LOGIN não pode ser vazio.\n";
                } else
                {
                    Usuario u = new Usuario();
                    u.Login = txtLogin.Text;
                    u.Consultar();

                    if (usuario.Id == 0 && u.Id != 0 ||
                        usuario.Id != 0 && u.Id != 0 && usuario.Id != u.Id)
                    {
                        mensagemErro += "Usuario já existente.\n";
                    }
                }

                if (txtNome.Text == string.Empty)
                {
                    mensagemErro += "O campo NOME não pode ser vazio.\n";
                }

                try
                {
                    MailAddress ma = new MailAddress(txtEmail.Text);

                } catch (Exception)
                {
                    mensagemErro += "Campo E-MAIL inválido \n";
                }

                if (txtSenha.Text == string.Empty)
                {
                    mensagemErro += "O campo SENHA não pode ser vazio.\n";
                } else if (txtSenha.Text != txtRepetirSenha.Text)
                {
                    mensagemErro += "Confirmação da senha não confere.\n";
                
                }

                return mensagemErro;
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            usuario = new Usuario();
            usuario.Nome = txtPesquisa.Text;
            CarregarGrid();
        }

        private void grdDados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                usuario = new Usuario();
                usuario.Id = Convert.ToInt32(grdDados.SelectedRows[0].Cells[0].Value);
                usuario.Consultar();
                PreencherFormulario();
            } catch (Exception ex)
            {
                MessageBox.Show("Erro-->" + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void grdDados_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                usuario = new Usuario();
                usuario.Id = Convert.ToInt32(grdDados.SelectedRows[0].Cells[0].Value);
                usuario.Consultar();
                PreencherFormulario();
                btnCadastrar.Text = "Atualizar";
            } catch (Exception ex)
            {
                MessageBox.Show("Erro-->" + ex.Message, "Erro",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                string mensagemErro = ValidarCampos();

                if (mensagemErro != string.Empty)
                {
                    MessageBox.Show(mensagemErro, "Erro de Preenchimento",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                PreencherClasse();
                usuario.Gravar();

                MessageBox.Show("Usuário gravado com sucesso!", "Cadastro de Usuários",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimparCampos();
                CarregarGrid();
            } catch (Exception ex)
            {
                MessageBox.Show("Erro-->" + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, System.EventArgs e)
        {
            LimparCampos();
            
        }
    }
}
