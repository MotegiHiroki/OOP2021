using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1 {
    class Program {
        static void Main(string[] args) {
            Console.Write("str1:");
            string str1 = Console.ReadLine();
            Console.Write("str2:");
            string str2 = Console.ReadLine();
            if(String.Compare( str1, str2,true) == 0) {
                Console.WriteLine("等しい");
            }
        }
    }
}
