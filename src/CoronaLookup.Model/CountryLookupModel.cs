using System;
using System.Collections.Generic;
using System.Linq;
using CoronaLookup.Repository;
using CoronaLookup.Repository.CSV;

namespace CoronaLookup.Model
{
  public class CountryLookupModel
  {
    private IRepository mCurrentRepository;
    private readonly IEnumerable<IRepository> mRepositories;

    public CountryLookupModel(params IRepository[] repos)
    {
      mRepositories = repos;
    }

    public IList<Country> GetCountries()
    {
      return mCurrentRepository?.GetCountries();
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
      try
      {
        return mCurrentRepository.GetCaseInfoByCountryAsync(country).Result;
      }
      catch(Exception ex)
      {
        // Some countries may cause a timeout
        Console.WriteLine(ex);
        return null;
      }
    }

    public void SetCsvPath(string fileName)
    {
      var repo = mRepositories.OfType<CsvRepository>().FirstOrDefault();
      repo?.SetCsvPath(fileName);
    }
  }
}