using CoronaLookup.ViewModel;
using System.Windows.Forms;

namespace CoronaLookup.View
{
  public partial class CaseDetailView : UserControl
  {
    private CaseDetailViewModel mViewModel;

    public CaseDetailView(CaseDetailViewModel viewModel)
    {
      InitializeComponent();
      mViewModel = viewModel;
    }
  }
}
