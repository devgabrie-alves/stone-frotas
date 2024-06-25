using GerenciadorFrotas.Model;
using GerenciadorFrotas.Utils;
using System;
using System.Windows.Forms;

namespace GerenciadorFrotas.View.Cadastro.Veiculo
{
    public partial class frmMarca : Form
    {
        //Atributos
        Marca marca = new Marca();

        //Construtor
        public frmMarca()
        {
            InitializeComponent();
        }

        //Metodos
        private void CarregarGrid()
        {
            try
            {
                grdDados.DataSource = marca.Consultar();
                grdDados.Columns[0].Visible = false;

                //Cabeçalho das colunas
                grdDados.Columns[1].HeaderText = "Marca";
                grdDados.Columns[2].HeaderText = "Data Cadastro";

                //Largura das colunas
                grdDados.Columns[1].Width = 111;
                grdDados.Columns[2].Width = 110;

            } catch (Exception ex)
            {
                MessageBox.Show("Erro-->" + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimparCampos()
        {
            marca = new Marca();
            ApplicationUtils.LimparFormulario(this);
            btnCadastrar.Text = "Cadastrar";
            btnExcluir.Enabled = false;
            txtPesquisa.Focus();
        }

        private string ValidarCampos()
        {
            try
            {
                string mensagemErro = string.Empty;

                if (txtMarca.Text == string.Empty)
                {
                    mensagemErro += "O campo MARCA não pode ser vazio.\n";
                }

                return mensagemErro;
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void PreencherFormulario()
        {
            txtMarca.Text = marca.Nome;
            btnExcluir.Enabled = true;
            btnCadastrar.Text = "Atualizar";
        }

        private void PreencherClasse()
        {
            marca.Nome = txtMarca.Text;
        }

        private void frmMarca_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            marca = new Marca();
            marca.Nome = txtPesquisa.Text;
            CarregarGrid();
        }

        private void grdDados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdDados.Rows.Count == 0)
            {
                return;
            }

            try
            {
                marca = new Marca();
                marca.Id = Convert.ToInt32(grdDados.SelectedRows[0].Cells[0].Value);
                marca.Consultar();
                PreencherFormulario();

            } catch (Exception ex)
            {
                MessageBox.Show("Erro-->" + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (DatabaseUtils.IsAssociado("tblModelo", "marcaId", marca.Id))
                {
                    MessageBox.Show("Não foi possível excluir: O item se encontra associado á um modelo",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (MessageBox.Show("Tem certeza de que deseja excluir o item selecionado?", "Exclusão de Item",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2) == DialogResult.No)
                {
                    return;
                }

                marca.Excluir();

                MessageBox.Show("Marca excluída com sucesso!", "Cadastro de Marcas",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimparCampos();
                CarregarGrid();

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

                    txtMarca.Focus();
                    return;
                }

                PreencherClasse();

                if (marca.Id == 0)
                {
                    if (DatabaseUtils.JaExisteNoBanco("tblMarca", "nome", marca.Nome))
                    {
                        MessageBox.Show("Não foi possível cadastrar: O item já existe no banco de dados",
                            "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        txtMarca.Focus();
                        return;
                    }
                }

                marca.Gravar();

                MessageBox.Show("Marca gravada com sucesso!", "Cadastro de Marcas",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimparCampos();
                CarregarGrid();
            } catch (Exception ex)
            {
                MessageBox.Show("Erro-->" + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
