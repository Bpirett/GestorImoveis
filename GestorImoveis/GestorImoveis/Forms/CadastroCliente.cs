using GestorImoveis.BLL;
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
using GestorImoveis.Helpers;
using System.Collections;
using Correios;


namespace GestorImoveis.Forms
{
    public partial class CadastroCliente : Form
    {
        #region Globais
        /// <summary>
        /// 
        /// </summary>
        bool Alteracao = false;
        #endregion

        #region Construtor
        public CadastroCliente()
        {
            InitializeComponent();
            InciarAmbiente();
            AplicarEventoCEP(txtCEP);
            HabilitarCampos(false);
        }

        #endregion

        #region Eventos
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Alteracao = false;
            BoCliente boCliente = new BoCliente();
            HabilitarCampos(true);
            LimparCampos();
            txtId.Text = boCliente.ObterUltCodCli();
            gridCliente.Enabled = false;
            gridCliente.DataSource = null;
            PreencherCombos();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

            BoCliente boCliente = new BoCliente();
            LimparCampos();
            HabilitarCampos(false);
            gridCliente.DataSource = boCliente.ConsultaClientes();
            MontarGrid();
            Alteracao = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

            BoCliente boCliente = new BoCliente();
            LimparCampos();
            HabilitarCampos(true);
            gridCliente.DataSource = boCliente.ConsultaClientes();
            MontarGrid();
            PreencherCombos();
            Alteracao = true;
        }

        private void buttonGravar_Click(object sender, EventArgs e)
        {

            BoCliente boCliente = new BoCliente();
            try
            {
                Cliente cliente = ConverterFormToDML();
                if (Alteracao == true)
                {
                    boCliente.AtualizarCliente(cliente);
                    boCliente.GravarLogCliente(cliente);
                    MessageBox.Show("Registro alterado com sucesso", "SUCESSO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gridCliente.DataSource = boCliente.ConsultaClientes();
                    MontarGrid();
                }
                else
                {
                    boCliente.IncluirCliente(cliente);
                    boCliente.GravarLogCliente(cliente);

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
                lblMsgErro.Text = string.Empty;
                lblMsgErro.Visible = true;
                lblMsgErro.Text = ex.Message;
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnPesquisa_Click(object sender, EventArgs e)
        {
            BoCliente boCliente = new BoCliente();


            try
            {

                if (RbCodigo.Checked == true && !string.IsNullOrEmpty(TxtPesquisa.Text))
                {
                    gridCliente.DataSource = boCliente.ObterCliente(TxtPesquisa.Text, RbCodigo.Text);
                }
                else if (RbCPF.Checked == true && !string.IsNullOrEmpty(TxtPesquisa.Text))
                {
                    gridCliente.DataSource = boCliente.ObterCliente(TxtPesquisa.Text, RbCPF.Text);
                }
                else if (RbNome.Checked == true && !string.IsNullOrEmpty(TxtPesquisa.Text))
                {
                    gridCliente.DataSource = boCliente.ObterCliente(TxtPesquisa.Text, RbNome.Text);
                }
                else
                    gridCliente.DataSource = boCliente.ConsultaClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridCliente_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 9 || e.ColumnIndex == 0)
            {
                BoCliente boCliente = new BoCliente();
                string CodCliente = gridCliente.Rows[e.RowIndex].Cells["Codigo"].FormattedValue.ToString();
                var table = boCliente.ObterCliente(CodCliente, RbCodigo.Text);

                txtId.Text = gridCliente.Rows[e.RowIndex].Cells["Codigo"].FormattedValue.ToString();
                txtNome.Text = table[0].Nome;
                txtCPF.Text = table[0].CPF;
                txtEmail.Text = table[0].Email;
                txtNumeroFixo.Text = table[0].TelefoneFixo;
                txtCelula.Text = table[0].Celular;
                cboTipoCliente.Text = table[0].tipoCliente;
                cboAtivoCli.Text = UtilHelpers.ConverterTipoSituacao(table[0].ClienteAtivo);
                txtCEP.Text = table[0].Endereco.Cep;
                txtEndereco.Text = table[0].Endereco.End;
                txtNumeroImovel.Text = table[0].Endereco.NumeroImovel.ToString();
                txtBairro.Text = table[0].Endereco.Bairro;
                txtCidade.Text = table[0].Endereco.Cidade;
                txtUF.Text = table[0].Endereco.Uf;
                txtComplemento.Text = table[0].Endereco.Complemento;
                txtComplemento2.Text = table[0].Endereco.Complemento2;
            }
        }

        private void txtCEP_TextChanged(object sender, EventArgs e)
        {
            if (txtCEP.TextLength == 9)
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
        }

        private void ckNaoInfEnd_CheckedChanged(object sender, EventArgs e)
        {
            if (ckNaoInfEnd.Checked == true)
            {
                txtEndereco.Enabled = false;
                txtBairro.Enabled = false;
                txtUF.Enabled = false;
                txtCidade.Enabled = false;
                txtComplemento.Enabled = false;
                txtComplemento2.Enabled = false;
                txtCEP.Enabled = false;
                txtNumeroImovel.Enabled = false;
            }
            else
            {
                txtEndereco.Enabled = true;
                txtBairro.Enabled = true;
                txtUF.Enabled = true;
                txtCidade.Enabled = true;
                txtComplemento.Enabled = true;
                txtComplemento2.Enabled = true;
                txtCEP.Enabled = true;
                txtNumeroImovel.Enabled = true;
            }

        }

        #endregion

        #region Metodos

        /// <summary>
        /// 
        /// </summary>
        private void MontarGrid()
        {
            gridCliente.Enabled = true;

            if (!RadioCriar.Checked == true)
            {
                DataGridViewButtonColumn BtnEdit = new DataGridViewButtonColumn();
                BtnEdit.HeaderText = "";
                BtnEdit.Name = "BtnEdit";
                BtnEdit.Width = 30;
                BtnEdit.UseColumnTextForButtonValue = true;

                if (!gridCliente.Columns.Contains(BtnEdit.Name = "BtnEdit"))
                {
                    gridCliente.Columns.Add(BtnEdit);
                }

                gridCliente.Columns["Codigo"].HeaderText = "Cod.";
                gridCliente.Columns["Codigo"].Width = 30;
                gridCliente.Columns["Codigo"].DisplayIndex = 0;

                gridCliente.Columns["Nome"].HeaderText = "Nome";
                gridCliente.Columns["Nome"].Width = 137;
                gridCliente.Columns["Nome"].DisplayIndex = 1;

                gridCliente.Columns["CPF"].HeaderText = "CPF";
                gridCliente.Columns["CPF"].Width = 100;
                gridCliente.Columns["CPF"].DisplayIndex = 2;

                gridCliente.Columns["TelefoneFixo"].HeaderText = "Telefone";
                gridCliente.Columns["TelefoneFixo"].Width = 100;
                gridCliente.Columns["TelefoneFixo"].DisplayIndex = 3;

                gridCliente.Columns["Celular"].HeaderText = "Celular";
                gridCliente.Columns["Celular"].Width = 100;
                gridCliente.Columns["Celular"].DisplayIndex = 4;

                gridCliente.Columns["Email"].HeaderText = "E-mail";
                gridCliente.Columns["Email"].Width = 150;
                gridCliente.Columns["Email"].DisplayIndex = 5;

                gridCliente.Columns["tipoCliente"].HeaderText = "Tipo";
                gridCliente.Columns["tipoCliente"].Width = 68;
                gridCliente.Columns["tipoCliente"].DisplayIndex = 6;

                gridCliente.Columns["ClienteAtivo"].HeaderText = "Ativo";
                gridCliente.Columns["ClienteAtivo"].Width = 58;
                gridCliente.Columns["ClienteAtivo"].DisplayIndex = 7;

                gridCliente.Columns["BtnEdit"].DisplayIndex = 8;

                gridCliente.Columns["Endereco"].Visible = false;

                gridCliente.ColumnHeadersVisible = true;
            }
            else
                gridCliente.ColumnHeadersVisible = false;
        }

        /// <summary>
        /// 
        /// </summary>
        void InciarAmbiente()
        {
            LimparCampos();
            this.Refresh();
            RadioCriar.Checked = false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pHabilitar"></param>
        private void HabilitarCampos(bool pHabilitar)
        {
            txtCelula.Enabled = pHabilitar;
            txtCPF.Enabled = pHabilitar;
            txtEmail.Enabled = pHabilitar;
            txtId.Enabled = false;
            txtNome.Enabled = pHabilitar;
            txtNumeroFixo.Enabled = pHabilitar;
            cboTipoCliente.Enabled = pHabilitar;
            cboAtivoCli.Enabled = pHabilitar;
            TxtPesquisa.Enabled = false;
            RbNome.Enabled = false;
            RbCodigo.Enabled = false;
            RbCPF.Enabled = false;
            BtnPesquisa.Enabled = false;
            buttonGravar.Visible = pHabilitar;
            buttonGravar.Enabled = pHabilitar;
            txtEndereco.Enabled = pHabilitar;
            txtBairro.Enabled = pHabilitar;
            txtUF.Enabled = pHabilitar;
            txtCidade.Enabled = pHabilitar;
            txtComplemento.Enabled = pHabilitar;
            txtComplemento2.Enabled = pHabilitar;
            txtCEP.Enabled = pHabilitar;
            txtNumeroImovel.Enabled = pHabilitar;


            if (RbConsultar.Checked == true || RBAlterar.Checked == true)
            {
                TxtPesquisa.Enabled = true;
                RbNome.Enabled = true;
                RbCodigo.Enabled = true;
                RbCPF.Enabled = true;
                BtnPesquisa.Enabled = true;
            }

            if (RbConsultar.Checked == true)
                buttonGravar.Visible = false;
        }

        /// <summary>
        /// 
        /// </summary>
        private void LimparCampos()
        {
            txtCelula.Text = string.Empty;
            txtCPF.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtId.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtNumeroFixo.Text = string.Empty;
            cboTipoCliente.Text = string.Empty;
            cboAtivoCli.Text = string.Empty;
            lblMsgErro.Text = string.Empty;
            txtEndereco.Text = string.Empty;
            txtBairro.Text = string.Empty;
            txtUF.Text = string.Empty;
            txtCidade.Text = string.Empty;
            txtComplemento.Text = string.Empty;
            txtComplemento2.Text = string.Empty;
            txtCEP.Text = string.Empty;
            txtNumeroImovel.Text = string.Empty;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private Cliente ConverterFormToDML()
        {
            var DmlCliente = new Cliente();
            DmlCliente.Endereco = new Endereco();

            if (!string.IsNullOrEmpty(txtId.Text))
                DmlCliente.Codigo = Convert.ToString(txtId.Text);
            else
                BoErro.DesErro(BoErro.CERRO_CAMPOOBRIGATORIO, lblCodigo.Text);

            if (!string.IsNullOrEmpty(txtNome.Text))
                DmlCliente.Nome = txtNome.Text;
            else
                BoErro.DesErro(BoErro.CERRO_CAMPOOBRIGATORIO, lblNome.Text);

            if (!string.IsNullOrEmpty(txtCPF.Text))
                DmlCliente.CPF = txtCPF.Text;
            else
                BoErro.DesErro(BoErro.CERRO_CAMPOOBRIGATORIO, lblCPF.Text);

            if (!UtilHelpers.ValidaCPF(txtCPF.Text))
                BoErro.DesErro(BoErro.CERRO_CPF_INVALIDO, txtCPF.Text);

            if (!string.IsNullOrEmpty(txtEmail.Text))
                DmlCliente.Email = txtEmail.Text;

            if (!string.IsNullOrEmpty(txtNumeroFixo.Text))
                DmlCliente.TelefoneFixo = txtNumeroFixo.Text;
            else
                BoErro.DesErro(BoErro.CERRO_CAMPOOBRIGATORIO, lblTelefone.Text);

            if (!string.IsNullOrEmpty(txtCelula.Text))
                DmlCliente.Celular = txtCelula.Text;
            else
                BoErro.DesErro(BoErro.CERRO_CAMPOOBRIGATORIO, lblCelular.Text);

            if (!string.IsNullOrEmpty(cboTipoCliente.Text) || cboAtivoCli.Text == "Selecionar")
                DmlCliente.tipoCliente = cboTipoCliente.Text;
            else
                BoErro.DesErro(BoErro.CERRO_CAMPOOBRIGATORIO, lblTpCliente.Text);

            if (!string.IsNullOrEmpty(txtCEP.Text))
                DmlCliente.Endereco.Cep = txtCEP.Text;
            else if (!ckNaoInfEnd.Checked == true)
                BoErro.DesErro(BoErro.CERRO_CAMPOOBRIGATORIO, lblCEP.Text);

            if (!string.IsNullOrEmpty(txtNumeroImovel.Text))
                DmlCliente.Endereco.NumeroImovel = Convert.ToInt32(txtNumeroImovel.Text);
            else if (!ckNaoInfEnd.Checked == true)
                BoErro.DesErro(BoErro.CERRO_CAMPOOBRIGATORIO, lblNumeroImovel.Text);

            if (!string.IsNullOrEmpty(txtEndereco.Text))
                DmlCliente.Endereco.End = Convert.ToString(txtEndereco.Text);
            else if (!ckNaoInfEnd.Checked == true)
                BoErro.DesErro(BoErro.CERRO_CAMPOOBRIGATORIO, lblEnd.Text);

            if (!string.IsNullOrEmpty(txtBairro.Text))
                DmlCliente.Endereco.Bairro = txtBairro.Text;
            else if (!ckNaoInfEnd.Checked == true)
                BoErro.DesErro(BoErro.CERRO_CAMPOOBRIGATORIO, lblBairro.Text);

            if (!string.IsNullOrEmpty(txtCidade.Text))
                DmlCliente.Endereco.Cidade = txtCidade.Text;
            else if (!ckNaoInfEnd.Checked == true)
                BoErro.DesErro(BoErro.CERRO_CAMPOOBRIGATORIO, lblCidade.Text);

            if (!string.IsNullOrEmpty(txtUF.Text))
                DmlCliente.Endereco.Uf = txtUF.Text;
            else if (!ckNaoInfEnd.Checked == true)
                BoErro.DesErro(BoErro.CERRO_CAMPOOBRIGATORIO, lblUF.Text);

            DmlCliente.Endereco.Complemento = txtComplemento.Text;
            DmlCliente.Endereco.Complemento2 = txtComplemento2.Text;

            if (!Alteracao)
            {
                BoCliente boCliente = new BoCliente();
                if (boCliente.ValidaExistenciaCPF(DmlCliente.CPF))
                    BoErro.DesErro(BoErro.CERRO_CPFEXISTENTE, lblCPF.Text);
            }

            if (cboAtivoCli.Text == "Ativo")
                cboAtivoCli.Text = "A";
            else
                cboAtivoCli.Text = "I";

            DmlCliente.ClienteAtivo = UtilHelpers.ConverterTipoSituacao(cboAtivoCli.Text);

            return DmlCliente;
        }

        /// <summary>
        /// 
        /// </summary>
        private void PreencherCombos()
        {
            string[] tipocliente = { "Selecionar", "Locatario", "Locador" };
            cboTipoCliente.DataSource = tipocliente;
            cboAtivoCli.DataSource = Enum.GetValues(typeof(UtilHelpers.TipoSituacao));

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
