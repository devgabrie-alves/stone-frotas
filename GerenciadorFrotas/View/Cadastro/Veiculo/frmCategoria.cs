using GerenciadorFrotas.Model;
using GerenciadorFrotas.Utils;
using System.Text.RegularExpressions;
using System;
using System.Windows.Forms;

namespace GerenciadorFrotas.View.Cadastro.Veiculo
{
    public partial class frmCategoria : Form
    {
        //Atributos
        Categoria categoria = new Categoria();

        //Construtor
        public frmCategoria()
        {
            InitializeComponent();
        }

        //Metodos
        private void CarregarGrid()
        {
            try
            {
                grdDados.DataSource = categoria.Consultar();
                grdDados.Columns[0].Visible = false;

                //Cabeçalho das colunas
                grdDados.Columns[1].HeaderText = "Categoria";
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
            categoria = new Categoria();
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

                if (txtCategoria.Text == string.Empty)
                {
                    mensagemErro += "O campo CATEGORIA não pode ser vazio.\n";
                }

                return mensagemErro;
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void PreencherFormulario()
        {
            txtCategoria.Text = categoria.Descricao;
            btnExcluir.Enabled = true;
            btnCadastrar.Text = "Atualizar";
        }

        private void PreencherClasse()
        {
            categoria.Descricao = txtCategoria.Text;
        }

        private void frmCategoria_Load(object sender, EventArgs e)
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
            categoria = new Categoria();
            categoria.Descricao = txtPesquisa.Text;
            CarregarGrid();
        }

        private void grdDados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                categoria = new Categoria();
                categoria.Id = Convert.ToInt32(grdDados.SelectedRows[0].Cells[0].Value);
                categoria.Consultar();
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
                if (DatabaseUtils.IsAssociado("tblModelo", "categoriaId", categoria.Id))
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

                categoria.Excluir();

                MessageBox.Show("Categoria excluída com sucesso!", "Cadastro de Marcas",
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

                    txtCategoria.Focus();
                    return;
                }

                PreencherClasse();

                if (categoria.Id == 0)
                {
                    if (DatabaseUtils.JaExisteNoBanco("tblCategoria", "descricao", categoria.Descricao))
                    {
                        MessageBox.Show("Não foi possível cadastrar: O item já existe no banco de dados",
                            "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        txtCategoria.Focus();
                        return;
                    }
                }

                categoria.Gravar();

                MessageBox.Show("Categoria gravada com sucesso!", "Cadastro de Categorias",
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
