using System;
using System.IO;
using System.Windows.Forms;
using MapManager.Apis;
using Serilog;
using Splat;
using Splat.Serilog;

namespace MapManager
{
    static class Program
    {
        private static Serilog.ILogger Log => Logger.Log.ForContext(typeof(Program));

        public static MainForm frmMain = null;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Log.Information("MapManager starting ...");
            Locator.CurrentMutable.UseSerilogFullLogger();

            // setting the current directory equal to the executing directory
            if (Environment.CurrentDirectory != Application.StartupPath)
            {
                Environment.CurrentDirectory = Application.StartupPath;
            }

            // TODO: Check to see if files have been altered
            ReplaceFiles();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            frmMain = new MainForm();
            Application.Run(frmMain);
        }

        static void ReplaceFiles()
        {
            try
            {
                if (!Apis.Config.SharedFontList.File.Exists)
                {
                    File.Copy(Apis.Config.DefaultFontList.File.FullName, Apis.Config.SharedFontList.File.FullName);
                }

                if (!Apis.Config.SharedSymbols.File.Exists)
                {
                    File.Copy(Apis.Config.DefaultSymbols.File.FullName, Apis.Config.SharedSymbols.File.FullName);
                }

                // set references in Default.map
                var replaceMapText = File.ReadAllText(Apis.Config.DefaultMap.File.FullName);
                replaceMapText = replaceMapText.Replace("FONTSET \"font.list\"",
                    $"FONTSET \"{Apis.Config.SharedFontList.File.FullName.Replace(@"\", @"\\")}\"");
                replaceMapText = replaceMapText.Replace("SYMBOLSET \"symbols.sym\"",
                    $"SYMBOLSET \"{Apis.Config.SharedSymbols.File.FullName.Replace(@"\", @"\\")}\"");
                File.WriteAllText(Apis.Config.SharedDefaultMap.File.FullName, replaceMapText);

                if (!Apis.Config.SharedStyleLibraryMap.File.Exists)
                {
                    // set references in StyleLibrary.map
                    var replaceStyleLibraryMapText = File.ReadAllText(Apis.Config.DefaultStyleLibraryMap.File.FullName);
                    replaceStyleLibraryMapText = replaceStyleLibraryMapText.Replace("FONTSET \"font.list\"",
                        $"FONTSET \"{Apis.Config.SharedFontList.File.FullName.Replace(@"\", @"\\")}\"");
                    replaceStyleLibraryMapText = replaceStyleLibraryMapText.Replace("SYMBOLSET \"symbols.sym\"",
                        $"SYMBOLSET \"{Apis.Config.SharedSymbols.File.FullName.Replace(@"\", @"\\")}\"");
                    File.WriteAllText(Apis.Config.SharedStyleLibraryMap.File.FullName, replaceStyleLibraryMapText);
                }

                if (!Apis.Config.SharedAnnotationMap.File.Exists)
                {
                    // set references in Annotation.map
                    var replaceAnnotationMapText = File.ReadAllText(Apis.Config.DefaultAnnotationMap.File.FullName);
                    replaceAnnotationMapText = replaceAnnotationMapText.Replace("FONTSET \"font.list\"",
                        $"FONTSET \"{Apis.Config.SharedFontList.File.FullName.Replace(@"\", @"\\")}\"");
                    replaceAnnotationMapText = replaceAnnotationMapText.Replace("SYMBOLSET \"symbols.sym\"",
                        $"SYMBOLSET \"{Apis.Config.SharedSymbols.File.FullName.Replace(@"\", @"\\")}\"");
                    File.WriteAllText(Apis.Config.SharedAnnotationMap.File.FullName, replaceAnnotationMapText);
                } 
            }
            catch (UnauthorizedAccessException unauthorizedAccessException)
            {
                Log.Error(unauthorizedAccessException, unauthorizedAccessException.Message);
                MessageBox.Show(unauthorizedAccessException.Message, "MapManager", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                Log.Error(ex, ex.Message);
                MessageBox.Show(ex.Message, "MapManager", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}