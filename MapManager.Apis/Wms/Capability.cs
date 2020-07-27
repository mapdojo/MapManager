using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace MapManager.Apis.Wms
{
    public class Capability
    {
        public static XmlDocument GetCapabilities(string serverURL)
        {
            var doc = new XmlDocument();

            XmlTextReader reader;
            if (serverURL.Contains("?"))
                reader = new XmlTextReader(serverURL + "&SERVICE=WMS&REQUEST=GetCapabilities&VERSION=1.3.0");
            else
                reader = new XmlTextReader(serverURL + "?SERVICE=WMS&REQUEST=GetCapabilities&VERSION=1.3.0");

            reader.Namespaces = false;
            reader.XmlResolver = new XmlProxyUrlResolver();
            doc.Load(reader);
            return doc;
        }

        public static IEnumerable<XmlNode> GetLayerNodes(XmlDocument doc)
        {
            foreach (XmlNode node in doc.SelectNodes("//Capability/Layer"))
            {
                yield return node;
            }
        }
    }
}
