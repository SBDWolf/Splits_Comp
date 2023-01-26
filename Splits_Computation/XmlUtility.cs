using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Xml.Linq;
using System.Text.RegularExpressions;

namespace Splits_Computation
{
    internal class XmlUtility
    {
        public static string SearchForPB(string filePath)
        {
            XElement root = XElement.Load(filePath);
            XElement lastSegment = root.Element("Segments").Elements("Segment").Last();
            string output = "";
            foreach (XElement element in lastSegment.Elements("SplitTimes").Elements("SplitTime"))
            {
                if (element.Attribute("name").Value.ToString() == "Personal Best")
                {
                    output = element.Element("RealTime").Value;
                    break;
                }
            }
            output = Regex.Replace(output, @"[.]\d+$", "");
            return output;
        }

    }
}
