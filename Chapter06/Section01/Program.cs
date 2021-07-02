using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {
        static void Main(string[] args) {
            //var number = Enumerable.Range(1, 20).ToArray();
            var books = Books.GetBooks();
            //Console.WriteLine("本の平均価格は" + books.Average(x => x.Price).ToString("#,0") + "円");
            //Console.WriteLine("本の総ページ数は" + books.Sum(x => x.Pages) + "ページ");
            //Console.WriteLine("最も価格の高い本は" + books.Max(x => x.Price)+ "円");
            //Console.WriteLine("最も価格の安い本は" + books.Min(x => x.Price)+ "円");
            ////
            //Console.WriteLine("500円以上の本は" + books.Count(x => x.Price >= 500) + "冊");


            //Console.WriteLine("「物語」が含まれている数は"+ books.Count(x => x.Title.Contains("物語")) + "冊");

            //foreach (var n in books.Where(x => x.Title.Contains("物語")).Take(2)) {
            //    Console.WriteLine(n.Title);
            //}

            //foreach (var n in books.OrderByDescending(x => x.Price).Take(3)) {
            //    Console.WriteLine(n.Title + "  " + n.Price);
            //}

             var titles = books.Select(x => x.Title);
            foreach (var item in titles) {
                Console.WriteLine(item);
            }
            
        }
    }
}
