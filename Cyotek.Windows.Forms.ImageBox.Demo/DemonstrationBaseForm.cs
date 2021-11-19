// Cyotek Color Picker Controls Library
// http://cyotek.com/blog/tag/colorpicker

// Copyright (c) 2021 Cyotek Ltd.

// This work is licensed under the MIT License.
// See LICENSE.TXT for the full text

// Found this code useful?
// https://www.cyotek.com/contribute

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Cyotek.Windows.Forms.Demo
{
  internal partial class DemonstrationBaseForm : BaseForm
  {
    #region Private Fields

    private const int _margin = 12;

    #endregion Private Fields

    #region Public Constructors

    public DemonstrationBaseForm()
    {
      this.InitializeComponent();

      base.ForeColor = SystemColors.ControlText;
      base.BackColor = SystemColors.Control;
      base.FormBorderStyle = FormBorderStyle.Sizable;
      base.MaximizeBox = true;
    }

    #endregion Public Constructors

    #region Public Properties

    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [DefaultValue(typeof(Color), "Window")]
    public override Color BackColor
    {
      get => base.BackColor;
      set => base.BackColor = value;
    }

    public override Rectangle DisplayRectangle => new Rectangle(_margin, _margin, this.ClientSize.Width - (_margin * 2), productNameLabel.Top - (_margin * 2));

    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [DefaultValue(typeof(Color), "WindowText")]
    public override Color ForeColor
    {
      get => base.ForeColor;
      set => base.ForeColor = value;
    }

    [DefaultValue(typeof(FormBorderStyle), "Sizable")]
    public new FormBorderStyle FormBorderStyle
    {
      get => base.FormBorderStyle;
      set => base.FormBorderStyle = value;
    }

    [DefaultValue(true)]
    public new bool MaximizeBox
    {
      get => base.MaximizeBox;
      set => base.MaximizeBox = value;
    }

    #endregion Public Properties

    #region Protected Properties

    protected Button CloseButton => closeButton;

    #endregion Protected Properties

    #region Protected Methods

    protected override void OnFontChanged(EventArgs e)
    {
      base.OnFontChanged(e);

      this.PositionChrome();
    }

    protected override void OnLoad(EventArgs e)
    {
      base.OnLoad(e);

      closeButton.TabIndex = this.Controls.Count - 2;
      productUrlLabel.TabIndex = this.Controls.Count - 1;
    }

    protected override void OnResize(EventArgs e)
    {
      base.OnResize(e);

      this.PositionChrome();
    }

    protected override void OnShown(EventArgs e)
    {
      this.OnResize(e);

      base.OnShown(e);
    }

    #endregion Protected Methods

    #region Private Methods

    private void CloseButton_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void PositionChrome()
    {
      if (iconPictureBox != null)
      {
        int x;
        int y;
        int w;
        int h;

        x = _margin;
        y = _margin;
        w = this.ClientSize.Width;
        h = this.ClientSize.Height;

        iconPictureBox.Location = new Point(x, h - (iconPictureBox.Height + x));
        closeButton.Location = new Point(w - (closeButton.Width + x), h - (closeButton.Height + y));

        x += iconPictureBox.Right;
        productUrlLabel.Location = new Point(x, h - (productUrlLabel.Height + y));
        productNameLabel.Location = new Point(x, productUrlLabel.Top - productUrlLabel.Height);
      }
    }

    private void ProductUrlLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      AboutDialog.OpenCyotekHomePage();
    }

    #endregion Private Methods

    protected string FormatPoint(Point point)
    {
      return string.Format("X:{0}, Y:{1}", point.X, point.Y);
    }
    protected string FormatRectangle(RectangleF rect)
    {
      return string.Format("X:{0}, Y:{1}, W:{2}, H:{3}", (int)rect.X, (int)rect.Y, (int)rect.Width, (int)rect.Height);
    }
  }
}
