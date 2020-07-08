using System;
using System.Runtime.InteropServices;
using Serilog;

namespace MapManager.Apis
{
    public class Geos
    {
        private static ILogger Log => Logger.Log.ForContext(typeof(Geos));
        
        [DllImport("geos_c", EntryPoint = "GEOSversion")]
        private static extern IntPtr GEOSversion();
        
        public static string Version
        {
            get
            {
                try
                {
                    Log.Debug("Getting GEOS Version ...");
                    var geos = Marshal.PtrToStringAnsi(GEOSversion());
                    Log.Debug("GEOS Version is {geos}.", geos);
                    return geos;
                }
                catch (Exception)
                {
                    // library not available
                    Log.Warning("GEOS Library is not available.");
                }
                
                return null;
            }
        }
    }
}