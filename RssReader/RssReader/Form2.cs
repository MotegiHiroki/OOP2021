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

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        internal void wbBrowser_DocumentCompleted(string sender)
        {
            wbBrowser.Url = new Uri(sender);
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            if (wbBrowser.CanGoBack == true)
            {
                wbBrowser.GoBack();
            }

        }

        private void btFront_Click(object sender, EventArgs e)
        {
            if (wbBrowser.CanGoForward == true)
            {
                wbBrowser.GoForward();
            }
        }

        private void wbBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (wbBrowser.CanGoBack == true)
            {
                btBack.Enabled = true;
            }
            else
            {
                btBack.Enabled = false;
            }

            if (wbBrowser.CanGoForward == true)
            {
                btFront.Enabled = true;
            }
            else
            {
                btFront.Enabled = false;
            }
        }
    }
}
