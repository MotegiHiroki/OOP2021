using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3 {
    class Program {
        static void Main(string[] args) {
            var sales = new SalesCounter("sales.csv");

            //var amountPerStore = sales.GetPerStoreSales();//店舗別に売り上げを求める
            var amountPerCategory = sales.GetPerCategorySales();//店舗別に売り上げを求める
            foreach (var obj in amountPerCategory) {
                Console.WriteLine("{0} {1}", obj.Key, obj.Value);
            }
        }
    }
}
