using System;
using System.Windows.Forms;
using CoronaLookup.Controller;

namespace CoronaLookup.Main
{
  static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      var mainWindowController = new MainWindowController();
      Application.Run(mainWindowController.MainWindow);
    }
  }
}