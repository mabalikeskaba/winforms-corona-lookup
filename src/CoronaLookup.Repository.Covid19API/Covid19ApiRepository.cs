using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CoronaLookup.Repository.Covid19API
{
  public class Covid19ApiRepository : IRepository
  {
    private RestClient mClient;

    public Covid19ApiRepository()
    {
      mClient = new RestClient("https://api.covid19api.com");
    }

    public IEnumerable<Country> GetCountries()
    {
      var request = new RestRequest("/countries", DataFormat.Json);

      var response = mClient.Get<IEnumerable<ApiCountry>>(request);
      if (response.StatusCode == System.Net.HttpStatusCode.OK)
      {
        var list = new List<Country>();
        foreach (var country in response.Data)
        {
          list.Add(new Country(country.Country));
        }
        return list.OrderBy(x => x.Name);
      }
      return null;
    }

    public async Task<CountryCaseInfo> GetCaseInfoByCountry(Country country)
    {
      var from = "2020-03-01T00:00:00Z";
      var now = DateTime.Now;
      var to = $"{now.Year}-{now.Month:D2}-{now.Day:D2}T{now.Hour:D2}:{now.Minute:D2}:{now.Second:D2}Z";
      var requestString = $"/country/{country.Name}?from={from}&to={to}";
      var request = new RestRequest(requestString, DataFormat.Json);
      var token = new CancellationTokenSource();
      token.CancelAfter(3000);
      var task = mClient.ExecuteAsync<IEnumerable<ApiCountryCaseInfo>>(request, token.Token);
      task.Wait();
      var response = await task;
      var actualCaseInfo = response.Data.LastOrDefault();
      if (actualCaseInfo != null)
        return new CountryCaseInfo { Country = new Country(actualCaseInfo.Country), Date = actualCaseInfo.Date, TotalCases = actualCaseInfo.Confirmed, TotalDeaths = actualCaseInfo.Deaths, TotalRecovered = actualCaseInfo.Recovered };

      return null;
    }
  }
}
