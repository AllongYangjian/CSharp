using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _1_xml
{
    class Program
    {
        static void Main(string[] args)
        {
            //XmlTest();
            LoadXml();
        }

        public static void XmlTest()
        {
            //创建xml文档对象
            XmlDocument doc = new XmlDocument();
            //创建文档描述信息
            XmlDeclaration declaration =  doc.CreateXmlDeclaration("1." +
                "0", "utf-8",null);
            doc.AppendChild(declaration);
            //创建根节点
            XmlElement root = doc.CreateElement("Books");
            doc.AppendChild(root);

            XmlElement b1 = doc.CreateElement("Book");
            root.AppendChild(b1);

            XmlElement name = doc.CreateElement("name");
            name.InnerText = "红会";
            b1.AppendChild(name);

            XmlElement price = doc.CreateElement("price");
            price.InnerText = "50";
            b1.AppendChild(price);

            XmlElement version = doc.CreateElement("version");
            version.InnerText = "1.0";

            XmlAttribute attr = doc.CreateAttribute("name");
            version.SetAttributeNode(attr);
            b1.AppendChild(version);

            doc.Save("xmlTest.xml");
            Console.ReadKey();

        }

        public static void LoadXml()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("xmlTest.xml");

            XmlNodeList nodes = doc.SelectNodes("/Books/Book");
            foreach(XmlNode item in nodes)
            {
                Console.WriteLine(item.InnerText); 
            }
            Console.ReadKey();

        }
    }
}
