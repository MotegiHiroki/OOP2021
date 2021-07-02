using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1 {
    class Program {
        static void Main(string[] args) {
            var number = new int[] { 5, 10, 17, 9, 3, 21, 10, 40, 21, 3, 35 };

            Console.WriteLine(number.Max());

            foreach (var item in number.Reverse().Take(2)) {
                Console.Write(item + " ");
            }
            Console.WriteLine("");
            foreach (var item in number) {
                Console.Write(item.ToString("#") + " ");
            }

            Console.WriteLine(" ");

            foreach (var item in number.OrderBy(x => x).Take(3)) {
                Console.Write(item + " ");
            }

            Console.WriteLine(" ");

            Console.WriteLine(number.Distinct().Count(x => x > 10));


            var books = new List<Book> {
               new Book { Title = "C#プログラミングの新常識", Price = 3800, Pages = 378 },
               new Book { Title = "ラムダ式とLINQの極意", Price = 2500, Pages = 312 },
               new Book { Title = "ワンダフル・C#ライフ", Price = 2900, Pages = 385 },
               new Book { Title = "一人で学ぶ並列処理プログラミング", Price = 4800, Pages = 464 },
               new Book { Title = "フレーズで覚えるC#入門", Price = 5300, Pages = 604 },
               new Book { Title = "私でも分かったASP.NET MVC", Price = 3200, Pages = 453 },
               new Book { Title = "楽しいC#プログラミング教室", Price = 2540, Pages = 348 },
            };

            Exercise2_1(books);
            Console.WriteLine("-----");

            Exercise2_2(books);

            Console.WriteLine("-----");

            Exercise2_3(books);
            Console.WriteLine("-----");

            Exercise2_4(books);
            Console.WriteLine("-----");

            Exercise2_5(books);
            Console.WriteLine("-----");

            Exercise2_6(books);

            Console.WriteLine("-----");

            Exercise2_7(books);
        }

        private static void Exercise2_1(List<Book> books) {
            foreach (var item in books.Where(x => x.Title.Contains("ワンダフル・C#ライフ"))) {
                Console.WriteLine(item.Price + " " + item.Pages);
            }
            var book = books.FirstOrDefault(b => b.Title == "ワンダフル・C#ライフ");
            if(book != null) {
                Console.WriteLine("{0} {1}", book.Price, book.Pages);
            }
        }

        private static void Exercise2_2(List<Book> books) {
            Console.WriteLine(books.Count(x => x.Title.Contains("C#")));
        }

        private static void Exercise2_3(List<Book> books) {
            Console.WriteLine(books.Where(y => y.Title.Contains("C#")).Average(x => x.Pages));
        }

        private static void Exercise2_4(List<Book> books) {
            Console.WriteLine(books[books.FindIndex(x => x.Price >= 4000)].Title); 
            
        }

        private static void Exercise2_5(List<Book> books) {
            Console.WriteLine(books.Where(x => x.Price < 4000).Max(x => x.Pages));
        }

        private static void Exercise2_6(List<Book> books) {
            foreach (var item in books.Where(x => x.Pages >= 400).OrderBy(x => x.Price)) {
                Console.WriteLine(item.Title + " " + item.Price);
            }
            
        }

        private static void Exercise2_7(List<Book> books) {
            foreach (var item in books.Where(x => x.Pages <= 500 && x.Title.Contains("C#")) ) {
                Console.WriteLine(item.Title);
            }
        }
        class Book {
            public string Title { get; set; }
            public int Price { get; set; }
            public int Pages { get; set; }
        }
    }
}
