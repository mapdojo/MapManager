using System;
using System.Runtime.InteropServices;
using Serilog;

namespace MapManager.Apis
{
    public class Proj
    {
        private static ILogger Log => Logger.Log.ForContext(typeof(Proj));

        public static string Version
        {
            get
            {
                try
                {
                    Log.Debug("Getting PROJ Version ...");
                    var proj = Marshal.PtrToStringAnsi(pj_get_release());
                    Log.Debug("PROJ Version is {proj}.", proj);
                    return proj;
                }
                catch (Exception)
                {
                    // library not available
                    Log.Warning("PROJ Library is not available.");
                }

                return null;
            }
        }

        [DllImport("proj", EntryPoint = "pj_get_release")]
        private static extern IntPtr pj_get_release();
    }
}