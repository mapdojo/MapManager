using System;
using System.Reactive.Linq;
using System.Windows.Forms;
using MapManager.ViewModels;
using ReactiveUI;

namespace MapManager
{
    /// <summary>
    ///     Provides the about box for the application
    /// </summary>
    internal partial class AboutBox : Form, IViewFor<AboutBoxViewModel>
    {
        /// <summary>
        ///     Constructs a new AboutBox object.
        /// </summary>
        public AboutBox()
        {
            InitializeComponent();

            this.WhenActivated(d =>
            {
                d(this.OneWayBind(ViewModel, vm => vm.Title, v => v.Text));
                d(this.OneWayBind(ViewModel, vm => vm.ProductName, v => v.productName.Text));
                d(this.OneWayBind(ViewModel, vm => vm.Version, v => v.version.Text));
                d(this.OneWayBind(ViewModel, vm => vm.Copyright, v => v.labelCopyright.Text));
                d(this.OneWayBind(ViewModel, vm => vm.VersionInfo, v => v.versionInfo.Text));
                d(this.OneWayBind(ViewModel, vm => vm.MapServerFormats, v => v.mapserverFormats.Text));
                d(this.OneWayBind(ViewModel, vm => vm.GdalFormats, v => v.gdalFormats.Text));
                d(this.OneWayBind(ViewModel, vm => vm.OgrFormats, v => v.ogrFormats.Text));
            });

            var keyDown = Observable.FromEventPattern<KeyEventArgs>(this, "KeyDown");
            keyDown.Subscribe(evt =>
            {
                if (evt.EventArgs.KeyCode == Keys.Escape)
                    Close();
            });

            ViewModel = new AboutBoxViewModel();
        }

        public AboutBoxViewModel ViewModel { get; set; }

        object IViewFor.ViewModel
        {
            get => ViewModel;
            set => ViewModel = (AboutBoxViewModel) value;
        }
    }
}