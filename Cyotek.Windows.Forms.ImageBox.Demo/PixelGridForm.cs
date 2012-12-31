using System;

namespace Cyotek.Windows.Forms.Demo
{
  public partial class PixelGridForm : BaseForm
  {
    #region Constructors

    public PixelGridForm()
    {
      this.InitializeComponent();
    }

    #endregion

    #region Members

    protected override void OnLoad(EventArgs e)
    {
      base.OnLoad(e);

      propertyGrid.SelectItem("ShowPixelGrid");
    }

    #endregion
  }
}
