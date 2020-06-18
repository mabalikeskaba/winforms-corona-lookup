namespace CoronaLookup.View.Controls
{
  partial class CountryLookupView
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
        mOpenCsvButton.Click -= (sender, args) => OpenCsvFileDialog();
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
      this.mCountryLabel = new System.Windows.Forms.Label();
      this.mAddButton = new System.Windows.Forms.Button();
      this.mCountrySelection = new System.Windows.Forms.ComboBox();
      this.mDataSourceGroupBox = new System.Windows.Forms.GroupBox();
      this.mOpenCsvButton = new System.Windows.Forms.Button();
      this.mRadButtonFileSystem = new System.Windows.Forms.RadioButton();
      this.mFileSystemText = new System.Windows.Forms.TextBox();
      this.mRadButtonApi = new System.Windows.Forms.RadioButton();
      this.mDataSourceGroupBox.SuspendLayout();
      this.SuspendLayout();
      // 
      // mCountryLabel
      // 
      this.mCountryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.mCountryLabel.Location = new System.Drawing.Point(2, 95);
      this.mCountryLabel.Name = "mCountryLabel";
      this.mCountryLabel.Size = new System.Drawing.Size(84, 23);
      this.mCountryLabel.TabIndex = 1;
      this.mCountryLabel.Text = "Country:";
      this.mCountryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // mAddButton
      // 
      this.mAddButton.AutoSize = true;
      this.mAddButton.Location = new System.Drawing.Point(332, 93);
      this.mAddButton.Name = "mAddButton";
      this.mAddButton.Size = new System.Drawing.Size(93, 31);
      this.mAddButton.TabIndex = 2;
      this.mAddButton.Text = "Add to list";
      this.mAddButton.UseVisualStyleBackColor = true;
      this.mAddButton.Click += new System.EventHandler(this.mAddButton_Click);
      // 
      // mCountrySelection
      // 
      this.mCountrySelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.mCountrySelection.FormattingEnabled = true;
      this.mCountrySelection.Location = new System.Drawing.Point(92, 95);
      this.mCountrySelection.Name = "mCountrySelection";
      this.mCountrySelection.Size = new System.Drawing.Size(234, 28);
      this.mCountrySelection.TabIndex = 3;
      // 
      // mDataSourceGroupBox
      // 
      this.mDataSourceGroupBox.Controls.Add(this.mOpenCsvButton);
      this.mDataSourceGroupBox.Controls.Add(this.mRadButtonFileSystem);
      this.mDataSourceGroupBox.Controls.Add(this.mFileSystemText);
      this.mDataSourceGroupBox.Controls.Add(this.mRadButtonApi);
      this.mDataSourceGroupBox.Location = new System.Drawing.Point(6, 3);
      this.mDataSourceGroupBox.Name = "mDataSourceGroupBox";
      this.mDataSourceGroupBox.Size = new System.Drawing.Size(419, 88);
      this.mDataSourceGroupBox.TabIndex = 4;
      this.mDataSourceGroupBox.TabStop = false;
      this.mDataSourceGroupBox.Text = "Data source";
      // 
      // mOpenCsvButton
      // 
      this.mOpenCsvButton.Enabled = false;
      this.mOpenCsvButton.Location = new System.Drawing.Point(385, 44);
      this.mOpenCsvButton.Name = "mOpenCsvButton";
      this.mOpenCsvButton.Size = new System.Drawing.Size(28, 28);
      this.mOpenCsvButton.TabIndex = 3;
      this.mOpenCsvButton.Text = "...";
      this.mOpenCsvButton.UseVisualStyleBackColor = true;
      // 
      // mRadButtonFileSystem
      // 
      this.mRadButtonFileSystem.AutoSize = true;
      this.mRadButtonFileSystem.Location = new System.Drawing.Point(6, 53);
      this.mRadButtonFileSystem.Name = "mRadButtonFileSystem";
      this.mRadButtonFileSystem.Size = new System.Drawing.Size(14, 13);
      this.mRadButtonFileSystem.TabIndex = 2;
      this.mRadButtonFileSystem.TabStop = true;
      this.mRadButtonFileSystem.UseVisualStyleBackColor = true;
      this.mRadButtonFileSystem.CheckedChanged += new System.EventHandler(this.OnFileSystemRadButtonCheckedChanged);
      // 
      // mFileSystemText
      // 
      this.mFileSystemText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.mFileSystemText.Location = new System.Drawing.Point(26, 45);
      this.mFileSystemText.Name = "mFileSystemText";
      this.mFileSystemText.ReadOnly = true;
      this.mFileSystemText.Size = new System.Drawing.Size(353, 26);
      this.mFileSystemText.TabIndex = 1;
      this.mFileSystemText.Click += new System.EventHandler(this.mFileSystemText_Click);
      // 
      // mRadButtonApi
      // 
      this.mRadButtonApi.AutoSize = true;
      this.mRadButtonApi.Checked = true;
      this.mRadButtonApi.Location = new System.Drawing.Point(6, 22);
      this.mRadButtonApi.Name = "mRadButtonApi";
      this.mRadButtonApi.Size = new System.Drawing.Size(153, 17);
      this.mRadButtonApi.TabIndex = 0;
      this.mRadButtonApi.TabStop = true;
      this.mRadButtonApi.Text = "https://api.covid19api.com";
      this.mRadButtonApi.UseVisualStyleBackColor = true;
      this.mRadButtonApi.CheckedChanged += new System.EventHandler(this.OnApiRadButtonCheckedChanged);
      // 
      // CountryLookupView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.mDataSourceGroupBox);
      this.Controls.Add(this.mCountrySelection);
      this.Controls.Add(this.mAddButton);
      this.Controls.Add(this.mCountryLabel);
      this.Name = "CountryLookupView";
      this.Size = new System.Drawing.Size(428, 131);
      this.mDataSourceGroupBox.ResumeLayout(false);
      this.mDataSourceGroupBox.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion
        private System.Windows.Forms.Label mCountryLabel;
        private System.Windows.Forms.Button mAddButton;
        private System.Windows.Forms.ComboBox mCountrySelection;
        private System.Windows.Forms.GroupBox mDataSourceGroupBox;
        private System.Windows.Forms.RadioButton mRadButtonFileSystem;
        private System.Windows.Forms.TextBox mFileSystemText;
        private System.Windows.Forms.RadioButton mRadButtonApi;
    private System.Windows.Forms.Button mOpenCsvButton;
  }
}
