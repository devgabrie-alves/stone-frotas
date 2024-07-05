using GerenciadorFrotas.Model;
using GerenciadorFrotas.Model.enums;
using GerenciadorFrotas.Utils;
using System;
using System.Data;
using System.Windows.Forms;

namespace GerenciadorFrotas.View.Controle
{
    public partial class frmSaida : Form
    {
        //Atributos
        Veiculo veiculo = new Veiculo();
        Modelo modelo = new Modelo();
        Marca marca = new Marca();
        Categoria categoria = new Categoria();
        Colaborador colaborador = new Colaborador();
        Model.Controle controle = new Model.Controle();

        //Construtor
        public frmSaida()
        {
            InitializeComponent();
        }

        //Metodos
        private void CarregarGrids()
        {
            CarregarGridVeiculos(-1, "");
            CarregarGridColaboradores();
        }

        private void CarregarGridVeiculos(int escolhaConsulta, string campoPesquisa)
        {
            try
            {
                grdVeiculos.DataSource = veiculo.Consultar(escolhaConsulta, campoPesquisa, StatusAtivoEnum.ATIVO, StatusAtividadeEnum.CONCLUIDO, StatusManutencaoEnum.TODOS);
                grdVeiculos.Columns[0].Visible = false;
                grdVeiculos.Columns[3].Visible = false;
                grdVeiculos.Columns[4].Visible = false;
                grdVeiculos.Columns[5].Visible = false;
                grdVeiculos.Columns[6].Visible = false;
                grdVeiculos.Columns[7].Visible = false;

                //Cabeçalho das colunas
                grdVeiculos.Columns[1].HeaderText = "Placa";
                grdVeiculos.Columns[2].HeaderText = "Chassi";
                grdVeiculos.Columns[8].HeaderText = "Modelo";
                grdVeiculos.Columns[9].HeaderText = "Marca";
                grdVeiculos.Columns[10].HeaderText = "Categoria";

                //Largura das colunas
                grdVeiculos.Columns[1].Width = 100;
                grdVeiculos.Columns[2].Width = 100;
                grdVeiculos.Columns[8].Width = 100;
                grdVeiculos.Columns[9].Width = 100;
                grdVeiculos.Columns[10].Width = 100;

            } catch (Exception ex)
            {
                MessageBox.Show("Erro-->" + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CarregarGridColaboradores()
        {
            try
            {
                grdColaboradores.DataSource = colaborador.Consultar(StatusAtividadeEnum.CONCLUIDO, StatusAtivoEnum.ATIVO);
                grdColaboradores.Columns[0].Visible = false;
                grdColaboradores.Columns[4].Visible = false;
                grdColaboradores.Columns[5].Visible = false;
                grdColaboradores.Columns[6].Visible = false;
                grdColaboradores.Columns[7].Visible = false;
                grdColaboradores.Columns[8].Visible = false;

                //Definindo Cabeçalhos
                grdColaboradores.Columns[1].HeaderText = "Nome";
                grdColaboradores.Columns[2].HeaderText = "CPF";
                grdColaboradores.Columns[3].HeaderText = "E-mail";


                grdColaboradores.Columns[1].Width = 200;
                grdColaboradores.Columns[2].Width = 100;
                grdColaboradores.Columns[3].Width = 200;
            } catch (Exception ex)
            {
                MessageBox.Show("Erro --> " + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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

        private void LimparCampos()
        {
            veiculo = new Veiculo();
            colaborador = new Colaborador();
            ApplicationUtils.LimparFormulario(this);
            CarregarGrids();
            GetFormDefault();
        }

        private void GetFormDefault()
        {
            rdbNome.Checked = true;
            rdbCPF.Checked = false;
            mskPesquisa.Mask = "";
            mskPesquisa.MaxLength = 100;
            mskPesquisa.Clear();

            rdbAtivo.Checked = false;
            rdbInativo.Checked = false;
            cboPesquisa.SelectedIndex = 0;
            txtPesquisa.Focus();
        }

        private void PreencherFormularioVeiculo()
        {
            txtPlaca.Text = veiculo.Placa;
            txtChassi.Text = veiculo.Chassi;
            txtQuilometragemInicial.Text = veiculo.QuilometragemInicial.ToString();
            txtQuilometragemAtual.Text = veiculo.QuilometragemAtual.ToString();
            rdbAtivo.Checked = veiculo.Ativo == true;
            rdbInativo.Checked = veiculo.Ativo == false;

            //Combobox
            modelo = new Modelo();
            modelo.Id = veiculo.ModeloId;
            modelo.Consultar();

            cboMarca.SelectedValue = Convert.ToInt32(modelo.MarcaId);
            cboCategoria.SelectedValue = Convert.ToInt32(modelo.CategoriaId);

            modelo = new Modelo();
            CarregarModelos();
            cboModelo.SelectedValue = Convert.ToInt32(veiculo.ModeloId);
        }

        private void PreencherFormularioColaboradores()
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

        private void CarregarDadosPesquisa()
        {
            DataTable dt = CriarDataTableDePesquisa();

            cboPesquisa.DataSource = dt;
            cboPesquisa.DisplayMember = "item";
            cboPesquisa.ValueMember = "id";
            cboPesquisa.SelectedIndex = 0;
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

        private void CarregarComboBox()
        {
            CarregarMarcas();
            CarregarCategorias();
            CarregarComboBoxStatus();
            CarregarComboBoxSexo();
        }

        private string ValidarPreenchimento()
        {
            string mensagemErro = string.Empty;

            if (veiculo.Id == 0)
            {
                mensagemErro = "Por favor, selecione um veículo. \n";
            }

            if (colaborador.Id == 0)
            {
                mensagemErro = "Por favor, selecione um colaborador. \n";
            }

            return mensagemErro;
        }

        private void PreencherClasse()
        {
            controle.DataSaida = DateTime.Now;
            controle.Concluido = false;
            controle.UsuarioId = DatabaseUtils.IdUsuarioLogado;
            controle.ColaboradorId = colaborador.Id;
            controle.VeiculoId = veiculo.Id;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            btnLiberar.Enabled = false;
        }

        private void btnLiberar_Click(object sender, EventArgs e)
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

                if (controle.VerificarPendencia())
                {
                    MessageBox.Show("O veículo ou colaborador já estão com um controle pendente.", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                controle.Gravar();

                MessageBox.Show("Registro feito com sucesso!", "Controle - Saída",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimparCampos();
                CarregarGrids();
            } catch (Exception ex)
            {
                MessageBox.Show("Erro-->" + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmSaida_Load(object sender, EventArgs e)
        {
            CarregarDadosPesquisa();
            CarregarGrids();
            CarregarComboBox();
        }

        private void grdVeiculos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdVeiculos.Rows.Count == 0)
            {
                return;
            }

            try
            {
                veiculo = new Veiculo();
                veiculo.Id = Convert.ToInt32(grdVeiculos.SelectedRows[0].Cells[0].Value);
                veiculo.Consultar(-1, "", StatusAtivoEnum.ATIVO, StatusAtividadeEnum.CONCLUIDO, StatusManutencaoEnum.TODOS);
                PreencherFormularioVeiculo();

                if (veiculo.Id != 0 && colaborador.Id != 0)
                {
                    btnLiberar.Enabled = true;
                }

            } catch (Exception ex)
            {
                MessageBox.Show("Erro-->" + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void grdColaboradores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdColaboradores.Rows.Count == 0)
            {
                return;
            }

            try
            {
                colaborador = new Colaborador();
                colaborador.Id = Convert.ToInt32(grdColaboradores.SelectedRows[0].Cells[0].Value);
                colaborador.Consultar(StatusAtividadeEnum.CONCLUIDO, StatusAtivoEnum.ATIVO);
                PreencherFormularioColaboradores();

                if (veiculo.Id != 0 && colaborador.Id != 0)
                {
                    btnLiberar.Enabled = true;
                }

            } catch (Exception ex)
            {
                MessageBox.Show("Erro-->" + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rdbNome_CheckedChanged(object sender, EventArgs e)
        {
            mskPesquisa.Mask = "";
            mskPesquisa.MaxLength = 100;
            mskPesquisa.Clear();
        }

        private void rdbCPF_CheckedChanged(object sender, EventArgs e)
        {
            mskPesquisa.Clear();
            mskPesquisa.Mask = "000,000,000-00";
        }

        private void mskPesquisa_TextChanged(object sender, EventArgs e)
        {
            colaborador = new Colaborador();

            if (rdbNome.Checked)
            {
                colaborador.Nome = mskPesquisa.Text;
                CarregarGridColaboradores();

            } else if (rdbCPF.Checked && mskPesquisa.Text.Length == 14)
            {
                colaborador.CPF = mskPesquisa.Text;
                CarregarGridColaboradores();
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
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
            CarregarGridVeiculos(escolhaPesquisa, campoPesquisa);
        }
    }
}
