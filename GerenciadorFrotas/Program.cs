using GerenciadorFrotas.Utils;
using GerenciadorFrotas.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorFrotas
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            DatabaseUtils.LerAppConfig();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            frmLogin form = new frmLogin();
            form.ShowDialog();

            if (form.DialogResult == DialogResult.OK)
            {
                Application.Run(new frmPrincipal());
            }
        }
    }
}
