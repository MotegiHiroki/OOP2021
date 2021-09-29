using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise2 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            if (ofd.ShowDialog() == DialogResult.OK) {
                var lines = File.ReadAllLines(ofd.FileName, Encoding.GetEncoding("shift_jis"))
                    .Select((s,ix) => string.Format("{0,4}:{1}",ix +1,s))
                    .ToArray();
                foreach (var line in lines) {
                    textBox1.Text += line + "\r\n";

                }
                try {
                    if (sfd.ShowDialog() == DialogResult.OK) {
                        //バイナリ形式でシリアル化
                        var bf = new BinaryFormatter();
                        using (FileStream fs = File.Open(sfd.FileName, FileMode.Create)) {
                            bf.Serialize(fs, textBox1.Text);
                        }
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }



            }
        }
    }
}
