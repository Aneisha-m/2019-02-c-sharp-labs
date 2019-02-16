using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//To use XML add following using statement
using System.Xml.Linq;
// To load XML
using System.Xml;
//Notes:
/*
 
*/

namespace lab_09_xml
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n Most Basic XML Element\n");
            var xm101 = new XElement("test", 1); // test = name of the field // 1 = value of the data
            Console.WriteLine(xm101);

            Console.WriteLine("\n Now add XML sub-Element\n");
            var xm102 = new XElement("RootElement",
                new XElement("SubElement", 100)); // data is replaced by sub-element
            Console.WriteLine(xm102);

            //multiple sub elements
            Console.WriteLine("\n Now add XML sub-Element\n");
            var xm103 = new XElement("RootElement",
                new XElement("SubElement", 100),
                new XElement("SubElement", 100),
                new XElement("SubElement", 100),
                new XElement("SubElement", 100),
                new XElement("SubElement", 100)
                );
            Console.WriteLine(xm103);

            //HTML Input Attributes
            Console.WriteLine("\n Now add attributes\n");
            var xm104 = new XElement("RootElement",
                new XElement("SubElement",
                    new XAttribute("height", 500),
                100),
                new XElement("SubElement", 100),
                new XElement("SubElement", 100),
                new XElement("SubElement", 100),
                new XElement("SubElement", 100)
                );
            Console.WriteLine(xm104);

            //adding attribute to all sub-elements
            Console.WriteLine("\n put attributes on all\n");
            var xm105 = new XElement("RootElement",
                new XElement("SubElement",
                    new XAttribute("height", 500),
                100),
                new XElement("SubElement", new XAttribute("height", 500), 100),
                new XElement("SubElement", new XAttribute("height", 500), 100),
                new XElement("SubElement", new XAttribute("height", 500), 100),
                new XElement("SubElement", new XAttribute("height", 500), 100)
                );
            Console.WriteLine(xm105);

            //saving to a document
            Console.WriteLine("\n now save to a document\n");
            var xm106 = new XElement("RootElement",
                new XElement("SubElement",
                    new XAttribute("height", 500),
                100),
                new XElement("SubElement", new XAttribute("height", 500), 100),
                new XElement("SubElement", new XAttribute("height", 500), 100),
                new XElement("SubElement", new XAttribute("height", 500), 100),
                new XElement("SubElement", new XAttribute("height", 500), 100)
                );
            Console.WriteLine(xm106);
            //xDcoument : save this to file
            var doc06 = new XDocument(XElement.Parse(xm106.ToString()));
            doc06.Save("Xml06.xml"); // you can define path here if not the file will be in its relative path //look at escape

            //Loading : method 1
            Console.WriteLine("\n Now load back the same data\n");
            var doc07 = new XmlDocument();
            doc07.Load("Xml06.xml");
            Console.WriteLine(doc07.InnerXml);
            Console.WriteLine(XDocument.Parse(doc07.InnerXml));

            //Loading : method 2
            var doc08 = XDocument.Load("Xml106.xml");
            Console.WriteLine(doc08);
        }
    }
}
