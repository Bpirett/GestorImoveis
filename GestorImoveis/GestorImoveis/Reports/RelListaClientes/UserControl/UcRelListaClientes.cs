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
    public partial class UcRelListaClientes : UserControl
    {
        public UcRelListaClientes()
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
            else if (Rb_Nome.Checked == true)
            {
                Valor = txt_Pesq.Text;
                Filtro = Rb_Nome.Text;
            }
            else if (Rb_Tipo.Checked == true)
            {
                Valor = cbo_Pesq.Text;
                Filtro = Rb_Tipo.Text;
            }
            else if (Rb_CPF.Checked == true)
            {
                Valor = cbo_Pesq.Text;
                Filtro = Rb_CPF.Text;
            }

            boRelatorio.RelListaClientes(relatorio, Filtro, Valor);
            ReportViewerForm reportViewerForm = new ReportViewerForm(relatorio);
            reportViewerForm.Show();
        }

        private void Rb_Codigo_CheckedChanged(object sender, EventArgs e)
        {
            txt_Pesq.Text = string.Empty;
            txt_Pesq.Visible = true;
            cbo_Pesq.Visible = false;
        }

        private void Rb_Nome_CheckedChanged(object sender, EventArgs e)
        {
            txt_Pesq.Text = string.Empty;
            txt_Pesq.Visible = true;
            cbo_Pesq.Visible = false;
        }

        private void Rb_PF_CheckedChanged(object sender, EventArgs e)
        {
            txt_Pesq.Text = string.Empty;
            txt_Pesq.Visible = true;
            cbo_Pesq.Visible = false;
        }

        private void Rb_Tipo_CheckedChanged(object sender, EventArgs e)
        {
            txt_Pesq.Visible = false;
            cbo_Pesq.Visible = true;
            string[] tipocliente = { "Selecionar", "Locatario", "Locador" };
            cbo_Pesq.DataSource = tipocliente;
        }
    }
}
