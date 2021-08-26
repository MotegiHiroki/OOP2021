using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Section01
{
    class Program
    {
        static void Main(string[] args)
        {
            var xdoc = XDocument.Load("novelists.xml");
            //var xelements = xdoc.Root.Elements().Where(x => ((DateTime)x.Element("birth")).Year >= 1900);
            //var xelements = xdoc.Root.Elements().OrderBy(x => (string)x.Element("birth"));
            foreach (var xnovelist in xdoc.Root.Elements())
            {
                //var birth = (DateTime)xnovelist.Element("birth");
                var xname = xnovelist.Element("name");
                var works = xnovelist.Element("masterpieces").Elements("title").Select(x => x.Value);
               // XAttribute xkana = xname.Attribute("kana");
                Console.WriteLine("{ 0}{ 1}" ,xname.Value, string.Join(",",works));
            }
        }
    }
}
