namespace CoronaLookup.Repository
{
  public class Country
  {
    public string Name { get; set; }

    public Country(string name)
    {
      Name = name;
    }

    public override string ToString() => Name;
  }
}