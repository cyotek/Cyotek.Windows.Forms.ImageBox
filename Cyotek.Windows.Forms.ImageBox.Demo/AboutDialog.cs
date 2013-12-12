using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace Cyotek.Windows.Forms.Demo
{
  // Cyotek ImageBox
  // Copyright (c) 2010-2013 Cyotek.
  // http://cyotek.com
  // http://cyotek.com/blog/tag/imagebox

  // Licensed under the MIT License. See imagebox-license.txt for the full text.

  // If you use this control in your applications, attribution, donations or contributions are welcome.

  internal partial class AboutDialog : BaseForm
  {
    #region Constructors

    public AboutDialog()
    {
      this.InitializeComponent();
    }

    #endregion

    #region Class Members

    internal static void ShowAboutDialog()
    {
      using (Form dialog = new AboutDialog())
        dialog.ShowDialog();
    }

    #endregion

    #region Overridden Members

    protected override void OnLoad(EventArgs e)
    {
      base.OnLoad(e);

      if (!this.DesignMode)
      {
        FileVersionInfo info;
        Assembly assembly;
        string title;

        assembly = typeof(ImageBox).Assembly;
        info = FileVersionInfo.GetVersionInfo(assembly.Location);
        title = info.ProductName;

        this.Text = string.Format("About {0}", title);
        nameLabel.Text = title;
        versionLabel.Text = string.Format("Version {0}", info.FileVersion);
        copyrightLabel.Text = info.LegalCopyright;

        this.AddReadme("changelog.md");
        this.AddReadme("readme.md");
        this.AddReadme("acknowledgements.md");
        this.AddReadme("imagebox-license.txt");
      }
    }

    protected override void OnResize(EventArgs e)
    {
      base.OnResize(e);

      if (docsTabControl != null)
        docsTabControl.SetBounds(docsTabControl.Left, docsTabControl.Top, this.ClientSize.Width - (docsTabControl.Left * 2), this.ClientSize.Height - (docsTabControl.Top + footerGroupBox.Height + docsTabControl.Left));
    }

    #endregion

    #region Properties

    protected TabControl TabControl
    {
      get { return docsTabControl; }
    }

    #endregion

    #region Members

    private void AddReadme(string fileName)
    {
      TabPage page;
      TextBox textBox;
      string fullPath;

      fullPath = Path.Combine(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\"), fileName);

      page = new TabPage
      {
        UseVisualStyleBackColor = true,
        Padding = new Padding(9),
        ToolTipText = fullPath,
        Text = fileName
      };

      textBox = new TextBox
      {
        ReadOnly = true,
        Multiline = true,
        WordWrap = true,
        ScrollBars = ScrollBars.Vertical,
        Dock = DockStyle.Fill,
        Text = File.ReadAllText(fullPath)
      };

      page.Controls.Add(textBox);

      docsTabControl.TabPages.Add(page);
    }

    #endregion

    #region Event Handlers

    private void closeButton_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void footerGroupBox_Paint(object sender, PaintEventArgs e)
    {
      e.Graphics.DrawLine(SystemPens.ControlDark, 0, 0, footerGroupBox.Width, 0);
      e.Graphics.DrawLine(SystemPens.ControlLightLight, 0, 1, footerGroupBox.Width, 1);
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
