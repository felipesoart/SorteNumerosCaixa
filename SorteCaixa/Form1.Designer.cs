namespace SorteCaixa
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSorteioSemanal = new System.Windows.Forms.Button();
            this.lblNumerosSistema = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox3 = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // btnSorteioSemanal
            // 
            this.btnSorteioSemanal.Location = new System.Drawing.Point(250, 38);
            this.btnSorteioSemanal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSorteioSemanal.Name = "btnSorteioSemanal";
            this.btnSorteioSemanal.Size = new System.Drawing.Size(144, 34);
            this.btnSorteioSemanal.TabIndex = 0;
            this.btnSorteioSemanal.Text = "Sorteio Semanal";
            this.btnSorteioSemanal.UseVisualStyleBackColor = true;
            this.btnSorteioSemanal.Click += new System.EventHandler(this.btnSorteioSemanal_Click);
            // 
            // lblNumerosSistema
            // 
            this.lblNumerosSistema.AutoSize = true;
            this.lblNumerosSistema.Location = new System.Drawing.Point(253, 88);
            this.lblNumerosSistema.Name = "lblNumerosSistema";
            this.lblNumerosSistema.Size = new System.Drawing.Size(141, 17);
            this.lblNumerosSistema.TabIndex = 1;
            this.lblNumerosSistema.Text = "Números do sistema:";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.SystemColors.Control;
            this.checkedListBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10"});
            this.checkedListBox1.Location = new System.Drawing.Point(12, 38);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(58, 208);
            this.checkedListBox1.TabIndex = 2;
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.BackColor = System.Drawing.SystemColors.Control;
            this.checkedListBox2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Items.AddRange(new object[] {
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.checkedListBox2.Location = new System.Drawing.Point(89, 38);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(59, 208);
            this.checkedListBox2.TabIndex = 3;
            // 
            // checkedListBox3
            // 
            this.checkedListBox3.BackColor = System.Drawing.SystemColors.Control;
            this.checkedListBox3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.checkedListBox3.FormattingEnabled = true;
            this.checkedListBox3.Items.AddRange(new object[] {
            "21",
            "22",
            "23",
            "24",
            "25"});
            this.checkedListBox3.Location = new System.Drawing.Point(168, 38);
            this.checkedListBox3.Name = "checkedListBox3";
            this.checkedListBox3.Size = new System.Drawing.Size(55, 123);
            this.checkedListBox3.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 263);
            this.Controls.Add(this.checkedListBox3);
            this.Controls.Add(this.checkedListBox2);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.lblNumerosSistema);
            this.Controls.Add(this.btnSorteioSemanal);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSorteioSemanal;
        private System.Windows.Forms.Label lblNumerosSistema;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.CheckedListBox checkedListBox3;
    }
}

