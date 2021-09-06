
namespace RssReader
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.btRead = new System.Windows.Forms.Button();
            this.wbBrowser = new System.Windows.Forms.WebBrowser();
            this.lbTitles = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "RssReader";
            // 
            // tbUrl
            // 
            this.tbUrl.Location = new System.Drawing.Point(151, 13);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(487, 22);
            this.tbUrl.TabIndex = 1;
            // 
            // btRead
            // 
            this.btRead.Location = new System.Drawing.Point(695, 11);
            this.btRead.Name = "btRead";
            this.btRead.Size = new System.Drawing.Size(75, 23);
            this.btRead.TabIndex = 2;
            this.btRead.Text = "読み込み";
            this.btRead.UseVisualStyleBackColor = true;
            this.btRead.Click += new System.EventHandler(this.btRead_Click);
            // 
            // wbBrowser
            // 
            this.wbBrowser.Location = new System.Drawing.Point(273, 64);
            this.wbBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbBrowser.Name = "wbBrowser";
            this.wbBrowser.Size = new System.Drawing.Size(480, 391);
            this.wbBrowser.TabIndex = 3;
            // 
            // lbTitles
            // 
            this.lbTitles.FormattingEnabled = true;
            this.lbTitles.ItemHeight = 15;
            this.lbTitles.Location = new System.Drawing.Point(12, 64);
            this.lbTitles.Name = "lbTitles";
            this.lbTitles.Size = new System.Drawing.Size(230, 379);
            this.lbTitles.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbTitles);
            this.Controls.Add(this.wbBrowser);
            this.Controls.Add(this.btRead);
            this.Controls.Add(this.tbUrl);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "32090";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.Button btRead;
        private System.Windows.Forms.WebBrowser wbBrowser;
        private System.Windows.Forms.ListBox lbTitles;
    }
}

