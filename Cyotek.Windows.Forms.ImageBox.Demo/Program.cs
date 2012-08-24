using System;
using System.Windows.Forms;

namespace ImageBoxSample
{
  static class Program
  {
    #region  Private Class Methods

    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new MainForm());
    }

    #endregion  Private Class Methods
  }
}
