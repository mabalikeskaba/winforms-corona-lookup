namespace CoronaLookup.Repository.Covid19API
{
  public class ApiCountry
  {
    public string Country { get; set; }
    public string Slug { get; set; }
    public string ISO2 { get; set; }

    public Country ToCountry() => new Country(Country);
  }
}
