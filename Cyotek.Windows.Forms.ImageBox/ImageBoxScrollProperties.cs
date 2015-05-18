using System.ComponentModel;
using System.Windows.Forms;

namespace Cyotek.Windows.Forms
{
  /// <summary>
  /// Encapsulates properties related to scrolling.
  /// </summary>
  public sealed class ImageBoxScrollProperties
  {
    #region Constants

    private readonly ScrollBar _scrollBar;

    #endregion

    #region Constructors

    internal ImageBoxScrollProperties(ScrollBar scrollBar)
    {
      _scrollBar = scrollBar;
    }

    #endregion

    #region Properties

    /// <summary>
    /// Gets or sets whether the scroll bar can be used on the container.
    /// </summary>
    /// <value><c>true</c> if the scroll bar can be used; otherwise, <c>false</c>.</value>
    [DefaultValue(true)]
    public bool Enabled
    {
      get { return _scrollBar.Enabled; }
      internal set { _scrollBar.Enabled = value; }
    }

    /// <summary>
    /// Gets or sets the distance to move a scroll bar in response to a large scroll command.
    /// </summary>
    /// <value>An <see cref="int"/> describing how far, in pixels, to move the scroll bar in response to a large change.</value>
    [DefaultValue(10)]
    public int LargeChange
    {
      get { return _scrollBar.LargeChange; }
      internal set { _scrollBar.LargeChange = value; }
    }

    /// <summary>
    /// Gets or sets the upper limit of the scrollable range.
    /// </summary>
    /// <value>An <see cref="int"/> representing the maximum range of the scroll bar.</value>
    [DefaultValue(100)]
    public int Maximum
    {
      get { return _scrollBar.Maximum; }
      internal set { _scrollBar.Maximum = value; }
    }

    /// <summary>
    /// Gets or sets the lower limit of the scrollable range.
    /// </summary>
    /// <value>An <see cref="int"/> representing the lower range of the scroll bar.</value>
    [DefaultValue(0)]
    public int Minimum
    {
      get { return _scrollBar.Minimum; }
      internal set { _scrollBar.Minimum = value; }
    }

    /// <summary>
    /// Gets or sets the distance to move a scroll bar in response to a small scroll command.
    /// </summary>
    /// <value>An <see cref="int"/> representing how far, in pixels, to move the scroll bar.</value>
    [DefaultValue(1)]
    public int SmallChange
    {
      get { return _scrollBar.SmallChange; }
      internal set { _scrollBar.SmallChange = value; }
    }

    /// <summary>
    /// Gets or sets a numeric value that represents the current position of the scroll bar box.
    /// </summary>
    /// <value>An <see cref="int"/> representing the position of the scroll bar box, in pixels. </value>
    [Bindable(true)]
    [DefaultValue(0)]
    public int Value
    {
      get { return _scrollBar.Value; }
      internal set
      {
        if (value < this.Minimum)
        {
          value = this.Minimum;
        }
        else if (value > this.Maximum)
        {
          value = this.Maximum;
        }

        _scrollBar.Value = value;
      }
    }

    /// <summary>
    /// Gets or sets whether the scroll bar can be seen by the user.
    /// </summary>
    /// <value><c>true</c> if it can be seen; otherwise, <c>false</c>.</value>
    [DefaultValue(false)]
    public bool Visible
    {
      get { return _scrollBar.Visible; }
      internal set { _scrollBar.Visible = value; }
    }

    #endregion
  }
}
