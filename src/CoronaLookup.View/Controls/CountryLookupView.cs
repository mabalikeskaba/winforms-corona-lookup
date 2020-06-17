using System;
using System.Windows.Forms;

namespace CoronaLookup.View.Controls
{
  public partial class CountryLookupView : UserControl
  {
    public CountryLookupView()
    {
      InitializeComponent();
      mFileSystemText.Text = Environment.CurrentDirectory;
    }

    private void mFileSystemText_Click(object sender, EventArgs e)
    {
      if (!mRadButtonFileSystem.Checked)
      {
        mRadButtonFileSystem.Checked = true;
      }
    }

    private void OnFileSystemRadButtonCheckedChanged(object sender, EventArgs e)
    {
      mOpenCsvButton.Enabled = mRadButtonFileSystem.Checked;
    }

    private void OnApiRadButtonCheckedChanged(object sender, EventArgs e)
    {
    }
  }
}
