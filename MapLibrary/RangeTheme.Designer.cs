namespace MapLibrary
{
    partial class RangeTheme
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.WizardPage1 = new System.Windows.Forms.Panel();
            this.comboBoxMode = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDownClasses = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxColumns = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.WizardPage2 = new System.Windows.Forms.Panel();
            this.colorRampPickerBackgroundColor = new ColorRampPicker();
            this.colorRampPickerOutlineColor = new ColorRampPicker();
            this.colorRampPickerColor = new ColorRampPicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxFirstOnly = new System.Windows.Forms.CheckBox();
            this.checkBoxKeepStyles = new System.Windows.Forms.CheckBox();
            this.layerControl = new LayerControl();
            this.WizardPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownClasses)).BeginInit();
            this.WizardPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // WizardPage1
            // 
            this.WizardPage1.Controls.Add(this.comboBoxMode);
            this.WizardPage1.Controls.Add(this.label7);
            this.WizardPage1.Controls.Add(this.numericUpDownClasses);
            this.WizardPage1.Controls.Add(this.label6);
            this.WizardPage1.Controls.Add(this.comboBoxColumns);
            this.WizardPage1.Controls.Add(this.label2);
            this.WizardPage1.Controls.Add(this.label1);
            this.WizardPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WizardPage1.Location = new System.Drawing.Point(0, 0);
            this.WizardPage1.Name = "WizardPage1";
            this.WizardPage1.Size = new System.Drawing.Size(413, 305);
            this.WizardPage1.TabIndex = 4;
            // 
            // comboBoxMode
            // 
            this.comboBoxMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMode.FormattingEnabled = true;
            this.comboBoxMode.Items.AddRange(new object[] {
            "Equal Interval"});
            this.comboBoxMode.Location = new System.Drawing.Point(102, 169);
            this.comboBoxMode.Name = "comboBoxMode";
            this.comboBoxMode.Size = new System.Drawing.Size(250, 21);
            this.comboBoxMode.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Mode:";
            // 
            // numericUpDownClasses
            // 
            this.numericUpDownClasses.Location = new System.Drawing.Point(102, 132);
            this.numericUpDownClasses.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownClasses.Name = "numericUpDownClasses";
            this.numericUpDownClasses.Size = new System.Drawing.Size(92, 20);
            this.numericUpDownClasses.TabIndex = 4;
            this.numericUpDownClasses.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Classes:";
            // 
            // comboBoxColumns
            // 
            this.comboBoxColumns.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxColumns.FormattingEnabled = true;
            this.comboBoxColumns.Location = new System.Drawing.Point(102, 94);
            this.comboBoxColumns.Name = "comboBoxColumns";
            this.comboBoxColumns.Size = new System.Drawing.Size(250, 21);
            this.comboBoxColumns.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Column:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select a Column to Create the Theme:";
            // 
            // WizardPage2
            // 
            this.WizardPage2.Controls.Add(this.colorRampPickerBackgroundColor);
            this.WizardPage2.Controls.Add(this.colorRampPickerOutlineColor);
            this.WizardPage2.Controls.Add(this.colorRampPickerColor);
            this.WizardPage2.Controls.Add(this.label5);
            this.WizardPage2.Controls.Add(this.label4);
            this.WizardPage2.Controls.Add(this.label3);
            this.WizardPage2.Controls.Add(this.checkBoxFirstOnly);
            this.WizardPage2.Controls.Add(this.checkBoxKeepStyles);
            this.WizardPage2.Controls.Add(this.layerControl);
            this.WizardPage2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WizardPage2.Location = new System.Drawing.Point(0, 0);
            this.WizardPage2.Name = "WizardPage2";
            this.WizardPage2.Size = new System.Drawing.Size(413, 305);
            this.WizardPage2.TabIndex = 4;
            // 
            // colorRampPickerBackgroundColor
            // 
            this.colorRampPickerBackgroundColor.BackColor = System.Drawing.SystemColors.Window;
            this.colorRampPickerBackgroundColor.Context = null;
            this.colorRampPickerBackgroundColor.ForeColor = System.Drawing.SystemColors.WindowText;
            this.colorRampPickerBackgroundColor.Location = new System.Drawing.Point(144, 279);
            this.colorRampPickerBackgroundColor.Name = "colorRampPickerBackgroundColor";
            this.colorRampPickerBackgroundColor.ReadOnly = false;
            this.colorRampPickerBackgroundColor.Size = new System.Drawing.Size(238, 20);
            this.colorRampPickerBackgroundColor.TabIndex = 11;
            this.colorRampPickerBackgroundColor.Value = ColorRampValueList.Empty;
            this.colorRampPickerBackgroundColor.ValueChanged += new System.EventHandler(this.colorRampPickerBackgroundColor_ValueChanged);
            // 
            // colorRampPickerOutlineColor
            // 
            this.colorRampPickerOutlineColor.BackColor = System.Drawing.SystemColors.Window;
            this.colorRampPickerOutlineColor.Context = null;
            this.colorRampPickerOutlineColor.ForeColor = System.Drawing.SystemColors.WindowText;
            this.colorRampPickerOutlineColor.Location = new System.Drawing.Point(144, 253);
            this.colorRampPickerOutlineColor.Name = "colorRampPickerOutlineColor";
            this.colorRampPickerOutlineColor.ReadOnly = false;
            this.colorRampPickerOutlineColor.Size = new System.Drawing.Size(238, 20);
            this.colorRampPickerOutlineColor.TabIndex = 11;
            this.colorRampPickerOutlineColor.Value = ColorRampValueList.Empty;
            this.colorRampPickerOutlineColor.ValueChanged += new System.EventHandler(this.colorRampPickerOutlineColor_ValueChanged);
            // 
            // colorRampPickerColor
            // 
            this.colorRampPickerColor.BackColor = System.Drawing.SystemColors.Window;
            this.colorRampPickerColor.Context = null;
            this.colorRampPickerColor.ForeColor = System.Drawing.SystemColors.WindowText;
            this.colorRampPickerColor.Location = new System.Drawing.Point(144, 226);
            this.colorRampPickerColor.Name = "colorRampPickerColor";
            this.colorRampPickerColor.ReadOnly = false;
            this.colorRampPickerColor.Size = new System.Drawing.Size(238, 20);
            this.colorRampPickerColor.TabIndex = 10;
            this.colorRampPickerColor.Value = ColorRampValueList.Random;
            this.colorRampPickerColor.ValueChanged += new System.EventHandler(this.colorRampPickerColor_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Background Colour Ramp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Outline Colour Ramp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Colour Ramp";
            // 
            // checkBoxFirstOnly
            // 
            this.checkBoxFirstOnly.AutoSize = true;
            this.checkBoxFirstOnly.Location = new System.Drawing.Point(237, 206);
            this.checkBoxFirstOnly.Name = "checkBoxFirstOnly";
            this.checkBoxFirstOnly.Size = new System.Drawing.Size(156, 17);
            this.checkBoxFirstOnly.TabIndex = 2;
            this.checkBoxFirstOnly.Text = "Override Only the First Style";
            this.checkBoxFirstOnly.UseVisualStyleBackColor = true;
            this.checkBoxFirstOnly.CheckedChanged += new System.EventHandler(this.checkBoxFirstOnly_CheckedChanged);
            // 
            // checkBoxKeepStyles
            // 
            this.checkBoxKeepStyles.AutoSize = true;
            this.checkBoxKeepStyles.Location = new System.Drawing.Point(13, 206);
            this.checkBoxKeepStyles.Name = "checkBoxKeepStyles";
            this.checkBoxKeepStyles.Size = new System.Drawing.Size(218, 17);
            this.checkBoxKeepStyles.TabIndex = 1;
            this.checkBoxKeepStyles.Text = "Derive the Styles from The Original Layer";
            this.checkBoxKeepStyles.UseVisualStyleBackColor = true;
            this.checkBoxKeepStyles.CheckedChanged += new System.EventHandler(this.checkBoxKeepStyles_CheckedChanged);
            // 
            // layerControl
            // 
            this.layerControl.Location = new System.Drawing.Point(0, 0);
            this.layerControl.Name = "layerControl";
            this.layerControl.ShowCheckBoxes = true;
            this.layerControl.ShowClasses = true;
            this.layerControl.ShowRootObject = true;
            this.layerControl.ShowStyles = false;
            this.layerControl.ShowLabels = false;
            this.layerControl.Size = new System.Drawing.Size(410, 200);
            this.layerControl.TabIndex = 0;
            this.layerControl.Target = null;
            // 
            // RangeTheme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.WizardPage2);
            this.Controls.Add(this.WizardPage1);
            this.Name = "RangeTheme";
            this.Size = new System.Drawing.Size(413, 305);
            this.WizardPage1.ResumeLayout(false);
            this.WizardPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownClasses)).EndInit();
            this.WizardPage2.ResumeLayout(false);
            this.WizardPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel WizardPage1;
        private System.Windows.Forms.ComboBox comboBoxColumns;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel WizardPage2;
        private LayerControl layerControl;
        private System.Windows.Forms.CheckBox checkBoxKeepStyles;
        private System.Windows.Forms.CheckBox checkBoxFirstOnly;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxMode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDownClasses;
        private System.Windows.Forms.Label label6;
        private ColorRampPicker colorRampPickerBackgroundColor;
        private ColorRampPicker colorRampPickerOutlineColor;
        private ColorRampPicker colorRampPickerColor;
    }
}
