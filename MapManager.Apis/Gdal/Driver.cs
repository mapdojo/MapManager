using Serilog;
using System.Collections.Generic;

namespace MapManager.Apis.Gdal
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
            Log.Debug("Registering GDAL Drivers ...");
            OSGeo.GDAL.Gdal.AllRegister();
            Log.Debug("GDAL Drivers Registered.");
            var driverLongNames = new HashSet<string>();
            for (var i = 0; i < OSGeo.GDAL.Gdal.GetDriverCount(); i++)
                driverLongNames.Add(OSGeo.GDAL.Gdal.GetDriver(i).LongName);
            return driverLongNames;
        }
    }
}