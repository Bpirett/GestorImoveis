using GestorImoveis.DAL.Context;
using GestorImoveis.DML;
using GestorImoveis.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorImoveis.DAL.Clientes
{
    public class DalCliente
    {
        #region Constantes

        private const string GI_SP_INCCLIENTE = "GI_SP_IncCliente";

        private const string GI_SP_CONSULTIMOCODCLI = "GI_SP_ObterUltCodCli";

        private const string GI_SP_VALEXISTCODCLI = "GI_SP_ExisteCodCli";

        private const string GI_SP_CONSULTACLIENTES = "GI_SP_ConsultaAllCliente";

        private const string GI_SP_ATULIZACLIENTE = "GI_SP_AlteraCliente";

        private const string GI_SP_VALEXISTENCIACPF = "GI_SP_ExisteCpfCli";

        private const string GI_SP_OBTERCLIENTE = "GI_SP_ObterClientes";

        private const string GI_SP_INCLOGCLI = "GI_SP_IncLogCliente";

        private const string GI_SP_COUNTCLIENTES = "GI_SP_CountClientes";

        private const string GI_SP_OBTERLOCADOR = "GI_SP_ObterLocador";

        private const string GI_SP_OBTERLOCATARIO = "GI_SP_ObterLocatario";

        #endregion
        public string ObterUltCodCli()
        {
            string UltimoCodcli = "0";

            DbContext db = new DbContext();
            DataSet ds = db.ConsultaSQL(GI_SP_CONSULTIMOCODCLI, null);

            if (ds != null && ds.Tables != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    UltimoCodcli = row.Field<string>("CODCLI");
                }
            }
            return UltimoCodcli;
        }


        public void IncluirCliente(Cliente pCliente)
        {
            List<System.Data.SqlClient.SqlParameter> parametros = new List<System.Data.SqlClient.SqlParameter>();
            DbContext db = new DbContext();
           

            parametros.Add(new System.Data.SqlClient.SqlParameter("NomeCli", pCliente.Nome));
            parametros.Add(new System.Data.SqlClient.SqlParameter("CPFCli", pCliente.CPF));
            parametros.Add(new System.Data.SqlClient.SqlParameter("CodCli", pCliente.Codigo));
            parametros.Add(new System.Data.SqlClient.SqlParameter("TelefCli", pCliente.TelefoneFixo));
            parametros.Add(new System.Data.SqlClient.SqlParameter("CelCli", pCliente.Celular));
            parametros.Add(new System.Data.SqlClient.SqlParameter("EmailCli", pCliente.Email));
            parametros.Add(new System.Data.SqlClient.SqlParameter("TipoCli", pCliente.tipoCliente));
            parametros.Add(new System.Data.SqlClient.SqlParameter("DATACADCLI", DateTime.Now));
            parametros.Add(new System.Data.SqlClient.SqlParameter("AtivoCli", UtilHelpers.ConverterTipoSituacao(pCliente.ClienteAtivo)));
            parametros.Add(new System.Data.SqlClient.SqlParameter("CEPCLI", pCliente.Endereco.Cep));
            parametros.Add(new System.Data.SqlClient.SqlParameter("ENDCLI", pCliente.Endereco.End));
            parametros.Add(new System.Data.SqlClient.SqlParameter("NUMIMOVCLI", pCliente.Endereco.NumeroImovel));
            parametros.Add(new System.Data.SqlClient.SqlParameter("BAIRROCLI", pCliente.Endereco.Bairro));
            parametros.Add(new System.Data.SqlClient.SqlParameter("CIDADECLI", pCliente.Endereco.Cidade));
            parametros.Add(new System.Data.SqlClient.SqlParameter("UFCLI", pCliente.Endereco.Uf));
            parametros.Add(new System.Data.SqlClient.SqlParameter("COMPLCLI", pCliente.Endereco.Complemento));
            parametros.Add(new System.Data.SqlClient.SqlParameter("COMPL2CLI", pCliente.Endereco.Complemento2));


            db.ExecutaComandoSQL(GI_SP_INCCLIENTE, parametros);
        }


        public void AtualizarCliente(Cliente pCliente)
        {
            List<System.Data.SqlClient.SqlParameter> parametros = new List<System.Data.SqlClient.SqlParameter>();

            parametros.Add(new System.Data.SqlClient.SqlParameter("NomeCli", pCliente.Nome));
            parametros.Add(new System.Data.SqlClient.SqlParameter("CPFCli", pCliente.CPF));
            parametros.Add(new System.Data.SqlClient.SqlParameter("CodCli", pCliente.Codigo));
            parametros.Add(new System.Data.SqlClient.SqlParameter("TelefCli", pCliente.TelefoneFixo));
            parametros.Add(new System.Data.SqlClient.SqlParameter("CelCli", pCliente.Celular));
            parametros.Add(new System.Data.SqlClient.SqlParameter("EmailCli", pCliente.Email));
            parametros.Add(new System.Data.SqlClient.SqlParameter("TipoCli", pCliente.tipoCliente));
            parametros.Add(new System.Data.SqlClient.SqlParameter("DataUltAltCli", DateTime.Now));
            parametros.Add(new System.Data.SqlClient.SqlParameter("AtivoCli", UtilHelpers.ConverterTipoSituacao(pCliente.ClienteAtivo)));
            parametros.Add(new System.Data.SqlClient.SqlParameter("CEPCLI", pCliente.Endereco.Cep));
            parametros.Add(new System.Data.SqlClient.SqlParameter("ENDCLI", pCliente.Endereco.End));
            parametros.Add(new System.Data.SqlClient.SqlParameter("NUMIMOVCLI", pCliente.Endereco.NumeroImovel));
            parametros.Add(new System.Data.SqlClient.SqlParameter("BAIRROCLI", pCliente.Endereco.Bairro));
            parametros.Add(new System.Data.SqlClient.SqlParameter("CIDADECLI", pCliente.Endereco.Cidade));
            parametros.Add(new System.Data.SqlClient.SqlParameter("UFCLI", pCliente.Endereco.Uf));
            parametros.Add(new System.Data.SqlClient.SqlParameter("COMPLCLI", pCliente.Endereco.Complemento));
            parametros.Add(new System.Data.SqlClient.SqlParameter("COMPL2CLI", pCliente.Endereco.Complemento2));

            DbContext db = new DbContext();
            db.ExecutaComandoSQL(GI_SP_ATULIZACLIENTE, parametros);

        }

        public bool ValidaExistenciaCodCli(string pCodcli)
        {

            List<System.Data.SqlClient.SqlParameter> parametros = new List<System.Data.SqlClient.SqlParameter>();
            parametros.Add(new System.Data.SqlClient.SqlParameter("CodCli", pCodcli));

            DbContext db = new DbContext();
            DataSet ds = db.ConsultaSQL(GI_SP_VALEXISTCODCLI, parametros);

            if (ds.Tables[0].Rows.Count > 0)
                return true;

            return false;
        }


        public bool ValidaExistenciaCPF(string pCPF)
        {

            List<System.Data.SqlClient.SqlParameter> parametros = new List<System.Data.SqlClient.SqlParameter>();
            parametros.Add(new System.Data.SqlClient.SqlParameter("CPFCLI", pCPF));

            DbContext db = new DbContext();
            DataSet ds = db.ConsultaSQL(GI_SP_VALEXISTENCIACPF, parametros);

            if (ds.Tables[0].Rows.Count > 0)
                return true;

            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pParam"></param>
        /// <returns></returns>
        public List<Cliente> ObterCliente(string pParam, string pFiltro)
        {
            List<Cliente> lstcliente = new List<Cliente>();

            List<System.Data.SqlClient.SqlParameter> parametros = new List<System.Data.SqlClient.SqlParameter>();

            parametros.Add(new System.Data.SqlClient.SqlParameter("FILTRO", pFiltro));
            parametros.Add(new System.Data.SqlClient.SqlParameter("VALOR", pParam));

            DbContext db = new DbContext();
            DataSet ds = db.ConsultaSQL(GI_SP_OBTERCLIENTE, parametros);

            if (ds != null && ds.Tables != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {

                DataTable dt = ds.Tables[0];

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Cliente cliente = new Cliente();
                    cliente.Endereco = new Endereco();

                    if (dt.Rows[i]["CODCLI"] != DBNull.Value)
                        cliente.Codigo = Convert.ToString(dt.Rows[i]["CODCLI"]);

                    if (dt.Rows[i]["NOMECLI"] != DBNull.Value)
                        cliente.Nome = Convert.ToString(dt.Rows[i]["NOMECLI"]);

                    if (dt.Rows[i]["CPFCLI"] != DBNull.Value)
                        cliente.CPF = Convert.ToString(dt.Rows[i]["CPFCLI"]);

                    if (dt.Rows[i]["EMAILCLI"] != DBNull.Value)
                        cliente.Email = Convert.ToString(dt.Rows[i]["EMAILCLI"]);

                    if (dt.Rows[i]["TELEFCLI"] != DBNull.Value)
                        cliente.TelefoneFixo = Convert.ToString(dt.Rows[i]["TELEFCLI"]);

                    if (dt.Rows[i]["CELCLI"] != DBNull.Value)
                        cliente.Celular = Convert.ToString(dt.Rows[i]["CELCLI"]);

                    if (dt.Rows[i]["ATIVOCLI"] != DBNull.Value)
                        cliente.ClienteAtivo = UtilHelpers.ConverterTipoSituacao(dt.Rows[i]["ATIVOCLI"].ToString());

                    if (dt.Rows[i]["TIPOCLI"] != DBNull.Value)
                        cliente.tipoCliente = Convert.ToString(dt.Rows[i]["TIPOCLI"]);

                    if (dt.Rows[i]["CEPCLI"] != DBNull.Value)
                        cliente.Endereco.Cep = Convert.ToString(dt.Rows[i]["CEPCLI"]);


                    if (dt.Rows[i]["ENDCLI"] != DBNull.Value)
                        cliente.Endereco.End = Convert.ToString(dt.Rows[i]["ENDCLI"]);


                    if (dt.Rows[i]["NUMIMOVCLI"] != DBNull.Value)
                        cliente.Endereco.NumeroImovel = Convert.ToInt32(dt.Rows[i]["NUMIMOVCLI"]);


                    if (dt.Rows[i]["BAIRROCLI"] != DBNull.Value)
                        cliente.Endereco.Bairro = Convert.ToString(dt.Rows[i]["BAIRROCLI"]);


                    if (dt.Rows[i]["CIDADECLI"] != DBNull.Value)
                        cliente.Endereco.Cidade = Convert.ToString(dt.Rows[i]["CIDADECLI"]);


                    if (dt.Rows[i]["UFCLI"] != DBNull.Value)
                        cliente.Endereco.Uf = Convert.ToString(dt.Rows[i]["UFCLI"]);


                    if (dt.Rows[i]["COMPLCLI"] != DBNull.Value)
                        cliente.Endereco.Complemento = Convert.ToString(dt.Rows[i]["COMPLCLI"]);


                    if (dt.Rows[i]["COMPL2CLI"] != DBNull.Value)
                        cliente.Endereco.Complemento2 = Convert.ToString(dt.Rows[i]["COMPL2CLI"]);
                   

                    lstcliente.Add(cliente);
                }

            }

            return lstcliente;
        }



        public List<Cliente> ConsultaClientes()
        {
            List<Cliente> lstcliente = new List<Cliente>();

            DbContext db = new DbContext();
            DataSet ds = db.ConsultaSQL(GI_SP_CONSULTACLIENTES, null);

            if (ds != null && ds.Tables != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {

                DataTable dt = ds.Tables[0];

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Cliente cliente = new Cliente();
                    cliente.Endereco = new Endereco();
                    if (dt.Rows[i]["CODCLI"] != DBNull.Value)
                        cliente.Codigo = Convert.ToString(dt.Rows[i]["CODCLI"]);

                    if (dt.Rows[i]["NOMECLI"] != DBNull.Value)
                        cliente.Nome = Convert.ToString(dt.Rows[i]["NOMECLI"]);

                    if (dt.Rows[i]["CPFCLI"] != DBNull.Value)
                        cliente.CPF = Convert.ToString(dt.Rows[i]["CPFCLI"]);

                    if (dt.Rows[i]["EMAILCLI"] != DBNull.Value)
                        cliente.Email = Convert.ToString(dt.Rows[i]["EMAILCLI"]);

                    if (dt.Rows[i]["TELEFCLI"] != DBNull.Value)
                        cliente.TelefoneFixo = Convert.ToString(dt.Rows[i]["TELEFCLI"]);

                    if (dt.Rows[i]["CELCLI"] != DBNull.Value)
                        cliente.Celular = Convert.ToString(dt.Rows[i]["CELCLI"]);

                    if (dt.Rows[i]["ATIVOCLI"] != DBNull.Value)
                        cliente.ClienteAtivo = UtilHelpers.ConverterTipoSituacao(dt.Rows[i]["ATIVOCLI"].ToString());

                    if (dt.Rows[i]["TIPOCLI"] != DBNull.Value)
                        cliente.tipoCliente = Convert.ToString(dt.Rows[i]["TIPOCLI"]);


                    if (dt.Rows[i]["CEPCLI"] != DBNull.Value)
                        cliente.Endereco.Cep = Convert.ToString(dt.Rows[i]["CEPCLI"]);


                    if (dt.Rows[i]["ENDCLI"] != DBNull.Value)
                        cliente.Endereco.End = Convert.ToString(dt.Rows[i]["ENDCLI"]);


                    if (dt.Rows[i]["NUMIMOVCLI"] != DBNull.Value)
                        cliente.Endereco.NumeroImovel = Convert.ToInt32(dt.Rows[i]["NUMIMOVCLI"]);


                    if (dt.Rows[i]["BAIRROCLI"] != DBNull.Value)
                        cliente.Endereco.Bairro = Convert.ToString(dt.Rows[i]["BAIRROCLI"]);


                    if (dt.Rows[i]["CIDADECLI"] != DBNull.Value)
                        cliente.Endereco.Cidade = Convert.ToString(dt.Rows[i]["CIDADECLI"]);


                    if (dt.Rows[i]["UFCLI"] != DBNull.Value)
                        cliente.Endereco.Uf = Convert.ToString(dt.Rows[i]["UFCLI"]);


                    if (dt.Rows[i]["COMPLCLI"] != DBNull.Value)
                        cliente.Endereco.Complemento = Convert.ToString(dt.Rows[i]["COMPLCLI"]);


                    if (dt.Rows[i]["COMPL2CLI"] != DBNull.Value)
                        cliente.Endereco.Complemento2 = Convert.ToString(dt.Rows[i]["COMPL2CLI"]);

                    lstcliente.Add(cliente);
                }
                
            }

            return lstcliente;
        }

        public void GravarLogCliente(Cliente pCliente)
        {
            List<System.Data.SqlClient.SqlParameter> parametros = new List<System.Data.SqlClient.SqlParameter>();
            DbContext db = new DbContext();


            parametros.Add(new System.Data.SqlClient.SqlParameter("CLNOME", pCliente.Nome));
            parametros.Add(new System.Data.SqlClient.SqlParameter("CLCPF", pCliente.CPF));
            parametros.Add(new System.Data.SqlClient.SqlParameter("CLCODCLI", pCliente.Codigo));
            parametros.Add(new System.Data.SqlClient.SqlParameter("CLTELEF", pCliente.TelefoneFixo));
            parametros.Add(new System.Data.SqlClient.SqlParameter("CLCEL", pCliente.Celular));
            parametros.Add(new System.Data.SqlClient.SqlParameter("CLEMAIL", pCliente.Email));
            parametros.Add(new System.Data.SqlClient.SqlParameter("CLTIPO", pCliente.tipoCliente));
            parametros.Add(new System.Data.SqlClient.SqlParameter("CLDATACAD", DateTime.Now));
            parametros.Add(new System.Data.SqlClient.SqlParameter("CLATIVO", UtilHelpers.ConverterTipoSituacao(pCliente.ClienteAtivo)));
            parametros.Add(new System.Data.SqlClient.SqlParameter("CLCEP", pCliente.Endereco.Cep));
            parametros.Add(new System.Data.SqlClient.SqlParameter("CLEND", pCliente.Endereco.End));
            parametros.Add(new System.Data.SqlClient.SqlParameter("CLNUMIMOV", pCliente.Endereco.NumeroImovel));
            parametros.Add(new System.Data.SqlClient.SqlParameter("CLBAIRRO", pCliente.Endereco.Bairro));
            parametros.Add(new System.Data.SqlClient.SqlParameter("CLCIDADE", pCliente.Endereco.Cidade));
            parametros.Add(new System.Data.SqlClient.SqlParameter("CLUF", pCliente.Endereco.Uf));
            parametros.Add(new System.Data.SqlClient.SqlParameter("CLCOMPL", pCliente.Endereco.Complemento));
            parametros.Add(new System.Data.SqlClient.SqlParameter("CLCOMPL2", pCliente.Endereco.Complemento2));


            db.ExecutaComandoSQL(GI_SP_INCLOGCLI, parametros);
        }

        public int CountClientes()
        {
            DbContext db = new DbContext();
            DataSet ds = db.ConsultaSQL(GI_SP_COUNTCLIENTES, null);
            DataTable dt = ds.Tables[0];
            return Convert.ToInt32(dt.Rows[0]["QUANTIDADE"].ToString());
        }

        public int CountLocatarios()
        {
            List<System.Data.SqlClient.SqlParameter> parametros = new List<System.Data.SqlClient.SqlParameter>();
            parametros.Add(new System.Data.SqlClient.SqlParameter("@TIPOCLIENTE", "Locatario"));

            DbContext db = new DbContext();
            DataSet ds = db.ConsultaSQL(GI_SP_COUNTCLIENTES, parametros);
            DataTable dt = ds.Tables[0];
            return Convert.ToInt32(dt.Rows[0]["QUANTIDADE"].ToString());
        }

        public int CountLocadores()
        {
            List<System.Data.SqlClient.SqlParameter> parametros = new List<System.Data.SqlClient.SqlParameter>();
            parametros.Add(new System.Data.SqlClient.SqlParameter("@TIPOCLIENTE", "Locador"));

            DbContext db = new DbContext();
            DataSet ds = db.ConsultaSQL(GI_SP_COUNTCLIENTES, parametros);
            DataTable dt = ds.Tables[0];
            return Convert.ToInt32(dt.Rows[0]["QUANTIDADE"].ToString());
        }

        public List<string> ObterLocador(string pCodLocador)
        {
            List<string> lstcontrato = new List<string>();

            List<System.Data.SqlClient.SqlParameter> parametros = new List<System.Data.SqlClient.SqlParameter>();

            parametros.Add(new System.Data.SqlClient.SqlParameter("CODCLI", pCodLocador));


            DbContext db = new DbContext();
            DataSet ds = db.ConsultaSQL(GI_SP_OBTERLOCADOR, parametros);

            if (ds != null && ds.Tables != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {

                DataTable dt = ds.Tables[0];

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Contrato contrato = new Contrato();
                    if (dt.Rows[i]["NOMECLI"] != DBNull.Value)
                        contrato.Locador = Convert.ToString(dt.Rows[i]["NOMECLI"]);

                    lstcontrato.Add(contrato.Locador);
                }

            }

            return lstcontrato;
        }

        public List<string> ObterLocatario(string pCodLocatario)
        {
            List<string> lstcontrato = new List<string>();

            List<System.Data.SqlClient.SqlParameter> parametros = new List<System.Data.SqlClient.SqlParameter>();

            parametros.Add(new System.Data.SqlClient.SqlParameter("CODCLI", pCodLocatario));


            DbContext db = new DbContext();
            DataSet ds = db.ConsultaSQL(GI_SP_OBTERLOCATARIO, parametros);

            if (ds != null && ds.Tables != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {

                DataTable dt = ds.Tables[0];

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Contrato contrato = new Contrato();
                    if (dt.Rows[i]["NOMECLI"] != DBNull.Value)
                        contrato.Locador = Convert.ToString(dt.Rows[i]["NOMECLI"]);

                    lstcontrato.Add(contrato.Locador);
                }

            }

            return lstcontrato;
        }




    }
}
