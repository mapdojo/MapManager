using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Win32;
using Serilog;

namespace MapManager.Apis
{
    public class Font
    {
        private const string FONTS_KEY = @"Software\Microsoft\Windows NT\CurrentVersion\Fonts";
        // TODO: FontsKey.Close() needs to be called in Dispose, but need to make instance or singleton for that
        private static readonly RegistryKey FontsKey = Registry.LocalMachine.OpenSubKey(FONTS_KEY);

        private static HashSet<string> names;
        private static ILogger Log => Logger.Log.ForContext(typeof(Font));

        public static IEnumerable<string> Names
        {
            get
            {
                if (names != null && names.Count > 0) return names;

                names = GetFontNames();
                return names;
            }
        }

        private static HashSet<string> GetFontNames()
        {
            Log.Debug("Getting Font Names ...");
            names = new HashSet<string>();
            foreach (var font in FontsKey.GetValueNames())
                if (font.EndsWith("(TrueType)"))
                    names.Add(font);
            Log.Debug("{FontCount} Font Names.", names.Count);
            return names;
        }

        private static readonly DirectoryInfo FontDirectory = new DirectoryInfo(Path.Combine(Directory.GetParent(Environment.GetFolderPath(Environment.SpecialFolder.System)).FullName, "Fonts"));

        public static FileInfo GetFontFile(string fontName)
        {
            var fileName = FontsKey.GetValue(fontName, string.Empty);
            return new FileInfo(Path.Combine(FontDirectory.FullName, $"{fileName}"));
        }
    }
}