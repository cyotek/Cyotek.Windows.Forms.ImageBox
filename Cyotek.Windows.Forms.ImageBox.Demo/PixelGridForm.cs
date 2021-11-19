// Cyotek ImageBox
// http://cyotek.com/blog/tag/imagebox

// Copyright (c) 2010-2021 Cyotek Ltd.

// This work is licensed under the MIT License.
// See LICENSE.TXT for the full text

// Found this code useful?
// https://www.cyotek.com/contribute

using System;

namespace Cyotek.Windows.Forms.Demo
{
  internal partial class PixelGridForm : DemonstrationBaseForm
  {
    #region Public Constructors

    public PixelGridForm()
    {
      this.InitializeComponent();
    }

    #endregion

    #region Overridden Methods

    protected override void OnLoad(EventArgs e)
    {
      base.OnLoad(e);

      propertyGrid.SelectItem("ShowPixelGrid");
    }

    #endregion
  }
}
