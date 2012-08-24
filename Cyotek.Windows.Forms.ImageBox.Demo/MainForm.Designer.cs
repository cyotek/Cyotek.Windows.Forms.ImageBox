namespace ImageBoxSample
{
  partial class MainForm
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
      if (disposing)
      {
        if (_previewImage != null)
          _previewImage.Dispose();

        if (components != null)
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      this.viewSplitContainer = new System.Windows.Forms.SplitContainer();
      this.selectionSplitContainer = new System.Windows.Forms.SplitContainer();
      this.imageBox = new Cyotek.Windows.Forms.ImageBox();
      this.previewImageBox = new Cyotek.Windows.Forms.ImageBox();
      this.propertyGrid = new Cyotek.Windows.Forms.PropertyGrid();
      this.statusStrip = new System.Windows.Forms.StatusStrip();
      this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
      this.autoScrollPositionToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
      this.imageSizeToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
      this.zoomToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
      this.cursorToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
      this.selectionToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
      this.toolStrip1 = new System.Windows.Forms.ToolStrip();
      this.showImageRegionToolStripButton = new System.Windows.Forms.ToolStripButton();
      this.showSourceImageRegionToolStripButton = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.actualSizeToolStripButton = new System.Windows.Forms.ToolStripButton();
      this.zoomInToolStripButton = new System.Windows.Forms.ToolStripButton();
      this.zoomOutToolStripButton = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.selectAllToolStripButton = new System.Windows.Forms.ToolStripButton();
      this.selectNoneToolStripButton = new System.Windows.Forms.ToolStripButton();
      this.viewSplitContainer.Panel1.SuspendLayout();
      this.viewSplitContainer.Panel2.SuspendLayout();
      this.viewSplitContainer.SuspendLayout();
      this.selectionSplitContainer.Panel1.SuspendLayout();
      this.selectionSplitContainer.Panel2.SuspendLayout();
      this.selectionSplitContainer.SuspendLayout();
      this.statusStrip.SuspendLayout();
      this.toolStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // viewSplitContainer
      // 
      this.viewSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
      this.viewSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
      this.viewSplitContainer.Location = new System.Drawing.Point(0, 25);
      this.viewSplitContainer.Name = "viewSplitContainer";
      // 
      // viewSplitContainer.Panel1
      // 
      this.viewSplitContainer.Panel1.Controls.Add(this.selectionSplitContainer);
      // 
      // viewSplitContainer.Panel2
      // 
      this.viewSplitContainer.Panel2.Controls.Add(this.propertyGrid);
      this.viewSplitContainer.Size = new System.Drawing.Size(915, 467);
      this.viewSplitContainer.SplitterDistance = 615;
      this.viewSplitContainer.TabIndex = 0;
      // 
      // selectionSplitContainer
      // 
      this.selectionSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
      this.selectionSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
      this.selectionSplitContainer.Location = new System.Drawing.Point(0, 0);
      this.selectionSplitContainer.Name = "selectionSplitContainer";
      this.selectionSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
      // 
      // selectionSplitContainer.Panel1
      // 
      this.selectionSplitContainer.Panel1.Controls.Add(this.imageBox);
      // 
      // selectionSplitContainer.Panel2
      // 
      this.selectionSplitContainer.Panel2.Controls.Add(this.previewImageBox);
      this.selectionSplitContainer.Size = new System.Drawing.Size(615, 467);
      this.selectionSplitContainer.SplitterDistance = 317;
      this.selectionSplitContainer.TabIndex = 1;
      // 
      // imageBox
      // 
      this.imageBox.AutoSize = false;
      this.imageBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this.imageBox.Image = global::Cyotek.Windows.Forms.Demo.Properties.Resources.Sample;
      this.imageBox.Location = new System.Drawing.Point(0, 0);
      this.imageBox.Name = "imageBox";
      this.imageBox.Size = new System.Drawing.Size(615, 317);
      this.imageBox.TabIndex = 0;
      this.imageBox.Selected += new System.EventHandler<System.EventArgs>(this.imageBox_Selected);
      this.imageBox.SelectionRegionChanged += new System.EventHandler(this.imageBox_SelectionRegionChanged);
      this.imageBox.ZoomChanged += new System.EventHandler(this.imageBox_ZoomChanged);
      this.imageBox.Scroll += new System.Windows.Forms.ScrollEventHandler(this.imageBox_Scroll);
      this.imageBox.Paint += new System.Windows.Forms.PaintEventHandler(this.imageBox_Paint);
      this.imageBox.MouseLeave += new System.EventHandler(this.imageBox_MouseLeave);
      this.imageBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.imageBox_MouseMove);
      this.imageBox.Resize += new System.EventHandler(this.imageBox_Resize);
      // 
      // previewImageBox
      // 
      this.previewImageBox.AllowZoom = false;
      this.previewImageBox.AutoPan = false;
      this.previewImageBox.AutoSize = false;
      this.previewImageBox.BackColor = System.Drawing.SystemColors.Control;
      this.previewImageBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this.previewImageBox.GridDisplayMode = Cyotek.Windows.Forms.ImageBoxGridDisplayMode.Image;
      this.previewImageBox.ImageBorderStyle = Cyotek.Windows.Forms.ImageBoxBorderStyle.FixedSingle;
      this.previewImageBox.Location = new System.Drawing.Point(0, 0);
      this.previewImageBox.Name = "previewImageBox";
      this.previewImageBox.Size = new System.Drawing.Size(615, 146);
      this.previewImageBox.TabIndex = 0;
      // 
      // propertyGrid
      // 
      this.propertyGrid.CommandsVisibleIfAvailable = false;
      this.propertyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
      this.propertyGrid.HelpVisible = false;
      this.propertyGrid.Location = new System.Drawing.Point(0, 0);
      this.propertyGrid.Name = "propertyGrid";
      this.propertyGrid.SelectedObject = this.imageBox;
      this.propertyGrid.Size = new System.Drawing.Size(296, 467);
      this.propertyGrid.TabIndex = 0;
      // 
      // statusStrip
      // 
      this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.autoScrollPositionToolStripStatusLabel,
            this.imageSizeToolStripStatusLabel,
            this.zoomToolStripStatusLabel,
            this.cursorToolStripStatusLabel,
            this.selectionToolStripStatusLabel});
      this.statusStrip.Location = new System.Drawing.Point(0, 492);
      this.statusStrip.Name = "statusStrip";
      this.statusStrip.ShowItemToolTips = true;
      this.statusStrip.Size = new System.Drawing.Size(915, 22);
      this.statusStrip.TabIndex = 1;
      // 
      // toolStripStatusLabel1
      // 
      this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
      this.toolStripStatusLabel1.Size = new System.Drawing.Size(820, 17);
      this.toolStripStatusLabel1.Spring = true;
      // 
      // autoScrollPositionToolStripStatusLabel
      // 
      this.autoScrollPositionToolStripStatusLabel.Image = global::Cyotek.Windows.Forms.Demo.Properties.Resources.Object_Position;
      this.autoScrollPositionToolStripStatusLabel.Name = "autoScrollPositionToolStripStatusLabel";
      this.autoScrollPositionToolStripStatusLabel.Size = new System.Drawing.Size(16, 17);
      this.autoScrollPositionToolStripStatusLabel.ToolTipText = "Auto Scroll Position";
      // 
      // imageSizeToolStripStatusLabel
      // 
      this.imageSizeToolStripStatusLabel.Image = global::Cyotek.Windows.Forms.Demo.Properties.Resources.Object_Size;
      this.imageSizeToolStripStatusLabel.Name = "imageSizeToolStripStatusLabel";
      this.imageSizeToolStripStatusLabel.Size = new System.Drawing.Size(16, 17);
      this.imageSizeToolStripStatusLabel.ToolTipText = "Image Size";
      // 
      // zoomToolStripStatusLabel
      // 
      this.zoomToolStripStatusLabel.Image = global::Cyotek.Windows.Forms.Demo.Properties.Resources.magnifier_zoom;
      this.zoomToolStripStatusLabel.Name = "zoomToolStripStatusLabel";
      this.zoomToolStripStatusLabel.Size = new System.Drawing.Size(16, 17);
      this.zoomToolStripStatusLabel.ToolTipText = "Zoom";
      // 
      // cursorToolStripStatusLabel
      // 
      this.cursorToolStripStatusLabel.Image = global::Cyotek.Windows.Forms.Demo.Properties.Resources.cursor;
      this.cursorToolStripStatusLabel.Name = "cursorToolStripStatusLabel";
      this.cursorToolStripStatusLabel.Size = new System.Drawing.Size(16, 17);
      this.cursorToolStripStatusLabel.ToolTipText = "Current Cursor Position";
      // 
      // selectionToolStripStatusLabel
      // 
      this.selectionToolStripStatusLabel.Image = global::Cyotek.Windows.Forms.Demo.Properties.Resources.selection_select;
      this.selectionToolStripStatusLabel.Name = "selectionToolStripStatusLabel";
      this.selectionToolStripStatusLabel.Size = new System.Drawing.Size(16, 17);
      // 
      // toolStrip1
      // 
      this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showImageRegionToolStripButton,
            this.showSourceImageRegionToolStripButton,
            this.toolStripSeparator1,
            this.actualSizeToolStripButton,
            this.zoomInToolStripButton,
            this.zoomOutToolStripButton,
            this.toolStripSeparator2,
            this.selectAllToolStripButton,
            this.selectNoneToolStripButton});
      this.toolStrip1.Location = new System.Drawing.Point(0, 0);
      this.toolStrip1.Name = "toolStrip1";
      this.toolStrip1.Size = new System.Drawing.Size(915, 25);
      this.toolStrip1.TabIndex = 2;
      this.toolStrip1.Text = "toolStrip1";
      // 
      // showImageRegionToolStripButton
      // 
      this.showImageRegionToolStripButton.CheckOnClick = true;
      this.showImageRegionToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.showImageRegionToolStripButton.Image = global::Cyotek.Windows.Forms.Demo.Properties.Resources.zone;
      this.showImageRegionToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.showImageRegionToolStripButton.Name = "showImageRegionToolStripButton";
      this.showImageRegionToolStripButton.Size = new System.Drawing.Size(23, 22);
      this.showImageRegionToolStripButton.Text = "Show Image Region";
      this.showImageRegionToolStripButton.Click += new System.EventHandler(this.showImageRegionToolStripButton_Click);
      // 
      // showSourceImageRegionToolStripButton
      // 
      this.showSourceImageRegionToolStripButton.CheckOnClick = true;
      this.showSourceImageRegionToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.showSourceImageRegionToolStripButton.Image = global::Cyotek.Windows.Forms.Demo.Properties.Resources.zone;
      this.showSourceImageRegionToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.showSourceImageRegionToolStripButton.Name = "showSourceImageRegionToolStripButton";
      this.showSourceImageRegionToolStripButton.Size = new System.Drawing.Size(23, 22);
      this.showSourceImageRegionToolStripButton.Text = "Show Source Image Region";
      this.showSourceImageRegionToolStripButton.Click += new System.EventHandler(this.showImageRegionToolStripButton_Click);
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
      // 
      // actualSizeToolStripButton
      // 
      this.actualSizeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.actualSizeToolStripButton.Image = global::Cyotek.Windows.Forms.Demo.Properties.Resources.image_resize_actual;
      this.actualSizeToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.actualSizeToolStripButton.Name = "actualSizeToolStripButton";
      this.actualSizeToolStripButton.Size = new System.Drawing.Size(23, 22);
      this.actualSizeToolStripButton.Text = "Actual Size";
      this.actualSizeToolStripButton.Click += new System.EventHandler(this.actualSizeToolStripButton_Click);
      // 
      // zoomInToolStripButton
      // 
      this.zoomInToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.zoomInToolStripButton.Image = global::Cyotek.Windows.Forms.Demo.Properties.Resources.magnifier_zoom_in;
      this.zoomInToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.zoomInToolStripButton.Name = "zoomInToolStripButton";
      this.zoomInToolStripButton.Size = new System.Drawing.Size(23, 22);
      this.zoomInToolStripButton.Text = "Zoom In";
      this.zoomInToolStripButton.Click += new System.EventHandler(this.zoomInToolStripButton_Click);
      // 
      // zoomOutToolStripButton
      // 
      this.zoomOutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.zoomOutToolStripButton.Image = global::Cyotek.Windows.Forms.Demo.Properties.Resources.magnifier_zoom_out;
      this.zoomOutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.zoomOutToolStripButton.Name = "zoomOutToolStripButton";
      this.zoomOutToolStripButton.Size = new System.Drawing.Size(23, 22);
      this.zoomOutToolStripButton.Text = "Zoom Out";
      this.zoomOutToolStripButton.Click += new System.EventHandler(this.zoomOutToolStripButton_Click);
      // 
      // toolStripSeparator2
      // 
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
      // 
      // selectAllToolStripButton
      // 
      this.selectAllToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.selectAllToolStripButton.Image = global::Cyotek.Windows.Forms.Demo.Properties.Resources.selection_select;
      this.selectAllToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.selectAllToolStripButton.Name = "selectAllToolStripButton";
      this.selectAllToolStripButton.Size = new System.Drawing.Size(23, 22);
      this.selectAllToolStripButton.Text = "Select All";
      this.selectAllToolStripButton.Click += new System.EventHandler(this.selectAllToolStripButton_Click);
      // 
      // selectNoneToolStripButton
      // 
      this.selectNoneToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.selectNoneToolStripButton.Image = global::Cyotek.Windows.Forms.Demo.Properties.Resources.selection;
      this.selectNoneToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.selectNoneToolStripButton.Name = "selectNoneToolStripButton";
      this.selectNoneToolStripButton.Size = new System.Drawing.Size(23, 22);
      this.selectNoneToolStripButton.Text = "Select None";
      this.selectNoneToolStripButton.Click += new System.EventHandler(this.selectNoneToolStripButton_Click);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(915, 514);
      this.Controls.Add(this.viewSplitContainer);
      this.Controls.Add(this.statusStrip);
      this.Controls.Add(this.toolStrip1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "MainForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Cyotek ImageBox Demonstration";
      this.Load += new System.EventHandler(this.MainForm_Load);
      this.viewSplitContainer.Panel1.ResumeLayout(false);
      this.viewSplitContainer.Panel2.ResumeLayout(false);
      this.viewSplitContainer.ResumeLayout(false);
      this.selectionSplitContainer.Panel1.ResumeLayout(false);
      this.selectionSplitContainer.Panel2.ResumeLayout(false);
      this.selectionSplitContainer.ResumeLayout(false);
      this.statusStrip.ResumeLayout(false);
      this.statusStrip.PerformLayout();
      this.toolStrip1.ResumeLayout(false);
      this.toolStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.SplitContainer viewSplitContainer;
    private Cyotek.Windows.Forms.ImageBox imageBox;
    private Cyotek.Windows.Forms.PropertyGrid propertyGrid;
    private System.Windows.Forms.StatusStrip statusStrip;
    private System.Windows.Forms.ToolStripStatusLabel autoScrollPositionToolStripStatusLabel;
    private System.Windows.Forms.ToolStrip toolStrip1;
    private System.Windows.Forms.ToolStripButton showImageRegionToolStripButton;
    private System.Windows.Forms.ToolStripButton showSourceImageRegionToolStripButton;
    private System.Windows.Forms.ToolStripStatusLabel imageSizeToolStripStatusLabel;
    private System.Windows.Forms.ToolStripStatusLabel zoomToolStripStatusLabel;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripButton actualSizeToolStripButton;
    private System.Windows.Forms.ToolStripButton zoomInToolStripButton;
    private System.Windows.Forms.ToolStripButton zoomOutToolStripButton;
    private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    private System.Windows.Forms.ToolStripStatusLabel cursorToolStripStatusLabel;
    private System.Windows.Forms.SplitContainer selectionSplitContainer;
    private Cyotek.Windows.Forms.ImageBox previewImageBox;
    private System.Windows.Forms.ToolStripStatusLabel selectionToolStripStatusLabel;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    private System.Windows.Forms.ToolStripButton selectAllToolStripButton;
    private System.Windows.Forms.ToolStripButton selectNoneToolStripButton;
  }
}

