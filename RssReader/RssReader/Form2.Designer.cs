
namespace RssReader
{
    partial class Form2
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
            this.wbBrowser = new System.Windows.Forms.WebBrowser();
            this.btBack = new System.Windows.Forms.Button();
            this.btFront = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // wbBrowser
            // 
            this.wbBrowser.Location = new System.Drawing.Point(0, 121);
            this.wbBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbBrowser.Name = "wbBrowser";
            this.wbBrowser.ScriptErrorsSuppressed = true;
            this.wbBrowser.Size = new System.Drawing.Size(1239, 418);
            this.wbBrowser.TabIndex = 0;
            this.wbBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.wbBrowser_DocumentCompleted);
            // 
            // btBack
            // 
            this.btBack.Enabled = false;
            this.btBack.Location = new System.Drawing.Point(13, 13);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(75, 23);
            this.btBack.TabIndex = 1;
            this.btBack.Text = "←";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // btFront
            // 
            this.btFront.Enabled = false;
            this.btFront.Location = new System.Drawing.Point(95, 13);
            this.btFront.Name = "btFront";
            this.btFront.Size = new System.Drawing.Size(75, 23);
            this.btFront.TabIndex = 2;
            this.btFront.Text = "→";
            this.btFront.UseVisualStyleBackColor = true;
            this.btFront.Click += new System.EventHandler(this.btFront_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 551);
            this.Controls.Add(this.btFront);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.wbBrowser);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser wbBrowser;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Button btFront;
    }
}