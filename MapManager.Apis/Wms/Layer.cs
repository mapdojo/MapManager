using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace MapManager.Apis.Wms
{
    public class Layer
    {
        public static string GetTitle(XmlNode xmlNode)
        {
            return xmlNode.SelectSingleNode("Title").InnerText;
        }

        public static bool IsQueryable(XmlNode xmlNode)
        {
            XmlAttribute att = xmlNode.Attributes["queryable"];
            if (att != null && att.Value.Trim() == "1")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static XmlNodeList GetLayerNodes(XmlNode xmlNode)
        {
            return xmlNode.SelectNodes("Layer");
        }
    }
}
