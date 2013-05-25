using System;
using System.Windows.Forms;

namespace Cyotek.Windows.Forms.Demo
{
  // Cyotek ImageBox
  // Copyright (c) 2010-2013 Cyotek. All Rights Reserved.
  // http://cyotek.com

  // If you use this control in your applications, attribution or donations are welcome.

  // ImageBox sample project
  // http://cyotek.com/blog/tag/imagebox

  internal partial class MainMenuForm : BaseForm
  {
    #region Constructors

    public MainMenuForm()
    {
      InitializeComponent();
    }

    #endregion

    #region Event Handlers

    private void aboutButton_Click(object sender, EventArgs e)
    {
      using (Form dialog = new AboutDialog())
        dialog.ShowDialog(this);
    }

    private void dragTestDemoButton_Click(object sender, EventArgs e)
    {
      using (Form form = new DragTestForm())
        form.ShowDialog(this);
    }

    private void exitButton_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void imageBoxDemoButton_Click(object sender, EventArgs e)
    {
      using (Form form = new ImageBoxDemoForm())
        form.ShowDialog(this);
    }

    private void pixelGridDemoButton_Click(object sender, EventArgs e)
    {
      using (Form form = new PixelGridForm())
        form.ShowDialog(this);
    }

    private void virtualModeDemoButton_Click(object sender, EventArgs e)
    {
      using (Form form = new VirtualModeDemonstrationForm())
        form.ShowDialog(this);
    }

    #endregion
  }
}
