using GestorImoveis.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorImoveis.DML
{
    public class Anuncio
    {

        public string Codigo { get; set; }
        public double Valor { get; set; }
        public string Endereco { get; set; }
        public double VlrIptu { get; set; }
        public string TipoImovel { get; set; }
        public string Negocio { get; set; }
        public string Regiao { get; set; }
        public int Dormitorio { get; set; }
        public int Suites { get; set; }
        public int Vagas { get; set; }
        public int Area { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Proprietario { get; set; }
        public string Obs { get; set; }
        public DateTime DataCadastro { get; set; }
        public UtilHelpers.TipoSituacao Ativo { get; set; }
        public DateTime DataAtualizacao { get; set; }
        public bool Permuta { get; set; }
        public bool Churrasqueira { get; set; }
        public bool Piscina { get; set; }
        public bool Brinquedoteca { get; set; }
        public bool Playgroud { get; set; }
        public bool Poliesportiva { get; set; }
        public bool Ginastica { get; set; }
        public bool Festas { get; set; }
        public bool Jogos { get; set; }

    }
}
