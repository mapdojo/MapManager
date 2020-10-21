using MapManager.Apis;
using Serilog;
using Serilog.Events;
using Xunit;
using Xunit.Abstractions;

namespace MapManager.Tests.Apis.Config
{
    public class ConfigTest
    {
        private ILogger Log { get; }

        public ConfigTest(ITestOutputHelper output)
        {
            Log = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.TestOutput(output, LogEventLevel.Debug,
                    "{Timestamp:yyyy-MM-dd HH:mm:ss} [{Level}] [{SourceContext}] {Message}{NewLine}{Exception}")
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
            Assert.Equal(@"C:\Code\mapdojo\Xyzt\MapManager\MapManager.Tests\bin\Debug\net461\Default", fullName);
        }
        
        [Fact]
        public void DefaultAnnotationMap()
        {
            var fullName = MapManager.Apis.Config.DefaultAnnotationMap.File.FullName;
            Log.Debug(fullName);
            Assert.Equal(@"C:\Code\mapdojo\Xyzt\MapManager\MapManager.Tests\bin\Debug\net461\Default\Annotation.map", fullName);
        }
        
        [Fact]
        public void DefaultFontList()
        {
            var fullName = MapManager.Apis.Config.DefaultFontList.File.FullName;
            Log.Debug(fullName);
            Assert.Equal(@"C:\Code\mapdojo\Xyzt\MapManager\MapManager.Tests\bin\Debug\net461\Default\font.list", fullName);
        }
        
        [Fact]
        public void DefaultMap()
        {
            var fullName = MapManager.Apis.Config.DefaultMap.File.FullName;
            Log.Debug(fullName);
            Assert.Equal(@"C:\Code\mapdojo\Xyzt\MapManager\MapManager.Tests\bin\Debug\net461\Default\Default.map", fullName);
        }
        
        [Fact]
        public void DefaultStyleLibraryMap()
        {
            var fullName = MapManager.Apis.Config.DefaultStyleLibraryMap.File.FullName;
            Log.Debug(fullName);
            Assert.Equal(@"C:\Code\mapdojo\Xyzt\MapManager\MapManager.Tests\bin\Debug\net461\Default\StyleLibrary.map", fullName);
        }
        
        [Fact]
        public void DefaultSymbols()
        {
            var fullName = MapManager.Apis.Config.DefaultSymbols.File.FullName;
            Log.Debug(fullName);
            Assert.Equal(@"C:\Code\mapdojo\Xyzt\MapManager\MapManager.Tests\bin\Debug\net461\Default\symbols.sym", fullName);
        }
        
        [Fact]
        public void Shared()
        {
            var fullName = MapManager.Apis.Config.Shared.Directory.FullName;
            Log.Debug(fullName);
            Assert.Equal(@"C:\Code\mapdojo\Xyzt\MapManager\MapManager.Tests\bin\Shared", fullName);
        }
        
        [Fact]
        public void SharedAnnotationMap()
        {
            var fullName = MapManager.Apis.Config.SharedAnnotationMap.File.FullName;
            Log.Debug(fullName);
            Assert.Equal(@"C:\Code\mapdojo\Xyzt\MapManager\MapManager.Tests\bin\Debug\net461\Default\Annotation.map", fullName);
        }
        
        [Fact]
        public void SharedFontList()
        {
            var fullName = MapManager.Apis.Config.SharedFontList.File.FullName;
            Log.Debug(fullName);
            Assert.Equal(@"C:\Code\mapdojo\Xyzt\MapManager\MapManager.Tests\bin\Debug\net461\Default\font.list", fullName);
        }
        
        [Fact]
        public void SharedMap()
        {
            var fullName = MapManager.Apis.Config.SharedDefaultMap.File.FullName;
            Log.Debug(fullName);
            Assert.Equal(@"C:\Code\mapdojo\Xyzt\MapManager\MapManager.Tests\bin\Debug\net461\Default\Default.map", fullName);
        }
        
        [Fact]
        public void SharedStyleLibraryMap()
        {
            var fullName = MapManager.Apis.Config.SharedStyleLibraryMap.File.FullName;
            Log.Debug(fullName);
            Assert.Equal(@"C:\Code\mapdojo\Xyzt\MapManager\MapManager.Tests\bin\Debug\net461\Default\StyleLibrary.map", fullName);
        }
        
        [Fact]
        public void SharedSymbols()
        {
            var fullName = MapManager.Apis.Config.SharedSymbols.File.FullName;
            Log.Debug(fullName);
            Assert.Equal(@"C:\Code\mapdojo\Xyzt\MapManager\MapManager.Tests\bin\Debug\net461\Default\symbols.sym", fullName);
        }
    }
}
