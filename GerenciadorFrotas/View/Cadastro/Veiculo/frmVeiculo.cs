using GerenciadorFrotas.Model;
using GerenciadorFrotas.Model.enums;
using GerenciadorFrotas.Utils;
using System;
using System.Data;
using System.Windows.Forms;

namespace GerenciadorFrotas.View
{
    public partial class frmVeiculo : Form
    {
        //Atributos
        Veiculo veiculo = new Veiculo();
        Modelo modelo = new Modelo();
        Marca marca = new Marca();
        Categoria categoria = new Categoria();

        //Construtor
        public frmVeiculo()
        {
            InitializeComponent();
        }

        //Metodos
        private void CarregarGrid(int escolhaConsulta, string campoPesquisa)
        {
            try
            {
                grdDados.DataSource = veiculo.Consultar(escolhaConsulta, campoPesquisa, Model.enums.StatusAtivoEnum.TODOS, StatusAtividadeEnum.TODOS);
                grdDados.Columns[0].Visible = false;
                grdDados.Columns[3].Visible = false;
                grdDados.Columns[4].Visible = false;
                grdDados.Columns[5].Visible = false;
                grdDados.Columns[6].Visible = false;
                grdDados.Columns[7].Visible = false;

                //Cabeçalho das colunas
                grdDados.Columns[1].HeaderText = "Placa";
                grdDados.Columns[2].HeaderText = "Chassi";
                grdDados.Columns[8].HeaderText = "Modelo";
                grdDados.Columns[9].HeaderText = "Marca";
                grdDados.Columns[10].HeaderText = "Categoria";

                //Largura das colunas
                grdDados.Columns[1].Width = 100;
                grdDados.Columns[2].Width = 100;
                grdDados.Columns[8].Width = 100;
                grdDados.Columns[9].Width = 100;
                grdDados.Columns[10].Width = 100;

            } catch (Exception ex)
            {
                MessageBox.Show("Erro-->" + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PreencherClasse()
        {
            veiculo.Placa = txtPlaca.Text;
            veiculo.Chassi = txtChassi.Text;
            veiculo.QuilometragemInicial = Convert.ToInt32(txtQuilometragem.Text);
            veiculo.QuilometragemAtual = veiculo.QuilometragemInicial;

            if (rdbAtivo.Checked)
            {
                veiculo.Ativo = true;

            } else
            {
                veiculo.Ativo = false;
            }

            veiculo.ModeloId = Convert.ToInt32(cboModelo.SelectedValue);
            veiculo.UsuarioId = DatabaseUtils.IdUsuarioLogado;
        }

        private void PreencherFormulario()
        {
            txtPlaca.Text = veiculo.Placa;
            txtChassi.Text = veiculo.Chassi;
            txtQuilometragem.Text = veiculo.QuilometragemInicial.ToString();
            cboModelo.SelectedValue = veiculo.ModeloId;
            rdbAtivo.Checked = veiculo.Ativo;
            rdbInativo.Checked = !veiculo.Ativo;

            modelo = new Modelo();
            modelo.Id = veiculo.ModeloId;
            modelo.Consultar();

            cboMarca.SelectedValue = Convert.ToInt32(modelo.MarcaId);
            cboCategoria.SelectedValue = Convert.ToInt32(modelo.CategoriaId);

            modelo = new Modelo();
            CarregarModelos();
            cboModelo.SelectedValue = Convert.ToInt32(veiculo.ModeloId);
        }

        private void LimparCampos()
        {
            veiculo = new Veiculo();
            ApplicationUtils.LimparFormulario(this);
            CarregarGrid(-1, "");
            GetFormDefault();
        }

        private void GetFormDefault()
        {
            rdbAtivo.Checked = true;
            btnCadastrar.Text = "Cadastrar";
            cboPesquisa.SelectedIndex = 0;
            cboModelo.Enabled = false;
            cboModelo.DataSource = null;
            txtQuilometragem.Enabled = true;
            rdbAtivo.Enabled = true;
            rdbInativo.Enabled = true;

            txtPesquisa.Focus();
        }

        private string ValidarCampos()
        {
            try
            {
                string mensagemErro = string.Empty;

                if (txtPlaca.Text == string.Empty)
                {
                    mensagemErro += "O campo PLACA não pode ser vazio.\n";

                } else if (txtPlaca.Text.Length != 7)
                {
                    mensagemErro += "O campo PLACA é inválido.\n";

                } else
                {
                    Veiculo v = new Veiculo();
                    v.Placa = txtPlaca.Text;
                    v.Consultar(6, v.Placa, StatusAtivoEnum.TODOS, StatusAtividadeEnum.TODOS);
                    if (veiculo.Id == 0 && v.Id != 0 ||
                        veiculo.Id != 0 && v.Id != 0 && veiculo.Id != v.Id)
                    {
                        mensagemErro += "Veículo já existente.\n";
                    }
                }

                if (txtChassi.Text == string.Empty)
                {
                    mensagemErro += "O campo CHASSI não pode ser vazio.\n";
                
                } else if (txtChassi.Text.Length != 17) 
                {
                    mensagemErro += "O campo CHASSI é inválido.\n";
                }

                if (cboMarca.SelectedIndex == -1)
                {
                    mensagemErro += "O campo MARCA não pode ser vazio.\n";
                }

                if (cboCategoria.SelectedIndex == -1)
                {
                    mensagemErro += "O campo CATEGORIA não pode ser vazio.\n";
                }

                if (txtQuilometragem.Text == string.Empty)
                {
                    mensagemErro += "O campo QUILOMETRAGEM não pode ser vazio.\n";
                }

                if (cboModelo.SelectedIndex == -1)
                {
                    mensagemErro += "O campo MODELO não pode ser vazio.\n";
                }

                return mensagemErro;
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void CarregarComboBox()
        {
            CarregarDadosPesquisa();
            CarregarMarcas();
            CarregarCategorias();
        }

        private void CarregarModelos()
        {
            //Prepara objeto
            modelo.MarcaId = Convert.ToInt32(cboMarca.SelectedValue);
            modelo.CategoriaId = Convert.ToInt32(cboCategoria.SelectedValue);

            //Busca informações
            cboModelo.DataSource = modelo.Consultar();
            cboModelo.DisplayMember = "nomeAno";
            cboModelo.ValueMember = "id";
            cboModelo.SelectedIndex = -1;
        }

        private void CarregarDadosPesquisa()
        {
            DataTable dt = CriarDataTableDePesquisa();

            cboPesquisa.DataSource = dt;
            cboPesquisa.DisplayMember = "item";
            cboPesquisa.ValueMember = "id";
            cboPesquisa.SelectedIndex = 0;
        }

        private DataTable CriarDataTableDePesquisa()
        {
            DataTable dataTable = new DataTable();
            DataColumn id = new DataColumn("id", typeof(int));
            DataColumn nome = new DataColumn("item", typeof(string));

            dataTable.Columns.Add(id);
            dataTable.Columns.Add(nome);

            //placa, chassi, modelo, marca, categoria
            DataRow placa = dataTable.NewRow();
            placa["id"] = 1;
            placa["item"] = "Placa";
            dataTable.Rows.Add(placa);

            DataRow chassi = dataTable.NewRow();
            chassi["id"] = 2;
            chassi["item"] = "Chassi";
            dataTable.Rows.Add(chassi);

            DataRow modelo = dataTable.NewRow();
            modelo["id"] = 3;
            modelo["item"] = "Modelo";
            dataTable.Rows.Add(modelo);

            DataRow marca = dataTable.NewRow();
            marca["id"] = 4;
            marca["item"] = "Marca";
            dataTable.Rows.Add(marca);

            DataRow categoria = dataTable.NewRow();
            categoria["id"] = 5;
            categoria["item"] = "Categoria";
            dataTable.Rows.Add(categoria);

            return dataTable;
        }

        private void CarregarMarcas()
        {
            cboMarca.DataSource = marca.Consultar();
            cboMarca.DisplayMember = "nome";
            cboMarca.ValueMember = "id";
            cboMarca.SelectedIndex = -1;
        }

        private void CarregarCategorias()
        {
            cboCategoria.DataSource = categoria.Consultar();
            cboCategoria.DisplayMember = "descricao";
            cboCategoria.ValueMember = "id";
            cboCategoria.SelectedIndex = -1;
        }

        private void frmVeiculo_Load(object sender, System.EventArgs e)
        {
            CarregarGrid(-1, "");
            CarregarComboBox();
        }

        private void grdDados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdDados.Rows.Count == 0)
            {
                return;
            }

            try
            {
                veiculo = new Veiculo();
                veiculo.Id = Convert.ToInt32(grdDados.SelectedRows[0].Cells[0].Value);
                veiculo.Consultar(-1, "", StatusAtivoEnum.TODOS, StatusAtividadeEnum.TODOS);

                if(veiculo.VerificaManutencaoOuControle())
                {
                    txtQuilometragem.Enabled = false;
                    rdbAtivo.Enabled = false;
                    rdbInativo.Enabled = false;
                
                }else
                {
                    txtQuilometragem.Enabled = true;
                    rdbAtivo.Enabled = true;
                    rdbInativo.Enabled = true;
                }

                PreencherFormulario();

                btnCadastrar.Text = "Atualizar";

            } catch (Exception ex)
            {
                MessageBox.Show("Erro-->" + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnPesquisar_Click(object sender, System.EventArgs e)
        {
            veiculo = new Veiculo();
            string campoPesquisa = string.Empty;
            int escolhaPesquisa = -1;

            if (Convert.ToInt32(cboPesquisa.SelectedValue) == 1)
            {
                escolhaPesquisa = 1;

            } else if (Convert.ToInt32(cboPesquisa.SelectedValue) == 2)
            {
                escolhaPesquisa = 2;

            } else if (Convert.ToInt32(cboPesquisa.SelectedValue) == 3)
            {
                escolhaPesquisa = 3;

            } else if (Convert.ToInt32(cboPesquisa.SelectedValue) == 4)
            {
                escolhaPesquisa = 4;

            } else if (Convert.ToInt32(cboPesquisa.SelectedValue) == 5)
            {
                escolhaPesquisa = 5;
            }

            campoPesquisa = txtPesquisa.Text;
            CarregarGrid(escolhaPesquisa, campoPesquisa);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
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
                veiculo.Gravar();

                MessageBox.Show("Veículo gravado com sucesso!", "Cadastro de Veículos",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimparCampos();
                CarregarGrid(-1, "");
            } catch (Exception ex)
            {
                MessageBox.Show("Erro-->" + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cboMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboModelo.SelectedIndex != -1)
            {
                cboModelo.SelectedIndex = -1;
            }

            if (cboMarca.SelectedIndex != -1 && cboCategoria.SelectedIndex != -1)
            {
                CarregarModelos();
                cboModelo.Enabled = true;
            }
        }

        private void cboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboModelo.SelectedIndex != -1)
            {
                cboModelo.SelectedIndex = -1;
            }

            if (cboMarca.SelectedIndex != -1 && cboCategoria.SelectedIndex != -1)
            {
                CarregarModelos();
                cboModelo.Enabled = true;
            }
        }

        private void txtQuilometragem_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ApplicationUtils.SomenteNumeros(e.KeyChar);
        }
    }
}
