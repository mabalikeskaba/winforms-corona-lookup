namespace CoronaLookup.View
{
    partial class CaseDetailContainerView
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
      this.mDividerPanel = new System.Windows.Forms.Panel();
      this.mCountryNameLabel = new System.Windows.Forms.Label();
      this.mDateLabel = new CoronaLookup.View.Controls.CaseDetailView();
      this.mTotalRecoveriesLabel = new CoronaLookup.View.Controls.CaseDetailView();
      this.mTotalDeathsLabel = new CoronaLookup.View.Controls.CaseDetailView();
      this.mTotalCasesLabel = new CoronaLookup.View.Controls.CaseDetailView();
      this.SuspendLayout();
      // 
      // mDividerPanel
      // 
      this.mDividerPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
      this.mDividerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.mDividerPanel.Location = new System.Drawing.Point(0, 212);
      this.mDividerPanel.Name = "mDividerPanel";
      this.mDividerPanel.Size = new System.Drawing.Size(346, 2);
      this.mDividerPanel.TabIndex = 7;
      // 
      // mCountryNameLabel
      // 
      this.mCountryNameLabel.AutoSize = true;
      this.mCountryNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.mCountryNameLabel.Location = new System.Drawing.Point(3, 3);
      this.mCountryNameLabel.Name = "mCountryNameLabel";
      this.mCountryNameLabel.Size = new System.Drawing.Size(0, 24);
      this.mCountryNameLabel.TabIndex = 8;
      // 
      // mDateLabel
      // 
      this.mDateLabel.BackColor = System.Drawing.SystemColors.Control;
      this.mDateLabel.DetailContent = null;
      this.mDateLabel.DetailName = "Date:";
      this.mDateLabel.Location = new System.Drawing.Point(0, 171);
      this.mDateLabel.Name = "mDateLabel";
      this.mDateLabel.Size = new System.Drawing.Size(335, 38);
      this.mDateLabel.TabIndex = 12;
      // 
      // mTotalRecoveriesLabel
      // 
      this.mTotalRecoveriesLabel.BackColor = System.Drawing.SystemColors.Control;
      this.mTotalRecoveriesLabel.DetailContent = null;
      this.mTotalRecoveriesLabel.DetailName = "Total recoveries:";
      this.mTotalRecoveriesLabel.Location = new System.Drawing.Point(0, 127);
      this.mTotalRecoveriesLabel.Name = "mTotalRecoveriesLabel";
      this.mTotalRecoveriesLabel.Size = new System.Drawing.Size(335, 38);
      this.mTotalRecoveriesLabel.TabIndex = 11;
      // 
      // mTotalDeathsLabel
      // 
      this.mTotalDeathsLabel.BackColor = System.Drawing.SystemColors.Control;
      this.mTotalDeathsLabel.DetailContent = null;
      this.mTotalDeathsLabel.DetailName = "Total deaths:";
      this.mTotalDeathsLabel.Location = new System.Drawing.Point(0, 83);
      this.mTotalDeathsLabel.Name = "mTotalDeathsLabel";
      this.mTotalDeathsLabel.Size = new System.Drawing.Size(335, 38);
      this.mTotalDeathsLabel.TabIndex = 10;
      // 
      // mTotalCasesLabel
      // 
      this.mTotalCasesLabel.BackColor = System.Drawing.SystemColors.Control;
      this.mTotalCasesLabel.DetailContent = null;
      this.mTotalCasesLabel.DetailName = "Total cases:";
      this.mTotalCasesLabel.Location = new System.Drawing.Point(0, 39);
      this.mTotalCasesLabel.Name = "mTotalCasesLabel";
      this.mTotalCasesLabel.Size = new System.Drawing.Size(335, 38);
      this.mTotalCasesLabel.TabIndex = 9;
      // 
      // CaseDetailContainerView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.mDateLabel);
      this.Controls.Add(this.mTotalRecoveriesLabel);
      this.Controls.Add(this.mTotalDeathsLabel);
      this.Controls.Add(this.mTotalCasesLabel);
      this.Controls.Add(this.mCountryNameLabel);
      this.Controls.Add(this.mDividerPanel);
      this.Name = "CaseDetailContainerView";
      this.Size = new System.Drawing.Size(346, 214);
      this.ResumeLayout(false);
      this.PerformLayout();

        }

    #endregion

    private System.Windows.Forms.Panel mDividerPanel;
        private System.Windows.Forms.Label mCountryNameLabel;
        private Controls.CaseDetailView mTotalCasesLabel;
        private Controls.CaseDetailView mTotalDeathsLabel;
        private Controls.CaseDetailView mTotalRecoveriesLabel;
        private Controls.CaseDetailView mDateLabel;
    }
}
