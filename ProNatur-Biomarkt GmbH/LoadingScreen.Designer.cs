namespace ProNatur_Biomarkt_GmbH
{
    partial class LoadingScreen
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadingScreen));
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblProgressBarPercent = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loadingText = new System.Windows.Forms.Label();
            this.timerProgressBar = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(12, 186);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(680, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // lblProgressBarPercent
            // 
            this.lblProgressBarPercent.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblProgressBarPercent.AutoSize = true;
            this.lblProgressBarPercent.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblProgressBarPercent.Location = new System.Drawing.Point(362, 170);
            this.lblProgressBarPercent.Name = "lblProgressBarPercent";
            this.lblProgressBarPercent.Size = new System.Drawing.Size(21, 13);
            this.lblProgressBarPercent.TabIndex = 2;
            this.lblProgressBarPercent.Text = "0%";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(680, 146);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // loadingText
            // 
            this.loadingText.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.loadingText.AutoSize = true;
            this.loadingText.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.loadingText.Location = new System.Drawing.Point(311, 170);
            this.loadingText.Name = "loadingText";
            this.loadingText.Size = new System.Drawing.Size(45, 13);
            this.loadingText.TabIndex = 5;
            this.loadingText.Text = "Loading";
            // 
            // timerProgressBar
            // 
            this.timerProgressBar.Tick += new System.EventHandler(this.timerProgressBar_Tick);
            // 
            // LoadingScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(704, 221);
            this.Controls.Add(this.loadingText);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblProgressBarPercent);
            this.Controls.Add(this.progressBar1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoadingScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProNatura-Biomarkt GmbH";
            this.Load += new System.EventHandler(this.LoadingScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblProgressBarPercent;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label loadingText;
        private System.Windows.Forms.Timer timerProgressBar;
    }
}

