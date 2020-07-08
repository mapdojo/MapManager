using System;
using System.Runtime.InteropServices;
using System.Text;
using OSGeo.MapServer;
using Serilog;

namespace MapManager.Apis.MapServer
{
    public class Version
    {
        private static ILogger Log => Logger.Log.ForContext(typeof(Version));
        
        public static readonly string VersionString = mapscript.msGetVersion();

        [DllImport("proj", EntryPoint = "pj_get_release")]
        private static extern IntPtr pj_get_release();

        [DllImport("geos_c", EntryPoint = "GEOSversion")]
        private static extern IntPtr GEOSversion();

        [DllImport("zlib1", EntryPoint = "zlibVersion")]
        private static extern IntPtr zlibVersion();

        [DllImport("libcurl", EntryPoint = "curl_version")]
        private static extern IntPtr curl_version();

        /// <summary>
        ///     Collect the versions of the dependent libraries
        /// </summary>
        /// <returns></returns>
        public static string VersionInfo
        {
            get
            {
                Log.Debug("Registering GDAL Drivers ...");
                OSGeo.GDAL.Gdal.AllRegister();
                Log.Debug("GDAL Drivers Registered.");

                var s = new StringBuilder();
                s.AppendLine("MapServer version " + mapscript.MS_VERSION);
                s.AppendLine(OSGeo.GDAL.Gdal.VersionInfo("GDAL_RELEASE_NAME"));
                try
                {
                    Log.Debug("Getting PROJ Version ...");
                    var proj = Marshal.PtrToStringAnsi(pj_get_release());
                    s.AppendLine($"proj {proj}");
                    Log.Debug("PROJ Version is {proj}.", proj);
                }
                catch (Exception)
                {
                    // library not available
                    Log.Warning("PROJ Library is not available.");
                }

                try
                {
                    Log.Debug("Getting GEOS Version ...");
                    var geos = Marshal.PtrToStringAnsi(GEOSversion());
                    s.AppendLine($"geos {geos}");
                    Log.Debug("GEOS Version is {geos}.", geos);
                }
                catch (Exception)
                {
                    // library not available
                    Log.Warning("GEOS Library is not available.");
                }

                try
                {
                    Log.Debug("Getting ZLib Version ...");
                    var zlib = Marshal.PtrToStringAnsi(zlibVersion());
                    s.AppendLine($"zlib {zlib}");
                    Log.Debug("ZLib Version is {zlib}.", zlib);
                }
                catch (Exception)
                {
                    // library not available
                    Log.Warning("ZLib Library is not available.");
                }

                try
                {
                    Log.Debug("Getting cUrl Version ...");
                    var curl = Marshal.PtrToStringAnsi(curl_version());
                    s.AppendLine(curl);
                    Log.Debug("cUrl Version is {curl}.", curl);
                }
                catch (Exception)
                {
                    // library not available
                    Log.Warning("cUrl Library is not available.");
                }

                return s.ToString();
            }
        }
    }
}