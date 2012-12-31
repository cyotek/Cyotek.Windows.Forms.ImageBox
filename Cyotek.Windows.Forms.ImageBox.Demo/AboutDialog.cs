using System;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;

namespace Cyotek.Windows.Forms.Demo
{
  public partial class AboutDialog : BaseForm
  {
    #region Constructors

    public AboutDialog()
    {
      FileVersionInfo info;
      Assembly assembly;
      string title;

      this.InitializeComponent();

      assembly = typeof(ImageBox).Assembly;
      info = FileVersionInfo.GetVersionInfo(assembly.Location);
      title = info.ProductName;

      this.Text = string.Format("About {0}", title);
      nameLabel.Text = title;
      versionLabel.Text = string.Format("Version {0}", info.FileVersion);
      copyrightLabel.Text = info.LegalCopyright;
    }

    #endregion

    #region Event Handlers

    private void closeButton_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void webLinkLabel_Click(object sender, EventArgs e)
    {
      try
      {
        Process.Start(((Control)sender).Text);
      }
      catch (Exception ex)
      {
        MessageBox.Show(string.Format("Unable to start the specified URI.\n\n{0}", ex.Message), Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
    }

    #endregion
  }
}
