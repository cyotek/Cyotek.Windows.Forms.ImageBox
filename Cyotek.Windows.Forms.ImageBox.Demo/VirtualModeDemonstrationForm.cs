// Cyotek ImageBox
// http://cyotek.com/blog/tag/imagebox

// Copyright (c) 2010-2021 Cyotek Ltd.

// This work is licensed under the MIT License.
// See LICENSE.TXT for the full text

// Found this code useful?
// https://www.cyotek.com/contribute

using System;
using System.Drawing;
using System.Windows.Forms;

namespace Cyotek.Windows.Forms.Demo
{
  internal partial class VirtualModeDemonstrationForm : DemonstrationBaseForm
  {
    #region Public Constructors

    public VirtualModeDemonstrationForm()
    {
      this.InitializeComponent();
    }

    #endregion Public Constructors

    #region Protected Methods

    protected override void OnLoad(EventArgs e)
    {
      base.OnLoad(e);

      propertyGrid.SelectItem("VirtualSize");
    }

    #endregion Protected Methods

    #region Private Methods

    private void ImageBox_VirtualDraw(object sender, PaintEventArgs e)
    {
      RectangleF bounds;

      bounds = imageBox.GetOffsetRectangle(new RectangleF(PointF.Empty, imageBox.VirtualSize));

      using (Brush brush = new SolidBrush(Color.FromArgb(128, Color.Goldenrod)))
      {
        e.Graphics.FillRectangle(brush, bounds);
      }

      e.Graphics.DrawRectangle(Pens.DarkGoldenrod, bounds.X, bounds.Y, bounds.Width, bounds.Height);

      using (Font font = new Font(this.Font.FontFamily, (float)(8 * imageBox.ZoomFactor)))
      {
        TextRenderer.DrawText(e.Graphics, "Use the VirtualMode and VirtualSize properties along with the VirtualDraw event to provide full control without needing a backing image.", font, new Rectangle((int)bounds.Left, (int)bounds.Top, (int)bounds.Width, (int)bounds.Height), Color.Black, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.WordBreak | TextFormatFlags.WordEllipsis);
      }
    }

    #endregion Private Methods
  }
}
