using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Cyotek.Windows.Forms;

namespace ImageBoxSample
{
  // Cyotek ImageBox
  // Copyright (c) 2010-2012 Cyotek. All Rights Reserved.
  // http://cyotek.com

  // If you use this control in your applications, attribution or donations are welcome.

  // ImageBox sample project
  // http://cyotek.com/article/display/creating-a-scrollable-and-zoomable-image-viewer-in-csharp-part-1
  // http://cyotek.com/article/display/creating-a-scrollable-and-zoomable-image-viewer-in-csharp-part-2
  // http://cyotek.com/article/display/creating-a-scrollable-and-zoomable-image-viewer-in-csharp-part-3
  // http://cyotek.com/article/display/creating-a-scrollable-and-zoomable-image-viewer-in-csharp-part-4
  // http://cyotek.com/article/display/creating-an-image-viewer-in-csharp-part-5-selecting-part-of-an-image

  // Preview image based on Glyfz sampler - http://www.glyfz.com/sampler.htm
  // Large preview image from http://www.crazythemes.com/colorful-abstract-widescreen-wallpapers-vol2/2153
  // Toolbar icons from Fugue Icons - http://p.yusukekamiyamane.com/

  public partial class MainForm : Form
  {
    #region  Private Member Declarations

    private Bitmap _previewImage;

    #endregion  Private Member Declarations

    #region  Public Constructors

    public MainForm()
    {
      InitializeComponent();
    }

    #endregion  Public Constructors

    #region  Event Handlers

    private void actualSizeToolStripButton_Click(object sender, EventArgs e)
    {
      imageBox.ActualSize();
    }

    private void imageBox_MouseLeave(object sender, EventArgs e)
    {
      cursorToolStripStatusLabel.Text = string.Empty;
    }

    private void imageBox_MouseMove(object sender, MouseEventArgs e)
    {
      this.UpdateCursorPosition(e.Location);
    }

    private void imageBox_Paint(object sender, PaintEventArgs e)
    {
      // highlight the image
      if (showImageRegionToolStripButton.Checked)
        this.DrawBox(e.Graphics, Color.CornflowerBlue, imageBox.GetImageViewPort(), imageBox.ZoomFactor);

      // show the region that will be drawn from the source image
      if (showSourceImageRegionToolStripButton.Checked)
        this.DrawBox(e.Graphics, Color.Firebrick, new RectangleF(imageBox.GetImageViewPort().Location, imageBox.GetSourceImageRegion().Size), imageBox.ZoomFactor);
    }

    private void imageBox_Resize(object sender, EventArgs e)
    {
      this.UpdateStatusBar();
    }

    private void imageBox_Scroll(object sender, ScrollEventArgs e)
    {
      this.UpdateStatusBar();
    }

    private void imageBox_Selected(object sender, EventArgs e)
    {
      this.UpdatePreviewImage();
    }

    private void imageBox_SelectionRegionChanged(object sender, EventArgs e)
    {
      selectionToolStripStatusLabel.Text = this.FormatRectangle(imageBox.SelectionRegion);
    }

    private void imageBox_ZoomChanged(object sender, EventArgs e)
    {
      this.UpdateStatusBar();
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
      imageBox.SelectionMode = ImageBoxSelectionMode.Rectangle;
      imageBox.SelectionRegion = new Rectangle(5, 5, 32, 32);
      propertyGrid.SelectedGridItem = propertyGrid.FindItem("SelectionMode");

      this.UpdateStatusBar();
      this.UpdatePreviewImage();
    }

    private void selectAllToolStripButton_Click(object sender, EventArgs e)
    {
      imageBox.SelectAll();

      this.UpdatePreviewImage();
    }

    private void selectNoneToolStripButton_Click(object sender, EventArgs e)
    {
      imageBox.SelectNone();

      this.UpdatePreviewImage();
    }

    private void showImageRegionToolStripButton_Click(object sender, EventArgs e)
    {
      imageBox.Invalidate();
    }

    private void zoomInToolStripButton_Click(object sender, EventArgs e)
    {
      imageBox.ZoomIn();
    }

    private void zoomOutToolStripButton_Click(object sender, EventArgs e)
    {
      imageBox.ZoomOut();
    }

    #endregion  Event Handlers

    #region  Private Methods

    private void DrawBox(Graphics graphics, Color color, RectangleF rectangle, double scale)
    {
      float penWidth;

      penWidth = 2 * (float)scale;

      using (SolidBrush brush = new SolidBrush(Color.FromArgb(64, color)))
        graphics.FillRectangle(brush, rectangle);

      using (Pen pen = new Pen(color, penWidth) { DashStyle = DashStyle.Dot, DashCap = DashCap.Round })
        graphics.DrawRectangle(pen, rectangle.X, rectangle.Y, rectangle.Width, rectangle.Height);
    }

    private string FormatPoint(Point point)
    {
      return string.Format("X:{0}, Y:{1}", point.X, point.Y);
    }

    private string FormatRectangle(RectangleF rect)
    {
      return string.Format("X:{0}, Y:{1}, W:{2}, H:{3}", (int)rect.X, (int)rect.Y, (int)rect.Width, (int)rect.Height);
    }

    private void UpdateCursorPosition(Point location)
    {
      Point point;

      point = imageBox.PointToImage(location);

      if (point != Point.Empty)
        cursorToolStripStatusLabel.Text = this.FormatPoint(point);
      else
        cursorToolStripStatusLabel.Text = string.Empty;
    }

    private void UpdatePreviewImage()
    {
      previewImageBox.Image = null;

      if (imageBox.LimitSelectionToImage && !imageBox.SelectionRegion.IsEmpty)
      {
        Rectangle rect;

        if (_previewImage != null)
          _previewImage.Dispose();

        rect = new Rectangle((int)imageBox.SelectionRegion.X, (int)imageBox.SelectionRegion.Y, (int)imageBox.SelectionRegion.Width, (int)imageBox.SelectionRegion.Height);

        _previewImage = new Bitmap(rect.Width, rect.Height);

        using (Graphics g = Graphics.FromImage(_previewImage))
          g.DrawImage(imageBox.Image, new Rectangle(Point.Empty, rect.Size), rect, GraphicsUnit.Pixel);
      }

      previewImageBox.Image = _previewImage;
    }

    private void UpdateStatusBar()
    {
      autoScrollPositionToolStripStatusLabel.Text = this.FormatPoint(imageBox.AutoScrollPosition);
      imageSizeToolStripStatusLabel.Text = this.FormatRectangle(imageBox.GetImageViewPort());
      zoomToolStripStatusLabel.Text = string.Format("{0}%", imageBox.Zoom);
    }

    #endregion  Private Methods
  }
}
