namespace PeeDeeEffMagic.Popup
{
  partial class YesNoConfirmForm
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
      btnOK = new Button();
      btnCancel = new Button();
      lblDescription = new Label();
      SuspendLayout();
      // 
      // btnOK
      // 
      btnOK.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      btnOK.Location = new Point(56, 42);
      btnOK.Name = "btnOK";
      btnOK.Size = new Size(94, 29);
      btnOK.TabIndex = 0;
      btnOK.Text = "Yes";
      btnOK.UseVisualStyleBackColor = true;
      // 
      // btnCancel
      // 
      btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      btnCancel.Location = new Point(166, 42);
      btnCancel.Name = "btnCancel";
      btnCancel.Size = new Size(94, 29);
      btnCancel.TabIndex = 1;
      btnCancel.Text = "Cancel";
      btnCancel.UseVisualStyleBackColor = true;
      // 
      // lblDescription
      // 
      lblDescription.AutoSize = true;
      lblDescription.Location = new Point(14, 8);
      lblDescription.Name = "lblDescription";
      lblDescription.Size = new Size(85, 20);
      lblDescription.TabIndex = 2;
      lblDescription.Text = "Description";
      // 
      // YesNoConfirmForm
      // 
      AutoScaleDimensions = new SizeF(8F, 20F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(272, 83);
      Controls.Add(lblDescription);
      Controls.Add(btnCancel);
      Controls.Add(btnOK);
      MinimumSize = new Size(290, 130);
      Name = "YesNoConfirmForm";
      Text = "YesNoConfirmForm";
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Button btnOK;
    private Button btnCancel;
    private Label lblDescription;
  }
}