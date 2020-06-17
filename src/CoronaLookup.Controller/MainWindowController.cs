using CoronaLookup.Model;
using CoronaLookup.Repository;
using CoronaLookup.Repository.Covid19API;
using CoronaLookup.Repository.MockSample;
using CoronaLookup.View.Windows;
using CoronaLookup.ViewModel;
using CoronaLookup.ViewModel.Controls;

namespace CoronaLookup.Controller
{
  public class MainWindowController
  {
    public MainWindow MainWindow { get; }

    private CountryLookupModel mCountryLookupModel;

    private readonly CountryLookupViewModel mCountryLookupViewModel;
    private readonly CaseContainerViewModel mCaseContainerViewModel;
    private readonly CaseDetailContainerViewModel mCaseDetailContainerViewModel;

    public MainWindowController()
    {
      mCountryLookupModel = new CountryLookupModel(new Covid19ApiRepository(), new MockSampleRepository());
      mCountryLookupViewModel = new CountryLookupViewModel(mCountryLookupModel);
      mCountryLookupViewModel.CountryAdded += OnCountryAddedToList;

      mCaseDetailContainerViewModel = new CaseDetailContainerViewModel();
      mCaseContainerViewModel = new CaseContainerViewModel();

      MainWindow = new MainWindow();
      MainWindow.Initialize(mCaseContainerViewModel, mCaseDetailContainerViewModel, mCountryLookupViewModel);
    }

    public void OnCountryAddedToList(Country country)
    {
      mCaseContainerViewModel.AddCountryCaseInfo(mCountryLookupModel.GetCaseInfoByCountry(country));
    }
  }
}
