using System;
using System.ComponentModel;
using System.Windows.Forms;
using CoronaLookup.ViewModel.Controls;
// ReSharper disable LocalizableElement

namespace CoronaLookup.View.Controls
{
  public partial class CaseContainerView : UserControl
  {
    private readonly CaseContainerViewModel mViewModel;

    public CaseContainerView()
    {
      InitializeComponent();
    }

    public CaseContainerView(CaseContainerViewModel viewModel)
    {
      InitializeComponent();
      mViewModel = viewModel;
      mViewModel.CountryCaseInfoAdded += ViewModelOnCountryCaseInfoAdded;
    }

    private void ViewModelOnCountryCaseInfoAdded()
    {
      Controls.Clear();
      foreach (var countryCaseInfo in mViewModel.CountryCaseInfos)
      {
        if (countryCaseInfo != null)
        {
          exportAsCSVToolStripMenuItem.Enabled = true;
          var view = new CaseDetailContainerView(countryCaseInfo) { Dock = DockStyle.Top };
          Controls.Add(view);
        }
      }
    }

    private void exportAsCSVToolStripMenuItem_Click(object sender, EventArgs e)
    {
      var now = DateTime.Now;
      var dlg = new SaveFileDialog
      {
        OverwritePrompt = true,
        AddExtension = true,
        DefaultExt = ".csv",
        Title = "Export country data",
        Filter = "CSV files(*.csv)|*.csv",
        FileName = $"Covid19Countries_{now.Year}_{now.Month:D2}_{now.Day:D2}"
      };

      dlg.FileOk += DlgOnFileOk;
      dlg.ShowDialog();
    }

    private void DlgOnFileOk(object sender, CancelEventArgs e)
    {
      if (sender is SaveFileDialog saveFileDialog)
      {
        saveFileDialog.FileOk -= DlgOnFileOk;
        mViewModel.ExportListAsCsv(saveFileDialog.FileName);
      }
    }
  }
}
