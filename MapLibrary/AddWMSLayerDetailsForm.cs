using MapManager.ViewModels;
using ReactiveUI;
using System;
using System.Reactive.Linq;
using System.Windows.Forms;
using System.Xml;

namespace MapLibrary
{
    /// <summary>
    /// Represents a Form for changing the map view.
    /// </summary>
    public partial class AddWMSLayerDetailsForm : Form, IViewFor<AddWMSLayerDetailsFormViewModel>
    {
        /// <summary>
        /// Constructs a new ChangeViewForm class.
        /// </summary>
        public AddWMSLayerDetailsForm(XmlDocument doc, string url, string version)
        {
            InitializeComponent();

            this.WhenActivated(d =>
            {
                d(this.OneWayBind(ViewModel, vm => vm.LayerDetails.Url, v => v.textBoxServerURL.Text));
                d(this.OneWayBind(ViewModel, vm => vm.LayerDetails.Title, v => v.textBoxServerName.Text));
                d(this.OneWayBind(ViewModel, vm => vm.LayerDetails.Version, v => v.textBoxVersion.Text));
                d(this.OneWayBind(ViewModel, vm => vm.LayerDetails.Abstract, v => v.textBoxAbstract.Text));
            });

            this.BindCommand(ViewModel, a => a.Ok, b => b.buttonOK);
            this.WhenAnyObservable(o => o.ViewModel.Ok).Subscribe(_ =>
            {
                DialogResult = DialogResult.OK;
                Close();
            });

            var keyDown = Observable.FromEventPattern<KeyEventArgs>(this, "KeyDown");
            keyDown.Subscribe(evt =>
            {
                if (evt.EventArgs.KeyCode == Keys.Escape)
                    Close();
            });

            ViewModel = new AddWMSLayerDetailsFormViewModel(doc, url, version);
        }

        public AddWMSLayerDetailsFormViewModel ViewModel { get; set; }

        object IViewFor.ViewModel
        {
            get => ViewModel;
            set => ViewModel = (AddWMSLayerDetailsFormViewModel)value;
        }
    }
}