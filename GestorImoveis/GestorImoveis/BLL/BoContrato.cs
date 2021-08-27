using GestorImoveis.DAL.Contratos;
using GestorImoveis.DML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorImoveis.BLL
{
    public class BoContrato
    {

        public List<string> ObterLocador(int pCod)
        {
            DalContrato dalContrato = new DalContrato();

             var lista = dalContrato.ObterLocador(pCod);

            return lista;

        }

        public List<string> ObterLocatario(int pCod)
        {
            DalContrato dalContrato = new DalContrato();

            var lista = dalContrato.ObterLocatario(pCod);


            return lista;
        }


        public List<Contrato> ConsultaContratos()
        {
            DalContrato dalContrato = new DalContrato();

            return dalContrato.ConsultaContratos();
        }

        public List<string> ConsulContratos()
        {
            DalContrato dalContrato = new DalContrato();

            return dalContrato.ConsulContratos();
        }

        public string ObterUltCodContrato()
        {
            double UltCodCod;
            int i = 1;
            try
            {
                DalContrato dalContrato = new DalContrato();
                UltCodCod = Convert.ToDouble(dalContrato.ObterUltCodContratos());
                UltCodCod += i;

                while (dalContrato.ValidaExistenciaCodContr(UltCodCod.ToString()))
                {
                    UltCodCod += i++;
                }
            }
            catch (Exception ex)
            {

                throw;
            }


            return UltCodCod.ToString().PadLeft(3,'0');

        }


        public void IncluirContrato(Contrato pContrato)
        {
            DalContrato dalContrato = new DalContrato();
            dalContrato.IncluirContrato(pContrato);
        }

        public void AtualizarContrato(Contrato pContrato)
        {
            DalContrato dalContrato = new DalContrato();
            dalContrato.AtualizaContrato(pContrato);
        }

        public List<Contrato> ObterContrato(string pParam, string pFiltro)
        {
            DalContrato dalContrato = new DalContrato();

            return dalContrato.ObterContratos(pParam, pFiltro);
        }

        public void GravarLogContrato(Contrato pContrato)
        {
            DalContrato dalContrato = new DalContrato();
            dalContrato.GravarLogContrato(pContrato);
        }


    }
}
