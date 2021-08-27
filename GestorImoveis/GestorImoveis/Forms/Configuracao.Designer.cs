namespace GestorImoveis.Forms
{
    partial class Configuracao
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
            this.btnFechar = new System.Windows.Forms.PictureBox();
            this.lblMsgErro = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPesquisa = new System.Windows.Forms.PictureBox();
            this.RbNome = new System.Windows.Forms.RadioButton();
            this.RbCodigo = new System.Windows.Forms.RadioButton();
            this.TxtPesquisa = new System.Windows.Forms.TextBox();
            this.buttonGravar = new System.Windows.Forms.Button();
            this.RbConsultar = new System.Windows.Forms.RadioButton();
            this.RBAlterar = new System.Windows.Forms.RadioButton();
            this.gridParametros = new System.Windows.Forms.DataGridView();
            this.txtSistema = new System.Windows.Forms.TextBox();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.txtParametro = new System.Windows.Forms.TextBox();
            this.txtDataAtualizacao = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblSist = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblParametro = new System.Windows.Forms.Label();
            this.lblDtAlt = new System.Windows.Forms.Label();
            this.lblUsu = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConteudo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPesquisa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridParametros)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.Image = global::GestorImoveis.Properties.Resources.Close;
            this.btnFechar.Location = new System.Drawing.Point(869, 5);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(18, 18);
            this.btnFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnFechar.TabIndex = 85;
            this.btnFechar.TabStop = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lblMsgErro
            // 
            this.lblMsgErro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMsgErro.AutoSize = true;
            this.lblMsgErro.ForeColor = System.Drawing.Color.Red;
            this.lblMsgErro.Location = new System.Drawing.Point(379, 243);
            this.lblMsgErro.Name = "lblMsgErro";
            this.lblMsgErro.Size = new System.Drawing.Size(143, 13);
            this.lblMsgErro.TabIndex = 122;
            this.lblMsgErro.Text = "Mensagem de Erro ou Aviso!";
            this.lblMsgErro.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.btnPesquisa);
            this.groupBox1.Controls.Add(this.RbNome);
            this.groupBox1.Controls.Add(this.RbCodigo);
            this.groupBox1.Controls.Add(this.TxtPesquisa);
            this.groupBox1.Location = new System.Drawing.Point(526, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 65);
            this.groupBox1.TabIndex = 98;
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
            // 
            // RbNome
            // 
            this.RbNome.AutoSize = true;
            this.RbNome.Location = new System.Drawing.Point(100, 14);
            this.RbNome.Name = "RbNome";
            this.RbNome.Size = new System.Drawing.Size(70, 17);
            this.RbNome.TabIndex = 29;
            this.RbNome.TabStop = true;
            this.RbNome.Text = "Categoria";
            this.RbNome.UseVisualStyleBackColor = true;
            // 
            // RbCodigo
            // 
            this.RbCodigo.AutoSize = true;
            this.RbCodigo.Location = new System.Drawing.Point(9, 14);
            this.RbCodigo.Name = "RbCodigo";
            this.RbCodigo.Size = new System.Drawing.Size(73, 17);
            this.RbCodigo.TabIndex = 28;
            this.RbCodigo.TabStop = true;
            this.RbCodigo.Text = "Parametro";
            this.RbCodigo.UseVisualStyleBackColor = true;
            // 
            // TxtPesquisa
            // 
            this.TxtPesquisa.Location = new System.Drawing.Point(9, 38);
            this.TxtPesquisa.Name = "TxtPesquisa";
            this.TxtPesquisa.Size = new System.Drawing.Size(205, 20);
            this.TxtPesquisa.TabIndex = 0;
            // 
            // buttonGravar
            // 
            this.buttonGravar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonGravar.BackColor = System.Drawing.Color.SlateBlue;
            this.buttonGravar.FlatAppearance.BorderColor = System.Drawing.Color.SlateBlue;
            this.buttonGravar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.buttonGravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGravar.ForeColor = System.Drawing.Color.White;
            this.buttonGravar.Location = new System.Drawing.Point(344, 451);
            this.buttonGravar.Name = "buttonGravar";
            this.buttonGravar.Size = new System.Drawing.Size(204, 23);
            this.buttonGravar.TabIndex = 92;
            this.buttonGravar.Text = "Gravar";
            this.buttonGravar.UseVisualStyleBackColor = false;
            this.buttonGravar.Click += new System.EventHandler(this.buttonGravar_Click);
            // 
            // RbConsultar
            // 
            this.RbConsultar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RbConsultar.AutoSize = true;
            this.RbConsultar.Location = new System.Drawing.Point(398, 52);
            this.RbConsultar.Name = "RbConsultar";
            this.RbConsultar.Size = new System.Drawing.Size(66, 17);
            this.RbConsultar.TabIndex = 91;
            this.RbConsultar.TabStop = true;
            this.RbConsultar.Text = "Consulta";
            this.RbConsultar.UseVisualStyleBackColor = true;
            this.RbConsultar.CheckedChanged += new System.EventHandler(this.RbConsultar_CheckedChanged);
            // 
            // RBAlterar
            // 
            this.RBAlterar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RBAlterar.AutoSize = true;
            this.RBAlterar.Location = new System.Drawing.Point(295, 52);
            this.RBAlterar.Name = "RBAlterar";
            this.RBAlterar.Size = new System.Drawing.Size(55, 17);
            this.RBAlterar.TabIndex = 90;
            this.RBAlterar.TabStop = true;
            this.RBAlterar.Text = "Alterar";
            this.RBAlterar.UseVisualStyleBackColor = true;
            this.RBAlterar.CheckedChanged += new System.EventHandler(this.RBAlterar_CheckedChanged);
            // 
            // gridParametros
            // 
            this.gridParametros.AllowUserToAddRows = false;
            this.gridParametros.AllowUserToDeleteRows = false;
            this.gridParametros.AllowUserToResizeColumns = false;
            this.gridParametros.AllowUserToResizeRows = false;
            this.gridParametros.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gridParametros.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.gridParametros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridParametros.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.BlueViolet;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridParametros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridParametros.ColumnHeadersHeight = 30;
            this.gridParametros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridParametros.EnableHeadersVisualStyles = false;
            this.gridParametros.GridColor = System.Drawing.Color.Black;
            this.gridParametros.Location = new System.Drawing.Point(118, 259);
            this.gridParametros.Name = "gridParametros";
            this.gridParametros.ReadOnly = true;
            this.gridParametros.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridParametros.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridParametros.RowHeadersVisible = false;
            this.gridParametros.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.gridParametros.Size = new System.Drawing.Size(692, 171);
            this.gridParametros.TabIndex = 86;
            this.gridParametros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridParametros_CellContentClick);
            // 
            // txtSistema
            // 
            this.txtSistema.Location = new System.Drawing.Point(136, 128);
            this.txtSistema.Name = "txtSistema";
            this.txtSistema.Size = new System.Drawing.Size(59, 20);
            this.txtSistema.TabIndex = 123;
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(205, 128);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(132, 20);
            this.txtCategoria.TabIndex = 124;
            // 
            // txtParametro
            // 
            this.txtParametro.Location = new System.Drawing.Point(136, 172);
            this.txtParametro.Name = "txtParametro";
            this.txtParametro.Size = new System.Drawing.Size(138, 20);
            this.txtParametro.TabIndex = 125;
            // 
            // txtDataAtualizacao
            // 
            this.txtDataAtualizacao.Location = new System.Drawing.Point(347, 128);
            this.txtDataAtualizacao.Name = "txtDataAtualizacao";
            this.txtDataAtualizacao.Size = new System.Drawing.Size(123, 20);
            this.txtDataAtualizacao.TabIndex = 126;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(280, 172);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(503, 20);
            this.txtDescricao.TabIndex = 127;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(479, 128);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(135, 20);
            this.txtUsuario.TabIndex = 128;
            // 
            // lblSist
            // 
            this.lblSist.AutoSize = true;
            this.lblSist.Location = new System.Drawing.Point(133, 112);
            this.lblSist.Name = "lblSist";
            this.lblSist.Size = new System.Drawing.Size(44, 13);
            this.lblSist.TabIndex = 129;
            this.lblSist.Text = "Sistema";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(202, 112);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(55, 13);
            this.lblCategoria.TabIndex = 130;
            this.lblCategoria.Text = "Categoria:";
            // 
            // lblParametro
            // 
            this.lblParametro.AutoSize = true;
            this.lblParametro.Location = new System.Drawing.Point(136, 156);
            this.lblParametro.Name = "lblParametro";
            this.lblParametro.Size = new System.Drawing.Size(58, 13);
            this.lblParametro.TabIndex = 131;
            this.lblParametro.Text = "Parametro:";
            // 
            // lblDtAlt
            // 
            this.lblDtAlt.AutoSize = true;
            this.lblDtAlt.Location = new System.Drawing.Point(344, 112);
            this.lblDtAlt.Name = "lblDtAlt";
            this.lblDtAlt.Size = new System.Drawing.Size(103, 13);
            this.lblDtAlt.TabIndex = 132;
            this.lblDtAlt.Text = "Data deAtualização:";
            // 
            // lblUsu
            // 
            this.lblUsu.AutoSize = true;
            this.lblUsu.Location = new System.Drawing.Point(476, 112);
            this.lblUsu.Name = "lblUsu";
            this.lblUsu.Size = new System.Drawing.Size(46, 13);
            this.lblUsu.TabIndex = 133;
            this.lblUsu.Text = "Usuario:";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(279, 156);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(58, 13);
            this.lblDescricao.TabIndex = 134;
            this.lblDescricao.Text = "Descrição:";
            this.lblDescricao.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 136;
            this.label1.Text = "Conteudo:";
            // 
            // txtConteudo
            // 
            this.txtConteudo.Location = new System.Drawing.Point(195, 209);
            this.txtConteudo.Name = "txtConteudo";
            this.txtConteudo.Size = new System.Drawing.Size(588, 20);
            this.txtConteudo.TabIndex = 135;
            // 
            // Configuracao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(892, 499);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtConteudo);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblUsu);
            this.Controls.Add(this.lblDtAlt);
            this.Controls.Add(this.lblParametro);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblSist);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtDataAtualizacao);
            this.Controls.Add(this.txtParametro);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.txtSistema);
            this.Controls.Add(this.lblMsgErro);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonGravar);
            this.Controls.Add(this.RbConsultar);
            this.Controls.Add(this.RBAlterar);
            this.Controls.Add(this.gridParametros);
            this.Controls.Add(this.btnFechar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Configuracao";
            this.Text = "Configuracao";
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPesquisa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridParametros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox btnFechar;
        private System.Windows.Forms.Label lblMsgErro;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox btnPesquisa;
        private System.Windows.Forms.RadioButton RbNome;
        private System.Windows.Forms.RadioButton RbCodigo;
        private System.Windows.Forms.TextBox TxtPesquisa;
        private System.Windows.Forms.Button buttonGravar;
        private System.Windows.Forms.RadioButton RbConsultar;
        private System.Windows.Forms.RadioButton RBAlterar;
        private System.Windows.Forms.DataGridView gridParametros;
        private System.Windows.Forms.TextBox txtSistema;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.TextBox txtParametro;
        private System.Windows.Forms.TextBox txtDataAtualizacao;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblSist;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblParametro;
        private System.Windows.Forms.Label lblDtAlt;
        private System.Windows.Forms.Label lblUsu;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConteudo;
    }
}