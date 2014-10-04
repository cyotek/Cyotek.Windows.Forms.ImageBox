namespace Cyotek.Windows.Forms.Demo
{
  partial class ImageBoxDemoForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageBoxDemoForm));
      this.viewSplitContainer = new System.Windows.Forms.SplitContainer();
      this.selectionSplitContainer = new System.Windows.Forms.SplitContainer();
      this.imageBox = new Cyotek.Windows.Forms.ImageBox();
      this.previewImageBox = new Cyotek.Windows.Forms.ImageBox();
      this.propertyGrid = new PropertyGrid();
      this.statusStrip = new System.Windows.Forms.StatusStrip();
      this.cursorToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
      this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
      this.autoScrollPositionToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
      this.imageSizeToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
      this.zoomToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
      this.selectionToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
      this.toolStrip = new System.Windows.Forms.ToolStrip();
      this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
      this.showImageRegionToolStripButton = new System.Windows.Forms.ToolStripButton();
      this.showSourceImageRegionToolStripButton = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.actualSizeToolStripButton = new System.Windows.Forms.ToolStripButton();
      this.zoomInToolStripButton = new System.Windows.Forms.ToolStripButton();
      this.zoomOutToolStripButton = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.selectAllToolStripButton = new System.Windows.Forms.ToolStripButton();
      this.selectNoneToolStripButton = new System.Windows.Forms.ToolStripButton();
      this.zoomLevelsToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
      this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
      this.menuStrip = new System.Windows.Forms.MenuStrip();
      this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
      this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
      this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.selectNoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.viewSplitContainer.Panel1.SuspendLayout();
      this.viewSplitContainer.Panel2.SuspendLayout();
      this.viewSplitContainer.SuspendLayout();
      this.selectionSplitContainer.Panel1.SuspendLayout();
      this.selectionSplitContainer.Panel2.SuspendLayout();
      this.selectionSplitContainer.SuspendLayout();
      this.statusStrip.SuspendLayout();
      this.toolStrip.SuspendLayout();
      this.menuStrip.SuspendLayout();
      this.SuspendLayout();
      // 
      // viewSplitContainer
      // 
      this.viewSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
      this.viewSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
      this.viewSplitContainer.Location = new System.Drawing.Point(0, 49);
      this.viewSplitContainer.Name = "viewSplitContainer";
      // 
      // viewSplitContainer.Panel1
      // 
      this.viewSplitContainer.Panel1.Controls.Add(this.selectionSplitContainer);
      // 
      // viewSplitContainer.Panel2
      // 
      this.viewSplitContainer.Panel2.Controls.Add(this.propertyGrid);
      this.viewSplitContainer.Size = new System.Drawing.Size(1060, 536);
      this.viewSplitContainer.SplitterDistance = 752;
      this.viewSplitContainer.SplitterWidth = 5;
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
      this.selectionSplitContainer.Size = new System.Drawing.Size(752, 536);
      this.selectionSplitContainer.SplitterDistance = 378;
      this.selectionSplitContainer.SplitterWidth = 5;
      this.selectionSplitContainer.TabIndex = 1;
      // 
      // imageBox
      // 
      this.imageBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this.imageBox.Location = new System.Drawing.Point(0, 0);
      this.imageBox.Name = "imageBox";
      this.imageBox.Size = new System.Drawing.Size(752, 378);
      this.imageBox.TabIndex = 0;
      this.imageBox.Selected += new System.EventHandler<System.EventArgs>(this.imageBox_Selected);
      this.imageBox.SelectionRegionChanged += new System.EventHandler(this.imageBox_SelectionRegionChanged);
      this.imageBox.ZoomChanged += new System.EventHandler(this.imageBox_ZoomChanged);
      this.imageBox.ZoomLevelsChanged += new System.EventHandler(this.imageBox_ZoomLevelsChanged);
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
      this.previewImageBox.BackColor = System.Drawing.SystemColors.Control;
      this.previewImageBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this.previewImageBox.GridDisplayMode = Cyotek.Windows.Forms.ImageBoxGridDisplayMode.Image;
      this.previewImageBox.ImageBorderStyle = Cyotek.Windows.Forms.ImageBoxBorderStyle.FixedSingle;
      this.previewImageBox.Location = new System.Drawing.Point(0, 0);
      this.previewImageBox.Name = "previewImageBox";
      this.previewImageBox.Size = new System.Drawing.Size(752, 153);
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
      this.propertyGrid.Size = new System.Drawing.Size(303, 536);
      this.propertyGrid.TabIndex = 0;
      // 
      // statusStrip
      // 
      this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cursorToolStripStatusLabel,
            this.toolStripStatusLabel1,
            this.autoScrollPositionToolStripStatusLabel,
            this.imageSizeToolStripStatusLabel,
            this.zoomToolStripStatusLabel,
            this.selectionToolStripStatusLabel});
      this.statusStrip.Location = new System.Drawing.Point(0, 585);
      this.statusStrip.Name = "statusStrip";
      this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
      this.statusStrip.ShowItemToolTips = true;
      this.statusStrip.Size = new System.Drawing.Size(1060, 22);
      this.statusStrip.TabIndex = 1;
      // 
      // cursorToolStripStatusLabel
      // 
      this.cursorToolStripStatusLabel.Image = global::Cyotek.Windows.Forms.Demo.Properties.Resources.Cursor;
      this.cursorToolStripStatusLabel.Name = "cursorToolStripStatusLabel";
      this.cursorToolStripStatusLabel.Size = new System.Drawing.Size(16, 17);
      this.cursorToolStripStatusLabel.ToolTipText = "Current Cursor Position";
      // 
      // toolStripStatusLabel1
      // 
      this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
      this.toolStripStatusLabel1.Size = new System.Drawing.Size(963, 17);
      this.toolStripStatusLabel1.Spring = true;
      // 
      // autoScrollPositionToolStripStatusLabel
      // 
      this.autoScrollPositionToolStripStatusLabel.Image = global::Cyotek.Windows.Forms.Demo.Properties.Resources.Position;
      this.autoScrollPositionToolStripStatusLabel.Name = "autoScrollPositionToolStripStatusLabel";
      this.autoScrollPositionToolStripStatusLabel.Size = new System.Drawing.Size(16, 17);
      this.autoScrollPositionToolStripStatusLabel.ToolTipText = "Auto Scroll Position";
      // 
      // imageSizeToolStripStatusLabel
      // 
      this.imageSizeToolStripStatusLabel.Image = global::Cyotek.Windows.Forms.Demo.Properties.Resources.Size;
      this.imageSizeToolStripStatusLabel.Name = "imageSizeToolStripStatusLabel";
      this.imageSizeToolStripStatusLabel.Size = new System.Drawing.Size(16, 17);
      this.imageSizeToolStripStatusLabel.ToolTipText = "Image Size";
      // 
      // zoomToolStripStatusLabel
      // 
      this.zoomToolStripStatusLabel.Image = global::Cyotek.Windows.Forms.Demo.Properties.Resources.Zoom;
      this.zoomToolStripStatusLabel.Name = "zoomToolStripStatusLabel";
      this.zoomToolStripStatusLabel.Size = new System.Drawing.Size(16, 17);
      this.zoomToolStripStatusLabel.ToolTipText = "Zoom";
      // 
      // selectionToolStripStatusLabel
      // 
      this.selectionToolStripStatusLabel.Image = global::Cyotek.Windows.Forms.Demo.Properties.Resources.SelectAll;
      this.selectionToolStripStatusLabel.Name = "selectionToolStripStatusLabel";
      this.selectionToolStripStatusLabel.Size = new System.Drawing.Size(16, 17);
      // 
      // toolStrip
      // 
      this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripButton,
            this.toolStripSeparator8,
            this.showImageRegionToolStripButton,
            this.showSourceImageRegionToolStripButton,
            this.toolStripSeparator1,
            this.actualSizeToolStripButton,
            this.zoomInToolStripButton,
            this.zoomOutToolStripButton,
            this.toolStripSeparator2,
            this.selectAllToolStripButton,
            this.selectNoneToolStripButton,
            this.zoomLevelsToolStripComboBox,
            this.toolStripSeparator4});
      this.toolStrip.Location = new System.Drawing.Point(0, 24);
      this.toolStrip.Name = "toolStrip";
      this.toolStrip.Size = new System.Drawing.Size(1060, 25);
      this.toolStrip.TabIndex = 2;
      // 
      // openToolStripButton
      // 
      this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
      this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.openToolStripButton.Name = "openToolStripButton";
      this.openToolStripButton.Size = new System.Drawing.Size(23, 22);
      this.openToolStripButton.Text = "&Open";
      this.openToolStripButton.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
      // 
      // toolStripSeparator8
      // 
      this.toolStripSeparator8.Name = "toolStripSeparator8";
      this.toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
      // 
      // showImageRegionToolStripButton
      // 
      this.showImageRegionToolStripButton.CheckOnClick = true;
      this.showImageRegionToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.showImageRegionToolStripButton.Image = global::Cyotek.Windows.Forms.Demo.Properties.Resources.Zone;
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
      this.showSourceImageRegionToolStripButton.Image = global::Cyotek.Windows.Forms.Demo.Properties.Resources.Zone;
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
      this.actualSizeToolStripButton.Image = global::Cyotek.Windows.Forms.Demo.Properties.Resources.ActualSize;
      this.actualSizeToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.actualSizeToolStripButton.Name = "actualSizeToolStripButton";
      this.actualSizeToolStripButton.Size = new System.Drawing.Size(23, 22);
      this.actualSizeToolStripButton.Text = "Actual Size";
      this.actualSizeToolStripButton.Click += new System.EventHandler(this.actualSizeToolStripButton_Click);
      // 
      // zoomInToolStripButton
      // 
      this.zoomInToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.zoomInToolStripButton.Image = global::Cyotek.Windows.Forms.Demo.Properties.Resources.ZoomIn;
      this.zoomInToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.zoomInToolStripButton.Name = "zoomInToolStripButton";
      this.zoomInToolStripButton.Size = new System.Drawing.Size(23, 22);
      this.zoomInToolStripButton.Text = "Zoom In";
      this.zoomInToolStripButton.Click += new System.EventHandler(this.zoomInToolStripButton_Click);
      // 
      // zoomOutToolStripButton
      // 
      this.zoomOutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.zoomOutToolStripButton.Image = global::Cyotek.Windows.Forms.Demo.Properties.Resources.ZoomOut;
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
      this.selectAllToolStripButton.Image = global::Cyotek.Windows.Forms.Demo.Properties.Resources.SelectAll;
      this.selectAllToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.selectAllToolStripButton.Name = "selectAllToolStripButton";
      this.selectAllToolStripButton.Size = new System.Drawing.Size(23, 22);
      this.selectAllToolStripButton.Text = "Select All";
      this.selectAllToolStripButton.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
      // 
      // selectNoneToolStripButton
      // 
      this.selectNoneToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.selectNoneToolStripButton.Image = global::Cyotek.Windows.Forms.Demo.Properties.Resources.SelectNone;
      this.selectNoneToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.selectNoneToolStripButton.Name = "selectNoneToolStripButton";
      this.selectNoneToolStripButton.Size = new System.Drawing.Size(23, 22);
      this.selectNoneToolStripButton.Text = "Select None";
      this.selectNoneToolStripButton.Click += new System.EventHandler(this.selectNoneToolStripMenuItem_Click);
      // 
      // zoomLevelsToolStripComboBox
      // 
      this.zoomLevelsToolStripComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.zoomLevelsToolStripComboBox.Name = "zoomLevelsToolStripComboBox";
      this.zoomLevelsToolStripComboBox.Size = new System.Drawing.Size(140, 25);
      this.zoomLevelsToolStripComboBox.SelectedIndexChanged += new System.EventHandler(this.zoomLevelsToolStripComboBox_SelectedIndexChanged);
      // 
      // toolStripSeparator4
      // 
      this.toolStripSeparator4.Name = "toolStripSeparator4";
      this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
      // 
      // menuStrip
      // 
      this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
      this.menuStrip.Location = new System.Drawing.Point(0, 0);
      this.menuStrip.Name = "menuStrip";
      this.menuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
      this.menuStrip.Size = new System.Drawing.Size(1060, 24);
      this.menuStrip.TabIndex = 3;
      // 
      // fileToolStripMenuItem
      // 
      this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripSeparator3,
            this.exitToolStripMenuItem});
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
      this.fileToolStripMenuItem.Text = "&File";
      // 
      // openToolStripMenuItem
      // 
      this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
      this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.openToolStripMenuItem.Name = "openToolStripMenuItem";
      this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
      this.openToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
      this.openToolStripMenuItem.Text = "&Open";
      this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
      // 
      // toolStripSeparator3
      // 
      this.toolStripSeparator3.Name = "toolStripSeparator3";
      this.toolStripSeparator3.Size = new System.Drawing.Size(145, 6);
      // 
      // exitToolStripMenuItem
      // 
      this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
      this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
      this.exitToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
      this.exitToolStripMenuItem.Text = "&Close";
      this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
      // 
      // editToolStripMenuItem
      // 
      this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.toolStripSeparator6,
            this.selectAllToolStripMenuItem,
            this.selectNoneToolStripMenuItem});
      this.editToolStripMenuItem.Name = "editToolStripMenuItem";
      this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
      this.editToolStripMenuItem.Text = "&Edit";
      // 
      // copyToolStripMenuItem
      // 
      this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
      this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
      this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
      this.copyToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
      this.copyToolStripMenuItem.Text = "&Copy";
      this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
      // 
      // toolStripSeparator6
      // 
      this.toolStripSeparator6.Name = "toolStripSeparator6";
      this.toolStripSeparator6.Size = new System.Drawing.Size(176, 6);
      // 
      // selectAllToolStripMenuItem
      // 
      this.selectAllToolStripMenuItem.Image = global::Cyotek.Windows.Forms.Demo.Properties.Resources.SelectAll;
      this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
      this.selectAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
      this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
      this.selectAllToolStripMenuItem.Text = "Select &All";
      this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
      // 
      // selectNoneToolStripMenuItem
      // 
      this.selectNoneToolStripMenuItem.Image = global::Cyotek.Windows.Forms.Demo.Properties.Resources.SelectNone;
      this.selectNoneToolStripMenuItem.Name = "selectNoneToolStripMenuItem";
      this.selectNoneToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
      this.selectNoneToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
      this.selectNoneToolStripMenuItem.Text = "Select &None";
      this.selectNoneToolStripMenuItem.Click += new System.EventHandler(this.selectNoneToolStripMenuItem_Click);
      // 
      // helpToolStripMenuItem
      // 
      this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
      this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
      this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
      this.helpToolStripMenuItem.Text = "&Help";
      // 
      // aboutToolStripMenuItem
      // 
      this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
      this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
      this.aboutToolStripMenuItem.Text = "&About...";
      this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
      // 
      // ImageBoxDemoForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1060, 607);
      this.Controls.Add(this.viewSplitContainer);
      this.Controls.Add(this.statusStrip);
      this.Controls.Add(this.toolStrip);
      this.Controls.Add(this.menuStrip);
      this.Font = new System.Drawing.Font("Segoe UI", 9F);
      this.MainMenuStrip = this.menuStrip;
      this.Name = "ImageBoxDemoForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "General Demonstration";
      this.viewSplitContainer.Panel1.ResumeLayout(false);
      this.viewSplitContainer.Panel2.ResumeLayout(false);
      this.viewSplitContainer.ResumeLayout(false);
      this.selectionSplitContainer.Panel1.ResumeLayout(false);
      this.selectionSplitContainer.Panel2.ResumeLayout(false);
      this.selectionSplitContainer.ResumeLayout(false);
      this.statusStrip.ResumeLayout(false);
      this.statusStrip.PerformLayout();
      this.toolStrip.ResumeLayout(false);
      this.toolStrip.PerformLayout();
      this.menuStrip.ResumeLayout(false);
      this.menuStrip.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.SplitContainer viewSplitContainer;
    private Cyotek.Windows.Forms.ImageBox imageBox;
    private PropertyGrid propertyGrid;
    private System.Windows.Forms.StatusStrip statusStrip;
    private System.Windows.Forms.ToolStripStatusLabel autoScrollPositionToolStripStatusLabel;
    private System.Windows.Forms.ToolStrip toolStrip;
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
    private System.Windows.Forms.ToolStripButton openToolStripButton;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
    private System.Windows.Forms.MenuStrip menuStrip;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
    private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    private System.Windows.Forms.ToolStripComboBox zoomLevelsToolStripComboBox;
    private System.Windows.Forms.ToolStripMenuItem selectNoneToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
  }
}

