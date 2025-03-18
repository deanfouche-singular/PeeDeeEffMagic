namespace PeeDeeEffMagic.Popup
{
  partial class CheckBoxInputForm
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
      lblFieldName = new Label();
      cBoxFieldValue = new CheckBox();
      btnOK = new Button();
      SuspendLayout();
      // 
      // lblFieldName
      // 
      lblFieldName.AutoSize = true;
      lblFieldName.Location = new Point(36, 9);
      lblFieldName.Name = "lblFieldName";
      lblFieldName.Size = new Size(82, 20);
      lblFieldName.TabIndex = 0;
      lblFieldName.Text = "Field name";
      // 
      // cBoxFieldValue
      // 
      cBoxFieldValue.AutoSize = true;
      cBoxFieldValue.Location = new Point(12, 12);
      cBoxFieldValue.Name = "cBoxFieldValue";
      cBoxFieldValue.Size = new Size(18, 17);
      cBoxFieldValue.TabIndex = 1;
      cBoxFieldValue.UseVisualStyleBackColor = true;
      // 
      // btnOK
      // 
      btnOK.Location = new Point(176, 37);
      btnOK.Name = "btnOK";
      btnOK.Size = new Size(94, 29);
      btnOK.TabIndex = 2;
      btnOK.Text = "OK";
      btnOK.UseVisualStyleBackColor = true;
      // 
      // CheckBoxInputForm
      // 
      AutoScaleDimensions = new SizeF(8F, 20F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(282, 78);
      Controls.Add(btnOK);
      Controls.Add(cBoxFieldValue);
      Controls.Add(lblFieldName);
      MaximumSize = new Size(300, 155);
      Name = "CheckBoxInputForm";
      Text = "CheckBoxInputForm";
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Label lblFieldName;
    private CheckBox cBoxFieldValue;
    private Button btnOK;
  }
}