using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace STools
{
    class ParseXmlFile
    {
        public XmlDocument document;

        public ParseXmlFile()
        {

            document = new XmlDocument();
            string dir = Path.GetDirectoryName(Assembly.GetCallingAssembly().Location);
            document.Load(Path.Combine(dir, @".\省市区暴雨公式.xml"));
            //document.Load(@"D:\91 STools\04 数据\省市1区暴雨公式.xml");
            //textBoxTestXml.Text = Update(document.DocumentElement.SelectNodes("."));
        }

        public string Update(XmlNodeList nodes)
        {
            string xmlString;
            if (nodes == null || nodes.Count == 0)
            {
                xmlString = "The query yielded no results";
                return xmlString;
            }
            string text = "";
            foreach (XmlNode node in nodes)
            {
                text = FormatText(node, text, "") + "\r\n";
            }
            xmlString = text;
            return xmlString;
        }

        private string FormatText(XmlNode node, string text, string indent)
        {
            if (node is XmlText)
            {
                text += node.Value;
                return text;
            }

            if (string.IsNullOrEmpty(indent))
                indent = "";
            else
            {
                text += "\r\n" + indent;
            }

            if (node is XmlComment)
            {
                text += node.OuterXml;
                return text;
            }

            text += "<" + node.Name;
            if (node.Attributes.Count > 0)
            {
                AddAttributes(node, ref text);
            }
            if (node.HasChildNodes)
            {
                text += ">";
                foreach (XmlNode child in node.ChildNodes)
                {
                    text = FormatText(child, text, indent + "  ");
                }
                if (node.ChildNodes.Count == 1 &&
                   (node.FirstChild is XmlText || node.FirstChild is XmlComment))
                    text += "</" + node.Name + ">";
                else
                    text += "\r\n" + indent + "</" + node.Name + ">";
            }
            else
                text += " />";
            return text;
        }

        private void AddAttributes(XmlNode node, ref string text)
        {
            foreach (XmlAttribute xa in node.Attributes)
            {
                text += " " + xa.Name + "='" + xa.Value + "'";
            }
        }
    }
}
