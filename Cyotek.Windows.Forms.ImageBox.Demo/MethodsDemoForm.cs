using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Cyotek.Windows.Forms.Demo.Properties;

namespace Cyotek.Windows.Forms.Demo
{
  // Cyotek ImageBox
  // Copyright (c) 2010-2015 Cyotek Ltd.
  // http://cyotek.com
  // http://cyotek.com/blog/tag/imagebox

  // Licensed under the MIT License. See license.txt for the full text.

  // If you use this control in your applications, attribution, donations or contributions are welcome.

  internal partial class MethodsDemoForm : BaseForm
  {
    public MethodsDemoForm()
    {
      InitializeComponent();
    }

    private void closeToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
    {
      AboutDialog.ShowAboutDialog();
    }

    /// <summary>
    /// Raises the <see cref="E:System.Windows.Forms.Form.Load"/> event.
    /// </summary>
    /// <param name="e">An <see cref="T:System.EventArgs"/> that contains the event data. </param>
    protected override void OnLoad(EventArgs e)
    {
      base.OnLoad(e);

      imageBox.Image = Resources.Sample;
    }

    private void zoomToFitButton_Click(object sender, EventArgs e)
    {
      imageBox.ZoomToFit();
    }

    private void zoomInButton_Click(object sender, EventArgs e)
    {
      imageBox.ZoomIn();
    }

    private void zoomOutButton_Click(object sender, EventArgs e)
    {
      imageBox.ZoomOut();
    }

    private void actualSizeButton_Click(object sender, EventArgs e)
    {
      imageBox.ActualSize();
    }

    private void centerToImageButton_Click(object sender, EventArgs e)
    {
      imageBox.CenterToImage();
    }

    private void selectAllButton_Click(object sender, EventArgs e)
    {
      imageBox.SelectAll();
    }

    private void selectNoneButton_Click(object sender, EventArgs e)
    {
      imageBox.SelectNone();
    }
  }
}
