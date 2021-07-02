using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise03 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

       

       

        //フォームがロードされるタイミングで一回だけ実行される
        private void Form1_Load(object sender, EventArgs e) {
            inputStrText.Text = "Jackdaws love my big sphinx of quartz";
            textBox6.Text = "Novelist=谷崎潤一郎;BestWork=春琴抄;Born=1886";
        }

        private void Button5_3_1_Click(object sender, EventArgs e) {
            textBox2.Text = inputStrText.Text.Count(c => c == ' ').ToString();
        }

        private void Button5_3_2_Click(object sender, EventArgs e) {
            textBox1.Text = inputStrText.Text.Replace("big", "small");

        }
        

        private void Button5_3_3_Click(object sender, EventArgs e) {
            textBox3.Text = inputStrText.Text.Split(' ').Count().ToString();
        }

        private void Button5_3_4_Click(object sender, EventArgs e) {
            var str = inputStrText.Text.Split(' ').Where(s => s.Length <= 4);
            foreach (var n in str) {
                textBox4.Text += n+ " ";
            }

        }

        private void Button5_3_5_Click(object sender, EventArgs e) {
            var str = inputStrText.Text.Split(' ').ToArray();
            if(str.Length > 0) {
                var sb = new StringBuilder(str[0]);
                foreach (var n in str) {
                    sb.Append(' ');
                    sb.Append(n);

                }
                textBox5.Text = sb.ToString();
            }
            //var sb = new StringBuilder();
            //foreach (var n in str) {
            //    sb.Append(n+ " ");
            //}

            //textBox5.Text = sb.ToString().Trim();

        }

        private void Button5_4_Click(object sender, EventArgs e) {
            //string n = "", be = "", bo = "";
            foreach (var s in textBox6.Text.Split(';')) {
                var str = s.Split('=');
                textBox7.Text += ToJapanese(str[0]) + ":" + str[1] + "\r\n";
                //if (s.Contains("Novelist")) n = s.Substring(s.IndexOf("=") + 1) ;
                //if (s.Contains("BestWork")) be = s.Substring(s.IndexOf("=") + 1);
                //if (s.Contains("Born")) bo = s.Substring(s.IndexOf("=") + 1);
            }
            //textBox7.Text = string.Format("作家　：{0}\r\n代表作　：{1}\r\n誕生年　：{2}", n, be, bo);
        }

        private string ToJapanese(string key) {
            switch (key) {
                case "Novelist":
                    return "作家 ";
                case "BestWork":
                    return "代表作 ";
                case "Born":
                    return "誕生年 ";
            }
            throw new ArgumentException("引数が正しくありません");
        }
    }


}
