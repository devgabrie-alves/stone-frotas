using GerenciadorFrotas.Model;
using GerenciadorFrotas.Model.enums;
using GerenciadorFrotas.Utils;
using System;
using System.Data;
using System.Transactions;
using System.Windows.Forms;

namespace GerenciadorFrotas.View.Controle
{
    public partial class frmEntrada : Form
    {
        //Atributos
        Model.Controle controle = new Model.Controle();
        Veiculo veiculo = new Veiculo();
        Modelo modelo = new Modelo();
        Colaborador colaborador = new Colaborador();

        //Construtor
        public frmEntrada()
        {
            InitializeComponent();
        }

        //Metodos
        private void CarregarGrid()
        {
            try
            {
                grdDados.DataSource = controle.Consultar(StatusEnum.PENDENTE, veiculo, colaborador);
                grdDados.Columns[0].Visible = false;
                grdDados.Columns[4].Visible = false;
                grdDados.Columns[5].Visible = false;
                grdDados.Columns[6].Visible = false;
                grdDados.Columns[7].Visible = false;
                grdDados.Columns[8].Visible = false;
                grdDados.Columns[9].Visible = false;
                grdDados.Columns[10].Visible = false;
                grdDados.Columns[11].Visible = false;
                grdDados.Columns[12].Visible = false;
                grdDados.Columns[13].Visible = false;
                grdDados.Columns[14].Visible = false;
                grdDados.Columns[15].Visible = false;

                //Definindo Cabeçalhos
                grdDados.Columns[1].HeaderText = "Data Saída";
                grdDados.Columns[2].HeaderText = "Veículo";
                grdDados.Columns[3].HeaderText = "Colaborador";


                grdDados.Columns[1].Width = 100;
                grdDados.Columns[2].Width = 200;
                grdDados.Columns[3].Width = 230;
            } catch (Exception ex)
            {
                MessageBox.Show("Erro --> " + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DataTable CriarDataTableDePesquisaVeiculo()
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

            return dataTable;
        }

        private DataTable CriarDataTableDePesquisaColaborador()
        {
            DataTable dataTable = new DataTable();
            DataColumn id = new DataColumn("id", typeof(int));
            DataColumn nome = new DataColumn("item", typeof(string));

            dataTable.Columns.Add(id);
            dataTable.Columns.Add(nome);

            //nome e cpf
            DataRow nomeColaborador = dataTable.NewRow();
            nomeColaborador["id"] = 1;
            nomeColaborador["item"] = "Nome";
            dataTable.Rows.Add(nomeColaborador);

            DataRow cpf = dataTable.NewRow();
            cpf["id"] = 2;
            cpf["item"] = "CPF";
            dataTable.Rows.Add(cpf);

            return dataTable;
        }

        private void CarregarDadosPesquisa()
        {
            DataTable dtVeiculo = CriarDataTableDePesquisaVeiculo();

            cboPesquisaVeiculo.DataSource = dtVeiculo;
            cboPesquisaVeiculo.DisplayMember = "item";
            cboPesquisaVeiculo.ValueMember = "id";
            cboPesquisaVeiculo.SelectedIndex = 0;

            DataTable dtColaborador = CriarDataTableDePesquisaColaborador();

            cboPesquisaColaborador.DataSource = dtColaborador;
            cboPesquisaColaborador.DisplayMember = "item";
            cboPesquisaColaborador.ValueMember = "id";
            cboPesquisaColaborador.SelectedIndex = 0;
        }

        private void GetFormDefault()
        {
            cboPesquisaVeiculo.SelectedIndex = 0;
            cboPesquisaColaborador.SelectedIndex = 0;
            btnRecepcionar.Enabled = false;
        }

        private void LimparCampos()
        {
            veiculo = new Veiculo();
            ApplicationUtils.LimparFormulario(this);
            CarregarGrid();
            GetFormDefault();
        }

        private void PreencherClasse()
        {
            veiculo = new Veiculo();
            veiculo.Id = controle.VeiculoId;
            veiculo.Consultar(-1, "", StatusVeiculoEnum.TODOS);

            controle.Concluido = true;
            controle.DataEntrada = DateTime.Now;
            controle.UsuarioId = DatabaseUtils.IdUsuarioLogado;
        }

        private void CarregarModelos()
        {

            //Busca informações
            cboModelo.DataSource = modelo.Consultar();
            cboModelo.DisplayMember = "nomeAno";
            cboModelo.ValueMember = "id";
            cboModelo.SelectedIndex = -1;
        }

        private void PreencherFormulario()
        {
            txtPlaca.Text = veiculo.Placa;
            txtChassi.Text = veiculo.Chassi;

            txtNome.Text = colaborador.Nome;
            mskCPF.Text = colaborador.CPF;
            mskCelular.Text = colaborador.Celular;

            modelo = new Modelo();
            CarregarModelos();
            cboModelo.SelectedValue = Convert.ToInt32(veiculo.ModeloId);
        }

        private void frmEntrada_Load(object sender, EventArgs e)
        {
            CarregarDadosPesquisa();
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

        private void grdDados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdDados.Rows.Count == 0)
            {
                return;
            }

            try
            {
                controle = new Model.Controle();
                controle.Id = Convert.ToInt32(grdDados.SelectedRows[0].Cells[0].Value);
                controle.Consultar(StatusEnum.PENDENTE, veiculo, colaborador);
                PreencherFormulario();

                btnRecepcionar.Enabled = true;
            
            }catch (Exception ex)
            {
                MessageBox.Show("Erro-->" + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            controle = new Model.Controle();
            veiculo = new Veiculo();
            colaborador = new Colaborador();

            //veiculo
            if (Convert.ToInt32(cboPesquisaVeiculo.SelectedValue) == 1)
            {
                veiculo.Placa = txtPesquisaVeiculo.Text;

            } else if (Convert.ToInt32(cboPesquisaVeiculo.SelectedValue) == 2)
            {
                veiculo.Chassi = txtPesquisaVeiculo.Text;
            }

            //colaborador
            if (Convert.ToInt32(cboPesquisaColaborador.SelectedValue) == 1)
            {
                colaborador.Nome = mskPesquisaColaborador.Text;

            } else if (Convert.ToInt32(cboPesquisaColaborador.SelectedValue) == 2)
            {
                colaborador.CPF = mskPesquisaColaborador.Text;
            }

            CarregarGrid();
        }

        private void btnRecepcionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (controle.Id == 0)
                {
                    MessageBox.Show("Selecione um registro de controle.", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (txtQuilometragem.Text == string.Empty)
                {
                    MessageBox.Show("O campo QUILOMETRAGEM ATUAL não pode ser vazio.", "Erro de Preenchimento",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                PreencherClasse();

                if (Convert.ToInt32(txtQuilometragem.Text) < veiculo.QuilometragemAtual)
                {
                    MessageBox.Show("A quilometragem não pode ser menor que a atual do veículo.", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                controle.TotalPercorrido = (Convert.ToInt32(txtQuilometragem.Text) - veiculo.QuilometragemAtual);
                veiculo.QuilometragemAtual += controle.TotalPercorrido;
                veiculo.Ativo = true;

                using (TransactionScope transacao = new TransactionScope())
                {
                    controle.Gravar();
                    veiculo.Gravar();

                    transacao.Complete();
                }

                MessageBox.Show("Registro feito com sucesso!", "Controle - Entrada",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                int quilometrosRodadosPosManutencao = 0;
                quilometrosRodadosPosManutencao = veiculo.QuilometragemAtual - veiculo.QuilometragemInicial;

                if (quilometrosRodadosPosManutencao > 5000)
                {
                    MessageBox.Show("Este veículo passou dos 5000 km's rodados e precisa de uma manutenção!", "Controle - Entrada",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                LimparCampos();
                CarregarGrid();
            } catch (Exception ex)
            {
                MessageBox.Show("Erro-->" + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtQuilometragem_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ApplicationUtils.SomenteNumeros(e.KeyChar);
        }
    }
}
