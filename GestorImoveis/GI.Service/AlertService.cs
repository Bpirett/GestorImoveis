using GestorImoveis.BLL;
using GestorImoveis.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GI.Service
{
    public class AlertService
    {

        #region Metodos


        public void AlertBoletosVencer()
        {
            BoBoletos boBoletos = new BoBoletos();
            bool ExibeMsg = boBoletos.BoletosVencer();

            if (true)
            {
                string Msg = "";
                Msg = $"Hoje tem boletos a vencer!";
                AlertForm alert = new AlertForm();
               
            }
        }


        #endregion





    }
}
