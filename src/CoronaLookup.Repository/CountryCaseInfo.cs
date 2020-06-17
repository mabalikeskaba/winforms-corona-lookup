using System;
using System.Collections.Generic;

namespace CoronaLookup.Repository
{
  public class CountryCaseInfo
  {
    public Country Country { get; set; }
    public int TotalCases { get; set; }
    public int TotalDeaths { get; set; }
    public int TotalRecovered { get; set; }
    public string Date { get; set; }

    public override bool Equals(object obj)
    {
      if (obj is CountryCaseInfo info)
      {
        return info.Country.Name == Country.Name;
      }

      return false;
    }

    public override int GetHashCode()
    {
      return 1950172441 + EqualityComparer<Country>.Default.GetHashCode(Country);
    }
  }
}