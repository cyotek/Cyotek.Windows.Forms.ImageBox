// Cyotek Color Picker Controls Library
// http://cyotek.com/blog/tag/colorpicker

// Copyright (c) 2013-2021 Cyotek Ltd.

// This work is licensed under the MIT License.
// See LICENSE.TXT for the full text

// Found this code useful?
// https://www.cyotek.com/contribute

using System;
using System.Windows.Forms;

namespace Cyotek.Windows.Forms.Demo
{
  internal partial class MainForm : AboutDialog
  {
    #region Public Constructors

    public MainForm()
    {
      this.InitializeComponent();
    }

    #endregion Public Constructors

    #region Protected Methods

    protected override void OnLoad(EventArgs e)
    {
      TabPage demoPage;

      base.OnLoad(e);

      demoPage = new TabPage
      {
        UseVisualStyleBackColor = true,
        Padding = new Padding(9),
        Text = "Demonstrations"
      };

      demoList.Dock = DockStyle.Fill;
      demoPage.Controls.Add(demoList);

      this.TabControl.TabPages.Insert(0, demoPage);
      this.TabControl.SelectedTab = demoPage;

      this.Text = Application.ProductName;
    }

    #endregion Protected Methods
  }
}
