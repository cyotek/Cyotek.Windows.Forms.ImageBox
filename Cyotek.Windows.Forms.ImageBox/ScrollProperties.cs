using System.ComponentModel;

// Original ScrollControl code by Scott Crawford (http://sukiware.com/)

namespace Cyotek.Windows.Forms
{
  partial class ScrollControl
  {
    public class HScrollProperties : ScrollProperties
    {
      public HScrollProperties(ScrollControl container)
        : base(container)
      { }
    }

    public abstract class ScrollProperties
    {
      private ScrollControl _container;

      protected ScrollProperties(ScrollControl container)
      {
        _container = container;
      }

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

      [Bindable(true)]
      [DefaultValue(0)]
      public int Value { get; set; }

      [DefaultValue(false)]
      public bool Visible { get; set; }

      protected ScrollControl ParentControl
      { get { return _container; } }
    }

    public class VScrollProperties : ScrollProperties
    {
      public VScrollProperties(ScrollControl container)
        : base(container)
      { }
    }
  }
}