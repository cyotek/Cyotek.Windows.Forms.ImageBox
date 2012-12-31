using System.ComponentModel;

// Original ScrollControl code by Scott Crawford (http://sukiware.com/)

namespace Cyotek.Windows.Forms
{
  partial class ScrollControl
  {
    #region Nested Types

    public class HScrollProperties : ScrollProperties
    {
      #region Constructors

      public HScrollProperties(ScrollControl container)
        : base(container)
      { }

      #endregion
    }

    public abstract class ScrollProperties
    {
      #region Instance Fields

      private readonly ScrollControl _container;

      #endregion

      #region Constructors

      protected ScrollProperties(ScrollControl container)
      {
        _container = container;
      }

      #endregion

      #region Properties

      [DefaultValue(true)]
      public bool Enabled { get; set; }

      [DefaultValue(10)]
      public int LargeChange { get; set; }

      [DefaultValue(100)]
      public int Maximum { get; set; }

      [DefaultValue(0)]
      public int Minimum { get; set; }

      [DefaultValue(1)]
      public int SmallChange { get; set; }

      [Bindable(true), DefaultValue(0)]
      public int Value { get; set; }

      [DefaultValue(false)]
      public bool Visible { get; set; }

      protected ScrollControl ParentControl
      {
        get { return _container; }
      }

      #endregion
    }

    public class VScrollProperties : ScrollProperties
    {
      #region Constructors

      public VScrollProperties(ScrollControl container)
        : base(container)
      { }

      #endregion
    }

    #endregion
  }
}
