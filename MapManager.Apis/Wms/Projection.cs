using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace MapManager.Apis.Wms
{
    public class Projection
    {
        public static List<KeyValuePair<string, string>> GetProjections(XmlDocument doc, Hashtable epsg, out string selectedProj)
        {
            Dictionary<string, string> projections = new Dictionary<string, string>();
            selectedProj = null;
            foreach (XmlNode srs in doc.SelectNodes("//CRS | //SRS"))
            {
                string[] srs2 = srs.InnerText.Split();
                foreach (string s in srs2)
                {
                    if (!projections.ContainsKey(s))
                    {
                        if (epsg.ContainsKey(s))
                            projections.Add(s, epsg[s].ToString());
                        else
                            projections.Add(s, s);

                        if (s.Contains("EPSG:4326"))
                            selectedProj = epsg[s].ToString();
                    }
                }
            }
            return new List<KeyValuePair<string, string>>(projections);
        }
    }
}
