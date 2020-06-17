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
      this.mCaseDetailLabel = new System.Windows.Forms.Label();
      this.mCaseContentLabel = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // mCaseDetailLabel
      // 
      this.mCaseDetailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.mCaseDetailLabel.Location = new System.Drawing.Point(0, 0);
      this.mCaseDetailLabel.Margin = new System.Windows.Forms.Padding(0);
      this.mCaseDetailLabel.Name = "mCaseDetailLabel";
      this.mCaseDetailLabel.Size = new System.Drawing.Size(120, 32);
      this.mCaseDetailLabel.TabIndex = 3;
      this.mCaseDetailLabel.Text = "Total deaths:";
      this.mCaseDetailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // mCaseContentLabel
      // 
      this.mCaseContentLabel.AutoSize = true;
      this.mCaseContentLabel.Location = new System.Drawing.Point(131, 10);
      this.mCaseContentLabel.Name = "mCaseContentLabel";
      this.mCaseContentLabel.Size = new System.Drawing.Size(35, 13);
      this.mCaseContentLabel.TabIndex = 4;
      this.mCaseContentLabel.Text = "label1";
      // 
      // CaseDetailView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.Control;
      this.Controls.Add(this.mCaseContentLabel);
      this.Controls.Add(this.mCaseDetailLabel);
      this.Name = "CaseDetailView";
      this.Size = new System.Drawing.Size(335, 38);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion
        private System.Windows.Forms.Label mCaseDetailLabel;
        private System.Windows.Forms.Label mCaseContentLabel;
    }
}
