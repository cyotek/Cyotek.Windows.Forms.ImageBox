using System.ComponentModel;
using System.Drawing;

namespace Cyotek.Windows.Forms
{
  public class ImageBoxCancelEventArgs : CancelEventArgs
  {
    #region Constructors

    public ImageBoxCancelEventArgs(Point location)
      : this()
    {
      this.Location = location;
    }

    protected ImageBoxCancelEventArgs()
    { }

    #endregion

    #region Properties

    public Point Location { get; protected set; }

    #endregion
  }
}
