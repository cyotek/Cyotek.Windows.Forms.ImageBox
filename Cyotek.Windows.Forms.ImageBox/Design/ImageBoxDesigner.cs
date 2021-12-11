// Cyotek ImageBox
// http://cyotek.com/blog/tag/imagebox

// Copyright (c) 2010-2021 Cyotek Ltd.

// This work is licensed under the MIT License.
// See LICENSE.TXT for the full text

// Found this code useful?
// https://www.cyotek.com/contribute

using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace Cyotek.Windows.Forms.Design
{
  /// <summary>
  /// Provides design mode behavior for an <see cref="ImageBox"/> control.
  /// </summary>
  public class ImageBoxDesigner : ControlDesigner
  {
    #region Private Fields

    private DesignerVerb _dockVerb;

    private DesignerVerb _undockVerb;

    private DesignerVerbCollection _verbs;

    #endregion Private Fields

    #region Public Properties

    /// <summary>
    /// Gets the design-time verbs supported by the component that is associated with the designer.
    /// </summary>
    /// <value>A collection that contains the verbs that are available to the designer.</value>
    /// <returns>A <see cref="T:System.ComponentModel.Design.DesignerVerbCollection" /> of <see cref="T:System.ComponentModel.Design.DesignerVerb" /> objects, or null if no designer verbs are available. This default implementation always returns null.</returns>
    public override DesignerVerbCollection Verbs
    {
      get
      {
        if (_verbs == null)
        {
          _verbs = new DesignerVerbCollection();

          _dockVerb = new DesignerVerb("Dock to parent control", this.DockVerbHandler)
          {
            Description = "Dock this control with its parent.",
            Enabled = this.ImageBoxControl.Dock == DockStyle.None
          };
          _verbs.Add(_dockVerb);

          _undockVerb = new DesignerVerb("Undock from parent control", this.UndockVerbHandler)
          {
            Description = "Undock this control from its parent.",
            Enabled = this.ImageBoxControl.Dock != DockStyle.None
          };
          _verbs.Add(_undockVerb);
        }

        return _verbs;
      }
    }

    #endregion Public Properties

    #region Protected Properties

    /// <summary>
    /// Gets the TabList control currently being designed
    /// </summary>
    /// <value>The TabList control being designed.</value>
    protected ImageBox ImageBoxControl => this.Component as ImageBox;

    #endregion Protected Properties

    #region Public Methods

    /// <summary>
    /// Initializes the designer with the specified component.
    /// </summary>
    /// <param name="component">The <see cref="T:System.ComponentModel.IComponent" /> to associate with the designer.</param>
    public override void Initialize(IComponent component)
    {
      IComponentChangeService changeService;

      base.Initialize(component);

      // attach an event to notify us of when a component has been modified
      changeService = (IComponentChangeService)this.GetService(typeof(IComponentChangeService));
      if (changeService != null)
      {
        changeService.ComponentChanged += this.OnComponentChanged;
      }
    }

    #endregion Public Methods

    #region Protected Methods

    /// <summary>
    /// Releases the unmanaged resources used by the <see cref="T:System.Windows.Forms.Design.ParentControlDesigner" />, and optionally releases the managed resources.
    /// </summary>
    /// <param name="disposing">true to release both managed and unmanaged resources; false to release only unmanaged resources.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing)
      {
        IComponentChangeService changeService;

        changeService = (IComponentChangeService)this.GetService(typeof(IComponentChangeService));
        if (changeService != null)
        {
          changeService.ComponentChanged -= this.OnComponentChanged;
        }
      }

      base.Dispose(disposing);
    }

    #endregion Protected Methods

    #region Private Methods

    /// <summary>
    /// Called when the Dock verb is activated
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
    private void DockVerbHandler(object sender, EventArgs e)
    {
      this.SetDock(DockStyle.Fill);
    }

    /// <summary>
    /// Called when the component attached to this designer has changed
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The <see cref="ComponentChangedEventArgs" /> instance containing the event data.</param>
    private void OnComponentChanged(object sender, ComponentChangedEventArgs e)
    {
      if (_dockVerb != null)
      {
        _dockVerb.Enabled = this.ImageBoxControl.Dock == DockStyle.None;
      }
      if (_undockVerb != null)
      {
        _undockVerb.Enabled = this.ImageBoxControl.Dock != DockStyle.None;
      }
    }

    /// <summary>
    /// Applies a new dock setting to the hosted control
    /// </summary>
    private void SetDock(DockStyle dock)
    {
      ImageBox control;
      IDesignerHost host;

      control = this.ImageBoxControl;
      host = (IDesignerHost)this.GetService(typeof(IDesignerHost));

      if (control != null && host != null)
      {
        using (DesignerTransaction transaction = host.CreateTransaction(string.Format("Add TabListPage to '{0}'", control.Name)))
        {
          try
          {
            MemberDescriptor dockProperty;

            dockProperty = TypeDescriptor.GetProperties(control)["Dock"];

            // tell the designer we're about to start making changes
            this.RaiseComponentChanging(dockProperty);

            // dock it!
            control.Dock = dock;

            // inform the designer we're finished making changes
            this.RaiseComponentChanged(dockProperty, null, null);

            // commit the transaction
            transaction.Commit();
          }
          catch
          {
            transaction.Cancel();
            throw;
          }
        }
      }
    }

    /// <summary>
    /// Occurs when the Undock verb is activated
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void UndockVerbHandler(object sender, EventArgs e)
    {
      this.SetDock(DockStyle.None);
    }

    #endregion Private Methods
  }
}
