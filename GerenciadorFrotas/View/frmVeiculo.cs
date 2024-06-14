using GerenciadorFrotas.Model;
using System.Windows.Forms;

namespace GerenciadorFrotas.View
{
    public partial class frmVeiculo : Form
    {
        //Atributos
        Veiculo veiculo = new Veiculo();

        //Construtor
        public frmVeiculo()
        {
            InitializeComponent();
        }

        //Metodos
        private void txtPesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void grdDados_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Tab)
            {
                MessageBox.Show("teste", "teste",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
