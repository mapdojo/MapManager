using System.Collections.Generic;
using Serilog;

namespace MapManager.Apis.Ogr
{
    public class Driver
    {
        private static ILogger Log => Logger.Log.ForContext(typeof(Driver));
        
        public static IEnumerable<string> DriverNames { get; } = GetDriverNames();

        private static IEnumerable<string> GetDriverNames()
        {
            Log.Debug("Registering OGR Drivers ...");
            OSGeo.OGR.Ogr.RegisterAll();
            Log.Debug("OGR Drivers Registered.");
            for (var i = 0; i < OSGeo.OGR.Ogr.GetDriverCount(); i++) yield return OSGeo.OGR.Ogr.GetDriver(i).name;
        }
    }
}