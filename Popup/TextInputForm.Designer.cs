namespace PeeDeeEffMagic.Popup
{
  partial class TextInputForm
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
      components = new System.ComponentModel.Container();
      lblFieldName = new Label();
      btnOK = new Button();
      txtBoxFieldValue = new TextBox();
      tTipFieldValue = new ToolTip(components);
      SuspendLayout();
      // 
      // lblFieldName
      // 
      lblFieldName.AutoSize = true;
      lblFieldName.Location = new Point(12, 11);
      lblFieldName.Name = "lblFieldName";
      lblFieldName.Size = new Size(82, 20);
      lblFieldName.TabIndex = 0;
      lblFieldName.Text = "Field name";
      // 
      // btnOK
      // 
      btnOK.Location = new Point(176, 69);
      btnOK.Name = "btnOK";
      btnOK.Size = new Size(94, 29);
      btnOK.TabIndex = 1;
      btnOK.Text = "OK";
      btnOK.UseVisualStyleBackColor = true;
      btnOK.Click += btnOK_Click;
      // 
      // txtBoxFieldValue
      // 
      txtBoxFieldValue.Location = new Point(12, 34);
      txtBoxFieldValue.Name = "txtBoxFieldValue";
      txtBoxFieldValue.Size = new Size(258, 27);
      txtBoxFieldValue.TabIndex = 2;
      txtBoxFieldValue.KeyDown += txtBoxFieldValue_KeyDown;
      txtBoxFieldValue.MouseLeave += txtBoxFieldValue_MouseLeave;
      txtBoxFieldValue.MouseHover += txtBoxFieldValue_MouseHover;
      // 
      // tTipFieldValue
      // 
      tTipFieldValue.ToolTipTitle = "Field Value";
      // 
      // TextInputForm
      // 
      AutoScaleDimensions = new SizeF(8F, 20F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(282, 108);
      Controls.Add(txtBoxFieldValue);
      Controls.Add(btnOK);
      Controls.Add(lblFieldName);
      FormBorderStyle = FormBorderStyle.FixedToolWindow;
      MaximumSize = new Size(300, 155);
      MinimumSize = new Size(300, 155);
      Name = "TextInputForm";
      StartPosition = FormStartPosition.CenterParent;
      Text = "Field Editor";
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Label lblFieldName;
    private Button btnOK;
    private TextBox txtBoxFieldValue;
    private ToolTip tTipFieldValue;
  }
}