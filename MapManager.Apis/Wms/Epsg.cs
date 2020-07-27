using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MapManager.Apis.Wms
{
    public class Epsg
    {
        public static Hashtable GetEpsg()
        {
            Hashtable epsg = new Hashtable();
            using (Stream s = File.OpenRead(Path.Combine(Proj.ProjLibDirectory.FullName, "epsg")))
            {
                using (StreamReader reader = new StreamReader(s))
                {
                    string line;
                    string projName = "";
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (line.StartsWith("#") && line.Length > 2)
                            projName = line.Substring(2);
                        else if (line.StartsWith("<"))
                        {
                            string[] items = line.Split(new char[] { '<', '>' },
                                               StringSplitOptions.RemoveEmptyEntries);
                            if (items.Length > 0)
                                epsg.Add("EPSG:" + items[0], projName);
                        }
                    }
                }
            }
            return epsg;
        }
    }
}
