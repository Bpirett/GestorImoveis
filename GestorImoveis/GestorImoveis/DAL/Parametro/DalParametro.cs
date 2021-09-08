using GestorImoveis.DAL.Context;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorImoveis.DAL.Parametro
{
    public class DalParametro
    {
        #region Constantes

        private const string GI_SP_INCPARAMETROS = "GI_SP_IncParametro";

        private const string GI_SP_CONSULTAPARAMETRO = "GI_SP_ConsultaParametros";

        private const string GI_SP_OBTERPARAMETRO = "GI_SP_ObterParametro";

        private const string GI_SP_ALTPARAMETROS = "GI_SP_AltParametros";

      

        #endregion


        public List<DML.Parametro> ConsultaParametros()
        {
            List<DML.Parametro> lstparametros = new List<DML.Parametro>();
            List<System.Data.SqlClient.SqlParameter> parametros = new List<System.Data.SqlClient.SqlParameter>();

            DbContext db = new DbContext();
            DataSet ds = db.ConsultaSQL(GI_SP_CONSULTAPARAMETRO, null);


            if (ds != null && ds.Tables != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {

                DataTable dt = ds.Tables[0];

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DML.Parametro parametro = new DML.Parametro();
                    if (dt.Rows[i]["TPSIST"] != DBNull.Value)
                        parametro.Sistema = Convert.ToString(dt.Rows[i]["TPSIST"]);

                    if (dt.Rows[i]["TPCATEG"] != DBNull.Value)
                        parametro.Categoria = parametro.ConverterTipoCategoria(dt.Rows[i]["TPCATEG"].ToString());

                    if (dt.Rows[i]["TPPARAM"] != DBNull.Value)
                        parametro.Parametros = Convert.ToString(dt.Rows[i]["TPPARAM"]);

                    if (dt.Rows[i]["TPCONTEUDO"] != DBNull.Value)
                        parametro.Conteudo = Convert.ToString(dt.Rows[i]["TPCONTEUDO"]);

                    if (dt.Rows[i]["TPDESC"] != DBNull.Value)
                        parametro.Descricao = Convert.ToString(dt.Rows[i]["TPDESC"]);

                    if (dt.Rows[i]["TPDTALT"] != DBNull.Value)
                        parametro.DataAtualizacao = Convert.ToDateTime(dt.Rows[i]["TPDTALT"]);

                    if (dt.Rows[i]["TPUSU"] != DBNull.Value)
                        parametro.Usuario = Convert.ToString(dt.Rows[i]["TPUSU"]);

                    lstparametros.Add(parametro);
                }
            }
            return lstparametros;
        }


        public void AlterarParametro(DML.Parametro pParametro)
        {
            DbContext db = new DbContext();
            
            List<System.Data.SqlClient.SqlParameter> parametros = new List<System.Data.SqlClient.SqlParameter>();
            parametros.Add(new System.Data.SqlClient.SqlParameter("@TPSIST", pParametro.Sistema));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@TPPARAM", pParametro.Parametros));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@TPCATEG", pParametro.ConverterTipoCategoria(pParametro.Categoria)));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@TPCONTEUDO", pParametro.Conteudo));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@TPDESC", pParametro.Descricao));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@TPDTALT", pParametro.DataAtualizacao));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@TPUSU", pParametro.Usuario));
      
            db.ExecutaComandoSQL(GI_SP_ALTPARAMETROS, parametros);
        }

        public string ObterValueParametros(string pParametro)
        {
            List<System.Data.SqlClient.SqlParameter> parametros = new List<System.Data.SqlClient.SqlParameter>();
            DML.Parametro parametro = new DML.Parametro();
     
            parametros.Add(new System.Data.SqlClient.SqlParameter("@TPPARAM", pParametro));

           
            DbContext db = new DbContext();
            DataSet ds = db.ConsultaSQL(GI_SP_OBTERPARAMETRO, parametros);


            if (ds != null && ds.Tables != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {

                DataTable dt = ds.Tables[0];

                for (int i = 0; i < dt.Rows.Count; i++)
                {
               
                    if (dt.Rows[i]["TPSIST"] != DBNull.Value)
                        parametro.Sistema = Convert.ToString(dt.Rows[i]["TPSIST"]);

                    if (dt.Rows[i]["TPCATEG"] != DBNull.Value)
                        parametro.Categoria = parametro.ConverterTipoCategoria(dt.Rows[i]["TPCATEG"].ToString());

                    if (dt.Rows[i]["TPPARAM"] != DBNull.Value)
                        parametro.Parametros = Convert.ToString(dt.Rows[i]["TPPARAM"]);

                    if (dt.Rows[i]["TPCONTEUDO"] != DBNull.Value)
                        parametro.Conteudo = Convert.ToString(dt.Rows[i]["TPCONTEUDO"]);

                    if (dt.Rows[i]["TPDESC"] != DBNull.Value)
                        parametro.Descricao = Convert.ToString(dt.Rows[i]["TPDESC"]);

                    if (dt.Rows[i]["TPDTALT"] != DBNull.Value)
                        parametro.DataAtualizacao = Convert.ToDateTime(dt.Rows[i]["TPDTALT"]);

                    if (dt.Rows[i]["TPUSU"] != DBNull.Value)
                        parametro.Usuario = Convert.ToString(dt.Rows[i]["TPUSU"]);
                }
            }
            return parametro.Conteudo;
        }


        public DML.Parametro ObterParametro(string pSistema, string pParametro, DML.Parametro.ParametroCategoria pCategoria)
        {
            List<System.Data.SqlClient.SqlParameter> parametros = new List<System.Data.SqlClient.SqlParameter>();
            DML.Parametro parametro = new DML.Parametro();
            //parametros.Add(new System.Data.SqlClient.SqlParameter("@TPSIST", pSistema));
            //parametros.Add(new System.Data.SqlClient.SqlParameter("@TPCATEG", parametro.ConverterTipoCategoria(pCategoria)));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@TPPARAM", pParametro));


            DbContext db = new DbContext();
            DataSet ds = db.ConsultaSQL(GI_SP_OBTERPARAMETRO, parametros);


            if (ds != null && ds.Tables != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {

                DataTable dt = ds.Tables[0];

                for (int i = 0; i < dt.Rows.Count; i++)
                {

                    if (dt.Rows[i]["TPSIST"] != DBNull.Value)
                        parametro.Sistema = Convert.ToString(dt.Rows[i]["TPSIST"]);

                    if (dt.Rows[i]["TPCATEG"] != DBNull.Value)
                        parametro.Categoria = parametro.ConverterTipoCategoria(dt.Rows[i]["TPCATEG"].ToString());

                    if (dt.Rows[i]["TPPARAM"] != DBNull.Value)
                        parametro.Parametros = Convert.ToString(dt.Rows[i]["TPPARAM"]);

                    if (dt.Rows[i]["TPCONTEUDO"] != DBNull.Value)
                        parametro.Conteudo = Convert.ToString(dt.Rows[i]["TPCONTEUDO"]);

                    if (dt.Rows[i]["TPDESC"] != DBNull.Value)
                        parametro.Descricao = Convert.ToString(dt.Rows[i]["TPDESC"]);

                    if (dt.Rows[i]["TPDTALT"] != DBNull.Value)
                        parametro.DataAtualizacao = Convert.ToDateTime(dt.Rows[i]["TPDTALT"]);

                    if (dt.Rows[i]["TPUSU"] != DBNull.Value)
                        parametro.Usuario = Convert.ToString(dt.Rows[i]["TPUSU"]);
                }
            }
            return parametro;
        }



        public void InserirParametro(DML.AtributoParametro pAtributo)
        {
            DbContext db = new DbContext();
            DML.Parametro parametro = new DML.Parametro();

            List<System.Data.SqlClient.SqlParameter> parametros = new List<System.Data.SqlClient.SqlParameter>();
            parametros.Add(new System.Data.SqlClient.SqlParameter("@TPSIST", pAtributo.Sistema));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@TPCATEG", parametro.ConverterTipoCategoria(pAtributo.Categoria)));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@TPPARAM", pAtributo.Parametros));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@TPCONTEUDO", pAtributo.Conteudo ?? pAtributo.ConteudoDefault));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@TPDESC", pAtributo.Descricao));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@TPDTALT", DateTime.Now.Date));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@TPUSU", pAtributo.Usuario ?? string.Empty));

            db.ExecutaComandoSQL(GI_SP_INCPARAMETROS, parametros);
        }











    }
}
