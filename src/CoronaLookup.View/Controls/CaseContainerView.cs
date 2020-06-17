using System.Windows.Forms;
using CoronaLookup.ViewModel.Controls;

namespace CoronaLookup.View.Controls
{
  public partial class CaseContainerView : UserControl
  {
    private readonly CaseContainerViewModel mViewModel;

    public CaseContainerView()
    {
      InitializeComponent();
    }

    public CaseContainerView(CaseContainerViewModel viewModel)
    {
      InitializeComponent();
      mViewModel = viewModel;
      mViewModel.CountryCaseInfoAdded += ViewModelOnCountryCaseInfoAdded;
    }

    private void ViewModelOnCountryCaseInfoAdded()
    {
      Controls.Clear();
      foreach (var countryCaseInfo in mViewModel.CountryCaseInfos)
      {
        if (countryCaseInfo != null)
        {
          var view = new CaseDetailContainerView(countryCaseInfo) { Dock = DockStyle.Top };
          Controls.Add(view);
        }
      }
    }
  }
}
