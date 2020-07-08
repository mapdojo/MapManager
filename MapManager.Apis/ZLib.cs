using System;
using System.Runtime.InteropServices;
using Serilog;

namespace MapManager.Apis
{
    public class ZLib
    {
        private static ILogger Log => Logger.Log.ForContext(typeof(ZLib));

        [DllImport("zlib1", EntryPoint = "zlibVersion")]
        private static extern IntPtr zlibVersion();
        
        public static string Version
        {
            get
            {
                try
                {
                    Log.Debug("Getting ZLib Version ...");
                    var zlib = Marshal.PtrToStringAnsi(zlibVersion());
                    Log.Debug("ZLib Version is {zlib}.", zlib);
                    return zlib;
                }
                catch (Exception)
                {
                    // library not available
                    Log.Warning("ZLib Library is not available.");
                }

                return null;
            }
        }
    }
}