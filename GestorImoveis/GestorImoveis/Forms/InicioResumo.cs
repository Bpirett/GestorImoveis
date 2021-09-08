using GestorImoveis.BLL;
using GestorImoveis.Helpers;
using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace GestorImoveis.Forms
{
    public partial class InicioResumo : Form
    {
        public InicioResumo()
        {
            InitializeComponent();
            MontarAmbiente();

        }

        private void TimeResumo_Tick(object sender, EventArgs e)
        {
            BoCliente boCliente = new BoCliente();
            BoContrato boContrato = new BoContrato();
            BoAnuncio boAnuncio = new BoAnuncio();
            BoBoletos boBoletos = new BoBoletos();

            lblAnuncios.Text = boAnuncio.CountAnuncios().ToString();
            lblContratos.Text = boContrato.CountContratos().ToString();
            lblClientes.Text = boCliente.CountClientes().ToString();
            lblLocadores.Text = boCliente.CountLocadores().ToString();
            lblLocatarios.Text = boCliente.CountLocatarios().ToString();
            lblReceber.Text = boBoletos.ConsultarValorReceberMes().ToString("C2");
            lblReceberAdm.Text = boBoletos.ConsultarValorAdmReceberMes().ToString("C2");
        }



        #region Metodos

        private void MontarAmbiente()
        {
            BoCliente boCliente = new BoCliente();
            BoContrato boContrato = new BoContrato();
            BoAnuncio boAnuncio = new BoAnuncio();
            BoBoletos boBoletos = new BoBoletos();

            lblAnuncios.Text = boAnuncio.CountAnuncios().ToString();
            lblContratos.Text = boContrato.CountContratos().ToString();
            lblClientes.Text = boCliente.CountClientes().ToString();
            lblLocadores.Text = boCliente.CountLocadores().ToString();
            lblLocatarios.Text = boCliente.CountLocatarios().ToString();
            lblReceber.Text = boBoletos.ConsultarValorReceberMes().ToString("C2");
            lblReceberAdm.Text = boBoletos.ConsultarValorAdmReceberMes().ToString("C2");

            MontarChartResumo();
        }


        public void MontarChartResumo()
        {
            cartesianChart1.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Clientes",
                    Values = new ChartValues<double> {4, 6, 5, 2, 7,10,20,36,5,4,15,20},
                     PointGeometry = DefaultGeometries.Circle
                },
                new LineSeries
                {
                    Title = "Anuncios",
                    Values = new ChartValues<double> {6, 7, 3, 4, 6,21,22,23,5,24,30,15},
                    PointGeometry = DefaultGeometries.Circle
                },
            };

            cartesianChart1.AxisX.Add(new Axis
            {
                Title = "Meses",
                Labels = new[] { "Jan", "Fev", "Mar", "Abri", "Mai", "Jun", "Jul", "Ago", "Set", "Out", "Nov", "Dez" }
            });

            cartesianChart1.AxisY.Add(new Axis
            {
                Title = "Quantidade.",
                LabelFormatter = value => value.ToString()
            });

            cartesianChart1.LegendLocation = LegendLocation.Bottom;
            cartesianChart1.DataClick += CartesianChart1OnDataClick;
        }


        private void CartesianChart1OnDataClick(object sender, ChartPoint chartPoint)
        {
            MessageBox.Show("You clicked (" + chartPoint.X + "," + chartPoint.Y + ")");
        }
        #endregion
    }
}

