namespace Cyotek.Windows.Forms.Demo
{
  partial class DemonstrationBaseForm
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
            this.productNameLabel = new System.Windows.Forms.Label();
            this.productUrlLabel = new System.Windows.Forms.LinkLabel();
            this.closeButton = new System.Windows.Forms.Button();
            this.iconPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.productNameLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.productNameLabel.Location = new System.Drawing.Point(50, 397);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(219, 13);
            this.productNameLabel.TabIndex = 1;
            this.productNameLabel.Text = "Cyotek ImageBox Control for Windows Forms";
            // 
            // productUrlLabel
            // 
            this.productUrlLabel.AutoSize = true;
            this.productUrlLabel.BackColor = System.Drawing.Color.Transparent;
            this.productUrlLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.productUrlLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.productUrlLabel.LinkColor = System.Drawing.SystemColors.ControlDark;
            this.productUrlLabel.Location = new System.Drawing.Point(50, 411);
            this.productUrlLabel.Name = "productUrlLabel";
            this.productUrlLabel.Size = new System.Drawing.Size(130, 13);
            this.productUrlLabel.TabIndex = 2;
            this.productUrlLabel.TabStop = true;
            this.productUrlLabel.Text = "https://www.cyotek.com/";
            this.productUrlLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ProductUrlLabel_LinkClicked);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeButton.Location = new System.Drawing.Point(537, 406);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // iconPictureBox
            // 
            this.iconPictureBox.Image = global::Cyotek.Windows.Forms.Demo.Properties.Resources.IconSmall;
            this.iconPictureBox.Location = new System.Drawing.Point(12, 397);
            this.iconPictureBox.Name = "iconPictureBox";
            this.iconPictureBox.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.iconPictureBox.TabIndex = 9;
            this.iconPictureBox.TabStop = false;
            // 
            // DemonstrationBaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.CancelButton = this.closeButton;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.iconPictureBox);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.productUrlLabel);
            this.Controls.Add(this.productNameLabel);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Name = "DemonstrationBaseForm";
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }
    private System.Windows.Forms.Label productNameLabel;
    private System.Windows.Forms.LinkLabel productUrlLabel;
    private System.Windows.Forms.Button closeButton;
    private System.Windows.Forms.PictureBox iconPictureBox;
   

    #endregion
  }
}
