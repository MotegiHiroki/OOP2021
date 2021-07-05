using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise1 {
    public partial class Form1 : System.Windows.Forms.Form {
        public Form1() {
            InitializeComponent();
        }

        private void btAction_Click(object sender, EventArgs e) {
            //var today = DateTime.Today;
            //var today = new DateTime((int)nudYear.Value,(int)nudMonth.Value,(int)nudDay.Value);
            var today = dateTimePicker1.Value;
            DayOfWeek dayOfWeek = today.DayOfWeek;
            string dow = "";
            
            switch (dayOfWeek) {
                case DayOfWeek.Sunday:
                    dow = "日曜日";
                    break;
                case DayOfWeek.Monday:
                    dow = "月曜日";
                    break;
                case DayOfWeek.Tuesday:
                    dow = "火曜日";
                    break;
                case DayOfWeek.Wednesday:
                    dow = "水曜日";
                    break;
                case DayOfWeek.Thursday:
                    dow = "木曜日";
                    break;
                case DayOfWeek.Friday:
                    dow = "金曜日";
                    break;
                case DayOfWeek.Saturday:
                    dow = "土曜日";
                    break;
                
            }

            tbOutput.Text = dow + "です";

            var year = DateTime.IsLeapYear((int)nudYear.Value);
            if (year) {
                textBox1.Text = "閏年です";
            } else {
                textBox1.Text = "閏年ではありません";
            }

            var now = DateTime.Now;
            TimeSpan diff = now - today;
            textBox2.Text = diff.Days+"日";

            var age = now.Year - today.Year;
            if(now < today.AddYears((int)age)){
                age--;
            }
            tbOutput.Text = age + "才";
            //tbOutput.Text = DateTime.Today.DayOfYear.ToString();
        }
    }
}
