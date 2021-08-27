using GestorImoveis.DAL.Context;
using GestorImoveis.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorImoveis.DAL.Relatorio
{
    public class DalRelatorio
    {
        #region Constantes

        private const string GI_SP_RELLISTAANUNCIO = "GI_SP_RelListaAnuncio";
        private const string GI_SP_RELLISTACLIENTE = "GI_SP_RelListaClientes";
        private const string GI_SP_RELCONTRATOS = "GI_SP_RelContratos";

        #endregion

        public DataTable RelListaAnuncio(string pfiltro, string pValor)
        {

            List<System.Data.SqlClient.SqlParameter> parametros = new List<System.Data.SqlClient.SqlParameter>();
            parametros.Add(new System.Data.SqlClient.SqlParameter("@FILTRO", pfiltro));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@VALOR", pValor));


            DbContext db = new DbContext();
            DataSet ds = db.ConsultaSQL(GI_SP_RELLISTAANUNCIO, parametros);

            DataTable dataTable = ds.Tables[0];
            return dataTable;
        }

        public DataTable RelListaClientes(string pfiltro, string pValor)
        {
            List<System.Data.SqlClient.SqlParameter> parametros = new List<System.Data.SqlClient.SqlParameter>();
            parametros.Add(new System.Data.SqlClient.SqlParameter("@FILTRO", pfiltro));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@VALOR", pValor));

            DbContext db = new DbContext();
            DataSet ds = db.ConsultaSQL(GI_SP_RELLISTACLIENTE, parametros);

            DataTable dataTable = ds.Tables[0];
            return dataTable;
        }

        public DataTable RelContratos(string pValor)
        {
            List<System.Data.SqlClient.SqlParameter> parametros = new List<System.Data.SqlClient.SqlParameter>();
            parametros.Add(new System.Data.SqlClient.SqlParameter("@CODCONTRATO", pValor));

            DbContext db = new DbContext();
            DataSet ds = db.ConsultaSQL(GI_SP_RELCONTRATOS, parametros);
            DataTable dataTable = ds.Tables[0];

            dataTable.Rows[0]["SITCONTR"] = ConverterSitcontrato(dataTable.Rows[0]["SITCONTR"].ToString());

            return dataTable;
        }


        public string ConverterSitcontrato(string pSitContrato)
        {
            switch (pSitContrato)
            {
                case "FIN":
                    return "Finalizado";
                case "CAN":
                    return "Cancelado";
                case "REN":
                    return "Renovado";
                default:
                    return "Andamento";
            }

        }

    }
}
