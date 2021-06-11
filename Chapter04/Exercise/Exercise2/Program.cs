using Exercise1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2 {
    class Program {

        static void Main(string[] args) {

           
            var ym1 = new YearMonth(2019, 2);
            var ym2 = new YearMonth(2017, 12);
            var ym3 = new YearMonth(2016, 2);
            var ym4 = new YearMonth(2013, 11);
            var ym5 = new YearMonth(2019, 12);
            var ym = new YearMonth[] { ym1, ym2, ym3, ym4, ym5 };

            for (int i = 0; i < ym.Length; i++) {
                Console.WriteLine(ym[i]);
            }
            
            string a = ym.Contains(Is21(ym)) ? Is21(ym).Year.ToString(): "21世紀のデータがありません";
            Console.WriteLine(a);


            var years = ym.Select(s => s.AddOneMonth()).OrderBy(y => y.Year);
            foreach (var b in years) {
                Console.WriteLine(b);
            }
                 
        }
        static YearMonth Is21(YearMonth[] yms) {
            foreach (var i in yms) {
                if (i.Is21Century) {
                    return i;
                }
            }
            return null;
        }
    }
}
