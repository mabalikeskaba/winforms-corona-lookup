using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using CoronaLookup.Repository;
using CoronaLookup.ViewModel.Controls;
// ReSharper disable CoVariantArrayConversion
// ReSharper disable LocalizableElement

namespace CoronaLookup.View.Controls
{
  public partial class CountryLookupView : UserControl
  {
    private readonly CountryLookupViewModel mViewModel;

    public CountryLookupView() : this(null) { }

    public CountryLookupView(CountryLookupViewModel viewModel)
    {
      InitializeComponent();
      mFileSystemText.Text = Path.Combine(Environment.CurrentDirectory, "Covid19Countries_Europe_2020_06_18.csv");
      mOpenCsvButton.Click += (sender, args) => OpenCsvFileDialog();

      mViewModel = viewModel;
      OnApiRadButtonCheckedChanged(this, null);
    }

    private void OnFileSystemRadButtonCheckedChanged(object sender, EventArgs e)
    {
      mOpenCsvButton.Enabled = mRadButtonFileSystem.Checked;
    }

    private void OnApiRadButtonCheckedChanged(object sender, EventArgs e)
    {
      if (mRadButtonApi.Checked)
      {
        mViewModel.SetRepository("Covid19ApiRepository");
        mOpenCsvButton.Enabled = false;
      }
      else
      {
        mViewModel.SetRepository("CsvRepository");
        mOpenCsvButton.Enabled = true;
      }

      LoadCountries();
    }

    private void LoadCountries()
    {
      mCountrySelection.Items.Clear();

      var countries = mViewModel.GetCountries();
      if (countries != null)
      {
        if (countries.Any())
        {
          mCountrySelection.Items.AddRange(countries.ToArray());
          mCountrySelection.SelectedIndex = 0;
        }
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

    // File dialog handling

    private void OpenCsvFileDialog()
    {
      var dialog = new OpenFileDialog
      {
        DefaultExt = ".csv",
        InitialDirectory = Path.GetDirectoryName(mFileSystemText.Text),
        Filter = "CSV file (*.csv)|*.csv"
      };

      dialog.FileOk += DialogOnFileOk;
      dialog.ShowDialog();
    }

    private void DialogOnFileOk(object sender, CancelEventArgs e)
    {
      if (sender is OpenFileDialog dialog)
      {
        dialog.FileOk -= DialogOnFileOk;
        if (File.Exists(dialog.FileName))
        {
          mViewModel.SetCsvPath(dialog.FileName);
          mFileSystemText.Text = dialog.FileName;
          LoadCountries();
        }
      }
    }
  }
}
