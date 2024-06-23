using GerenciadorFrotas.Model.enums;
using GerenciadorFrotas.Model;
using GerenciadorFrotas.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorFrotas.View.Controle
{
    public partial class frmConsultaControle : Form
    {
        //Atributos
        Model.Controle controle = new Model.Controle();
        Veiculo veiculo = new Veiculo();
        Colaborador colaborador = new Colaborador();

        //Construtor
        public frmConsultaControle()
        {
            InitializeComponent();
        }

        //Metodos
        private void CarregarGrid(int escolha)
        {
            try
            {
                grdDados.DataSource = controle.Consultar(getStatusByRadioButton(escolha), veiculo, colaborador);
                grdDados.Columns[0].Visible = false;
                grdDados.Columns[7].Visible = false;
                grdDados.Columns[8].Visible = false;
                grdDados.Columns[9].Visible = false;
                grdDados.Columns[12].Visible = false;

                //Definindo Cabeçalhos
                grdDados.Columns[1].HeaderText = "Data Saída";
                grdDados.Columns[2].HeaderText = "Veículo";
                grdDados.Columns[3].HeaderText = "Colaborador";
                grdDados.Columns[4].HeaderText = "Data Entrada";
                grdDados.Columns[5].HeaderText = "Km's Rodados";
                grdDados.Columns[6].HeaderText = "Concluído";
                grdDados.Columns[10].HeaderText = "Placa";
                grdDados.Columns[11].HeaderText = "Chassi";
                grdDados.Columns[13].HeaderText = "Nome Colaborador";
                grdDados.Columns[14].HeaderText = "CPF Colaborador";
                grdDados.Columns[15].HeaderText = "Celular Colaborador";

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

        private void LimparCampos()
        {
            veiculo = new Veiculo();
            ApplicationUtils.LimparFormulario(this);
            CarregarGrid(0);
        }

        private StatusEnum getStatusByRadioButton(int radioButton)
        {
            if (radioButton == 1)
            {
                return StatusEnum.CONCLUIDO;
            
            }else if (radioButton == 2)
            {
                return StatusEnum.PENDENTE;
            }

            return StatusEnum.TODOS; 

        }

        private void frmConsultaControle_Load(object sender, EventArgs e)
        {
            CarregarDadosPesquisa();
            CarregarGrid(0);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (grdDados.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.ApplicationClass MExcel = new Microsoft.Office.Interop.Excel.ApplicationClass();
                MExcel.Application.Workbooks.Add(Type.Missing);
                for (int i = 1; i < grdDados.Columns.Count + 1; i++)
                {
                    MExcel.Cells[1, i] = grdDados.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < grdDados.Rows.Count; i++)
                {
                    for (int j = 0; j < grdDados.Columns.Count; j++)
                    {
                        MExcel.Cells[i + 2, j + 1] = grdDados.Rows[i].Cells[j].Value.ToString();
                    }
                }
                MExcel.Columns.AutoFit();
                MExcel.Rows.AutoFit();
                MExcel.Columns.Font.Size = 12;
                MExcel.Visible = true;
            } else
            {
                MessageBox.Show("Não há dados para exportar!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            controle = new Model.Controle();
            veiculo = new Veiculo();
            colaborador = new Colaborador();
            int radioButton = 0;

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

            //radioButton
            if(rdbConcluido.Checked)
            {
                radioButton = 1;
            
            }else if (rdbPendente.Checked)
            {
                radioButton = 2;
            }


            CarregarGrid(radioButton);
        }
    }
}
