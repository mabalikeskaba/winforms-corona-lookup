using CoronaLookup.ViewModel;
using System.Windows.Forms;

namespace CoronaLookup.View
{
  public partial class CaseDetailContainerView : UserControl
  {
    private CaseDetailContainerViewModel mViewModel;

    public CaseDetailContainerView(CaseDetailContainerViewModel viewModel)
    {
      InitializeComponent();
      mViewModel = viewModel;
    }
  }
}
