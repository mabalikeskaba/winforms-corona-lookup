using System;
using System.Windows.Forms;
using CoronaLookup.View.Controls;
using CoronaLookup.ViewModel.Controls;

namespace CoronaLookup.View.Windows
{
  public partial class MainWindow : Form
  {
    public MainWindow() : this(null, null) { }

    public MainWindow(CaseContainerViewModel caseContainerViewModel, CountryLookupViewModel countryLookupViewModel)
    {
      var countryLookupView = new CountryLookupView(countryLookupViewModel)
      {
        AutoSize = true,
        Location = new System.Drawing.Point(0, 0),
        Name = "countryLookupView",
        Size = new System.Drawing.Size(437, 1),
        TabIndex = 0
      };
     
      var caseContainerView = new CaseContainerView(caseContainerViewModel)
      {
        AutoScroll = true,
        BorderStyle = BorderStyle.FixedSingle,
        Location = new System.Drawing.Point(11, 135),
        Name = "caseContainerView",
        Size = new System.Drawing.Size(415, 364),
        TabIndex = 1
      };

      InitializeComponent();

      Controls.Add(caseContainerView);
      Controls.Add(countryLookupView);
    }

    protected override void OnLoad(EventArgs e)
    {

    }
  }
}
