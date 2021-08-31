using GestorImoveis.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorImoveis.Forms
{
    public partial class InicioResumo : Form
    {
        public InicioResumo()
        {
            InitializeComponent();
            MontarAmbiente();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToString("hh:mm:ss ");
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void TimeResumo_Tick(object sender, EventArgs e)
        {
            BoCliente boCliente = new BoCliente();
            BoContrato boContrato = new BoContrato();
            BoAnuncio boAnuncio = new BoAnuncio();

            lblAnuncios.Text = boAnuncio.CountAnuncios().ToString();
            lblContratos.Text = boContrato.CountContratos().ToString();
            lblClientes.Text = boCliente.CountClientes().ToString();
            lblLocadores.Text = boCliente.CountLocadores().ToString();
            lblLocatarios.Text = boCliente.CountLocatarios().ToString();
        }



        #region Metodos

        private void MontarAmbiente()
        {
            BoCliente boCliente = new BoCliente();
            BoContrato boContrato = new BoContrato();
            BoAnuncio boAnuncio = new BoAnuncio();

            lblAnuncios.Text = boAnuncio.CountAnuncios().ToString();
            lblContratos.Text = boContrato.CountContratos().ToString();
            lblClientes.Text = boCliente.CountClientes().ToString();
            lblLocadores.Text = boCliente.CountLocadores().ToString();
            lblLocatarios.Text = boCliente.CountLocatarios().ToString();
        }


            #endregion


        }
}
