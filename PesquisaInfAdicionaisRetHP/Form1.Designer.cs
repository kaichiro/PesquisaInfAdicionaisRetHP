namespace PesquisaInfAdicionaisRetHP
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
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.ofdMain = new System.Windows.Forms.OpenFileDialog();
            this.txtFolderFile = new System.Windows.Forms.TextBox();
            this.btnProcessFile = new System.Windows.Forms.Button();
            this.txtDados = new System.Windows.Forms.TextBox();
            this.pbMain = new System.Windows.Forms.ProgressBar();
            this.lblNrCorrente = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPercCorrente = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.Location = new System.Drawing.Point(12, 12);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(75, 23);
            this.btnLoadFile.TabIndex = 0;
            this.btnLoadFile.Text = "&Load File";
            this.btnLoadFile.UseVisualStyleBackColor = true;
            this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click);
            // 
            // ofdMain
            // 
            this.ofdMain.FileName = "openFileDialog1";
            // 
            // txtFolderFile
            // 
            this.txtFolderFile.Location = new System.Drawing.Point(93, 14);
            this.txtFolderFile.Name = "txtFolderFile";
            this.txtFolderFile.Size = new System.Drawing.Size(428, 20);
            this.txtFolderFile.TabIndex = 1;
            // 
            // btnProcessFile
            // 
            this.btnProcessFile.Location = new System.Drawing.Point(527, 12);
            this.btnProcessFile.Name = "btnProcessFile";
            this.btnProcessFile.Size = new System.Drawing.Size(75, 23);
            this.btnProcessFile.TabIndex = 2;
            this.btnProcessFile.Text = "&Process File";
            this.btnProcessFile.UseVisualStyleBackColor = true;
            this.btnProcessFile.Click += new System.EventHandler(this.btnProcessFile_Click);
            // 
            // txtDados
            // 
            this.txtDados.Location = new System.Drawing.Point(12, 40);
            this.txtDados.Multiline = true;
            this.txtDados.Name = "txtDados";
            this.txtDados.Size = new System.Drawing.Size(590, 183);
            this.txtDados.TabIndex = 3;
            // 
            // pbMain
            // 
            this.pbMain.Location = new System.Drawing.Point(12, 256);
            this.pbMain.Maximum = 0;
            this.pbMain.Name = "pbMain";
            this.pbMain.Size = new System.Drawing.Size(590, 23);
            this.pbMain.TabIndex = 4;
            // 
            // lblNrCorrente
            // 
            this.lblNrCorrente.AutoSize = true;
            this.lblNrCorrente.Location = new System.Drawing.Point(498, 240);
            this.lblNrCorrente.Name = "lblNrCorrente";
            this.lblNrCorrente.Size = new System.Drawing.Size(37, 13);
            this.lblNrCorrente.TabIndex = 5;
            this.lblNrCorrente.Text = "00000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(541, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "/";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(559, 240);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(43, 13);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "000000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(559, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "100%";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(541, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "/";
            // 
            // lblPercCorrente
            // 
            this.lblPercCorrente.AutoSize = true;
            this.lblPercCorrente.Location = new System.Drawing.Point(498, 282);
            this.lblPercCorrente.Name = "lblPercCorrente";
            this.lblPercCorrente.Size = new System.Drawing.Size(37, 13);
            this.lblPercCorrente.TabIndex = 8;
            this.lblPercCorrente.Text = "00000";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 400);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblPercCorrente);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNrCorrente);
            this.Controls.Add(this.pbMain);
            this.Controls.Add(this.txtDados);
            this.Controls.Add(this.btnProcessFile);
            this.Controls.Add(this.txtFolderFile);
            this.Controls.Add(this.btnLoadFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadFile;
        private System.Windows.Forms.OpenFileDialog ofdMain;
        private System.Windows.Forms.TextBox txtFolderFile;
        private System.Windows.Forms.Button btnProcessFile;
        private System.Windows.Forms.TextBox txtDados;
        private System.Windows.Forms.ProgressBar pbMain;
        private System.Windows.Forms.Label lblNrCorrente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPercCorrente;
    }
}

