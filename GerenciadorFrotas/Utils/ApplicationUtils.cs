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

                if (c is MaskedTextBox)
                {
                    ((MaskedTextBox)c).Text = String.Empty;
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

        public static bool IsCpfValido(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;

            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");
            if (cpf.Length != 11)
            
            {
                return false;
            }
            
            tempCpf = cpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
            {
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            }

            resto = soma % 11;
            
            if (resto < 2)
            {
                resto = 0;
            }
            else
            {
                resto = 11 - resto;
            }
            
            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            
            for (int i = 0; i < 10; i++)
            {
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            }

            resto = soma % 11;
            if (resto < 2)
            {
                resto = 0;
            }
            else
            {
                resto = 11 - resto;
            }

            digito = digito + resto.ToString();

            return cpf.EndsWith(digito);
        }

        public static bool IsCnpjValido(string cnpj)
        {
            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma;
            int resto;
            string digito;
            string tempCnpj;

            cnpj = cnpj.Trim();
            cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "");
            
            if (cnpj.Length != 14)
            {
                return false;
            }

            tempCnpj = cnpj.Substring(0, 12);
            soma = 0;
            
            for (int i = 0; i < 12; i++)
            {
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];
            }

            resto = (soma % 11);
            
            if (resto < 2)
            {
                resto = 0;
            }
            else
            {
                resto = 11 - resto;
            }

            digito = resto.ToString();
            tempCnpj = tempCnpj + digito;
            soma = 0;
            for (int i = 0; i < 13; i++)
            {
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];
            }

            resto = (soma % 11);
            if (resto < 2)
            {
                resto = 0;
            }
            else
            {
                resto = 11 - resto;
            }
            
            digito = digito + resto.ToString();

            return cnpj.EndsWith(digito);
        }

    }
}
