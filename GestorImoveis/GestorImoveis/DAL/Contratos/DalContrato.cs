using GestorImoveis.DAL.Context;
using GestorImoveis.DML;
using GestorImoveis.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorImoveis.DAL.Contratos
{
    public class DalContrato
    {
        #region Constantes

        private const string GI_SP_CONSULTACONTRATOS = "GI_SP_ConsultaContratos";

        private const string GI_SP_CONSULTIMOCODCONTRATOS = "GI_SP_ObterUltCodContrato";

        private const string GI_SP_INCCONTRATOS = "GI_SP_IncContratos";

        private const string GI_SP_VALEXISTCODCONTR = "GI_SP_ExisteCodContrato";

        private const string GI_SP_OBTERCONTRATO = "GI_SP_ObterContratos";

        private const string GI_SP_ATUALIZARCONTRATOS = "GI_SP_AlteraContratos";

        private const string GI_SP_CONSCONTRATOSBOL = "GI_SP_ConsulContratosBol";

        private const string GI_SP_INCLOGCONTRATOS = "GI_SP_IncLogContratos";

        private const string GI_SP_COUNTCONTRATOS = "GI_SP_CountContratos";

        #endregion



        public string ObterUltCodContratos()
        {
            string UltimoCodContr = "0";

            DbContext db = new DbContext();
            DataSet ds = db.ConsultaSQL(GI_SP_CONSULTIMOCODCONTRATOS, null);

            if (ds != null && ds.Tables != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    UltimoCodContr = row.Field<string>("CODCONTR") ?? "0";
                }
            }
            return UltimoCodContr;
        }

        public bool ValidaExistenciaCodContr(string pCodContr)
        {

            List<System.Data.SqlClient.SqlParameter> parametros = new List<System.Data.SqlClient.SqlParameter>();
            parametros.Add(new System.Data.SqlClient.SqlParameter("CODCONTR", pCodContr));

            DbContext db = new DbContext();
            DataSet ds = db.ConsultaSQL(GI_SP_VALEXISTCODCONTR, parametros);

            if (ds.Tables[0].Rows.Count > 0)
                return true;

            return false;
        }


        public void IncluirContrato(Contrato pContratos)
        {
            List<System.Data.SqlClient.SqlParameter> parametros = new List<System.Data.SqlClient.SqlParameter>();

            parametros.Add(new System.Data.SqlClient.SqlParameter("@CODCONTR", pContratos.Codigo));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@CEPCONTR", pContratos.End.Cep));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@ENDCONTR", pContratos.End.End));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@SITCONTR", pContratos.ConverterSitcontrato(pContratos.SituacaoContrato)));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@TIPOIMOVCONTR", pContratos.TipoImovel));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@NOMELOCASCONTR", pContratos.Locador));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@NOMELOCATCONTR", pContratos.Locatario));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@DTENTRADACONTR", pContratos.DataEntrada));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@QTAMESESCONTR", pContratos.QtaMeses));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@DTSAIDACONTR", pContratos.DataSaida));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@DIAPAGCONTR", pContratos.DiaPagamento));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@VALORCONTR", pContratos.Valor));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@VLRIPTUCONTR", pContratos.VlrIptu));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@DTCADCONTR", DateTime.Now));
            parametros.Add(new System.Data.SqlClient.SqlParameter("NUMIMOVCONTR", pContratos.End.NumeroImovel));
            parametros.Add(new System.Data.SqlClient.SqlParameter("BAIRROCONTR", pContratos.End.Bairro));
            parametros.Add(new System.Data.SqlClient.SqlParameter("CIDADECONTR", pContratos.End.Cidade));
            parametros.Add(new System.Data.SqlClient.SqlParameter("UFCONTR", pContratos.End.Uf));
            parametros.Add(new System.Data.SqlClient.SqlParameter("COMPLCONTR", pContratos.End.Complemento ?? string.Empty));
            parametros.Add(new System.Data.SqlClient.SqlParameter("COMPL2CONTR", pContratos.End.Complemento2 ?? string.Empty));

            DbContext db = new DbContext();
            db.ExecutaComandoSQL(GI_SP_INCCONTRATOS, parametros);

        }



        public void AtualizaContrato(Contrato pContratos)
        {
            List<System.Data.SqlClient.SqlParameter> parametros = new List<System.Data.SqlClient.SqlParameter>();

            parametros.Add(new System.Data.SqlClient.SqlParameter("@CODCONTR", pContratos.Codigo));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@CEPCONTR", pContratos.End.Cep));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@ENDCONTR", pContratos.End.End));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@SITCONTR", pContratos.ConverterSitcontrato(pContratos.SituacaoContrato)));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@TIPOIMOVCONTR", pContratos.TipoImovel));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@NOMELOCASCONTR", pContratos.Locador));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@NOMELOCATCONTR", pContratos.Locatario));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@DTENTRADACONTR", pContratos.DataEntrada));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@QTAMESESCONTR", pContratos.QtaMeses));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@DTSAIDACONTR", pContratos.DataSaida));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@DIAPAGCONTR", pContratos.DiaPagamento));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@VALORCONTR", pContratos.Valor));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@VLRIPTUCONTR", pContratos.VlrIptu));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@DTULTALTCONTR", DateTime.Now));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@NUMIMOVCONTR", pContratos.End.NumeroImovel));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@BAIRROCONTR", pContratos.End.Bairro));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@CIDADECONTR", pContratos.End.Cidade));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@UFCONTR", pContratos.End.Uf));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@COMPLCONTR", pContratos.End.Complemento ?? string.Empty));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@COMPL2CONTR", pContratos.End.Complemento2 ?? string.Empty));

            DbContext db = new DbContext();
            db.ExecutaComandoSQL(GI_SP_ATUALIZARCONTRATOS, parametros);
        }



        public List<Contrato> ConsultaContratos()
        {
            List<Contrato> lstcontrato = new List<Contrato>();

            DbContext db = new DbContext();
            DataSet ds = db.ConsultaSQL(GI_SP_CONSULTACONTRATOS, null);

            if (ds != null && ds.Tables != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {

                DataTable dt = ds.Tables[0];

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Contrato contrato = new Contrato();
                    contrato.End = new Endereco();

                    if (dt.Rows[i]["CODCONTR"] != DBNull.Value)
                        contrato.Codigo = Convert.ToString(dt.Rows[i]["CODCONTR"]);

                    if (dt.Rows[i]["SITCONTR"] != DBNull.Value)
                        contrato.SituacaoContrato = contrato.ConverterSitContratoDAL(dt.Rows[i]["SITCONTR"].ToString());

                    if (dt.Rows[i]["TIPOIMOVCONTR"] != DBNull.Value)
                        contrato.TipoImovel = dt.Rows[i]["TIPOIMOVCONTR"].ToString();

                    if (dt.Rows[i]["NOMELOCASCONTR"] != DBNull.Value)
                        contrato.Locador = Convert.ToString(dt.Rows[i]["NOMELOCASCONTR"]);

                    if (dt.Rows[i]["NOMELOCATCONTR"] != DBNull.Value)
                        contrato.Locatario = Convert.ToString(dt.Rows[i]["NOMELOCATCONTR"]);

                    if (dt.Rows[i]["QTAMESESCONTR"] != DBNull.Value)
                        contrato.QtaMeses = Convert.ToInt32(dt.Rows[i]["QTAMESESCONTR"]);

                    if (dt.Rows[i]["DTSAIDACONTR"] != DBNull.Value)
                        contrato.DataSaida = Convert.ToDateTime(dt.Rows[i]["DTSAIDACONTR"]);

                    if (dt.Rows[i]["DIAPAGCONTR"] != DBNull.Value)
                        contrato.DiaPagamento = Convert.ToInt32(dt.Rows[i]["DIAPAGCONTR"]);

                    if (dt.Rows[i]["VALORCONTR"] != DBNull.Value)
                        contrato.Valor = Convert.ToDouble(dt.Rows[i]["VALORCONTR"]);

                    lstcontrato.Add(contrato);
                }

            }

            return lstcontrato;
        }


        public List<Contrato> ObterContratos(string pParam, string pFiltro)
        {
            List<Contrato> lstcontrato = new List<Contrato>();

            List<System.Data.SqlClient.SqlParameter> parametros = new List<System.Data.SqlClient.SqlParameter>();
            parametros.Add(new System.Data.SqlClient.SqlParameter("FILTRO", pFiltro));
            parametros.Add(new System.Data.SqlClient.SqlParameter("VALOR", pParam));

            DbContext db = new DbContext();
            DataSet ds = db.ConsultaSQL(GI_SP_OBTERCONTRATO, parametros);

            if (ds != null && ds.Tables != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {

                DataTable dt = ds.Tables[0];

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Contrato contrato = new Contrato();
                    contrato.End = new Endereco();

                    if (dt.Rows[i]["CODCONTR"] != DBNull.Value)
                        contrato.Codigo = Convert.ToString(dt.Rows[i]["CODCONTR"]);

                    if (dt.Rows[i]["CEPCONTR"] != DBNull.Value)
                        contrato.End.Cep = Convert.ToString(dt.Rows[i]["CEPCONTR"]);

                    if (dt.Rows[i]["ENDCONTR"] != DBNull.Value)
                        contrato.End.End = Convert.ToString(dt.Rows[i]["ENDCONTR"]);

                    if (dt.Rows[i]["SITCONTR"] != DBNull.Value)
                        contrato.SituacaoContrato = contrato.ConverterSitContratoDAL(dt.Rows[i]["SITCONTR"].ToString());

                    if (dt.Rows[i]["TIPOIMOVCONTR"] != DBNull.Value)
                        contrato.TipoImovel = dt.Rows[i]["TIPOIMOVCONTR"].ToString();

                    if (dt.Rows[i]["NOMELOCASCONTR"] != DBNull.Value)
                        contrato.Locador = Convert.ToString(dt.Rows[i]["NOMELOCASCONTR"]);

                    if (dt.Rows[i]["NOMELOCATCONTR"] != DBNull.Value)
                        contrato.Locatario = Convert.ToString(dt.Rows[i]["NOMELOCATCONTR"]);

                    if (dt.Rows[i]["DTENTRADACONTR"] != DBNull.Value)
                        contrato.DataEntrada = Convert.ToDateTime(dt.Rows[i]["DTENTRADACONTR"]);

                    if (dt.Rows[i]["QTAMESESCONTR"] != DBNull.Value)
                        contrato.QtaMeses = Convert.ToInt32(dt.Rows[i]["QTAMESESCONTR"]);

                    if (dt.Rows[i]["DTSAIDACONTR"] != DBNull.Value)
                        contrato.DataSaida = Convert.ToDateTime(dt.Rows[i]["DTSAIDACONTR"]);

                    if (dt.Rows[i]["DIAPAGCONTR"] != DBNull.Value)
                        contrato.DiaPagamento = Convert.ToInt32(dt.Rows[i]["DIAPAGCONTR"]);

                    if (dt.Rows[i]["VALORCONTR"] != DBNull.Value)
                        contrato.Valor = Convert.ToDouble(dt.Rows[i]["VALORCONTR"]);

                    if (dt.Rows[i]["VLRIPTUCONTR"] != DBNull.Value)
                        contrato.VlrIptu = Convert.ToDouble(dt.Rows[i]["VLRIPTUCONTR"]);

                    if (dt.Rows[i]["NUMIMOVCONTR"] != DBNull.Value)
                        contrato.End.NumeroImovel = Convert.ToInt32(dt.Rows[i]["NUMIMOVCONTR"]);


                    if (dt.Rows[i]["BAIRROCONTR"] != DBNull.Value)
                        contrato.End.Bairro = Convert.ToString(dt.Rows[i]["BAIRROCONTR"]);


                    if (dt.Rows[i]["CIDADECONTR"] != DBNull.Value)
                        contrato.End.Cidade = Convert.ToString(dt.Rows[i]["CIDADECONTR"]);


                    if (dt.Rows[i]["UFCONTR"] != DBNull.Value)
                        contrato.End.Uf = Convert.ToString(dt.Rows[i]["UFCONTR"]);


                    if (dt.Rows[i]["COMPLCONTR"] != DBNull.Value)
                        contrato.End.Complemento = Convert.ToString(dt.Rows[i]["COMPLCONTR"]);


                    if (dt.Rows[i]["COMPL2CONTR"] != DBNull.Value)
                        contrato.End.Complemento2 = Convert.ToString(dt.Rows[i]["COMPL2CONTR"]);

                    lstcontrato.Add(contrato);
                }

            }

            return lstcontrato;
        }

        public List<string> ConsulContratos()
        {
            List<string> lstcontrato = new List<string>();

            DbContext db = new DbContext();
            DataSet ds = db.ConsultaSQL(GI_SP_CONSCONTRATOSBOL, null);

            if (ds != null && ds.Tables != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {

                DataTable dt = ds.Tables[0];

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Contrato contrato = new Contrato();
                    if (dt.Rows[i]["CODCONTR"] != DBNull.Value)
                        contrato.Codigo = Convert.ToString(dt.Rows[i]["CODCONTR"]);

                    lstcontrato.Add(contrato.Codigo);
                }
            }
            return lstcontrato;
        }

        public void GravarLogContrato(Contrato pContratos)
        {
            List<System.Data.SqlClient.SqlParameter> parametros = new List<System.Data.SqlClient.SqlParameter>();

            parametros.Add(new System.Data.SqlClient.SqlParameter("@LCCODCONTR", pContratos.Codigo));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@LCCEP", pContratos.End.Cep));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@LCEND", pContratos.End.End));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@LCSIT", pContratos.ConverterSitcontrato(pContratos.SituacaoContrato)));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@LCTPIMOV", pContratos.TipoImovel));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@LCNOMELOCAD", pContratos.Locador));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@LCNOMELOCAT", pContratos.Locatario));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@LCDTENTRADA", pContratos.DataEntrada));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@LCQTAMESES", pContratos.QtaMeses));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@LCDTSAIDA", pContratos.DataSaida));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@LCDIAPAG", pContratos.DiaPagamento));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@LCVALOR", pContratos.Valor));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@LCVLRIPTU", pContratos.VlrIptu));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@LCDTCAD", DateTime.Now));
            parametros.Add(new System.Data.SqlClient.SqlParameter("LCNUMIMOV", pContratos.End.NumeroImovel));
            parametros.Add(new System.Data.SqlClient.SqlParameter("LCBAIRRO", pContratos.End.Bairro));
            parametros.Add(new System.Data.SqlClient.SqlParameter("LCCIDADE", pContratos.End.Cidade));
            parametros.Add(new System.Data.SqlClient.SqlParameter("LCUF", pContratos.End.Uf));
            parametros.Add(new System.Data.SqlClient.SqlParameter("LCCOMPL", pContratos.End.Complemento ?? string.Empty));
            parametros.Add(new System.Data.SqlClient.SqlParameter("LCCOMPL2", pContratos.End.Complemento2 ?? string.Empty));

            DbContext db = new DbContext();
            db.ExecutaComandoSQL(GI_SP_INCLOGCONTRATOS, parametros);

        }

        public int CountContratos()
        {
            DbContext db = new DbContext();
            DataSet ds = db.ConsultaSQL(GI_SP_COUNTCONTRATOS, null);
            DataTable dt = ds.Tables[0];
            return Convert.ToInt32(dt.Rows[0]["QUANTIDADE"].ToString());
        }

    }
}
