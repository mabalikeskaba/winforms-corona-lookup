using System.Collections.Generic;

namespace CoronaLookup.Repository
{
  public interface IRepository
  {
    IEnumerable<Country> FetchCountries();
    CountryCaseInfo FetchCaseInfoByCountry(Country country);
  }
}