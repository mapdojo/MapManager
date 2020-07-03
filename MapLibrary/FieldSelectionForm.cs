using System;
using System.Windows.Forms;
using OSGeo.MapServer;

namespace MapLibrary
{
    public partial class FieldSelectionForm : Form
    {
        public FieldSelectionForm(layerObj layer, string msg)
        {
            InitializeComponent();
            labelItem.Text = msg;
            layer.open();
            for (int i = 0; i < layer.numitems; i++)
            {
                listBoxItems.Items.Add(layer.getItem(i));
            }
            layer.close();
            buttonOK.Enabled = false;
        }

        public string SelectedItem
        {
            get
            {
                return listBoxItems.SelectedItem.ToString();
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void listBoxItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonOK.Enabled = true;
        }
    }
}
