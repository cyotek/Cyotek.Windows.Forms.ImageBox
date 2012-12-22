using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cyotek.Windows.Forms.Demo
{
  public partial class VirtualModeDemonstrationForm
    : BaseForm
  {
    public VirtualModeDemonstrationForm()
    {
      this.InitializeComponent();
    }

    protected override void OnLoad(EventArgs e)
    {
      base.OnLoad(e);

      propertyGrid.SelectItem("VirtualSize");
    }

    private void imageBox_VirtualDraw(object sender, PaintEventArgs e)
    {
      RectangleF bounds;

      bounds = imageBox.GetOffsetRectangle(new RectangleF(PointF.Empty, imageBox.VirtualSize));

      using (Brush brush = new SolidBrush(Color.FromArgb(128, Color.Goldenrod)))
        e.Graphics.FillRectangle(brush, bounds);

      using (Pen pen = new Pen(Color.DarkGoldenrod, (float)imageBox.ZoomFactor * 2))
        e.Graphics.DrawRectangle(pen, bounds.X, bounds.Y, bounds.Width, bounds.Height);

      using (Font font = new Font(this.Font.FontFamily, (float)(8 * imageBox.ZoomFactor)))
      {
        TextRenderer.DrawText(e.Graphics,
                              "Use the VirtualMode and VirtualSize properties along with the VirtualDraw event to provide full control without needing a backing image.",
                              font,
                              new Rectangle((int)bounds.Left, (int)bounds.Top, (int)bounds.Width, (int)bounds.Height),
                              Color.Black,
                              TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter |
                              TextFormatFlags.WordBreak | TextFormatFlags.WordEllipsis);
      }
    }
  }
}
