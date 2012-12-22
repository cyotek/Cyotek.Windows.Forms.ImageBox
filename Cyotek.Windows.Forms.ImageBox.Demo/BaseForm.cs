using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cyotek.Windows.Forms.Demo
{
  public partial class BaseForm 
    : Form
  {
    public BaseForm()
    {
      this.InitializeComponent();
    }

    protected override void OnLoad(EventArgs e)
    {
      this.Font = SystemFonts.MessageBoxFont;

      base.OnLoad(e);
    }
  }
}
