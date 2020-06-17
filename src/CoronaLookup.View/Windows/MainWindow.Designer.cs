﻿namespace CoronaLookup.View.Windows
{
  partial class MainWindow
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

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
      this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
      this.caseContainerView1 = new CoronaLookup.View.Controls.CaseContainerView();
      this.countryLookupView1 = new CoronaLookup.View.Controls.CountryLookupView();
      this.SuspendLayout();
      // 
      // caseContainerView1
      // 
      this.caseContainerView1.AutoScroll = true;
      this.caseContainerView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.caseContainerView1.Location = new System.Drawing.Point(11, 163);
      this.caseContainerView1.Name = "caseContainerView1";
      this.caseContainerView1.Size = new System.Drawing.Size(415, 335);
      this.caseContainerView1.TabIndex = 1;
      // 
      // countryLookupView1
      // 
      this.countryLookupView1.AutoSize = true;
      this.countryLookupView1.Location = new System.Drawing.Point(0, 0);
      this.countryLookupView1.Name = "countryLookupView1";
      this.countryLookupView1.Size = new System.Drawing.Size(437, 152);
      this.countryLookupView1.TabIndex = 0;
      // 
      // MainWindow
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(437, 510);
      this.Controls.Add(this.caseContainerView1);
      this.Controls.Add(this.countryLookupView1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "MainWindow";
      this.Text = "Covid19 Lookup";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private Controls.CountryLookupView countryLookupView1;
    private Controls.CaseContainerView caseContainerView1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}