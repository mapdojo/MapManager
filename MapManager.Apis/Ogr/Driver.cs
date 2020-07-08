using System.Collections.Generic;
using Serilog;

namespace MapManager.Apis.Ogr
{
    public class Driver
    {
        private static ILogger Log => Logger.Log.ForContext(typeof(Driver));
        
        private static HashSet<string> driverNames;
        
        public static IEnumerable<string> DriverNames
        {
            get
            {
                if (driverNames != null && driverNames.Count > 0)
                {
                    return driverNames;
                }
                
                driverNames = GetDriverNames();
                return driverNames;
            }
        }
        
        private static HashSet<string> GetDriverNames()
        {
            Log.Debug("Registering OGR Drivers ...");
            OSGeo.OGR.Ogr.RegisterAll();
            Log.Debug("OGR Drivers Registered.");
            var driverLongNames = new HashSet<string>();
            for (var i = 0; i < OSGeo.OGR.Ogr.GetDriverCount(); i++) 
                driverLongNames.Add(OSGeo.OGR.Ogr.GetDriver(i).name);
            return driverLongNames;
        }
    }
}