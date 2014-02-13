using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Cyotek.Windows.Forms.Demo.Properties;

namespace Cyotek.Windows.Forms.Demo
{
  // Cyotek ImageBox
  // Copyright (c) 2010-2014 Cyotek.
  // http://cyotek.com
  // http://cyotek.com/blog/tag/imagebox

  // Licensed under the MIT License. See imagebox-license.txt for the full text.

  // If you use this control in your applications, attribution, donations or contributions are welcome.

  internal partial class ScaledAdornmentsDemoForm : BaseForm
  {
    #region Instance Fields

    private List<Point> _landmarks;

    private Bitmap _markerImage;

    #endregion

    #region Public Constructors

    public ScaledAdornmentsDemoForm()
    {
      InitializeComponent();
    }

    #endregion

    #region Overridden Methods

    protected override void OnLoad(EventArgs e)
    {
      base.OnLoad(e);

      imageBox.ZoomToFit();

      _markerImage = Resources.MapMarker;

      _landmarks = new List<Point>();
      this.AddLandmark(new Point(467, 447));
      this.AddLandmark(new Point(662, 262));
      this.AddLandmark(new Point(779, 239));
    }

    #endregion

    #region Private Members

    private void AddLandmark(Point point)
    {
      Debug.Print("Added landmark: {0}", point);

      _landmarks.Add(new Point(point.X - (_markerImage.Size.Width / 2), point.Y - _markerImage.Size.Height));
    }

    #endregion

    #region Event Handlers

    private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
    {
      AboutDialog.ShowAboutDialog();
    }

    private void closeToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void imageBox_MouseClick(object sender, MouseEventArgs e)
    {
      if (imageBox.IsPointInImage(e.Location))
      {
        // add a new landmark
        this.AddLandmark(imageBox.PointToImage(e.Location));

        // force the image to repaint
        imageBox.Invalidate();
      }
    }

    private void imageBox_Paint(object sender, PaintEventArgs e)
    {
      Size markerSize;

      // Work out the size of the marker graphic according to the current zoom level
      markerSize = imageBox.GetScaledSize(_markerImage.Size);

      foreach (Point landmark in _landmarks)
      {
        Point location;

        // Work out the location of the marker graphic according to the current zoom level and scroll offset
        location = imageBox.GetOffsetPoint(landmark);

        // Draw the marker
        e.Graphics.DrawImage(_markerImage, new Rectangle(location, markerSize), new Rectangle(Point.Empty, _markerImage.Size), GraphicsUnit.Pixel);
      }
    }

    #endregion
  }
}
