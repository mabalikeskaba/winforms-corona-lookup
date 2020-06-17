using System.Drawing;
using System.Windows.Forms;
using CoronaLookup.View.Controls;
using CoronaLookup.ViewModel;

namespace CoronaLookup.View.Windows
{
  public partial class MainWindow : Form
  {
    public MainWindow()
    {
      InitializeComponent();
      var caseDetailView = new CaseDetailView(new CaseDetailViewModel
        {CaseAmount = 500, CaseDetailColor = Color.Aqua, CaseDetailName = "wasd"});
      caseDetailView.Dock = DockStyle.Top;
      caseContainerView1.Controls.Add(caseDetailView);
    }
  }
}
