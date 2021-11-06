using GestorImoveis.DAL.Context;
using GestorImoveis.DML;
using GestorImoveis.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorImoveis.DAL.Anuncio
{
    public class DalAnuncio
    {

        #region Constantes

        private const string GI_SP_CONSULTIMOCODANUNCIO = "GI_SP_ObterUltCodAnuncio";

        private const string GI_SP_INCANUNCIO = "GI_SP_IncAnuncio";

        private const string GI_SP_VALEXISTCODANUNCIO = "GI_SP_ExisteCodAnuncio";

        private const string GI_SP_OBTERANUNCIO = "GI_SP_ObterAnuncio";

        private const string GI_SP_ATUALIZAANUNCIO = "GI_SP_AlterarAnuncio";

        private const string GI_SP_CONSULTAANUNCIOS = "GI_SP_ConsultaAnuncios";

        private const string GI_SP_DELETEANUNCIO = "/*GI_SP_DeleteAnuncio*/";

        private const string GI_SP_PESQANUNCIO = "GI_SP_PesqAnuncio";

        private const string GI_SP_COUNTANUNCIOS = "GI_SP_CountAnuncios";

        #endregion

        public string ObterUltCodAnuncios(string pNeg)
        {
            string UltimoCodAnunc = string.Empty;

            List<System.Data.SqlClient.SqlParameter> parametros = new List<System.Data.SqlClient.SqlParameter>();
            parametros.Add(new System.Data.SqlClient.SqlParameter("@NEG", pNeg));

            DbContext db = new DbContext();
            DataSet ds = db.ConsultaSQL(GI_SP_CONSULTIMOCODANUNCIO, parametros);

            if (ds != null && ds.Tables != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    UltimoCodAnunc = row.Field<string>("CODANUNC");
                }
            }
            return UltimoCodAnunc;
        }


        public bool ValidaExistenciaCodAnuncio(string pCodAnuncio)
        {

            List<System.Data.SqlClient.SqlParameter> parametros = new List<System.Data.SqlClient.SqlParameter>();
            parametros.Add(new System.Data.SqlClient.SqlParameter("CODANUNC", pCodAnuncio));

            DbContext db = new DbContext();
            DataSet ds = db.ConsultaSQL(GI_SP_VALEXISTCODANUNCIO, parametros);

            if (ds.Tables[0].Rows.Count > 0)
                return true;

            return false;
        }

        public List<GestorImoveis.DML.Anuncio> ConsultaAnuncios()
        {
            List<GestorImoveis.DML.Anuncio> lstanuncio = new List<GestorImoveis.DML.Anuncio>();

            DbContext db = new DbContext();
            DataSet ds = db.ConsultaSQL(GI_SP_CONSULTAANUNCIOS, null);

            if (ds != null && ds.Tables != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {

                DataTable dt = ds.Tables[0];

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    GestorImoveis.DML.Anuncio anuncio = new GestorImoveis.DML.Anuncio();
                    if (dt.Rows[i]["CODANUNC"] != DBNull.Value)
                        anuncio.Codigo = Convert.ToString(dt.Rows[i]["CODANUNC"]);

                    if (dt.Rows[i]["TIPOIMOVANUNC"] != DBNull.Value)
                        anuncio.TipoImovel = Convert.ToString(dt.Rows[i]["TIPOIMOVANUNC"]);

                    if (dt.Rows[i]["NOMEPROPANUNC"] != DBNull.Value)
                        anuncio.Proprietario = Convert.ToString(dt.Rows[i]["NOMEPROPANUNC"]);

                    if (dt.Rows[i]["VALORANUNC"] != DBNull.Value)
                        anuncio.Valor = Convert.ToDouble(dt.Rows[i]["VALORANUNC"]);

                    if (dt.Rows[i]["NEGANUNC"] != DBNull.Value)
                        anuncio.Negocio = Convert.ToString(dt.Rows[i]["NEGANUNC"]);

                    if (dt.Rows[i]["REGANUNC"] != DBNull.Value)
                        anuncio.Regiao = Convert.ToString(dt.Rows[i]["REGANUNC"]);

                    if (dt.Rows[i]["DTULTALTANUNC"] != DBNull.Value)
                        anuncio.DataAtualizacao = Convert.ToDateTime(dt.Rows[i]["DTULTALTANUNC"]);
                
                    if (dt.Rows[i]["CIDADEANUNC"] != DBNull.Value)
                        anuncio.Cidade = Convert.ToString(dt.Rows[i]["CIDADEANUNC"]);

                    if (dt.Rows[i]["BAIRROANUNC"] != DBNull.Value)
                        anuncio.Bairro = Convert.ToString(dt.Rows[i]["BAIRROANUNC"]);

                    if (dt.Rows[i]["ATIVOANUNC"] != DBNull.Value)
                        anuncio.Ativo = UtilHelpers.ConverterTipoSituacao(dt.Rows[i]["ATIVOANUNC"].ToString());

                    lstanuncio.Add(anuncio);
                }

            }

            return lstanuncio;
        }

        public void IncluirAnuncio(GestorImoveis.DML.Anuncio pAnuncio)
        {
            List<System.Data.SqlClient.SqlParameter> parametros = new List<System.Data.SqlClient.SqlParameter>();

            parametros.Add(new System.Data.SqlClient.SqlParameter("@CODANUNC", pAnuncio.Codigo));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@ENDANUNC", pAnuncio.Endereco));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@TIPOIMOVANUNC", pAnuncio.TipoImovel));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@NOMEPROPANUNC", pAnuncio.Proprietario));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@VALORANUNC", pAnuncio.Valor));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@VLRIPTUANUNC", pAnuncio.VlrIptu));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@DTCADANUNC", pAnuncio.DataCadastro.Date));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@NEGANUNC", pAnuncio.Negocio));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@REGANUNC", pAnuncio.Regiao));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@DORMANUNC", pAnuncio.Dormitorio));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@SUITEANUNC", pAnuncio.Suites));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@VAGASANUNC", pAnuncio.Vagas));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@AREAANUNC", pAnuncio.Area));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@CIDADEANUNC", pAnuncio.Cidade));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@BAIRROANUNC", pAnuncio.Bairro));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@OBSANUNC", pAnuncio.Obs));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@PERMUTAANUNC", pAnuncio.Permuta));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@CHURRASQUEIRAANUNC", pAnuncio.Churrasqueira));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@PISCINAANUNC", pAnuncio.Piscina));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@BRINQUEDOTECAANUNC", pAnuncio.Brinquedoteca));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@PLAYGROUDANUNC", pAnuncio.Playgroud));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@QUADRAANUNC", pAnuncio.Poliesportiva));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@SGINASTICAANUNC", pAnuncio.Ginastica));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@SFESTAANUNC", pAnuncio.Festas));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@SJOGOSNUNC", pAnuncio.Jogos));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@ATIVOANUNC", UtilHelpers.ConverterTipoSituacao(pAnuncio.Ativo)));
                
            DbContext db = new DbContext();
            db.ExecutaComandoSQL(GI_SP_INCANUNCIO, parametros);

        }

        public void AtualizaAnuncio(GestorImoveis.DML.Anuncio pAnuncio)
        {
            List<System.Data.SqlClient.SqlParameter> parametros = new List<System.Data.SqlClient.SqlParameter>();

            parametros.Add(new System.Data.SqlClient.SqlParameter("@CODANUNC", pAnuncio.Codigo));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@ENDANUNC", pAnuncio.Endereco));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@TIPOIMOVANUNC", pAnuncio.TipoImovel));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@NOMEPROPANUNC", pAnuncio.Proprietario));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@VALORANUNC", pAnuncio.Valor));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@VLRIPTUANUNC", pAnuncio.VlrIptu));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@DTULTALTANUNC", DateTime.Now.Date));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@NEGANUNC", pAnuncio.Negocio));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@REGANUNC", pAnuncio.Regiao));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@DORMANUNC", pAnuncio.Dormitorio));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@SUITEANUNC", pAnuncio.Suites));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@VAGASANUNC", pAnuncio.Vagas));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@AREAANUNC", pAnuncio.Area));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@CIDADEANUNC", pAnuncio.Cidade));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@BAIRROANUNC", pAnuncio.Bairro));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@OBSANUNC", pAnuncio.Obs));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@PERMUTAANUNC", pAnuncio.Permuta));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@CHURRASQUEIRAANUNC", pAnuncio.Churrasqueira));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@PISCINAANUNC", pAnuncio.Piscina));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@BRINQUEDOTECAANUNC", pAnuncio.Brinquedoteca));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@PLAYGROUDANUNC", pAnuncio.Playgroud));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@QUADRAANUNC", pAnuncio.Poliesportiva));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@SGINASTICAANUNC", pAnuncio.Ginastica));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@SFESTAANUNC", pAnuncio.Festas));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@SJOGOSNUNC", pAnuncio.Jogos));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@ATIVOANUNC", UtilHelpers.ConverterTipoSituacao(pAnuncio.Ativo)));


            DbContext db = new DbContext();
            db.ExecutaComandoSQL(GI_SP_ATUALIZAANUNCIO, parametros); 

        }

        public List<GestorImoveis.DML.Anuncio> ObterAnuncio(string pParam)
        {
            List<GestorImoveis.DML.Anuncio> lstanuncio = new List<GestorImoveis.DML.Anuncio>();

            List<System.Data.SqlClient.SqlParameter> parametros = new List<System.Data.SqlClient.SqlParameter>();
            parametros.Add(new System.Data.SqlClient.SqlParameter("@CODANUNC", pParam));

            DbContext db = new DbContext();
            DataSet ds = db.ConsultaSQL(GI_SP_OBTERANUNCIO, parametros);

            if (ds != null && ds.Tables != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {

                DataTable dt = ds.Tables[0];
                GestorImoveis.DML.Anuncio anuncio = new GestorImoveis.DML.Anuncio();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                   
                    if (dt.Rows[i]["CODANUNC"] != DBNull.Value)
                        anuncio.Codigo = Convert.ToString(dt.Rows[i]["CODANUNC"]);

                    if (dt.Rows[i]["TIPOIMOVANUNC"] != DBNull.Value)
                        anuncio.TipoImovel = Convert.ToString(dt.Rows[i]["TIPOIMOVANUNC"]);

                    if (dt.Rows[i]["NOMEPROPANUNC"] != DBNull.Value)
                        anuncio.Proprietario = Convert.ToString(dt.Rows[i]["NOMEPROPANUNC"]);

                    if (dt.Rows[i]["VALORANUNC"] != DBNull.Value)
                        anuncio.Valor = Convert.ToDouble(dt.Rows[i]["VALORANUNC"]);

                    if (dt.Rows[i]["NEGANUNC"] != DBNull.Value)
                        anuncio.Negocio = Convert.ToString(dt.Rows[i]["NEGANUNC"]);

                    if (dt.Rows[i]["REGANUNC"] != DBNull.Value)
                        anuncio.Regiao = Convert.ToString(dt.Rows[i]["REGANUNC"]);

                    if (dt.Rows[i]["ENDANUNC"] != DBNull.Value)
                        anuncio.Endereco = Convert.ToString(dt.Rows[i]["ENDANUNC"]);

                    if (dt.Rows[i]["CIDADEANUNC"] != DBNull.Value)
                        anuncio.Cidade = Convert.ToString(dt.Rows[i]["CIDADEANUNC"]);

                    if (dt.Rows[i]["BAIRROANUNC"] != DBNull.Value)
                        anuncio.Bairro = Convert.ToString(dt.Rows[i]["BAIRROANUNC"]);

                    if (dt.Rows[i]["DORMANUNC"] != DBNull.Value)
                        anuncio.Dormitorio = Convert.ToInt32(dt.Rows[i]["DORMANUNC"]);

                    if (dt.Rows[i]["SUITEANUNC"] != DBNull.Value)
                        anuncio.Suites = Convert.ToInt32(dt.Rows[i]["SUITEANUNC"]);

                    if (dt.Rows[i]["VAGASANUNC"] != DBNull.Value)
                        anuncio.Vagas = Convert.ToInt32(dt.Rows[i]["VAGASANUNC"]);

                    if (dt.Rows[i]["AREAANUNC"] != DBNull.Value)
                        anuncio.Area = Convert.ToInt32(dt.Rows[i]["AREAANUNC"]);

                    if (dt.Rows[i]["OBSANUNC"] != DBNull.Value)
                        anuncio.Obs = dt.Rows[i]["OBSANUNC"].ToString();

                    if (dt.Rows[i]["PERMUTAANUNC"] != DBNull.Value)
                        anuncio.Permuta = Convert.ToBoolean(dt.Rows[i]["PERMUTAANUNC"]);

                    if (dt.Rows[i]["CHURRASQUEIRAANUNC"] != DBNull.Value)
                        anuncio.Churrasqueira = Convert.ToBoolean(dt.Rows[i]["CHURRASQUEIRAANUNC"]);

                    if (dt.Rows[i]["PISCINAANUNC"] != DBNull.Value)
                        anuncio.Piscina = Convert.ToBoolean(dt.Rows[i]["PISCINAANUNC"]);

                    if (dt.Rows[i]["BRINQUEDOTECAANUNC"] != DBNull.Value)
                        anuncio.Brinquedoteca = Convert.ToBoolean(dt.Rows[i]["BRINQUEDOTECAANUNC"]);

                    if (dt.Rows[i]["PLAYGROUDANUNC"] != DBNull.Value)
                        anuncio.Playgroud = Convert.ToBoolean(dt.Rows[i]["PLAYGROUDANUNC"]);

                    if (dt.Rows[i]["QUADRAANUNC"] != DBNull.Value)
                        anuncio.Poliesportiva = Convert.ToBoolean(dt.Rows[i]["QUADRAANUNC"]);

                    if (dt.Rows[i]["SGINASTICAANUNC"] != DBNull.Value)
                        anuncio.Ginastica = Convert.ToBoolean(dt.Rows[i]["SGINASTICAANUNC"]);

                    if (dt.Rows[i]["SFESTAANUNC"] != DBNull.Value)
                        anuncio.Festas = Convert.ToBoolean(dt.Rows[i]["SFESTAANUNC"]);

                    if (dt.Rows[i]["SJOGOSNUNC"] != DBNull.Value)
                        anuncio.Jogos = Convert.ToBoolean(dt.Rows[i]["SJOGOSNUNC"]);

                    if (dt.Rows[i]["VLRIPTUANUNC"] != DBNull.Value)
                        anuncio.VlrIptu = Convert.ToDouble(dt.Rows[i]["VLRIPTUANUNC"]);

                    if (dt.Rows[i]["ATIVOANUNC"] != DBNull.Value)
                        anuncio.Ativo = UtilHelpers.ConverterTipoSituacao(dt.Rows[i]["ATIVOANUNC"].ToString());

                    lstanuncio.Add(anuncio);
                }

            }

            return lstanuncio;
        }

        public void DeleteAnuncio(string pParam)
        {
            List<System.Data.SqlClient.SqlParameter> parametros = new List<System.Data.SqlClient.SqlParameter>();
            parametros.Add(new System.Data.SqlClient.SqlParameter("@CODANUNC", pParam));

            DbContext db = new DbContext();
            db.ExecutaComandoSQL(GI_SP_DELETEANUNCIO, parametros);

        }

        public List<GestorImoveis.DML.Anuncio> PesqAnuncio(string pParam, string pFiltro)
        {
            List<GestorImoveis.DML.Anuncio> lstanuncio = new List<GestorImoveis.DML.Anuncio>();

            List<System.Data.SqlClient.SqlParameter> parametros = new List<System.Data.SqlClient.SqlParameter>();
            parametros.Add(new System.Data.SqlClient.SqlParameter("@FILTRO", pFiltro));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@VALOR", pParam));

            DbContext db = new DbContext();
            DataSet ds = db.ConsultaSQL(GI_SP_PESQANUNCIO, parametros);

            if (ds != null && ds.Tables != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {

                DataTable dt = ds.Tables[0];
                GestorImoveis.DML.Anuncio anuncio = new GestorImoveis.DML.Anuncio();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i]["CODANUNC"] != DBNull.Value)
                        anuncio.Codigo = Convert.ToString(dt.Rows[i]["CODANUNC"]);

                    if (dt.Rows[i]["TIPOIMOVANUNC"] != DBNull.Value)
                        anuncio.TipoImovel = Convert.ToString(dt.Rows[i]["TIPOIMOVANUNC"]);

                    if (dt.Rows[i]["NOMEPROPANUNC"] != DBNull.Value)
                        anuncio.Proprietario = Convert.ToString(dt.Rows[i]["NOMEPROPANUNC"]);

                    if (dt.Rows[i]["VALORANUNC"] != DBNull.Value)
                        anuncio.Valor = Convert.ToDouble(dt.Rows[i]["VALORANUNC"]);

                    if (dt.Rows[i]["NEGANUNC"] != DBNull.Value)
                        anuncio.Negocio = Convert.ToString(dt.Rows[i]["NEGANUNC"]);

                    if (dt.Rows[i]["REGANUNC"] != DBNull.Value)
                        anuncio.Regiao = Convert.ToString(dt.Rows[i]["REGANUNC"]);

                    if (dt.Rows[i]["DTULTALTANUNC"] != DBNull.Value)
                        anuncio.DataAtualizacao = Convert.ToDateTime(dt.Rows[i]["DTULTALTANUNC"]);

                    if (dt.Rows[i]["CIDADEANUNC"] != DBNull.Value)
                        anuncio.Cidade = Convert.ToString(dt.Rows[i]["CIDADEANUNC"]);

                    if (dt.Rows[i]["BAIRROANUNC"] != DBNull.Value)
                        anuncio.Bairro = Convert.ToString(dt.Rows[i]["BAIRROANUNC"]);

                    if (dt.Rows[i]["ATIVOANUNC"] != DBNull.Value)
                        anuncio.Ativo = UtilHelpers.ConverterTipoSituacao(dt.Rows[i]["ATIVOANUNC"].ToString());

                    lstanuncio.Add(anuncio);
                }

            }

            return lstanuncio;
        }

        public int CountAnuncios()
        {
            DbContext db = new DbContext();
            DataSet ds = db.ConsultaSQL(GI_SP_COUNTANUNCIOS, null);
            DataTable dt = ds.Tables[0];
            return Convert.ToInt32(dt.Rows[0]["QUANTIDADE"].ToString());
        }


    }
}
