using GerenciadorFrotas.Model;
using GerenciadorFrotas.Utils;
using System;
using System.Net.Mail;
using System.Windows.Forms;

namespace GerenciadorFrotas.View
{
    public partial class frmColaborador : Form
    {
        //Atributos
        Colaborador colaborador = new Colaborador();

        //Construtor
        public frmColaborador()
        {
            InitializeComponent();
        }

        //Metodos
        private void CarregarGrid()
        {
            try
            {
                grdDados.DataSource = colaborador.Consultar();
                grdDados.Columns[0].Visible = false;
                grdDados.Columns[4].Visible = false;
                grdDados.Columns[5].Visible = false;
                grdDados.Columns[6].Visible = false;
                grdDados.Columns[7].Visible = false;
                grdDados.Columns[8].Visible = false;

                //Definindo Cabeçalhos
                grdDados.Columns[1].HeaderText = "Nome";
                grdDados.Columns[2].HeaderText = "CPF";
                grdDados.Columns[3].HeaderText = "E-mail";


                grdDados.Columns[1].Width = 200;
                grdDados.Columns[2].Width = 100;
                grdDados.Columns[3].Width = 200;
            } catch (Exception ex)
            {
                MessageBox.Show("Erro --> " + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CarregarComboBox()
        {
            CarregarComboBoxStatus();
            CarregarComboBoxSexo();
        }

        private void CarregarComboBoxStatus()
        {
            cboStatus.DataSource = DatabaseUtils.ConsultarStatusFuncionario();
            cboStatus.DisplayMember = "descricao";
            cboStatus.ValueMember = "id";
            cboStatus.SelectedIndex = -1;
        }

        private void CarregarComboBoxSexo()
        {
            cboSexo.DataSource = DatabaseUtils.ConsultarSexo();
            cboSexo.DisplayMember = "descricao";
            cboSexo.ValueMember = "id";
            cboSexo.SelectedIndex = -1;
        }

        private void LimparCampos()
        {
            ApplicationUtils.LimparFormulario(this);
            dtpDataAdmissao.Value = DateTime.Parse("01/01/1900");
            rdbNome.Checked = true;
            rdbCPF.Checked = false;
            mskPesquisa.Mask = "";
            mskPesquisa.MaxLength = 100;
            mskPesquisa.Clear();
            mskPesquisa.Focus();
        }

        private void PreencherClasse()
        {
            colaborador.Nome = txtNome.Text;
            colaborador.CPF = mskCPF.Text;
            colaborador.Email = txtEmail.Text;
            colaborador.DataAdmissao = dtpDataAdmissao.Value;
            colaborador.Celular = mskCelular.Text;
            colaborador.SexoId = Convert.ToInt32(cboSexo.SelectedValue);
            colaborador.StatusId = Convert.ToInt32(cboStatus.SelectedValue);
            colaborador.UsuarioId = DatabaseUtils.IdUsuarioLogado;
        }

        private void PreencherFormulario()
        {
            txtNome.Text = colaborador.Nome;
            mskCPF.Text = colaborador.CPF;
            txtEmail.Text = colaborador.Email;
            dtpDataAdmissao.Value = colaborador.DataAdmissao;
            mskCelular.Text = colaborador.Celular;

            //Combobox
            cboSexo.SelectedValue = colaborador.SexoId;
            cboStatus.SelectedValue = colaborador.StatusId;
        }

        private string ValidarPreenchimento()
        {
            string mensagemErro = string.Empty;

            try
            {
                if (txtNome.Text == string.Empty)
                {
                    mensagemErro += "O campo NOME não pode ser vazio.\n";
                }

                if (dtpDataAdmissao.Value == DateTime.Parse("01/01/1990"))
                {
                    mensagemErro += "O campo DATA DE ADMISSÃO não pode ser vazio.\n";
                }

                if (mskCPF.Text == string.Empty)
                {
                    mensagemErro += "O campo CPF não pode ser vazio.\n";

                } else if (mskCPF.Text.Length != 14) //usar ApplicationUtils.isCPFValido para uma validacao melhor (se quiser)
                {
                    mensagemErro += "O campo CPF está inválido.\n";

                } else
                {
                    Colaborador col = new Colaborador();
                    col.CPF = mskCPF.Text;
                    col.Consultar();
                    if (colaborador.Id == 0 && col.Id != 0 ||
                        colaborador.Id != 0 && col.Id != 0 && colaborador.Id != col.Id)
                    {
                        mensagemErro += "Colaborador já existente.\n";
                    }
                }

                string teste = mskCelular.Text.Substring(1, 2);

                try
                {
                    MailAddress ma = new MailAddress(txtEmail.Text);
                } catch (Exception)
                {
                    mensagemErro += "Campo E-MAIL inválido.\n";
                }

                if (mskCelular.Text == string.Empty)
                {
                    mensagemErro += "O campo CELULAR não pode ser vazio.\n";

                } else if(mskCelular.Text.Length != 15 
                        || mskCelular.Text.Substring(5, 1) != "9"
                        || mskCelular.Text.Substring(1,2).Contains("0"))
                {
                    mensagemErro += "O campo TELEFONE está inválido.";
                }

                if (cboSexo.SelectedIndex == -1)
                {
                    mensagemErro += "O campo SEXO não pode ser vazio.\n";
                }

                if (cboStatus.SelectedIndex == -1)
                {
                    mensagemErro += "O campo STATUS não pode ser vazio.\n";
                }

            } catch (Exception ex)
            {
                MessageBox.Show("Erro --> " + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return mensagemErro;
        }

        private void frmColaborador_Load(object sender, EventArgs e)
        {
            CarregarGrid();
            CarregarComboBox();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            btnGravar.Text = "Cadastrar";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void grdDados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            colaborador = new Colaborador();
            btnGravar.Text = "Atualizar";
            colaborador.Id = Convert.ToInt32(grdDados.SelectedRows[0].Cells[0].Value);
            colaborador.Consultar();
            PreencherFormulario();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                string mensagemErro = ValidarPreenchimento();

                if (mensagemErro != string.Empty)
                {
                    MessageBox.Show(mensagemErro, "Erro de Preenchimento",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                PreencherClasse();

                colaborador.Gravar();

                MessageBox.Show("Colaborador gravado com sucesso", "Cadastro de Colaborador",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimparCampos();
                CarregarGrid();
            } catch (Exception ex)
            {
                MessageBox.Show("Erro --> " + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void rdbCPF_CheckedChanged(object sender, EventArgs e)
        {
            mskPesquisa.Clear();
            mskPesquisa.Mask = "000,000,000-00";
        }

        private void rdbNome_CheckedChanged(object sender, EventArgs e)
        {
            mskPesquisa.Mask = "";
            mskPesquisa.MaxLength = 100;
            mskPesquisa.Clear();
        }

        private void mskPesquisa_TextChanged(object sender, EventArgs e)
        {
            colaborador = new Colaborador();

            if (rdbNome.Checked)
            {
                colaborador.Nome = mskPesquisa.Text;
                CarregarGrid();
            } else if (rdbCPF.Checked && mskPesquisa.Text.Length == 14)
            {
                colaborador.CPF = mskPesquisa.Text;
                CarregarGrid();
            }
        }
    }
}
