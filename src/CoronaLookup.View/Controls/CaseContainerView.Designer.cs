namespace CoronaLookup.View.Controls
{
  partial class CaseContainerView
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
      this.components = new System.ComponentModel.Container();
      this.mExportContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.exportAsCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.mExportContextMenuStrip.SuspendLayout();
      this.SuspendLayout();
      // 
      // mExportContextMenuStrip
      // 
      this.mExportContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportAsCSVToolStripMenuItem});
      this.mExportContextMenuStrip.Name = "mExportContextMenuStrip";
      this.mExportContextMenuStrip.Size = new System.Drawing.Size(181, 48);
      // 
      // exportAsCSVToolStripMenuItem
      // 
      this.exportAsCSVToolStripMenuItem.Enabled = false;
      this.exportAsCSVToolStripMenuItem.Name = "exportAsCSVToolStripMenuItem";
      this.exportAsCSVToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.exportAsCSVToolStripMenuItem.Text = "Export as CSV";
      this.exportAsCSVToolStripMenuItem.Click += new System.EventHandler(this.exportAsCSVToolStripMenuItem_Click);
      // 
      // CaseContainerView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoScroll = true;
      this.ContextMenuStrip = this.mExportContextMenuStrip;
      this.Name = "CaseContainerView";
      this.mExportContextMenuStrip.ResumeLayout(false);
      this.ResumeLayout(false);

    }

        #endregion

        private System.Windows.Forms.ContextMenuStrip mExportContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem exportAsCSVToolStripMenuItem;
    }
}
