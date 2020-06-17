using System;
using System.Windows.Forms;
using CoronaLookup.View.Controls;
using CoronaLookup.ViewModel;
using CoronaLookup.ViewModel.Controls;

namespace CoronaLookup.View.Windows
{
  public partial class MainWindow : Form
  {
    private CountryLookupView mCountryLookupView;
    private CaseContainerView mCaseContainerView;

    public void Initialize(CaseContainerViewModel caseContainerViewModel, CaseDetailContainerViewModel caseDetailContainerViewModel, CountryLookupViewModel countryLookupViewModel)
    {
      mCountryLookupView = new CountryLookupView(countryLookupViewModel);
      mCaseContainerView = new CaseContainerView(caseContainerViewModel);

      mCaseContainerView.AutoScroll = true;
      mCaseContainerView.BorderStyle = BorderStyle.FixedSingle;
      mCaseContainerView.Location = new System.Drawing.Point(11, 137);
      mCaseContainerView.Name = "caseContainerView";
      mCaseContainerView.Size = new System.Drawing.Size(415, 361);
      mCaseContainerView.TabIndex = 1;

      mCountryLookupView.AutoSize = true;
      mCountryLookupView.Location = new System.Drawing.Point(0, 0);
      mCountryLookupView.Name = "countryLookupView";
      mCountryLookupView.Size = new System.Drawing.Size(437, 131);
      mCountryLookupView.TabIndex = 0;

      InitializeComponent();
    }

    protected override void OnLoad(EventArgs e)
    {
      
    }
  }
}
