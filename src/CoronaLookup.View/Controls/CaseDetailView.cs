using System.Windows.Forms;

namespace CoronaLookup.View.Controls
{
  public partial class CaseDetailView : UserControl
  {
    private string mDetailName;
    private string mDetailContent;

    public string DetailName
    {
      get => mDetailName;
      set
      {
        mDetailName = value;
        mCaseDetailLabel.Text = value;
      }
    }

    public string DetailContent
    {
      get => mDetailContent;
      set
      {
        mDetailContent = value;
        mCaseContentLabel.Text = value;
      }
    }

    public CaseDetailView()
    {
      InitializeComponent();
    }
  }
}
