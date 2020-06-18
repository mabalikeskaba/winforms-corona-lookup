using System;
using System.Windows.Forms;
using CoronaLookup.View.Controls;
using CoronaLookup.ViewModel.Controls;

namespace CoronaLookup.View.Windows
{
  public partial class MainWindow : Form
  {
    private readonly CountryLookupView mCountryLookupView;
    private readonly CaseContainerView mCaseContainerView;

    public MainWindow() : this(null, null) { }

    public MainWindow(CaseContainerViewModel caseContainerViewModel, CountryLookupViewModel countryLookupViewModel)
    {
      mCountryLookupView = new CountryLookupView(countryLookupViewModel)
      {
        AutoSize = true,
        Location = new System.Drawing.Point(0, 0),
        Name = "countryLookupView",
        Size = new System.Drawing.Size(437, 1),
        TabIndex = 0
      };
     
      mCaseContainerView = new CaseContainerView(caseContainerViewModel)
      {
        AutoScroll = true,
        BorderStyle = BorderStyle.FixedSingle,
        Location = new System.Drawing.Point(11, 135),
        Name = "caseContainerView",
        Size = new System.Drawing.Size(415, 364),
        TabIndex = 1
      };

      InitializeComponent();
    }

    protected override void OnLoad(EventArgs e)
    {

    }
  }
}
