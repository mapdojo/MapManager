using System.Xml;

namespace MapManager.Apis.Wms
{
    public class LayerDetails
    {
        public LayerDetails(XmlDocument xmlDocument, string url, string version)
        {
            Url = url;
            Version = version;

            XmlNode node = xmlDocument.SelectSingleNode("//Service");
            if (node != null)
            {
                XmlNode n2 = node.SelectSingleNode("Title");
                if (n2 != null)
                    Title = n2.InnerText;
                n2 = node.SelectSingleNode("Abstract");
                if (n2 != null)
                    Abstract = n2.InnerText;
            }
        }

        public string Url { get; set; }
        public string Version { get; set; }
        public string Abstract { get; set; }
        public string Title { get; set; }
    }
}
