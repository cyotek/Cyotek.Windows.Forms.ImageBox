namespace Cyotek.Windows.Forms.Demo
{
  partial class MiniMapDemoForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.zoomImageBox = new Cyotek.Windows.Forms.ImageBox();
            this.miniMapImageBox = new Cyotek.Windows.Forms.ImageBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.imageViewPortToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.calculatedRectangleToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // zoomImageBox
            // 
            this.zoomImageBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zoomImageBox.Location = new System.Drawing.Point(0, 0);
            this.zoomImageBox.Name = "zoomImageBox";
            this.zoomImageBox.Size = new System.Drawing.Size(680, 445);
            this.zoomImageBox.TabIndex = 0;
            this.zoomImageBox.TabStop = false;
            this.zoomImageBox.ImageChanged += new System.EventHandler(this.ZoomImageBox_ImageChanged);
            this.zoomImageBox.Zoomed += new System.EventHandler<Cyotek.Windows.Forms.ImageBoxZoomEventArgs>(this.ZoomImageBox_Zoomed);
            this.zoomImageBox.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ZoomImageBox_Scroll);
            this.zoomImageBox.Resize += new System.EventHandler(this.ZoomImageBox_Resize);
            // 
            // miniMapImageBox
            // 
            this.miniMapImageBox.AllowZoom = false;
            this.miniMapImageBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.miniMapImageBox.AutoPan = false;
            this.miniMapImageBox.Location = new System.Drawing.Point(3, 3);
            this.miniMapImageBox.Name = "miniMapImageBox";
            this.miniMapImageBox.Size = new System.Drawing.Size(267, 155);
            this.miniMapImageBox.SizeMode = Cyotek.Windows.Forms.ImageBoxSizeMode.Fit;
            this.miniMapImageBox.TabIndex = 0;
            this.miniMapImageBox.TabStop = false;
            this.miniMapImageBox.VirtualMode = true;
            this.miniMapImageBox.Paint += new System.Windows.Forms.PaintEventHandler(this.MiniMapImageBox_Paint);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imageViewPortToolStripStatusLabel,
            this.calculatedRectangleToolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(12, 457);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(956, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // imageViewPortToolStripStatusLabel
            // 
            this.imageViewPortToolStripStatusLabel.Name = "imageViewPortToolStripStatusLabel";
            this.imageViewPortToolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // calculatedRectangleToolStripStatusLabel
            // 
            this.calculatedRectangleToolStripStatusLabel.Name = "calculatedRectangleToolStripStatusLabel";
            this.calculatedRectangleToolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer.Location = new System.Drawing.Point(12, 12);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.zoomImageBox);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.miniMapImageBox);
            this.splitContainer.Size = new System.Drawing.Size(956, 445);
            this.splitContainer.SplitterDistance = 680;
            this.splitContainer.SplitterWidth = 3;
            this.splitContainer.TabIndex = 1;
            this.splitContainer.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.SplitContainer_SplitterMoved);
            // 
            // MiniMapDemoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 529);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.statusStrip1);
            this.Name = "MiniMapDemoForm";
            this.Text = "Minimap Overlay Demonstration";
            this.Controls.SetChildIndex(this.statusStrip1, 0);
            this.Controls.SetChildIndex(this.splitContainer, 0);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private Cyotek.Windows.Forms.ImageBox zoomImageBox;
    private Cyotek.Windows.Forms.ImageBox miniMapImageBox;
    private System.Windows.Forms.StatusStrip statusStrip1;
    private System.Windows.Forms.ToolStripStatusLabel imageViewPortToolStripStatusLabel;
    private System.Windows.Forms.ToolStripStatusLabel calculatedRectangleToolStripStatusLabel;
    private System.Windows.Forms.SplitContainer splitContainer;
  }
}

