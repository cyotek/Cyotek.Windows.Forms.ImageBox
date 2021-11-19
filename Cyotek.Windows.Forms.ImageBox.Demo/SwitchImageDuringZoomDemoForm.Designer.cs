namespace Cyotek.Windows.Forms.Demo
{
  partial class SwitchImageDuringZoomDemoForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.components = new System.ComponentModel.Container();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.cursorToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.zoomToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.mapNameToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.imageBox = new Cyotek.Windows.Forms.ImageBox();
            this.messageLabel = new System.Windows.Forms.Label();
            this.resetMessageTimer = new System.Windows.Forms.Timer(this.components);
            this.refreshMapTimer = new System.Windows.Forms.Timer(this.components);
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusToolStripStatusLabel,
            this.cursorToolStripStatusLabel,
            this.zoomToolStripStatusLabel,
            this.mapNameToolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(12, 446);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(723, 22);
            this.statusStrip.TabIndex = 11;
            // 
            // statusToolStripStatusLabel
            // 
            this.statusToolStripStatusLabel.Name = "statusToolStripStatusLabel";
            this.statusToolStripStatusLabel.Size = new System.Drawing.Size(625, 17);
            this.statusToolStripStatusLabel.Spring = true;
            this.statusToolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cursorToolStripStatusLabel
            // 
            this.cursorToolStripStatusLabel.Image = global::Cyotek.Windows.Forms.Demo.Properties.Resources.Cursor;
            this.cursorToolStripStatusLabel.Name = "cursorToolStripStatusLabel";
            this.cursorToolStripStatusLabel.Size = new System.Drawing.Size(16, 17);
            this.cursorToolStripStatusLabel.ToolTipText = "Current Cursor Position";
            // 
            // zoomToolStripStatusLabel
            // 
            this.zoomToolStripStatusLabel.Image = global::Cyotek.Windows.Forms.Demo.Properties.Resources.Zoom;
            this.zoomToolStripStatusLabel.Name = "zoomToolStripStatusLabel";
            this.zoomToolStripStatusLabel.Size = new System.Drawing.Size(51, 17);
            this.zoomToolStripStatusLabel.Text = "100%";
            this.zoomToolStripStatusLabel.ToolTipText = "Zoom";
            // 
            // mapNameToolStripStatusLabel
            // 
            this.mapNameToolStripStatusLabel.Image = global::Cyotek.Windows.Forms.Demo.Properties.Resources.SmallMap;
            this.mapNameToolStripStatusLabel.Name = "mapNameToolStripStatusLabel";
            this.mapNameToolStripStatusLabel.Size = new System.Drawing.Size(16, 17);
            this.mapNameToolStripStatusLabel.ToolTipText = "Zoom";
            // 
            // imageBox
            // 
            this.imageBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageBox.Location = new System.Drawing.Point(12, 12);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(723, 413);
            this.imageBox.TabIndex = 12;
            this.imageBox.ZoomChanged += new System.EventHandler(this.ImageBox_ZoomChanged);
            this.imageBox.Zoomed += new System.EventHandler<Cyotek.Windows.Forms.ImageBoxZoomEventArgs>(this.ImageBox_Zoomed);
            this.imageBox.MouseLeave += new System.EventHandler(this.ImageBox_MouseLeave);
            this.imageBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ImageBox_MouseMove);
            // 
            // messageLabel
            // 
            this.messageLabel.AutoEllipsis = true;
            this.messageLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.messageLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.messageLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.messageLabel.Location = new System.Drawing.Point(12, 425);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(723, 21);
            this.messageLabel.TabIndex = 13;
            this.messageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resetMessageTimer
            // 
            this.resetMessageTimer.Interval = 5000;
            this.resetMessageTimer.Tick += new System.EventHandler(this.ResetMessageTimer_Tick);
            // 
            // refreshMapTimer
            // 
            this.refreshMapTimer.Interval = 5;
            this.refreshMapTimer.Tick += new System.EventHandler(this.RefreshMapTimer_Tick);
            // 
            // SwitchImageDuringZoomDemoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 518);
            this.Controls.Add(this.imageBox);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.statusStrip);
            this.Name = "SwitchImageDuringZoomDemoForm";
            this.Text = "Switch Image During Zoom Demonstration";
            this.Controls.SetChildIndex(this.statusStrip, 0);
            this.Controls.SetChildIndex(this.messageLabel, 0);
            this.Controls.SetChildIndex(this.imageBox, 0);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.StatusStrip statusStrip;
    private ImageBox imageBox;
    private System.Windows.Forms.ToolStripStatusLabel zoomToolStripStatusLabel;
    private System.Windows.Forms.ToolStripStatusLabel mapNameToolStripStatusLabel;
    private System.Windows.Forms.ToolStripStatusLabel cursorToolStripStatusLabel;
    private System.Windows.Forms.ToolStripStatusLabel statusToolStripStatusLabel;
    private System.Windows.Forms.Label messageLabel;
    private System.Windows.Forms.Timer resetMessageTimer;
    private System.Windows.Forms.Timer refreshMapTimer;
  }
}