using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CoronaLookup.Repository.CSV
{
  public class CsvRepository : IRepository
  {
    public CsvRepository(string pathToCsvFile)
    {

    }

    public IList<Country> GetCountries()
    {
      throw new NotImplementedException();
    }

    public CountryCaseInfo GetCaseInfoByCountry(Country country)
    {
      throw new NotImplementedException();
    }

    public Task<CountryCaseInfo> GetCaseInfoByCountryAsync(Country country)
    {
      throw new NotImplementedException();
    }
  }
}
