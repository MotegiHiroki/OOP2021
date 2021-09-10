using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RssReader
{
    public partial class Form1 : Form
    {
        List<string> a = new List<string>();
        List<string> b = new List<string>();
        List<string> c = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btRead_Click(object sender, EventArgs e)
        {
            SetRssTitles(tbUrl.Text);
        }

        private void SetRssTitles(string url)
        {

            using (var wc = new WebClient())
            {
                wc.Headers.Add("Content-type", "charset=UTF-8");


                var stream = wc.OpenRead(url);

                XDocument xdoc = XDocument.Load(stream);
                var nodes = xdoc.Root.Descendants("item");
                foreach (var node in nodes)
                {
                    lbTitles.Items.Add(node.Element("title").Value);
                    a.Add(node.Element("link").Value);
                    b.Add(node.Element("description").Value);
                    c.Add(node.Element("pubDate").Value);
                }
            } 
        }

        private void btWeb_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            form2.wbBrowser_DocumentCompleted(a[lbTitles.SelectedIndex]);
        }

        private void lbTitles_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime dtime = DateTime.Parse(c[lbTitles.SelectedIndex]);
            label2.Text = dtime + "\r\n" + b[lbTitles.SelectedIndex];
        }

    }

}
