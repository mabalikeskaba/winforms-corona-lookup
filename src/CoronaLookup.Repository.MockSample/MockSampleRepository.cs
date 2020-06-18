using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace CoronaLookup.Repository.MockSample
{
  public class MockSampleRepository : IRepository
  {
    private readonly Country[] mCountries =
    {
      new Country("Germany"),
      new Country("USA"),
      new Country("China"),
      new Country("Italy")
    };

    public IList<Country> GetCountries()
    {
      return mCountries;
    }

    public CountryCaseInfo GetCaseInfoByCountry(Country country)
    {
      var ctry = mCountries.FirstOrDefault(x => x.Name == country.Name);
      var rnd = new Random();
      var fetchDate = DateTime.Now.ToString(CultureInfo.InvariantCulture);
      var totalCases = rnd.Next(1, 200000);
      var totalDeaths = rnd.Next(0, totalCases / 2);
      var totalRecoveries = rnd.Next(0, totalCases / 2);
      if (ctry != null)
      {
        return new CountryCaseInfo()
        {
          Country = ctry,
          TotalCases = totalCases,
          TotalDeaths = totalDeaths,
          TotalRecovered = totalRecoveries,
          Date = fetchDate
        };
      }

      return null;
    }

    public async Task<CountryCaseInfo> GetCaseInfoByCountryAsync(Country country)
    {
      var task = Task.Factory.StartNew(() => GetCaseInfoByCountry(country));
      task.Wait();
      return await task;
    }
  }
}
