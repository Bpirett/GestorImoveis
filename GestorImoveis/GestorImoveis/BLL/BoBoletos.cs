using GestorImoveis.DAL.Boletos;
using GestorImoveis.DML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorImoveis.BLL
{
    public class BoBoletos
    {

        public void IncluirBoleto(List<Boleto> pBoleto)
        {
            DalBoleto dalBoleto = new DalBoleto();
            dalBoleto.IncluirBoleto(pBoleto);
        }

        public List<Boleto> ConsultaBoleto(string pCodContrato)
        {
            DalBoleto dalBoleto = new DalBoleto();
            return dalBoleto.ConsulBoletos(pCodContrato);
        }

        public string ObterUltCodBoleto()
        {
            double UltCodCod;
            int i = 1;
            try
            {
                DalBoleto dalBoleto = new DalBoleto();
                UltCodCod = Convert.ToDouble(dalBoleto.ObterUltCodBoleto());

                UltCodCod += i;

                while (dalBoleto.ValidaExistenciaCodBol(UltCodCod.ToString()))
                {
                    UltCodCod += i++;
                }
            }
            catch (Exception ex)
            {

                throw;
            }

            return UltCodCod.ToString().PadLeft(3, '0');
        }

        public List<Boleto> ObterBoleto(string pCodContrato, string pCodBoleto, string pNumBoleto)
        {
            DalBoleto dalBoleto = new DalBoleto();
            return dalBoleto.ObterBoleto(pCodContrato,pCodBoleto,pNumBoleto);
        }

        public List<Boleto> ObterBoletoRel(string pCodContrato, string pCodBoleto, string pNumBoleto)
        {
            DalBoleto dalBoleto = new DalBoleto();
            return dalBoleto.ObterBoletoRel(pCodContrato, pCodBoleto, pNumBoleto);
        }

        public void AlterarBoleto(Boleto pBoleto)
        {
            DalBoleto dalBoleto = new DalBoleto();
            dalBoleto.AlterarBoleto(pBoleto);
        }

        public void PagarBoleto(string pCodContrato, string pCodBoleto, string pNumBoleto)
        {
            DalBoleto dalBoleto = new DalBoleto();
            dalBoleto.PagarBoleto(pCodContrato, pCodBoleto, pNumBoleto);
        }

        public bool ValidaBoletoPago(string pCodContrato, string pCodBoleto, string pNumBoleto)
        {
            DalBoleto dalBoleto = new DalBoleto();
            return dalBoleto.ValidaBoletoPago(pCodContrato, pCodBoleto, pNumBoleto);
        }


    }
}
