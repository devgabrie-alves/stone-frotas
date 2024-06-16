    using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorFrotas.Utils
{
    public static class ApplicationUtils
    {
        public static string Criptografar(string senha)
        {
            Byte[] original;
            Byte[] criptografado;
            MD5 md5 = new MD5CryptoServiceProvider();
            original = ASCIIEncoding.Default.GetBytes(senha);
            criptografado = md5.ComputeHash(original);

            return Regex.Replace(BitConverter.ToString(criptografado), "-", "").ToLower();
        }

        public static bool SomenteNumeros(char tecla)
        {
            if ((!char.IsDigit(tecla) && tecla != (char)Keys.Back))
            {
                return true;
            }
            return false;
        }

        public static void LimparFormulario(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = String.Empty;
                }

                if (c is ComboBox)
                {
                    ((ComboBox)c).SelectedIndex = -1;
                }

                if (c.Controls.Count > 0)
                {
                    LimparFormulario(c);
                }
            }
        }

    }
}
