using CoronaLookup.ViewModel;
using System.Windows.Forms;

namespace CoronaLookup.View
{
  public partial class CaseDetailContainerView : UserControl
  {
    private CaseDetailContainerViewModel mViewModel;

    public CaseDetailContainerView() : this(null)
    {
    }

    public CaseDetailContainerView(CaseDetailContainerViewModel viewModel)
    {
      InitializeComponent();
      mViewModel = viewModel;
    }
  }
}
