using GestorImoveis.DAL.Anuncio;
using GestorImoveis.DML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorImoveis.BLL
{
    public class BoAnuncio
    {
        public string ObterUltCodAnuncio(string pTipoNeg)
        {
            DalAnuncio dalAnuncio = new DalAnuncio();
            return dalAnuncio.ObterUltCodAnuncios(pTipoNeg);

        }

        public List<Anuncio> ConsultaAnuncio()
        {
            DalAnuncio dalAnuncio = new DalAnuncio();
            return dalAnuncio.ConsultaAnuncios();
        }

        public void IncluirAnuncio(Anuncio pAnuncio)
        {
            DalAnuncio dalAnuncio = new DalAnuncio();
            dalAnuncio.IncluirAnuncio(pAnuncio);
        }

        public void AtualizarAnuncio(Anuncio pAnuncio)
        {
            DalAnuncio dalAnuncio = new DalAnuncio();
            dalAnuncio.AtualizaAnuncio(pAnuncio);
        }

        public List<Anuncio> ObterAnuncio(string pParam)
        {
            DalAnuncio dalAnuncio = new DalAnuncio();

            return dalAnuncio.ObterAnuncio(pParam);
        }

        public void DeleteAnuncio(string pParam)
        {
            DalAnuncio dalAnuncio = new DalAnuncio();
            dalAnuncio.DeleteAnuncio(pParam);
        }

        public List<Anuncio> PesqContrato(string pParam, string pFiltro)
        {
            DalAnuncio dalAnuncio = new DalAnuncio();

            return dalAnuncio.PesqAnuncio(pParam, pFiltro);
        }

        public string GeraCodigoSequencial(string pTipoNeg, string pTpDigito)
        {
            DalAnuncio dalAnuncio = new DalAnuncio();
            double contador = 0;
            string MontarCodigo = string.Empty;

            string UltCodAnuncio = ObterUltCodAnuncio(pTipoNeg);

            if (string.IsNullOrEmpty(UltCodAnuncio))
                contador++;
            else
            {
                contador = Convert.ToDouble(UltCodAnuncio.Substring(1, 3));
                contador++;
            }

            MontarCodigo = "#" + contador.ToString("000") + pTpDigito;

            while (dalAnuncio.ValidaExistenciaCodAnuncio(MontarCodigo))
            {
                contador++;
                MontarCodigo = "#" + contador.ToString("000") + pTpDigito;
            }

            return MontarCodigo;
        }


    }
}
