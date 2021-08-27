namespace GestorImoveis
{
    partial class UcListaAnuncio
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Gerar = new System.Windows.Forms.Button();
            this.Rb_Regiao = new System.Windows.Forms.RadioButton();
            this.Rb_Codigo = new System.Windows.Forms.RadioButton();
            this.Rb_Prop = new System.Windows.Forms.RadioButton();
            this.Rb_TipoImovel = new System.Windows.Forms.RadioButton();
            this.txt_Pesq = new System.Windows.Forms.TextBox();
            this.cbo_Pesq = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbo_Pesq);
            this.groupBox1.Controls.Add(this.txt_Pesq);
            this.groupBox1.Controls.Add(this.Rb_TipoImovel);
            this.groupBox1.Controls.Add(this.Rb_Prop);
            this.groupBox1.Controls.Add(this.Rb_Codigo);
            this.groupBox1.Controls.Add(this.Rb_Regiao);
            this.groupBox1.Controls.Add(this.btn_Gerar);
            this.groupBox1.Location = new System.Drawing.Point(16, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(855, 340);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btn_Gerar
            // 
            this.btn_Gerar.Location = new System.Drawing.Point(376, 299);
            this.btn_Gerar.Name = "btn_Gerar";
            this.btn_Gerar.Size = new System.Drawing.Size(128, 23);
            this.btn_Gerar.TabIndex = 12;
            this.btn_Gerar.Text = "Gerar";
            this.btn_Gerar.UseVisualStyleBackColor = true;
            this.btn_Gerar.Click += new System.EventHandler(this.btn_Gerar_Click);
            // 
            // Rb_Regiao
            // 
            this.Rb_Regiao.AutoSize = true;
            this.Rb_Regiao.Location = new System.Drawing.Point(235, 79);
            this.Rb_Regiao.Name = "Rb_Regiao";
            this.Rb_Regiao.Size = new System.Drawing.Size(59, 17);
            this.Rb_Regiao.TabIndex = 13;
            this.Rb_Regiao.TabStop = true;
            this.Rb_Regiao.Text = "Região";
            this.Rb_Regiao.UseVisualStyleBackColor = true;
            this.Rb_Regiao.CheckedChanged += new System.EventHandler(this.Rb_Regiao_CheckedChanged);
            // 
            // Rb_Codigo
            // 
            this.Rb_Codigo.AutoSize = true;
            this.Rb_Codigo.Location = new System.Drawing.Point(326, 79);
            this.Rb_Codigo.Name = "Rb_Codigo";
            this.Rb_Codigo.Size = new System.Drawing.Size(58, 17);
            this.Rb_Codigo.TabIndex = 14;
            this.Rb_Codigo.TabStop = true;
            this.Rb_Codigo.Text = "Codigo";
            this.Rb_Codigo.UseVisualStyleBackColor = true;
            this.Rb_Codigo.CheckedChanged += new System.EventHandler(this.Rb_Codigo_CheckedChanged);
            // 
            // Rb_Prop
            // 
            this.Rb_Prop.AutoSize = true;
            this.Rb_Prop.Location = new System.Drawing.Point(419, 79);
            this.Rb_Prop.Name = "Rb_Prop";
            this.Rb_Prop.Size = new System.Drawing.Size(78, 17);
            this.Rb_Prop.TabIndex = 15;
            this.Rb_Prop.TabStop = true;
            this.Rb_Prop.Text = "Proprietario";
            this.Rb_Prop.UseVisualStyleBackColor = true;
            this.Rb_Prop.CheckedChanged += new System.EventHandler(this.Rb_Prop_CheckedChanged);
            // 
            // Rb_TipoImovel
            // 
            this.Rb_TipoImovel.AutoSize = true;
            this.Rb_TipoImovel.Location = new System.Drawing.Point(536, 79);
            this.Rb_TipoImovel.Name = "Rb_TipoImovel";
            this.Rb_TipoImovel.Size = new System.Drawing.Size(94, 17);
            this.Rb_TipoImovel.TabIndex = 16;
            this.Rb_TipoImovel.TabStop = true;
            this.Rb_TipoImovel.Text = "Tipo de imovel";
            this.Rb_TipoImovel.UseVisualStyleBackColor = true;
            this.Rb_TipoImovel.CheckedChanged += new System.EventHandler(this.Rb_TipoImovel_CheckedChanged);
            // 
            // txt_Pesq
            // 
            this.txt_Pesq.Location = new System.Drawing.Point(341, 132);
            this.txt_Pesq.Name = "txt_Pesq";
            this.txt_Pesq.Size = new System.Drawing.Size(189, 20);
            this.txt_Pesq.TabIndex = 17;
            // 
            // cbo_Pesq
            // 
            this.cbo_Pesq.FormattingEnabled = true;
            this.cbo_Pesq.Location = new System.Drawing.Point(341, 132);
            this.cbo_Pesq.Name = "cbo_Pesq";
            this.cbo_Pesq.Size = new System.Drawing.Size(189, 21);
            this.cbo_Pesq.TabIndex = 18;
            // 
            // UcListaAnuncio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "UcListaAnuncio";
            this.Size = new System.Drawing.Size(889, 400);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Gerar;
        private System.Windows.Forms.ComboBox cbo_Pesq;
        private System.Windows.Forms.TextBox txt_Pesq;
        private System.Windows.Forms.RadioButton Rb_TipoImovel;
        private System.Windows.Forms.RadioButton Rb_Prop;
        private System.Windows.Forms.RadioButton Rb_Codigo;
        private System.Windows.Forms.RadioButton Rb_Regiao;
    }
}
