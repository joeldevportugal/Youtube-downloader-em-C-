namespace Youtube
{
    partial class frYoutube
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frYoutube));
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.BtnExtrair = new System.Windows.Forms.Button();
            this.BtnDownload = new System.Windows.Forms.Button();
            this.BtnMostrar = new System.Windows.Forms.Button();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.Avanco = new System.Windows.Forms.ProgressBar();
            this.CMBMp4 = new System.Windows.Forms.ComboBox();
            this.CMBMp3 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtUrl
            // 
            this.txtUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUrl.Location = new System.Drawing.Point(12, 12);
            this.txtUrl.Multiline = true;
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(964, 36);
            this.txtUrl.TabIndex = 0;
            // 
            // BtnExtrair
            // 
            this.BtnExtrair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnExtrair.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExtrair.ForeColor = System.Drawing.Color.Blue;
            this.BtnExtrair.Image = ((System.Drawing.Image)(resources.GetObject("BtnExtrair.Image")));
            this.BtnExtrair.Location = new System.Drawing.Point(165, 53);
            this.BtnExtrair.Name = "BtnExtrair";
            this.BtnExtrair.Size = new System.Drawing.Size(125, 38);
            this.BtnExtrair.TabIndex = 1;
            this.BtnExtrair.Text = "Extrair Áudio";
            this.BtnExtrair.UseVisualStyleBackColor = true;
            this.BtnExtrair.Click += new System.EventHandler(this.BtnExtrair_Click);
            // 
            // BtnDownload
            // 
            this.BtnDownload.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnDownload.BackgroundImage")));
            this.BtnDownload.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnDownload.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDownload.ForeColor = System.Drawing.Color.Blue;
            this.BtnDownload.Location = new System.Drawing.Point(12, 52);
            this.BtnDownload.Name = "BtnDownload";
            this.BtnDownload.Size = new System.Drawing.Size(147, 38);
            this.BtnDownload.TabIndex = 2;
            this.BtnDownload.Text = "Download";
            this.BtnDownload.UseVisualStyleBackColor = true;
            this.BtnDownload.Click += new System.EventHandler(this.BtnDownload_Click);
            // 
            // BtnMostrar
            // 
            this.BtnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMostrar.ForeColor = System.Drawing.Color.Blue;
            this.BtnMostrar.Image = ((System.Drawing.Image)(resources.GetObject("BtnMostrar.Image")));
            this.BtnMostrar.Location = new System.Drawing.Point(856, 53);
            this.BtnMostrar.Name = "BtnMostrar";
            this.BtnMostrar.Size = new System.Drawing.Size(119, 38);
            this.BtnMostrar.TabIndex = 3;
            this.BtnMostrar.Text = "Mostrar";
            this.BtnMostrar.UseVisualStyleBackColor = true;
            this.BtnMostrar.Click += new System.EventHandler(this.BtnMostrar_Click);
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnLimpar.BackgroundImage")));
            this.BtnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpar.ForeColor = System.Drawing.Color.Blue;
            this.BtnLimpar.Location = new System.Drawing.Point(298, 53);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(137, 38);
            this.BtnLimpar.TabIndex = 4;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // BtnSair
            // 
            this.BtnSair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSair.BackgroundImage")));
            this.BtnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSair.ForeColor = System.Drawing.Color.Blue;
            this.BtnSair.Location = new System.Drawing.Point(441, 53);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(137, 38);
            this.BtnSair.TabIndex = 5;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // Avanco
            // 
            this.Avanco.Location = new System.Drawing.Point(12, 96);
            this.Avanco.Name = "Avanco";
            this.Avanco.Size = new System.Drawing.Size(964, 36);
            this.Avanco.TabIndex = 6;
            // 
            // CMBMp4
            // 
            this.CMBMp4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMBMp4.FormattingEnabled = true;
            this.CMBMp4.Location = new System.Drawing.Point(585, 54);
            this.CMBMp4.Name = "CMBMp4";
            this.CMBMp4.Size = new System.Drawing.Size(123, 33);
            this.CMBMp4.TabIndex = 7;
            // 
            // CMBMp3
            // 
            this.CMBMp3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMBMp3.FormattingEnabled = true;
            this.CMBMp3.Location = new System.Drawing.Point(714, 54);
            this.CMBMp3.Name = "CMBMp3";
            this.CMBMp3.Size = new System.Drawing.Size(136, 33);
            this.CMBMp3.TabIndex = 8;
            // 
            // frYoutube
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(992, 144);
            this.Controls.Add(this.CMBMp3);
            this.Controls.Add(this.CMBMp4);
            this.Controls.Add(this.Avanco);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.BtnMostrar);
            this.Controls.Add(this.BtnDownload);
            this.Controls.Add(this.BtnExtrair);
            this.Controls.Add(this.txtUrl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frYoutube";
            this.Text = "Youtube Downloader V0.0.0.1 DevJoel2024 ©Portugal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Button BtnExtrair;
        private System.Windows.Forms.Button BtnDownload;
        private System.Windows.Forms.Button BtnMostrar;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.ProgressBar Avanco;
        private System.Windows.Forms.ComboBox CMBMp4;
        private System.Windows.Forms.ComboBox CMBMp3;
    }
}
