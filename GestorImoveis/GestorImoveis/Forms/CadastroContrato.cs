using Correios;
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
using static GestorImoveis.DML.Contrato;


namespace GestorImoveis.Forms
{
    public partial class CadastroContrato : Form
    {
        #region Globais
        /// <summary>
        /// 
        /// </summary>
        bool Alteracao = false;
        public DateTime Periodo { get; set; }
        public DateTime UltimoPeriodo { get; set; }
        #endregion

        #region Construtor
        public CadastroContrato()
        {
            InitializeComponent();
            AplicarEventos(txtVlrAluguel);
            AplicarEventos(txtIptu);
            AplicarEventoCEP(txtCEP);
            InciarAmbiente();
            HabilitarCampos(false);
        }
        #endregion

        #region Eventos

        private void buttonGravar_Click(object sender, EventArgs e)
        {
            BoContrato boContrato = new BoContrato();
            BoBoletos boBoletos = new BoBoletos();
            try
            {
                Contrato contrato = ConverterFormToDML();
                if (Alteracao == true)
                {
                    boContrato.AtualizarContrato(contrato);
                    boContrato.GravarLogContrato(contrato);

                    if (contrato.SituacaoContrato == Situacaocontrato.Renovado)
                    {
                        boBoletos.IncluirBoleto(contrato.Boletos);
                    }

                    MessageBox.Show("Registro alterado com sucesso", "SUCESSO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gridContratos.DataSource = boContrato.ConsultaContratos();
                    MontarGrid();
                }
                else
                {
                    boContrato.IncluirContrato(contrato);
                    boContrato.GravarLogContrato(contrato);
                    boBoletos.IncluirBoleto(contrato.Boletos);
                    MessageBox.Show("Cadastro realizado com sucesso", "SUCESSO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                InciarAmbiente();
                HabilitarCampos(false);

                if (Alteracao == true)
                    RBAlterar.Checked = false;
                else
                    RadioCriar.Checked = false;
            }
            catch (Exception ex)
            {
                lblMsgErro.Visible = true;
                lblMsgErro.Text = ex.Message;
            }
        }

        private void RadioCriar_CheckedChanged(object sender, EventArgs e)
        {
            Alteracao = false;
            BoContrato boContrato = new BoContrato();
            HabilitarCampos(true);
            LimparCampos();
            gridContratos.DataSource = null;
            txtId.Text = boContrato.ObterUltCodContrato();
            PreencherCombos();
        }

        private void RBAlterar_CheckedChanged(object sender, EventArgs e)
        {
            Alteracao = true;
            BoContrato boContrato = new BoContrato();
            HabilitarCampos(true);
            LimparCampos();
            gridContratos.DataSource = boContrato.ConsultaContratos();
            MontarGrid();
            gridContratos.Enabled = true;
            PreencherCombos();
        }

        private void RbConsultar_CheckedChanged(object sender, EventArgs e)
        {
            HabilitarCampos(false);
            LimparCampos();
            BoContrato boContrato = new BoContrato();
            gridContratos.DataSource = null;
            gridContratos.DataSource = boContrato.ConsultaContratos();
            MontarGrid();
            gridContratos.Enabled = true;
        }
        private void btnPesqLocador_Click(object sender, EventArgs e)
        {

            try
            {
                BoContrato boContrato = new BoContrato();
                if (string.IsNullOrEmpty(txtPesqcodLocador.Text))
                {
                    cboLocador.DataSource = boContrato.ObterLocador(string.Empty);
                }
                else
                    cboLocador.DataSource = boContrato.ObterLocador(txtPesqcodLocador.Text);
            }
            catch (Exception ex)
            {
                lblMsgErro.Visible = true;
                lblMsgErro.Text = ex.Message;
            }

        }

        private void btnPesqLocatario_Click(object sender, EventArgs e)
        {

            try
            {
                BoContrato boContrato = new BoContrato();
                if (string.IsNullOrEmpty(txtPesqcodLocatario.Text))
                {
                    cboLocatario.DataSource = boContrato.ObterLocatario(string.Empty);
                }
                else
                    cboLocatario.DataSource = boContrato.ObterLocatario(txtPesqcodLocatario.Text);

            }
            catch (Exception ex)
            {

                lblMsgErro.Visible = true;
                lblMsgErro.Text = ex.Message;
            }
        }

        private void txtMesesContrato_ValueChanged(object sender, EventArgs e)
        {
            string dataentrada = txtDataEntrada.Text;

            try
            {
                if (string.IsNullOrWhiteSpace(dataentrada.Replace("/", "")))
                    BoErro.DesErro(BoErro.CERRO_EXCEPTION, $"Campo {lblDtEntrada.Text} precisa estar preechido!");


                DateTime DtEntrada = Convert.ToDateTime(txtDataEntrada.Text);

                if (BoParametro.C_VALENTRA)
                {
                    if (DtEntrada >= DateTime.Now.Date)
                    {

                        txtDataSaida.Text = DtEntrada.AddMonths((int)txtMesesContrato.Value).ToString();
                    }
                    else
                    {
                        if (!Alteracao)
                        {
                            lblMsgErro.Visible = true;
                            lblMsgErro.Text = "Data de Entrada precisa ser igual ou maior que a data de hoje!";
                        }

                    }
                }
                else
                {
                    txtDataSaida.Text = DtEntrada.AddMonths((int)txtMesesContrato.Value).ToString();
                }
            
            }
            catch (Exception ex)
            {
                lblMsgErro.Visible = true;
                lblMsgErro.Text = ex.Message;
                txtMesesContrato.Value = 0;
            }
        }

        private void TxtPesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            var Backspace = "\b";
            if (RbCodigo.Checked == true)
            {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar.ToString() != Keys.Delete.ToString() && e.KeyChar.ToString() != Backspace)
                {
                    e.Handled = true;
                    lblMsgErro.Visible = true;
                    lblMsgErro.Text = "Este campo aceita somente numero";
                }
            }
        }

        private void RbCodigo_CheckedChanged(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void RbNome_CheckedChanged(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            BoContrato boContrato = new BoContrato();

            try
            {
                if (RbCodigo.Checked == true && !string.IsNullOrEmpty(TxtPesquisa.Text))
                {
                    gridContratos.DataSource = boContrato.ObterContrato(TxtPesquisa.Text, RbCodigo.Text);
                }
                else if (RbNome.Checked == true && !string.IsNullOrEmpty(TxtPesquisa.Text))
                {
                    gridContratos.DataSource = boContrato.ObterContrato(TxtPesquisa.Text, RbNome.Text);
                }
                else
                    gridContratos.DataSource = boContrato.ObterContrato(string.Empty, string.Empty);

                MontarGrid();
            }
            catch (Exception ex)
            {
                lblMsgErro.Visible = true;
                lblMsgErro.Text = ex.Message;
            }
        }

        private void gridContratos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 12 || e.ColumnIndex == 0)
            {
                BoContrato boContrato = new BoContrato();
                string CodContrato = gridContratos.Rows[e.RowIndex].Cells["Codigo"].FormattedValue.ToString();
                var table = boContrato.ObterContrato(CodContrato, RbCodigo.Text);


                txtCEP.Text = table[0].End.Cep;
                cboLocador.Text = table[0].Locador;
                cboLocatario.Text = table[0].Locatario;
                txtVlrAluguel.Text = Convert.ToDouble(table[0].Valor).ToString("C");
                txtEndereco.Text = table[0].End.End;
                txtDiaPag.Text = Convert.ToString(table[0].DiaPagamento);
                txtDataEntrada.Text = Convert.ToString(table[0].DataEntrada);
                txtDataSaida.Text = Convert.ToString(table[0].DataSaida);
                txtMesesContrato.Text = Convert.ToString(table[0].QtaMeses);
                txtIptu.Text = Convert.ToDouble(table[0].VlrIptu).ToString("C");
                cboTipoImovel.Text = Convert.ToString(table[0].TipoImovel);
                cboSituacao.Text = Convert.ToString(table[0].SituacaoContrato);
                txtId.Text = table[0].Codigo;
                txtBairro.Text = table[0].End.Bairro;
                txtUF.Text = table[0].End.Uf;
                txtCidade.Text = table[0].End.Cidade;
                txtComplemento.Text = table[0].End.Complemento;
                txtComplemento2.Text = table[0].End.Complemento2;
                txtNumeroImovel.Text = Convert.ToString(table[0].End.NumeroImovel);
            }
        }

        private void txtCEP_TextChanged(object sender, EventArgs e)
        {
            if (txtCEP.TextLength == 9)
            {


                try
                {
                    CorreiosApi correiosAPI = new CorreiosApi();
                    var enderecoERP = correiosAPI.consultaCEP(txtCEP.Text);

                    if (enderecoERP is null)
                    {
                        MessageBox.Show("CEP não encontrado!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        txtEndereco.Text = enderecoERP.end;
                        txtBairro.Text = enderecoERP.bairro;
                        txtUF.Text = enderecoERP.uf;
                        txtCidade.Text = enderecoERP.cidade;
                        txtComplemento.Text = enderecoERP.complemento;
                        txtComplemento2.Text = enderecoERP.complemento2;
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("CEP não encontrado!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void txtDiaPag_TextChanged(object sender, EventArgs e)
        {
            lblMsgErro.Text = string.Empty;
            if (!string.IsNullOrEmpty(txtDiaPag.Text))
            {
                if (UtilHelpers.IsAllDigits(txtDiaPag.Text))
                {
                    int dia = Convert.ToInt32(txtDiaPag.Text);

                    if (dia <= 0 || dia > 31)
                    {
                        lblMsgErro.Visible = true;
                        lblMsgErro.Text = "Dia de pagamento deve ser entre dia 1 até dia 31";
                    }
                }
                else
                {
                    lblMsgErro.Visible = true;
                    lblMsgErro.Text = "Este campo aceita somente numeros";
                }
            }
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
            txtCEP.Enabled = pHabilitar;
            txtDataEntrada.Enabled = pHabilitar;
            txtDiaPag.Enabled = pHabilitar;
            txtId.Enabled = false;
            txtEndereco.Enabled = pHabilitar;
            txtIptu.Enabled = pHabilitar;
            btnPesqLocador.Enabled = pHabilitar;
            btnPesqLocatario.Enabled = pHabilitar;
            txtPesqcodLocador.Enabled = pHabilitar;
            txtPesqcodLocatario.Enabled = pHabilitar;
            cboTipoImovel.Enabled = pHabilitar;
            cboLocador.Enabled = pHabilitar;
            cboLocatario.Enabled = pHabilitar;
            cboSituacao.Enabled = pHabilitar;
            txtVlrAluguel.Enabled = pHabilitar;
            txtMesesContrato.Enabled = pHabilitar;
            txtDataSaida.Enabled = pHabilitar;
            TxtPesquisa.Enabled = false;
            RbNome.Enabled = false;
            RbCodigo.Enabled = false;
            btnPesquisa.Enabled = false;
            buttonGravar.Visible = pHabilitar;
            buttonGravar.Enabled = pHabilitar;
            txtEndereco.Enabled = pHabilitar;
            txtBairro.Enabled = pHabilitar;
            txtUF.Enabled = pHabilitar;
            txtCidade.Enabled = pHabilitar;
            txtComplemento.Enabled = pHabilitar;
            txtComplemento2.Enabled = pHabilitar;
            txtNumeroImovel.Enabled = pHabilitar;

            if (RbConsultar.Checked == true || RBAlterar.Checked == true)
            {
                TxtPesquisa.Enabled = true;
                RbNome.Enabled = true;
                RbCodigo.Enabled = true;
                btnPesquisa.Enabled = true;
            }

            if (RbConsultar.Checked == true)
                buttonGravar.Visible = false;
        }

        /// <summary>
        /// 
        /// </summary>
        private void LimparCampos()
        {
            txtCEP.Text = string.Empty;
            txtDataEntrada.Text = string.Empty;
            txtDiaPag.Text = string.Empty;
            txtId.Text = string.Empty;
            txtEndereco.Text = string.Empty;
            txtIptu.Text = string.Empty;
            btnPesqLocador.Text = string.Empty;
            btnPesqLocatario.Text = string.Empty;
            txtPesqcodLocador.Text = string.Empty;
            txtPesqcodLocatario.Text = string.Empty;
            cboTipoImovel.Text = string.Empty;
            cboLocador.Text = string.Empty;
            cboLocatario.Text = string.Empty;
            cboSituacao.Text = string.Empty;
            txtVlrAluguel.Text = string.Empty;
            txtMesesContrato.ResetText();
            txtDataSaida.Text = string.Empty;
            TxtPesquisa.Text = string.Empty;
            lblMsgErro.Text = string.Empty;
            txtEndereco.Text = string.Empty;
            txtBairro.Text = string.Empty;
            txtUF.Text = string.Empty;
            txtCidade.Text = string.Empty;
            txtComplemento.Text = string.Empty;
            txtComplemento2.Text = string.Empty;
            txtNumeroImovel.Text = string.Empty;
        }

        /// <summary>
        /// 
        /// </summary>
        private void PreencherCombos()
        {
            BoContrato boContrato = new BoContrato();

            string[] tipoImovel = { "Selecionar", "Apartamento", "Sobrado", "Casa Térrea", "Condomínio Fechado", "Apartamento Duplex", "Cobertura", "Flat / Studio", "Kitnet / Loft", "Imóvel para Renda", "Chácara / Sítio", "Terreno", "Prédio", "Casa Comercial", "Sala Comercial", "Galpão / Salão", "Ponto Comercial", "Prédio Comercial", "Loja de Shopping", "Quiosque", "Pousada / Chalé" };
            cboTipoImovel.DataSource = tipoImovel;

            if (RadioCriar.Checked == true)
            {
                string[] Situacaocontrato = { "Andamento" };
                cboSituacao.DataSource = Situacaocontrato;
            }
            else
                cboSituacao.DataSource = Enum.GetValues(typeof(Situacaocontrato));

            cboLocador.DataSource =  boContrato.ObterLocador(string.Empty);
            cboLocatario.DataSource = boContrato.ObterLocatario(string.Empty);
        }

        /// <summary>
        /// 
        /// </summary>
        private void MontarGrid()
        {
            if (!RadioCriar.Checked == true)
            {
                DataGridViewButtonColumn BtnEdit = new DataGridViewButtonColumn();
                BtnEdit.HeaderText = "";
                BtnEdit.Name = "BtnEdit";
                BtnEdit.Width = 30;
                BtnEdit.UseColumnTextForButtonValue = true;

                if (!gridContratos.Columns.Contains(BtnEdit.Name = "BtnEdit"))
                {
                    gridContratos.Columns.Add(BtnEdit);
                }

                gridContratos.Columns["Codigo"].HeaderText = "Cod.";
                gridContratos.Columns["Codigo"].Width = 30;
                gridContratos.Columns["Codigo"].DisplayIndex = 0;


                gridContratos.Columns["Locatario"].HeaderText = "Locatario";
                gridContratos.Columns["Locatario"].Width = 125;
                gridContratos.Columns["Locatario"].DisplayIndex = 1;

                gridContratos.Columns["Locador"].HeaderText = "Locador";
                gridContratos.Columns["Locador"].Width = 125;
                gridContratos.Columns["Locador"].DisplayIndex = 2;

                gridContratos.Columns["Valor"].HeaderText = "Valor";
                gridContratos.Columns["Valor"].Width = 70;
                gridContratos.Columns["Valor"].DisplayIndex = 3;

                gridContratos.Columns["End"].Visible = false;

                gridContratos.Columns["DiaPagamento"].HeaderText = "Dia Pag";
                gridContratos.Columns["DiaPagamento"].Width = 40;
                gridContratos.Columns["DiaPagamento"].DisplayIndex = 5;

                gridContratos.Columns["DataEntrada"].Visible = false;

                gridContratos.Columns["DataSaida"].HeaderText = "Data Saida";
                gridContratos.Columns["DataSaida"].Width = 68;
                gridContratos.Columns["DataSaida"].DisplayIndex = 8;

                gridContratos.Columns["QtaMeses"].HeaderText = "Duração (Meses)";
                gridContratos.Columns["QtaMeses"].Width = 58;
                gridContratos.Columns["QtaMeses"].DisplayIndex = 9;

                gridContratos.Columns["VlrIptu"].Visible = false;

                gridContratos.Columns["TipoImovel"].HeaderText = "Tipo Imovel";
                gridContratos.Columns["TipoImovel"].Width = 100;
                gridContratos.Columns["TipoImovel"].DisplayIndex = 10;

                gridContratos.Columns["SituacaoContrato"].HeaderText = "Situação";
                gridContratos.Columns["SituacaoContrato"].Width = 80;
                gridContratos.Columns["SituacaoContrato"].DisplayIndex = 11;

                gridContratos.Columns["BtnEdit"].DisplayIndex = 12;

                gridContratos.ColumnHeadersVisible = true;
            }
            else
                gridContratos.ColumnHeadersVisible = false;


        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Contrato ConverterFormToDML()
        {
            var DmlContrato = new Contrato();
            DmlContrato.End = new Endereco();

            if (!string.IsNullOrEmpty(txtId.Text))
                DmlContrato.Codigo = txtId.Text;
            else
                BoErro.DesErro(BoErro.CERRO_CAMPOOBRIGATORIO, lblCodigo.Text);

            if (!string.IsNullOrEmpty(cboLocador.Text))
                DmlContrato.Locador = cboLocador.Text;
            else
                BoErro.DesErro(BoErro.CERRO_CAMPOOBRIGATORIO, lblLocad.Text);

            if (!string.IsNullOrEmpty(cboLocatario.Text))
                DmlContrato.Locatario = cboLocatario.Text;
            else
                BoErro.DesErro(BoErro.CERRO_CAMPOOBRIGATORIO, lblLocat.Text);

            if (!string.IsNullOrEmpty(txtDiaPag.Text))
                DmlContrato.DiaPagamento = Convert.ToInt32(txtDiaPag.Text);
            else
                BoErro.DesErro(BoErro.CERRO_CAMPOOBRIGATORIO, lblDiaPag.Text);


            if (!string.IsNullOrEmpty(cboTipoImovel.Text) || cboTipoImovel.Text == "selecionar")
                DmlContrato.TipoImovel = cboTipoImovel.Text;
            else
                BoErro.DesErro(BoErro.CERRO_CAMPOOBRIGATORIO, lblTpImovel.Text);


            if (!string.IsNullOrEmpty(txtDataEntrada.Text))
                DmlContrato.DataEntrada = Convert.ToDateTime(txtDataEntrada.Text).Date;
            else
                BoErro.DesErro(BoErro.CERRO_CAMPOOBRIGATORIO, lblDtEntrada.Text);

            if ((DmlContrato.DataEntrada.Year != DateTime.Now.Year || DmlContrato.DataEntrada <= DateTime.MinValue || DmlContrato.DataEntrada >= DateTime.MaxValue) && BoParametro.C_VALENTRA)
                BoErro.DesErro(BoErro.CERRO_DATA_INVALIDA_NO_ANO_CORRENTE, lblDtEntrada.Text);


            if (!string.IsNullOrEmpty(txtMesesContrato.Text))
                DmlContrato.QtaMeses = Convert.ToInt32(txtMesesContrato.Text);
            else
                BoErro.DesErro(BoErro.CERRO_CAMPOOBRIGATORIO, lblPrazo.Text);

            if (!string.IsNullOrEmpty(txtDataSaida.Text))
                DmlContrato.DataSaida = Convert.ToDateTime(txtDataSaida.Text).Date;
            else
                BoErro.DesErro(BoErro.CERRO_CAMPOOBRIGATORIO, lblDtSaida.Text);

            if (DmlContrato.DataSaida <= DateTime.MinValue || DmlContrato.DataSaida >= DateTime.MaxValue)
                BoErro.DesErro(BoErro.CERRO_DATA_INVALIDA, lblDtSaida.Text);

            if (!string.IsNullOrEmpty(txtVlrAluguel.Text))
                DmlContrato.Valor = Convert.ToDouble(txtVlrAluguel.Text.Replace("R$", "").Trim());
            else
                BoErro.DesErro(BoErro.CERRO_CAMPOOBRIGATORIO, lblVlrAluguel.Text);

            if (!string.IsNullOrEmpty(txtIptu.Text))
                DmlContrato.VlrIptu = Convert.ToDouble(txtIptu.Text.Replace("R$", "").Trim());

            DmlContrato.SituacaoContrato = DmlContrato.ConverterSitcontrato(cboSituacao.Text);

            if (!string.IsNullOrEmpty(txtEndereco.Text))
                DmlContrato.End.End = txtEndereco.Text;
            else
                BoErro.DesErro(BoErro.CERRO_CAMPOOBRIGATORIO, lblEnd.Text);

            if (!string.IsNullOrEmpty(txtCEP.Text))
                DmlContrato.End.Cep = txtCEP.Text;
            else
                BoErro.DesErro(BoErro.CERRO_CAMPOOBRIGATORIO, lblCEP.Text);

            if (!string.IsNullOrEmpty(txtNumeroImovel.Text))
                DmlContrato.End.NumeroImovel = Convert.ToInt32(txtNumeroImovel.Text);
            else
                BoErro.DesErro(BoErro.CERRO_CAMPOOBRIGATORIO, lblNumeroImovel.Text);

            if (!string.IsNullOrEmpty(txtBairro.Text))
                DmlContrato.End.Bairro = txtBairro.Text;
            else
                BoErro.DesErro(BoErro.CERRO_CAMPOOBRIGATORIO, lblBairro.Text);

            if (!string.IsNullOrEmpty(txtCidade.Text))
                DmlContrato.End.Cidade = txtCidade.Text;
            else
                BoErro.DesErro(BoErro.CERRO_CAMPOOBRIGATORIO, lblCidade.Text);

            if (!string.IsNullOrEmpty(txtUF.Text))
                DmlContrato.End.Uf = txtUF.Text;
            else
                BoErro.DesErro(BoErro.CERRO_CAMPOOBRIGATORIO, lblUF.Text);

            DmlContrato.End.Complemento = txtComplemento.Text;
            DmlContrato.End.Complemento2 = txtComplemento2.Text;


            if (DmlContrato.SituacaoContrato == Situacaocontrato.Renovado || DmlContrato.SituacaoContrato == Situacaocontrato.Andamento)
            {
                DmlContrato.Boletos = new List<Boleto>();
                BoBoletos boBoletos = new BoBoletos();
                string dtvencimento = $"{DmlContrato.DiaPagamento}/{DmlContrato.DataEntrada.Month}/{DmlContrato.DataEntrada.Year}";
                DateTime vencimento = Convert.ToDateTime(dtvencimento).Date;
                Periodo = DmlContrato.DataEntrada;
                UltimoPeriodo = DmlContrato.DataEntrada.AddMonths(1);

                for (int i = 0; i < DmlContrato.QtaMeses; i++)
                {
                    Boleto Boletos = new Boleto();
                    Boletos.Codigo = boBoletos.ObterUltCodBoleto();
                    Boletos.CodContrato = DmlContrato.Codigo.ToString().PadLeft(3, '0');
                    Boletos.NumBoleto = (i + 1).ToString().PadLeft(3, '0');
                    Boletos.Endereco = DmlContrato.End.End;
                    Boletos.Locador = DmlContrato.Locador;
                    Boletos.Locatario = DmlContrato.Locatario;
                    Boletos.Valor = DmlContrato.Valor;
                    Boletos.VlrIptu = DmlContrato.VlrIptu;
                    Boletos.DataVencimento = vencimento.AddMonths(i+1);
                    Boletos.JrComissao = Convert.ToDouble(BoParametro.C_PORADMIN);
                    double convrtcom = Convert.ToDouble(Boletos.JrComissao);
                    Boletos.VlrComissao = (convrtcom / 100) * Boletos.Valor;
                    Boletos.JrMulta = 0;
                    Boletos.VlrMulta = 0;
                    Boletos.JrDesconto = 0;
                    Boletos.VlrDesconto = 0;
                    Boletos.PagBoleto = Boleto.PagamentoBoleto.N;
                    Boletos.PeriodoInicio = Periodo.AddMonths(i).Date;

                    if (i == 0)
                        Boletos.PeriodoFim = UltimoPeriodo.AddMonths(i).Date;
                    else
                        Boletos.PeriodoFim = UltimoPeriodo.AddMonths(1).Date;

                    UltimoPeriodo = Boletos.PeriodoFim;
                    DmlContrato.Boletos.Add(Boletos);
                }
            }

            return DmlContrato;
        }

        private void AplicarEventos(TextBox txt)
        {
            txt.Enter += UtilHelpers.TirarMascara;
            txt.Leave += UtilHelpers.RetornarMascaraMoeda;
            txt.KeyPress += UtilHelpers.ApenasValorNumerico;
        }

        private void AplicarEventoCEP(TextBox txt)
        {
            txt.Enter += UtilHelpers.TirarMascaraCEP;
            txt.Leave += UtilHelpers.RetornarMascaraCEP;
            txt.KeyPress += UtilHelpers.ApenasValorNumerico;
        }

        #endregion
    }
}
