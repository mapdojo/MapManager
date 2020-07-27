using System;
using System.Linq;
using System.Reactive.Linq;
using System.Windows.Forms;
using MapManager.ViewModels;
using ReactiveUI;

namespace MapLibrary
{
    public partial class AddFontForm : Form, IViewFor<AddFontFormViewModel>
    {
        public AddFontForm()
        {
            InitializeComponent();

            this.WhenActivated(d =>
            {
                comboBoxFonts.DataSource = ViewModel.FontNames.ToList();
                this.Bind(ViewModel, vm => vm.FontAlias, v => v.textBoxFontName.Text);

                this.BindCommand(ViewModel, a => a.Cancel, b => b.buttonCancel);
                this.WhenAnyObservable(o => o.ViewModel.Cancel).Subscribe(_ =>
                {
                    DialogResult = DialogResult.Cancel;
                    Close();
                });
                this.BindCommand(ViewModel, a => a.Ok, b => b.buttonOK);
                this.WhenAnyObservable(o => o.ViewModel.Ok).Subscribe(_ =>
                {
                    DialogResult = DialogResult.OK;
                    Close();
                });
            });

            Observable.FromEventPattern<EventHandler, EventArgs>(
                    ev => comboBoxFonts.SelectedIndexChanged += ev,
                    ev => comboBoxFonts.SelectedIndexChanged -= ev)
                .Select(x => comboBoxFonts.SelectedItem)
                .BindTo(this, x => x.ViewModel.SelectedFont);

            ViewModel = new AddFontFormViewModel();
        }

        public AddFontFormViewModel ViewModel { get; set; }

        object IViewFor.ViewModel
        {
            get => ViewModel;
            set => ViewModel = (AddFontFormViewModel) value;
        }
    }
}