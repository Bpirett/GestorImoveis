using GestorImoveis.DAL.Boletos;
using GestorImoveis.DAL.Relatorio;
using GestorImoveis.DML;
using GestorImoveis.Helpers;
using Microsoft.Reporting.WinForms;
using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;
using System;
using System.Data;
using System.IO;



namespace GestorImoveis.BLL
{
    public class BoRelatorio
    {
        /// <summary>
        /// BoletoModelo.docx
        /// </summary>
        public void EmitirBoleto(string pCodContrato, string pCodBoleto, string pNumBoleto)
        {
            Stream docStream = File.OpenRead(Path.GetFullPath(BoParametro.R_DIRMOBOL));
            WordDocument document = new WordDocument(docStream, FormatType.Docx);
            docStream.Dispose();

            string[] fieldNames = { "RefBoleto", "VlrAluguel", "VlrIptu", "VlrDesc", "VlrMulta", "VlrOutros", "VlrTotal", "VlrAdmin", "Locatario", "Locador", "TipoImovel", "EnderecoImovel", "DataIni", "DataFim", "DataVencimentor", "DataAtual", "NumParcela" };

            BoBoletos boBoletos = new BoBoletos();
            var table = boBoletos.ObterBoletoRel(pCodContrato, pCodBoleto, pNumBoleto);

            string[] fieldValues = { table[0].Codigo.ToString(), table[0].Valor.ToString("C2"), table[0].VlrIptu.ToString("C2"), table[0].VlrDesconto.ToString("C2"), table[0].VlrMulta.ToString("C2"), "0,00", table[0].Valor.ToString("C2"), table[0].VlrComissao.ToString("C2"),
            table[0].Locatario,table[0].Locador ,table[0].TipoImovel, table[0].Endereco, UtilHelpers.ConverteData(table[0].PeriodoInicio), UtilHelpers.ConverteData(table[0].PeriodoFim), UtilHelpers.ConverteData(table[0].DataVencimento), DateTime.Now.ToLongDateString(), table[0].NumBoleto.ToString() };
            //Performs the mail merge
            document.MailMerge.Execute(fieldNames, fieldValues);

            //Saves the Word document as DOCX format
            docStream = File.Create(Path.GetFullPath(string.Format(BoParametro.R_DIRDOWND + @"\Boleto_{0}_{1}.Docx", table[0].Codigo, table[0].NumBoleto)));
            document.Save(docStream, FormatType.Docx);
            document.Close();
            docStream.Dispose();
            //Releases the resources occupied by WordDocument instance
            document.Dispose();
        }


        public Relatorio RelListaAnuncio(Relatorio pReport, string pFiltro, string pValor)
        {
            DalRelatorio dalRelatorio = new DalRelatorio();

            DataTable dt = dalRelatorio.RelListaAnuncio(pFiltro, pValor);
            pReport.DataSource = new ReportDataSource("DataSet1", dt);
            pReport.PathReport = @"F:\Repositorio\Estudo\ControleImovel-2020\GestorImoveis\GestorImoveis\Reports\RelListaAnuncios\Template\RelListaAnuncio.rdlc";

            return pReport;
        }


        public Relatorio RelListaClientes(Relatorio pReport, string pFiltro, string pValor)
        {
            DalRelatorio dalRelatorio = new DalRelatorio();

            DataTable dt = dalRelatorio.RelListaClientes(pFiltro, pValor);
            pReport.DataSource = new ReportDataSource("DataSetRelListaClientes", dt);
            pReport.PathReport = @"F:\Repositorio\Estudo\ControleImovel-2020\GestorImoveis\GestorImoveis\Reports\RelListaClientes\Template\RelListaClientes.rdlc";

            return pReport;
        }


        public Relatorio RelContratos(Relatorio pReport, string pValor)
        {
            DalRelatorio dalRelatorio = new DalRelatorio();

            DataTable dt = dalRelatorio.RelContratos(pValor);

            pReport.DataSource = new ReportDataSource("DataSetRelContratos", dt);
            pReport.PathReport = @"F:\Repositorio\Estudo\ControleImovel-2020\GestorImoveis\GestorImoveis\Reports\RelContratos\Template\RelContratos.rdlc";

            return pReport;
        }


    }
}
