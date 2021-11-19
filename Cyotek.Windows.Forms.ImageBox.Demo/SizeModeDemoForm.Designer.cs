namespace Cyotek.Windows.Forms.Demo
{
  partial class SizeModeDemoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SizeModeDemoForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.imageBox1 = new Cyotek.Windows.Forms.ImageBox();
            this.cyotekPreviewHeaderLabel = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.imageBox2 = new Cyotek.Windows.Forms.ImageBox();
            this.label1 = new System.Windows.Forms.Label();
            this.imageBox3 = new Cyotek.Windows.Forms.ImageBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.imageBox1);
            this.splitContainer1.Panel1.Controls.Add(this.cyotekPreviewHeaderLabel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(747, 366);
            this.splitContainer1.SplitterDistance = 249;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 10;
            // 
            // imageBox1
            // 
            this.imageBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageBox1.Image = ((System.Drawing.Image)(resources.GetObject("imageBox1.Image")));
            this.imageBox1.Location = new System.Drawing.Point(0, 0);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(249, 345);
            this.imageBox1.TabIndex = 0;
            // 
            // cyotekPreviewHeaderLabel
            // 
            this.cyotekPreviewHeaderLabel.AutoEllipsis = true;
            this.cyotekPreviewHeaderLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cyotekPreviewHeaderLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cyotekPreviewHeaderLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cyotekPreviewHeaderLabel.Location = new System.Drawing.Point(0, 345);
            this.cyotekPreviewHeaderLabel.Name = "cyotekPreviewHeaderLabel";
            this.cyotekPreviewHeaderLabel.Size = new System.Drawing.Size(249, 21);
            this.cyotekPreviewHeaderLabel.TabIndex = 8;
            this.cyotekPreviewHeaderLabel.Text = "Normal";
            this.cyotekPreviewHeaderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.imageBox2);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.imageBox3);
            this.splitContainer2.Panel2.Controls.Add(this.label2);
            this.splitContainer2.Size = new System.Drawing.Size(495, 366);
            this.splitContainer2.SplitterDistance = 247;
            this.splitContainer2.SplitterWidth = 3;
            this.splitContainer2.TabIndex = 11;
            // 
            // imageBox2
            // 
            this.imageBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageBox2.Image = ((System.Drawing.Image)(resources.GetObject("imageBox2.Image")));
            this.imageBox2.Location = new System.Drawing.Point(0, 0);
            this.imageBox2.Name = "imageBox2";
            this.imageBox2.Size = new System.Drawing.Size(247, 345);
            this.imageBox2.SizeMode = Cyotek.Windows.Forms.ImageBoxSizeMode.Stretch;
            this.imageBox2.TabIndex = 1;
            this.imageBox2.Zoom = 162;
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(0, 345);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Stretch";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imageBox3
            // 
            this.imageBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageBox3.Image = ((System.Drawing.Image)(resources.GetObject("imageBox3.Image")));
            this.imageBox3.Location = new System.Drawing.Point(0, 0);
            this.imageBox3.Name = "imageBox3";
            this.imageBox3.Size = new System.Drawing.Size(245, 345);
            this.imageBox3.SizeMode = Cyotek.Windows.Forms.ImageBoxSizeMode.Fit;
            this.imageBox3.TabIndex = 1;
            this.imageBox3.Zoom = 160;
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(0, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Fit";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SizeModeDemoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 428);
            this.Controls.Add(this.splitContainer1);
            this.Name = "SizeModeDemoForm";
            this.Text = "SizeMode Demonstation";
            this.Controls.SetChildIndex(this.splitContainer1, 0);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.SplitContainer splitContainer1;
    private System.Windows.Forms.SplitContainer splitContainer2;
    private ImageBox imageBox1;
    private ImageBox imageBox2;
    private ImageBox imageBox3;
    private System.Windows.Forms.Label cyotekPreviewHeaderLabel;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;

  }
}