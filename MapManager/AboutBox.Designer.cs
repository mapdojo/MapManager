namespace MapManager
{
    partial class AboutBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.versionInfo = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.mapserverFormats = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gdalFormats = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.ogrFormats = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.productName = new System.Windows.Forms.Label();
            this.version = new System.Windows.Forms.Label();
            this.labelCopyright = new System.Windows.Forms.Label();
            this.labelCompanyName = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(175, 128);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(345, 153);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.versionInfo);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(337, 127);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Versions";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // versionInfo
            // 
            this.versionInfo.BackColor = System.Drawing.Color.White;
            this.versionInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.versionInfo.Location = new System.Drawing.Point(0, 0);
            this.versionInfo.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.versionInfo.Multiline = true;
            this.versionInfo.Name = "versionInfo";
            this.versionInfo.ReadOnly = true;
            this.versionInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.versionInfo.Size = new System.Drawing.Size(337, 127);
            this.versionInfo.TabIndex = 0;
            this.versionInfo.TabStop = false;
            this.versionInfo.Text = "Description";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.mapserverFormats);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(337, 127);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "MapServer Formats";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // mapserverFormats
            // 
            this.mapserverFormats.BackColor = System.Drawing.Color.White;
            this.mapserverFormats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapserverFormats.Location = new System.Drawing.Point(3, 3);
            this.mapserverFormats.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.mapserverFormats.Multiline = true;
            this.mapserverFormats.Name = "mapserverFormats";
            this.mapserverFormats.ReadOnly = true;
            this.mapserverFormats.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.mapserverFormats.Size = new System.Drawing.Size(331, 121);
            this.mapserverFormats.TabIndex = 24;
            this.mapserverFormats.TabStop = false;
            this.mapserverFormats.Text = "Description";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gdalFormats);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(337, 127);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "GDAL Formats";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gdalFormats
            // 
            this.gdalFormats.BackColor = System.Drawing.Color.White;
            this.gdalFormats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdalFormats.Location = new System.Drawing.Point(3, 3);
            this.gdalFormats.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.gdalFormats.Multiline = true;
            this.gdalFormats.Name = "gdalFormats";
            this.gdalFormats.ReadOnly = true;
            this.gdalFormats.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.gdalFormats.Size = new System.Drawing.Size(331, 121);
            this.gdalFormats.TabIndex = 25;
            this.gdalFormats.TabStop = false;
            this.gdalFormats.Text = "Description";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.ogrFormats);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(337, 127);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "OGR Formats";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // ogrFormats
            // 
            this.ogrFormats.BackColor = System.Drawing.Color.White;
            this.ogrFormats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ogrFormats.Location = new System.Drawing.Point(0, 0);
            this.ogrFormats.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.ogrFormats.Multiline = true;
            this.ogrFormats.Name = "ogrFormats";
            this.ogrFormats.ReadOnly = true;
            this.ogrFormats.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ogrFormats.Size = new System.Drawing.Size(337, 127);
            this.ogrFormats.TabIndex = 25;
            this.ogrFormats.TabStop = false;
            this.ogrFormats.Text = "Description";
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.okButton.Location = new System.Drawing.Point(445, 290);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 26);
            this.okButton.TabIndex = 5;
            this.okButton.Text = "&OK";
            this.okButton.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67F));
            this.tableLayoutPanel.Controls.Add(this.label1, 1, 5);
            this.tableLayoutPanel.Controls.Add(this.logoPictureBox, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.productName, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.version, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.labelCopyright, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.labelCompanyName, 1, 4);
            this.tableLayoutPanel.Controls.Add(this.okButton, 1, 8);
            this.tableLayoutPanel.Controls.Add(this.tabControl1, 1, 7);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(9, 9);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 9;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(523, 319);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(178, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.label1.MaximumSize = new System.Drawing.Size(0, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "support@mapdojo.com";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logoPictureBox.Image = global::MapManager.Properties.Resources.Splash;
            this.logoPictureBox.Location = new System.Drawing.Point(3, 3);
            this.logoPictureBox.Name = "logoPictureBox";
            this.tableLayoutPanel.SetRowSpan(this.logoPictureBox, 9);
            this.logoPictureBox.Size = new System.Drawing.Size(166, 313);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.logoPictureBox.TabIndex = 12;
            this.logoPictureBox.TabStop = false;
            // 
            // productName
            // 
            this.productName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productName.Location = new System.Drawing.Point(178, 15);
            this.productName.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.productName.MaximumSize = new System.Drawing.Size(0, 17);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(342, 17);
            this.productName.TabIndex = 0;
            this.productName.Text = "Product Name";
            this.productName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // version
            // 
            this.version.Dock = System.Windows.Forms.DockStyle.Fill;
            this.version.Location = new System.Drawing.Point(178, 34);
            this.version.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.version.MaximumSize = new System.Drawing.Size(0, 17);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(342, 17);
            this.version.TabIndex = 1;
            this.version.Text = "Version";
            this.version.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCopyright
            // 
            this.labelCopyright.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCopyright.Location = new System.Drawing.Point(178, 53);
            this.labelCopyright.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.labelCopyright.MaximumSize = new System.Drawing.Size(0, 17);
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.Size = new System.Drawing.Size(342, 17);
            this.labelCopyright.TabIndex = 2;
            this.labelCopyright.Text = "Copyright";
            this.labelCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCompanyName
            // 
            this.labelCompanyName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCompanyName.Location = new System.Drawing.Point(178, 72);
            this.labelCompanyName.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.labelCompanyName.MaximumSize = new System.Drawing.Size(0, 17);
            this.labelCompanyName.Name = "labelCompanyName";
            this.labelCompanyName.Size = new System.Drawing.Size(342, 17);
            this.labelCompanyName.TabIndex = 3;
            this.labelCompanyName.Text = "https://support.mapdojo.com";
            this.labelCompanyName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AboutBox
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 337);
            this.Controls.Add(this.tableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutBox";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AboutBox";
            this.tabControl1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox versionInfo;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox mapserverFormats;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox gdalFormats;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox ogrFormats;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Label productName;
        private System.Windows.Forms.Label version;
        private System.Windows.Forms.Label labelCopyright;
        private System.Windows.Forms.Label labelCompanyName;
        private System.Windows.Forms.Label label1;

    }
}
