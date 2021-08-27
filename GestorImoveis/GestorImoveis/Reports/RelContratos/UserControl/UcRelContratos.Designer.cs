namespace GestorImoveis
{
    partial class UcRelContratos
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
            this.cbo_Pesq = new System.Windows.Forms.ComboBox();
            this.btn_Gerar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbo_Pesq);
            this.groupBox1.Controls.Add(this.btn_Gerar);
            this.groupBox1.Location = new System.Drawing.Point(17, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(855, 340);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // cbo_Pesq
            // 
            this.cbo_Pesq.FormattingEnabled = true;
            this.cbo_Pesq.Location = new System.Drawing.Point(341, 129);
            this.cbo_Pesq.Name = "cbo_Pesq";
            this.cbo_Pesq.Size = new System.Drawing.Size(189, 21);
            this.cbo_Pesq.TabIndex = 18;
            // 
            // btn_Gerar
            // 
            this.btn_Gerar.Location = new System.Drawing.Point(376, 263);
            this.btn_Gerar.Name = "btn_Gerar";
            this.btn_Gerar.Size = new System.Drawing.Size(128, 23);
            this.btn_Gerar.TabIndex = 12;
            this.btn_Gerar.Text = "Gerar";
            this.btn_Gerar.UseVisualStyleBackColor = true;
            this.btn_Gerar.Click += new System.EventHandler(this.btn_Gerar_Click);
            // 
            // UcRelContratos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "UcRelContratos";
            this.Size = new System.Drawing.Size(889, 400);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbo_Pesq;
        private System.Windows.Forms.Button btn_Gerar;
    }
}
