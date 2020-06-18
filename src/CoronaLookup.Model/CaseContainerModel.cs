using System.Collections.Generic;
using System.IO;
using System.Text;
using CoronaLookup.Repository;

namespace CoronaLookup.Model
{
  public class CaseContainerModel
  {
    public void ExportCountryCaseInfoListAsCsv(string path, IEnumerable<CountryCaseInfo> countryCaseInfos)
    {
      var sb = new StringBuilder();
      foreach (var info in countryCaseInfos)
      {
        sb.Append(info.Country);
        sb.Append(";");
        sb.Append(info.TotalCases);
        sb.Append(";");
        sb.Append(info.TotalDeaths);
        sb.Append(";");
        sb.Append(info.TotalRecovered);
        sb.Append(";");
        sb.Append(info.Date);
        sb.AppendLine();
      }
      File.WriteAllText(path, sb.ToString());
    }
  }
}