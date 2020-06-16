using CoronaLookup.ViewModel;
using System.Drawing;
using System.Windows.Forms;

namespace CoronaLookup.View.Controls
{
  public partial class CaseDetailView : UserControl
  {
    private CaseDetailViewModel mViewModel;

    public CaseDetailView(CaseDetailViewModel viewModel)
    {
      InitializeComponent();

      mViewModel = viewModel;

      mCaseDetailLabel.Text = mViewModel.CaseDetailName;
      mCaseDetailPanel.Paint += new PaintEventHandler(OnCaseDetailPanelPaint);
    }

    private void OnCaseDetailPanelPaint(object sender, PaintEventArgs e)
    {
      var panel = sender as Panel;
      var g = e.Graphics;

      var font = new Font(FontFamily.GenericMonospace, 12f);
      var caseAmount = mViewModel.CaseAmount.ToString();

      var caseAmountStringSize = g.MeasureString(caseAmount, font);
      g.DrawString(caseAmount, font, new SolidBrush(mViewModel.CaseAmountFontColor), new PointF((panel.Size.Width / 2) - (caseAmountStringSize.Width / 2), panel.Size.Height / 2));
      g.FillRectangle(new SolidBrush(mViewModel.CaseDetailColor), panel.DisplayRectangle);
    }
  }
}
