using System;
using System.Windows.Forms;

namespace Cyotek.Windows.Forms.Demo
{
  // Cyotek ImageBox
  // Copyright (c) 2010-2013 Cyotek.
  // http://cyotek.com
  // http://cyotek.com/blog/tag/imagebox

  // Licensed under the MIT License. See imagebox-license.txt for the full text.

  // If you use this control in your applications, attribution, donations or contributions are welcome.

  internal partial class MainMenuForm : AboutDialog
  {
    #region Constructors

    public MainMenuForm()
    {
      InitializeComponent();
    }

    #endregion

    #region Overridden Members

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

      groupBox1.Dock = DockStyle.Fill;
      demoPage.Controls.Add(groupBox1);

      this.TabControl.TabPages.Insert(0, demoPage);
      this.TabControl.SelectedTab = demoPage;

      this.Text = "Cyotek ImageBox Control for Windows Forms";
    }

    #endregion

    #region Event Handlers

    private void animatedGifDemoButton_Click(object sender, EventArgs e)
    {
      using (Form form = new AnimatedGifDemoForm())
        form.ShowDialog(this);
    }

    private void dragTestDemoButton_Click(object sender, EventArgs e)
    {
      using (Form form = new DragTestForm())
        form.ShowDialog(this);
    }

    private void imageBoxDemoButton_Click(object sender, EventArgs e)
    {
      using (Form form = new ImageBoxDemoForm())
        form.ShowDialog(this);
    }

    private void pixelGridDemoButton_Click(object sender, EventArgs e)
    {
      using (Form form = new PixelGridForm())
        form.ShowDialog(this);
    }

    private void scaledAdornmentsDemoButton_Click(object sender, EventArgs e)
    {
      using (Form form = new ScaledAdornmentsDemoForm())
        form.ShowDialog(this);
    }

    private void sizeModeDemoButton_Click(object sender, EventArgs e)
    {
      using (Form form = new SizeModeDemoForm())
        form.ShowDialog(this);
    }

    private void switchImageDuringZoomDemoButton_Click(object sender, EventArgs e)
    {
      using (Form form = new SwitchImageDuringZoomDemoForm())
        form.ShowDialog(this);
    }

    private void textDemoButton_Click(object sender, EventArgs e)
    {
      using (Form form = new TextDemoForm())
        form.ShowDialog(this);
    }

    private void virtualModeDemoButton_Click(object sender, EventArgs e)
    {
      using (Form form = new VirtualModeDemonstrationForm())
        form.ShowDialog(this);
    }

    #endregion
  }
}
