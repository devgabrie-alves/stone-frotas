using GerenciadorFrotas.Model;
using GerenciadorFrotas.Utils;
using System;
using System.Drawing.Text;
using System.Windows.Forms;

namespace GerenciadorFrotas.View.Cadastro.Veiculo
{
    public partial class frmModelo : Form
    {
        //Atributos
        Modelo modelo = new Modelo();
        Marca marca = new Marca();
        Categoria categoria = new Categoria();

        //Construtor
        public frmModelo()
        {
            InitializeComponent();
        }

        //Metodos
        private void CarregarGrid()
        {
            try
            {
                grdDados.DataSource = modelo.Consultar();
                grdDados.Columns[0].Visible = false;
                grdDados.Columns[3].Visible = false;
                grdDados.Columns[4].Visible = false;
                grdDados.Columns[7].Visible = false;
                grdDados.Columns[8].Visible = false;

                //Cabeçalho das colunas
                grdDados.Columns[1].HeaderText = "Modelo";
                grdDados.Columns[2].HeaderText = "Data Cadastro";
                grdDados.Columns[5].HeaderText = "Marca";
                grdDados.Columns[6].HeaderText = "Categoria";

                //Largura das colunas
                grdDados.Columns[1].Width = 120;
                grdDados.Columns[2].Width = 110;
                grdDados.Columns[5].Width = 110;
                grdDados.Columns[6].Width = 110;

            } catch (Exception ex)
            {
                MessageBox.Show("Erro-->" + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimparCampos()
        {
            modelo = new Modelo();
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

                if (txtModelo.Text == string.Empty)
                {
                    mensagemErro += "O campo MODELO não pode ser vazio.\n";
                }

                if(txtAno.Text == string.Empty)
                {
                    mensagemErro += "O campo ANO não pode ser vazio.\n";
                }
                else if(Convert.ToInt32(txtAno.Text) >  DateTime.Now.Year)
                {
                    mensagemErro += "O ano não pode ser maior que o atual.\n";
                
                }else if (txtAno.Text.Length != 4)
                {
                    mensagemErro += "O campo ANO é inválido.\n";
                }

                if (cboMarca.SelectedIndex == -1)
                {
                    mensagemErro += "O campo MARCA não pode ser vazio.\n";
                }

                if (cboCategoria.SelectedIndex == -1)
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
            txtModelo.Text = modelo.Nome;
            txtAno.Text = modelo.Ano.ToString();
            btnExcluir.Enabled = true;
            btnCadastrar.Text = "Atualizar";

            //Combobox
            cboMarca.SelectedValue = modelo.MarcaId;
            cboCategoria.SelectedValue = modelo.CategoriaId;
        }

        private void PreencherClasse()
        {
            modelo.Nome = txtModelo.Text;
            modelo.Ano = Convert.ToInt32(txtAno.Text);
            modelo.MarcaId = Convert.ToInt32(cboMarca.SelectedValue);
            modelo.CategoriaId = Convert.ToInt32(cboCategoria.SelectedValue);
        }

        private void CarregarMarcas()
        {
            try
            {
                cboMarca.DataSource = marca.Consultar();
                cboMarca.DisplayMember = "nome";
                cboMarca.ValueMember = "id";
                cboMarca.SelectedIndex = -1;
            } catch (Exception ex)
            {
                MessageBox.Show("Erro --> " + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CarregarCategorias()
        {
            try
            {
                cboCategoria.DataSource = categoria.Consultar();
                cboCategoria.DisplayMember = "descricao";
                cboCategoria.ValueMember = "id";
                cboCategoria.SelectedIndex = -1;
            } catch (Exception ex)
            {
                MessageBox.Show("Erro --> " + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void CarregarComboBox()
        {
            CarregarMarcas();
            CarregarCategorias();
        }

        private void frmModelo_Load(object sender, EventArgs e)
        {
            CarregarGrid();
            CarregarComboBox();
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
            modelo = new Modelo();
            modelo.Nome = txtPesquisa.Text;
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
                modelo = new Modelo();
                modelo.Id = Convert.ToInt32(grdDados.SelectedRows[0].Cells[0].Value);
                modelo.Consultar();
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
                if (DatabaseUtils.IsAssociado("tblVeiculo", "modeloId", modelo.Id))
                {
                    MessageBox.Show("Não foi possível excluir: O item se encontra associado á um veículo",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (MessageBox.Show("Tem certeza de que deseja excluir o item selecionado?", "Exclusão de Item",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2) == DialogResult.No)
                {
                    return;
                }

                modelo.Excluir();

                MessageBox.Show("Modelo excluído com sucesso!", "Cadastro de Modelos",
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

                    txtModelo.Focus();
                    return;
                }

                PreencherClasse();

                if (modelo.Id == 0)
                {
                    if(modelo.JaExisteNoBanco())
                    {
                        MessageBox.Show("Não foi possível cadastrar: O item já existe no banco de dados",
                            "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        txtModelo.Focus();
                        return;
                    }
                }

                modelo.Gravar();

                MessageBox.Show("Modelo gravado com sucesso!", "Cadastro de Modelos",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimparCampos();
                CarregarGrid();
            } catch (Exception ex)
            {
                MessageBox.Show("Erro-->" + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtAno_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ApplicationUtils.SomenteNumeros(e.KeyChar);
        }
    }
}
