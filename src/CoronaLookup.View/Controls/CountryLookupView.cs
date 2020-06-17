using System;
using System.Linq;
using System.Windows.Forms;
using CoronaLookup.Repository;
using CoronaLookup.ViewModel.Controls;
// ReSharper disable CoVariantArrayConversion

namespace CoronaLookup.View.Controls
{
  public partial class CountryLookupView : UserControl
  {
    private readonly CountryLookupViewModel mViewModel;

    public CountryLookupView() : this(null) { }

    public CountryLookupView(CountryLookupViewModel viewModel)
    {
      InitializeComponent();
      mFileSystemText.Text = Environment.CurrentDirectory;

      mViewModel = viewModel;
      OnApiRadButtonCheckedChanged(this, null);
    }

    protected override void OnLoad(EventArgs e)
    {
      base.OnLoad(e);
      var countries = mViewModel.GetCountries().ToArray();
      if (countries.Any())
      {
        mCountrySelection.Items.AddRange(countries);
        mCountrySelection.SelectedIndex = 0;
      }
    }

    private void OnFileSystemRadButtonCheckedChanged(object sender, EventArgs e)
    {
      mOpenCsvButton.Enabled = mRadButtonFileSystem.Checked;
    }

    private void OnApiRadButtonCheckedChanged(object sender, EventArgs e)
    {
      if (mRadButtonApi.Checked)
      {
        mViewModel.SetRepository("MockSampleRepository");
      }
      else
      {
        mViewModel.SetRepository("MockSampleRepository");
      }
    }

    // Button handling

    private void mFileSystemText_Click(object sender, EventArgs e)
    {
      if (!mRadButtonFileSystem.Checked)
      {
        mRadButtonFileSystem.Checked = true;
      }
    }

    private void mAddButton_Click(object sender, EventArgs e)
    {
      mViewModel.AddCountryToList((Country)mCountrySelection.SelectedItem);
    }
  }
}
