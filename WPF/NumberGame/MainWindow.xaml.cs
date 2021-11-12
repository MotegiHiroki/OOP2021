using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NumberGame
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        int num  = 0;
        public MainWindow()
        {
            InitializeComponent();
            
            Random r = new Random();
            num = r.Next(1, 26);
            
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            

            var button = int.Parse(((Button)sender).Content.ToString()) ;

            if (num == button)
            {
                t.Text = "正解です " + num;
            }
            else if(num > button)
            {
                t.Text = "もっと大きいです " + num;
            }
            else
            {
                t.Text = "もっと小さいです " + num;
            }
        }
    }
}
