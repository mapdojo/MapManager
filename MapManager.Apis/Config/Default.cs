using Serilog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MapManager.Apis.Config
{
    public class Default
    {
        private static ILogger Log => Logger.Log.ForContext(typeof(Default));
        private static DirectoryInfo directory;

        private static DirectoryInfo GetDirectory()
        {
            var assemblyDirectory
                = new DirectoryInfo(Path.Combine(Path.GetDirectoryName(typeof(Version).Assembly.Location) ?? @"./", "Default"));
            return assemblyDirectory;
        }

        public static DirectoryInfo Directory
        {
            get
            {
                if (directory != null && directory.Exists)
                    return directory;
                directory = GetDirectory();
                return directory;
            }
        }
    }
}
