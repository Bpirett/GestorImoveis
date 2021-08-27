using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorImoveis.DML
{
    public class Boleto
    {
        public string Codigo { get; set; }
        public string CodContrato { get; set; }
        public string NumBoleto { get; set; }
        public string Locatario { get; set; }
        public string Locador { get; set; }
        public string TipoImovel { get; set; }
        public double Valor { get; set; }
        public string Endereco { get; set; }
        public DateTime DataVencimento { get; set; }
        public double JrMulta { get; set; }
        public double VlrMulta { get; set; }
        public double VlrIptu { get; set; }
        public double JrDesconto { get; set; }
        public double VlrDesconto { get; set; }
        public PagamentoBoleto PagBoleto { get; set; }
        public DateTime DataPagamento { get; set; }
        public double JrComissao { get; set; }
        public double VlrComissao { get; set; }
        public DateTime PeriodoInicio { get; set; }
        public DateTime PeriodoFim { get; set; }



        public enum PagamentoBoleto
        {
            P,
            N,
        }


        public PagamentoBoleto ConverterPagBoleto(string pPagouBol)
        {
            if (pPagouBol == "P")
                return PagamentoBoleto.P;
            else
                return PagamentoBoleto.N;

        }

        public string ConverterPagBoleto(PagamentoBoleto pSitContrato)
        {

            if (PagamentoBoleto.P == pSitContrato)
                return "P";
            else
                return "N";
        }
    }
}
