using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Excise2
{
    class Program
    {
        static void Main(string[] args)
        {
            var xdoc = XDocument.Load("11_2.xml");
            var pairs = xdoc.Root.Elements().Select(x => new
            {
                Key = x.Attribute("kanji").Value,
                Value = x.Attribute("yomi").Value
            });
            var root = new XElement("difficultkanji", pairs);
            root.Save("11_2.xml");

        }
    }
}
