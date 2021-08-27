using GestorImoveis.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorImoveis.DML
{
    public class Cliente
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string TelefoneFixo { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public string tipoCliente { get; set; }
        public UtilHelpers.TipoSituacao ClienteAtivo { get; set; }
        public Endereco Endereco { get; set; }
    }






}
