using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace MapManager.Apis.Wms
{
    public class Version
    {
        public static string GetVersion(XmlDocument doc)
        {
            XmlAttribute att = doc.DocumentElement.Attributes["version"];
            var wms_server_version = "1.1.1";
            if (att != null)
                wms_server_version = att.Value.Trim();
            if (!wms_server_version.StartsWith("1.0") && !wms_server_version.StartsWith("1.1"))
                wms_server_version = "1.1.1";
            return wms_server_version;
        }
    }
}
