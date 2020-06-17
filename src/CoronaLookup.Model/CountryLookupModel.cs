using System.Collections.Generic;
using System.Linq;
using CoronaLookup.Repository;

namespace CoronaLookup.Model
{
  public class CountryLookupModel
  {
    private IRepository mCurrentRepository = null;
    private readonly IEnumerable<IRepository> mRepositories;

    public CountryLookupModel(params IRepository[] repos)
    {
      mRepositories = repos;
    }

    public IEnumerable<Country> GetCountries()
    {
      return mCurrentRepository?.FetchCountries();
    }

    public void SetRepository(string repositoryName)
    {
      var repo = mRepositories.FirstOrDefault(x => x.GetType().Name == repositoryName);
      if (repo != null)
      {
        mCurrentRepository = repo;
      }
    }

    public CountryCaseInfo GetCaseInfoByCountry(Country country)
    {
      return mCurrentRepository.FetchCaseInfoByCountry(country);
    }
  }
}