using MapManager.Apis.Map;
using MapManager.Apis.Wms;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using Splat;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Reactive;
using System.Reactive.Linq;
using System.Xml;
using ILogger = Serilog.ILogger;

namespace MapManager.ViewModels
{
    public class AddWMSLayerFormViewModel : ReactiveObject
    {
        public AddWMSLayerFormViewModel(MapObjectHolder target)
        {
            this.Log().Debug("AddWMSLayerFormViewModel");

            Load = ReactiveCommand.Create(() => { 
                Log.Debug("Load");
                if (Projections != null)
                {
                    var epsg4326 = Projections.Find(f => f.Key == "EPSG:4326");
                    SelectedProjection = epsg4326.Value; // FIX: This doesn't work (and it should default to map projection anyway)
                }
            }); // TODO: Handle Loading in ViewModel

            this.WhenAnyValue(a => a.XmlDocument)
                .Select(s => s != null ? Version.GetVersion(s) : null)
                .ToPropertyEx(this, p => p.ServerVersion);

            this.WhenAnyValue(a => a.XmlDocument)
                .Select(s => s != null ? Format.GetFormatNodes(s) : null)
                .ToPropertyEx(this, p => p.Formats);

            this.WhenAnyValue(a => a.XmlDocument)
                .Select(s => s != null ? Projection.GetProjections(s, Epsgs) : null)
                .ToPropertyEx(this, p => p.Projections);

            Epsgs = Epsg.GetEpsg();
        }

        public ReactiveCommand<Unit, Unit> Load { get; }

        [Reactive] public string ServerUrl { get; set; }
        [Reactive] public XmlDocument XmlDocument { get; set; }
        [Reactive] public Hashtable Epsgs { get; set; }
        [Reactive] public string SelectedProjection { get; set; }

        [SuppressMessage("ReSharper", "UnassignedGetOnlyAutoProperty")]
        public string ServerVersion { [ObservableAsProperty] get; }
        [SuppressMessage("ReSharper", "UnassignedGetOnlyAutoProperty")]
        public IEnumerable<XmlNode> Formats { [ObservableAsProperty] get; }
        [SuppressMessage("ReSharper", "UnassignedGetOnlyAutoProperty")]
        public List<KeyValuePair<string, string>> Projections { [ObservableAsProperty] get; }

        public XmlProxyUrlResolver XmlProxyUrlResolver => new XmlProxyUrlResolver();

        private static ILogger Log => Apis.Logger.Log.ForContext(typeof(AddWMSLayerFormViewModel));
    }
}