//using GestorImoveis.BLL;
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

namespace GestorImoveis.Forms
{
    public partial class Anuncios : Form
    {
        #region Globais
        /// <summary>
        /// 
        /// </summary>
        bool Alteracao = false;
        #endregion

        #region Construtor
        public Anuncios()
        {
            InitializeComponent();
            HabilitarCampos(false);
            AplicarEventos(txtPreco);
            AplicarEventos(txtIPTU);
        }
        #endregion


        #region Eventos

        private void RadioCriar_CheckedChanged(object sender, EventArgs e)
        {
            Alteracao = false;
            BoAnuncio boContrato = new BoAnuncio();
            HabilitarCampos(true);
            LimparCampos();
            gridAnuncio.DataSource = null;
            PreencherCombos();

        }

        private void RBAlterar_CheckedChanged(object sender, EventArgs e)
        {
            Alteracao = true;
            BoAnuncio boAnuncio = new BoAnuncio();
            HabilitarCampos(false);
            LimparCampos();
            gridAnuncio.DataSource = boAnuncio.ConsultaAnuncio();
            MontarGrid();
            gridAnuncio.Enabled = true;
            PreencherCombos();
        }

        private void RbConsultar_CheckedChanged(object sender, EventArgs e)
        {
            Alteracao = false;
            HabilitarCampos(false);
            LimparCampos();
            BoAnuncio boAnuncio = new BoAnuncio();
            gridAnuncio.DataSource = boAnuncio.ConsultaAnuncio();
            MontarGrid();
            gridAnuncio.Enabled = true;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RbNomeProp_CheckedChanged(object sender, EventArgs e)
        {
            LimparCampos();
        }
        private void RbCodigo_CheckedChanged(object sender, EventArgs e)
        {
            LimparCampos();
        }
        private void BtnPesquisa_Click(object sender, EventArgs e)
        {
            BoAnuncio boAnuncio = new BoAnuncio();

            try
            {

                if (RbCodigo.Checked == true && !string.IsNullOrEmpty(TxtPesquisa.Text))
                {
                    gridAnuncio.DataSource = boAnuncio.PesqContrato(TxtPesquisa.Text, RbCodigo.Text);
                }
                else if (RbRegiao.Checked == true && !string.IsNullOrEmpty(cboRegiaoPesq.Text))
                {
                    gridAnuncio.DataSource = boAnuncio.PesqContrato(cboRegiaoPesq.Text, RbRegiao.Text);
                }
                else if (RbNomeProp.Checked == true && !string.IsNullOrEmpty(TxtPesquisa.Text))
                {
                    gridAnuncio.DataSource = boAnuncio.PesqContrato(TxtPesquisa.Text, RbNomeProp.Text);
                }
                else
                {
                    gridAnuncio.DataSource = boAnuncio.ConsultaAnuncio();
                }

                MontarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboNeg_SelectedIndexChanged(object sender, EventArgs e)
        {
            BoAnuncio boAnuncio = new BoAnuncio();

            if (!this.Alteracao && RbConsultar.Checked == false)
            {
                if (cboNeg.Text == "Venda")
                    txtId.Text = boAnuncio.GeraCodigoSequencial(cboNeg.Text, "V");
                else if (cboNeg.Text == "Alugar")
                    txtId.Text = boAnuncio.GeraCodigoSequencial(cboNeg.Text, "A");
            }

        }

        private void cboRegiao_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboRegiao.Text == "Zona Norte" || cboRegiao.Text == "Zona Leste" || cboRegiao.Text == "Zona Oeste" || cboRegiao.Text == "Zona Sul")
            {
                string[] cidade = { "São Paulo" };

                cboCidade.DataSource = cidade;
            }
            else if (cboRegiao.Text == "Grande ABC")
            {
                string[] cidade = { "Selecionar", "Santo André", "São Bernardo do Campo", "São Caetano do Sul", "Diadema", "Ribeirão Pires", "Mauá", "Franco da Rocha", "Rio Grande da Serra" };

                cboCidade.DataSource = cidade;
            }
            else if (cboRegiao.Text == "Litoral")
            {
                string[] cidade = { "Praia Grande", "Santos", "Mongaguá", "Itanhaém", "Guarujá", "São Vicente", "Peruíbe", "Bertioga", "Ubatuba", "Caraguatatuba", "São Sebastião", "Ilhabela", "Ilha Comprida", "Iguape", "Cananéia", "Cubatão", "Itararé" };

                cboCidade.DataSource = cidade;
            }

        }

        private void cboCidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCidade.Text == "São Paulo" && cboRegiao.Text == "Zona Norte")
            {
                string[] bairo = { "Água Fria", "Alto de Santana", "Armênia", "Associação Sobradinho", "Barro Branco (Zona Norte)", "Bortolândia", "Brasilândia", "Cachoeirinha", "Carandiru", "Casa Verde", "Casa Verde Alta", "Casa Verde Baixa", "Casa Verde Média", "Chácara do Encosto", "Chácara do Rosário ",
                    "Chácara Inglesa (ZN)", "Chácara Nossa Senhora Aparecida", "Chora Menino", "City Jaraguá", "Cohab Santa Terezinha", "Conjunto dos Bancários", "Conjunto Habitacional Brigadeiro Eduardo Gomes", "Conjunto Residencial Vista Verde", "Freguesia do Ó", "Furnas", "Guapira", "Horto Florestal",
                    "Imirim", "Itaberaba", "Jaçanã", "Jaguaré", "Jardim Almanara" , "Jardim Alvina" , "Jardim Alvorada" , "Jardim Andaraí" , "Jardim Antártica" , "Jardim Apuana" , "Jardim Ataliba Leonel" , "Jardim Bandeirantes (Zona Norte)" , "Jardim Bela Vista (Zona Norte)" , "Jardim Bibi" ,
                    "Jardim Brasil" , "Jardim Brasil Novo" , "Jardim Brasília (Zona Norte)" , "Jardim Cabuçu" , "Jardim Cachoeira" , "Jardim Campo Limpo" , "Jardim Carlu" , "Jardim Carombé" , "Jardim Cecy" , "Jardim Centenário" , "Jardim Cidade Pirituba" , "Jardim Corisco", "Jardim Cristina" , "Jardim Cruz do Corisco" ,
                    "Jardim da Montanha" , "Jardim Damasceno" , "Jardim das Cerejeiras" , "Jardim das Graças" , "Jardim das Laranjeiras" , "Jardim das Pedras" , "Jardim das Rosas" , "Jardim Daysy" , "Jardim do Colégio" , "Jardim do Tiro" , "Jardim dos Francos" , "Jardim Elisa Maria" , "Jardim Elisio", "Jardim Entre Serras",
                    "Jardim Estrela D'alva", "Jardim Felicidade", "Jardim Filhos da Terra", "Jardim Flor de Maio", "Jardim Floresta", "Jardim Fontalis", "Jardim França", "Jardim Francisco Mendes", "Jardim Guançã", "Jardim Guapira", "Jardim Guarani" };

                cboBairro.DataSource = bairo;
            }

            if (cboCidade.Text == "São Paulo" && cboRegiao.Text == "Zona Leste")
            {
                string[] bairo = { "" };

                cboBairro.DataSource = bairo;
            }

            if (cboCidade.Text == "São Paulo" && cboRegiao.Text == "Zona Oeste")
            {
                string[] bairo = { "" };

                cboBairro.DataSource = bairo;
            }

            if (cboCidade.Text == "São Paulo" && cboRegiao.Text == "Zona Sul")
            {
                string[] bairo = { "" };

                cboBairro.DataSource = bairo;
            }

        }

        private void gridAnuncio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 || e.ColumnIndex == 27)
            {
                BoAnuncio boAnuncio = new BoAnuncio();
                string CodAnuncio = gridAnuncio.Rows[e.RowIndex].Cells["Codigo"].FormattedValue.ToString();
                var table = boAnuncio.ObterAnuncio(CodAnuncio);
                if (RBAlterar.Checked == true)
                {
                    HabilitarCampos(true);
                    BtnUploadImage.Enabled = true;
                    BtnUploadImage.Visible = true;
                }

                txtId.Text = table[0].Codigo;
                cboNeg.Text = table[0].Negocio;
                cboRegiao.Text = table[0].Regiao;
                cboTipoImov.Text = table[0].TipoImovel;
                txtPreco.Text = table[0].Valor.ToString();
                txtIPTU.Text = table[0].VlrIptu.ToString();
                txtDorm.Text = table[0].Dormitorio.ToString();
                txtSuites.Text = table[0].Suites.ToString();

                txtVagas.Text = table[0].Vagas.ToString();
                txtArea.Text = table[0].Area.ToString();
                cboCidade.Text = table[0].Cidade;
                cboBairro.Text = table[0].Bairro;
                txtEndereco.Text = table[0].Endereco;
                cboSituacao.Text = UtilHelpers.TipoSituacao.Ativo == table[0].Ativo ? "Ativo" : "Inativo";

                txtNomeProp.Text = table[0].Proprietario;
                txtObs.Text = table[0].Obs;

                ckPermuta.Checked = table[0].Permuta;
                ckChurrasqueira.Checked = table[0].Churrasqueira;
                chPiscina.Checked = table[0].Piscina;
                ckBrinquedoteca.Checked = table[0].Brinquedoteca;
                ckPlayground.Checked = table[0].Playgroud;
                ckPoliesportiva.Checked = table[0].Poliesportiva;
                ckGinástica.Checked = table[0].Ginastica;
                ckFestas.Checked = table[0].Festas;
                ckJogos.Checked = table[0].Jogos;


            }

            if (e.ColumnIndex == 1 || e.ColumnIndex == 28)
            {
                BoAnuncio boAnuncio = new BoAnuncio();
                string CodAnuncio = gridAnuncio.Rows[e.RowIndex].Cells["Codigo"].FormattedValue.ToString();
                boAnuncio.DeleteAnuncio(CodAnuncio);
                MessageBox.Show($"Anuncio {CodAnuncio} removido com sucesso", "SUCESSO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gridAnuncio.DataSource = boAnuncio.ConsultaAnuncio();
                InciarAmbiente();
            }
        }

        private void buttonGravar_Click(object sender, EventArgs e)
        {
            BoAnuncio boAnuncio = new BoAnuncio();
            try
            {
                Anuncio anuncio = ConverterFormToDML();
                if (Alteracao == true)
                {
                    boAnuncio.AtualizarAnuncio(anuncio);
                    MessageBox.Show("Registro alterado com sucesso", "SUCESSO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gridAnuncio.DataSource = boAnuncio.ConsultaAnuncio();
                    InciarAmbiente();
                }
                else
                {
                    boAnuncio.IncluirAnuncio(anuncio);
                    MessageBox.Show("Cadastro realizado com sucesso", "SUCESSO!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    HabilitarCampos(false);

                    BtnUploadImage.Enabled = true;
                    buttonGravar.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                lblMsgErro.Text = string.Empty;
                lblMsgErro.Visible = true;
                lblMsgErro.Text = ex.Message;
            }
        }

        private void RbRegiao_CheckedChanged(object sender, EventArgs e)
        {
            TxtPesquisa.Visible = false;
            cboRegiaoPesq.Visible = true;
            string[] regiao = { "Selecionar", "Zona Norte", "Zona Leste", "Zona Oeste", "Zona Sul", "Grande ABC", "Litoral" };
            cboRegiaoPesq.DataSource = regiao;
        }

        private void BtnUploadImage_Click(object sender, EventArgs e)
        {
            Forms.UploadImageForm Form = null;
            if (Alteracao)
                Form = new UploadImageForm(txtId.Text, true, null);
            else
                Form = new UploadImageForm(txtId.Text, false, this);

            Form.ShowDialog();
        }

        #endregion

        #region Metodos

        /// <summary>
        /// 
        /// </summary>
        private void MontarGrid()
        {
            if (!RadioCriar.Checked == true)
            {
                DataGridViewButtonColumn BtnEdit = new DataGridViewButtonColumn();
                BtnEdit.Name = "BtnEdit";
                BtnEdit.Width = 30;
                BtnEdit.UseColumnTextForButtonValue = true;
                BtnEdit.HeaderText = "Alt.";


                DataGridViewButtonColumn BtnPrint = new DataGridViewButtonColumn();
                BtnEdit.Name = "BtnExcluir";
                BtnEdit.Width = 30;
                BtnEdit.UseColumnTextForButtonValue = true;


                if (!gridAnuncio.Columns.Contains(BtnEdit.Name = "BtnEdit"))
                {
                    gridAnuncio.Columns.Add(BtnEdit);
                }

                if (!gridAnuncio.Columns.Contains(BtnPrint.Name = "BtnExcluir"))
                {
                    gridAnuncio.Columns.Add(BtnPrint);
                }

                gridAnuncio.Columns["Codigo"].HeaderText = "Cod.";
                gridAnuncio.Columns["Codigo"].Width = 40;
                gridAnuncio.Columns["Codigo"].DisplayIndex = 0;

                gridAnuncio.Columns["Proprietario"].HeaderText = "Proprietario";
                gridAnuncio.Columns["Proprietario"].Width = 146;
                gridAnuncio.Columns["Proprietario"].DisplayIndex = 1;

                gridAnuncio.Columns["Negocio"].HeaderText = "Neg.";
                gridAnuncio.Columns["Negocio"].Width = 48;
                gridAnuncio.Columns["Negocio"].DisplayIndex = 2;

                gridAnuncio.Columns["Bairro"].HeaderText = "Bairro";
                gridAnuncio.Columns["Bairro"].Width = 120;
                gridAnuncio.Columns["Bairro"].DisplayIndex = 3;

                gridAnuncio.Columns["Cidade"].HeaderText = "Cidade";
                gridAnuncio.Columns["Cidade"].Width = 80;
                gridAnuncio.Columns["Cidade"].DisplayIndex = 4;

                gridAnuncio.Columns["Regiao"].HeaderText = "Regiao";
                gridAnuncio.Columns["Regiao"].Width = 80;
                gridAnuncio.Columns["Regiao"].DisplayIndex = 5;

                gridAnuncio.Columns["TipoImovel"].HeaderText = "Tipo Imovel";
                gridAnuncio.Columns["TipoImovel"].Width = 90;
                gridAnuncio.Columns["TipoImovel"].DisplayIndex = 6;

                gridAnuncio.Columns["DataAtualizacao"].HeaderText = "Data de Atualização";
                gridAnuncio.Columns["DataAtualizacao"].Width = 70;
                gridAnuncio.Columns["DataAtualizacao"].DisplayIndex = 7;

                gridAnuncio.Columns["Valor"].HeaderText = "Valor";
                gridAnuncio.Columns["Valor"].Width = 80;
                gridAnuncio.Columns["Valor"].DisplayIndex = 8;

                gridAnuncio.Columns["Ativo"].HeaderText = "Ativo";
                gridAnuncio.Columns["Ativo"].Width = 50;
                gridAnuncio.Columns["Ativo"].DisplayIndex = 9;

                gridAnuncio.Columns["BtnEdit"].DisplayIndex = 10;
                gridAnuncio.Columns["BtnExcluir"].DisplayIndex = 11;
                gridAnuncio.Columns["BtnExcluir"].Width = 30;
                gridAnuncio.Columns["BtnExcluir"].HeaderText = "Del.";

                gridAnuncio.Columns["Endereco"].Visible = false;
                gridAnuncio.Columns["VlrIptu"].Visible = false;
                gridAnuncio.Columns["Dormitorio"].Visible = false;
                gridAnuncio.Columns["Suites"].Visible = false;
                gridAnuncio.Columns["Vagas"].Visible = false;
                gridAnuncio.Columns["Area"].Visible = false;
                gridAnuncio.Columns["Obs"].Visible = false;
                gridAnuncio.Columns["DataCadastro"].Visible = false;
                gridAnuncio.Columns["Permuta"].Visible = false;
                gridAnuncio.Columns["Churrasqueira"].Visible = false;
                gridAnuncio.Columns["Piscina"].Visible = false;
                gridAnuncio.Columns["Brinquedoteca"].Visible = false;
                gridAnuncio.Columns["Playgroud"].Visible = false;
                gridAnuncio.Columns["Poliesportiva"].Visible = false;
                gridAnuncio.Columns["Ginastica"].Visible = false;
                gridAnuncio.Columns["Festas"].Visible = false;
                gridAnuncio.Columns["Jogos"].Visible = false;

                gridAnuncio.ColumnHeadersVisible = true;
            }
            else
                gridAnuncio.ColumnHeadersVisible = false;
        }

        /// <summary>
        /// 
        /// </summary>
        private void InciarAmbiente()
        {
            LimparCampos();
            this.Refresh();
            RadioCriar.Checked = false;
            MontarGrid();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="pHabilitar"></param>
        private void HabilitarCampos(bool pHabilitar)
        {
            cboNeg.Enabled = pHabilitar;
            cboRegiao.Enabled = pHabilitar;
            cboTipoImov.Enabled = pHabilitar;
            txtId.Enabled = false;
            txtPreco.Enabled = pHabilitar;
            txtIPTU.Enabled = pHabilitar;
            txtDorm.Enabled = pHabilitar;
            txtSuites.Enabled = pHabilitar;

            txtVagas.Enabled = pHabilitar;
            txtArea.Enabled = pHabilitar;
            cboCidade.Enabled = pHabilitar;
            cboBairro.Enabled = pHabilitar;

            txtNomeProp.Enabled = pHabilitar;
            txtEndereco.Enabled = pHabilitar;
            txtObs.Enabled = pHabilitar;
            cboSituacao.Enabled = pHabilitar;

            ckPermuta.Enabled = pHabilitar;
            ckChurrasqueira.Enabled = pHabilitar;
            chPiscina.Enabled = pHabilitar;
            ckBrinquedoteca.Enabled = pHabilitar;
            ckPlayground.Enabled = pHabilitar;
            ckPoliesportiva.Enabled = pHabilitar;
            ckGinástica.Enabled = pHabilitar;
            ckFestas.Enabled = pHabilitar;
            ckJogos.Enabled = pHabilitar;

            TxtPesquisa.Enabled = false;
            RbNomeProp.Enabled = false;
            RbCodigo.Enabled = false;
            RbRegiao.Enabled = false;
            BtnPesquisa.Enabled = false;
            cboRegiaoPesq.Visible = false;

            buttonGravar.Visible = pHabilitar;
            buttonGravar.Enabled = pHabilitar;
            BtnUploadImage.Enabled = false;
            BtnUploadImage.Visible = false;

            if (RbConsultar.Checked == true || RBAlterar.Checked == true)
            {
                TxtPesquisa.Enabled = true;
                RbNomeProp.Enabled = true;
                RbCodigo.Enabled = true;
                RbRegiao.Enabled = true;
                BtnPesquisa.Enabled = true;
            }

            if (RadioCriar.Checked == true)
            {
                buttonGravar.Visible = true;
                buttonGravar.Enabled = true;
                BtnUploadImage.Visible = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
       public void LimparCampos()
        {
            cboNeg.Text = string.Empty;
            cboRegiao.Text = string.Empty;
            cboTipoImov.Text = string.Empty;
            txtId.Text = string.Empty;
            txtPreco.Text = string.Empty;
            txtIPTU.Text = string.Empty;
            txtDorm.Text = string.Empty;
            txtSuites.Text = string.Empty;

            txtVagas.Text = string.Empty;
            txtArea.Text = string.Empty;
            cboCidade.Text = string.Empty;
            cboBairro.Text = string.Empty;

            txtNomeProp.Text = string.Empty;
            txtEndereco.Text = string.Empty;
            txtObs.Text = string.Empty;

            ckPermuta.Checked = false;
            ckChurrasqueira.Checked = false;
            chPiscina.Checked = false;
            ckBrinquedoteca.Checked = false;
            ckPlayground.Checked = false;
            ckPoliesportiva.Checked = false;
            ckGinástica.Checked = false;
            ckFestas.Checked = false;
            ckJogos.Checked = false;
            lblMsgErro.Text = string.Empty;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private Anuncio ConverterFormToDML()
        {
            var dmlAnuncio = new Anuncio();
            if (!string.IsNullOrEmpty(txtId.Text))
                dmlAnuncio.Codigo = Convert.ToString(txtId.Text);
            else
                BoErro.DesErro(BoErro.CERRO_CAMPOOBRIGATORIO, lblCodigo.Text);

            if (!string.IsNullOrEmpty(cboNeg.Text))
                dmlAnuncio.Negocio = cboNeg.Text;
            else
                BoErro.DesErro(BoErro.CERRO_CAMPOOBRIGATORIO, lblNeg.Text);

            if (!string.IsNullOrEmpty(cboRegiao.Text))
                dmlAnuncio.Regiao = cboRegiao.Text;
            else
                BoErro.DesErro(BoErro.CERRO_CAMPOOBRIGATORIO, lblReg.Text);

            if (!string.IsNullOrEmpty(cboTipoImov.Text))
                dmlAnuncio.TipoImovel = cboTipoImov.Text;
            else
                BoErro.DesErro(BoErro.CERRO_CAMPOOBRIGATORIO, lblTipoImovel.Text);

            if (!string.IsNullOrEmpty(txtPreco.Text))
                dmlAnuncio.Valor = Convert.ToDouble(txtPreco.Text.Replace("R$", "").Trim());
            else
                BoErro.DesErro(BoErro.CERRO_CAMPOOBRIGATORIO, lblPreco.Text);

            if (!string.IsNullOrEmpty(txtIPTU.Text))
                dmlAnuncio.VlrIptu = Convert.ToDouble(txtIPTU.Text.Replace("R$", "").Trim());
            else
                BoErro.DesErro(BoErro.CERRO_CAMPOOBRIGATORIO, lblIptu.Text);

            if (!string.IsNullOrEmpty(txtDorm.Text))
                dmlAnuncio.Dormitorio = Convert.ToInt32(txtDorm.Text);
            else
                BoErro.DesErro(BoErro.CERRO_CAMPOOBRIGATORIO, lblDorm.Text);

            if (!string.IsNullOrEmpty(txtSuites.Text))
                dmlAnuncio.Suites = Convert.ToInt32(txtSuites.Text);
            else
                BoErro.DesErro(BoErro.CERRO_CAMPOOBRIGATORIO, lblsuites.Text);

            if (!string.IsNullOrEmpty(txtVagas.Text))
                dmlAnuncio.Vagas = Convert.ToInt32(txtVagas.Text);
            else
                BoErro.DesErro(BoErro.CERRO_CAMPOOBRIGATORIO, lblVagas.Text);

            if (!string.IsNullOrEmpty(txtArea.Text))
                dmlAnuncio.Area = Convert.ToInt32(txtArea.Text);
            else
                BoErro.DesErro(BoErro.CERRO_CAMPOOBRIGATORIO, lblArea.Text);

            if (!string.IsNullOrEmpty(cboCidade.Text))
                dmlAnuncio.Cidade = cboCidade.Text;
            else
                BoErro.DesErro(BoErro.CERRO_CAMPOOBRIGATORIO, lblCidade.Text);

            if (!string.IsNullOrEmpty(cboBairro.Text))
                dmlAnuncio.Bairro = cboBairro.Text;
            else
                BoErro.DesErro(BoErro.CERRO_CAMPOOBRIGATORIO, lblBairro.Text);

            if (!string.IsNullOrEmpty(txtNomeProp.Text))
                dmlAnuncio.Proprietario = txtNomeProp.Text;
            else
                BoErro.DesErro(BoErro.CERRO_CAMPOOBRIGATORIO, lblNomeProp.Text);

            if (!string.IsNullOrEmpty(txtEndereco.Text))
                dmlAnuncio.Endereco = txtEndereco.Text;
            else
                BoErro.DesErro(BoErro.CERRO_CAMPOOBRIGATORIO, lblEndereco.Text);

            if (!string.IsNullOrEmpty(txtObs.Text))
                dmlAnuncio.Obs = txtObs.Text;
            else
                BoErro.DesErro(BoErro.CERRO_CAMPOOBRIGATORIO, lblObs.Text);


            if (cboSituacao.Text == "Ativo")
                cboSituacao.Text = "A";
            else
                cboSituacao.Text = "I";

            dmlAnuncio.Ativo = UtilHelpers.ConverterTipoSituacao(cboSituacao.Text);
            dmlAnuncio.DataCadastro = DateTime.Now.Date;

            // checkbox
            dmlAnuncio.Permuta = ckPermuta.Checked;
            dmlAnuncio.Churrasqueira = ckChurrasqueira.Checked;
            dmlAnuncio.Piscina = chPiscina.Checked;
            dmlAnuncio.Brinquedoteca = ckBrinquedoteca.Checked;
            dmlAnuncio.Playgroud = ckPlayground.Checked;
            dmlAnuncio.Poliesportiva = ckPoliesportiva.Checked;
            dmlAnuncio.Ginastica = ckGinástica.Checked;
            dmlAnuncio.Festas = ckFestas.Checked;
            dmlAnuncio.Jogos = ckJogos.Checked;

            return dmlAnuncio;
        }

        /// <summary>
        /// 
        /// </summary>
        private void PreencherCombos()
        {
            string[] regiao = { "Selecionar", "Zona Norte", "Zona Leste", "Zona Oeste", "Zona Sul", "Grande ABC", "Litoral" };
            cboRegiao.DataSource = regiao;

            string[] negocio = { "Selecionar", "Venda", "Alugar" };
            cboNeg.DataSource = negocio;

            string[] tipoImovel = { "Selecionar", "Apartamento", "Sobrado", "Casa Térrea", "Condomínio Fechado", "Apartamento Duplex", "Cobertura", "Flat / Studio", "Kitnet / Loft", "Imóvel para Renda", "Chácara / Sítio", "Terreno", "Prédio", "Casa Comercial", "Sala Comercial", "Galpão / Salão", "Ponto Comercial", "Prédio Comercial", "Loja de Shopping", "Quiosque", "Pousada / Chalé" };
            cboTipoImov.DataSource = tipoImovel;


            cboSituacao.DataSource = Enum.GetValues(typeof(UtilHelpers.TipoSituacao));
        }

        public  void FinalizarAnuncio()
        {
            RadioCriar.Checked = false;
            HabilitarCampos(false);
            LimparCampos();
            MessageBox.Show($"Anuncio {txtId.Text} cadastrado com sucesso!", "SUCESSO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AplicarEventos(TextBox txt)
        {
            txt.Enter += UtilHelpers.TirarMascara;
            txt.Leave += UtilHelpers.RetornarMascaraMoeda;
            txt.KeyPress += UtilHelpers.ApenasValorNumerico;
        }

        #endregion

        private void Anuncios_Load(object sender, EventArgs e)
        {

        }
    }
}
