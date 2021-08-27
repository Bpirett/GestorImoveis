using GestorImoveis.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorImoveis.DML
{
    public class Contrato
    {
        public string Codigo { get; set; }
        public string Locatario { get; set; }
        public string Locador { get; set; }
        public double Valor { get; set; }
        public int DiaPagamento { get; set; }
        public DateTime DataEntrada { get; set; }

        public DateTime DataSaida { get; set; }

        public int QtaMeses { get; set; }

        public double VlrIptu { get; set; }
        public string TipoImovel { get; set; }
        public Situacaocontrato SituacaoContrato { get; set; }
        public List<Boleto> Boletos { get; set; }
        public Endereco End { get; set; }

        public enum Situacaocontrato
        {
            Andamento,
            Cancelado,
            Renovado,
            Finalizado
        }

        public Situacaocontrato ConverterSitcontrato(string pSitContrato)
        {
            switch (pSitContrato)
            {
                case "Finalizado":
                    return Situacaocontrato.Finalizado;
                case "Cancelado":
                    return Situacaocontrato.Cancelado;
                case "Renovado":
                    return Situacaocontrato.Renovado;
                default:
                    return Situacaocontrato.Andamento;
            }

        }

        public string ConverterSitcontrato(Situacaocontrato pSitContrato)
        {
            switch (pSitContrato)
            {
                case Situacaocontrato.Finalizado:
                    return "FIN";
                case Situacaocontrato.Cancelado:
                    return "CAN";
                case Situacaocontrato.Renovado:
                    return "REN";
                default:
                    return "AND";
            }

        }

        public Situacaocontrato ConverterSitContratoDAL(string pSitContrato)
        {
            switch (pSitContrato)
            {
                case "FIN":
                    return Situacaocontrato.Finalizado;
                case "CAN":
                    return Situacaocontrato.Cancelado;
                case "REN":
                    return Situacaocontrato.Renovado;
                default:
                    return Situacaocontrato.Andamento;
            }

        }
    }
}
