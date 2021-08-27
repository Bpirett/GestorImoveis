using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestorImoveis.BLL;
using GestorImoveis.Forms;

namespace GestorImoveis
{
    public partial class UcRelContratos : UserControl
    {
        public UcRelContratos()
        {
            InitializeComponent();
            BoContrato boContrato = new BoContrato();
            cbo_Pesq.DataSource = boContrato.ConsulContratos();
        }

        private void btn_Gerar_Click(object sender, EventArgs e)
        {
            BoRelatorio boRelatorio = new BoRelatorio();
            DML.Relatorio relatorio = new DML.Relatorio();

            string pValor = cbo_Pesq.Text;

            boRelatorio.RelContratos(relatorio, pValor);
            ReportViewerForm reportViewerForm = new ReportViewerForm(relatorio);
            reportViewerForm.Show();
        }
    }
}
