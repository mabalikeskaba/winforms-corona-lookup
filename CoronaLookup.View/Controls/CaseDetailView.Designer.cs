namespace CoronaLookup.View.Controls
{
  partial class CaseDetailView
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
      this.mCaseDetailPanel = new System.Windows.Forms.Panel();
      this.mCaseDetailLabel = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // mCaseDetailPanel
      // 
      this.mCaseDetailPanel.Location = new System.Drawing.Point(97, 0);
      this.mCaseDetailPanel.Name = "mCaseDetailPanel";
      this.mCaseDetailPanel.Size = new System.Drawing.Size(166, 32);
      this.mCaseDetailPanel.TabIndex = 1;
      // 
      // mCaseDetailLabel
      // 
      this.mCaseDetailLabel.Location = new System.Drawing.Point(0, 0);
      this.mCaseDetailLabel.Margin = new System.Windows.Forms.Padding(0);
      this.mCaseDetailLabel.Name = "mCaseDetailLabel";
      this.mCaseDetailLabel.Size = new System.Drawing.Size(92, 32);
      this.mCaseDetailLabel.TabIndex = 3;
      this.mCaseDetailLabel.Text = "Total deaths:";
      this.mCaseDetailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // CaseDetailView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.mCaseDetailLabel);
      this.Controls.Add(this.mCaseDetailPanel);
      this.Name = "CaseDetailView";
      this.Size = new System.Drawing.Size(266, 33);
      this.ResumeLayout(false);

    }

        #endregion
        private System.Windows.Forms.Panel mCaseDetailPanel;
        private System.Windows.Forms.Label mCaseDetailLabel;
    }
}
