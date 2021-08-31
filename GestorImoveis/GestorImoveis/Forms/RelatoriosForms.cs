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
    public partial class RelatoriosForms : Form
    {
        #region Construtotor
        public RelatoriosForms()
        {
            InitializeComponent();
            List<string> lista = new List<string>();
            string[] relatorios = { "Selecionar", "Relatorio de Anuncios", "Relatorio de Clientes", "Relatorio de Contratos", "Extrato de Boletos" };
            cboRelatorio.DataSource = relatorios;
        }
        #endregion

        #region Eventos
        private void cboRelatorio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboRelatorio.Text == "Relatorio de Anuncios")
            {
                ucListaAnuncio1.Show();
                ucListaAnuncio1.BringToFront();

                ucRelContratos1.Hide();
                ucRelListaClientes1.Hide();
                ucRelBoletos1.Hide();
            }
            else if (cboRelatorio.Text == "Relatorio de Clientes")
            {
                ucRelListaClientes1.Show();
                ucRelListaClientes1.BringToFront();

                ucListaAnuncio1.Hide();
                ucRelContratos1.Hide();
                ucRelBoletos1.Hide();
            }
            else if (cboRelatorio.Text == "Relatorio de Contratos")
            {
                ucRelContratos1.Show();
                ucRelContratos1.BringToFront();

                ucListaAnuncio1.Hide();
                ucRelListaClientes1.Hide();
                ucRelBoletos1.Hide();
            }
            else if (cboRelatorio.Text == "Extrato de Boletos")
            {
                ucRelBoletos1.Show();

                ucListaAnuncio1.Hide();
                ucRelListaClientes1.Hide();
                ucRelContratos1.Hide();
            }
            else
            {
                ucListaAnuncio1.Hide();
                ucRelListaClientes1.Hide();
                ucRelContratos1.Hide();
                ucRelBoletos1.Hide();
            }
        }

        #endregion



        #region Metodo
        #endregion

        private void RelatoriosForms_Load(object sender, EventArgs e)
        {
            ucListaAnuncio1.Hide();
            ucRelListaClientes1.Hide();
            ucRelContratos1.Hide();
            ucRelBoletos1.Hide();
        }
    }
}
