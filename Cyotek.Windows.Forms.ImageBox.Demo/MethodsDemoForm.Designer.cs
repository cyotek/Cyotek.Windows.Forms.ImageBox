namespace Cyotek.Windows.Forms.Demo
{
  partial class MethodsDemoForm
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
      this.menuStrip = new System.Windows.Forms.MenuStrip();
      this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.statusStrip = new System.Windows.Forms.StatusStrip();
      this.splitContainer = new System.Windows.Forms.SplitContainer();
      this.imageBox = new Cyotek.Windows.Forms.ImageBox();
      this.selectNoneButton = new System.Windows.Forms.Button();
      this.selectAllButton = new System.Windows.Forms.Button();
      this.centerToImageButton = new System.Windows.Forms.Button();
      this.actualSizeButton = new System.Windows.Forms.Button();
      this.zoomOutButton = new System.Windows.Forms.Button();
      this.zoomInButton = new System.Windows.Forms.Button();
      this.zoomToFitButton = new System.Windows.Forms.Button();
      this.menuStrip.SuspendLayout();
      this.splitContainer.Panel1.SuspendLayout();
      this.splitContainer.Panel2.SuspendLayout();
      this.splitContainer.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip
      // 
      this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
      this.menuStrip.Location = new System.Drawing.Point(0, 0);
      this.menuStrip.Name = "menuStrip";
      this.menuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
      this.menuStrip.Size = new System.Drawing.Size(847, 24);
      this.menuStrip.TabIndex = 10;
      // 
      // fileToolStripMenuItem
      // 
      this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
      this.fileToolStripMenuItem.Text = "&File";
      // 
      // closeToolStripMenuItem
      // 
      this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
      this.closeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
      this.closeToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
      this.closeToolStripMenuItem.Text = "&Close";
      this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
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
      // statusStrip
      // 
      this.statusStrip.Location = new System.Drawing.Point(0, 351);
      this.statusStrip.Name = "statusStrip";
      this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
      this.statusStrip.Size = new System.Drawing.Size(847, 22);
      this.statusStrip.TabIndex = 11;
      // 
      // splitContainer
      // 
      this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
      this.splitContainer.Location = new System.Drawing.Point(0, 24);
      this.splitContainer.Name = "splitContainer";
      // 
      // splitContainer.Panel1
      // 
      this.splitContainer.Panel1.Controls.Add(this.imageBox);
      // 
      // splitContainer.Panel2
      // 
      this.splitContainer.Panel2.Controls.Add(this.selectNoneButton);
      this.splitContainer.Panel2.Controls.Add(this.selectAllButton);
      this.splitContainer.Panel2.Controls.Add(this.centerToImageButton);
      this.splitContainer.Panel2.Controls.Add(this.actualSizeButton);
      this.splitContainer.Panel2.Controls.Add(this.zoomOutButton);
      this.splitContainer.Panel2.Controls.Add(this.zoomInButton);
      this.splitContainer.Panel2.Controls.Add(this.zoomToFitButton);
      this.splitContainer.Size = new System.Drawing.Size(847, 327);
      this.splitContainer.SplitterDistance = 643;
      this.splitContainer.SplitterWidth = 5;
      this.splitContainer.TabIndex = 12;
      // 
      // imageBox
      // 
      this.imageBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this.imageBox.Location = new System.Drawing.Point(0, 0);
      this.imageBox.Name = "imageBox";
      this.imageBox.Size = new System.Drawing.Size(643, 327);
      this.imageBox.TabIndex = 0;
      // 
      // selectNoneButton
      // 
      this.selectNoneButton.Location = new System.Drawing.Point(8, 182);
      this.selectNoneButton.Name = "selectNoneButton";
      this.selectNoneButton.Size = new System.Drawing.Size(103, 23);
      this.selectNoneButton.TabIndex = 7;
      this.selectNoneButton.Text = "SelectNone";
      this.selectNoneButton.UseVisualStyleBackColor = true;
      this.selectNoneButton.Click += new System.EventHandler(this.selectNoneButton_Click);
      // 
      // selectAllButton
      // 
      this.selectAllButton.Location = new System.Drawing.Point(8, 153);
      this.selectAllButton.Name = "selectAllButton";
      this.selectAllButton.Size = new System.Drawing.Size(103, 23);
      this.selectAllButton.TabIndex = 6;
      this.selectAllButton.Text = "SelectAll";
      this.selectAllButton.UseVisualStyleBackColor = true;
      this.selectAllButton.Click += new System.EventHandler(this.selectAllButton_Click);
      // 
      // centerToImageButton
      // 
      this.centerToImageButton.Location = new System.Drawing.Point(8, 124);
      this.centerToImageButton.Name = "centerToImageButton";
      this.centerToImageButton.Size = new System.Drawing.Size(103, 23);
      this.centerToImageButton.TabIndex = 5;
      this.centerToImageButton.Text = "CenterToImage";
      this.centerToImageButton.UseVisualStyleBackColor = true;
      this.centerToImageButton.Click += new System.EventHandler(this.centerToImageButton_Click);
      // 
      // actualSizeButton
      // 
      this.actualSizeButton.Location = new System.Drawing.Point(8, 95);
      this.actualSizeButton.Name = "actualSizeButton";
      this.actualSizeButton.Size = new System.Drawing.Size(75, 23);
      this.actualSizeButton.TabIndex = 4;
      this.actualSizeButton.Text = "ActualSize";
      this.actualSizeButton.UseVisualStyleBackColor = true;
      this.actualSizeButton.Click += new System.EventHandler(this.actualSizeButton_Click);
      // 
      // zoomOutButton
      // 
      this.zoomOutButton.Location = new System.Drawing.Point(8, 66);
      this.zoomOutButton.Name = "zoomOutButton";
      this.zoomOutButton.Size = new System.Drawing.Size(75, 23);
      this.zoomOutButton.TabIndex = 3;
      this.zoomOutButton.Text = "ZoomOut";
      this.zoomOutButton.UseVisualStyleBackColor = true;
      this.zoomOutButton.Click += new System.EventHandler(this.zoomOutButton_Click);
      // 
      // zoomInButton
      // 
      this.zoomInButton.Location = new System.Drawing.Point(8, 37);
      this.zoomInButton.Name = "zoomInButton";
      this.zoomInButton.Size = new System.Drawing.Size(75, 23);
      this.zoomInButton.TabIndex = 2;
      this.zoomInButton.Text = "ZoomIn";
      this.zoomInButton.UseVisualStyleBackColor = true;
      this.zoomInButton.Click += new System.EventHandler(this.zoomInButton_Click);
      // 
      // zoomToFitButton
      // 
      this.zoomToFitButton.Location = new System.Drawing.Point(8, 8);
      this.zoomToFitButton.Name = "zoomToFitButton";
      this.zoomToFitButton.Size = new System.Drawing.Size(75, 23);
      this.zoomToFitButton.TabIndex = 1;
      this.zoomToFitButton.Text = "ZoomToFit";
      this.zoomToFitButton.UseVisualStyleBackColor = true;
      this.zoomToFitButton.Click += new System.EventHandler(this.zoomToFitButton_Click);
      // 
      // MethodsDemoForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(847, 373);
      this.Controls.Add(this.splitContainer);
      this.Controls.Add(this.menuStrip);
      this.Controls.Add(this.statusStrip);
      this.Font = new System.Drawing.Font("Segoe UI", 9F);
      this.Name = "MethodsDemoForm";
      this.Text = "Methods Demonstration";
      this.menuStrip.ResumeLayout(false);
      this.menuStrip.PerformLayout();
      this.splitContainer.Panel1.ResumeLayout(false);
      this.splitContainer.Panel2.ResumeLayout(false);
      this.splitContainer.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    private System.Windows.Forms.StatusStrip statusStrip;
    private System.Windows.Forms.SplitContainer splitContainer;
    private ImageBox imageBox;
    private System.Windows.Forms.Button zoomToFitButton;
    private System.Windows.Forms.Button zoomOutButton;
    private System.Windows.Forms.Button zoomInButton;
    private System.Windows.Forms.Button actualSizeButton;
    private System.Windows.Forms.Button centerToImageButton;
    private System.Windows.Forms.Button selectAllButton;
    private System.Windows.Forms.Button selectNoneButton;
  }
}