using GerenciadorFrotas.Model;
using GerenciadorFrotas.Utils;
using System;
using System.Data;
using System.Reflection;
using System.Text.RegularExpressions;
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
                grdVeiculos.DataSource = veiculo.Consultar(escolhaConsulta, campoPesquisa);
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

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro-->" + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CarregarGridColaboradores()
        {
            try
            {
                grdColaboradores.DataSource = colaborador.Consultar();
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
            }
            catch (Exception ex)
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
            ApplicationUtils.LimparFormulario(this);
            CarregarGrids();
            GetFormDefault();
        }

        private void GetFormDefault()
        {
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnLiberar_Click(object sender, EventArgs e)
        {
            
        }

        private void frmSaida_Load(object sender, EventArgs e)
        {
            CarregarDadosPesquisa();
            CarregarGrids();
            CarregarComboBox();
        }

        private void grdVeiculos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            veiculo = new Veiculo();
            veiculo.Id = Convert.ToInt32(grdVeiculos.SelectedRows[0].Cells[0].Value);
            veiculo.Consultar(-1, "");
            PreencherFormularioVeiculo();
        }

        private void grdColaboradores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            colaborador = new Colaborador();
            colaborador.Id = Convert.ToInt32(grdColaboradores.SelectedRows[0].Cells[0].Value);
            colaborador.Consultar();
            PreencherFormularioColaboradores();
        }
    }
}
