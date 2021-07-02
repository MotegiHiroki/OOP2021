using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise02 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Button5_2_Click(object sender, EventArgs e) {
            if (int.TryParse(inStrNum.Text, out int num)) {
                outStrNum.Text = num.ToString("#,0");

            } else {
                outStrNum.Text = "数値文字列ではありません";
            }
            

           
                
        }
    }
}
