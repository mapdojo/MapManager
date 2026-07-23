using MapManager.Apis;
using Serilog;
using Serilog.Events;
using System.IO;
using Xunit;

namespace MapManager.Tests.Apis.Config
{
    public class ConfigTest
    {
        private static string OutputDirectory => AppContext.BaseDirectory.TrimEnd(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar);
        private static string DefaultDirectory => Path.Combine(OutputDirectory, "Default");
        private static string SharedDirectory => new DirectoryInfo(OutputDirectory).Parent.Parent.FullName + Path.DirectorySeparatorChar + "Shared";

        private ILogger Log { get; }

        public ConfigTest(ITestOutputHelper output)
        {
            Log = new LoggerConfiguration()
                .MinimumLevel.Debug()
                // .WriteTo.TestOutput(output, LogEventLevel.Debug,
                //     "{Timestamp:yyyy-MM-dd HH:mm:ss} [{Level}] [{SourceContext}] {Message}{NewLine}{Exception}")
                .Enrich.FromLogContext()
                .CreateLogger()
                .ForContext<ConfigTest>();
            Logger.Init(Log);
        }

        [Fact]
        public void Default()
        {
            var fullName = MapManager.Apis.Config.Default.Directory.FullName;
            Log.Debug(fullName);
            Assert.Equal(DefaultDirectory, fullName);
        }
        
        [Fact]
        public void DefaultAnnotationMap()
        {
            var fullName = MapManager.Apis.Config.DefaultAnnotationMap.File.FullName;
            Log.Debug(fullName);
            Assert.Equal(Path.Combine(DefaultDirectory, "Annotation.map"), fullName);
        }
        
        [Fact]
        public void DefaultFontList()
        {
            var fullName = MapManager.Apis.Config.DefaultFontList.File.FullName;
            Log.Debug(fullName);
            Assert.Equal(Path.Combine(DefaultDirectory, "font.list"), fullName);
        }
        
        [Fact]
        public void DefaultMap()
        {
            var fullName = MapManager.Apis.Config.DefaultMap.File.FullName;
            Log.Debug(fullName);
            Assert.Equal(Path.Combine(DefaultDirectory, "Default.map"), fullName);
        }
        
        [Fact]
        public void DefaultStyleLibraryMap()
        {
            var fullName = MapManager.Apis.Config.DefaultStyleLibraryMap.File.FullName;
            Log.Debug(fullName);
            Assert.Equal(Path.Combine(DefaultDirectory, "StyleLibrary.map"), fullName);
        }
        
        [Fact]
        public void DefaultSymbols()
        {
            var fullName = MapManager.Apis.Config.DefaultSymbols.File.FullName;
            Log.Debug(fullName);
            Assert.Equal(Path.Combine(DefaultDirectory, "symbols.sym"), fullName);
        }
        
        [Fact]
        public void Shared()
        {
            var fullName = MapManager.Apis.Config.Shared.Directory.FullName;
            Log.Debug(fullName);
            Assert.Equal(SharedDirectory, fullName);
        }
        
        [Fact]
        public void SharedAnnotationMap()
        {
            var fullName = MapManager.Apis.Config.SharedAnnotationMap.File.FullName;
            Log.Debug(fullName);
            Assert.Equal(Path.Combine(SharedDirectory, "Annotation.map"), fullName);
        }
        
        [Fact]
        public void SharedFontList()
        {
            var fullName = MapManager.Apis.Config.SharedFontList.File.FullName;
            Log.Debug(fullName);
            Assert.Equal(Path.Combine(SharedDirectory, "font.list"), fullName);
        }
        
        [Fact]
        public void SharedMap()
        {
            var fullName = MapManager.Apis.Config.SharedDefaultMap.File.FullName;
            Log.Debug(fullName);
            Assert.Equal(Path.Combine(SharedDirectory, "Default.map"), fullName);
        }
        
        [Fact]
        public void SharedStyleLibraryMap()
        {
            var fullName = MapManager.Apis.Config.SharedStyleLibraryMap.File.FullName;
            Log.Debug(fullName);
            Assert.Equal(Path.Combine(SharedDirectory, "StyleLibrary.map"), fullName);
        }
        
        [Fact]
        public void SharedSymbols()
        {
            var fullName = MapManager.Apis.Config.SharedSymbols.File.FullName;
            Log.Debug(fullName);
            Assert.Equal(Path.Combine(SharedDirectory, "symbols.sym"), fullName);
        }
    }
}
