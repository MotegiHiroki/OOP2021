using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SendMail
{
    public partial class Form1 : Form
    {
        ConfigForm config = new ConfigForm();
        private Settings set = Settings.getInstance();
        
        
        public Form1()
        {
            string filepass = @"./set.xml";
            if (!File.Exists(filepass))
            {
                config.ShowDialog();
            }
            
            InitializeComponent();
        }

        private void btSend_Click(object sender, EventArgs e)
        {
            try
            {
                //メール送信のためのインスタンスを生成
                MailMessage mailMessage = new MailMessage();
                //差出人アドレス
                mailMessage.From = new MailAddress(set.MailAddr);
                //宛先(To)
                mailMessage.To.Add(tbTo.Text);
                if (tbCc.Text != "")
                {
                    mailMessage.CC.Add(tbCc.Text);
                }
                if (tbBcc.Text != "")
                {
                    mailMessage.Bcc.Add(tbBcc.Text);
                }

                
                //件名タイトル
                mailMessage.Subject = tbTitle.Text;

                if (tbMessage.Text == "")
                {
                    MessageBox.Show("入力されていません");
                    return;
                }
                //本文
                mailMessage.Body = tbMessage.Text;


                //SMTPを使ってメールを送信する
                SmtpClient smtpClient = new SmtpClient();
                //メール送信のための認証情報
                smtpClient.Credentials = new NetworkCredential(set.MailAddr, set.Pass);
                smtpClient.Host = set.Host;
                smtpClient.Port = set.Port;
                smtpClient.EnableSsl = set.Ssl;
                smtpClient.SendCompleted += SmtpClient_SendCompleted;
                //smtpClient.Send(mailMessage);

                string userState = "SendMail";
                smtpClient.SendAsync(mailMessage, userState);

                btSend.Enabled = false;
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void SmtpClient_SendCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message);
            }
            else
            {
                MessageBox.Show("送信完了");
                
                ClearTextBox(this);
            }
            btSend.Enabled = true;
        }

        private void btConfig_Click(object sender, EventArgs e)
        {
            config = new ConfigForm();
            config.ShowDialog();
        }

        private void 終了XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public static void ClearTextBox(Control hParent)
        {
            foreach (Control cControl in hParent.Controls)
            {
                if (cControl is TextBoxBase)
                {
                    cControl.Text = string.Empty;
                }
            }
        }
        private void 新規作成NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearTextBox(this);
           
        }
    }
}
