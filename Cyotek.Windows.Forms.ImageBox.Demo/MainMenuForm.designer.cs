namespace Cyotek.Windows.Forms.Demo
{
  partial class MainMenuForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
      this.aboutButton = new System.Windows.Forms.Button();
      this.exitButton = new System.Windows.Forms.Button();
      this.imageBoxDemoButton = new System.Windows.Forms.Button();
      this.pixelGridDemoButton = new System.Windows.Forms.Button();
      this.virtualModeDemoButton = new System.Windows.Forms.Button();
      this.groupBox1 = new Cyotek.Windows.Forms.GroupBox();
      this.dragTestDemoButton = new System.Windows.Forms.Button();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // aboutButton
      // 
      this.aboutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.aboutButton.Location = new System.Drawing.Point(276, 296);
      this.aboutButton.Name = "aboutButton";
      this.aboutButton.Size = new System.Drawing.Size(87, 27);
      this.aboutButton.TabIndex = 1;
      this.aboutButton.Text = "&About";
      this.aboutButton.UseVisualStyleBackColor = true;
      this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
      // 
      // exitButton
      // 
      this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.exitButton.Location = new System.Drawing.Point(370, 296);
      this.exitButton.Name = "exitButton";
      this.exitButton.Size = new System.Drawing.Size(87, 27);
      this.exitButton.TabIndex = 2;
      this.exitButton.Text = "Close";
      this.exitButton.UseVisualStyleBackColor = true;
      this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
      // 
      // imageBoxDemoButton
      // 
      this.imageBoxDemoButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.imageBoxDemoButton.Location = new System.Drawing.Point(41, 22);
      this.imageBoxDemoButton.Name = "imageBoxDemoButton";
      this.imageBoxDemoButton.Size = new System.Drawing.Size(397, 27);
      this.imageBoxDemoButton.TabIndex = 0;
      this.imageBoxDemoButton.Text = "General &ImageBox Control Demonstration";
      this.imageBoxDemoButton.UseVisualStyleBackColor = true;
      this.imageBoxDemoButton.Click += new System.EventHandler(this.imageBoxDemoButton_Click);
      // 
      // pixelGridDemoButton
      // 
      this.pixelGridDemoButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.pixelGridDemoButton.Location = new System.Drawing.Point(41, 56);
      this.pixelGridDemoButton.Name = "pixelGridDemoButton";
      this.pixelGridDemoButton.Size = new System.Drawing.Size(397, 27);
      this.pixelGridDemoButton.TabIndex = 1;
      this.pixelGridDemoButton.Text = "Pixel&Grid Demonstration";
      this.pixelGridDemoButton.UseVisualStyleBackColor = true;
      this.pixelGridDemoButton.Click += new System.EventHandler(this.pixelGridDemoButton_Click);
      // 
      // virtualModeDemoButton
      // 
      this.virtualModeDemoButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.virtualModeDemoButton.Location = new System.Drawing.Point(41, 89);
      this.virtualModeDemoButton.Name = "virtualModeDemoButton";
      this.virtualModeDemoButton.Size = new System.Drawing.Size(397, 27);
      this.virtualModeDemoButton.TabIndex = 2;
      this.virtualModeDemoButton.Text = "&Virtual Mode Demonstration";
      this.virtualModeDemoButton.UseVisualStyleBackColor = true;
      this.virtualModeDemoButton.Click += new System.EventHandler(this.virtualModeDemoButton_Click);
      // 
      // groupBox1
      // 
      this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox1.Controls.Add(this.dragTestDemoButton);
      this.groupBox1.Controls.Add(this.imageBoxDemoButton);
      this.groupBox1.Controls.Add(this.virtualModeDemoButton);
      this.groupBox1.Controls.Add(this.pixelGridDemoButton);
      this.groupBox1.Image = global::Cyotek.Windows.Forms.Demo.Properties.Resources.icon_32;
      this.groupBox1.Location = new System.Drawing.Point(14, 14);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(444, 275);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Available Demonstrations";
      // 
      // dragTestDemoButton
      // 
      this.dragTestDemoButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dragTestDemoButton.Location = new System.Drawing.Point(41, 122);
      this.dragTestDemoButton.Name = "dragTestDemoButton";
      this.dragTestDemoButton.Size = new System.Drawing.Size(397, 27);
      this.dragTestDemoButton.TabIndex = 3;
      this.dragTestDemoButton.Text = "&Drag Test Demonstration";
      this.dragTestDemoButton.UseVisualStyleBackColor = true;
      this.dragTestDemoButton.Click += new System.EventHandler(this.dragTestDemoButton_Click);
      // 
      // MainMenuForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.exitButton;
      this.ClientSize = new System.Drawing.Size(472, 336);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.exitButton);
      this.Controls.Add(this.aboutButton);
      this.Font = new System.Drawing.Font("Segoe UI", 9F);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.Name = "MainMenuForm";
      this.ShowIcon = true;
      this.ShowInTaskbar = true;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Cyotek ImageBox Control for Windows Forms";
      this.groupBox1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button aboutButton;
    private System.Windows.Forms.Button exitButton;
    private System.Windows.Forms.Button imageBoxDemoButton;
    private System.Windows.Forms.Button pixelGridDemoButton;
    private System.Windows.Forms.Button virtualModeDemoButton;
    private GroupBox groupBox1;
    private System.Windows.Forms.Button dragTestDemoButton;



  }
}

