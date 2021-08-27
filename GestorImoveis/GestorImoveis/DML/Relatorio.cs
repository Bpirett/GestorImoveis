using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorImoveis.DML
{
   public class Relatorio
    {
        public ReportDataSource DataSource { get; set; }
        public string PathReport { get; set; }

    }
}
