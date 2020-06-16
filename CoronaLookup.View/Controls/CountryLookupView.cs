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
  }
}
