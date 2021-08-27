namespace GestorImoveis.Forms
{
    partial class DigitalizacaoForm
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
            this.btnContrato = new System.Windows.Forms.Button();
            this.btnServico = new System.Windows.Forms.Button();
            this.btnEntragaChavesEntrada = new System.Windows.Forms.Button();
            this.btnEntregaChavesSaida = new System.Windows.Forms.Button();
            this.btnDocLocador = new System.Windows.Forms.Button();
            this.btnDocLocatario = new System.Windows.Forms.Button();
            this.btnRecibos = new System.Windows.Forms.Button();
            this.btnBoletos = new System.Windows.Forms.Button();
            this.btnOutro = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboContratos = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnContrato
            // 
            this.btnContrato.Location = new System.Drawing.Point(93, 111);
            this.btnContrato.Name = "btnContrato";
            this.btnContrato.Size = new System.Drawing.Size(176, 46);
            this.btnContrato.TabIndex = 0;
            this.btnContrato.Text = "Contrato";
            this.btnContrato.UseVisualStyleBackColor = true;
            this.btnContrato.Click += new System.EventHandler(this.btnContrato_Click);
            // 
            // btnServico
            // 
            this.btnServico.Location = new System.Drawing.Point(93, 206);
            this.btnServico.Name = "btnServico";
            this.btnServico.Size = new System.Drawing.Size(176, 46);
            this.btnServico.TabIndex = 1;
            this.btnServico.Text = "Contrato de Serviço";
            this.btnServico.UseVisualStyleBackColor = true;
            this.btnServico.Click += new System.EventHandler(this.btnServico_Click);
            // 
            // btnEntragaChavesEntrada
            // 
            this.btnEntragaChavesEntrada.Location = new System.Drawing.Point(93, 302);
            this.btnEntragaChavesEntrada.Name = "btnEntragaChavesEntrada";
            this.btnEntragaChavesEntrada.Size = new System.Drawing.Size(176, 46);
            this.btnEntragaChavesEntrada.TabIndex = 2;
            this.btnEntragaChavesEntrada.Text = "Entrega de Chaves - Entrada";
            this.btnEntragaChavesEntrada.UseVisualStyleBackColor = true;
            this.btnEntragaChavesEntrada.Click += new System.EventHandler(this.btnEntragaChavesEntrada_Click);
            // 
            // btnEntregaChavesSaida
            // 
            this.btnEntregaChavesSaida.Location = new System.Drawing.Point(362, 111);
            this.btnEntregaChavesSaida.Name = "btnEntregaChavesSaida";
            this.btnEntregaChavesSaida.Size = new System.Drawing.Size(176, 46);
            this.btnEntregaChavesSaida.TabIndex = 3;
            this.btnEntregaChavesSaida.Text = "Entrega de Chaves - Saida";
            this.btnEntregaChavesSaida.UseVisualStyleBackColor = true;
            this.btnEntregaChavesSaida.Click += new System.EventHandler(this.btnEntregaChavesSaida_Click);
            // 
            // btnDocLocador
            // 
            this.btnDocLocador.Location = new System.Drawing.Point(362, 206);
            this.btnDocLocador.Name = "btnDocLocador";
            this.btnDocLocador.Size = new System.Drawing.Size(176, 46);
            this.btnDocLocador.TabIndex = 4;
            this.btnDocLocador.Text = "Documentos Locador";
            this.btnDocLocador.UseVisualStyleBackColor = true;
            this.btnDocLocador.Click += new System.EventHandler(this.btnDocLocador_Click);
            // 
            // btnDocLocatario
            // 
            this.btnDocLocatario.Location = new System.Drawing.Point(362, 302);
            this.btnDocLocatario.Name = "btnDocLocatario";
            this.btnDocLocatario.Size = new System.Drawing.Size(176, 46);
            this.btnDocLocatario.TabIndex = 5;
            this.btnDocLocatario.Text = "Documentos Locatario";
            this.btnDocLocatario.UseVisualStyleBackColor = true;
            this.btnDocLocatario.Click += new System.EventHandler(this.btnDocLocatario_Click);
            // 
            // btnRecibos
            // 
            this.btnRecibos.Location = new System.Drawing.Point(615, 111);
            this.btnRecibos.Name = "btnRecibos";
            this.btnRecibos.Size = new System.Drawing.Size(176, 46);
            this.btnRecibos.TabIndex = 6;
            this.btnRecibos.Text = "Recibos";
            this.btnRecibos.UseVisualStyleBackColor = true;
            this.btnRecibos.Click += new System.EventHandler(this.btnRecibos_Click);
            // 
            // btnBoletos
            // 
            this.btnBoletos.Location = new System.Drawing.Point(615, 206);
            this.btnBoletos.Name = "btnBoletos";
            this.btnBoletos.Size = new System.Drawing.Size(176, 46);
            this.btnBoletos.TabIndex = 7;
            this.btnBoletos.Text = "Boletos";
            this.btnBoletos.UseVisualStyleBackColor = true;
            this.btnBoletos.Click += new System.EventHandler(this.btnBoletos_Click);
            // 
            // btnOutro
            // 
            this.btnOutro.Location = new System.Drawing.Point(615, 302);
            this.btnOutro.Name = "btnOutro";
            this.btnOutro.Size = new System.Drawing.Size(176, 46);
            this.btnOutro.TabIndex = 8;
            this.btnOutro.Text = "Outros";
            this.btnOutro.UseVisualStyleBackColor = true;
            this.btnOutro.Click += new System.EventHandler(this.btnOutro_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.Image = global::GestorImoveis.Properties.Resources.Close;
            this.btnFechar.Location = new System.Drawing.Point(857, 1);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(18, 18);
            this.btnFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnFechar.TabIndex = 84;
            this.btnFechar.TabStop = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 86;
            this.label1.Text = "Selecionar Contrato:";
            // 
            // cboContratos
            // 
            this.cboContratos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboContratos.FormattingEnabled = true;
            this.cboContratos.Location = new System.Drawing.Point(12, 31);
            this.cboContratos.Name = "cboContratos";
            this.cboContratos.Size = new System.Drawing.Size(167, 21);
            this.cboContratos.TabIndex = 85;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // DigitalizacaoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(876, 460);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboContratos);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnOutro);
            this.Controls.Add(this.btnBoletos);
            this.Controls.Add(this.btnRecibos);
            this.Controls.Add(this.btnDocLocatario);
            this.Controls.Add(this.btnDocLocador);
            this.Controls.Add(this.btnEntregaChavesSaida);
            this.Controls.Add(this.btnEntragaChavesEntrada);
            this.Controls.Add(this.btnServico);
            this.Controls.Add(this.btnContrato);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DigitalizacaoForm";
            this.Text = "DigitalizacaoForm";
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnContrato;
        private System.Windows.Forms.Button btnServico;
        private System.Windows.Forms.Button btnEntragaChavesEntrada;
        private System.Windows.Forms.Button btnEntregaChavesSaida;
        private System.Windows.Forms.Button btnDocLocador;
        private System.Windows.Forms.Button btnDocLocatario;
        private System.Windows.Forms.Button btnRecibos;
        private System.Windows.Forms.Button btnBoletos;
        private System.Windows.Forms.Button btnOutro;
        private System.Windows.Forms.PictureBox btnFechar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboContratos;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}