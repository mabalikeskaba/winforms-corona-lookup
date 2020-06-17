using System.Collections.Generic;
using CoronaLookup.Repository;

namespace CoronaLookup.ViewModel.Controls
{
  public class CaseContainerViewModel
  {
    public delegate void CountryCaseInfoAddedDelegate();
    public event CountryCaseInfoAddedDelegate CountryCaseInfoAdded;

    public List<CountryCaseInfo> CountryCaseInfos { get; }

    public CaseContainerViewModel()
    {
      CountryCaseInfos = new List<CountryCaseInfo>();
    }

    public void AddCountryCaseInfo(CountryCaseInfo info)
    {
      if (!CountryCaseInfos.Contains(info))
      {
        CountryCaseInfos.Add(info);
        CountryCaseInfoAdded?.Invoke();
      }
    }
  }
}