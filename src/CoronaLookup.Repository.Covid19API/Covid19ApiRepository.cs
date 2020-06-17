using System;
using System.Collections.Generic;

namespace CoronaLookup.Repository.Covid19API
{
  public class Covid19ApiRepository : IRepository
  {
    public IEnumerable<Country> FetchCountries()
    {
      throw new NotImplementedException();
    }

    public CountryCaseInfo FetchCaseInfoByCountry(Country country)
    {
      throw new NotImplementedException();
    }
  }
}
