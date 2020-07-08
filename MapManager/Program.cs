using System;
using System.IO;
using System.Windows.Forms;
using Serilog;
using Splat;
using Splat.Serilog;

namespace MapManager
{
    static class Program
    {
        public static MainForm frmMain = null;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.Console()
                .CreateLogger();
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
            String strFile = File.ReadAllText("Default\\Default.map");
            strFile = strFile.Replace("FONTSET \"font.list\"", "FONTSET \"" + (Application.StartupPath + "\\Default\\font.list\"").Replace("\\", "\\\\"));
            strFile = strFile.Replace("SYMBOLSET \"symbols.sym\"", "SYMBOLSET \"" + (Application.StartupPath + "\\Default\\symbols.sym\"").Replace("\\", "\\\\"));
            File.WriteAllText("Default\\Default.map", strFile);

            // set references in StyleLibrary.map
            strFile = File.ReadAllText("Default\\StyleLibrary.map");
            strFile = strFile.Replace("FONTSET \"font.list\"", "FONTSET \"" + (Application.StartupPath + "\\Default\\font.list\"").Replace("\\", "\\\\"));
            strFile = strFile.Replace("SYMBOLSET \"symbols.sym\"", "SYMBOLSET \"" + (Application.StartupPath + "\\Default\\symbols.sym\"").Replace("\\", "\\\\"));
            File.WriteAllText("Default\\StyleLibrary.map", strFile);

            // set references in Annotation.map
            strFile = File.ReadAllText("Default\\Annotation.map");
            strFile = strFile.Replace("FONTSET \"font.list\"", "FONTSET \"" + (Application.StartupPath + "\\Default\\font.list\"").Replace("\\", "\\\\"));
            strFile = strFile.Replace("SYMBOLSET \"symbols.sym\"", "SYMBOLSET \"" + (Application.StartupPath + "\\Default\\symbols.sym\"").Replace("\\", "\\\\"));
            File.WriteAllText("Default\\Annotation.map", strFile);
        }
    }
}