using System.Collections.Generic;
using Serilog;

namespace MapManager.Apis.Ogr
{
    public class Driver
    {
        private static ILogger Log => Logger.Log.ForContext(typeof(Driver));
        
        private static HashSet<string> names;
        
        public static IEnumerable<string> Names
        {
            get
            {
                if (names != null && names.Count > 0)
                {
                    return names;
                }
                
                names = GetDriverNames();
                return names;
            }
        }
        
        private static HashSet<string> GetDriverNames()
        {
            Log.Debug("Registering OGR Drivers ...");
            OSGeo.OGR.Ogr.RegisterAll();
            var driverNames = new HashSet<string>();
            for (var i = 0; i < OSGeo.OGR.Ogr.GetDriverCount(); i++) 
                driverNames.Add(OSGeo.OGR.Ogr.GetDriver(i).name);
            Log.Debug("{DriverLongNamesCount} OGR Drivers Registered.", driverNames.Count);
            return driverNames;
        }

        public static void Register()
        {
            GetDriverNames();
        }
    }
}