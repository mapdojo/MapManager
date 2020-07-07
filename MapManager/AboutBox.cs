using System.Windows.Forms;
using ReactiveUI;
using MapManager.ViewModels;

namespace MapManager
{
    /// <summary>
    ///     Provides the about box for the application
    /// </summary>
    partial class AboutBox : Form, IViewFor<AboutBoxViewModel>
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
                d(this.OneWayBind(ViewModel, vm => vm.MapserverFormats, v => v.mapserverFormats.Text));
                d(this.OneWayBind(ViewModel, vm => vm.GdalFormats, v => v.gdalFormats.Text));
                d(this.OneWayBind(ViewModel, vm => vm.OgrFormats, v => v.ogrFormats.Text));
            });

            ViewModel = new AboutBoxViewModel();
        }

        /// <summary>
        ///     KeyDown event handler of the AboutBox object.
        /// </summary>
        /// <param name="sender">The source object of this event.</param>
        /// <param name="e">The event parameters.</param>
        private void AboutBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) Close();
        }

        public AboutBoxViewModel ViewModel { get; set; }

        object IViewFor.ViewModel
        {
            get => ViewModel;
            set => ViewModel = (AboutBoxViewModel)value;
        }
    }
}