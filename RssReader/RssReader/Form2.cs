using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RssReader
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void SetRsslink(string url)
        {
            Form1 form1 = new Form1();
            form1.SetRssTitles(form1.tbUrl.Text);
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        internal void wbBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
