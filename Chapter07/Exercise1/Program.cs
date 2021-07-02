using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1 {
    class Program {
        static void Main(string[] args) {
            var text = "Cozy lummox gives smart squid who asks for job pen";
            Exercise1_1(text);
            Console.WriteLine();
            Exercise1_2(text);
        }

        private static void Exercise1_1(string text) {
             string s =  text.ToUpper();
            var dict = new Dictionary<char, int>();
            foreach (var item in s) {
                if (dict.ContainsKey(item)) {
                    dict[item]++;
                } else if('A' <= item && item <=  'Z'){
                    dict.Add(item,1);
                }
            }
            foreach (var item in dict.OrderBy(x=> x.Key)) {
                Console.WriteLine(item.Key + ":" + item.Value);
            }
            
        }

        private static void Exercise1_2(string text) {
            string s = text.ToUpper();
            var dict = new SortedDictionary<char, int>();
            foreach (var item in s) {
                if (dict.ContainsKey(item)) {
                    dict[item]++;
                } else if ('A' <= item && item <= 'Z') {
                    dict.Add(item, 1);
                }
            }
            foreach (var item in dict) {
                Console.WriteLine(item.Key + ":" + item.Value);
            }
        }
    }

   
}
