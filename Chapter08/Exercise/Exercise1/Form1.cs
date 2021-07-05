using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btToday_Click(object sender, EventArgs e) {
            var today = DateTime.Now;
            var cl = new CultureInfo("ja-jp");
            cl.DateTimeFormat.Calendar = new JapaneseCalendar();
            

            tbDateDisp.Text = string.Format("{0:yyyy/M/d HH:mm}",today)+"\r\n";
            tbDateDisp.Text += today.ToString("yyyy年M月d日 HH時mm分ss秒") + "\r\n";
            tbDateDisp.Text += today.ToString("ggyy年 M月d日(dddd)",cl);


        }

        private void Form1_Load(object sender, EventArgs e) {
            var today =  DateTime.Now;
            var tm = new Timer();
            tm.Tick += Tm_Tick;
            tm.Start();

        }

        private void Tm_Tick(object sender, EventArgs e) {
            var today = DateTime.Now;
            tssTimeLabel.Text = today.ToString("HH時mm分ss秒");
        }
    }
}
