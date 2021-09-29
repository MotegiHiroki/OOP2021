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
        IEnumerable<ItemData> items = null;
        //List<string> a = new List<string>();
        //List<string> b = new List<string>();
        //List<string> c = new List<string>();
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
                try
                {
                    var stream = wc.OpenRead(url);

                    //XDocument xdoc = XDocument.Load(stream);
                    //var nodes = xdoc.Root.Descendants("item");
                    XDocument xdoc = XDocument.Load(stream);
                    items = xdoc.Root.Descendants("item").Select(x => new ItemData
                    {
                        Title = (string)x.Element("title"),
                        Link = (string)x.Element("link"),
                        PubDate = (DateTime)x.Element("pubDate"),
                        Description = (string)x.Element("description")
                    });

                    foreach (var item in items)
                    {
                        lbTitles.Items.Add(item.Title);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                   
                
                
                //foreach (var node in nodes)
                //{
                //    lbTitles.Items.Add(node.Element("title").Value);
                //    a.Add(node.Element("link").Value);
                //    b.Add(node.Element("description").Value);
                //    c.Add(node.Element("pubDate").Value);
                //}
            } 
        }

        private void btWeb_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            try
            {
                string link = (items.ToArray())[lbTitles.SelectedIndex].Link;
                form2.wbBrowser_DocumentCompleted(link);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                form2.Close();
            }
            
            // form2.wbBrowser_DocumentCompleted(a[lbTitles.SelectedIndex]);
        }

        private void lbTitles_SelectedIndexChanged(object sender, EventArgs e)
        {
            //DateTime dtime = DateTime.Parse(c[lbTitles.SelectedIndex]);
            //label2.Text = dtime + "\r\n" + b[lbTitles.SelectedIndex];

            try
            {
                label2.Text = items.ToArray()[lbTitles.SelectedIndex].PubDate.ToString() + "\r\n"
                                                                + items.ToArray()[lbTitles.SelectedIndex].Description;
            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message);
            }
            
        }

    }

}
