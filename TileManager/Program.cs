using System;

namespace TileGenerator
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            // post setup install actions
            if (args.Length > 0)
            {
                if (args[0] == "/tile")
                {
                    new MapManager.TileManager.TileGenerator(args[1], args[2], args[3]);
                }
            }
        }
    }
}
