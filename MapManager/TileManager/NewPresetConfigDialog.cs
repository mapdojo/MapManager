using System;
using System.Windows.Forms;

namespace MapManager.TileManager
{
    public partial class NewPresetConfigDialog : Form
    {
        public NewPresetConfigDialog()
        {
            InitializeComponent();
        }

        private void btnNewPreset_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void NewPresetConfigDialog_Load(object sender, EventArgs e)
        {

        }
    }
}
