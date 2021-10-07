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
            update();
            this.Close();
        }

        public void btApply_Click(object sender, EventArgs e)
        {
            
            update();
        }
        

        public void update()
        {
            setting.Host = tbHost.Text;
            setting.Pass = tbPass.Text;
            setting.Port = int.Parse(tbPort.Text);
            setting.MailAddr = tbUserName.Text;
            setting.Ssl = cbSsl.Checked;
            var settings = new XmlWriterSettings
            {
                Encoding = new System.Text.UTF8Encoding(false),
                Indent = true,
                IndentChars = " ",
            };

            using (var writer = XmlWriter.Create("set.xml", settings))
            {
                var ser = new DataContractSerializer(setting.GetType());
                ser.WriteObject(writer, setting);
            }
        }

        private void btCancel_Click(object sender, EventArgs e)

        {
            this.Close();
        }
    }
}
