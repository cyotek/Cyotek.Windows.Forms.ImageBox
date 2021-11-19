// Reading DOOM WAD files
// https://www.cyotek.com/blog/reading-doom-wad-files

// Writing DOOM WAD files
// https://www.cyotek.com/blog/writing-doom-wad-files

// Copyright (c) 2020-2021 Cyotek Ltd. All Rights Reserved.

// This work is licensed under the MIT License.
// See LICENSE.txt for the full text

// Found this example useful?
// https://www.cyotek.com/contribute

using Cyotek.Windows.Forms.Demo.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Cyotek.Windows.Forms.Demo
{
  internal class BaseForm : System.Windows.Forms.Form
  {
    #region Protected Constructors

    protected BaseForm()
    {
      base.MaximizeBox = false;
      base.MinimizeBox = false;
      base.ShowIcon = false;
      base.ShowInTaskbar = false;
      base.StartPosition = FormStartPosition.CenterParent;
      this.AutoScaleDimensions = new SizeF(6F, 13F);
      this.AutoScaleMode = AutoScaleMode.Font;
      base.Icon = Resources.ApplicationIcon;
    }

    #endregion Protected Constructors

    #region Public Properties

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public override Font Font
    {
      get => base.Font;
      set => base.Font = value;
    }

    [DefaultValue(false)]
    public new bool MaximizeBox
    {
      get => base.MaximizeBox;
      set => base.MaximizeBox = value;
    }

    [DefaultValue(false)]
    public new bool MinimizeBox
    {
      get => base.MinimizeBox;
      set => base.MinimizeBox = value;
    }

    [DefaultValue(false)]
    public new bool ShowIcon
    {
      get => base.ShowIcon;
      set => base.ShowIcon = value;
    }

    [DefaultValue(false)]
    public new bool ShowInTaskbar
    {
      get => base.ShowInTaskbar;
      set => base.ShowInTaskbar = value;
    }

    [DefaultValue(typeof(FormStartPosition), "CenterParent")]
    public new FormStartPosition StartPosition
    {
      get => base.StartPosition;
      set => base.StartPosition = value;
    }

    #endregion Public Properties

    #region Protected Methods

    protected override void OnLoad(EventArgs e)
    {
      if (!this.DesignMode)
      {
        this.Font = SystemFonts.MessageBoxFont;
      }

      base.OnLoad(e);
    }

    protected override void OnShown(EventArgs e)
    {
      base.OnShown(e);

      Cursor.Current = Cursors.Default;
    }

    #endregion Protected Methods
  }
}
