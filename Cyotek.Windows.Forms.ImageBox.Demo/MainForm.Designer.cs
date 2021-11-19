namespace Cyotek.Windows.Forms.Demo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.demoList = new Cyotek.Windows.Forms.Demo.DemoList();
            this.SuspendLayout();
            // 
            // demoList
            // 
            this.demoList.Location = new System.Drawing.Point(0, 63);
            this.demoList.Name = "demoList";
            this.demoList.Size = new System.Drawing.Size(596, 397);
            this.demoList.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 541);
            this.Controls.Add(this.demoList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.ShowIcon = true;
            this.ShowInTaskbar = true;
            this.Text = "Cyotek Color Picker Controls for Windows Forms";
            this.Controls.SetChildIndex(this.demoList, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private DemoList demoList;
  }
}

