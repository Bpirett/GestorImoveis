namespace GestorImoveis.Forms
{
    partial class CadastroContrato
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPesquisa = new System.Windows.Forms.PictureBox();
            this.RbNome = new System.Windows.Forms.RadioButton();
            this.RbCodigo = new System.Windows.Forms.RadioButton();
            this.TxtPesquisa = new System.Windows.Forms.TextBox();
            this.lblAtivo = new System.Windows.Forms.Label();
            this.cboSituacao = new System.Windows.Forms.ComboBox();
            this.lblTpImovel = new System.Windows.Forms.Label();
            this.buttonGravar = new System.Windows.Forms.Button();
            this.RbConsultar = new System.Windows.Forms.RadioButton();
            this.RBAlterar = new System.Windows.Forms.RadioButton();
            this.RadioCriar = new System.Windows.Forms.RadioButton();
            this.cboTipoImovel = new System.Windows.Forms.ComboBox();
            this.gridContratos = new System.Windows.Forms.DataGridView();
            this.cboLocador = new System.Windows.Forms.ComboBox();
            this.lblLocad = new System.Windows.Forms.Label();
            this.lblCodLocad = new System.Windows.Forms.Label();
            this.txtPesqcodLocador = new System.Windows.Forms.TextBox();
            this.cboLocatario = new System.Windows.Forms.ComboBox();
            this.lblLocat = new System.Windows.Forms.Label();
            this.lblCodLocat = new System.Windows.Forms.Label();
            this.txtPesqcodLocatario = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblCEP = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lblEnd = new System.Windows.Forms.Label();
            this.lblVlrAluguel = new System.Windows.Forms.Label();
            this.lblDiaPag = new System.Windows.Forms.Label();
            this.btnPesqLocador = new System.Windows.Forms.Button();
            this.btnPesqLocatario = new System.Windows.Forms.Button();
            this.lblVlrIptu = new System.Windows.Forms.Label();
            this.lblDtEntrada = new System.Windows.Forms.Label();
            this.txtDataEntrada = new System.Windows.Forms.MaskedTextBox();
            this.lblPrazo = new System.Windows.Forms.Label();
            this.lblDtSaida = new System.Windows.Forms.Label();
            this.txtDataSaida = new System.Windows.Forms.MaskedTextBox();
            this.txtMesesContrato = new System.Windows.Forms.NumericUpDown();
            this.lblMsgErro = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.PictureBox();
            this.txtVlrAluguel = new System.Windows.Forms.TextBox();
            this.txtIptu = new System.Windows.Forms.TextBox();
            this.txtCEP = new System.Windows.Forms.TextBox();
            this.lblNumeroImovel = new System.Windows.Forms.Label();
            this.txtNumeroImovel = new System.Windows.Forms.TextBox();
            this.txtUF = new System.Windows.Forms.TextBox();
            this.lblUF = new System.Windows.Forms.Label();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtComplemento2 = new System.Windows.Forms.TextBox();
            this.lblComplemento2 = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtDiaPag = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPesquisa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridContratos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMesesContrato)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.btnPesquisa);
            this.groupBox1.Controls.Add(this.RbNome);
            this.groupBox1.Controls.Add(this.RbCodigo);
            this.groupBox1.Controls.Add(this.TxtPesquisa);
            this.groupBox1.Location = new System.Drawing.Point(577, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 65);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisa";
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Image = global::GestorImoveis.Properties.Resources.search_Icon_16px;
            this.btnPesquisa.Location = new System.Drawing.Point(220, 38);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(16, 16);
            this.btnPesquisa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnPesquisa.TabIndex = 30;
            this.btnPesquisa.TabStop = false;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
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
            this.RbNome.CheckedChanged += new System.EventHandler(this.RbNome_CheckedChanged);
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
            this.RbCodigo.CheckedChanged += new System.EventHandler(this.RbCodigo_CheckedChanged);
            // 
            // TxtPesquisa
            // 
            this.TxtPesquisa.Location = new System.Drawing.Point(9, 38);
            this.TxtPesquisa.Name = "TxtPesquisa";
            this.TxtPesquisa.Size = new System.Drawing.Size(205, 20);
            this.TxtPesquisa.TabIndex = 0;
            this.TxtPesquisa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPesquisa_KeyPress);
            // 
            // lblAtivo
            // 
            this.lblAtivo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAtivo.AutoSize = true;
            this.lblAtivo.Location = new System.Drawing.Point(587, 160);
            this.lblAtivo.Name = "lblAtivo";
            this.lblAtivo.Size = new System.Drawing.Size(34, 13);
            this.lblAtivo.TabIndex = 45;
            this.lblAtivo.Text = "Ativo:";
            // 
            // cboSituacao
            // 
            this.cboSituacao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboSituacao.FormattingEnabled = true;
            this.cboSituacao.Location = new System.Drawing.Point(590, 173);
            this.cboSituacao.Name = "cboSituacao";
            this.cboSituacao.Size = new System.Drawing.Size(117, 21);
            this.cboSituacao.TabIndex = 44;
            // 
            // lblTpImovel
            // 
            this.lblTpImovel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTpImovel.AutoSize = true;
            this.lblTpImovel.Location = new System.Drawing.Point(587, 195);
            this.lblTpImovel.Name = "lblTpImovel";
            this.lblTpImovel.Size = new System.Drawing.Size(65, 13);
            this.lblTpImovel.TabIndex = 43;
            this.lblTpImovel.Text = "Tipo Imovel:";
            // 
            // buttonGravar
            // 
            this.buttonGravar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonGravar.BackColor = System.Drawing.Color.SlateBlue;
            this.buttonGravar.FlatAppearance.BorderColor = System.Drawing.Color.SlateBlue;
            this.buttonGravar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.buttonGravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGravar.ForeColor = System.Drawing.Color.White;
            this.buttonGravar.Location = new System.Drawing.Point(360, 467);
            this.buttonGravar.Name = "buttonGravar";
            this.buttonGravar.Size = new System.Drawing.Size(204, 23);
            this.buttonGravar.TabIndex = 35;
            this.buttonGravar.Text = "Gravar";
            this.buttonGravar.UseVisualStyleBackColor = false;
            this.buttonGravar.Click += new System.EventHandler(this.buttonGravar_Click);
            // 
            // RbConsultar
            // 
            this.RbConsultar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RbConsultar.AutoSize = true;
            this.RbConsultar.Location = new System.Drawing.Point(476, 30);
            this.RbConsultar.Name = "RbConsultar";
            this.RbConsultar.Size = new System.Drawing.Size(66, 17);
            this.RbConsultar.TabIndex = 34;
            this.RbConsultar.TabStop = true;
            this.RbConsultar.Text = "Consulta";
            this.RbConsultar.UseVisualStyleBackColor = true;
            this.RbConsultar.CheckedChanged += new System.EventHandler(this.RbConsultar_CheckedChanged);
            // 
            // RBAlterar
            // 
            this.RBAlterar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RBAlterar.AutoSize = true;
            this.RBAlterar.Location = new System.Drawing.Point(373, 30);
            this.RBAlterar.Name = "RBAlterar";
            this.RBAlterar.Size = new System.Drawing.Size(55, 17);
            this.RBAlterar.TabIndex = 33;
            this.RBAlterar.TabStop = true;
            this.RBAlterar.Text = "Alterar";
            this.RBAlterar.UseVisualStyleBackColor = true;
            this.RBAlterar.CheckedChanged += new System.EventHandler(this.RBAlterar_CheckedChanged);
            // 
            // RadioCriar
            // 
            this.RadioCriar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RadioCriar.AutoSize = true;
            this.RadioCriar.Location = new System.Drawing.Point(270, 30);
            this.RadioCriar.Name = "RadioCriar";
            this.RadioCriar.Size = new System.Drawing.Size(46, 17);
            this.RadioCriar.TabIndex = 32;
            this.RadioCriar.TabStop = true;
            this.RadioCriar.Text = "Criar";
            this.RadioCriar.UseVisualStyleBackColor = true;
            this.RadioCriar.CheckedChanged += new System.EventHandler(this.RadioCriar_CheckedChanged);
            // 
            // cboTipoImovel
            // 
            this.cboTipoImovel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboTipoImovel.FormattingEnabled = true;
            this.cboTipoImovel.Location = new System.Drawing.Point(593, 211);
            this.cboTipoImovel.Name = "cboTipoImovel";
            this.cboTipoImovel.Size = new System.Drawing.Size(198, 21);
            this.cboTipoImovel.TabIndex = 31;
            // 
            // gridContratos
            // 
            this.gridContratos.AllowUserToAddRows = false;
            this.gridContratos.AllowUserToDeleteRows = false;
            this.gridContratos.AllowUserToResizeColumns = false;
            this.gridContratos.AllowUserToResizeRows = false;
            this.gridContratos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gridContratos.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.gridContratos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridContratos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.BlueViolet;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridContratos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridContratos.ColumnHeadersHeight = 30;
            this.gridContratos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridContratos.EnableHeadersVisualStyles = false;
            this.gridContratos.GridColor = System.Drawing.Color.Black;
            this.gridContratos.Location = new System.Drawing.Point(75, 300);
            this.gridContratos.Name = "gridContratos";
            this.gridContratos.ReadOnly = true;
            this.gridContratos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridContratos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridContratos.RowHeadersVisible = false;
            this.gridContratos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.gridContratos.Size = new System.Drawing.Size(748, 155);
            this.gridContratos.TabIndex = 27;
            this.gridContratos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridContratos_CellContentClick);
            // 
            // cboLocador
            // 
            this.cboLocador.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboLocador.FormattingEnabled = true;
            this.cboLocador.Location = new System.Drawing.Point(194, 173);
            this.cboLocador.Name = "cboLocador";
            this.cboLocador.Size = new System.Drawing.Size(381, 21);
            this.cboLocador.TabIndex = 54;
            // 
            // lblLocad
            // 
            this.lblLocad.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblLocad.AutoSize = true;
            this.lblLocad.Location = new System.Drawing.Point(191, 160);
            this.lblLocad.Name = "lblLocad";
            this.lblLocad.Size = new System.Drawing.Size(46, 13);
            this.lblLocad.TabIndex = 53;
            this.lblLocad.Text = "Locador";
            // 
            // lblCodLocad
            // 
            this.lblCodLocad.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCodLocad.AutoSize = true;
            this.lblCodLocad.Location = new System.Drawing.Point(106, 160);
            this.lblCodLocad.Name = "lblCodLocad";
            this.lblCodLocad.Size = new System.Drawing.Size(43, 13);
            this.lblCodLocad.TabIndex = 52;
            this.lblCodLocad.Text = "Codigo:";
            // 
            // txtPesqcodLocador
            // 
            this.txtPesqcodLocador.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPesqcodLocador.Enabled = false;
            this.txtPesqcodLocador.Location = new System.Drawing.Point(109, 173);
            this.txtPesqcodLocador.Name = "txtPesqcodLocador";
            this.txtPesqcodLocador.Size = new System.Drawing.Size(71, 20);
            this.txtPesqcodLocador.TabIndex = 51;
            // 
            // cboLocatario
            // 
            this.cboLocatario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboLocatario.FormattingEnabled = true;
            this.cboLocatario.Location = new System.Drawing.Point(194, 210);
            this.cboLocatario.Name = "cboLocatario";
            this.cboLocatario.Size = new System.Drawing.Size(381, 21);
            this.cboLocatario.TabIndex = 58;
            // 
            // lblLocat
            // 
            this.lblLocat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblLocat.AutoSize = true;
            this.lblLocat.Location = new System.Drawing.Point(191, 195);
            this.lblLocat.Name = "lblLocat";
            this.lblLocat.Size = new System.Drawing.Size(51, 13);
            this.lblLocat.TabIndex = 57;
            this.lblLocat.Text = "Locatario";
            // 
            // lblCodLocat
            // 
            this.lblCodLocat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCodLocat.AutoSize = true;
            this.lblCodLocat.Location = new System.Drawing.Point(106, 197);
            this.lblCodLocat.Name = "lblCodLocat";
            this.lblCodLocat.Size = new System.Drawing.Size(43, 13);
            this.lblCodLocat.TabIndex = 56;
            this.lblCodLocat.Text = "Codigo:";
            // 
            // txtPesqcodLocatario
            // 
            this.txtPesqcodLocatario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPesqcodLocatario.Enabled = false;
            this.txtPesqcodLocatario.Location = new System.Drawing.Point(109, 211);
            this.txtPesqcodLocatario.Name = "txtPesqcodLocatario";
            this.txtPesqcodLocatario.Size = new System.Drawing.Size(71, 20);
            this.txtPesqcodLocatario.TabIndex = 55;
            // 
            // txtId
            // 
            this.txtId.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(78, 98);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(71, 20);
            this.txtId.TabIndex = 30;
            // 
            // lblCodigo
            // 
            this.lblCodigo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(75, 82);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 37;
            this.lblCodigo.Text = "Codigo:";
            // 
            // lblCEP
            // 
            this.lblCEP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCEP.AutoSize = true;
            this.lblCEP.Location = new System.Drawing.Point(156, 81);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(31, 13);
            this.lblCEP.TabIndex = 38;
            this.lblCEP.Text = "CEP:";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEndereco.Location = new System.Drawing.Point(269, 98);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(372, 20);
            this.txtEndereco.TabIndex = 60;
            // 
            // lblEnd
            // 
            this.lblEnd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(267, 82);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(105, 13);
            this.lblEnd.TabIndex = 61;
            this.lblEnd.Text = "Endereço do Imovel:";
            // 
            // lblVlrAluguel
            // 
            this.lblVlrAluguel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblVlrAluguel.AutoSize = true;
            this.lblVlrAluguel.Location = new System.Drawing.Point(75, 237);
            this.lblVlrAluguel.Name = "lblVlrAluguel";
            this.lblVlrAluguel.Size = new System.Drawing.Size(87, 13);
            this.lblVlrAluguel.TabIndex = 63;
            this.lblVlrAluguel.Text = "Valor do Aluguel:";
            // 
            // lblDiaPag
            // 
            this.lblDiaPag.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDiaPag.AutoSize = true;
            this.lblDiaPag.Location = new System.Drawing.Point(715, 160);
            this.lblDiaPag.Name = "lblDiaPag";
            this.lblDiaPag.Size = new System.Drawing.Size(98, 13);
            this.lblDiaPag.TabIndex = 64;
            this.lblDiaPag.Text = "Dia de Pagamento:";
            // 
            // btnPesqLocador
            // 
            this.btnPesqLocador.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPesqLocador.BackColor = System.Drawing.Color.White;
            this.btnPesqLocador.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPesqLocador.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet;
            this.btnPesqLocador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesqLocador.Image = global::GestorImoveis.Properties.Resources.search_Icon_16px;
            this.btnPesqLocador.Location = new System.Drawing.Point(78, 171);
            this.btnPesqLocador.Name = "btnPesqLocador";
            this.btnPesqLocador.Size = new System.Drawing.Size(25, 23);
            this.btnPesqLocador.TabIndex = 67;
            this.btnPesqLocador.UseVisualStyleBackColor = false;
            this.btnPesqLocador.Click += new System.EventHandler(this.btnPesqLocador_Click);
            // 
            // btnPesqLocatario
            // 
            this.btnPesqLocatario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPesqLocatario.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPesqLocatario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet;
            this.btnPesqLocatario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesqLocatario.Image = global::GestorImoveis.Properties.Resources.search_Icon_16px;
            this.btnPesqLocatario.Location = new System.Drawing.Point(78, 209);
            this.btnPesqLocatario.Name = "btnPesqLocatario";
            this.btnPesqLocatario.Size = new System.Drawing.Size(25, 23);
            this.btnPesqLocatario.TabIndex = 68;
            this.btnPesqLocatario.UseVisualStyleBackColor = true;
            this.btnPesqLocatario.Click += new System.EventHandler(this.btnPesqLocatario_Click);
            // 
            // lblVlrIptu
            // 
            this.lblVlrIptu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblVlrIptu.AutoSize = true;
            this.lblVlrIptu.Location = new System.Drawing.Point(220, 237);
            this.lblVlrIptu.Name = "lblVlrIptu";
            this.lblVlrIptu.Size = new System.Drawing.Size(35, 13);
            this.lblVlrIptu.TabIndex = 70;
            this.lblVlrIptu.Text = "IPTU:";
            // 
            // lblDtEntrada
            // 
            this.lblDtEntrada.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDtEntrada.AutoSize = true;
            this.lblDtEntrada.Location = new System.Drawing.Point(336, 236);
            this.lblDtEntrada.Name = "lblDtEntrada";
            this.lblDtEntrada.Size = new System.Drawing.Size(88, 13);
            this.lblDtEntrada.TabIndex = 72;
            this.lblDtEntrada.Text = "Data de Entrada:";
            // 
            // txtDataEntrada
            // 
            this.txtDataEntrada.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDataEntrada.Location = new System.Drawing.Point(339, 252);
            this.txtDataEntrada.Mask = "00/00/0000";
            this.txtDataEntrada.Name = "txtDataEntrada";
            this.txtDataEntrada.Size = new System.Drawing.Size(101, 20);
            this.txtDataEntrada.TabIndex = 71;
            this.txtDataEntrada.ValidatingType = typeof(System.DateTime);
            // 
            // lblPrazo
            // 
            this.lblPrazo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPrazo.AutoSize = true;
            this.lblPrazo.Location = new System.Drawing.Point(450, 237);
            this.lblPrazo.Name = "lblPrazo";
            this.lblPrazo.Size = new System.Drawing.Size(37, 13);
            this.lblPrazo.TabIndex = 74;
            this.lblPrazo.Text = "Prazo:";
            // 
            // lblDtSaida
            // 
            this.lblDtSaida.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDtSaida.AutoSize = true;
            this.lblDtSaida.Location = new System.Drawing.Point(530, 236);
            this.lblDtSaida.Name = "lblDtSaida";
            this.lblDtSaida.Size = new System.Drawing.Size(78, 13);
            this.lblDtSaida.TabIndex = 76;
            this.lblDtSaida.Text = "Data de Saida:";
            // 
            // txtDataSaida
            // 
            this.txtDataSaida.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDataSaida.Location = new System.Drawing.Point(533, 252);
            this.txtDataSaida.Mask = "00/00/0000";
            this.txtDataSaida.Name = "txtDataSaida";
            this.txtDataSaida.Size = new System.Drawing.Size(101, 20);
            this.txtDataSaida.TabIndex = 75;
            this.txtDataSaida.ValidatingType = typeof(System.DateTime);
            // 
            // txtMesesContrato
            // 
            this.txtMesesContrato.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMesesContrato.Location = new System.Drawing.Point(453, 251);
            this.txtMesesContrato.Name = "txtMesesContrato";
            this.txtMesesContrato.Size = new System.Drawing.Size(64, 20);
            this.txtMesesContrato.TabIndex = 77;
            this.txtMesesContrato.ValueChanged += new System.EventHandler(this.txtMesesContrato_ValueChanged);
            // 
            // lblMsgErro
            // 
            this.lblMsgErro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMsgErro.AutoSize = true;
            this.lblMsgErro.ForeColor = System.Drawing.Color.Red;
            this.lblMsgErro.Location = new System.Drawing.Point(324, 284);
            this.lblMsgErro.Name = "lblMsgErro";
            this.lblMsgErro.Size = new System.Drawing.Size(143, 13);
            this.lblMsgErro.TabIndex = 80;
            this.lblMsgErro.Text = "Mensagem de Erro ou Aviso!";
            this.lblMsgErro.Visible = false;
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.Image = global::GestorImoveis.Properties.Resources.Close;
            this.btnFechar.Location = new System.Drawing.Point(859, 8);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(18, 18);
            this.btnFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnFechar.TabIndex = 83;
            this.btnFechar.TabStop = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // txtVlrAluguel
            // 
            this.txtVlrAluguel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtVlrAluguel.Location = new System.Drawing.Point(75, 251);
            this.txtVlrAluguel.Name = "txtVlrAluguel";
            this.txtVlrAluguel.Size = new System.Drawing.Size(139, 20);
            this.txtVlrAluguel.TabIndex = 84;
            // 
            // txtIptu
            // 
            this.txtIptu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtIptu.Location = new System.Drawing.Point(223, 252);
            this.txtIptu.Name = "txtIptu";
            this.txtIptu.Size = new System.Drawing.Size(102, 20);
            this.txtIptu.TabIndex = 85;
            // 
            // txtCEP
            // 
            this.txtCEP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCEP.Location = new System.Drawing.Point(155, 97);
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(108, 20);
            this.txtCEP.TabIndex = 86;
            this.txtCEP.TextChanged += new System.EventHandler(this.txtCEP_TextChanged);
            // 
            // lblNumeroImovel
            // 
            this.lblNumeroImovel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNumeroImovel.AutoSize = true;
            this.lblNumeroImovel.Location = new System.Drawing.Point(656, 82);
            this.lblNumeroImovel.Name = "lblNumeroImovel";
            this.lblNumeroImovel.Size = new System.Drawing.Size(19, 13);
            this.lblNumeroImovel.TabIndex = 88;
            this.lblNumeroImovel.Text = "N°";
            // 
            // txtNumeroImovel
            // 
            this.txtNumeroImovel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNumeroImovel.Location = new System.Drawing.Point(647, 97);
            this.txtNumeroImovel.Name = "txtNumeroImovel";
            this.txtNumeroImovel.Size = new System.Drawing.Size(36, 20);
            this.txtNumeroImovel.TabIndex = 89;
            // 
            // txtUF
            // 
            this.txtUF.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtUF.Location = new System.Drawing.Point(98, 136);
            this.txtUF.Name = "txtUF";
            this.txtUF.Size = new System.Drawing.Size(33, 20);
            this.txtUF.TabIndex = 91;
            // 
            // lblUF
            // 
            this.lblUF.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblUF.AutoSize = true;
            this.lblUF.Location = new System.Drawing.Point(102, 123);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(24, 13);
            this.lblUF.TabIndex = 90;
            this.lblUF.Text = "UF:";
            // 
            // lblComplemento
            // 
            this.lblComplemento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(347, 122);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(74, 13);
            this.lblComplemento.TabIndex = 92;
            this.lblComplemento.Text = "Complemento:";
            // 
            // txtBairro
            // 
            this.txtBairro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBairro.Location = new System.Drawing.Point(689, 96);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(134, 20);
            this.txtBairro.TabIndex = 95;
            // 
            // lblBairro
            // 
            this.lblBairro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(687, 82);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(37, 13);
            this.lblBairro.TabIndex = 94;
            this.lblBairro.Text = "Bairro:";
            // 
            // txtComplemento2
            // 
            this.txtComplemento2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtComplemento2.Location = new System.Drawing.Point(547, 136);
            this.txtComplemento2.Name = "txtComplemento2";
            this.txtComplemento2.Size = new System.Drawing.Size(187, 20);
            this.txtComplemento2.TabIndex = 97;
            // 
            // lblComplemento2
            // 
            this.lblComplemento2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblComplemento2.AutoSize = true;
            this.lblComplemento2.Location = new System.Drawing.Point(544, 121);
            this.lblComplemento2.Name = "lblComplemento2";
            this.lblComplemento2.Size = new System.Drawing.Size(77, 13);
            this.lblComplemento2.TabIndex = 96;
            this.lblComplemento2.Text = "Complemeto 2:";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtComplemento.Location = new System.Drawing.Point(350, 137);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(187, 20);
            this.txtComplemento.TabIndex = 98;
            // 
            // txtCidade
            // 
            this.txtCidade.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCidade.Location = new System.Drawing.Point(155, 136);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(187, 20);
            this.txtCidade.TabIndex = 100;
            // 
            // lblCidade
            // 
            this.lblCidade.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(152, 121);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(43, 13);
            this.lblCidade.TabIndex = 99;
            this.lblCidade.Text = "Cidade:";
            // 
            // txtDiaPag
            // 
            this.txtDiaPag.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDiaPag.Location = new System.Drawing.Point(741, 174);
            this.txtDiaPag.Name = "txtDiaPag";
            this.txtDiaPag.Size = new System.Drawing.Size(33, 20);
            this.txtDiaPag.TabIndex = 101;
            this.txtDiaPag.TextChanged += new System.EventHandler(this.txtDiaPag_TextChanged);
            // 
            // CadastroContrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(892, 499);
            this.Controls.Add(this.txtDiaPag);
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
            this.Controls.Add(this.txtIptu);
            this.Controls.Add(this.txtVlrAluguel);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.lblMsgErro);
            this.Controls.Add(this.txtMesesContrato);
            this.Controls.Add(this.lblDtSaida);
            this.Controls.Add(this.txtDataSaida);
            this.Controls.Add(this.lblPrazo);
            this.Controls.Add(this.lblDtEntrada);
            this.Controls.Add(this.txtDataEntrada);
            this.Controls.Add(this.lblVlrIptu);
            this.Controls.Add(this.btnPesqLocatario);
            this.Controls.Add(this.btnPesqLocador);
            this.Controls.Add(this.lblDiaPag);
            this.Controls.Add(this.lblVlrAluguel);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.cboLocatario);
            this.Controls.Add(this.lblLocat);
            this.Controls.Add(this.lblCodLocat);
            this.Controls.Add(this.txtPesqcodLocatario);
            this.Controls.Add(this.cboLocador);
            this.Controls.Add(this.lblLocad);
            this.Controls.Add(this.lblCodLocad);
            this.Controls.Add(this.txtPesqcodLocador);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblAtivo);
            this.Controls.Add(this.cboSituacao);
            this.Controls.Add(this.lblTpImovel);
            this.Controls.Add(this.lblCEP);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.buttonGravar);
            this.Controls.Add(this.RbConsultar);
            this.Controls.Add(this.RBAlterar);
            this.Controls.Add(this.RadioCriar);
            this.Controls.Add(this.cboTipoImovel);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.gridContratos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CadastroContrato";
            this.Text = "CadastroContrato";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPesquisa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridContratos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMesesContrato)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RbNome;
        private System.Windows.Forms.RadioButton RbCodigo;
        private System.Windows.Forms.TextBox TxtPesquisa;
        private System.Windows.Forms.Label lblAtivo;
        private System.Windows.Forms.ComboBox cboSituacao;
        private System.Windows.Forms.Label lblTpImovel;
        private System.Windows.Forms.Button buttonGravar;
        private System.Windows.Forms.RadioButton RbConsultar;
        private System.Windows.Forms.RadioButton RBAlterar;
        private System.Windows.Forms.RadioButton RadioCriar;
        private System.Windows.Forms.ComboBox cboTipoImovel;
        private System.Windows.Forms.DataGridView gridContratos;
        private System.Windows.Forms.ComboBox cboLocador;
        private System.Windows.Forms.Label lblLocad;
        private System.Windows.Forms.Label lblCodLocad;
        private System.Windows.Forms.TextBox txtPesqcodLocador;
        private System.Windows.Forms.ComboBox cboLocatario;
        private System.Windows.Forms.Label lblLocat;
        private System.Windows.Forms.Label lblCodLocat;
        private System.Windows.Forms.TextBox txtPesqcodLocatario;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Label lblVlrAluguel;
        private System.Windows.Forms.Label lblDiaPag;
        private System.Windows.Forms.Button btnPesqLocador;
        private System.Windows.Forms.Button btnPesqLocatario;
        private System.Windows.Forms.Label lblVlrIptu;
        private System.Windows.Forms.Label lblDtEntrada;
        private System.Windows.Forms.MaskedTextBox txtDataEntrada;
        private System.Windows.Forms.Label lblPrazo;
        private System.Windows.Forms.Label lblDtSaida;
        private System.Windows.Forms.MaskedTextBox txtDataSaida;
        private System.Windows.Forms.NumericUpDown txtMesesContrato;
        private System.Windows.Forms.Label lblMsgErro;
        private System.Windows.Forms.PictureBox btnFechar;
        private System.Windows.Forms.PictureBox btnPesquisa;
        private System.Windows.Forms.TextBox txtVlrAluguel;
        private System.Windows.Forms.TextBox txtIptu;
        private System.Windows.Forms.TextBox txtCEP;
        private System.Windows.Forms.Label lblNumeroImovel;
        private System.Windows.Forms.TextBox txtNumeroImovel;
        private System.Windows.Forms.TextBox txtUF;
        private System.Windows.Forms.Label lblUF;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txtComplemento2;
        private System.Windows.Forms.Label lblComplemento2;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox txtDiaPag;
    }
}