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
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.tableLayoutPanel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // mCaseDetailPanel
      // 
      this.mCaseDetailPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.mCaseDetailPanel.Dock = System.Windows.Forms.DockStyle.Left;
      this.mCaseDetailPanel.Location = new System.Drawing.Point(125, 3);
      this.mCaseDetailPanel.Name = "mCaseDetailPanel";
      this.mCaseDetailPanel.Size = new System.Drawing.Size(404, 29);
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
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 2;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.07692F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.92308F));
      this.tableLayoutPanel1.Controls.Add(this.mCaseDetailLabel, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.mCaseDetailPanel, 1, 0);
      this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 1;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(532, 35);
      this.tableLayoutPanel1.TabIndex = 4;
      // 
      // CaseDetailView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.tableLayoutPanel1);
      this.Name = "CaseDetailView";
      this.Size = new System.Drawing.Size(537, 41);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

        #endregion
        private System.Windows.Forms.Panel mCaseDetailPanel;
        private System.Windows.Forms.Label mCaseDetailLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
