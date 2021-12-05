// Cyotek ImageBox
// http://cyotek.com/blog/tag/imagebox

// Copyright (c) 2010-2021 Cyotek Ltd.

// This work is licensed under the MIT License.
// See LICENSE.TXT for the full text

// Found this code useful?
// https://www.cyotek.com/contribute

using System;
using System.Windows.Forms;

namespace Cyotek.Windows.Forms.Demo
{
  internal partial class DemoList : UserControl
  {
    #region Public Constructors

    public DemoList()
    {
      this.InitializeComponent();
    }

    #endregion Public Constructors

    #region Private Methods

    private void AnimatedGifDemoButton_Click(object sender, EventArgs e)
    {
      this.ShowDemo<AnimatedGifDemoForm>();
    }

    private void DragTestDemoButton_Click(object sender, EventArgs e)
    {
      this.ShowDemo<DragTestForm>();
    }

    private void ImageBoxDemoButton_Click(object sender, EventArgs e)
    {
      this.ShowDemo<GeneralDemoForm>();
    }

    private void MinimapDemoButton_Click(object sender, EventArgs e)
    {
      this.ShowDemo<MiniMapDemoForm>();
    }

    private void PanStylesDemoButton_Click(object sender, EventArgs e)
    {
      this.ShowDemo<PanStylesDemoForm>();
    }

    private void PixelGridDemoButton_Click(object sender, EventArgs e)
    {
      this.ShowDemo<PixelGridForm>();
    }

    private void ResizableSelectionDemoButton_Click(object sender, EventArgs e)
    {
      this.ShowDemo<ResizableSelectionDemoForm>();
    }

    private void ScaledAdornmentsDemoButton_Click(object sender, EventArgs e)
    {
      this.ShowDemo<ScaledAdornmentsDemoForm>();
    }

    private void ShowDemo<T>()
      where T : Form, new()
    {
      Cursor.Current = Cursors.WaitCursor;

      using (Form form = new T())
      {
        form.ShowDialog(this);
      }
    }

    private void SizeModeDemoButton_Click(object sender, EventArgs e)
    {
      this.ShowDemo<SizeModeDemoForm>();
    }

    private void SwitchImageDuringZoomDemoButton_Click(object sender, EventArgs e)
    {
      this.ShowDemo<SwitchImageDuringZoomDemoForm>();
    }

    private void TextDemoButton_Click(object sender, EventArgs e)
    {
      this.ShowDemo<TextDemoForm>();
    }

    private void VirtualModeDemoButton_Click(object sender, EventArgs e)
    {
      this.ShowDemo<VirtualModeDemonstrationForm>();
    }

    #endregion Private Methods
  }
}
