using ReactiveUI;
using System;

namespace MapManager.ViewModels
{
    public class AboutBoxViewModel : ReactiveObject
    {
        private string title;
        private string productName;
        private string version;
        private string copyright;
        private string versionInfo;
        private string mapserverFormats;
        private string gdalFormats;
        private string ogrFormats;

        public AboutBoxViewModel()
        {
            Title = $"About {MapManager.Version.AssemblyTitle}";
            ProductName = MapManager.Version.AssemblyProduct;
            Version = $"Version {MapManager.Version.AssemblyVersion}";
            Copyright = MapManager.Version.AssemblyCopyright;
            VersionInfo = Apis.MapServer.Version.VersionInfo;
            MapserverFormats = Apis.MapServer.Version.VersionString
                .Substring(Apis.MapServer.Version.VersionString.IndexOf("OUTPUT", StringComparison.Ordinal))
                .Replace(" ", "\r\n");
            GdalFormats = string.Join("\r\n", Apis.Gdal.Driver.DriverNames);
            OgrFormats = string.Join("\r\n", Apis.Ogr.Driver.DriverNames);
        }

        public string Title { get => title; set => title = this.RaiseAndSetIfChanged(ref title, value); }
        public string ProductName { get => productName; set => this.RaiseAndSetIfChanged(ref productName, value); }
        public string Version { get => version; set => this.RaiseAndSetIfChanged(ref version, value); }
        public string Copyright { get => copyright; set => this.RaiseAndSetIfChanged(ref copyright, value); }
        public string VersionInfo { get => versionInfo; set => this.RaiseAndSetIfChanged(ref versionInfo, value); }
        public string MapserverFormats { get => mapserverFormats; set => this.RaiseAndSetIfChanged(ref mapserverFormats, value); }
        public string GdalFormats { get => gdalFormats; set => this.RaiseAndSetIfChanged(ref gdalFormats, value); }
        public string OgrFormats { get => ogrFormats; set => this.RaiseAndSetIfChanged(ref ogrFormats, value); }
    }
}
