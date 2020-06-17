using System.Windows.Forms;

namespace CoronaLookup.View.Controls
{
  public partial class CaseContainerView : UserControl
  {
    public CaseContainerView()
    {
      InitializeComponent();
      var ashdio = new CaseDetailContainerView();
      var qdio = new CaseDetailContainerView();
      ashdio.Dock = DockStyle.Top;
      qdio.Dock = DockStyle.Top;
      Controls.Add(ashdio);
      Controls.Add(qdio);
    }
  }
}
