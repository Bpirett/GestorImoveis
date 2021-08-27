using GestorImoveis.DML;
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
    public partial class ReportViewerForm : Form
    {
        public ReportViewerForm(Relatorio pRelatorio)
        {
            InitializeComponent();

            reportViewer1.LocalReport.ReportPath = pRelatorio.PathReport;
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(pRelatorio.DataSource);
            reportViewer1.RefreshReport();
        }

        private void ReportViewerForm_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
