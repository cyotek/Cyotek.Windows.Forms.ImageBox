// Cyotek ImageBox
// http://cyotek.com/blog/tag/imagebox

// Copyright (c) 2010-2021 Cyotek Ltd.

// This work is licensed under the MIT License.
// See LICENSE.TXT for the full text

// Found this code useful?
// https://www.cyotek.com/contribute

using Cyotek.Windows.Forms.Demo.Properties;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace Cyotek.Windows.Forms.Demo
{
  internal partial class GeneralDemoForm : DemonstrationBaseForm
  {
    #region Private Fields

    private Image _previewImage;

    #endregion Private Fields

    #region Public Constructors

    public GeneralDemoForm()
    {
      this.InitializeComponent();
    }

    #endregion Public Constructors

    #region Protected Methods

    protected override void OnLoad(EventArgs e)
    {
      base.OnLoad(e);

      this.FillZoomLevels();
      this.OpenImage(Resources.Sample);

      imageBox.SelectionMode = ImageBoxSelectionMode.Zoom;
      imageBox.AllowClickZoom = true;
    }

    #endregion Protected Methods

    #region Private Methods

    private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
    {
      AboutDialog.ShowAboutDialog();
    }

    private void ActualSizeToolStripButton_Click(object sender, EventArgs e)
    {
      imageBox.ActualSize();
    }

    private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
    {
      try
      {
        Clipboard.Clear();
        Clipboard.SetImage(imageBox.GetSelectedImage() ?? imageBox.Image);
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void DrawBox(Graphics graphics, Color color, RectangleF rectangle, double scale)
    {
      float penWidth;

      penWidth = 2 * (float)scale;

      using (SolidBrush brush = new SolidBrush(Color.FromArgb(64, color)))
      {
        graphics.FillRectangle(brush, rectangle);
      }

      using (Pen pen = new Pen(color, penWidth)
      {
        DashStyle = DashStyle.Dot,
        DashCap = DashCap.Round
      })
      {
        graphics.DrawRectangle(pen, rectangle.X, rectangle.Y, rectangle.Width, rectangle.Height);
      }
    }

    private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void FillZoomLevels()
    {
      zoomLevelsToolStripComboBox.Items.Clear();

      foreach (int zoom in imageBox.ZoomLevels)
      {
        zoomLevelsToolStripComboBox.Items.Add(string.Format("{0}%", zoom));
      }
    }

    private void FromURLToolStripMenuItem_Click(object sender, EventArgs e)
    {
      using (OpenUrlDialog dialog = new OpenUrlDialog())
      {
        if (dialog.ShowDialog(this) == DialogResult.OK)
        {
          this.OpenImageFromUrl(dialog.Url);
        }
      }
    }

    private void ImageBox_MouseLeave(object sender, EventArgs e)
    {
      cursorToolStripStatusLabel.Text = string.Empty;
    }

    private void ImageBox_MouseMove(object sender, MouseEventArgs e)
    {
      this.UpdateCursorPosition(e.Location);
    }

    private void ImageBox_Paint(object sender, PaintEventArgs e)
    {
      // highlight the image
      if (showImageRegionToolStripButton.Checked)
      {
        this.DrawBox(e.Graphics, Color.CornflowerBlue, imageBox.GetImageViewPort(), 1);
      }

      // show the region that will be drawn from the source image
      if (showSourceImageRegionToolStripButton.Checked)
      {
        this.DrawBox(e.Graphics, Color.Firebrick, new RectangleF(imageBox.GetImageViewPort().Location, imageBox.GetSourceImageRegion().Size), 1);
      }
    }

    private void ImageBox_Resize(object sender, EventArgs e)
    {
      this.UpdateStatusBar();
    }

    private void ImageBox_Scroll(object sender, ScrollEventArgs e)
    {
      this.UpdateStatusBar();
    }

    private void ImageBox_Selected(object sender, EventArgs e)
    {
      this.UpdatePreviewImage();
    }

    private void ImageBox_SelectionRegionChanged(object sender, EventArgs e)
    {
      selectionToolStripStatusLabel.Text = this.FormatRectangle(imageBox.SelectionRegion);
    }

    private void ImageBox_ZoomChanged(object sender, EventArgs e)
    {
      this.UpdateStatusBar();
    }

    private void ImageBox_ZoomLevelsChanged(object sender, EventArgs e)
    {
      this.FillZoomLevels();
    }

    private void OpenFromFileToolStripMenuItem_Click(object sender, EventArgs e)
    {
      using (FileDialog dialog = new OpenFileDialog())
      {
        dialog.Filter = "All Supported Images (*.bmp;*.dib;*.rle;*.gif;*.jpg;*.png;*.tif;*.tiff)|*.bmp;*.dib;*.rle;*.gif;*.jpg;*.png;*.tif;*.tiff|Bitmaps (*.bmp;*.dib;*.rle)|*.bmp;*.dib;*.rle|Graphics Interchange Format (*.gif)|*.gif|Joint Photographic Experts (*.jpg)|*.jpg|Portable Network Graphics (*.png)|*.png|Tagged Image File Format (*.tif;*.tiff)|*.tif;*.tiff|All Files (*.*)|*.*";
        dialog.DefaultExt = "png";

        if (dialog.ShowDialog(this) == DialogResult.OK)
        {
          try
          {
            this.OpenImage(Image.FromFile(dialog.FileName));
          }
          catch (Exception ex)
          {
            MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
          }
        }
      }
    }

    private void OpenImage(Image image)
    {
      imageBox.Image = image;
      imageBox.ZoomToFit();

      this.UpdateStatusBar();
      this.UpdatePreviewImage();
    }

    private void OpenImageFromUrl(string url)
    {
      try
      {
        using (WebClient client = new WebClient())
        {
          byte[] data;

          data = client.DownloadData(url);

          using (Stream stream = new MemoryStream(data))
          {
            this.OpenImage(Image.FromStream(stream));
          }
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void SelectAllToolStripMenuItem_Click(object sender, EventArgs e)
    {
      imageBox.SelectAll();
    }

    private void SelectNoneToolStripMenuItem_Click(object sender, EventArgs e)
    {
      imageBox.SelectNone();
    }

    private void ShowImageRegionToolStripButton_Click(object sender, EventArgs e)
    {
      imageBox.Invalidate();
    }

    private void UpdateCursorPosition(Point location)
    {
      if (!fitCursorLocationToBoundsToolStripMenuItem.Checked || imageBox.IsPointInImage(location))
      {
        Point point;

        point = imageBox.PointToImage(location);

        cursorToolStripStatusLabel.Text = this.FormatPoint(point);
      }
      else
      {
        cursorToolStripStatusLabel.Text = string.Empty;
      }
    }

    private void UpdatePreviewImage()
    {
      if (_previewImage != null)
      {
        _previewImage.Dispose();
      }

      _previewImage = imageBox.GetSelectedImage();

      previewImageBox.Image = _previewImage;
    }

    private void UpdateStatusBar()
    {
      zoomLevelsToolStripComboBox.Text = string.Format("{0}%", imageBox.Zoom);
      autoScrollPositionToolStripStatusLabel.Text = this.FormatPoint(imageBox.AutoScrollPosition);
      imageSizeToolStripStatusLabel.Text = this.FormatRectangle(imageBox.GetImageViewPort());
      zoomToolStripStatusLabel.Text = string.Format("{0}%", imageBox.Zoom);
    }

    private void ZoomInToolStripButton_Click(object sender, EventArgs e)
    {
      imageBox.ZoomIn();
    }

    private void ZoomLevelsToolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
      int zoom;

      zoom = Convert.ToInt32(zoomLevelsToolStripComboBox.Text.Substring(0, zoomLevelsToolStripComboBox.Text.Length - 1));

      imageBox.Zoom = zoom;
    }

    private void ZoomOutToolStripButton_Click(object sender, EventArgs e)
    {
      imageBox.ZoomOut();
    }

    #endregion Private Methods
  }
}
