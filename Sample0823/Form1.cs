using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sample0823
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Exec_Click(object sender, EventArgs e)
        {
            int num = int.Parse(Value.Text);
            int num2 = int.Parse(jyou.Text);
            Result.Text = Math.Pow(num,num2).ToString();
        }
    }
}
