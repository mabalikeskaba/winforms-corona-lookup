using CoronaLookup.Model;
using CoronaLookup.Repository;
using CoronaLookup.Repository.Covid19API;
using CoronaLookup.Repository.MockSample;
using CoronaLookup.View.Windows;
using CoronaLookup.ViewModel.Controls;

namespace CoronaLookup.Controller
{
  public class MainWindowController
  {
    public MainWindow MainWindow { get; }

    private readonly CountryLookupModel mCountryLookupModel;

    private readonly CaseContainerViewModel mCaseContainerViewModel;

    public MainWindowController()
    {
      mCountryLookupModel = new CountryLookupModel(new Covid19ApiRepository(), new MockSampleRepository());
      var countryLookupViewModel = new CountryLookupViewModel(mCountryLookupModel);
      countryLookupViewModel.CountryAdded += OnCountryAddedToList;

      mCaseContainerViewModel = new CaseContainerViewModel(new CaseContainerModel());

      MainWindow = new MainWindow(mCaseContainerViewModel, countryLookupViewModel);
    }

    public void OnCountryAddedToList(Country country)
    {
      mCaseContainerViewModel.AddCountryCaseInfo(mCountryLookupModel.GetCaseInfoByCountry(country));
    }
  }
}
