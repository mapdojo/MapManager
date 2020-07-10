using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Reactive;
using System.Reactive.Linq;
using MapManager.Apis;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using Serilog;

namespace MapLibrary.ViewModels
{
    public class AddFontFormViewModel : ReactiveObject
    {
        public AddFontFormViewModel()
        {
            FontNames = Font.Names;

            this.WhenAnyValue(a => a.SelectedFont)
                .Select(Font.GetFontFile)
                .ToPropertyEx(this, p => p.FontFile);

            Cancel = ReactiveCommand.Create(() => Log.Debug("Cancel"));

            // TODO: Replace with https://github.com/reactiveui/ReactiveUI.Validation and show Validation Text
            var nameValid = this.WhenAnyValue(x => x.FontAlias,
                a => !string.IsNullOrWhiteSpace(a) && !a.Contains(" ") && !a.Contains("\t") && !a.Contains("#"));
            Ok = ReactiveCommand.Create(() => Log.Debug("Ok"), nameValid);
        }

        private static ILogger Log => Logger.Log.ForContext(typeof(AddFontFormViewModel));

        public ReactiveCommand<Unit, Unit> Cancel { get; }
        public ReactiveCommand<Unit, Unit> Ok { get; }

        [Reactive] public IEnumerable<string> FontNames { get; set; }

        [Reactive] public string SelectedFont { get; set; }

        [Reactive] public string FontAlias { get; set; }

        [SuppressMessage("ReSharper", "UnassignedGetOnlyAutoProperty")]
        public FileInfo FontFile { [ObservableAsProperty] get; }
    }
}