namespace GestorImoveis.Forms
{
    partial class BoletosForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridBoletos = new System.Windows.Forms.DataGridView();
            this.RbConsultar = new System.Windows.Forms.RadioButton();
            this.RBAlterar = new System.Windows.Forms.RadioButton();
            this.cboContratos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblVlrAluguel = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtLocador = new System.Windows.Forms.TextBox();
            this.txtLocatario = new System.Windows.Forms.TextBox();
            this.lblVlrComissao = new System.Windows.Forms.Label();
            this.txtPorcComissao = new System.Windows.Forms.TextBox();
            this.txtPorcMulta = new System.Windows.Forms.TextBox();
            this.lblVlrMulta = new System.Windows.Forms.Label();
            this.txtNumBol = new System.Windows.Forms.TextBox();
            this.lblNumBol = new System.Windows.Forms.Label();
            this.lblVlrDesconto = new System.Windows.Forms.Label();
            this.txtPorcDesconto = new System.Windows.Forms.TextBox();
            this.lblVlrIptu = new System.Windows.Forms.Label();
            this.lblDtVcto = new System.Windows.Forms.Label();
            this.lblDtPag = new System.Windows.Forms.Label();
            this.cboPago = new System.Windows.Forms.ComboBox();
            this.lblPorcCom = new System.Windows.Forms.Label();
            this.lblPorcMulta = new System.Windows.Forms.Label();
            this.lblLocador = new System.Windows.Forms.Label();
            this.lblLocatario = new System.Windows.Forms.Label();
            this.lblPorcDesconto = new System.Windows.Forms.Label();
            this.lblPago = new System.Windows.Forms.Label();
            this.buttonGravar = new System.Windows.Forms.Button();
            this.lblMsgErro = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lblEnd = new System.Windows.Forms.Label();
            this.txtDataVencimento = new System.Windows.Forms.MaskedTextBox();
            this.txtDataPag = new System.Windows.Forms.MaskedTextBox();
            this.btnFechar = new System.Windows.Forms.PictureBox();
            this.txtVlrAluguel = new System.Windows.Forms.TextBox();
            this.txtVlrIptu = new System.Windows.Forms.TextBox();
            this.txtVlrComissao = new System.Windows.Forms.TextBox();
            this.txtVlrMulta = new System.Windows.Forms.TextBox();
            this.txtVlrDesconto = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridBoletos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).BeginInit();
            this.SuspendLayout();
            // 
            // gridBoletos
            // 
            this.gridBoletos.AllowUserToAddRows = false;
            this.gridBoletos.AllowUserToDeleteRows = false;
            this.gridBoletos.AllowUserToResizeColumns = false;
            this.gridBoletos.AllowUserToResizeRows = false;
            this.gridBoletos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gridBoletos.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.gridBoletos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.BlueViolet;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridBoletos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridBoletos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.BlueViolet;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridBoletos.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridBoletos.EnableHeadersVisualStyles = false;
            this.gridBoletos.GridColor = System.Drawing.Color.Black;
            this.gridBoletos.Location = new System.Drawing.Point(51, 271);
            this.gridBoletos.Name = "gridBoletos";
            this.gridBoletos.ReadOnly = true;
            this.gridBoletos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.BlueViolet;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridBoletos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridBoletos.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.gridBoletos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gridBoletos.Size = new System.Drawing.Size(781, 175);
            this.gridBoletos.TabIndex = 1;
            this.gridBoletos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridBoletos_CellContentClick);
            // 
            // RbConsultar
            // 
            this.RbConsultar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RbConsultar.AutoSize = true;
            this.RbConsultar.Location = new System.Drawing.Point(461, 46);
            this.RbConsultar.Name = "RbConsultar";
            this.RbConsultar.Size = new System.Drawing.Size(66, 17);
            this.RbConsultar.TabIndex = 37;
            this.RbConsultar.TabStop = true;
            this.RbConsultar.Text = "Consulta";
            this.RbConsultar.UseVisualStyleBackColor = true;
            // 
            // RBAlterar
            // 
            this.RBAlterar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RBAlterar.AutoSize = true;
            this.RBAlterar.Location = new System.Drawing.Point(372, 46);
            this.RBAlterar.Name = "RBAlterar";
            this.RBAlterar.Size = new System.Drawing.Size(55, 17);
            this.RBAlterar.TabIndex = 36;
            this.RBAlterar.TabStop = true;
            this.RBAlterar.Text = "Alterar";
            this.RBAlterar.UseVisualStyleBackColor = true;
            this.RBAlterar.CheckedChanged += new System.EventHandler(this.RBAlterar_CheckedChanged_1);
            // 
            // cboContratos
            // 
            this.cboContratos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboContratos.FormattingEnabled = true;
            this.cboContratos.Location = new System.Drawing.Point(12, 27);
            this.cboContratos.Name = "cboContratos";
            this.cboContratos.Size = new System.Drawing.Size(167, 21);
            this.cboContratos.TabIndex = 38;
            this.cboContratos.SelectedIndexChanged += new System.EventHandler(this.cboContratos_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Selecionar Contrato:";
            // 
            // lblVlrAluguel
            // 
            this.lblVlrAluguel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblVlrAluguel.AutoSize = true;
            this.lblVlrAluguel.Location = new System.Drawing.Point(563, 85);
            this.lblVlrAluguel.Name = "lblVlrAluguel";
            this.lblVlrAluguel.Size = new System.Drawing.Size(87, 13);
            this.lblVlrAluguel.TabIndex = 87;
            this.lblVlrAluguel.Text = "Valor do Aluguel:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(47, 85);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 86;
            this.lblCodigo.Text = "Codigo:";
            // 
            // txtId
            // 
            this.txtId.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(50, 101);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(40, 20);
            this.txtId.TabIndex = 85;
            // 
            // txtLocador
            // 
            this.txtLocador.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtLocador.Location = new System.Drawing.Point(133, 101);
            this.txtLocador.Name = "txtLocador";
            this.txtLocador.Size = new System.Drawing.Size(209, 20);
            this.txtLocador.TabIndex = 89;
            // 
            // txtLocatario
            // 
            this.txtLocatario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtLocatario.Location = new System.Drawing.Point(348, 101);
            this.txtLocatario.Name = "txtLocatario";
            this.txtLocatario.Size = new System.Drawing.Size(209, 20);
            this.txtLocatario.TabIndex = 90;
            // 
            // lblVlrComissao
            // 
            this.lblVlrComissao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblVlrComissao.AutoSize = true;
            this.lblVlrComissao.Location = new System.Drawing.Point(87, 135);
            this.lblVlrComissao.Name = "lblVlrComissao";
            this.lblVlrComissao.Size = new System.Drawing.Size(82, 13);
            this.lblVlrComissao.TabIndex = 91;
            this.lblVlrComissao.Text = "Valor Comissão:";
            // 
            // txtPorcComissao
            // 
            this.txtPorcComissao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPorcComissao.Location = new System.Drawing.Point(51, 151);
            this.txtPorcComissao.Name = "txtPorcComissao";
            this.txtPorcComissao.Size = new System.Drawing.Size(27, 20);
            this.txtPorcComissao.TabIndex = 93;
            this.txtPorcComissao.TextChanged += new System.EventHandler(this.txtPorcComissao_TextChanged);
            // 
            // txtPorcMulta
            // 
            this.txtPorcMulta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPorcMulta.Location = new System.Drawing.Point(238, 151);
            this.txtPorcMulta.Name = "txtPorcMulta";
            this.txtPorcMulta.Size = new System.Drawing.Size(27, 20);
            this.txtPorcMulta.TabIndex = 94;
            this.txtPorcMulta.TextChanged += new System.EventHandler(this.txtPorcMulta_TextChanged);
            // 
            // lblVlrMulta
            // 
            this.lblVlrMulta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblVlrMulta.AutoSize = true;
            this.lblVlrMulta.Location = new System.Drawing.Point(278, 135);
            this.lblVlrMulta.Name = "lblVlrMulta";
            this.lblVlrMulta.Size = new System.Drawing.Size(63, 13);
            this.lblVlrMulta.TabIndex = 95;
            this.lblVlrMulta.Text = "Valor Multa:";
            // 
            // txtNumBol
            // 
            this.txtNumBol.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNumBol.Enabled = false;
            this.txtNumBol.Location = new System.Drawing.Point(97, 101);
            this.txtNumBol.Name = "txtNumBol";
            this.txtNumBol.Size = new System.Drawing.Size(28, 20);
            this.txtNumBol.TabIndex = 97;
            // 
            // lblNumBol
            // 
            this.lblNumBol.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNumBol.AutoSize = true;
            this.lblNumBol.Location = new System.Drawing.Point(96, 85);
            this.lblNumBol.Name = "lblNumBol";
            this.lblNumBol.Size = new System.Drawing.Size(32, 13);
            this.lblNumBol.TabIndex = 98;
            this.lblNumBol.Text = "Num:";
            // 
            // lblVlrDesconto
            // 
            this.lblVlrDesconto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblVlrDesconto.AutoSize = true;
            this.lblVlrDesconto.Location = new System.Drawing.Point(467, 135);
            this.lblVlrDesconto.Name = "lblVlrDesconto";
            this.lblVlrDesconto.Size = new System.Drawing.Size(83, 13);
            this.lblVlrDesconto.TabIndex = 100;
            this.lblVlrDesconto.Text = "Valor Desconto:";
            // 
            // txtPorcDesconto
            // 
            this.txtPorcDesconto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPorcDesconto.Location = new System.Drawing.Point(431, 151);
            this.txtPorcDesconto.Name = "txtPorcDesconto";
            this.txtPorcDesconto.Size = new System.Drawing.Size(27, 20);
            this.txtPorcDesconto.TabIndex = 99;
            this.txtPorcDesconto.TextChanged += new System.EventHandler(this.txtPorcDesconto_TextChanged);
            // 
            // lblVlrIptu
            // 
            this.lblVlrIptu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblVlrIptu.AutoSize = true;
            this.lblVlrIptu.Location = new System.Drawing.Point(708, 85);
            this.lblVlrIptu.Name = "lblVlrIptu";
            this.lblVlrIptu.Size = new System.Drawing.Size(77, 13);
            this.lblVlrIptu.TabIndex = 102;
            this.lblVlrIptu.Text = "Valor do IPTU:";
            // 
            // lblDtVcto
            // 
            this.lblDtVcto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDtVcto.AutoSize = true;
            this.lblDtVcto.Location = new System.Drawing.Point(581, 135);
            this.lblDtVcto.Name = "lblDtVcto";
            this.lblDtVcto.Size = new System.Drawing.Size(92, 13);
            this.lblDtVcto.TabIndex = 105;
            this.lblDtVcto.Text = "Data Vencimento:";
            // 
            // lblDtPag
            // 
            this.lblDtPag.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDtPag.AutoSize = true;
            this.lblDtPag.Location = new System.Drawing.Point(695, 135);
            this.lblDtPag.Name = "lblDtPag";
            this.lblDtPag.Size = new System.Drawing.Size(90, 13);
            this.lblDtPag.TabIndex = 107;
            this.lblDtPag.Text = "Data Pagamento:";
            // 
            // cboPago
            // 
            this.cboPago.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboPago.FormattingEnabled = true;
            this.cboPago.Location = new System.Drawing.Point(512, 196);
            this.cboPago.Name = "cboPago";
            this.cboPago.Size = new System.Drawing.Size(30, 21);
            this.cboPago.TabIndex = 108;
            // 
            // lblPorcCom
            // 
            this.lblPorcCom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPorcCom.AutoSize = true;
            this.lblPorcCom.Location = new System.Drawing.Point(39, 135);
            this.lblPorcCom.Name = "lblPorcCom";
            this.lblPorcCom.Size = new System.Drawing.Size(42, 13);
            this.lblPorcCom.TabIndex = 109;
            this.lblPorcCom.Text = "% Com.";
            // 
            // lblPorcMulta
            // 
            this.lblPorcMulta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPorcMulta.AutoSize = true;
            this.lblPorcMulta.Location = new System.Drawing.Point(234, 135);
            this.lblPorcMulta.Name = "lblPorcMulta";
            this.lblPorcMulta.Size = new System.Drawing.Size(38, 13);
            this.lblPorcMulta.TabIndex = 110;
            this.lblPorcMulta.Text = "% Mul.";
            // 
            // lblLocador
            // 
            this.lblLocador.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblLocador.AutoSize = true;
            this.lblLocador.Location = new System.Drawing.Point(130, 85);
            this.lblLocador.Name = "lblLocador";
            this.lblLocador.Size = new System.Drawing.Size(46, 13);
            this.lblLocador.TabIndex = 111;
            this.lblLocador.Text = "Locador";
            // 
            // lblLocatario
            // 
            this.lblLocatario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblLocatario.AutoSize = true;
            this.lblLocatario.Location = new System.Drawing.Point(345, 85);
            this.lblLocatario.Name = "lblLocatario";
            this.lblLocatario.Size = new System.Drawing.Size(51, 13);
            this.lblLocatario.TabIndex = 112;
            this.lblLocatario.Text = "Locatario";
            // 
            // lblPorcDesconto
            // 
            this.lblPorcDesconto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPorcDesconto.AutoSize = true;
            this.lblPorcDesconto.Location = new System.Drawing.Point(424, 135);
            this.lblPorcDesconto.Name = "lblPorcDesconto";
            this.lblPorcDesconto.Size = new System.Drawing.Size(40, 13);
            this.lblPorcDesconto.TabIndex = 113;
            this.lblPorcDesconto.Text = "% Des.";
            // 
            // lblPago
            // 
            this.lblPago.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPago.AutoSize = true;
            this.lblPago.Location = new System.Drawing.Point(502, 180);
            this.lblPago.Name = "lblPago";
            this.lblPago.Size = new System.Drawing.Size(55, 13);
            this.lblPago.TabIndex = 114;
            this.lblPago.Text = "Pago S/N";
            // 
            // buttonGravar
            // 
            this.buttonGravar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonGravar.BackColor = System.Drawing.Color.SlateBlue;
            this.buttonGravar.FlatAppearance.BorderColor = System.Drawing.Color.SlateBlue;
            this.buttonGravar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.buttonGravar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.buttonGravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGravar.ForeColor = System.Drawing.Color.White;
            this.buttonGravar.Location = new System.Drawing.Point(367, 459);
            this.buttonGravar.Name = "buttonGravar";
            this.buttonGravar.Size = new System.Drawing.Size(201, 23);
            this.buttonGravar.TabIndex = 115;
            this.buttonGravar.Text = "Gravar";
            this.buttonGravar.UseVisualStyleBackColor = false;
            this.buttonGravar.Click += new System.EventHandler(this.buttonGravar_Click);
            // 
            // lblMsgErro
            // 
            this.lblMsgErro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMsgErro.AutoSize = true;
            this.lblMsgErro.ForeColor = System.Drawing.Color.Red;
            this.lblMsgErro.Location = new System.Drawing.Point(369, 249);
            this.lblMsgErro.Name = "lblMsgErro";
            this.lblMsgErro.Size = new System.Drawing.Size(143, 13);
            this.lblMsgErro.TabIndex = 116;
            this.lblMsgErro.Text = "Mensagem de Erro ou Aviso!";
            this.lblMsgErro.Visible = false;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEndereco.Location = new System.Drawing.Point(51, 197);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(436, 20);
            this.txtEndereco.TabIndex = 117;
            // 
            // lblEnd
            // 
            this.lblEnd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(48, 182);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(56, 13);
            this.lblEnd.TabIndex = 118;
            this.lblEnd.Text = "Endereço:";
            // 
            // txtDataVencimento
            // 
            this.txtDataVencimento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDataVencimento.Location = new System.Drawing.Point(584, 151);
            this.txtDataVencimento.Mask = "00/00/0000";
            this.txtDataVencimento.Name = "txtDataVencimento";
            this.txtDataVencimento.Size = new System.Drawing.Size(89, 20);
            this.txtDataVencimento.TabIndex = 119;
            this.txtDataVencimento.ValidatingType = typeof(System.DateTime);
            // 
            // txtDataPag
            // 
            this.txtDataPag.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDataPag.Location = new System.Drawing.Point(698, 151);
            this.txtDataPag.Mask = "00/00/0000";
            this.txtDataPag.Name = "txtDataPag";
            this.txtDataPag.Size = new System.Drawing.Size(89, 20);
            this.txtDataPag.TabIndex = 121;
            this.txtDataPag.ValidatingType = typeof(System.DateTime);
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.Image = global::GestorImoveis.Properties.Resources.Close;
            this.btnFechar.Location = new System.Drawing.Point(867, 5);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(18, 18);
            this.btnFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnFechar.TabIndex = 84;
            this.btnFechar.TabStop = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // txtVlrAluguel
            // 
            this.txtVlrAluguel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtVlrAluguel.Location = new System.Drawing.Point(566, 101);
            this.txtVlrAluguel.Name = "txtVlrAluguel";
            this.txtVlrAluguel.Size = new System.Drawing.Size(136, 20);
            this.txtVlrAluguel.TabIndex = 122;
            this.txtVlrAluguel.TextChanged += new System.EventHandler(this.txtVlrAluguel_TextChanged);
            // 
            // txtVlrIptu
            // 
            this.txtVlrIptu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtVlrIptu.Location = new System.Drawing.Point(711, 101);
            this.txtVlrIptu.Name = "txtVlrIptu";
            this.txtVlrIptu.Size = new System.Drawing.Size(121, 20);
            this.txtVlrIptu.TabIndex = 123;
            // 
            // txtVlrComissao
            // 
            this.txtVlrComissao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtVlrComissao.Location = new System.Drawing.Point(90, 151);
            this.txtVlrComissao.Name = "txtVlrComissao";
            this.txtVlrComissao.Size = new System.Drawing.Size(133, 20);
            this.txtVlrComissao.TabIndex = 124;
            // 
            // txtVlrMulta
            // 
            this.txtVlrMulta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtVlrMulta.Location = new System.Drawing.Point(281, 151);
            this.txtVlrMulta.Name = "txtVlrMulta";
            this.txtVlrMulta.Size = new System.Drawing.Size(140, 20);
            this.txtVlrMulta.TabIndex = 125;
            // 
            // txtVlrDesconto
            // 
            this.txtVlrDesconto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtVlrDesconto.Location = new System.Drawing.Point(470, 151);
            this.txtVlrDesconto.Name = "txtVlrDesconto";
            this.txtVlrDesconto.Size = new System.Drawing.Size(100, 20);
            this.txtVlrDesconto.TabIndex = 126;
            // 
            // BoletosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(892, 499);
            this.Controls.Add(this.txtVlrDesconto);
            this.Controls.Add(this.txtVlrMulta);
            this.Controls.Add(this.txtVlrComissao);
            this.Controls.Add(this.txtVlrIptu);
            this.Controls.Add(this.txtVlrAluguel);
            this.Controls.Add(this.txtDataPag);
            this.Controls.Add(this.txtDataVencimento);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.lblMsgErro);
            this.Controls.Add(this.buttonGravar);
            this.Controls.Add(this.lblPago);
            this.Controls.Add(this.lblPorcDesconto);
            this.Controls.Add(this.lblLocatario);
            this.Controls.Add(this.lblLocador);
            this.Controls.Add(this.lblPorcMulta);
            this.Controls.Add(this.lblPorcCom);
            this.Controls.Add(this.cboPago);
            this.Controls.Add(this.lblDtPag);
            this.Controls.Add(this.lblDtVcto);
            this.Controls.Add(this.lblVlrIptu);
            this.Controls.Add(this.lblVlrDesconto);
            this.Controls.Add(this.txtPorcDesconto);
            this.Controls.Add(this.lblNumBol);
            this.Controls.Add(this.txtNumBol);
            this.Controls.Add(this.lblVlrMulta);
            this.Controls.Add(this.txtPorcMulta);
            this.Controls.Add(this.txtPorcComissao);
            this.Controls.Add(this.lblVlrComissao);
            this.Controls.Add(this.txtLocatario);
            this.Controls.Add(this.txtLocador);
            this.Controls.Add(this.lblVlrAluguel);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboContratos);
            this.Controls.Add(this.RbConsultar);
            this.Controls.Add(this.RBAlterar);
            this.Controls.Add(this.gridBoletos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BoletosForm";
            this.ShowInTaskbar = false;
            this.Text = "Boletos";
            ((System.ComponentModel.ISupportInitialize)(this.gridBoletos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridBoletos;
        private System.Windows.Forms.RadioButton RbConsultar;
        private System.Windows.Forms.RadioButton RBAlterar;
        private System.Windows.Forms.ComboBox cboContratos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnFechar;
        private System.Windows.Forms.Label lblVlrAluguel;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtLocador;
        private System.Windows.Forms.TextBox txtLocatario;
        private System.Windows.Forms.Label lblVlrComissao;
        private System.Windows.Forms.TextBox txtPorcComissao;
        private System.Windows.Forms.TextBox txtPorcMulta;
        private System.Windows.Forms.Label lblVlrMulta;
        private System.Windows.Forms.TextBox txtNumBol;
        private System.Windows.Forms.Label lblNumBol;
        private System.Windows.Forms.Label lblVlrDesconto;
        private System.Windows.Forms.TextBox txtPorcDesconto;
        private System.Windows.Forms.Label lblVlrIptu;
        private System.Windows.Forms.Label lblDtVcto;
        private System.Windows.Forms.Label lblDtPag;
        private System.Windows.Forms.ComboBox cboPago;
        private System.Windows.Forms.Label lblPorcCom;
        private System.Windows.Forms.Label lblPorcMulta;
        private System.Windows.Forms.Label lblLocador;
        private System.Windows.Forms.Label lblLocatario;
        private System.Windows.Forms.Label lblPorcDesconto;
        private System.Windows.Forms.Label lblPago;
        private System.Windows.Forms.Button buttonGravar;
        private System.Windows.Forms.Label lblMsgErro;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.MaskedTextBox txtDataVencimento;
        private System.Windows.Forms.MaskedTextBox txtDataPag;
        private System.Windows.Forms.TextBox txtVlrAluguel;
        private System.Windows.Forms.TextBox txtVlrIptu;
        private System.Windows.Forms.TextBox txtVlrComissao;
        private System.Windows.Forms.TextBox txtVlrMulta;
        private System.Windows.Forms.TextBox txtVlrDesconto;
    }
}