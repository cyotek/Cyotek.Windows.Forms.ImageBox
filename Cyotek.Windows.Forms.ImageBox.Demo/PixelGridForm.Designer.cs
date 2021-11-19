namespace Cyotek.Windows.Forms.Demo
{
  partial class PixelGridForm
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
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.propertyGrid = new Cyotek.Windows.Forms.Demo.PropertyGrid();
            this.imageBox = new Cyotek.Windows.Forms.ImageBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
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
            this.splitContainer.Panel1.Controls.Add(this.propertyGrid);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.imageBox);
            this.splitContainer.Size = new System.Drawing.Size(824, 474);
            this.splitContainer.SplitterDistance = 300;
            this.splitContainer.SplitterWidth = 3;
            this.splitContainer.TabIndex = 0;
            // 
            // propertyGrid
            // 
            this.propertyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGrid.Location = new System.Drawing.Point(0, 0);
            this.propertyGrid.Name = "propertyGrid";
            this.propertyGrid.SelectedObject = this.imageBox;
            this.propertyGrid.Size = new System.Drawing.Size(300, 474);
            this.propertyGrid.TabIndex = 0;
            // 
            // imageBox
            // 
            this.imageBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.imageBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageBox.GridDisplayMode = Cyotek.Windows.Forms.ImageBoxGridDisplayMode.Image;
            this.imageBox.Image = global::Cyotek.Windows.Forms.Demo.Properties.Resources.Monitor;
            this.imageBox.ImageBorderStyle = Cyotek.Windows.Forms.ImageBoxBorderStyle.FixedSingleGlowShadow;
            this.imageBox.Location = new System.Drawing.Point(0, 0);
            this.imageBox.Name = "imageBox";
            this.imageBox.ShowPixelGrid = true;
            this.imageBox.Size = new System.Drawing.Size(521, 474);
            this.imageBox.TabIndex = 0;
            this.imageBox.Zoom = 1600;
            // 
            // PixelGridForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 536);
            this.Controls.Add(this.splitContainer);
            this.Name = "PixelGridForm";
            this.Text = "Pixel Grid";
            this.Controls.SetChildIndex(this.splitContainer, 0);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.SplitContainer splitContainer;
    private PropertyGrid propertyGrid;
    private ImageBox imageBox;
  }
}