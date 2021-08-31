using GestorImoveis.BLL;
using GestorImoveis.DML;
using GestorImoveis.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GestorImoveis.DML.Boleto;

namespace GestorImoveis.Forms
{
    public partial class BoletosForm : Form
    {
        #region Globais
        /// <summary>
        /// 
        /// </summary>
        bool Alteracao = false;
        #endregion

        #region Construtor
        public BoletosForm()
        {
            InitializeComponent();
            InciarAmbiente();
            HabilitarCampos(false);
            AplicarEventos(txtVlrAluguel);
            AplicarEventos(txtVlrIptu);
            AplicarEventos(txtVlrDesconto);
            AplicarEventos(txtVlrMulta);
            AplicarEventos(txtVlrComissao);
         
            //TODO Calculo de comissão e de multa e de descontos - fazer
        }
        #endregion

        #region Eventos
        private void cboContratos_SelectedIndexChanged(object sender, EventArgs e)
        {
            BoBoletos boBoletos = new BoBoletos();
            gridBoletos.DataSource = boBoletos.ConsultaBoleto(cboContratos.Text);
            MontarGrid();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RBAlterar_CheckedChanged_1(object sender, EventArgs e)
        {
            Alteracao = true;
            BoContrato boContrato = new BoContrato();
            cboContratos.DataSource = boContrato.ConsulContratos();
            HabilitarCampos(true);
            LimparCampos();
            PreencherCombos();
        }

        private void RbConsultar_CheckedChanged(object sender, EventArgs e)
        {
            Alteracao = false;
            BoContrato boContrato = new BoContrato();
            cboContratos.DataSource = boContrato.ConsulContratos();
            HabilitarCampos(false);
            LimparCampos();
        }

        private void buttonGravar_Click(object sender, EventArgs e)
        {
            BoBoletos boBoletos = new BoBoletos();
            try
            {
                Boleto boleto = ConverterFormToDML();
                if (Alteracao == true)
                {
                    boBoletos.AlterarBoleto(boleto);

                    MessageBox.Show("Registro alterado com sucesso", "SUCESSO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                gridBoletos.DataSource = boBoletos.ConsultaBoleto(boleto.CodContrato.ToString());
                InciarAmbiente();
            }
            catch (Exception ex)
            {
                lblMsgErro.Visible = true;
                lblMsgErro.Text = ex.Message;
            }
        }

        private void gridBoletos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BoBoletos boBoletos = new BoBoletos();
            string Codboleto = gridBoletos.Rows[e.RowIndex].Cells["Codigo"].FormattedValue.ToString();
            string CodContrato = cboContratos.Text;
            string NumBoleto = gridBoletos.Rows[e.RowIndex].Cells["NumBoleto"].FormattedValue.ToString();


            if (e.ColumnIndex == 20 || e.ColumnIndex == 0)
            {

                var table = boBoletos.ObterBoleto(CodContrato, Codboleto, NumBoleto);


                txtId.Text = Convert.ToString(table[0].Codigo);
                txtNumBol.Text = Convert.ToString(table[0].NumBoleto);
                txtEndereco.Text = Convert.ToString(table[0].Endereco);
                txtLocador.Text = Convert.ToString(table[0].Locador);
                txtLocatario.Text = Convert.ToString(table[0].Locatario);
                txtPorcComissao.Text = Convert.ToString(table[0].JrComissao);
                txtPorcDesconto.Text = Convert.ToString(table[0].JrDesconto);
                txtPorcMulta.Text = Convert.ToString(table[0].JrMulta);
                txtVlrAluguel.Text = table[0].Valor.ToString("C");
                txtVlrComissao.Text = table[0].VlrComissao.ToString("C");
                txtVlrDesconto.Text = table[0].VlrDesconto.ToString("C");
                txtVlrIptu.Text = table[0].VlrIptu.ToString("C");
                txtVlrMulta.Text = table[0].VlrMulta.ToString("C");
                txtDataVencimento.Text = Convert.ToString(table[0].DataVencimento);
                cboPago.Text = Convert.ToString(table[0].PagBoleto);
                
                if (UtilHelpers.ValidaData(table[0].DataPagamento))
                txtDataPag.Text = Convert.ToString(table[0].DataPagamento);
              
            }

            if (e.ColumnIndex == 21 || e.ColumnIndex == 1)
            {
                BoRelatorio boRelatorio = new BoRelatorio();
                boRelatorio.EmitirBoleto(CodContrato, Codboleto, NumBoleto);
            }

            if (e.ColumnIndex == 22 || e.ColumnIndex == 2)
            {
                try
                {
                    if (!boBoletos.ValidaBoletoPago(CodContrato, Codboleto, NumBoleto))
                    {
                        boBoletos.PagarBoleto(CodContrato, Codboleto, NumBoleto);
                        MessageBox.Show("Boleto Pago", "SUCESSO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Boleto já foi Pago", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    gridBoletos.DataSource = boBoletos.ConsultaBoleto(CodContrato);
                }
                catch (Exception)
                {
                    MessageBox.Show("Falha ao efetuar o pagamento do boleto", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

        private void txtPorcComissao_TextChanged(object sender, EventArgs e)
        {
            double PorcComissao = 0;
            double VlrAluguel = 0;

            if (!string.IsNullOrEmpty(txtPorcComissao.Text))
                PorcComissao = Convert.ToDouble(txtPorcComissao.Text);

            if (!string.IsNullOrEmpty(txtVlrAluguel.Text.Replace("R$", "")))
                VlrAluguel = Convert.ToDouble(txtVlrAluguel.Text.Replace("R$", ""));

            double vlrComissao = (PorcComissao / 100) * VlrAluguel;
            txtVlrComissao.Text = vlrComissao.ToString("C");
        }

        private void txtPorcMulta_TextChanged(object sender, EventArgs e)
        {
            double PorcMulta = 0;
            double VlrAluguel = 0;

            if (!string.IsNullOrEmpty(txtPorcMulta.Text))
                PorcMulta = Convert.ToDouble(txtPorcMulta.Text);

            if (!string.IsNullOrEmpty(txtVlrAluguel.Text.Replace("R$", "")))
                VlrAluguel = Convert.ToDouble(txtVlrAluguel.Text.Replace("R$", ""));

            double vlrMulta = (PorcMulta / 100) * VlrAluguel;
            txtVlrMulta.Text = vlrMulta.ToString("C");
        }

        private void txtPorcDesconto_TextChanged(object sender, EventArgs e)
        {
            double PorcDesconto = 0;
            double VlrAluguel = 0;

            if (!string.IsNullOrEmpty(txtPorcMulta.Text))
                PorcDesconto = Convert.ToDouble(txtPorcMulta.Text);

            if (!string.IsNullOrEmpty(txtVlrAluguel.Text.Replace("R$", "")))
                VlrAluguel = Convert.ToDouble(txtVlrAluguel.Text.Replace("R$", ""));

            double vlrDesconto = (PorcDesconto / 100) * VlrAluguel;
            txtVlrDesconto.Text = vlrDesconto.ToString("C");
        }

        private void txtVlrAluguel_TextChanged(object sender, EventArgs e)
        {
            txtPorcDesconto_TextChanged(sender, e);
            txtPorcComissao_TextChanged(sender, e);
            txtPorcMulta_TextChanged(sender, e);
        }

        #endregion

        #region Metodos
        /// <summary>
        /// 
        /// </summary>
        private void InciarAmbiente()
        {
            LimparCampos();
            this.Refresh();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pHabilitar"></param>
        private void HabilitarCampos(bool pHabilitar)
        {
            cboContratos.Enabled = pHabilitar;
            txtId.Enabled = false;
            txtNumBol.Enabled = false;
            txtLocador.Enabled = pHabilitar;
            txtLocatario.Enabled = pHabilitar;
            txtPorcComissao.Enabled = pHabilitar;
            txtPorcDesconto.Enabled = pHabilitar;
            txtPorcMulta.Enabled = pHabilitar;
            txtVlrAluguel.Enabled = pHabilitar;
            txtVlrComissao.Enabled = pHabilitar;
            txtVlrDesconto.Enabled = pHabilitar;
            txtVlrIptu.Enabled = pHabilitar;
            txtVlrMulta.Enabled = pHabilitar;
            txtEndereco.Enabled = pHabilitar;
            txtDataVencimento.Enabled = pHabilitar;
            txtDataPag.Enabled = pHabilitar;
            cboPago.Enabled = pHabilitar;
            buttonGravar.Visible = false;
            buttonGravar.Enabled = false;

            if (RBAlterar.Checked == true)
            {
                buttonGravar.Visible = true;
                buttonGravar.Enabled = true;
            }


        }

        /// <summary>
        /// 
        /// </summary>
        private void LimparCampos()
        {
            txtId.Text = string.Empty;
            txtNumBol.Text = string.Empty;
            txtLocador.Text = string.Empty;
            txtLocatario.Text = string.Empty;
            txtPorcComissao.Text = string.Empty;
            txtPorcDesconto.Text = string.Empty;
            txtPorcMulta.Text = string.Empty;
            txtVlrAluguel.Text = string.Empty;
            txtVlrIptu.Text = string.Empty;
            txtVlrDesconto.Text = string.Empty;
            txtVlrComissao.Text = string.Empty;
            txtDataVencimento.ResetText();
            txtDataPag.ResetText();
            cboPago.Text = string.Empty;
            txtEndereco.Text = string.Empty;
        }

        /// <summary>
        /// 
        /// </summary>
        private void PreencherCombos()
        {
            cboPago.DataSource = Enum.GetValues(typeof(PagamentoBoleto));
        }

        /// <summary>
        /// 
        /// </summary>
        private void MontarGrid()
        {
            DataGridViewButtonColumn BtnEdit = new DataGridViewButtonColumn();
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Width = 30;
            BtnEdit.UseColumnTextForButtonValue = true;


            DataGridViewButtonColumn BtnPrint = new DataGridViewButtonColumn();
            BtnEdit.Name = "BtnPrint";
            BtnEdit.Width = 30;
            BtnEdit.UseColumnTextForButtonValue = true;

            DataGridViewButtonColumn BtnPag = new DataGridViewButtonColumn();
            BtnEdit.Name = "BtnPag";
            BtnEdit.Width = 30;
            BtnEdit.UseColumnTextForButtonValue = true;

            if (!gridBoletos.Columns.Contains(BtnEdit.Name = "BtnEdit"))
            {
                gridBoletos.Columns.Add(BtnEdit);
            }

            if (!gridBoletos.Columns.Contains(BtnPrint.Name = "BtnPrint"))
            {
                gridBoletos.Columns.Add(BtnPrint);
            }

            if (!gridBoletos.Columns.Contains(BtnPag.Name = "BtnPag"))
            {
                gridBoletos.Columns.Add(BtnPag);
            }

            gridBoletos.Columns["Codigo"].HeaderText = "Cod.";
            gridBoletos.Columns["Codigo"].Width = 30;
            gridBoletos.Columns["Codigo"].DisplayIndex = 0;

            gridBoletos.Columns["CodContrato"].Visible = false;

            gridBoletos.Columns["NumBoleto"].HeaderText = "Num";
            gridBoletos.Columns["NumBoleto"].Width = 30;
            gridBoletos.Columns["NumBoleto"].DisplayIndex = 1;


            gridBoletos.Columns["Locatario"].HeaderText = "Locatario";
            gridBoletos.Columns["Locatario"].Width = 100;
            gridBoletos.Columns["Locatario"].DisplayIndex = 2;

            gridBoletos.Columns["Locador"].HeaderText = "Locador";
            gridBoletos.Columns["Locador"].Width = 100;
            gridBoletos.Columns["Locador"].DisplayIndex = 3;

            gridBoletos.Columns["Valor"].HeaderText = "Valor";
            gridBoletos.Columns["Valor"].Width = 50;
            gridBoletos.Columns["Valor"].DisplayIndex = 4;

            gridBoletos.Columns["Endereco"].HeaderText = "Endereço";
            gridBoletos.Columns["Endereco"].Width = 150;
            gridBoletos.Columns["Endereco"].DisplayIndex = 5;

            gridBoletos.Columns["DataVencimento"].HeaderText = "Vencimento";
            gridBoletos.Columns["DataVencimento"].Width = 80;
            gridBoletos.Columns["DataVencimento"].DisplayIndex = 6;

            gridBoletos.Columns["PagBoleto"].HeaderText = "Pago S/N";
            gridBoletos.Columns["PagBoleto"].Width = 50;
            gridBoletos.Columns["PagBoleto"].DisplayIndex = 7;


            gridBoletos.Columns["DataPagamento"].HeaderText = "Dt Pag";
            gridBoletos.Columns["DataPagamento"].Width = 80;
            gridBoletos.Columns["DataPagamento"].DisplayIndex = 8;

            gridBoletos.Columns["BtnEdit"].HeaderText = "Alt";
            gridBoletos.Columns["BtnEdit"].DisplayIndex = 9;

            gridBoletos.Columns["BtnPrint"].HeaderText = "Imp";
            gridBoletos.Columns["BtnPrint"].DisplayIndex = 10;
            gridBoletos.Columns["BtnPrint"].Width = 30;

            gridBoletos.Columns["BtnPag"].HeaderText = "Pag";
            gridBoletos.Columns["BtnPag"].DisplayIndex = 11;
            gridBoletos.Columns["BtnPag"].Width = 30;

            gridBoletos.Columns["jrMulta"].Visible = false;
            gridBoletos.Columns["VlrMulta"].Visible = false;
            gridBoletos.Columns["JrDesconto"].Visible = false;
            gridBoletos.Columns["VlrIptu"].Visible = false;
            gridBoletos.Columns["VlrDesconto"].Visible = false;
            gridBoletos.Columns["VlrComissao"].Visible = false;
            gridBoletos.Columns["jrComissao"].Visible = false;
            gridBoletos.Columns["TipoImovel"].Visible = false;
            gridBoletos.Columns["PeriodoInicio"].Visible = false;
            gridBoletos.Columns["PeriodoFim"].Visible = false;
        }
        public Boleto ConverterFormToDML()
        {
            var DmlBoleto = new Boleto();

            if (!string.IsNullOrEmpty(txtId.Text))
                DmlBoleto.Codigo = txtId.Text;
            else
                BoErro.DesErro(BoErro.CERRO_CAMPOOBRIGATORIO, lblCodigo.Text);
            
            if (!string.IsNullOrEmpty(txtNumBol.Text))
                DmlBoleto.NumBoleto = Convert.ToString(txtNumBol.Text);
            else
                BoErro.DesErro(BoErro.CERRO_CAMPOOBRIGATORIO, lblNumBol.Text);

            if (!string.IsNullOrEmpty(cboContratos.Text))
                DmlBoleto.CodContrato = cboContratos.Text;
            else
                BoErro.DesErro(BoErro.CERRO_CAMPOOBRIGATORIO, lblCodigo.Text);


            if (!string.IsNullOrEmpty(txtEndereco.Text))
                DmlBoleto.Endereco = txtEndereco.Text;
            else
                BoErro.DesErro(BoErro.CERRO_CAMPOOBRIGATORIO, lblEnd.Text);

            if (!string.IsNullOrEmpty(txtLocador.Text))
                DmlBoleto.Locador = txtLocador.Text;
            else
                BoErro.DesErro(BoErro.CERRO_CAMPOOBRIGATORIO, lblDtVcto.Text);

            if (!string.IsNullOrEmpty(txtLocatario.Text))
                DmlBoleto.Locatario = txtLocatario.Text;
            else
                BoErro.DesErro(BoErro.CERRO_CAMPOOBRIGATORIO, lblLocatario.Text);

            if (!string.IsNullOrEmpty(cboPago.Text))
                DmlBoleto.PagBoleto = DmlBoleto.ConverterPagBoleto(cboPago.Text);
            else
                BoErro.DesErro(BoErro.CERRO_CAMPOOBRIGATORIO, lblPago.Text);


            if (!string.IsNullOrEmpty(txtDataVencimento.Text))
                DmlBoleto.DataVencimento = Convert.ToDateTime(txtDataVencimento.Text);
            else
                BoErro.DesErro(BoErro.CERRO_CAMPOOBRIGATORIO, lblDtVcto.Text);

            if (!string.IsNullOrWhiteSpace(txtDataPag.Text.Replace("/", "")))
                DmlBoleto.DataPagamento = Convert.ToDateTime(txtDataPag.Text);

            if (!string.IsNullOrEmpty(txtVlrAluguel.Text.Replace("R$", "")))
                DmlBoleto.Valor = Convert.ToDouble(txtVlrAluguel.Text.Replace("R$", ""));
            else
                BoErro.DesErro(BoErro.CERRO_CAMPOOBRIGATORIO, lblVlrAluguel.Text);

            if (!string.IsNullOrEmpty(txtVlrIptu.Text.Replace("R$", "")))
                DmlBoleto.VlrIptu = Convert.ToDouble(txtVlrIptu.Text.Replace("R$", ""));
            

            if (!string.IsNullOrWhiteSpace(txtVlrMulta.Text.Replace("R$", "")))
                DmlBoleto.VlrMulta = Convert.ToDouble(txtVlrMulta.Text.Replace("R$", ""));

            if (!string.IsNullOrEmpty(txtVlrComissao.Text.Replace("R$", "")))
                DmlBoleto.VlrComissao = Convert.ToDouble(txtVlrComissao.Text.Replace("R$", ""));

            if (!string.IsNullOrEmpty(txtVlrDesconto.Text.Replace("R$", "")))
                DmlBoleto.VlrDesconto = Convert.ToDouble(txtVlrDesconto.Text.Replace("R$", ""));

            if (!string.IsNullOrEmpty(txtPorcMulta.Text.Replace("R$", "")))
                DmlBoleto.JrMulta = Convert.ToDouble(txtPorcMulta.Text);

            if (!string.IsNullOrEmpty(txtPorcComissao.Text))
                DmlBoleto.JrComissao = Convert.ToDouble(txtPorcComissao.Text);

            if (!string.IsNullOrEmpty(txtPorcDesconto.Text))
                DmlBoleto.JrDesconto = Convert.ToDouble(txtPorcDesconto.Text);

            return DmlBoleto;
        }

        private void AplicarEventos(TextBox txt)
        {
            txt.Enter += UtilHelpers.TirarMascara;
            txt.Leave += UtilHelpers.RetornarMascaraMoeda;
            txt.KeyPress += UtilHelpers.ApenasValorNumerico;
        }

        #endregion

 
    }
}
