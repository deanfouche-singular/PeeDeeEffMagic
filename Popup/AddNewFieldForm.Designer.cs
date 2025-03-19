namespace PeeDeeEffMagic.Popup
{
  partial class AddNewFieldForm
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
      gBoxFieldType = new GroupBox();
      rBtnSignature = new RadioButton();
      rBtnCheckBox = new RadioButton();
      rBtnText = new RadioButton();
      gBoxPos = new GroupBox();
      txtYPos = new TextBox();
      txtXPos = new TextBox();
      lblY = new Label();
      lblX = new Label();
      btnAdd = new Button();
      btnCancel = new Button();
      gBoxFieldType.SuspendLayout();
      gBoxPos.SuspendLayout();
      SuspendLayout();
      // 
      // gBoxFieldType
      // 
      gBoxFieldType.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      gBoxFieldType.Controls.Add(rBtnSignature);
      gBoxFieldType.Controls.Add(rBtnCheckBox);
      gBoxFieldType.Controls.Add(rBtnText);
      gBoxFieldType.Location = new Point(12, 12);
      gBoxFieldType.MinimumSize = new Size(0, 64);
      gBoxFieldType.Name = "gBoxFieldType";
      gBoxFieldType.Size = new Size(281, 64);
      gBoxFieldType.TabIndex = 0;
      gBoxFieldType.TabStop = false;
      gBoxFieldType.Text = "Field Type";
      // 
      // rBtnSignature
      // 
      rBtnSignature.AutoSize = true;
      rBtnSignature.Location = new Point(180, 26);
      rBtnSignature.Name = "rBtnSignature";
      rBtnSignature.Size = new Size(93, 24);
      rBtnSignature.TabIndex = 2;
      rBtnSignature.TabStop = true;
      rBtnSignature.Text = "Signature";
      rBtnSignature.UseVisualStyleBackColor = true;
      // 
      // rBtnCheckBox
      // 
      rBtnCheckBox.AutoSize = true;
      rBtnCheckBox.Location = new Point(80, 26);
      rBtnCheckBox.Name = "rBtnCheckBox";
      rBtnCheckBox.Size = new Size(94, 24);
      rBtnCheckBox.TabIndex = 1;
      rBtnCheckBox.TabStop = true;
      rBtnCheckBox.Text = "Checkbox";
      rBtnCheckBox.UseVisualStyleBackColor = true;
      // 
      // rBtnText
      // 
      rBtnText.AutoSize = true;
      rBtnText.Location = new Point(6, 26);
      rBtnText.Name = "rBtnText";
      rBtnText.Size = new Size(57, 24);
      rBtnText.TabIndex = 0;
      rBtnText.TabStop = true;
      rBtnText.Text = "Text";
      rBtnText.UseVisualStyleBackColor = true;
      // 
      // gBoxPos
      // 
      gBoxPos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      gBoxPos.Controls.Add(txtYPos);
      gBoxPos.Controls.Add(txtXPos);
      gBoxPos.Controls.Add(lblY);
      gBoxPos.Controls.Add(lblX);
      gBoxPos.Location = new Point(12, 82);
      gBoxPos.Name = "gBoxPos";
      gBoxPos.Size = new Size(281, 103);
      gBoxPos.TabIndex = 1;
      gBoxPos.TabStop = false;
      gBoxPos.Text = "Position";
      // 
      // txtYPos
      // 
      txtYPos.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      txtYPos.Location = new Point(220, 60);
      txtYPos.Name = "txtYPos";
      txtYPos.Size = new Size(55, 27);
      txtYPos.TabIndex = 3;
      // 
      // txtXPos
      // 
      txtXPos.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      txtXPos.Location = new Point(220, 26);
      txtXPos.Name = "txtXPos";
      txtXPos.Size = new Size(55, 27);
      txtXPos.TabIndex = 2;
      // 
      // lblY
      // 
      lblY.AutoSize = true;
      lblY.Location = new Point(17, 63);
      lblY.Name = "lblY";
      lblY.Size = new Size(24, 20);
      lblY.TabIndex = 1;
      lblY.Text = "Y :";
      // 
      // lblX
      // 
      lblX.AutoSize = true;
      lblX.Location = new Point(17, 29);
      lblX.Name = "lblX";
      lblX.Size = new Size(25, 20);
      lblX.TabIndex = 0;
      lblX.Text = "X :";
      // 
      // btnAdd
      // 
      btnAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      btnAdd.Location = new Point(99, 191);
      btnAdd.Name = "btnAdd";
      btnAdd.Size = new Size(94, 29);
      btnAdd.TabIndex = 2;
      btnAdd.Text = "Add";
      btnAdd.UseVisualStyleBackColor = true;
      // 
      // btnCancel
      // 
      btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      btnCancel.Location = new Point(199, 191);
      btnCancel.Name = "btnCancel";
      btnCancel.Size = new Size(94, 29);
      btnCancel.TabIndex = 3;
      btnCancel.Text = "Cancel";
      btnCancel.UseVisualStyleBackColor = true;
      // 
      // AddNewFieldForm
      // 
      AutoScaleDimensions = new SizeF(8F, 20F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(305, 229);
      Controls.Add(btnCancel);
      Controls.Add(btnAdd);
      Controls.Add(gBoxPos);
      Controls.Add(gBoxFieldType);
      MaximumSize = new Size(323, 276);
      MinimumSize = new Size(323, 276);
      Name = "AddNewFieldForm";
      Text = "New Field Editor";
      gBoxFieldType.ResumeLayout(false);
      gBoxFieldType.PerformLayout();
      gBoxPos.ResumeLayout(false);
      gBoxPos.PerformLayout();
      ResumeLayout(false);
    }

    #endregion

    private GroupBox gBoxFieldType;
    private RadioButton rBtnSignature;
    private RadioButton rBtnCheckBox;
    private RadioButton rBtnText;
    private GroupBox gBoxPos;
    private TextBox txtYPos;
    private TextBox txtXPos;
    private Label lblY;
    private Label lblX;
    private Button btnAdd;
    private Button btnCancel;
  }
}