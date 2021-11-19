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
  internal partial class TextDemoForm : DemonstrationBaseForm
  {
    #region Public Constructors

    public TextDemoForm()
    {
      InitializeComponent();
    }

    #endregion Public Constructors

    #region Protected Methods

    protected override void OnLoad(EventArgs e)
    {
      base.OnLoad(e);

      propertyGrid.SelectItem("TextPadding"); // HACK: This forces the property grid to scroll the property into view
      propertyGrid.SelectItem("Text");
    }

    #endregion Protected Methods
  }
}
