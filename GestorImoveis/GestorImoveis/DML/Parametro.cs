using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorImoveis.DML
{
    public class Parametro
    {

        public string Sistema { get; set; }
        public ParametroCategoria Categoria { get; set; }
        public string Parametros { get; set; }
        public string Conteudo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataAtualizacao { get; set; }
        public string Usuario { get; set; }

        public string ConteudoDefault { get; set; }


        public enum ParametroCategoria
        {
            Integracoes,
            Boletos,
            Contratos,
            Relatorios,
            Clientes,
            Geral,
            Anuncios
        }




        public  ParametroCategoria ConverterTipoCategoria(string ptipo)
        {
            switch (ptipo)
            {
                case "Integracoes":
                    return ParametroCategoria.Integracoes;
                case "Contratos":
                    return ParametroCategoria.Contratos;
                case "Clientes":
                    return ParametroCategoria.Clientes;
                case "Boletos":
                    return ParametroCategoria.Boletos;
                case "Relatorios":
                    return ParametroCategoria.Relatorios;
                case "Anuncios":
                    return ParametroCategoria.Anuncios;
                default: return ParametroCategoria.Geral;
            }
        }

        public  string ConverterTipoCategoria(ParametroCategoria ptipo)
        {
            switch (ptipo)
            {
                case ParametroCategoria.Integracoes:
                    return "Integracoes";
                case ParametroCategoria.Boletos:
                    return "Boletos";
                case ParametroCategoria.Contratos:
                    return "Contratos";
                case ParametroCategoria.Clientes:
                    return "Clientes";
                case ParametroCategoria.Relatorios:
                    return "Relatorios";
                case ParametroCategoria.Anuncios:
                    return "Anuncios";
                default: return "Geral";
            }
        }
    }
}
