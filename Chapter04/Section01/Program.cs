using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {
        static void Main(string[] args) {
            //var person = new Person {
            //    Name = "新井遥菜",
            //    Birthday = new DateTime(1995, 11, 23),
            //    PhoneNumber = "123-3456-7890"
            //};

            //var list = new List<int> { 10, 20, 30, 40, };
            //var key = 50;
            //var num = list.Contains(key) ? 1 : 0;
            //Console.WriteLine(num);

            //string code = "12345";
            ////null合体演算子
            //var message = GetMessage(code) ?? DefalutMessage();
            //Console.WriteLine(message);

            //var ret = GetProductA();

            //int count = 0;

            //Console.WriteLine($"後置 : {count++}");

            //Console.WriteLine($"前置 : {++count}");

            //var str = "123";

            //int height;
            //if(int.TryParse(str, out var height)) {
            //    Console.WriteLine(height);
            //} else {
            //    Console.WriteLine("変換できません");
            //}

            //var Session = new Dictionary<string, object>();
            //Session["MyProduct"] = new Product();

            //var product = Session["MyProduct"] as Product;
            //if(product == null) {
            //    Console.WriteLine("productが取得できなかった");
            //} else {
            //    Console.WriteLine("productが取得できた");
            //}





        }

        //スタブ
        private static object DefalutMessage() {
            return "DefalutMessage";
        }

        private static object GetMessage(object code) {
            return null;
        }

        private static Product GetProductA() {
            Sale sale = new Sale();
            sale.Product = new Product();
            sale = null;
            return sale?.Product; //nill条件演算
        }

    }
    class Sale {
        public string ShopName { get; set; } = "abcde";
        public int Amount { get; set; } = 12340;
        public Product Product { get; set; }
    }
}
