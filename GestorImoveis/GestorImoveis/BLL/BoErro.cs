using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GestorImoveis.BLL
{
    public class BoErro : Exception
    {
        #region Constantes

        public const int CODIGO_SISTEMA_ERRO = 0010000;

        public const int CERRO_CPFEXISTENTE = 100000;

        public const int CERRO_CAMPOOBRIGATORIO = 100001;

        public const int CERRO_DATA_INVALIDA_NO_ANO_CORRENTE = 100002;

        public const int CERRO_DATA_INVALIDA = 100003;

        public const int CERRO_CPF_INVALIDO = 100004;

        #endregion

        #region Exception

        public const int CERRO_EXCEPTION = 9999;

        #endregion



        #region Metodos
        public BoErro(string pMsg)
        {
            throw new BoErro(CERRO_EXCEPTION, pMsg);
        }

        public BoErro(int pCodErro, string pMsg)
            :base (pMsg)
        {

        }

        public BoErro(SerializationInfo pCodErro, StreamingContext pMsg)
           : base(pCodErro, pMsg)
        {
        }


        public static string DesErro(int pCodErro, string[] pAux)
        {
            switch (pCodErro)
            {
                case CERRO_EXCEPTION: return string.Format("Erro Generico: {0}", pAux[0]);
                case CERRO_CPFEXISTENTE: return string.Format("CPF {0} já cadastrado: ", pAux[0]);
                case CERRO_CAMPOOBRIGATORIO: return string.Format("O campo {0} é obrigatorio!: ", pAux[0]);
                case CERRO_DATA_INVALIDA_NO_ANO_CORRENTE: return string.Format("Campo {0} com data Invalida! Informar uma data do ano atual.", pAux[0]);
                case CERRO_DATA_INVALIDA: return string.Format("Compo {0} com data Invalida!", pAux[0]);
                case CERRO_CPF_INVALIDO: return string.Format("CPF {0} invalido: !", pAux[0]);
                default: return ("Erro Desconhecido. Codigo: " + pCodErro);
            }
        }

        public static void DesErro(int pCodErro)
        {
            string[] tmp = { string.Empty };
            throw new BoErro(DesErro(pCodErro, tmp));
        }

        public static void DesErro(int pCodErro, string pMsg)
        {
            string[] tmp = { pMsg };
            throw new BoErro(DesErro(pCodErro, tmp));
        }

        #endregion

    }
}
