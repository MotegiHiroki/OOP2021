using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2 {
    class Program {
        static void Main(string[] args) {
            Console.Write("str1:");
            string str1 = Console.ReadLine();
            if(int.TryParse(str1, out int num)) { 
            
                Console.WriteLine(num);
            }
        }
    }
}
