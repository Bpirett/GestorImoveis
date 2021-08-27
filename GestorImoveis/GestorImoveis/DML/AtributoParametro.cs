using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorImoveis.DML
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
    
    [Serializable]
    public class AtributoParametro: Attribute
    {

        public string Sistema { get; set; }
        public Parametro.ParametroCategoria Categoria { get; set; }
        public string Parametros { get; set; }
        public string Conteudo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataAtualizacao { get; set; }
        public string Usuario { get; set; }

        public string ConteudoDefault { get; set; }








    }
}
