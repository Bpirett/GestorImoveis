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
    public partial class UcListaAnuncio : UserControl
    {
        public UcListaAnuncio()
        {
            InitializeComponent();
        }

        private void btn_Gerar_Click(object sender, EventArgs e)
        {
            BoRelatorio boRelatorio = new BoRelatorio();
            DML.Relatorio relatorio = new DML.Relatorio();

            string Valor = string.Empty;
            string Filtro = string.Empty;

            if (Rb_Codigo.Checked == true)
            {
                Valor = txt_Pesq.Text;
                Filtro = Rb_Codigo.Text;
            }
            else if (Rb_Prop.Checked == true)
            {
                Valor = txt_Pesq.Text;
                Filtro = Rb_Prop.Text;
            }
            else if (Rb_Regiao.Checked == true)
            {
                Valor = cbo_Pesq.Text;
                Filtro = Rb_Regiao.Text;
            }
            else if (Rb_TipoImovel.Checked == true)
            {
                Valor = cbo_Pesq.Text;
                Filtro = Rb_TipoImovel.Text;
            }
                
            boRelatorio.RelListaAnuncio(relatorio, Filtro, Valor);

            ReportViewerForm reportViewerForm = new ReportViewerForm(relatorio);
            reportViewerForm.Show();

        }

        private void Rb_Regiao_CheckedChanged(object sender, EventArgs e)
        {
            txt_Pesq.Visible = false;
            cbo_Pesq.Visible = true;
            string[] regiao = { "Selecionar", "Zona Norte", "Zona Leste", "Zona Oeste", "Zona Sul", "Grande ABC", "Litoral" };
            cbo_Pesq.DataSource = regiao;
        }

        private void Rb_TipoImovel_CheckedChanged(object sender, EventArgs e)
        {
            txt_Pesq.Visible = false;
            cbo_Pesq.Visible = true;
            string[] tipoImovel = { "Selecionar", "Apartamento", "Sobrado", "Casa Térrea", "Condomínio Fechado", "Apartamento Duplex", "Cobertura", "Flat / Studio", "Kitnet / Loft", "Imóvel para Renda", "Chácara / Sítio", "Terreno", "Prédio", "Casa Comercial", "Sala Comercial", "Galpão / Salão", "Ponto Comercial", "Prédio Comercial", "Loja de Shopping", "Quiosque", "Pousada / Chalé" };
            cbo_Pesq.DataSource = tipoImovel;
        }

        private void Rb_Codigo_CheckedChanged(object sender, EventArgs e)
        {
            txt_Pesq.Text = string.Empty;
            txt_Pesq.Visible = true;
            cbo_Pesq.Visible = false;
        }

        private void Rb_Prop_CheckedChanged(object sender, EventArgs e)
        {
            txt_Pesq.Text = string.Empty;
            txt_Pesq.Visible = true;
            cbo_Pesq.Visible = false;
        }
    }
}
