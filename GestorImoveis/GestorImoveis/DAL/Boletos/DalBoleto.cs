using GestorImoveis.DAL.Context;
using GestorImoveis.DML;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace GestorImoveis.DAL.Boletos
{
    public class DalBoleto
    {

        #region Constantes

        private const string GI_SP_CONSULTIMOCODBOLETOS = "GI_SP_ConsultUlmCodBoleto";

        private const string GI_SP_VALEXISTCODBOL = "GI_SP_ValExisteCodBol";

        private const string GI_SP_INCBOLETOS = "GI_SP_INCBOLETOS";

        private const string GI_SP_CONSULTOBOLETOS = "GI_SP_CONSULTOBOLETOS";

        private const string GI_SP_OBTERBOLETO = "GI_SP_OBTERBOLETO";

        private const string GI_SP_ALTBOLETOS = "GI_SP_ALTBOLETOS";

        private const string GI_SP_PAGARBOLETO = "GI_SP_PAGARBOLETO";

        private const string GI_SP_VALIDABOLETOPAGO = "GI_SP_ValidaBoletoPago";

        private const string GI_SP_OBTERBOLETOREL = "GI_SP_ObterBoletoRel";

        private const string GI_SP_CONSULVALORRECEBER = "GI_SP_ConsultValorReceberMes";

        private const string GI_SP_CONSULVALORADMRECEBER = "GI_SP_ConsultValorAdmReceberMes";

        private const string GI_SP_BOLETOSVENCER = "GI_SP_BoletosVencer";

        #endregion


        public string ObterUltCodBoleto()
        {
            string UltimoCodBoleto = "0";

            DbContext db = new DbContext();
            DataSet ds = db.ConsultaSQL(GI_SP_CONSULTIMOCODBOLETOS, null);

            if (ds != null && ds.Tables != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    UltimoCodBoleto = row.Field<string>("CODBOL") ?? "0";
                }
            }
            return UltimoCodBoleto;
        }


        public bool ValidaExistenciaCodBol(string pCodBol)
        {

            List<System.Data.SqlClient.SqlParameter> parametros = new List<System.Data.SqlClient.SqlParameter>();
            parametros.Add(new System.Data.SqlClient.SqlParameter("CODBOL", pCodBol));

            DbContext db = new DbContext();
            DataSet ds = db.ConsultaSQL(GI_SP_VALEXISTCODBOL, parametros);

            if (ds.Tables[0].Rows.Count > 0)
                return true;

            return false;
        }


        public void IncluirBoleto(List<Boleto> pBoleto)
        {

            DbContext db = new DbContext();
            foreach (var Boleto in pBoleto.OrderBy(p => p.DataVencimento))
            {
                List<System.Data.SqlClient.SqlParameter> parametros = new List<System.Data.SqlClient.SqlParameter>();
                parametros.Add(new System.Data.SqlClient.SqlParameter("@CODBOL", Boleto.Codigo));
                parametros.Add(new System.Data.SqlClient.SqlParameter("@CODCONTRBOL", Boleto.CodContrato));
                parametros.Add(new System.Data.SqlClient.SqlParameter("@NUMBOL", Boleto.NumBoleto));
                parametros.Add(new System.Data.SqlClient.SqlParameter("@ENDERBOL", Boleto.Endereco));
                parametros.Add(new System.Data.SqlClient.SqlParameter("@NOMELOCADBOL", Boleto.Locador));
                parametros.Add(new System.Data.SqlClient.SqlParameter("@NOMELOCATBOL", Boleto.Locatario));
                parametros.Add(new System.Data.SqlClient.SqlParameter("@JRMULBOL", Boleto.JrMulta));
                parametros.Add(new System.Data.SqlClient.SqlParameter("@VLRBOL", Boleto.Valor));
                parametros.Add(new System.Data.SqlClient.SqlParameter("@VLRMULBOL", Boleto.VlrMulta));
                parametros.Add(new System.Data.SqlClient.SqlParameter("@DTCADBOL", DateTime.Now.Date));
                parametros.Add(new System.Data.SqlClient.SqlParameter("@DTVCTBOL", Boleto.DataVencimento.Date));
                parametros.Add(new System.Data.SqlClient.SqlParameter("@VLRDESCONTBOL", Boleto.VlrDesconto));
                parametros.Add(new System.Data.SqlClient.SqlParameter("@DESCONJRBOL", Boleto.JrDesconto));
                parametros.Add(new System.Data.SqlClient.SqlParameter("@VLRIPTUBOL", Boleto.VlrIptu));
                parametros.Add(new System.Data.SqlClient.SqlParameter("@JRCOMBOL", Boleto.JrComissao));
                parametros.Add(new System.Data.SqlClient.SqlParameter("@VLRCOMBOL", Boleto.VlrComissao));
                parametros.Add(new System.Data.SqlClient.SqlParameter("@PAGBOL", Boleto.ConverterPagBoleto(Boleto.PagBoleto)));
                parametros.Add(new System.Data.SqlClient.SqlParameter("@DTINIBOL", Boleto.PeriodoInicio.Date));
                parametros.Add(new System.Data.SqlClient.SqlParameter("@DTFIMBOL", Boleto.PeriodoFim.Date));

                db.ExecutaComandoSQL(GI_SP_INCBOLETOS, parametros);
            }
        }

        public List<Boleto> ConsulBoletos(string pCodContrato)
        {
            List<Boleto> lstboletos = new List<Boleto>();
            List<System.Data.SqlClient.SqlParameter> parametros = new List<System.Data.SqlClient.SqlParameter>();
            parametros.Add(new System.Data.SqlClient.SqlParameter("@CODCONTR", pCodContrato));

            DbContext db = new DbContext();
            DataSet ds = db.ConsultaSQL(GI_SP_CONSULTOBOLETOS, parametros);


            if (ds != null && ds.Tables != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {

                DataTable dt = ds.Tables[0];

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Boleto boleto = new Boleto();
                    if (dt.Rows[i]["CODBOL"] != DBNull.Value)
                        boleto.Codigo = Convert.ToString(dt.Rows[i]["CODBOL"]);

                    if (dt.Rows[i]["NUMBOL"] != DBNull.Value)
                        boleto.NumBoleto = Convert.ToString(dt.Rows[i]["NUMBOL"]);

                    if (dt.Rows[i]["NOMELOCADBOL"] != DBNull.Value)
                        boleto.Locador = Convert.ToString(dt.Rows[i]["NOMELOCADBOL"]);

                    if (dt.Rows[i]["NOMELOCATBOL"] != DBNull.Value)
                        boleto.Locatario = Convert.ToString(dt.Rows[i]["NOMELOCATBOL"]);

                    if (dt.Rows[i]["VLRBOL"] != DBNull.Value)
                        boleto.Valor = Convert.ToDouble(dt.Rows[i]["VLRBOL"]);

                    if (dt.Rows[i]["DATAPAGBOL"] != DBNull.Value)
                        boleto.DataPagamento = Convert.ToDateTime(dt.Rows[i]["DATAPAGBOL"]).Date;

                    if (dt.Rows[i]["ENDERBOL"] != DBNull.Value)
                        boleto.Endereco = Convert.ToString(dt.Rows[i]["ENDERBOL"]);

                    if (dt.Rows[i]["DTVCTBOL"] != DBNull.Value)
                        boleto.DataVencimento = Convert.ToDateTime(dt.Rows[i]["DTVCTBOL"]).Date;

                    if (dt.Rows[i]["PAGBOL"] != DBNull.Value)
                        boleto.PagBoleto = boleto.ConverterPagBoleto(Convert.ToString(dt.Rows[i]["PAGBOL"]));



                    lstboletos.Add(boleto);
                }
            }
            return lstboletos;
        }

        public List<Boleto> ObterBoleto(string pCodContrato, string pCodBoleto, string pNumBoleto)
        {
            List<Boleto> lstboletos = new List<Boleto>();
            List<System.Data.SqlClient.SqlParameter> parametros = new List<System.Data.SqlClient.SqlParameter>();
            parametros.Add(new System.Data.SqlClient.SqlParameter("@CODCONTR", pCodContrato));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@CODBOL", pCodBoleto));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@NUMBOL", pNumBoleto));

            DbContext db = new DbContext();
            DataSet ds = db.ConsultaSQL(GI_SP_OBTERBOLETO, parametros);


            if (ds != null && ds.Tables != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {

                DataTable dt = ds.Tables[0];

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Boleto boleto = new Boleto();

                    if (dt.Rows[i]["CODBOL"] != DBNull.Value)
                        boleto.Codigo = Convert.ToString(dt.Rows[i]["CODBOL"]);

                    if (dt.Rows[i]["CODCONTRBOL"] != DBNull.Value)
                        boleto.Codigo = Convert.ToString(dt.Rows[i]["CODCONTRBOL"]);

                    if (dt.Rows[i]["NUMBOL"] != DBNull.Value)
                        boleto.NumBoleto = Convert.ToString(dt.Rows[i]["NUMBOL"]);

                    if (dt.Rows[i]["NOMELOCADBOL"] != DBNull.Value)
                        boleto.Locador = Convert.ToString(dt.Rows[i]["NOMELOCADBOL"]);

                    if (dt.Rows[i]["NOMELOCATBOL"] != DBNull.Value)
                        boleto.Locatario = Convert.ToString(dt.Rows[i]["NOMELOCATBOL"]);

                    if (dt.Rows[i]["VLRBOL"] != DBNull.Value)
                        boleto.Valor = Convert.ToDouble(dt.Rows[i]["VLRBOL"]);

                    if (dt.Rows[i]["VLRIPTUBOL"] != DBNull.Value)
                        boleto.VlrIptu = Convert.ToDouble(dt.Rows[i]["VLRIPTUBOL"]);

                    if (dt.Rows[i]["DATAPAGBOL"] != DBNull.Value)
                        boleto.DataPagamento = Convert.ToDateTime(dt.Rows[i]["DATAPAGBOL"]);

                    if (dt.Rows[i]["DTVCTBOL"] != DBNull.Value)
                        boleto.DataVencimento = Convert.ToDateTime(dt.Rows[i]["DTVCTBOL"]).Date;

                    if (dt.Rows[i]["ENDERBOL"] != DBNull.Value)
                        boleto.Endereco = Convert.ToString(dt.Rows[i]["ENDERBOL"]);

                    if (dt.Rows[i]["PAGBOL"] != DBNull.Value)
                        boleto.PagBoleto = boleto.ConverterPagBoleto(Convert.ToString(dt.Rows[i]["PAGBOL"]));

                    if (dt.Rows[i]["JRCOMBOL"] != DBNull.Value)
                        boleto.JrComissao = Convert.ToDouble(dt.Rows[i]["JRCOMBOL"]);

                    if (dt.Rows[i]["VLRCOMBOL"] != DBNull.Value)
                        boleto.VlrComissao = Convert.ToDouble(dt.Rows[i]["VLRCOMBOL"]);

                    if (dt.Rows[i]["DESCONJRBOL"] != DBNull.Value)
                        boleto.JrDesconto = Convert.ToDouble(dt.Rows[i]["DESCONJRBOL"]);

                    if (dt.Rows[i]["VLRDESCONTBOL"] != DBNull.Value)
                        boleto.VlrDesconto = Convert.ToDouble(dt.Rows[i]["VLRDESCONTBOL"]);

                    if (dt.Rows[i]["JRMULBOL"] != DBNull.Value)
                        boleto.JrMulta = Convert.ToDouble(dt.Rows[i]["JRMULBOL"]);

                    if (dt.Rows[i]["VLRMULBOL"] != DBNull.Value)
                        boleto.VlrMulta = Convert.ToDouble(dt.Rows[i]["VLRMULBOL"]);

                    lstboletos.Add(boleto);
                }
            }
            return lstboletos;
        }

        public Boleto ObterBoletoRel(string pCodContrato, string pCodBoleto, string pNumBoleto)
        {
            List<Boleto> lstboletos = new List<Boleto>();
            List<System.Data.SqlClient.SqlParameter> parametros = new List<System.Data.SqlClient.SqlParameter>();
            parametros.Add(new System.Data.SqlClient.SqlParameter("@CODCONTR", pCodContrato));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@CODBOL", pCodBoleto));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@NUMBOL", pNumBoleto));

            DbContext db = new DbContext();
            DataSet ds = db.ConsultaSQL(GI_SP_OBTERBOLETOREL, parametros);
            Boleto boleto = new Boleto();

            if (ds != null && ds.Tables != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {

                DataTable dt = ds.Tables[0];

                for (int i = 0; i < dt.Rows.Count; i++)
                {


                    if (dt.Rows[i]["CODBOL"] != DBNull.Value)
                        boleto.Codigo = Convert.ToString(dt.Rows[i]["CODBOL"]);

                    if (dt.Rows[i]["CODCONTRBOL"] != DBNull.Value)
                        boleto.Codigo = Convert.ToString(dt.Rows[i]["CODCONTRBOL"]);

                    if (dt.Rows[i]["NUMBOL"] != DBNull.Value)
                        boleto.NumBoleto = Convert.ToString(dt.Rows[i]["NUMBOL"]);

                    if (dt.Rows[i]["NOMELOCADBOL"] != DBNull.Value)
                        boleto.Locador = Convert.ToString(dt.Rows[i]["NOMELOCADBOL"]);

                    if (dt.Rows[i]["NOMELOCATBOL"] != DBNull.Value)
                        boleto.Locatario = Convert.ToString(dt.Rows[i]["NOMELOCATBOL"]);

                    if (dt.Rows[i]["VLRBOL"] != DBNull.Value)
                        boleto.Valor = Convert.ToDouble(dt.Rows[i]["VLRBOL"]);

                    if (dt.Rows[i]["VLRIPTUBOL"] != DBNull.Value)
                        boleto.VlrIptu = Convert.ToDouble(dt.Rows[i]["VLRIPTUBOL"]);

                    if (dt.Rows[i]["DATAPAGBOL"] != DBNull.Value)
                        boleto.DataPagamento = Convert.ToDateTime(dt.Rows[i]["DATAPAGBOL"]);

                    if (dt.Rows[i]["DTVCTBOL"] != DBNull.Value)
                        boleto.DataVencimento = Convert.ToDateTime(dt.Rows[i]["DTVCTBOL"]).Date;

                    if (dt.Rows[i]["ENDERBOL"] != DBNull.Value)
                        boleto.Endereco = Convert.ToString(dt.Rows[i]["ENDERBOL"]);

                    if (dt.Rows[i]["PAGBOL"] != DBNull.Value)
                        boleto.PagBoleto = boleto.ConverterPagBoleto(Convert.ToString(dt.Rows[i]["PAGBOL"]));

                    if (dt.Rows[i]["JRCOMBOL"] != DBNull.Value)
                        boleto.JrComissao = Convert.ToDouble(dt.Rows[i]["JRCOMBOL"]);

                    if (dt.Rows[i]["VLRCOMBOL"] != DBNull.Value)
                        boleto.VlrComissao = Convert.ToDouble(dt.Rows[i]["VLRCOMBOL"]);

                    if (dt.Rows[i]["DESCONJRBOL"] != DBNull.Value)
                        boleto.JrDesconto = Convert.ToDouble(dt.Rows[i]["DESCONJRBOL"]);

                    if (dt.Rows[i]["VLRDESCONTBOL"] != DBNull.Value)
                        boleto.VlrDesconto = Convert.ToDouble(dt.Rows[i]["VLRDESCONTBOL"]);

                    if (dt.Rows[i]["JRMULBOL"] != DBNull.Value)
                        boleto.JrMulta = Convert.ToDouble(dt.Rows[i]["JRMULBOL"]);

                    if (dt.Rows[i]["VLRMULBOL"] != DBNull.Value)
                        boleto.VlrMulta = Convert.ToDouble(dt.Rows[i]["VLRMULBOL"]);

                    if (dt.Rows[i]["TIPOIMOVCONTR"] != DBNull.Value)
                        boleto.TipoImovel = Convert.ToString(dt.Rows[i]["TIPOIMOVCONTR"]);

                    if (dt.Rows[i]["DTINIBOL"] != DBNull.Value)
                        boleto.PeriodoInicio = Convert.ToDateTime(dt.Rows[i]["DTINIBOL"]).Date;

                    if (dt.Rows[i]["DTFIMBOL"] != DBNull.Value)
                        boleto.PeriodoFim = Convert.ToDateTime(dt.Rows[i]["DTFIMBOL"]).Date;



                }
            }

            return boleto;
        }

        public void AlterarBoleto(Boleto pBoleto)
        {
            DbContext db = new DbContext();

            List<System.Data.SqlClient.SqlParameter> parametros = new List<System.Data.SqlClient.SqlParameter>();
            parametros.Add(new System.Data.SqlClient.SqlParameter("@CODBOL", pBoleto.Codigo));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@CODCONTRBOL", pBoleto.CodContrato));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@NUMBOL", pBoleto.NumBoleto));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@ENDERBOL", pBoleto.Endereco));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@NOMELOCADBOL", pBoleto.Locador));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@NOMELOCATBOL", pBoleto.Locatario));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@JRMULBOL", pBoleto.JrMulta));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@VLRBOL", pBoleto.Valor));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@VLRMULBOL", pBoleto.VlrMulta));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@DTVCTBOL", pBoleto.DataVencimento.Date));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@VLRDESCONTBOL", pBoleto.VlrDesconto));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@DESCONJRBOL", pBoleto.JrDesconto));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@VLRIPTUBOL", pBoleto.VlrIptu));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@PAGBOL", pBoleto.ConverterPagBoleto(pBoleto.PagBoleto)));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@DTULTALTBOL", DateTime.Now));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@JRCOMBOL", pBoleto.JrComissao));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@VLRCOMBOL", pBoleto.VlrComissao));

            db.ExecutaComandoSQL(GI_SP_ALTBOLETOS, parametros);
        }


        public void PagarBoleto(string pCodContrato, string pCodBoleto, string pNumBoleto)
        {
            DbContext db = new DbContext();

            List<System.Data.SqlClient.SqlParameter> parametros = new List<System.Data.SqlClient.SqlParameter>();
            parametros.Add(new System.Data.SqlClient.SqlParameter("@CODBOL", pCodBoleto));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@CODCONTRBOL", pCodContrato));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@NUMBOL", pNumBoleto));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@DATAPAGBOL", DateTime.Now.Date));

            db.ExecutaComandoSQL(GI_SP_PAGARBOLETO, parametros);
        }

        public bool ValidaBoletoPago(string pCodContrato, string pCodBoleto, string pNumBoleto)
        {
            DbContext db = new DbContext();

            List<System.Data.SqlClient.SqlParameter> parametros = new List<System.Data.SqlClient.SqlParameter>();
            parametros.Add(new System.Data.SqlClient.SqlParameter("@CODBOL", pCodBoleto));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@CODCONTRBOL", pCodContrato));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@NUMBOL", pNumBoleto));

            DataSet ds = db.ConsultaSQL(GI_SP_VALIDABOLETOPAGO, parametros);

            if (ds.Tables[0].Rows.Count > 0)
                return true;

            return false;
        }



        public double ConsultarValorReceberMes()
        {
            DbContext db = new DbContext();

            List<System.Data.SqlClient.SqlParameter> parametros = new List<System.Data.SqlClient.SqlParameter>();
            parametros.Add(new System.Data.SqlClient.SqlParameter("@DTNOW", DateTime.Now.Date));
            DataSet ds = db.ConsultaSQL(GI_SP_CONSULVALORRECEBER, parametros);
            double ValorReceber = 0.00;

            if (ds != null && ds.Tables != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                DataTable dt = ds.Tables[0];

                for (int i = 0; i < dt.Rows.Count; i++)
                {

                    if (dt.Rows[i]["VLRRECEBER"] != DBNull.Value)
                        ValorReceber  = Convert.ToDouble(dt.Rows[i]["VLRRECEBER"]);
                }
            }

            return ValorReceber;

        }

        public double ConsultarValorAdmReceberMes()
        {
            DbContext db = new DbContext();

            List<System.Data.SqlClient.SqlParameter> parametros = new List<System.Data.SqlClient.SqlParameter>();
            parametros.Add(new System.Data.SqlClient.SqlParameter("@DTNOW", DateTime.Now.Date));
            DataSet ds = db.ConsultaSQL(GI_SP_CONSULVALORADMRECEBER, parametros);
            double ValorReceber = 0.00;

            if (ds != null && ds.Tables != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                DataTable dt = ds.Tables[0];

                for (int i = 0; i < dt.Rows.Count; i++)
                {

                    if (dt.Rows[i]["VLRADMRECEBER"] != DBNull.Value)
                        ValorReceber = Convert.ToDouble(dt.Rows[i]["VLRADMRECEBER"]);
                }
            }

            return ValorReceber;

        }


        public bool BoletosVencer()
        {
            DbContext db = new DbContext();

            List<System.Data.SqlClient.SqlParameter> parametros = new List<System.Data.SqlClient.SqlParameter>();
            parametros.Add(new System.Data.SqlClient.SqlParameter("@DATANOW", DateTime.Now.Date));
            DataSet ds = db.ConsultaSQL(GI_SP_BOLETOSVENCER, parametros);

            if (ds.Tables[0].Rows.Count > 0)
                return true;

            return false;
        }




    }
}

