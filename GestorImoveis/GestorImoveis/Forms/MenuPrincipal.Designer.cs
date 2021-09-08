namespace GestorImoveis.Forms
{
    partial class MenuPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.PanelMenuVertical = new System.Windows.Forms.Panel();
            this.btnDigitalizacao = new System.Windows.Forms.Button();
            this.btnRelatorios = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.btnAnuncios = new System.Windows.Forms.Button();
            this.btnConfig = new System.Windows.Forms.Button();
            this.btnBoletos = new System.Windows.Forms.Button();
            this.btnCadContratos = new System.Windows.Forms.Button();
            this.btnCadCliente = new System.Windows.Forms.Button();
            this.PanelBarraTitulo = new System.Windows.Forms.Panel();
            this.PictureMinimized = new System.Windows.Forms.PictureBox();
            this.picture_Maximize = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.btnslide = new System.Windows.Forms.PictureBox();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.MenuNotificacoes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmi_Restaurar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.TimerNotificacao = new System.Windows.Forms.Timer(this.components);
            this.PanelMenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.PanelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureMinimized)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_Maximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnslide)).BeginInit();
            this.MenuNotificacoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMenuVertical
            // 
            this.PanelMenuVertical.BackColor = System.Drawing.Color.BlueViolet;
            this.PanelMenuVertical.Controls.Add(this.btnDigitalizacao);
            this.PanelMenuVertical.Controls.Add(this.btnRelatorios);
            this.PanelMenuVertical.Controls.Add(this.btnHome);
            this.PanelMenuVertical.Controls.Add(this.btnAnuncios);
            this.PanelMenuVertical.Controls.Add(this.btnConfig);
            this.PanelMenuVertical.Controls.Add(this.btnBoletos);
            this.PanelMenuVertical.Controls.Add(this.btnCadContratos);
            this.PanelMenuVertical.Controls.Add(this.btnCadCliente);
            this.PanelMenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenuVertical.Location = new System.Drawing.Point(0, 0);
            this.PanelMenuVertical.Name = "PanelMenuVertical";
            this.PanelMenuVertical.Size = new System.Drawing.Size(200, 548);
            this.PanelMenuVertical.TabIndex = 0;
            this.PanelMenuVertical.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelMenuVertical_Paint);
            // 
            // btnDigitalizacao
            // 
            this.btnDigitalizacao.BackColor = System.Drawing.Color.BlueViolet;
            this.btnDigitalizacao.FlatAppearance.BorderColor = System.Drawing.Color.BlueViolet;
            this.btnDigitalizacao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnDigitalizacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDigitalizacao.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDigitalizacao.ForeColor = System.Drawing.Color.Transparent;
            this.btnDigitalizacao.Image = global::GestorImoveis.Properties.Resources.pdf_48;
            this.btnDigitalizacao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDigitalizacao.Location = new System.Drawing.Point(0, 393);
            this.btnDigitalizacao.Name = "btnDigitalizacao";
            this.btnDigitalizacao.Size = new System.Drawing.Size(200, 60);
            this.btnDigitalizacao.TabIndex = 8;
            this.btnDigitalizacao.Text = "Digitalização ";
            this.btnDigitalizacao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDigitalizacao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDigitalizacao.UseVisualStyleBackColor = true;
            this.btnDigitalizacao.Click += new System.EventHandler(this.btnDigitalizacao_Click);
            // 
            // btnRelatorios
            // 
            this.btnRelatorios.BackColor = System.Drawing.Color.BlueViolet;
            this.btnRelatorios.FlatAppearance.BorderColor = System.Drawing.Color.BlueViolet;
            this.btnRelatorios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnRelatorios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorios.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorios.ForeColor = System.Drawing.Color.Transparent;
            this.btnRelatorios.Image = global::GestorImoveis.Properties.Resources.report_icon_48px;
            this.btnRelatorios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRelatorios.Location = new System.Drawing.Point(0, 328);
            this.btnRelatorios.Name = "btnRelatorios";
            this.btnRelatorios.Size = new System.Drawing.Size(200, 61);
            this.btnRelatorios.TabIndex = 7;
            this.btnRelatorios.Text = "Relatorios";
            this.btnRelatorios.UseVisualStyleBackColor = false;
            this.btnRelatorios.Click += new System.EventHandler(this.btnRelatorios_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackgroundImage = global::GestorImoveis.Properties.Resources.G_Logo_icon_48px;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(53, 72);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 6;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnAnuncios
            // 
            this.btnAnuncios.BackColor = System.Drawing.Color.BlueViolet;
            this.btnAnuncios.FlatAppearance.BorderColor = System.Drawing.Color.BlueViolet;
            this.btnAnuncios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnAnuncios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnuncios.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnuncios.ForeColor = System.Drawing.Color.Transparent;
            this.btnAnuncios.Image = global::GestorImoveis.Properties.Resources.Anuncios_Icon_48px;
            this.btnAnuncios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnuncios.Location = new System.Drawing.Point(0, 270);
            this.btnAnuncios.Name = "btnAnuncios";
            this.btnAnuncios.Size = new System.Drawing.Size(200, 51);
            this.btnAnuncios.TabIndex = 5;
            this.btnAnuncios.Text = "Anuncios";
            this.btnAnuncios.UseVisualStyleBackColor = false;
            this.btnAnuncios.Click += new System.EventHandler(this.btnAnuncios_Click);
            // 
            // btnConfig
            // 
            this.btnConfig.BackColor = System.Drawing.Color.BlueViolet;
            this.btnConfig.FlatAppearance.BorderColor = System.Drawing.Color.BlueViolet;
            this.btnConfig.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfig.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfig.ForeColor = System.Drawing.Color.Transparent;
            this.btnConfig.Image = global::GestorImoveis.Properties.Resources.settings_Icon_48Px;
            this.btnConfig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfig.Location = new System.Drawing.Point(0, 454);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(200, 60);
            this.btnConfig.TabIndex = 4;
            this.btnConfig.Text = "Configurações";
            this.btnConfig.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfig.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // btnBoletos
            // 
            this.btnBoletos.BackColor = System.Drawing.Color.BlueViolet;
            this.btnBoletos.FlatAppearance.BorderColor = System.Drawing.Color.BlueViolet;
            this.btnBoletos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnBoletos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBoletos.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoletos.ForeColor = System.Drawing.Color.Transparent;
            this.btnBoletos.Image = global::GestorImoveis.Properties.Resources.money_Icon_48px;
            this.btnBoletos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBoletos.Location = new System.Drawing.Point(0, 213);
            this.btnBoletos.Name = "btnBoletos";
            this.btnBoletos.Size = new System.Drawing.Size(200, 51);
            this.btnBoletos.TabIndex = 3;
            this.btnBoletos.Text = "Boletos";
            this.btnBoletos.UseVisualStyleBackColor = false;
            this.btnBoletos.Click += new System.EventHandler(this.btnBoletos_Click);
            // 
            // btnCadContratos
            // 
            this.btnCadContratos.BackColor = System.Drawing.Color.BlueViolet;
            this.btnCadContratos.FlatAppearance.BorderColor = System.Drawing.Color.BlueViolet;
            this.btnCadContratos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnCadContratos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadContratos.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadContratos.ForeColor = System.Drawing.Color.Transparent;
            this.btnCadContratos.Image = global::GestorImoveis.Properties.Resources.Contract_icon_48px;
            this.btnCadContratos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadContratos.Location = new System.Drawing.Point(0, 142);
            this.btnCadContratos.Name = "btnCadContratos";
            this.btnCadContratos.Size = new System.Drawing.Size(200, 65);
            this.btnCadContratos.TabIndex = 2;
            this.btnCadContratos.Text = "Contratos";
            this.btnCadContratos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadContratos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadContratos.UseVisualStyleBackColor = true;
            this.btnCadContratos.Click += new System.EventHandler(this.btnCadContratos_Click);
            // 
            // btnCadCliente
            // 
            this.btnCadCliente.BackColor = System.Drawing.Color.BlueViolet;
            this.btnCadCliente.FlatAppearance.BorderColor = System.Drawing.Color.BlueViolet;
            this.btnCadCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnCadCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadCliente.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadCliente.ForeColor = System.Drawing.Color.White;
            this.btnCadCliente.Image = global::GestorImoveis.Properties.Resources.group_Users_Icon_48px;
            this.btnCadCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadCliente.Location = new System.Drawing.Point(0, 78);
            this.btnCadCliente.Name = "btnCadCliente";
            this.btnCadCliente.Size = new System.Drawing.Size(200, 58);
            this.btnCadCliente.TabIndex = 1;
            this.btnCadCliente.Text = "Cliente";
            this.btnCadCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadCliente.UseVisualStyleBackColor = true;
            this.btnCadCliente.Click += new System.EventHandler(this.btnCadCliente_Click);
            // 
            // PanelBarraTitulo
            // 
            this.PanelBarraTitulo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PanelBarraTitulo.Controls.Add(this.PictureMinimized);
            this.PanelBarraTitulo.Controls.Add(this.picture_Maximize);
            this.PanelBarraTitulo.Controls.Add(this.btnExit);
            this.PanelBarraTitulo.Controls.Add(this.btnslide);
            this.PanelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelBarraTitulo.Location = new System.Drawing.Point(200, 0);
            this.PanelBarraTitulo.Name = "PanelBarraTitulo";
            this.PanelBarraTitulo.Size = new System.Drawing.Size(892, 49);
            this.PanelBarraTitulo.TabIndex = 1;
            this.PanelBarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelBarraTitulo_MouseDown);
            // 
            // PictureMinimized
            // 
            this.PictureMinimized.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureMinimized.Image = global::GestorImoveis.Properties.Resources.minimize;
            this.PictureMinimized.Location = new System.Drawing.Point(805, 0);
            this.PictureMinimized.Name = "PictureMinimized";
            this.PictureMinimized.Size = new System.Drawing.Size(25, 25);
            this.PictureMinimized.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureMinimized.TabIndex = 3;
            this.PictureMinimized.TabStop = false;
            this.PictureMinimized.Click += new System.EventHandler(this.PictureMinimized_Click);
            // 
            // picture_Maximize
            // 
            this.picture_Maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picture_Maximize.Image = global::GestorImoveis.Properties.Resources._32minimize_84242__2_;
            this.picture_Maximize.Location = new System.Drawing.Point(836, 0);
            this.picture_Maximize.Name = "picture_Maximize";
            this.picture_Maximize.Size = new System.Drawing.Size(25, 25);
            this.picture_Maximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_Maximize.TabIndex = 2;
            this.picture_Maximize.TabStop = false;
            this.picture_Maximize.Click += new System.EventHandler(this.picture_Maximize_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Image = global::GestorImoveis.Properties.Resources.Close;
            this.btnExit.Location = new System.Drawing.Point(867, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(25, 25);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 1;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnslide
            // 
            this.btnslide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnslide.Image = global::GestorImoveis.Properties.Resources.Mobile_Menu_Icon;
            this.btnslide.Location = new System.Drawing.Point(3, 8);
            this.btnslide.Name = "btnslide";
            this.btnslide.Size = new System.Drawing.Size(43, 35);
            this.btnslide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnslide.TabIndex = 0;
            this.btnslide.TabStop = false;
            this.btnslide.Click += new System.EventHandler(this.btnslide_Click);
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.AutoSize = true;
            this.PanelContenedor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedor.Location = new System.Drawing.Point(200, 49);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(892, 499);
            this.PanelContenedor.TabIndex = 2;
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.MenuNotificacoes;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Gestor Imoveis";
            this.notifyIcon.Visible = true;
            // 
            // MenuNotificacoes
            // 
            this.MenuNotificacoes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Restaurar,
            this.tsmi_Exit});
            this.MenuNotificacoes.Name = "contextMenuStrip2";
            this.MenuNotificacoes.Size = new System.Drawing.Size(124, 48);
            this.MenuNotificacoes.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuNotificacoes_ItemClicked);
            // 
            // tsmi_Restaurar
            // 
            this.tsmi_Restaurar.Name = "tsmi_Restaurar";
            this.tsmi_Restaurar.Size = new System.Drawing.Size(123, 22);
            this.tsmi_Restaurar.Text = "Restaurar";
            // 
            // tsmi_Exit
            // 
            this.tsmi_Exit.Name = "tsmi_Exit";
            this.tsmi_Exit.Size = new System.Drawing.Size(123, 22);
            this.tsmi_Exit.Text = "Exit";
            // 
            // TimerNotificacao
            // 
            this.TimerNotificacao.Enabled = true;
            this.TimerNotificacao.Interval = 1000;
            this.TimerNotificacao.Tick += new System.EventHandler(this.TimerNotificacao_Tick);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 548);
            this.Controls.Add(this.PanelContenedor);
            this.Controls.Add(this.PanelBarraTitulo);
            this.Controls.Add(this.PanelMenuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuPrincipal";
            this.Text = "Menucs";
            this.PanelMenuVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.PanelBarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureMinimized)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_Maximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnslide)).EndInit();
            this.MenuNotificacoes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelMenuVertical;
        private System.Windows.Forms.Button btnCadContratos;
        private System.Windows.Forms.Button btnCadCliente;
        private System.Windows.Forms.Panel PanelBarraTitulo;
        private System.Windows.Forms.PictureBox btnslide;
        private System.Windows.Forms.Panel PanelContenedor;
        private System.Windows.Forms.PictureBox btnExit;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Button btnBoletos;
        private System.Windows.Forms.Button btnAnuncios;
        private System.Windows.Forms.PictureBox PictureMinimized;
        private System.Windows.Forms.PictureBox picture_Maximize;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Button btnRelatorios;
        private System.Windows.Forms.Button btnDigitalizacao;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip MenuNotificacoes;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Restaurar;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Exit;
        private System.Windows.Forms.Timer TimerNotificacao;
    }
}