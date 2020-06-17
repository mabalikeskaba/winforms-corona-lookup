using System.Collections.Generic;
using System.Threading.Tasks;

namespace CoronaLookup.Repository
{
  public interface IRepository
  {
    IEnumerable<Country> GetCountries();
    Task<CountryCaseInfo> GetCaseInfoByCountry(Country country);
  }
}