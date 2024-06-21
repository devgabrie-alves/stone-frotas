using GerenciadorFrotas.Model;
using GerenciadorFrotas.Utils;
using System;
using System.Net.Mail;
using System.Windows.Forms;

namespace GerenciadorFrotas.View
{
    public partial class frmOficina : Form
    {
        //Atributos
        Oficina oficina = new Oficina();
        bool load = false;

        //Construtor
        public frmOficina()
        {
            InitializeComponent();
        }

        //Metodos
        private void CarregarGrid()
        {
            try
            {
                grdDados.DataSource = oficina.Consultar();
                grdDados.Columns[0].Visible = false;
                grdDados.Columns[1].Visible = false;
                grdDados.Columns[5].Visible = false;
                grdDados.Columns[6].Visible = false;
                grdDados.Columns[7].Visible = false;

                grdDados.Columns[2].HeaderText = "Nome Fantasia";
                grdDados.Columns[3].HeaderText = "CNPJ";
                grdDados.Columns[4].HeaderText = "E-mail";

                grdDados.Columns[2].Width = 200;
                grdDados.Columns[3].Width = 150;
                grdDados.Columns[4].Width = 150;

            } catch (Exception ex)
            {
                MessageBox.Show("Erro --> " + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CarregarCidades()
        {
            if (!load)
            {
                return;
            }

            try
            {
                int estado = Convert.ToInt32(cboEstado.SelectedValue);
                cboCidade.DataSource = DatabaseUtils.ConsultarCidades(estado);
                cboCidade.DisplayMember = "cidade";
                cboCidade.ValueMember = "id";
                cboCidade.SelectedIndex = -1;
            } catch (Exception ex)
            {
                MessageBox.Show("Erro --> " + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CarregarEstados()
        {
            try
            {
                cboEstado.DataSource = DatabaseUtils.ConsultarEstados();
                cboEstado.DisplayMember = "uf";
                cboEstado.ValueMember = "id";
                cboEstado.SelectedIndex = -1;
            } catch (Exception ex)
            {
                MessageBox.Show("Erro --> " + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimparCampos()
        {
            ApplicationUtils.LimparFormulario(this);
            rdbNome.Checked = true;
            rdbCNPJ.Checked = false;
        }

        private void PreencherClasse()
        {
            oficina.RazaoSocial = txtRazaoSocial.Text;
            oficina.NomeFantasia = txtNomeFantasia.Text;
            oficina.CNPJ = mskCNPJ.Text;
            oficina.Email = txtEmail.Text;
            oficina.UrlSite = txtSite.Text;
            oficina.Telefone = mskTelefone.Text;
            oficina.UsuarioId = DatabaseUtils.IdUsuarioLogado;

            //endereco oficina
            oficina.Endereco.Logradouro = txtEndereco.Text;
            oficina.Endereco.Complemento = txtComplemento.Text;
            oficina.Endereco.Numero = txtNumero.Text;
            oficina.Endereco.Bairro = txtBairro.Text;
            oficina.Endereco.CEP = mskCEP.Text;
            oficina.Endereco.CidadeId = Convert.ToInt32(cboCidade.SelectedValue);
        }

        private void PreencherFormulario()
        {
            try
            {
                //Informacoes Pessoais
                txtRazaoSocial.Text = oficina.RazaoSocial;
                txtNomeFantasia.Text = oficina.NomeFantasia;
                mskCNPJ.Text = oficina.CNPJ;
                txtEmail.Text = oficina.Email;
                txtSite.Text = oficina.UrlSite;
                mskTelefone.Text = oficina.Telefone;

                //Endereco
                txtEndereco.Text = oficina.Endereco.Logradouro;
                txtComplemento.Text = oficina.Endereco.Complemento;
                txtNumero.Text = oficina.Endereco.Numero;
                txtBairro.Text = oficina.Endereco.Bairro;
                mskCEP.Text = oficina.Endereco.CEP;

                //Combobox
                int codigoEstado = DatabaseUtils.ConsultarEstado(oficina.Endereco.CidadeId);
                cboEstado.SelectedValue = codigoEstado;
                cboCidade.SelectedValue = oficina.Endereco.CidadeId;
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private string ValidarPreenchimento()
        {
            string mensagemErro = string.Empty;
            try
            {
                if (txtRazaoSocial.Text == string.Empty)
                {
                    mensagemErro += "O campo RAZÃO SOCIAL não pode ser vazio. \n";
                }

                if (txtNomeFantasia.Text == string.Empty)
                {
                    mensagemErro += "O campo NOME FANTASIA não pode ser vazio. \n";
                }

                if (mskCNPJ.Text == string.Empty)
                {
                    mensagemErro += "O campo CNPJ não pode ser vazio. \n";

                } else if (mskCNPJ.Text.Length != 18) //usar ApplicationUtils.isCNPJValido para uma validacao melhor (se quiser)
                {
                    mensagemErro += "Campo CNPJ inválido. \n";

                } else
                {
                    Oficina of = new Oficina();
                    of.CNPJ = mskCNPJ.Text;
                    of.Consultar();
                    if (oficina.Id == 0 && of.Id != 0 ||
                        oficina.Id != 0 && of.Id != 0 && oficina.Id != of.Id)
                    {
                        mensagemErro += "Oficina já existente.\n";
                    }
                }

                try
                {
                    MailAddress ma = new MailAddress(txtEmail.Text);
                } catch (Exception)
                {
                    mensagemErro += "O campo E-MAIL é inválido. \n";
                }


                if (txtEndereco.Text == string.Empty)
                {
                    mensagemErro += "O campo ENDEREÇO não pode ser vazio. \n";
                }

                if (txtNumero.Text == string.Empty)
                {
                    mensagemErro += "O campo NÚMERO não pode ser vazio. \n";
                }

                if (txtBairro.Text == string.Empty)
                {
                    mensagemErro += "O campo BAIRRO não pode ser vazio. \n";
                }

                if (mskCEP.Text == string.Empty)
                {
                    mensagemErro += "O campo CEP não pode ser vazio. \n";

                } else if (mskCEP.Text.Length != 9)
                {
                    mensagemErro += "Campo CEP inválido. \n";
                }

                if (cboCidade.SelectedIndex == -1)
                {
                    mensagemErro += "O campo CIDADE não pode ser vazio. \n";
                }

                if (cboEstado.SelectedIndex == -1)
                {
                    mensagemErro += "O campo ESTADO não pode ser vazio. \n";
                }

                if (mskTelefone.Text == string.Empty)
                {
                    mensagemErro += "O campo TELEFONE não pode ser vazio. \n";
                
                }else if(mskTelefone.Text.Length != 14)
                {
                    mensagemErro += "Campo TELEFONE inválido. \n";
                }

            } catch (Exception ex)
            {
                MessageBox.Show("Erro --> " + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return mensagemErro;
        }

        private void frmOficina_Load(object sender, EventArgs e)
        {
            CarregarGrid();
            CarregarEstados();
            load = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                string mensagem = ValidarPreenchimento();

                if (mensagem != string.Empty)
                {
                    MessageBox.Show(mensagem, "Erro de Preenchimento",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                PreencherClasse();
                oficina.Gravar();

                MessageBox.Show("Oficina gravada com sucesso", "Cadastro de Oficina",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimparCampos();
                CarregarGrid();
            } catch (Exception ex)
            {
                MessageBox.Show("Erro --> " + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cboEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregarCidades();
        }

        private void grdDados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                oficina = new Oficina();
                oficina.Id = Convert.ToInt32(grdDados.SelectedRows[0].Cells[0].Value);
                oficina.Consultar();
                PreencherFormulario();
            } catch (Exception ex)
            {
                MessageBox.Show("Erro --> " + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rdbNome_CheckedChanged(object sender, EventArgs e)
        {
            mskPesquisa.Clear();
            mskPesquisa.Mask = "";
            mskPesquisa.MaxLength = 50;
        }

        private void rdbCNPJ_CheckedChanged(object sender, EventArgs e)
        {
            mskPesquisa.Clear();
            mskPesquisa.Mask = "00,000,000/0000-00";
        }

        private void mskCNPJ_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ApplicationUtils.SomenteNumeros(e.KeyChar);
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ApplicationUtils.SomenteNumeros(e.KeyChar);
        }

        private void mskPesquisa_TextChanged(object sender, EventArgs e)
        {
            oficina = new Oficina();

            if (rdbNome.Checked)
            {
                oficina.NomeFantasia = mskPesquisa.Text;
                CarregarGrid();

            } else if (rdbCNPJ.Checked && mskPesquisa.Text.Length == 18)
            {
                oficina.CNPJ = mskPesquisa.Text;
                CarregarGrid();
            }
        }
    }
}
