using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exiercise1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btOpen_Click(object sender, EventArgs e) {
            if(ofdOpenFile.ShowDialog() == DialogResult.OK) {
                using (var reader = new StreamReader(ofdOpenFile.FileName, Encoding.GetEncoding("shift_jis"))) {
                    int count = 0;
                    while (!reader.EndOfStream) {
                        var line = reader.ReadLine(); //1行読み込み
                        if (line.Contains(textBox1.Text)) {
                            count++;
                        }
                    }
                    tbOutPut.Text = count.ToString();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            if (ofdOpenFile.ShowDialog() == DialogResult.OK) {
                var lines = File.ReadAllLines(ofdOpenFile.FileName, Encoding.GetEncoding("shift_jis"));
                int count = lines.Count(x => x.Contains(textBox1.Text));
                tbOutPut.Text = count.ToString();

            }
        }

        private void button2_Click(object sender, EventArgs e) {
            if (ofdOpenFile.ShowDialog() == DialogResult.OK) {
                var lines = File.ReadLines(ofdOpenFile.FileName, Encoding.GetEncoding("shift_jis"));
                int count = lines.Count(x => x.Contains(textBox1.Text));
                tbOutPut.Text = count.ToString();
            }
        }
    }
}
