using System;
using System.Xml.XPath;
using System.Xml.Xsl;
using System.Xml;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            XslCompiledTransform xslt = new XslCompiledTransform();
            xslt.Load("stylesheet.xslt");
            XsltArgumentList xslArg = new XsltArgumentList();

            XPathDocument data = new XPathDocument("XmlData.xml");
            XmlWriter writer = new XmlTextWriter(Console.Out);

            //xslt.Transform(data, writer);
            xslt.Transform("XmlData.xml", "xmlout.xml");

            //Console.ReadKey();
        }
    }
}
