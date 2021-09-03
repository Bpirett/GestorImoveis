namespace GestorImoveis.Forms
{
    partial class RelatoriosForms
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
            this.cboRelatorio = new System.Windows.Forms.ComboBox();
            this.ucRelBoletos1 = new GestorImoveis.UcRelBoletos();
            this.ucRelContratos1 = new GestorImoveis.UcRelContratos();
            this.ucListaAnuncio1 = new GestorImoveis.UcListaAnuncio();
            this.ucRelListaClientes1 = new GestorImoveis.UcRelListaClientes();
            this.SuspendLayout();
            // 
            // cboRelatorio
            // 
            this.cboRelatorio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboRelatorio.FormattingEnabled = true;
            this.cboRelatorio.Location = new System.Drawing.Point(12, 29);
            this.cboRelatorio.Name = "cboRelatorio";
            this.cboRelatorio.Size = new System.Drawing.Size(190, 21);
            this.cboRelatorio.TabIndex = 0;
            this.cboRelatorio.SelectedIndexChanged += new System.EventHandler(this.cboRelatorio_SelectedIndexChanged);
            // 
            // ucRelBoletos1
            // 
            this.ucRelBoletos1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ucRelBoletos1.Location = new System.Drawing.Point(2, 69);
            this.ucRelBoletos1.Name = "ucRelBoletos1";
            this.ucRelBoletos1.Size = new System.Drawing.Size(889, 400);
            this.ucRelBoletos1.TabIndex = 3;
            // 
            // ucRelContratos1
            // 
            this.ucRelContratos1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ucRelContratos1.Location = new System.Drawing.Point(2, 67);
            this.ucRelContratos1.Name = "ucRelContratos1";
            this.ucRelContratos1.Size = new System.Drawing.Size(889, 400);
            this.ucRelContratos1.TabIndex = 2;
            // 
            // ucListaAnuncio1
            // 
            this.ucListaAnuncio1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ucListaAnuncio1.Location = new System.Drawing.Point(2, 56);
            this.ucListaAnuncio1.Name = "ucListaAnuncio1";
            this.ucListaAnuncio1.Size = new System.Drawing.Size(889, 400);
            this.ucListaAnuncio1.TabIndex = 0;
            // 
            // ucRelListaClientes1
            // 
            this.ucRelListaClientes1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ucRelListaClientes1.Location = new System.Drawing.Point(2, 56);
            this.ucRelListaClientes1.Name = "ucRelListaClientes1";
            this.ucRelListaClientes1.Size = new System.Drawing.Size(889, 444);
            this.ucRelListaClientes1.TabIndex = 1;
            // 
            // RelatoriosForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(892, 499);
            this.Controls.Add(this.ucRelBoletos1);
            this.Controls.Add(this.ucRelContratos1);
            this.Controls.Add(this.ucListaAnuncio1);
            this.Controls.Add(this.cboRelatorio);
            this.Controls.Add(this.ucRelListaClientes1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RelatoriosForms";
            this.Text = "RelatoriosForms";
            this.Load += new System.EventHandler(this.RelatoriosForms_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboRelatorio;
        private UcListaAnuncio ucListaAnuncio1;
        private UcRelListaClientes ucRelListaClientes1;
        private UcRelContratos ucRelContratos1;
        private UcRelBoletos ucRelBoletos1;
    }
}