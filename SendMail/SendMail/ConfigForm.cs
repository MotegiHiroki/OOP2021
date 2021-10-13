using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace SendMail
{
    public partial class ConfigForm : Form
    {
        private Settings setting = Settings.getInstance();
        public ConfigForm()
        {
            InitializeComponent();
            
            tbHost.Text = setting.Host;
            tbPass.Text = setting.Pass;
            tbPort.Text = setting.Port.ToString();
            tbUserName.Text = setting.MailAddr;
            cbSsl.Checked = true;
            tbSender.Text = setting.Host;
        }

        private void btDefault_Click(object sender, EventArgs e)
        {
            tbHost.Text = setting.sHost();
            tbPass.Text = setting.sPass();
            tbPort.Text = setting.sPort();
            tbUserName.Text = setting.sMailAddr();
            cbSsl.Checked = true;
            tbSender.Text = setting.sHost();

        }

        public void btOk_Click(object sender, EventArgs e)
        {
            btApply_Click(sender,e);
            this.Close();
        }

        public void btApply_Click(object sender, EventArgs e)
        {
            try
            {
                setting.setSendConfig(tbHost.Text, int.Parse(tbPort.Text), tbUserName.Text, tbPass.Text, cbSsl.Checked);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        

        

        private void btCancel_Click(object sender, EventArgs e)

        {
            this.Close();
        }
    }
}
