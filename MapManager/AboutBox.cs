using System;
using System.Windows.Forms;
using MapManager.Apis.Gdal;

namespace MapManager
{
    /// <summary>
    ///     Provides the about box for the application
    /// </summary>
    partial class AboutBox : Form
    {
        /// <summary>
        ///     Constructs a new AboutBox object.
        /// </summary>
        public AboutBox()
        {
            InitializeComponent();

            Text = $"About {Version.AssemblyTitle}";

            productName.Text = Version.AssemblyProduct;

            version.Text = $"Version {Version.AssemblyVersion}";

            labelCopyright.Text = Version.AssemblyCopyright;

            versionInfo.Text = Apis.MapServer.Version.VersionInfo;

            mapserverFormats.Text = Apis.MapServer.Version.VersionString
                .Substring(Apis.MapServer.Version.VersionString.IndexOf("OUTPUT", StringComparison.Ordinal))
                .Replace(" ", "\r\n");

            gdalFormats.Text = string.Join("\r\n", Driver.DriverNames);

            ogrFormats.Text = string.Join("\r\n", Apis.Ogr.Driver.DriverNames);
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
    }
}