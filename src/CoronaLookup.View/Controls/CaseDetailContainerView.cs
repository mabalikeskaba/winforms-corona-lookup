using System.Windows.Forms;
using CoronaLookup.Repository;

namespace CoronaLookup.View.Controls
{
  public partial class CaseDetailContainerView : UserControl
  {
    public CaseDetailContainerView()
    {
      InitializeComponent();
    }

    public CaseDetailContainerView(CountryCaseInfo info)
    {
      InitializeComponent();
      mCountryNameLabel.Text = info.Country.Name;
      mTotalCasesLabel.DetailContent = info.TotalCases.ToString();
      mTotalDeathsLabel.DetailContent = info.TotalDeaths.ToString();
      mTotalRecoveriesLabel.DetailContent = info.TotalRecovered.ToString();
      mDateLabel.DetailContent = info.Date;
    }
  }
}
