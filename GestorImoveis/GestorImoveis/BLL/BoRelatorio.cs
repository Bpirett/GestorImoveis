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
        /// Emissão de boletos
        /// </summary>
        public void EmitirBoleto(string pCodContrato, string pCodBoleto, string pNumBoleto)
        {

            try
            {
                Stream docStream = File.OpenRead(Path.GetFullPath(BoParametro.R_DIRMOBOL));
                WordDocument document = new WordDocument(docStream, FormatType.Docx);
                docStream.Dispose();

                string[] fieldNames = { "RefBoleto", "VlrAluguel", "VlrIptu", "VlrDesc", "VlrMulta", "VlrOutros", "VlrTotal", "VlrAdmin", "Locatario", "Locador", "TipoImovel", "EnderecoImovel", "DataIni", "DataFim", "DataVencimentor", "DataAtual", "NumParcela", "VlrTotalLocat" };

                BoBoletos boBoletos = new BoBoletos();
                Boleto boleto = boBoletos.ObterBoletoRel(pCodContrato, pCodBoleto, pNumBoleto);


                string[] fieldValues = { boleto.Codigo.ToString(), boleto.Valor.ToString("C2"), boleto.VlrIptu.ToString("C2"), boleto.VlrDesconto.ToString("C2"), boleto.VlrMulta.ToString("C2"), "0,00", CalcularValor(boleto,false).ToString("C2"), boleto.VlrComissao.ToString("C2"),
            boleto.Locatario,boleto.Locador ,boleto.TipoImovel, boleto.Endereco, UtilHelpers.ConverteData(boleto.PeriodoInicio), UtilHelpers.ConverteData(boleto.PeriodoFim), UtilHelpers.ConverteData(boleto.DataVencimento), DateTime.Now.ToLongDateString(), boleto.NumBoleto.ToString(), CalcularValor(boleto,true).ToString("C2") };
                //Performs the mail merge
                document.MailMerge.Execute(fieldNames, fieldValues);

                //Saves the Word document as DOCX format
                docStream = File.Create(Path.GetFullPath(string.Format(BoParametro.R_DIRDOWND + String.Format("\\Boleto_{0}_Parc_{1}.Docx", boleto.Codigo, boleto.NumBoleto))));
                document.Save(docStream, FormatType.Docx);
                document.Close();
                docStream.Dispose();
                //Releases the resources occupied by WordDocument instance
                document.Dispose();
            }
            catch (Exception e)
            {

                throw;
            }

  
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
            pReport.PathReport = @"F:\Repositorio\Projetos\GestorImoveis\GestorImoveis\GestorImoveis\Reports\RelContratos\Template\RelContratos.rdlc";

            return pReport;
        }


        public Relatorio RelBoletos(Relatorio pReport, string pValor)
        {
            DalRelatorio dalRelatorio = new DalRelatorio();

            DataTable dt = dalRelatorio.RelBoletos(pValor);

            pReport.DataSource = new ReportDataSource("DataSetRelBoletos", dt);
            pReport.PathReport = @"F:\Repositorio\Projetos\GestorImoveis\GestorImoveis\GestorImoveis\Reports\RelBoletos\Template\RelBoletos.rdlc";

            return pReport;
        }

        public double CalcularValor(Boleto boleto, bool pTipo)
        {
            double VlrTotal = 0.00;

            if (pTipo == true)
                VlrTotal = boleto.Valor + boleto.VlrIptu + boleto.VlrMulta - boleto.VlrDesconto;
            else
               VlrTotal = boleto.Valor + boleto.VlrIptu + boleto.VlrMulta - boleto.VlrDesconto - boleto.VlrComissao;

            return VlrTotal;
        }

    }
}
