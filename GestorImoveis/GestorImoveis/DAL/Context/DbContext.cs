using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorImoveis.DAL.Context
{
    class DbContext
    {
        string strConexao;
        SqlConnection SQLConexao;
        static DbContext instancia;



        public DbContext()
        {
            strConexao = @"Server=(LocalDB)\MSSQLLocalDB;Database=GestorImoveis;Trusted_Connection=True;";
            SQLConexao = new SqlConnection(strConexao);
        }

        public static DbContext Instancia
        {
            get
            {
                if (instancia == null)
                    instancia = new DbContext();
                return instancia;
            }
        }



        private void ConectaDataBase()
        {
            SQLConexao.Open();
        }

        private void DesconectaDataBase()
        {
            SQLConexao.Close();
        }

        public void ExecutaComandoSQL(string pProcedure, List<SqlParameter> pParametro)
        {

            SqlCommand sqlcommand = new SqlCommand();
            sqlcommand.Connection = SQLConexao;
            sqlcommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlcommand.CommandText = pProcedure;
            foreach (var item in pParametro)
                sqlcommand.Parameters.Add(item);

            ConectaDataBase();
            try
            {
                sqlcommand.ExecuteNonQuery();
            }
            finally
            {
                DesconectaDataBase();
            }

        }

        public DataSet ConsultaSQL(string pProcedure, List<SqlParameter> pParametro)
        {

            SqlCommand sqlcommand = new SqlCommand();
            sqlcommand.Connection = SQLConexao;
            sqlcommand.CommandType = CommandType.StoredProcedure;
            sqlcommand.CommandText = pProcedure;

            if(pParametro != null)
            {
                foreach (var item in pParametro)
                    sqlcommand.Parameters.Add(item);
            }
            

            SqlDataAdapter adapter = new SqlDataAdapter(sqlcommand);
            DataSet ds = new DataSet();
            ConectaDataBase();

            try
            {
                adapter.Fill(ds);
            }
            finally
            {
                DesconectaDataBase();
            }


            return ds;
        }


    }
}
