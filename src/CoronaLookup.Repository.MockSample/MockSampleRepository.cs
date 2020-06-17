using System;
using System.Collections.Generic;
using System.Linq;

namespace CoronaLookup.Repository.MockSample
{
  public class MockSampleRepository : IRepository
  {
    private readonly Country[] Countries =
    {
      new Country("Germany"),
      new Country("USA"),
      new Country("China"),
      new Country("Italy")
    };

    public IEnumerable<Country> FetchCountries()
    {
      return Countries;
    }

    public CountryCaseInfo FetchCaseInfoByCountry(Country country)
    {
      var ctry = Countries.FirstOrDefault(x => x.Name == country.Name);
      var rnd = new Random();
      var fetchDate = DateTime.Now;
      var totalCases = rnd.Next(1, 200000);
      var totalDeaths = rnd.Next(0, totalCases / 2);
      var totalRecoveries = rnd.Next(0, totalCases / 2);
      if (ctry != null)
      {
        return new CountryCaseInfo()
        {
          Country = ctry, TotalCases = totalCases, TotalDeaths = totalDeaths, TotalRecovered = totalRecoveries,
          Date = fetchDate
        };
      }

      return null;
    }
  }
}
