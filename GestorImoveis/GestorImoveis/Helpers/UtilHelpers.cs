using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorImoveis.Helpers
{
    public class UtilHelpers
    {

        public static bool ConverterSimNao(string pTipo)
        {
            if (pTipo == "S")
                return true;
            else
                return false;
        }


        public static string ConverterSimNao(bool pTipo)
        {
            if (pTipo == true)
                return "S";
            else
                return "N";
        }


        public static TipoSituacao ConverterTipoSituacao(string ptipo)
        {
            switch (ptipo)
            {
                case "A":
                    return TipoSituacao.Ativo;
                case "I":
                    return TipoSituacao.Inativo;
                default: return TipoSituacao.Ativo;
            }
        }

        public static string ConverterTipoSituacao(TipoSituacao ptipo)
        {
            switch (ptipo)
            {
                case TipoSituacao.Ativo:
                    return "A";
                case TipoSituacao.Inativo:
                    return "I";
                default: return "A";
            }
        }
        public static bool ValidaCPF(string pCpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;
            pCpf = pCpf.Trim();
            pCpf = pCpf.Replace(".", "").Replace("-", "").Replace(",", "");
            if (pCpf.Length != 11)
                return false;

            tempCpf = pCpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return pCpf.EndsWith(digito);


        }

        public static bool ValidaData(DateTime pData)
        {
            if (pData <= DateTime.MinValue || pData >= DateTime.MaxValue)
                return false;

            return true;
        }



        public enum TipoSituacao
        {

            [Description("Ativo")]
            [DefaultValue("A")]
            Ativo = 'A',
            [Description("Inativo")]
            [DefaultValue("I")]
            Inativo = 'I',
        }

        public static void ApenasValorNumerico(object sender, KeyPressEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                if (e.KeyChar == ',')
                {
                    e.Handled = (txt.Text.Contains(','));
                }
                else
                    e.Handled = true;
            }
        }

        public static void RetornarMascaraMoeda(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (!string.IsNullOrEmpty(txt.Text))
                txt.Text = double.Parse(txt.Text).ToString("C2");
        }

        public static void TirarMascara(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            txt.Text = txt.Text.Replace("R$", "").Trim();
        }


        public static void RetornarMascaraCEP(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (!string.IsNullOrEmpty(txt.Text))
                txt.Text = double.Parse(txt.Text).ToString(@"00000-000");
        }

        public static void TirarMascaraCEP(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            txt.Text = txt.Text.Replace("-", "").Trim();

        }

        public static string ConverteData(DateTime pData)
        {
            string data = $"{pData.Day}/0{pData.Month}/{pData.Year}";
            return data;
        }

        public static bool IsAllDigits(string s)
        {
            foreach (char c in s)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }

        public static bool IsAllLetters(string s)
        {
            foreach (char c in s)
            {
                if (!Char.IsLetter(c))
                    return false;
            }
            return true;
        }
    }
}
