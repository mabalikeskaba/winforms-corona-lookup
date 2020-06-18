using System.Collections.Generic;
using System.Threading.Tasks;

namespace CoronaLookup.Repository
{
  public interface IRepository
  {
    IList<Country> GetCountries();
    CountryCaseInfo GetCaseInfoByCountry(Country country);
    Task<CountryCaseInfo> GetCaseInfoByCountryAsync(Country country);
  }
}