using System;
using System.Drawing;
using System.Windows.Forms;

namespace Cyotek.Windows.Forms.Demo
{
  // Cyotek ImageBox
  // Copyright (c) 2010-2013 Cyotek.
  // http://cyotek.com
  // http://cyotek.com/blog/tag/imagebox

  // Licensed under the MIT License. See imagebox-license.txt for the full text.

  // If you use this control in your applications, attribution, donations or contributions are welcome.

  internal partial class BaseForm : Form
  {
    #region Constructors

    public BaseForm()
    {
      this.InitializeComponent();
    }

    #endregion

    #region Overridden Members

    protected override void OnLoad(EventArgs e)
    {
      this.Font = SystemFonts.MessageBoxFont;

      base.OnLoad(e);
    }

    #endregion

    #region Members

    protected string FormatPoint(Point point)
    {
      return string.Format("X:{0}, Y:{1}", point.X, point.Y);
    }

    protected string FormatRectangle(RectangleF rect)
    {
      return string.Format("X:{0}, Y:{1}, W:{2}, H:{3}", (int)rect.X, (int)rect.Y, (int)rect.Width, (int)rect.Height);
    }

    #endregion
  }
}
