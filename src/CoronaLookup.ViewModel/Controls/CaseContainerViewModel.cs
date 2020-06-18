using System.Collections.Generic;
using CoronaLookup.Model;
using CoronaLookup.Repository;

namespace CoronaLookup.ViewModel.Controls
{
  public class CaseContainerViewModel
  {
    private readonly CaseContainerModel mModel;

    public delegate void CountryCaseInfoAddedDelegate();
    public event CountryCaseInfoAddedDelegate CountryCaseInfoAdded;

    public List<CountryCaseInfo> CountryCaseInfos { get; }

    public CaseContainerViewModel(CaseContainerModel model)
    {
      CountryCaseInfos = new List<CountryCaseInfo>();
      mModel = model;
    }

    public void AddCountryCaseInfo(CountryCaseInfo info)
    {
      if (!CountryCaseInfos.Contains(info))
      {
        CountryCaseInfos.Add(info);
        CountryCaseInfoAdded?.Invoke();
      }
    }

    public void ExportListAsCsv(string path)
    {
      mModel.ExportCountryCaseInfoListAsCsv(path, CountryCaseInfos);
    }
  }
}