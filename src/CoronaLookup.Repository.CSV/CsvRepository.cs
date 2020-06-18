using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace CoronaLookup.Repository.CSV
{
  public class CsvRepository : IRepository
  {
    private string mCsvPath;
    public CsvRepository()
    {
      mCsvPath = Path.Combine(Environment.CurrentDirectory, "Covid19Countries_Europe_2020_06_18.csv");
    }

    public IList<Country> GetCountries()
    {
      var countryList = new List<Country>();
      var csvContent = File.ReadAllLines(mCsvPath);
      foreach (var line in csvContent)
      {
        var splittedContent = line.Split(';');
        if (splittedContent.Length > 0)
        {
          countryList.Add(new Country(splittedContent[0]));
        }
      }

      return countryList;
    }

    public CountryCaseInfo GetCaseInfoByCountry(Country country)
    {
      var csvContent = File.ReadAllLines(mCsvPath);
      foreach (var line in csvContent)
      {
        var splittedContent = line.Split(';');
        if (splittedContent.Length > 4 && splittedContent[0] == country.Name)
        {
          return new CountryCaseInfo
          {
            Country = new Country(splittedContent[0]),
            TotalCases = int.Parse(splittedContent[1]),
            TotalDeaths = int.Parse(splittedContent[2]),
            TotalRecovered = int.Parse(splittedContent[3]),
            Date = splittedContent[4]
          };
        }
      }

      return null;
    }

    public async Task<CountryCaseInfo> GetCaseInfoByCountryAsync(Country country)
    {
      var task = Task.Factory.StartNew(() => GetCaseInfoByCountry(country));
      task.Wait();
      return await task;
    }

    public void SetCsvPath(string fileName)
    {
      mCsvPath = fileName;
    }
  }
}
