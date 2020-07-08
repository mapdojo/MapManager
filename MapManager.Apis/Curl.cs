using System;
using System.IO;
using System.Runtime.InteropServices;
using OSGeo.MapServer;
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

        private const string CURL_CA_BUNDLE = "CURL_CA_BUNDLE";

        public static void SetCurlCertificateAuthorityBundleEnvironment(FileInfo curlCaBundleCrt)
        {
            if (curlCaBundleCrt.Exists)
            {
                Log.Debug("Setting {CURL_CA_BUNDLE} to {curlCaBundleCrt} ...", CURL_CA_BUNDLE, curlCaBundleCrt);
                mapscript.SetEnvironmentVariable($"{CURL_CA_BUNDLE}={curlCaBundleCrt.FullName}");
                Log.Debug("{CURL_CA_BUNDLE} set to {curlCaBundleCrt}", CURL_CA_BUNDLE, curlCaBundleCrt);
            }
            else
                Log.Warning("{CURL_CA_BUNDLE} could not be set because {curlCaBundleCrt} does not exist.", CURL_CA_BUNDLE, curlCaBundleCrt);
        }
    }
}