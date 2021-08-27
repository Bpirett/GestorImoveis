namespace GestorImoveis.Forms
{
    partial class UploadImageForm
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
            this.listImages = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.PictureBox();
            this.lblanunciodesc = new System.Windows.Forms.Label();
            this.lblCodAnuncio = new System.Windows.Forms.Label();
            this.rdbGrandes = new System.Windows.Forms.RadioButton();
            this.rdbPequenos = new System.Windows.Forms.RadioButton();
            this.rdbLista = new System.Windows.Forms.RadioButton();
            this.rdbLadoLado = new System.Windows.Forms.RadioButton();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnGravar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.lblDescSelecionada = new System.Windows.Forms.Label();
            this.lblcontadorSelecionadas = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).BeginInit();
            this.SuspendLayout();
            // 
            // listImages
            // 
            this.listImages.HideSelection = false;
            this.listImages.Location = new System.Drawing.Point(0, 111);
            this.listImages.Name = "listImages";
            this.listImages.Size = new System.Drawing.Size(604, 254);
            this.listImages.TabIndex = 0;
            this.listImages.UseCompatibleStateImageBehavior = false;
            this.listImages.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.listImages_AfterLabelEdit);
            this.listImages.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listImages_MouseClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnFechar);
            this.panel1.Controls.Add(this.lblanunciodesc);
            this.panel1.Controls.Add(this.lblCodAnuncio);
            this.panel1.Controls.Add(this.rdbGrandes);
            this.panel1.Controls.Add(this.rdbPequenos);
            this.panel1.Controls.Add(this.rdbLista);
            this.panel1.Controls.Add(this.rdbLadoLado);
            this.panel1.Controls.Add(this.btnSelecionar);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(604, 82);
            this.panel1.TabIndex = 1;
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.Image = global::GestorImoveis.Properties.Resources.Close;
            this.btnFechar.Location = new System.Drawing.Point(583, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(18, 18);
            this.btnFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnFechar.TabIndex = 119;
            this.btnFechar.TabStop = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lblanunciodesc
            // 
            this.lblanunciodesc.AutoSize = true;
            this.lblanunciodesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblanunciodesc.ForeColor = System.Drawing.Color.SlateBlue;
            this.lblanunciodesc.Location = new System.Drawing.Point(0, 4);
            this.lblanunciodesc.Name = "lblanunciodesc";
            this.lblanunciodesc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblanunciodesc.Size = new System.Drawing.Size(80, 16);
            this.lblanunciodesc.TabIndex = 6;
            this.lblanunciodesc.Text = "ANUNCIO:";
            // 
            // lblCodAnuncio
            // 
            this.lblCodAnuncio.AutoSize = true;
            this.lblCodAnuncio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodAnuncio.Location = new System.Drawing.Point(21, 23);
            this.lblCodAnuncio.Name = "lblCodAnuncio";
            this.lblCodAnuncio.Size = new System.Drawing.Size(11, 16);
            this.lblCodAnuncio.TabIndex = 5;
            this.lblCodAnuncio.Text = ".";
            // 
            // rdbGrandes
            // 
            this.rdbGrandes.AutoSize = true;
            this.rdbGrandes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbGrandes.Location = new System.Drawing.Point(229, 45);
            this.rdbGrandes.Name = "rdbGrandes";
            this.rdbGrandes.Size = new System.Drawing.Size(141, 24);
            this.rdbGrandes.TabIndex = 1;
            this.rdbGrandes.TabStop = true;
            this.rdbGrandes.Text = "Ícones Grandes";
            this.rdbGrandes.UseVisualStyleBackColor = true;
            this.rdbGrandes.CheckedChanged += new System.EventHandler(this.rdbGrandes_CheckedChanged_1);
            // 
            // rdbPequenos
            // 
            this.rdbPequenos.AutoSize = true;
            this.rdbPequenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPequenos.Location = new System.Drawing.Point(229, 15);
            this.rdbPequenos.Name = "rdbPequenos";
            this.rdbPequenos.Size = new System.Drawing.Size(151, 24);
            this.rdbPequenos.TabIndex = 2;
            this.rdbPequenos.TabStop = true;
            this.rdbPequenos.Text = "Ícones Pequenos";
            this.rdbPequenos.UseVisualStyleBackColor = true;
            this.rdbPequenos.CheckedChanged += new System.EventHandler(this.rdbPequenos_CheckedChanged_1);
            // 
            // rdbLista
            // 
            this.rdbLista.AutoSize = true;
            this.rdbLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbLista.Location = new System.Drawing.Point(107, 45);
            this.rdbLista.Name = "rdbLista";
            this.rdbLista.Size = new System.Drawing.Size(61, 24);
            this.rdbLista.TabIndex = 3;
            this.rdbLista.TabStop = true;
            this.rdbLista.Text = "Lista";
            this.rdbLista.UseVisualStyleBackColor = true;
            this.rdbLista.CheckedChanged += new System.EventHandler(this.rdbLista_CheckedChanged_1);
            // 
            // rdbLadoLado
            // 
            this.rdbLadoLado.AutoSize = true;
            this.rdbLadoLado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbLadoLado.Location = new System.Drawing.Point(107, 15);
            this.rdbLadoLado.Name = "rdbLadoLado";
            this.rdbLadoLado.Size = new System.Drawing.Size(116, 24);
            this.rdbLadoLado.TabIndex = 4;
            this.rdbLadoLado.TabStop = true;
            this.rdbLadoLado.Text = "Lado a Lado";
            this.rdbLadoLado.UseVisualStyleBackColor = true;
            this.rdbLadoLado.CheckedChanged += new System.EventHandler(this.rdbLadoLado_CheckedChanged_1);
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.BackColor = System.Drawing.Color.SlateBlue;
            this.btnSelecionar.FlatAppearance.BorderColor = System.Drawing.Color.SlateBlue;
            this.btnSelecionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelecionar.ForeColor = System.Drawing.Color.White;
            this.btnSelecionar.Location = new System.Drawing.Point(436, 29);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(143, 32);
            this.btnSelecionar.TabIndex = 0;
            this.btnSelecionar.Text = "Selecionar Imagens";
            this.btnSelecionar.UseVisualStyleBackColor = false;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(157, 380);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(129, 23);
            this.btnGravar.TabIndex = 2;
            this.btnGravar.Text = "Salvar Imagens";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Location = new System.Drawing.Point(311, 380);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(129, 23);
            this.BtnExcluir.TabIndex = 3;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // lblDescSelecionada
            // 
            this.lblDescSelecionada.AutoSize = true;
            this.lblDescSelecionada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescSelecionada.Location = new System.Drawing.Point(3, 89);
            this.lblDescSelecionada.Name = "lblDescSelecionada";
            this.lblDescSelecionada.Size = new System.Drawing.Size(148, 16);
            this.lblDescSelecionada.TabIndex = 4;
            this.lblDescSelecionada.Text = "Imagens selecionadas:";
            // 
            // lblcontadorSelecionadas
            // 
            this.lblcontadorSelecionadas.AutoSize = true;
            this.lblcontadorSelecionadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcontadorSelecionadas.Location = new System.Drawing.Point(146, 90);
            this.lblcontadorSelecionadas.Name = "lblcontadorSelecionadas";
            this.lblcontadorSelecionadas.Size = new System.Drawing.Size(22, 16);
            this.lblcontadorSelecionadas.TabIndex = 5;
            this.lblcontadorSelecionadas.Text = "00";
            // 
            // UploadImageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(604, 415);
            this.Controls.Add(this.lblcontadorSelecionadas);
            this.Controls.Add(this.lblDescSelecionada);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.listImages);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UploadImageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UploadImageForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UploadImageForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UploadImageForm_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UploadImageForm_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listImages;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdbGrandes;
        private System.Windows.Forms.RadioButton rdbPequenos;
        private System.Windows.Forms.RadioButton rdbLista;
        private System.Windows.Forms.RadioButton rdbLadoLado;
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Label lblDescSelecionada;
        private System.Windows.Forms.Label lblcontadorSelecionadas;
        private System.Windows.Forms.Label lblCodAnuncio;
        private System.Windows.Forms.Label lblanunciodesc;
        private System.Windows.Forms.PictureBox btnFechar;
    }
}