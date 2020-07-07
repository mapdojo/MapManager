using System;
using System.Runtime.InteropServices;
using System.Text;
using OSGeo.MapServer;

namespace MapManager.Apis.MapServer
{
    public static class Version
    {
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
                OSGeo.GDAL.Gdal.AllRegister();

                var s = new StringBuilder();
                s.AppendLine("MapServer version " + mapscript.MS_VERSION);
                s.AppendLine(OSGeo.GDAL.Gdal.VersionInfo("GDAL_RELEASE_NAME"));
                try
                {
                    s.AppendLine("proj " + Marshal.PtrToStringAnsi(pj_get_release()));
                }
                catch (Exception)
                {
                    // library not available
                }

                try
                {
                    s.AppendLine("geos " + Marshal.PtrToStringAnsi(GEOSversion()));
                }
                catch (Exception)
                {
                    // library not available
                }

                try
                {
                    s.AppendLine("zlib " + Marshal.PtrToStringAnsi(zlibVersion()));
                }
                catch (Exception)
                {
                    // library not available
                }

                try
                {
                    s.AppendLine(Marshal.PtrToStringAnsi(curl_version()));
                }
                catch (Exception)
                {
                    // library not available
                }

                return s.ToString();
            }
        }
    }
}