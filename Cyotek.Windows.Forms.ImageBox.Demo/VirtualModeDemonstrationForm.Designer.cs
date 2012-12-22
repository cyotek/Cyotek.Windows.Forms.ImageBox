namespace Cyotek.Windows.Forms.Demo
{
  partial class VirtualModeDemonstrationForm
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
      this.imageBox = new Cyotek.Windows.Forms.ImageBox();
      this.splitContainer = new System.Windows.Forms.SplitContainer();
      this.propertyGrid = new Cyotek.Windows.Forms.PropertyGrid();
      this.splitContainer.Panel1.SuspendLayout();
      this.splitContainer.Panel2.SuspendLayout();
      this.splitContainer.SuspendLayout();
      this.SuspendLayout();
      // 
      // imageBox
      // 
      this.imageBox.AutoSize = false;
      this.imageBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this.imageBox.Location = new System.Drawing.Point(0, 0);
      this.imageBox.Name = "imageBox";
      this.imageBox.SelectionMode = Cyotek.Windows.Forms.ImageBoxSelectionMode.Rectangle;
      this.imageBox.Size = new System.Drawing.Size(543, 373);
      this.imageBox.TabIndex = 0;
      this.imageBox.VirtualMode = true;
      this.imageBox.VirtualSize = new System.Drawing.Size(300, 200);
      this.imageBox.VirtualDraw += new System.Windows.Forms.PaintEventHandler(this.imageBox_VirtualDraw);
      // 
      // splitContainer
      // 
      this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
      this.splitContainer.Location = new System.Drawing.Point(0, 0);
      this.splitContainer.Name = "splitContainer";
      // 
      // splitContainer.Panel1
      // 
      this.splitContainer.Panel1.Controls.Add(this.propertyGrid);
      // 
      // splitContainer.Panel2
      // 
      this.splitContainer.Panel2.Controls.Add(this.imageBox);
      this.splitContainer.Size = new System.Drawing.Size(847, 373);
      this.splitContainer.SplitterDistance = 300;
      this.splitContainer.TabIndex = 1;
      // 
      // propertyGrid
      // 
      this.propertyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
      this.propertyGrid.Location = new System.Drawing.Point(0, 0);
      this.propertyGrid.Name = "propertyGrid";
      this.propertyGrid.SelectedObject = this.imageBox;
      this.propertyGrid.Size = new System.Drawing.Size(300, 373);
      this.propertyGrid.TabIndex = 0;
      // 
      // VirtualModeDemonstrationForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(847, 373);
      this.Controls.Add(this.splitContainer);
      this.Font = new System.Drawing.Font("Segoe UI", 9F);
      this.Name = "VirtualModeDemonstrationForm";
      this.Text = "Virtual Mode Demonstration";
      this.splitContainer.Panel1.ResumeLayout(false);
      this.splitContainer.Panel2.ResumeLayout(false);
      this.splitContainer.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private ImageBox imageBox;
    private System.Windows.Forms.SplitContainer splitContainer;
    private PropertyGrid propertyGrid;
  }
}