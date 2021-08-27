namespace GestorImoveis
{
    partial class UcRelListaClientes
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
            this.Rb_CPF = new System.Windows.Forms.RadioButton();
            this.cbo_Pesq = new System.Windows.Forms.ComboBox();
            this.txt_Pesq = new System.Windows.Forms.TextBox();
            this.Rb_Nome = new System.Windows.Forms.RadioButton();
            this.Rb_Tipo = new System.Windows.Forms.RadioButton();
            this.Rb_Codigo = new System.Windows.Forms.RadioButton();
            this.btn_Gerar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Rb_CPF);
            this.groupBox1.Controls.Add(this.cbo_Pesq);
            this.groupBox1.Controls.Add(this.txt_Pesq);
            this.groupBox1.Controls.Add(this.Rb_Nome);
            this.groupBox1.Controls.Add(this.Rb_Tipo);
            this.groupBox1.Controls.Add(this.Rb_Codigo);
            this.groupBox1.Controls.Add(this.btn_Gerar);
            this.groupBox1.Location = new System.Drawing.Point(17, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(855, 340);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // Rb_CPF
            // 
            this.Rb_CPF.AutoSize = true;
            this.Rb_CPF.Location = new System.Drawing.Point(543, 83);
            this.Rb_CPF.Name = "Rb_CPF";
            this.Rb_CPF.Size = new System.Drawing.Size(45, 17);
            this.Rb_CPF.TabIndex = 19;
            this.Rb_CPF.TabStop = true;
            this.Rb_CPF.Text = "CPF";
            this.Rb_CPF.UseVisualStyleBackColor = true;
            this.Rb_CPF.CheckedChanged += new System.EventHandler(this.Rb_PF_CheckedChanged);
            // 
            // cbo_Pesq
            // 
            this.cbo_Pesq.FormattingEnabled = true;
            this.cbo_Pesq.Location = new System.Drawing.Point(341, 131);
            this.cbo_Pesq.Name = "cbo_Pesq";
            this.cbo_Pesq.Size = new System.Drawing.Size(189, 21);
            this.cbo_Pesq.TabIndex = 18;
            // 
            // txt_Pesq
            // 
            this.txt_Pesq.Location = new System.Drawing.Point(341, 132);
            this.txt_Pesq.Name = "txt_Pesq";
            this.txt_Pesq.Size = new System.Drawing.Size(189, 20);
            this.txt_Pesq.TabIndex = 17;
            // 
            // Rb_Nome
            // 
            this.Rb_Nome.AutoSize = true;
            this.Rb_Nome.Location = new System.Drawing.Point(471, 83);
            this.Rb_Nome.Name = "Rb_Nome";
            this.Rb_Nome.Size = new System.Drawing.Size(53, 17);
            this.Rb_Nome.TabIndex = 16;
            this.Rb_Nome.TabStop = true;
            this.Rb_Nome.Text = "Nome";
            this.Rb_Nome.UseVisualStyleBackColor = true;
            this.Rb_Nome.CheckedChanged += new System.EventHandler(this.Rb_Nome_CheckedChanged);
            // 
            // Rb_Tipo
            // 
            this.Rb_Tipo.AutoSize = true;
            this.Rb_Tipo.Location = new System.Drawing.Point(374, 83);
            this.Rb_Tipo.Name = "Rb_Tipo";
            this.Rb_Tipo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Rb_Tipo.Size = new System.Drawing.Size(81, 17);
            this.Rb_Tipo.TabIndex = 15;
            this.Rb_Tipo.TabStop = true;
            this.Rb_Tipo.Text = "Tipo Cliente";
            this.Rb_Tipo.UseVisualStyleBackColor = true;
            this.Rb_Tipo.CheckedChanged += new System.EventHandler(this.Rb_Tipo_CheckedChanged);
            // 
            // Rb_Codigo
            // 
            this.Rb_Codigo.AutoSize = true;
            this.Rb_Codigo.Location = new System.Drawing.Point(308, 83);
            this.Rb_Codigo.Name = "Rb_Codigo";
            this.Rb_Codigo.Size = new System.Drawing.Size(58, 17);
            this.Rb_Codigo.TabIndex = 14;
            this.Rb_Codigo.TabStop = true;
            this.Rb_Codigo.Text = "Codigo";
            this.Rb_Codigo.UseVisualStyleBackColor = true;
            this.Rb_Codigo.CheckedChanged += new System.EventHandler(this.Rb_Codigo_CheckedChanged);
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
            // UcRelListaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "UcRelListaClientes";
            this.Size = new System.Drawing.Size(889, 400);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbo_Pesq;
        private System.Windows.Forms.TextBox txt_Pesq;
        private System.Windows.Forms.RadioButton Rb_Nome;
        private System.Windows.Forms.RadioButton Rb_Tipo;
        private System.Windows.Forms.RadioButton Rb_Codigo;
        private System.Windows.Forms.Button btn_Gerar;
        private System.Windows.Forms.RadioButton Rb_CPF;
    }
}
