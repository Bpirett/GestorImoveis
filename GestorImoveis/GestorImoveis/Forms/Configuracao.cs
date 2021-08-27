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

namespace GestorImoveis.Forms
{
    public partial class Configuracao : Form
    {
        #region Globais
        /// <summary>
        /// 
        /// </summary>
        bool Alteracao = false;
        #endregion


        #region Construtor
        public Configuracao()
        {
            InitializeComponent();
            HabilitarCampos(false);
            LimparCampos();
        }
        #endregion

        #region Eventos
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonGravar_Click(object sender, EventArgs e)
        {
            BoParametro boParametro = new BoParametro();
            try
            {
                Parametro parametro = ConverterFormToDML();
                if (Alteracao == true)
                {
                    boParametro.AlterarParametro(parametro);

                    MessageBox.Show("Registro alterado com sucesso", "SUCESSO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                gridParametros.DataSource = boParametro.ConsultaParametro();
            }
            catch (Exception ex)
            {
                lblMsgErro.Visible = true;
                lblMsgErro.Text = ex.Message;
            }
        }

        private void RBAlterar_CheckedChanged(object sender, EventArgs e)
        {
            Alteracao = true;
            BoParametro boParametro = new BoParametro();
            HabilitarCampos(true);
            LimparCampos();
            gridParametros.DataSource = boParametro.ConsultaParametro();
            MontarGrid();
        }

        private void RbConsultar_CheckedChanged(object sender, EventArgs e)
        {
            Alteracao = false;
            BoParametro boParametro = new BoParametro();
            HabilitarCampos(false);
            LimparCampos();
            gridParametros.DataSource = boParametro.ConsultaParametro();
            MontarGrid();
        }

        private void gridParametros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            
            if (e.ColumnIndex == 8 || e.ColumnIndex == 0)
            {
                //LimparCampos();
                var parametro = new Parametro();
                string Parametro = gridParametros.Rows[e.RowIndex].Cells["Parametros"].FormattedValue.ToString();
                string Sistema = gridParametros.Rows[e.RowIndex].Cells["Sistema"].FormattedValue.ToString();
                string Categoria = gridParametros.Rows[e.RowIndex].Cells["Categoria"].FormattedValue.ToString();
                parametro = BoParametro.ObterParametro(Sistema, Parametro, parametro.ConverterTipoCategoria(Categoria));

                txtSistema.Text = parametro.Sistema;
                txtCategoria.Text = parametro.ConverterTipoCategoria(parametro.Categoria);
                txtParametro.Text = parametro.Parametros;
                txtUsuario.Text = parametro.Usuario;
                txtDataAtualizacao.Text = parametro.DataAtualizacao.ToString();
                txtDescricao.Text = parametro.Descricao;
                txtConteudo.Text = parametro.Conteudo;

                if (RBAlterar.Checked == true)
                    HabilitarCampos(true);
                else
                    HabilitarCampos(false);
            }

        }

        #endregion

        #region Metodos


        public Parametro ConverterFormToDML()
        {
            var DmlParametro = new Parametro();



            if (!string.IsNullOrEmpty(txtParametro.Text))
                DmlParametro.Parametros = Convert.ToString(txtParametro.Text);
            else
                BoErro.DesErro(BoErro.CERRO_CAMPOOBRIGATORIO, lblParametro.Text);

            if (!string.IsNullOrEmpty(txtConteudo.Text))
                DmlParametro.Conteudo = Convert.ToString(txtConteudo.Text);
            else
                BoErro.DesErro(BoErro.CERRO_CAMPOOBRIGATORIO, lblDescricao.Text);


            DmlParametro.Sistema = "GI";
            DmlParametro.Categoria = DmlParametro.ConverterTipoCategoria(txtCategoria.Text);
            DmlParametro.Descricao = txtDescricao.Text;
            DmlParametro.Usuario = "SUPERVISOR";
            DmlParametro.DataAtualizacao = DateTime.Now.Date;

            return DmlParametro;
        }

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
            txtSistema.Enabled = false;
            txtCategoria.Enabled = false;
            txtParametro.Enabled = pHabilitar;
            txtUsuario.Enabled = false;
            txtDataAtualizacao.Enabled = false;
            txtConteudo.Enabled = pHabilitar;
            buttonGravar.Visible = false;
            buttonGravar.Enabled = false;
            btnPesquisa.Enabled = false;
            txtDescricao.Enabled = false;
            TxtPesquisa.Enabled = false;
            RbNome.Enabled = false;
            RbCodigo.Enabled = true;
            lblDtAlt.Visible = true;
            lblUsu.Visible = true;
            txtUsuario.Visible = true;
            txtDataAtualizacao.Visible = true;

            if (RBAlterar.Checked == true)
            {
                buttonGravar.Visible = true;
                buttonGravar.Enabled = true;
            }

            if (RbConsultar.Checked == true || RBAlterar.Checked == true)
            {
                TxtPesquisa.Enabled = true;
                RbNome.Enabled = true;
                RbCodigo.Enabled = true;
                btnPesquisa.Enabled = true;
            }

        }

        /// <summary>
        /// 
        /// </summary>
        private void LimparCampos()
        {
            txtSistema.Text = string.Empty;
            txtCategoria.Text = string.Empty;
            txtParametro.Text = string.Empty;
            txtUsuario.Text = string.Empty;
            txtDataAtualizacao.Text = string.Empty;
            txtDescricao.Text = string.Empty;
            txtConteudo.Text = string.Empty;
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

            if (!gridParametros.Columns.Contains(BtnEdit.Name = "BtnEdit"))
            {
                gridParametros.Columns.Add(BtnEdit);
            }


            gridParametros.Columns["Sistema"].HeaderText = "Sistema";
            gridParametros.Columns["Sistema"].Width = 50;
            gridParametros.Columns["Sistema"].DisplayIndex = 0;


            gridParametros.Columns["Categoria"].HeaderText = "Categoria";
            gridParametros.Columns["Categoria"].Width = 80;
            gridParametros.Columns["Categoria"].DisplayIndex = 1;


            gridParametros.Columns["Parametros"].HeaderText = "Parametro";
            gridParametros.Columns["Parametros"].Width = 100;
            gridParametros.Columns["Parametros"].DisplayIndex = 2;

            gridParametros.Columns["Conteudo"].HeaderText = "Conteudo";
            gridParametros.Columns["Conteudo"].Width = 130;
            gridParametros.Columns["Conteudo"].DisplayIndex = 3;

            gridParametros.Columns["Descricao"].HeaderText = "Descrição";
            gridParametros.Columns["Descricao"].Width = 130;
            gridParametros.Columns["Descricao"].DisplayIndex = 4;

            gridParametros.Columns["DataAtualizacao"].HeaderText = "Data Atualizacao";
            gridParametros.Columns["DataAtualizacao"].Width = 80;
            gridParametros.Columns["DataAtualizacao"].DisplayIndex = 5;

            gridParametros.Columns["Usuario"].HeaderText = "Usuario";
            gridParametros.Columns["Usuario"].Width = 80;
            gridParametros.Columns["Usuario"].DisplayIndex = 6;

            gridParametros.Columns["BtnEdit"].DisplayIndex = 7;
            gridParametros.Columns["BtnEdit"].HeaderText = "Alt.";

            gridParametros.Columns["ConteudoDefault"].Visible = false;


        }

        #endregion


    }
}
