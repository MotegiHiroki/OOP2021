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

namespace Exercise3 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            var filePath = textBox1.Text;
            var filePath2 = textBox2.Text;
            using (var writer = new StreamWriter(filePath, append: true)) {
                var reader = File.ReadAllLines(filePath2, Encoding.UTF8);
                foreach (var item in reader) {
                    writer.WriteLine(item);
                }
                  
            }
        }
    }
}
