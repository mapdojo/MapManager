using System;
using System.Runtime.InteropServices;
using Serilog;

namespace MapManager.Apis
{
    public class Curl
    {
        private static ILogger Log => Logger.Log.ForContext(typeof(Curl));

        [DllImport("libcurl", EntryPoint = "curl_version")]
        private static extern IntPtr curl_version();
        
        public static string Version
        {
            get
            {
                try
                {
                    Log.Debug("Getting cUrl Version ...");
                    var curl = Marshal.PtrToStringAnsi(curl_version());
                    Log.Debug("cUrl Version is {curl}.", curl);
                    return curl;
                }
                catch (Exception)
                {
                    // library not available
                    Log.Warning("cUrl Library is not available.");
                }

                return null;
            }
        }
    }
}