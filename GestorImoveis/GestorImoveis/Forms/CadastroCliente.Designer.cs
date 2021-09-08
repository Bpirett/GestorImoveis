namespace GestorImoveis.Forms
{
    partial class CadastroCliente
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.cboTipoCliente = new System.Windows.Forms.ComboBox();
            this.RadioCriar = new System.Windows.Forms.RadioButton();
            this.RBAlterar = new System.Windows.Forms.RadioButton();
            this.RbConsultar = new System.Windows.Forms.RadioButton();
            this.buttonGravar = new System.Windows.Forms.Button();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblCelular = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTpCliente = new System.Windows.Forms.Label();
            this.cboAtivoCli = new System.Windows.Forms.ComboBox();
            this.lblAtivo = new System.Windows.Forms.Label();
            this.txtCelula = new System.Windows.Forms.MaskedTextBox();
            this.txtNumeroFixo = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnPesquisa = new System.Windows.Forms.PictureBox();
            this.RbCPF = new System.Windows.Forms.RadioButton();
            this.RbNome = new System.Windows.Forms.RadioButton();
            this.RbCodigo = new System.Windows.Forms.RadioButton();
            this.TxtPesquisa = new System.Windows.Forms.TextBox();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.lblMsgErro = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.PictureBox();
            this.gridCliente = new System.Windows.Forms.DataGridView();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.txtComplemento2 = new System.Windows.Forms.TextBox();
            this.lblComplemento2 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.txtUF = new System.Windows.Forms.TextBox();
            this.lblUF = new System.Windows.Forms.Label();
            this.txtNumeroImovel = new System.Windows.Forms.TextBox();
            this.lblNumeroImovel = new System.Windows.Forms.Label();
            this.txtCEP = new System.Windows.Forms.TextBox();
            this.lblEnd = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lblCEP = new System.Windows.Forms.Label();
            this.ckNaoInfEnd = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnPesquisa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNome.Location = new System.Drawing.Point(165, 108);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(410, 20);
            this.txtNome.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEmail.Location = new System.Drawing.Point(274, 233);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(277, 20);
            this.txtEmail.TabIndex = 5;
            // 
            // txtId
            // 
            this.txtId.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(89, 108);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(71, 20);
            this.txtId.TabIndex = 6;
            // 
            // cboTipoCliente
            // 
            this.cboTipoCliente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboTipoCliente.FormattingEnabled = true;
            this.cboTipoCliente.Location = new System.Drawing.Point(559, 231);
            this.cboTipoCliente.Name = "cboTipoCliente";
            this.cboTipoCliente.Size = new System.Drawing.Size(126, 21);
            this.cboTipoCliente.TabIndex = 7;
            // 
            // RadioCriar
            // 
            this.RadioCriar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RadioCriar.AutoSize = true;
            this.RadioCriar.Location = new System.Drawing.Point(281, 39);
            this.RadioCriar.Name = "RadioCriar";
            this.RadioCriar.Size = new System.Drawing.Size(46, 17);
            this.RadioCriar.TabIndex = 8;
            this.RadioCriar.TabStop = true;
            this.RadioCriar.Text = "Criar";
            this.RadioCriar.UseVisualStyleBackColor = true;
            this.RadioCriar.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // RBAlterar
            // 
            this.RBAlterar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RBAlterar.AutoSize = true;
            this.RBAlterar.Location = new System.Drawing.Point(384, 39);
            this.RBAlterar.Name = "RBAlterar";
            this.RBAlterar.Size = new System.Drawing.Size(55, 17);
            this.RBAlterar.TabIndex = 9;
            this.RBAlterar.TabStop = true;
            this.RBAlterar.Text = "Alterar";
            this.RBAlterar.UseVisualStyleBackColor = true;
            this.RBAlterar.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // RbConsultar
            // 
            this.RbConsultar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RbConsultar.AutoSize = true;
            this.RbConsultar.Location = new System.Drawing.Point(487, 39);
            this.RbConsultar.Name = "RbConsultar";
            this.RbConsultar.Size = new System.Drawing.Size(66, 17);
            this.RbConsultar.TabIndex = 10;
            this.RbConsultar.TabStop = true;
            this.RbConsultar.Text = "Consulta";
            this.RbConsultar.UseVisualStyleBackColor = true;
            this.RbConsultar.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // buttonGravar
            // 
            this.buttonGravar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonGravar.BackColor = System.Drawing.Color.SlateBlue;
            this.buttonGravar.FlatAppearance.BorderColor = System.Drawing.Color.SlateBlue;
            this.buttonGravar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.buttonGravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGravar.ForeColor = System.Drawing.Color.White;
            this.buttonGravar.Location = new System.Drawing.Point(355, 464);
            this.buttonGravar.Name = "buttonGravar";
            this.buttonGravar.Size = new System.Drawing.Size(204, 23);
            this.buttonGravar.TabIndex = 11;
            this.buttonGravar.Text = "Gravar";
            this.buttonGravar.UseVisualStyleBackColor = false;
            this.buttonGravar.Click += new System.EventHandler(this.buttonGravar_Click);
            // 
            // lblCodigo
            // 
            this.lblCodigo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(86, 95);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 14;
            this.lblCodigo.Text = "Codigo:";
            // 
            // lblNome
            // 
            this.lblNome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(162, 94);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 15;
            this.lblNome.Text = "Nome:";
            // 
            // lblCPF
            // 
            this.lblCPF.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(579, 94);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(30, 13);
            this.lblCPF.TabIndex = 16;
            this.lblCPF.Text = "CPF:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(86, 218);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(74, 13);
            this.lblTelefone.TabIndex = 17;
            this.lblTelefone.Text = "Telefone Fixo:";
            // 
            // lblCelular
            // 
            this.lblCelular.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCelular.AutoSize = true;
            this.lblCelular.Location = new System.Drawing.Point(177, 218);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(42, 13);
            this.lblCelular.TabIndex = 18;
            this.lblCelular.Text = "Celular:";
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(271, 218);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(38, 13);
            this.lblEmail.TabIndex = 19;
            this.lblEmail.Text = "E-mail:";
            // 
            // lblTpCliente
            // 
            this.lblTpCliente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTpCliente.AutoSize = true;
            this.lblTpCliente.Location = new System.Drawing.Point(556, 218);
            this.lblTpCliente.Name = "lblTpCliente";
            this.lblTpCliente.Size = new System.Drawing.Size(66, 13);
            this.lblTpCliente.TabIndex = 20;
            this.lblTpCliente.Text = "Tipo Cliente:";
            // 
            // cboAtivoCli
            // 
            this.cboAtivoCli.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboAtivoCli.FormattingEnabled = true;
            this.cboAtivoCli.Location = new System.Drawing.Point(691, 231);
            this.cboAtivoCli.Name = "cboAtivoCli";
            this.cboAtivoCli.Size = new System.Drawing.Size(104, 21);
            this.cboAtivoCli.TabIndex = 21;
            // 
            // lblAtivo
            // 
            this.lblAtivo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAtivo.AutoSize = true;
            this.lblAtivo.Location = new System.Drawing.Point(688, 218);
            this.lblAtivo.Name = "lblAtivo";
            this.lblAtivo.Size = new System.Drawing.Size(34, 13);
            this.lblAtivo.TabIndex = 22;
            this.lblAtivo.Text = "Ativo:";
            // 
            // txtCelula
            // 
            this.txtCelula.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCelula.Location = new System.Drawing.Point(180, 233);
            this.txtCelula.Mask = "(99) 90000-0000";
            this.txtCelula.Name = "txtCelula";
            this.txtCelula.Size = new System.Drawing.Size(86, 20);
            this.txtCelula.TabIndex = 23;
            // 
            // txtNumeroFixo
            // 
            this.txtNumeroFixo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNumeroFixo.Location = new System.Drawing.Point(89, 232);
            this.txtNumeroFixo.Mask = "(99) 0000-0000";
            this.txtNumeroFixo.Name = "txtNumeroFixo";
            this.txtNumeroFixo.Size = new System.Drawing.Size(82, 20);
            this.txtNumeroFixo.TabIndex = 24;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.BtnPesquisa);
            this.groupBox1.Controls.Add(this.RbCPF);
            this.groupBox1.Controls.Add(this.RbNome);
            this.groupBox1.Controls.Add(this.RbCodigo);
            this.groupBox1.Controls.Add(this.TxtPesquisa);
            this.groupBox1.Location = new System.Drawing.Point(604, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 65);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisa";
            // 
            // BtnPesquisa
            // 
            this.BtnPesquisa.BackColor = System.Drawing.Color.White;
            this.BtnPesquisa.Image = global::GestorImoveis.Properties.Resources.search_Icon_16px;
            this.BtnPesquisa.Location = new System.Drawing.Point(220, 37);
            this.BtnPesquisa.Name = "BtnPesquisa";
            this.BtnPesquisa.Size = new System.Drawing.Size(16, 16);
            this.BtnPesquisa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.BtnPesquisa.TabIndex = 83;
            this.BtnPesquisa.TabStop = false;
            this.BtnPesquisa.Click += new System.EventHandler(this.BtnPesquisa_Click);
            // 
            // RbCPF
            // 
            this.RbCPF.AutoSize = true;
            this.RbCPF.Location = new System.Drawing.Point(191, 14);
            this.RbCPF.Name = "RbCPF";
            this.RbCPF.Size = new System.Drawing.Size(45, 17);
            this.RbCPF.TabIndex = 30;
            this.RbCPF.TabStop = true;
            this.RbCPF.Text = "CPF";
            this.RbCPF.UseVisualStyleBackColor = true;
            // 
            // RbNome
            // 
            this.RbNome.AutoSize = true;
            this.RbNome.Location = new System.Drawing.Point(100, 14);
            this.RbNome.Name = "RbNome";
            this.RbNome.Size = new System.Drawing.Size(53, 17);
            this.RbNome.TabIndex = 29;
            this.RbNome.TabStop = true;
            this.RbNome.Text = "Nome";
            this.RbNome.UseVisualStyleBackColor = true;
            // 
            // RbCodigo
            // 
            this.RbCodigo.AutoSize = true;
            this.RbCodigo.Location = new System.Drawing.Point(9, 14);
            this.RbCodigo.Name = "RbCodigo";
            this.RbCodigo.Size = new System.Drawing.Size(58, 17);
            this.RbCodigo.TabIndex = 28;
            this.RbCodigo.TabStop = true;
            this.RbCodigo.Text = "Codigo";
            this.RbCodigo.UseVisualStyleBackColor = true;
            // 
            // TxtPesquisa
            // 
            this.TxtPesquisa.Location = new System.Drawing.Point(9, 37);
            this.TxtPesquisa.Name = "TxtPesquisa";
            this.TxtPesquisa.Size = new System.Drawing.Size(205, 20);
            this.TxtPesquisa.TabIndex = 0;
            // 
            // txtCPF
            // 
            this.txtCPF.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCPF.Location = new System.Drawing.Point(582, 108);
            this.txtCPF.Mask = "000.000.000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(103, 20);
            this.txtCPF.TabIndex = 26;
            // 
            // lblMsgErro
            // 
            this.lblMsgErro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMsgErro.AutoSize = true;
            this.lblMsgErro.ForeColor = System.Drawing.Color.Red;
            this.lblMsgErro.Location = new System.Drawing.Point(394, 263);
            this.lblMsgErro.Name = "lblMsgErro";
            this.lblMsgErro.Size = new System.Drawing.Size(143, 13);
            this.lblMsgErro.TabIndex = 81;
            this.lblMsgErro.Text = "Mensagem de Erro ou Aviso!";
            this.lblMsgErro.Visible = false;
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.BackgroundImage = global::GestorImoveis.Properties.Resources.Close;
            this.btnFechar.Image = global::GestorImoveis.Properties.Resources.Close;
            this.btnFechar.Location = new System.Drawing.Point(875, -1);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(18, 18);
            this.btnFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnFechar.TabIndex = 82;
            this.btnFechar.TabStop = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // gridCliente
            // 
            this.gridCliente.AllowUserToAddRows = false;
            this.gridCliente.AllowUserToDeleteRows = false;
            this.gridCliente.AllowUserToResizeColumns = false;
            this.gridCliente.AllowUserToResizeRows = false;
            this.gridCliente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gridCliente.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.gridCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridCliente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.BlueViolet;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridCliente.ColumnHeadersHeight = 30;
            this.gridCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridCliente.EnableHeadersVisualStyles = false;
            this.gridCliente.GridColor = System.Drawing.Color.Black;
            this.gridCliente.Location = new System.Drawing.Point(52, 283);
            this.gridCliente.Name = "gridCliente";
            this.gridCliente.ReadOnly = true;
            this.gridCliente.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridCliente.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridCliente.RowHeadersVisible = false;
            this.gridCliente.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.gridCliente.Size = new System.Drawing.Size(795, 162);
            this.gridCliente.TabIndex = 83;
            this.gridCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCliente_CellContentClick_1);
            // 
            // txtCidade
            // 
            this.txtCidade.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCidade.Location = new System.Drawing.Point(89, 195);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(187, 20);
            this.txtCidade.TabIndex = 116;
            // 
            // lblCidade
            // 
            this.lblCidade.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(86, 180);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(43, 13);
            this.lblCidade.TabIndex = 115;
            this.lblCidade.Text = "Cidade:";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtComplemento.Location = new System.Drawing.Point(284, 196);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(187, 20);
            this.txtComplemento.TabIndex = 114;
            // 
            // txtComplemento2
            // 
            this.txtComplemento2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtComplemento2.Location = new System.Drawing.Point(481, 195);
            this.txtComplemento2.Name = "txtComplemento2";
            this.txtComplemento2.Size = new System.Drawing.Size(187, 20);
            this.txtComplemento2.TabIndex = 113;
            // 
            // lblComplemento2
            // 
            this.lblComplemento2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblComplemento2.AutoSize = true;
            this.lblComplemento2.Location = new System.Drawing.Point(478, 180);
            this.lblComplemento2.Name = "lblComplemento2";
            this.lblComplemento2.Size = new System.Drawing.Size(77, 13);
            this.lblComplemento2.TabIndex = 112;
            this.lblComplemento2.Text = "Complemeto 2:";
            // 
            // txtBairro
            // 
            this.txtBairro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBairro.Location = new System.Drawing.Point(634, 152);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(139, 20);
            this.txtBairro.TabIndex = 111;
            // 
            // lblBairro
            // 
            this.lblBairro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(631, 137);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(37, 13);
            this.lblBairro.TabIndex = 110;
            this.lblBairro.Text = "Bairro:";
            // 
            // lblComplemento
            // 
            this.lblComplemento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(281, 181);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(74, 13);
            this.lblComplemento.TabIndex = 109;
            this.lblComplemento.Text = "Complemento:";
            // 
            // txtUF
            // 
            this.txtUF.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtUF.Location = new System.Drawing.Point(779, 153);
            this.txtUF.Name = "txtUF";
            this.txtUF.Size = new System.Drawing.Size(33, 20);
            this.txtUF.TabIndex = 108;
            // 
            // lblUF
            // 
            this.lblUF.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblUF.AutoSize = true;
            this.lblUF.Location = new System.Drawing.Point(783, 140);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(24, 13);
            this.lblUF.TabIndex = 107;
            this.lblUF.Text = "UF:";
            // 
            // txtNumeroImovel
            // 
            this.txtNumeroImovel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNumeroImovel.Location = new System.Drawing.Point(581, 152);
            this.txtNumeroImovel.Name = "txtNumeroImovel";
            this.txtNumeroImovel.Size = new System.Drawing.Size(47, 20);
            this.txtNumeroImovel.TabIndex = 106;
            // 
            // lblNumeroImovel
            // 
            this.lblNumeroImovel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNumeroImovel.AutoSize = true;
            this.lblNumeroImovel.Location = new System.Drawing.Point(584, 138);
            this.lblNumeroImovel.Name = "lblNumeroImovel";
            this.lblNumeroImovel.Size = new System.Drawing.Size(19, 13);
            this.lblNumeroImovel.TabIndex = 105;
            this.lblNumeroImovel.Text = "N°";
            // 
            // txtCEP
            // 
            this.txtCEP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCEP.Location = new System.Drawing.Point(89, 152);
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(108, 20);
            this.txtCEP.TabIndex = 104;
            this.txtCEP.TextChanged += new System.EventHandler(this.txtCEP_TextChanged);
            // 
            // lblEnd
            // 
            this.lblEnd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(201, 137);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(56, 13);
            this.lblEnd.TabIndex = 103;
            this.lblEnd.Text = "Endereço:";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEndereco.Location = new System.Drawing.Point(203, 153);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(372, 20);
            this.txtEndereco.TabIndex = 102;
            // 
            // lblCEP
            // 
            this.lblCEP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCEP.AutoSize = true;
            this.lblCEP.Location = new System.Drawing.Point(90, 136);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(31, 13);
            this.lblCEP.TabIndex = 101;
            this.lblCEP.Text = "CEP:";
            // 
            // ckNaoInfEnd
            // 
            this.ckNaoInfEnd.AutoSize = true;
            this.ckNaoInfEnd.Location = new System.Drawing.Point(704, 110);
            this.ckNaoInfEnd.Name = "ckNaoInfEnd";
            this.ckNaoInfEnd.Size = new System.Drawing.Size(147, 17);
            this.ckNaoInfEnd.TabIndex = 117;
            this.ckNaoInfEnd.Text = "Não Informou o endereço";
            this.ckNaoInfEnd.UseVisualStyleBackColor = true;
            this.ckNaoInfEnd.CheckedChanged += new System.EventHandler(this.ckNaoInfEnd_CheckedChanged);
            // 
            // CadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(892, 499);
            this.Controls.Add(this.ckNaoInfEnd);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.txtComplemento);
            this.Controls.Add(this.txtComplemento2);
            this.Controls.Add(this.lblComplemento2);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.lblComplemento);
            this.Controls.Add(this.txtUF);
            this.Controls.Add(this.lblUF);
            this.Controls.Add(this.txtNumeroImovel);
            this.Controls.Add(this.lblNumeroImovel);
            this.Controls.Add(this.txtCEP);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.lblCEP);
            this.Controls.Add(this.gridCliente);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.lblMsgErro);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtNumeroFixo);
            this.Controls.Add(this.txtCelula);
            this.Controls.Add(this.lblAtivo);
            this.Controls.Add(this.cboAtivoCli);
            this.Controls.Add(this.lblTpCliente);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblCelular);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.buttonGravar);
            this.Controls.Add(this.RbConsultar);
            this.Controls.Add(this.RBAlterar);
            this.Controls.Add(this.RadioCriar);
            this.Controls.Add(this.cboTipoCliente);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CadastroCliente";
            this.Text = "CadastroCliente";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnPesquisa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.ComboBox cboTipoCliente;
        private System.Windows.Forms.RadioButton RadioCriar;
        private System.Windows.Forms.RadioButton RBAlterar;
        private System.Windows.Forms.RadioButton RbConsultar;
        private System.Windows.Forms.Button buttonGravar;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTpCliente;
        private System.Windows.Forms.ComboBox cboAtivoCli;
        private System.Windows.Forms.Label lblAtivo;
        private System.Windows.Forms.MaskedTextBox txtCelula;
        private System.Windows.Forms.MaskedTextBox txtNumeroFixo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RbCPF;
        private System.Windows.Forms.RadioButton RbNome;
        private System.Windows.Forms.RadioButton RbCodigo;
        private System.Windows.Forms.TextBox TxtPesquisa;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.Label lblMsgErro;
        private System.Windows.Forms.PictureBox btnFechar;
        private System.Windows.Forms.PictureBox BtnPesquisa;
        private System.Windows.Forms.DataGridView gridCliente;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.TextBox txtComplemento2;
        private System.Windows.Forms.Label lblComplemento2;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.TextBox txtUF;
        private System.Windows.Forms.Label lblUF;
        private System.Windows.Forms.TextBox txtNumeroImovel;
        private System.Windows.Forms.Label lblNumeroImovel;
        private System.Windows.Forms.TextBox txtCEP;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.CheckBox ckNaoInfEnd;
    }
}