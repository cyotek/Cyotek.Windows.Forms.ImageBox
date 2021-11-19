// Cyotek ImageBox
// http://cyotek.com/blog/tag/imagebox

// Copyright (c) 2010-2021 Cyotek Ltd.

// This work is licensed under the MIT License.
// See LICENSE.TXT for the full text

// Found this code useful?
// https://www.cyotek.com/contribute

using Cyotek.Windows.Forms.Demo.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Cyotek.Windows.Forms.Demo
{
  internal partial class ScaledAdornmentsDemoForm : DemonstrationBaseForm
  {
    #region Private Fields

    private List<Point> _landmarks;

    private Bitmap _markerImage;

    #endregion Private Fields

    #region Public Constructors

    public ScaledAdornmentsDemoForm()
    {
      this.InitializeComponent();
    }

    #endregion Public Constructors

    #region Protected Methods

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

    #endregion Protected Methods

    #region Private Methods

    private void AddLandmark(Point point)
    {
      Debug.Print("Added landmark: {0}", point);

      _landmarks.Add(new Point(point.X, point.Y));
    }

    private void ImageBox_MouseClick(object sender, MouseEventArgs e)
    {
      if (imageBox.IsPointInImage(e.Location))
      {
        // add a new landmark
        this.AddLandmark(imageBox.PointToImage(e.Location));

        // force the image to repaint
        imageBox.Invalidate();
      }
    }

    private void ImageBox_MouseLeave(object sender, EventArgs e)
    {
      positionToolStripStatusLabel.Text = string.Empty;
    }

    private void ImageBox_MouseMove(object sender, MouseEventArgs e)
    {
      this.UpdateCursorPosition(e.Location);
    }

    private void ImageBox_Paint(object sender, PaintEventArgs e)
    {
      Graphics g;
      GraphicsState originalState;
      Size scaledSize;
      Size originalSize;
      Size drawSize;
      bool scaleAdornmentSize;

      scaleAdornmentSize = scaleAdornmentsCheckBox.Checked;

      g = e.Graphics;

      originalState = g.Save();

      // Work out the size of the marker graphic according to the current zoom level
      originalSize = _markerImage.Size;
      scaledSize = imageBox.GetScaledSize(originalSize);
      drawSize = scaleAdornmentSize ? scaledSize : originalSize;

      foreach (Point landmark in _landmarks)
      {
        Point location;

        // Work out the location of the marker graphic according to the current zoom level and scroll offset
        location = imageBox.GetOffsetPoint(landmark);

        // adjust the location so that the image is displayed above the location and centered to it
        location.Y -= drawSize.Height;
        location.X -= drawSize.Width >> 1;

        // Draw the marker
        g.InterpolationMode = InterpolationMode.NearestNeighbor;
        g.DrawImage(_markerImage, new Rectangle(location, drawSize), new Rectangle(Point.Empty, originalSize), GraphicsUnit.Pixel);
      }

      g.Restore(originalState);
    }

    private void ScaleAdornmentsCheckBox_CheckedChanged(object sender, EventArgs e)
    {
      imageBox.Invalidate();
    }

    private void UpdateCursorPosition(Point location)
    {
      Point point;

      point = imageBox.PointToImage(location);

      positionToolStripStatusLabel.Text = this.FormatPoint(point);
    }

    #endregion Private Methods
  }
}
