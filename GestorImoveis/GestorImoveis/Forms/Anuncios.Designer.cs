namespace GestorImoveis.Forms
{
    partial class Anuncios
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboRegiaoPesq = new System.Windows.Forms.ComboBox();
            this.BtnPesquisa = new System.Windows.Forms.PictureBox();
            this.RbRegiao = new System.Windows.Forms.RadioButton();
            this.RbNomeProp = new System.Windows.Forms.RadioButton();
            this.RbCodigo = new System.Windows.Forms.RadioButton();
            this.TxtPesquisa = new System.Windows.Forms.TextBox();
            this.RbConsultar = new System.Windows.Forms.RadioButton();
            this.RBAlterar = new System.Windows.Forms.RadioButton();
            this.RadioCriar = new System.Windows.Forms.RadioButton();
            this.gridAnuncio = new System.Windows.Forms.DataGridView();
            this.cboNeg = new System.Windows.Forms.ComboBox();
            this.cboRegiao = new System.Windows.Forms.ComboBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.cboTipoImov = new System.Windows.Forms.ComboBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtDorm = new System.Windows.Forms.TextBox();
            this.txtSuites = new System.Windows.Forms.TextBox();
            this.txtVagas = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.cboCidade = new System.Windows.Forms.ComboBox();
            this.cboBairro = new System.Windows.Forms.ComboBox();
            this.ckPermuta = new System.Windows.Forms.CheckBox();
            this.txtIPTU = new System.Windows.Forms.TextBox();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.ckChurrasqueira = new System.Windows.Forms.CheckBox();
            this.ckBrinquedoteca = new System.Windows.Forms.CheckBox();
            this.chPiscina = new System.Windows.Forms.CheckBox();
            this.ckPlayground = new System.Windows.Forms.CheckBox();
            this.ckPoliesportiva = new System.Windows.Forms.CheckBox();
            this.ckJogos = new System.Windows.Forms.CheckBox();
            this.ckFestas = new System.Windows.Forms.CheckBox();
            this.ckGinástica = new System.Windows.Forms.CheckBox();
            this.buttonGravar = new System.Windows.Forms.Button();
            this.lblMsgErro = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.PictureBox();
            this.lblNeg = new System.Windows.Forms.Label();
            this.lblReg = new System.Windows.Forms.Label();
            this.lblTipoImovel = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblIptu = new System.Windows.Forms.Label();
            this.txtNomeProp = new System.Windows.Forms.TextBox();
            this.lblDorm = new System.Windows.Forms.Label();
            this.lblsuites = new System.Windows.Forms.Label();
            this.lblVagas = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblNomeProp = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblObs = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblAtivo = new System.Windows.Forms.Label();
            this.cboSituacao = new System.Windows.Forms.ComboBox();
            this.BtnUploadImage = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnPesquisa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAnuncio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.cboRegiaoPesq);
            this.groupBox1.Controls.Add(this.BtnPesquisa);
            this.groupBox1.Controls.Add(this.RbRegiao);
            this.groupBox1.Controls.Add(this.RbNomeProp);
            this.groupBox1.Controls.Add(this.RbCodigo);
            this.groupBox1.Controls.Add(this.TxtPesquisa);
            this.groupBox1.Location = new System.Drawing.Point(574, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 66);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisa";
            // 
            // cboRegiaoPesq
            // 
            this.cboRegiaoPesq.FormattingEnabled = true;
            this.cboRegiaoPesq.Location = new System.Drawing.Point(6, 37);
            this.cboRegiaoPesq.Name = "cboRegiaoPesq";
            this.cboRegiaoPesq.Size = new System.Drawing.Size(208, 21);
            this.cboRegiaoPesq.TabIndex = 137;
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
            // RbRegiao
            // 
            this.RbRegiao.AutoSize = true;
            this.RbRegiao.Location = new System.Drawing.Point(177, 14);
            this.RbRegiao.Name = "RbRegiao";
            this.RbRegiao.Size = new System.Drawing.Size(59, 17);
            this.RbRegiao.TabIndex = 30;
            this.RbRegiao.TabStop = true;
            this.RbRegiao.Text = "Região";
            this.RbRegiao.UseVisualStyleBackColor = true;
            this.RbRegiao.CheckedChanged += new System.EventHandler(this.RbRegiao_CheckedChanged);
            // 
            // RbNomeProp
            // 
            this.RbNomeProp.AutoSize = true;
            this.RbNomeProp.Location = new System.Drawing.Point(100, 14);
            this.RbNomeProp.Name = "RbNomeProp";
            this.RbNomeProp.Size = new System.Drawing.Size(47, 17);
            this.RbNomeProp.TabIndex = 29;
            this.RbNomeProp.TabStop = true;
            this.RbNomeProp.Text = "Prop";
            this.RbNomeProp.UseVisualStyleBackColor = true;
            this.RbNomeProp.CheckedChanged += new System.EventHandler(this.RbNomeProp_CheckedChanged);
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
            this.TxtPesquisa.Location = new System.Drawing.Point(9, 37);
            this.TxtPesquisa.Name = "TxtPesquisa";
            this.TxtPesquisa.Size = new System.Drawing.Size(205, 20);
            this.TxtPesquisa.TabIndex = 0;
            // 
            // RbConsultar
            // 
            this.RbConsultar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RbConsultar.AutoSize = true;
            this.RbConsultar.Location = new System.Drawing.Point(473, 23);
            this.RbConsultar.Name = "RbConsultar";
            this.RbConsultar.Size = new System.Drawing.Size(66, 17);
            this.RbConsultar.TabIndex = 28;
            this.RbConsultar.TabStop = true;
            this.RbConsultar.Text = "Consulta";
            this.RbConsultar.UseVisualStyleBackColor = true;
            this.RbConsultar.CheckedChanged += new System.EventHandler(this.RbConsultar_CheckedChanged);
            // 
            // RBAlterar
            // 
            this.RBAlterar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RBAlterar.AutoSize = true;
            this.RBAlterar.Location = new System.Drawing.Point(370, 23);
            this.RBAlterar.Name = "RBAlterar";
            this.RBAlterar.Size = new System.Drawing.Size(55, 17);
            this.RBAlterar.TabIndex = 27;
            this.RBAlterar.TabStop = true;
            this.RBAlterar.Text = "Alterar";
            this.RBAlterar.UseVisualStyleBackColor = true;
            this.RBAlterar.CheckedChanged += new System.EventHandler(this.RBAlterar_CheckedChanged);
            // 
            // RadioCriar
            // 
            this.RadioCriar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RadioCriar.AutoSize = true;
            this.RadioCriar.Location = new System.Drawing.Point(267, 23);
            this.RadioCriar.Name = "RadioCriar";
            this.RadioCriar.Size = new System.Drawing.Size(46, 17);
            this.RadioCriar.TabIndex = 26;
            this.RadioCriar.TabStop = true;
            this.RadioCriar.Text = "Criar";
            this.RadioCriar.UseVisualStyleBackColor = true;
            this.RadioCriar.CheckedChanged += new System.EventHandler(this.RadioCriar_CheckedChanged);
            // 
            // gridAnuncio
            // 
            this.gridAnuncio.AllowUserToAddRows = false;
            this.gridAnuncio.AllowUserToDeleteRows = false;
            this.gridAnuncio.AllowUserToResizeColumns = false;
            this.gridAnuncio.AllowUserToResizeRows = false;
            this.gridAnuncio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gridAnuncio.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.gridAnuncio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.BlueViolet;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridAnuncio.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridAnuncio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.BlueViolet;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridAnuncio.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridAnuncio.EnableHeadersVisualStyles = false;
            this.gridAnuncio.GridColor = System.Drawing.Color.Black;
            this.gridAnuncio.Location = new System.Drawing.Point(6, 313);
            this.gridAnuncio.Name = "gridAnuncio";
            this.gridAnuncio.ReadOnly = true;
            this.gridAnuncio.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.BlueViolet;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridAnuncio.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridAnuncio.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.gridAnuncio.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gridAnuncio.Size = new System.Drawing.Size(879, 145);
            this.gridAnuncio.TabIndex = 31;
            this.gridAnuncio.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridAnuncio_CellContentClick);
            // 
            // cboNeg
            // 
            this.cboNeg.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboNeg.FormattingEnabled = true;
            this.cboNeg.Location = new System.Drawing.Point(124, 94);
            this.cboNeg.Name = "cboNeg";
            this.cboNeg.Size = new System.Drawing.Size(72, 21);
            this.cboNeg.TabIndex = 32;
            this.cboNeg.SelectedIndexChanged += new System.EventHandler(this.cboNeg_SelectedIndexChanged);
            // 
            // cboRegiao
            // 
            this.cboRegiao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboRegiao.FormattingEnabled = true;
            this.cboRegiao.Location = new System.Drawing.Point(209, 94);
            this.cboRegiao.Name = "cboRegiao";
            this.cboRegiao.Size = new System.Drawing.Size(127, 21);
            this.cboRegiao.TabIndex = 33;
            this.cboRegiao.SelectedIndexChanged += new System.EventHandler(this.cboRegiao_SelectedIndexChanged);
            // 
            // lblCodigo
            // 
            this.lblCodigo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(56, 79);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 35;
            this.lblCodigo.Text = "Codigo:";
            // 
            // txtId
            // 
            this.txtId.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(42, 95);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(71, 20);
            this.txtId.TabIndex = 34;
            // 
            // cboTipoImov
            // 
            this.cboTipoImov.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboTipoImov.FormattingEnabled = true;
            this.cboTipoImov.Location = new System.Drawing.Point(351, 94);
            this.cboTipoImov.Name = "cboTipoImov";
            this.cboTipoImov.Size = new System.Drawing.Size(213, 21);
            this.cboTipoImov.TabIndex = 36;
            // 
            // txtPreco
            // 
            this.txtPreco.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPreco.Location = new System.Drawing.Point(574, 94);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(111, 20);
            this.txtPreco.TabIndex = 37;
            // 
            // txtDorm
            // 
            this.txtDorm.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDorm.Location = new System.Drawing.Point(42, 135);
            this.txtDorm.Name = "txtDorm";
            this.txtDorm.Size = new System.Drawing.Size(40, 20);
            this.txtDorm.TabIndex = 38;
            // 
            // txtSuites
            // 
            this.txtSuites.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSuites.Location = new System.Drawing.Point(89, 134);
            this.txtSuites.Name = "txtSuites";
            this.txtSuites.Size = new System.Drawing.Size(40, 20);
            this.txtSuites.TabIndex = 40;
            // 
            // txtVagas
            // 
            this.txtVagas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtVagas.Location = new System.Drawing.Point(135, 134);
            this.txtVagas.Name = "txtVagas";
            this.txtVagas.Size = new System.Drawing.Size(39, 20);
            this.txtVagas.TabIndex = 41;
            // 
            // txtArea
            // 
            this.txtArea.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtArea.Location = new System.Drawing.Point(189, 134);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(62, 20);
            this.txtArea.TabIndex = 42;
            // 
            // cboCidade
            // 
            this.cboCidade.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboCidade.FormattingEnabled = true;
            this.cboCidade.Location = new System.Drawing.Point(267, 133);
            this.cboCidade.Name = "cboCidade";
            this.cboCidade.Size = new System.Drawing.Size(253, 21);
            this.cboCidade.TabIndex = 43;
            this.cboCidade.SelectedIndexChanged += new System.EventHandler(this.cboCidade_SelectedIndexChanged);
            // 
            // cboBairro
            // 
            this.cboBairro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboBairro.FormattingEnabled = true;
            this.cboBairro.Location = new System.Drawing.Point(543, 133);
            this.cboBairro.Name = "cboBairro";
            this.cboBairro.Size = new System.Drawing.Size(277, 21);
            this.cboBairro.TabIndex = 44;
            // 
            // ckPermuta
            // 
            this.ckPermuta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ckPermuta.AutoSize = true;
            this.ckPermuta.Location = new System.Drawing.Point(535, 210);
            this.ckPermuta.Name = "ckPermuta";
            this.ckPermuta.Size = new System.Drawing.Size(65, 17);
            this.ckPermuta.TabIndex = 45;
            this.ckPermuta.Text = "Permuta";
            this.ckPermuta.UseVisualStyleBackColor = true;
            // 
            // txtIPTU
            // 
            this.txtIPTU.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtIPTU.Location = new System.Drawing.Point(693, 94);
            this.txtIPTU.Name = "txtIPTU";
            this.txtIPTU.Size = new System.Drawing.Size(95, 20);
            this.txtIPTU.TabIndex = 47;
            // 
            // txtObs
            // 
            this.txtObs.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtObs.Location = new System.Drawing.Point(43, 211);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(477, 69);
            this.txtObs.TabIndex = 48;
            // 
            // ckChurrasqueira
            // 
            this.ckChurrasqueira.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ckChurrasqueira.AutoSize = true;
            this.ckChurrasqueira.Location = new System.Drawing.Point(536, 234);
            this.ckChurrasqueira.Name = "ckChurrasqueira";
            this.ckChurrasqueira.Size = new System.Drawing.Size(91, 17);
            this.ckChurrasqueira.TabIndex = 49;
            this.ckChurrasqueira.Text = "Churrasqueira";
            this.ckChurrasqueira.UseVisualStyleBackColor = true;
            // 
            // ckBrinquedoteca
            // 
            this.ckBrinquedoteca.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ckBrinquedoteca.AutoSize = true;
            this.ckBrinquedoteca.Location = new System.Drawing.Point(636, 210);
            this.ckBrinquedoteca.Name = "ckBrinquedoteca";
            this.ckBrinquedoteca.Size = new System.Drawing.Size(95, 17);
            this.ckBrinquedoteca.TabIndex = 50;
            this.ckBrinquedoteca.Text = "Brinquedoteca";
            this.ckBrinquedoteca.UseVisualStyleBackColor = true;
            // 
            // chPiscina
            // 
            this.chPiscina.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chPiscina.AutoSize = true;
            this.chPiscina.Location = new System.Drawing.Point(536, 257);
            this.chPiscina.Name = "chPiscina";
            this.chPiscina.Size = new System.Drawing.Size(60, 17);
            this.chPiscina.TabIndex = 51;
            this.chPiscina.Text = "Piscina";
            this.chPiscina.UseVisualStyleBackColor = true;
            // 
            // ckPlayground
            // 
            this.ckPlayground.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ckPlayground.AutoSize = true;
            this.ckPlayground.Location = new System.Drawing.Point(636, 233);
            this.ckPlayground.Name = "ckPlayground";
            this.ckPlayground.Size = new System.Drawing.Size(79, 17);
            this.ckPlayground.TabIndex = 52;
            this.ckPlayground.Text = "Playground";
            this.ckPlayground.UseVisualStyleBackColor = true;
            // 
            // ckPoliesportiva
            // 
            this.ckPoliesportiva.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ckPoliesportiva.AutoSize = true;
            this.ckPoliesportiva.Location = new System.Drawing.Point(636, 256);
            this.ckPoliesportiva.Name = "ckPoliesportiva";
            this.ckPoliesportiva.Size = new System.Drawing.Size(86, 17);
            this.ckPoliesportiva.TabIndex = 53;
            this.ckPoliesportiva.Text = "Poliesportiva";
            this.ckPoliesportiva.UseVisualStyleBackColor = true;
            // 
            // ckJogos
            // 
            this.ckJogos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ckJogos.AutoSize = true;
            this.ckJogos.Location = new System.Drawing.Point(745, 257);
            this.ckJogos.Name = "ckJogos";
            this.ckJogos.Size = new System.Drawing.Size(99, 17);
            this.ckJogos.TabIndex = 57;
            this.ckJogos.Text = "Salão de Jogos";
            this.ckJogos.UseVisualStyleBackColor = true;
            // 
            // ckFestas
            // 
            this.ckFestas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ckFestas.AutoSize = true;
            this.ckFestas.Location = new System.Drawing.Point(745, 234);
            this.ckFestas.Name = "ckFestas";
            this.ckFestas.Size = new System.Drawing.Size(102, 17);
            this.ckFestas.TabIndex = 56;
            this.ckFestas.Text = "Salão de Festas";
            this.ckFestas.UseVisualStyleBackColor = true;
            // 
            // ckGinástica
            // 
            this.ckGinástica.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ckGinástica.AutoSize = true;
            this.ckGinástica.Location = new System.Drawing.Point(745, 211);
            this.ckGinástica.Name = "ckGinástica";
            this.ckGinástica.Size = new System.Drawing.Size(94, 17);
            this.ckGinástica.TabIndex = 55;
            this.ckGinástica.Text = "Sala Ginástica";
            this.ckGinástica.UseVisualStyleBackColor = true;
            // 
            // buttonGravar
            // 
            this.buttonGravar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonGravar.BackColor = System.Drawing.Color.SlateBlue;
            this.buttonGravar.FlatAppearance.BorderColor = System.Drawing.Color.SlateBlue;
            this.buttonGravar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.buttonGravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGravar.ForeColor = System.Drawing.Color.White;
            this.buttonGravar.Location = new System.Drawing.Point(242, 464);
            this.buttonGravar.Name = "buttonGravar";
            this.buttonGravar.Size = new System.Drawing.Size(204, 23);
            this.buttonGravar.TabIndex = 116;
            this.buttonGravar.Text = "Gravar";
            this.buttonGravar.UseVisualStyleBackColor = false;
            this.buttonGravar.Click += new System.EventHandler(this.buttonGravar_Click);
            // 
            // lblMsgErro
            // 
            this.lblMsgErro.AutoSize = true;
            this.lblMsgErro.ForeColor = System.Drawing.Color.Red;
            this.lblMsgErro.Location = new System.Drawing.Point(390, 297);
            this.lblMsgErro.Name = "lblMsgErro";
            this.lblMsgErro.Size = new System.Drawing.Size(143, 13);
            this.lblMsgErro.TabIndex = 117;
            this.lblMsgErro.Text = "Mensagem de Erro ou Aviso!";
            this.lblMsgErro.Visible = false;
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.Image = global::GestorImoveis.Properties.Resources.Close;
            this.btnFechar.Location = new System.Drawing.Point(866, 7);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(18, 18);
            this.btnFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnFechar.TabIndex = 118;
            this.btnFechar.TabStop = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lblNeg
            // 
            this.lblNeg.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNeg.AutoSize = true;
            this.lblNeg.Location = new System.Drawing.Point(124, 79);
            this.lblNeg.Name = "lblNeg";
            this.lblNeg.Size = new System.Drawing.Size(50, 13);
            this.lblNeg.TabIndex = 119;
            this.lblNeg.Text = "Negócio:";
            // 
            // lblReg
            // 
            this.lblReg.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblReg.AutoSize = true;
            this.lblReg.Location = new System.Drawing.Point(206, 79);
            this.lblReg.Name = "lblReg";
            this.lblReg.Size = new System.Drawing.Size(44, 13);
            this.lblReg.TabIndex = 120;
            this.lblReg.Text = "Região:";
            // 
            // lblTipoImovel
            // 
            this.lblTipoImovel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTipoImovel.AutoSize = true;
            this.lblTipoImovel.Location = new System.Drawing.Point(348, 78);
            this.lblTipoImovel.Name = "lblTipoImovel";
            this.lblTipoImovel.Size = new System.Drawing.Size(31, 13);
            this.lblTipoImovel.TabIndex = 121;
            this.lblTipoImovel.Text = "Tipo:";
            // 
            // lblPreco
            // 
            this.lblPreco.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(571, 80);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(38, 13);
            this.lblPreco.TabIndex = 122;
            this.lblPreco.Text = "Preço:";
            // 
            // lblIptu
            // 
            this.lblIptu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblIptu.AutoSize = true;
            this.lblIptu.Location = new System.Drawing.Point(690, 80);
            this.lblIptu.Name = "lblIptu";
            this.lblIptu.Size = new System.Drawing.Size(35, 13);
            this.lblIptu.TabIndex = 123;
            this.lblIptu.Text = "IPTU:";
            // 
            // txtNomeProp
            // 
            this.txtNomeProp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNomeProp.Location = new System.Drawing.Point(43, 172);
            this.txtNomeProp.Name = "txtNomeProp";
            this.txtNomeProp.Size = new System.Drawing.Size(336, 20);
            this.txtNomeProp.TabIndex = 124;
            // 
            // lblDorm
            // 
            this.lblDorm.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDorm.AutoSize = true;
            this.lblDorm.Location = new System.Drawing.Point(39, 120);
            this.lblDorm.Name = "lblDorm";
            this.lblDorm.Size = new System.Drawing.Size(38, 13);
            this.lblDorm.TabIndex = 125;
            this.lblDorm.Text = "Dorm.:";
            // 
            // lblsuites
            // 
            this.lblsuites.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblsuites.AutoSize = true;
            this.lblsuites.Location = new System.Drawing.Point(86, 119);
            this.lblsuites.Name = "lblsuites";
            this.lblsuites.Size = new System.Drawing.Size(39, 13);
            this.lblsuites.TabIndex = 126;
            this.lblsuites.Text = "Suites:";
            // 
            // lblVagas
            // 
            this.lblVagas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblVagas.AutoSize = true;
            this.lblVagas.Location = new System.Drawing.Point(132, 119);
            this.lblVagas.Name = "lblVagas";
            this.lblVagas.Size = new System.Drawing.Size(40, 13);
            this.lblVagas.TabIndex = 127;
            this.lblVagas.Text = "Vagas:";
            // 
            // lblArea
            // 
            this.lblArea.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(186, 119);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(32, 13);
            this.lblArea.TabIndex = 128;
            this.lblArea.Text = "Área:";
            // 
            // lblNomeProp
            // 
            this.lblNomeProp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNomeProp.AutoSize = true;
            this.lblNomeProp.Location = new System.Drawing.Point(40, 158);
            this.lblNomeProp.Name = "lblNomeProp";
            this.lblNomeProp.Size = new System.Drawing.Size(66, 13);
            this.lblNomeProp.TabIndex = 129;
            this.lblNomeProp.Text = "Nome Prop.:";
            // 
            // lblCidade
            // 
            this.lblCidade.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(264, 119);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(43, 13);
            this.lblCidade.TabIndex = 130;
            this.lblCidade.Text = "Cidade:";
            // 
            // lblBairro
            // 
            this.lblBairro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(540, 119);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(37, 13);
            this.lblBairro.TabIndex = 131;
            this.lblBairro.Text = "Bairro:";
            // 
            // lblObs
            // 
            this.lblObs.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblObs.AutoSize = true;
            this.lblObs.Location = new System.Drawing.Point(40, 196);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(73, 13);
            this.lblObs.TabIndex = 132;
            this.lblObs.Text = "Observações:";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEndereco.Location = new System.Drawing.Point(393, 171);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(346, 20);
            this.txtEndereco.TabIndex = 133;
            // 
            // lblEndereco
            // 
            this.lblEndereco.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(390, 157);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(56, 13);
            this.lblEndereco.TabIndex = 134;
            this.lblEndereco.Text = "Endereço:";
            // 
            // lblAtivo
            // 
            this.lblAtivo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAtivo.AutoSize = true;
            this.lblAtivo.Location = new System.Drawing.Point(742, 157);
            this.lblAtivo.Name = "lblAtivo";
            this.lblAtivo.Size = new System.Drawing.Size(34, 13);
            this.lblAtivo.TabIndex = 136;
            this.lblAtivo.Text = "Ativo:";
            // 
            // cboSituacao
            // 
            this.cboSituacao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboSituacao.FormattingEnabled = true;
            this.cboSituacao.Location = new System.Drawing.Point(745, 170);
            this.cboSituacao.Name = "cboSituacao";
            this.cboSituacao.Size = new System.Drawing.Size(72, 21);
            this.cboSituacao.TabIndex = 135;
            // 
            // BtnUploadImage
            // 
            this.BtnUploadImage.BackColor = System.Drawing.Color.SlateBlue;
            this.BtnUploadImage.FlatAppearance.BorderColor = System.Drawing.Color.SlateBlue;
            this.BtnUploadImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUploadImage.ForeColor = System.Drawing.Color.White;
            this.BtnUploadImage.Location = new System.Drawing.Point(491, 464);
            this.BtnUploadImage.Name = "BtnUploadImage";
            this.BtnUploadImage.Size = new System.Drawing.Size(204, 23);
            this.BtnUploadImage.TabIndex = 137;
            this.BtnUploadImage.Text = "Imagens";
            this.BtnUploadImage.UseVisualStyleBackColor = false;
            this.BtnUploadImage.Click += new System.EventHandler(this.BtnUploadImage_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Anuncios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(892, 499);
            this.Controls.Add(this.BtnUploadImage);
            this.Controls.Add(this.lblAtivo);
            this.Controls.Add(this.cboSituacao);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.lblObs);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.lblNomeProp);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblVagas);
            this.Controls.Add(this.lblsuites);
            this.Controls.Add(this.lblDorm);
            this.Controls.Add(this.txtNomeProp);
            this.Controls.Add(this.lblIptu);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.lblTipoImovel);
            this.Controls.Add(this.lblReg);
            this.Controls.Add(this.lblNeg);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.lblMsgErro);
            this.Controls.Add(this.buttonGravar);
            this.Controls.Add(this.ckJogos);
            this.Controls.Add(this.ckFestas);
            this.Controls.Add(this.ckGinástica);
            this.Controls.Add(this.ckPoliesportiva);
            this.Controls.Add(this.ckPlayground);
            this.Controls.Add(this.chPiscina);
            this.Controls.Add(this.ckBrinquedoteca);
            this.Controls.Add(this.ckChurrasqueira);
            this.Controls.Add(this.txtObs);
            this.Controls.Add(this.txtIPTU);
            this.Controls.Add(this.ckPermuta);
            this.Controls.Add(this.cboBairro);
            this.Controls.Add(this.cboCidade);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.txtVagas);
            this.Controls.Add(this.txtSuites);
            this.Controls.Add(this.txtDorm);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.cboTipoImov);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.cboRegiao);
            this.Controls.Add(this.cboNeg);
            this.Controls.Add(this.gridAnuncio);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.RbConsultar);
            this.Controls.Add(this.RBAlterar);
            this.Controls.Add(this.RadioCriar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Anuncios";
            this.Text = "Anuncios";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnPesquisa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAnuncio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox BtnPesquisa;
        private System.Windows.Forms.RadioButton RbNomeProp;
        private System.Windows.Forms.RadioButton RbCodigo;
        private System.Windows.Forms.TextBox TxtPesquisa;
        private System.Windows.Forms.RadioButton RbConsultar;
        private System.Windows.Forms.RadioButton RBAlterar;
        private System.Windows.Forms.RadioButton RadioCriar;
        private System.Windows.Forms.DataGridView gridAnuncio;
        private System.Windows.Forms.ComboBox cboNeg;
        private System.Windows.Forms.ComboBox cboRegiao;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.ComboBox cboTipoImov;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TextBox txtDorm;
        private System.Windows.Forms.TextBox txtVagas;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.ComboBox cboCidade;
        private System.Windows.Forms.ComboBox cboBairro;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.CheckBox ckChurrasqueira;
        private System.Windows.Forms.CheckBox ckBrinquedoteca;
        private System.Windows.Forms.CheckBox chPiscina;
        private System.Windows.Forms.CheckBox ckPlayground;
        private System.Windows.Forms.CheckBox ckPoliesportiva;
        private System.Windows.Forms.CheckBox ckJogos;
        private System.Windows.Forms.CheckBox ckFestas;
        private System.Windows.Forms.CheckBox ckGinástica;
        private System.Windows.Forms.Button buttonGravar;
        private System.Windows.Forms.Label lblMsgErro;
        private System.Windows.Forms.PictureBox btnFechar;
        private System.Windows.Forms.Label lblNeg;
        private System.Windows.Forms.Label lblReg;
        private System.Windows.Forms.Label lblTipoImovel;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblIptu;
        private System.Windows.Forms.TextBox txtNomeProp;
        private System.Windows.Forms.TextBox txtIPTU;
        private System.Windows.Forms.Label lblDorm;
        private System.Windows.Forms.Label lblsuites;
        private System.Windows.Forms.Label lblVagas;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblNomeProp;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblObs;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.TextBox txtSuites;
        private System.Windows.Forms.CheckBox ckPermuta;
        private System.Windows.Forms.Label lblAtivo;
        private System.Windows.Forms.ComboBox cboSituacao;
        private System.Windows.Forms.RadioButton RbRegiao;
        private System.Windows.Forms.ComboBox cboRegiaoPesq;
        private System.Windows.Forms.Button BtnUploadImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}