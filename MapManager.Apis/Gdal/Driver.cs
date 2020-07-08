using System.Collections.Generic;
using System.IO;
using Serilog;

namespace MapManager.Apis.Gdal
{
    public class Driver
    {
        private const string GDAL_DRIVER_PATH = "GDAL_DRIVER_PATH";

        private static HashSet<string> driverNames;
        private static ILogger Log => Logger.Log.ForContext(typeof(Driver));

        public static IEnumerable<string> DriverNames
        {
            get
            {
                if (driverNames != null && driverNames.Count > 0) return driverNames;

                driverNames = GetDriverNames();
                return driverNames;
            }
        }

        private static HashSet<string> GetDriverNames()
        {
            Log.Debug("Registering GDAL Drivers ...");
            OSGeo.GDAL.Gdal.AllRegister();
            var driverLongNames = new HashSet<string>();
            for (var i = 0; i < OSGeo.GDAL.Gdal.GetDriverCount(); i++)
                driverLongNames.Add(OSGeo.GDAL.Gdal.GetDriver(i).LongName);
            Log.Debug("{DriverLongNamesCount} GDAL Drivers Registered.", driverLongNames.Count);
            return driverLongNames;
        }

        public static void SetGdalDriverPathEnvironment(DirectoryInfo gdalPlugins)
        {
            if (gdalPlugins.Exists)
            {
                Log.Debug("Setting {GDAL_DRIVER_PATH} to {gdalPlugins} ...", GDAL_DRIVER_PATH, gdalPlugins);
                OSGeo.GDAL.Gdal.SetConfigOption(GDAL_DRIVER_PATH, gdalPlugins.FullName);
                Log.Debug("{GDAL_DRIVER_PATH} set to {gdalPlugins}", GDAL_DRIVER_PATH, gdalPlugins);
            }
            else
            {
                Log.Warning("{GDAL_DRIVER_PATH} could not be set because {gdalPlugins} does not exist.",
                    GDAL_DRIVER_PATH, gdalPlugins);
            }
        }

        public static void Register()
        {
            GetDriverNames();
        }
    }
}