using GestorImoveis.DAL.Parametro;
using GestorImoveis.DML;
using GestorImoveis.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GestorImoveis.BLL
{
    public class BoParametro
    {
        #region Parametros

        [AtributoParametro(Sistema = "GI", Categoria = Parametro.ParametroCategoria.Boletos, Parametros = "R_DIRMOBOL", Descricao = "Define Diretorio onde se encontra o documento modelo de boletos", ConteudoDefault = @"E:\Projetos\GestorImoveis\GestorImoveis\GestorImoveis\Template.docx")]
        public static string R_DIRMOBOL
        {
            get
            {
                return BoParametro.ObterValueParametros("R_DIRMOBOL");
            }

        }

        [AtributoParametro(Sistema = "GI", Categoria = Parametro.ParametroCategoria.Boletos, Parametros = "R_WSSPIMOV", Descricao = "URL de integração com o portal da SP imoveis", ConteudoDefault = "")]
        public static string R_WSSPIMOV
        {
            get
            {
                return BoParametro.ObterValueParametros("R_WSSPIMOV");
            }

        }


        [AtributoParametro(Sistema = "GI", Categoria = Parametro.ParametroCategoria.Anuncios, Parametros = "R_DIRANUN", Descricao = "Define Diretorio de imagens de anuncios", ConteudoDefault = @"C:\GestorImoveis\FotosAnuncio")]
        public static string R_DIRANUN
        {
            get
            {
                return BoParametro.ObterValueParametros("R_DIRANUN");
            }

        }

        [AtributoParametro(Sistema = "GI", Categoria = Parametro.ParametroCategoria.Contratos, Parametros = "R_DIRDIGIT", Descricao = "Define diretorio de digitalização de documentos do aluguel", ConteudoDefault = @"C:\GestorImoveis\DocumentosDigitalizados")]
        public static string R_DIRDIGIT
        {
            get
            {
                return BoParametro.ObterValueParametros("R_DIRDIGIT");
            }

        }

        [AtributoParametro(Sistema = "GI", Categoria = Parametro.ParametroCategoria.Geral, Parametros = "R_DIRLOGER", Descricao = "Define diretorio de Log de erro da Aplicação", ConteudoDefault = @"C:\GestorImoveis\Log")]
        public static string R_DIRLOGER
        {
            get
            {
                return BoParametro.ObterValueParametros("R_DIRLOGER");
            }

        }

        [AtributoParametro(Sistema = "GI", Categoria = Parametro.ParametroCategoria.Geral, Parametros = "R_DIRDOWND", Descricao = "Define diretorio de download", ConteudoDefault = "")]
        public static string R_DIRDOWND
        {
            get
            {
                return BoParametro.ObterValueParametros("R_DIRDOWND");
            }

        }

        [AtributoParametro(Sistema = "GI", Categoria = Parametro.ParametroCategoria.Contratos, Parametros = "C_PORADMIN", Descricao = "Define a porcentagem da administração", ConteudoDefault = "8")]
        public static string C_PORADMIN
        {
            get
            {
                return BoParametro.ObterValueParametros("C_PORADMIN");
            }

        }

        [AtributoParametro(Sistema = "GI", Categoria = Parametro.ParametroCategoria.Contratos, Parametros = "C_VALENTRA", Descricao = "Define se data de entrada e menor ou não", ConteudoDefault = "S")]
        public static bool C_VALENTRA
        {
            get
            {
                return UtilHelpers.ConverterSimNao(BoParametro.ObterValueParametros("C_VALENTRA"));
            }

        }



        #endregion

        #region Metodos


        public List<Parametro> ConsultaParametro()
        {
            DalParametro dalParametro = new DalParametro();
            return dalParametro.ConsultaParametros();
        }

        public void AlterarParametro(Parametro pParametro)
        {
            DalParametro dalParametro = new DalParametro();
            dalParametro.AlterarParametro(pParametro);
        }

        private static string ObterValueParametros(string pParametro)
        {
            DalParametro dalParametro = new DalParametro();
            string retorno = dalParametro.ObterValueParametros(pParametro);

            return retorno;
        }



        public static Parametro ObterParametro(string pSistema, string pParametro, Parametro.ParametroCategoria pCategoria)
        {
            DalParametro dalParametro = new DalParametro();
            Parametro retorno = dalParametro.ObterParametro(pSistema, pParametro, pCategoria);

            return retorno;
        }

        public void IncluirParametro(AtributoParametro pAtributo)
        {
            DalParametro dalParametro = new DalParametro();
            dalParametro.InserirParametro(pAtributo);
        }


        public static void InicialParameter()
        {
            BoParametro boParametro = new BoParametro();

            Type ParametrosType = typeof(BoParametro);
            PropertyInfo[] properties = ParametrosType.GetProperties();

            List<string> NomeParametro = new List<string>();

            List<Parametro> parametros = new List<Parametro>();
            parametros = boParametro.ConsultaParametro();
            foreach (var propertyInfo in properties)
            {

                var t = parametros.Find(p => p.Parametros == propertyInfo.Name);

                bool existe = false;

                if (t != null)
                {
                    existe = true;
                }

                if (!existe)
                {
                    AtributoParametro atributoParametro = boParametro.ResgatarAtributoPorNome(propertyInfo.Name);
                    boParametro.IncluirParametro(atributoParametro);
                }
            }
        }

        private AtributoParametro ResgatarAtributoPorNome(string pNomeParametro)
        {
            AtributoParametro atributo = null;

            List<AtributoParametro> listaAtributosParametros = ResgatarAtributosDasPropriedades();

            foreach (AtributoParametro atributos in listaAtributosParametros)
            {
                if ((atributos != null) && (atributos.Parametros == pNomeParametro))
                {
                    atributo = atributos;
                    break;
                }
            }

            return atributo;
        }



        private List<AtributoParametro> ResgatarAtributosDasPropriedades()
        {
            List<AtributoParametro> ListaAtributoParametros = new List<AtributoParametro>();

            AtributoParametro atributo = null;
            PropertyInfo[] properties = this.GetType().GetProperties(BindingFlags.Static | BindingFlags.Instance | BindingFlags.Public);

            foreach (var info in properties)
            {
                object[] atributos = info.GetCustomAttributes(typeof(AtributoParametro), false);

                if ((atributos != null) && (atributos.Length > 0))
                {
                    for (int i = 0; i < atributos.Length; i++)
                    {
                        atributo = (AtributoParametro)atributos[i];

                        ListaAtributoParametros.Add(atributo);
                    }
                }
            }

            return ListaAtributoParametros;
        }





        #endregion


    }
}
