using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.Win32;

namespace MapLibrary
{
    public partial class AddFontForm : Form
    {
        RegistryKey fontsKey;

        public AddFontForm()
        {
            InitializeComponent();
            fontsKey = Registry.LocalMachine.OpenSubKey(@"Software\Microsoft\Windows NT\CurrentVersion\Fonts");
            foreach (string font in fontsKey.GetValueNames())
                if (font.EndsWith("(TrueType)")) 
                    comboBoxFonts.Items.Add(font);

            FontFile = "";
        }

        public string FontName
        {
            get
            {
                return textBoxFontName.Text;
            }
        }

        public string FontFile { get; private set; }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (textBoxFontName.Text.Trim().Length == 0 || textBoxFontName.Text.Contains(" ") || textBoxFontName.Text.Contains("\t") || textBoxFontName.Text.Contains("#"))
            {
                MessageBox.Show("Invalid font name",
                    "MapManager", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // get parent of System folder to have Windows folder
            DirectoryInfo dirWindowsFolder = Directory.GetParent(Environment.GetFolderPath(Environment.SpecialFolder.System));

            // Concatenate Fonts folder onto Windows folder.
            string strFontsFolder = Path.Combine(dirWindowsFolder.FullName, "Fonts");

            FontFile = strFontsFolder + "\\" + fontsKey.GetValue(comboBoxFonts.Text, string.Empty).ToString();

            if (!File.Exists(FontFile))
            {
                MessageBox.Show("Font file doesn't exist",
                   "MapManager", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult = DialogResult.OK;
            fontsKey.Close();
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            fontsKey.Close();
            this.Close();
        }
    }
}
