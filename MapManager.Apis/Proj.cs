using System;
using System.IO;
using System.Runtime.InteropServices;
using OSGeo.OSR;
using Serilog;

namespace MapManager.Apis
{
    public class Proj
    {
        private const string PROJ_LIB = "PROJ_LIB";

        private static DirectoryInfo projLibDirectory;
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
                    Log.Warning("PROJ Library is not available.");
                }

                return null;
            }
        }

        public static DirectoryInfo ProjLibDirectory
        {
            set
            {
                if (SetProjLibEnvironment(value)) projLibDirectory = value;
            }
            get => projLibDirectory;
        }

        private static bool SetProjLib(DirectoryInfo projLib)
        {
            if (projLib.Exists)
            {
                if (MapServer.VersionSupport.Contains("SUPPORTS=PROJ"))
                {
                    Log.Debug("Setting {PROJ_LIB} to {projLib} ...", PROJ_LIB, projLib);
                    msSetPROJ_LIB(projLib.FullName, null);
                    Osr.SetPROJSearchPath(projLib.FullName);
                    Log.Debug("{PROJ_LIB} set to {projLib}", PROJ_LIB, projLib);
                    return true;
                }

                Log.Warning("{PROJ_LIB} could not be set because SUPPORTS=PROJ is not present.",
                    PROJ_LIB, projLib);
                return false;
            }

            Log.Warning("{PROJ_LIB} could not be set because {projLib} does not exist.",
                PROJ_LIB, projLib);
            return false;
        }

        private static bool SetProjLibEnvironment(DirectoryInfo projLib)
        {
            var projLibIsSet = SetProjLib(projLib);
            if (projLibIsSet) return true;

            var env = Environment.GetEnvironmentVariable(PROJ_LIB);
            if (env == null) return false;

            var envProjLib = new DirectoryInfo(env);
            return SetProjLib(envProjLib);
        }

        [DllImport("proj", EntryPoint = "pj_get_release")]
        private static extern IntPtr pj_get_release();

        [DllImport("mapserver.dll", EntryPoint = "msSetPROJ_LIB", CallingConvention = CallingConvention.Cdecl)]
        private static extern void msSetPROJ_LIB(string proj_lib, string pszRelToPath);
    }
}