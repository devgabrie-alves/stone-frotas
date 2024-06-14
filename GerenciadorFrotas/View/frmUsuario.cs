using GerenciadorFrotas.Model;
using GerenciadorFrotas.Utils;
using System;
using System.Net.Http.Headers;
using System.Windows.Forms;

namespace GerenciadorFrotas.View
{
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
        }

        //Atributos
        Usuario usuario = new Usuario();

        //Métodos
        private void btnCancelar_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, System.EventArgs e)
        {
            usuario = new Usuario();
            ApplicationUtils.LimparFormulario(this);
            rdpNao.Checked = true;
        }

        private void CarregarGridUsuario()
        {
            try
            {
                grdDados.DataSource = usuario.Consultar();
                grdDados.Columns[0].Visible = false;
                grdDados.Columns[4].Visible = false;
                grdDados.Columns[5].Visible = false;
                //Cabeçalho das colunas
                grdDados.Columns[1].HeaderText = "Usuário";
                grdDados.Columns[2].HeaderText = "Nome";
                grdDados.Columns[2].HeaderText = "E-mail";
                //Largura das colunas
                grdDados.Columns[1].Width = 100;
                grdDados.Columns[2].Width = 250;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro-->" + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            CarregarGridUsuario();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            usuario = new Usuario();
            usuario.Nome = txtPesquisa.Text;
            CarregarGridUsuario();
        }

        private void grdDados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                usuario = new Usuario();
                usuario.Id = Convert.ToInt32(grdDados.SelectedRows[0].Cells[0].Value);
                usuario.Consultar();
                //PreencherFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro-->" + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
