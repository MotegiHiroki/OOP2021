using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StopWatch {
    public partial class Form1 : Form {
        public Stopwatch stopWatch = new Stopwatch();
        Timer tm = new Timer();
        public Form1() {
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e) {
            
            tm.Start();
            
            tm.Tick += Tm_Tick;

        }

        private void Tm_Tick(object sender, EventArgs e) {
            stopWatch.Start();
            textBox1.Text = stopWatch.Elapsed.ToString(@"hh\:mm\:ss\:ff");
        }

        private void Form1_Load(object sender, EventArgs e) {
            textBox1.Text = stopWatch.Elapsed.ToString(@"hh\:mm\:ss\:ff");
        }

        private void stop_Click(object sender, EventArgs e) {
            stopWatch.Stop();
            tm.Stop();
        }

        private void re_Click(object sender, EventArgs e) {
            stopWatch.Reset();
            textBox1.Text = stopWatch.Elapsed.ToString(@"hh\:mm\:ss\:ff");
        }
    }
}
