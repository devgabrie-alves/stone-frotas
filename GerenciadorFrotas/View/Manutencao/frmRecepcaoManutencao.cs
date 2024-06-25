using GerenciadorFrotas.Model;
using GerenciadorFrotas.Model.enums;
using GerenciadorFrotas.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace GerenciadorFrotas.View.Manutencao
{
    public partial class frmRecepcaoManutencao : Form
    {
        //Atributos
        Model.Manutencao manutencao = new Model.Manutencao();
        Oficina oficina = new Oficina();
        Veiculo veiculo = new Veiculo();
        Modelo modelo = new Modelo();

        //Construtor
        public frmRecepcaoManutencao()
        {
            InitializeComponent();
        }

        //Atributos
        private void CarregarGrid()
        {
            try
            {
                grdDados.DataSource = manutencao.Consultar(StatusEnum.PENDENTE, veiculo, oficina);
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
                grdDados.Columns[3].HeaderText = "Oficina";


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

        private DataTable CriarDataTableDePesquisaOficina()
        {
            DataTable dataTable = new DataTable();
            DataColumn id = new DataColumn("id", typeof(int));
            DataColumn nome = new DataColumn("item", typeof(string));

            dataTable.Columns.Add(id);
            dataTable.Columns.Add(nome);

            //nome fantasia e cnpj
            DataRow nomeFantasia = dataTable.NewRow();
            nomeFantasia["id"] = 1;
            nomeFantasia["item"] = "Nome Fantasia";
            dataTable.Rows.Add(nomeFantasia);

            DataRow cnpj = dataTable.NewRow();
            cnpj["id"] = 2;
            cnpj["item"] = "CNPJ";
            dataTable.Rows.Add(cnpj);

            return dataTable;
        }

        private void CarregarDadosPesquisa()
        {
            DataTable dtVeiculo = CriarDataTableDePesquisaVeiculo();

            cboPesquisaVeiculo.DataSource = dtVeiculo;
            cboPesquisaVeiculo.DisplayMember = "item";
            cboPesquisaVeiculo.ValueMember = "id";
            cboPesquisaVeiculo.SelectedIndex = 0;

            DataTable dtColaborador = CriarDataTableDePesquisaOficina();

            cboPesquisaOficina.DataSource = dtColaborador;
            cboPesquisaOficina.DisplayMember = "item";
            cboPesquisaOficina.ValueMember = "id";
            cboPesquisaOficina.SelectedIndex = 0;
        }

        private void GetFormDefault()
        {
            cboPesquisaVeiculo.SelectedIndex = 0;
            cboPesquisaOficina.SelectedIndex = 0;
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
            veiculo.Id = manutencao.VeiculoId;
            veiculo.Consultar(-1, "", StatusVeiculoEnum.TODOS);
            veiculo.QuilometragemInicial = veiculo.QuilometragemAtual;
            veiculo.Ativo = true;

            manutencao.Concluido = true;
            manutencao.DataEntrada = DateTime.Now;
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

            txtRazaoSocial.Text = oficina.RazaoSocial;
            txtNomeFantasia.Text = oficina.NomeFantasia;
            mskCNPJ.Text = oficina.CNPJ;
            txtEmail.Text = oficina.Email;

            modelo = new Modelo();
            CarregarModelos();
            cboModelo.SelectedValue = Convert.ToInt32(veiculo.ModeloId);
        }


        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            manutencao = new Model.Manutencao();
            veiculo = new Veiculo();
            oficina = new Oficina();

            //veiculo
            if (Convert.ToInt32(cboPesquisaVeiculo.SelectedValue) == 1)
            {
                veiculo.Placa = txtPesquisaVeiculo.Text;

            } else if (Convert.ToInt32(cboPesquisaVeiculo.SelectedValue) == 2)
            {
                veiculo.Chassi = txtPesquisaVeiculo.Text;
            }

            //colaborador
            if (Convert.ToInt32(cboPesquisaOficina.SelectedValue) == 1)
            {
                oficina.NomeFantasia = mskPesquisaOficina.Text;

            } else if (Convert.ToInt32(cboPesquisaOficina.SelectedValue) == 2)
            {
                oficina.CNPJ = mskPesquisaOficina.Text;
            }

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

        private void frmRecepcaoManutencao_Load(object sender, EventArgs e)
        {
            CarregarDadosPesquisa();
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
                manutencao = new Model.Manutencao();
                manutencao.Id = Convert.ToInt32(grdDados.SelectedRows[0].Cells[0].Value);
                manutencao.Consultar(StatusEnum.PENDENTE, veiculo, oficina);
                PreencherFormulario();

                btnRecepcionar.Enabled = true;
            
            }catch (Exception ex)
            {
                MessageBox.Show("Erro-->" + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnRecepcionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (manutencao.Id == 0)
                {
                    MessageBox.Show("Selecione um registro de manutenção.", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                PreencherClasse();

                using (TransactionScope transacao = new TransactionScope())
                {
                    manutencao.Gravar();
                    veiculo.Gravar();

                    transacao.Complete();
                }

                MessageBox.Show("Registro feito com sucesso!", "Manutenção - Recepção",
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
