namespace Cyotek.Windows.Forms.Demo
{
  partial class DragTestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DragTestForm));
            this.imageBox = new Cyotek.Windows.Forms.ImageBox();
            this.demoLabel = new System.Windows.Forms.Label();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageBox
            // 
            this.imageBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageBox.Location = new System.Drawing.Point(0, 0);
            this.imageBox.Name = "imageBox";
            this.imageBox.SelectionMode = Cyotek.Windows.Forms.ImageBoxSelectionMode.Rectangle;
            this.imageBox.Size = new System.Drawing.Size(340, 261);
            this.imageBox.TabIndex = 0;
            this.imageBox.VirtualMode = true;
            this.imageBox.VirtualSize = new System.Drawing.Size(256, 256);
            this.imageBox.Selecting += new System.EventHandler<Cyotek.Windows.Forms.ImageBoxCancelEventArgs>(this.ImageBox_Selecting);
            this.imageBox.SelectionRegionChanged += new System.EventHandler(this.ImageBox_SelectionRegionChanged);
            this.imageBox.VirtualDraw += new System.Windows.Forms.PaintEventHandler(this.ImageBox_VirtualDraw);
            this.imageBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ImageBox_MouseDown);
            this.imageBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ImageBox_MouseMove);
            this.imageBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ImageBox_MouseUp);
            // 
            // demoLabel
            // 
            this.demoLabel.AutoEllipsis = true;
            this.demoLabel.BackColor = System.Drawing.SystemColors.Info;
            this.demoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.demoLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.demoLabel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.demoLabel.Location = new System.Drawing.Point(0, 0);
            this.demoLabel.Name = "demoLabel";
            this.demoLabel.Padding = new System.Windows.Forms.Padding(8);
            this.demoLabel.Size = new System.Drawing.Size(359, 261);
            this.demoLabel.TabIndex = 1;
            this.demoLabel.Text = resources.GetString("demoLabel.Text");
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(12, 12);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.imageBox);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.demoLabel);
            this.splitContainer.Size = new System.Drawing.Size(702, 261);
            this.splitContainer.SplitterDistance = 340;
            this.splitContainer.SplitterWidth = 3;
            this.splitContainer.TabIndex = 2;
            // 
            // DragTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 323);
            this.Controls.Add(this.splitContainer);
            this.Name = "DragTestForm";
            this.Text = "Drag Test";
            this.Controls.SetChildIndex(this.splitContainer, 0);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private ImageBox imageBox;
    private System.Windows.Forms.Label demoLabel;
    private System.Windows.Forms.SplitContainer splitContainer;
  }
}