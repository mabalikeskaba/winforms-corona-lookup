using System;

namespace CoronaLookup.Repository
{
  public class CountryCaseInfo
  {
    public Country Country { get; set; }
    public int TotalCases { get; set; }
    public int TotalDeaths { get; set; }
    public int TotalRecovered { get; set; }
    public DateTime Date { get; set; }

    public override bool Equals(object obj)
    {
      if (obj is CountryCaseInfo info)
      {
        return info.Country.Name == Country.Name;
      }

      return false;
    }
  }
}