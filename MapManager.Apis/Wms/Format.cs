using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace MapManager.Apis.Wms
{
    public class Format
    {
        public static IEnumerable<XmlNode> GetFormatNodes(XmlDocument doc)
        {
            foreach (XmlNode node in doc.SelectNodes("//Request/GetMap/Format"))
            {
                yield return node;
            }
        }
    }
}
