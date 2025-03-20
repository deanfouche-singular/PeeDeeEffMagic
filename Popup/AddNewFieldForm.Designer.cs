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
      cboBoxPages = new ComboBox();
      lblPage = new Label();
      txtYPos = new TextBox();
      txtXPos = new TextBox();
      lblY = new Label();
      lblX = new Label();
      btnAdd = new Button();
      btnCancel = new Button();
      lblFieldName = new Label();
      txtFieldName = new TextBox();
      gBoxSize = new GroupBox();
      txtHeight = new TextBox();
      lblWidth = new Label();
      txtWidth = new TextBox();
      lblHeight = new Label();
      gBoxFieldType.SuspendLayout();
      gBoxPos.SuspendLayout();
      gBoxSize.SuspendLayout();
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
      gBoxFieldType.Size = new Size(277, 64);
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
      rBtnSignature.CheckedChanged += rBtnSignature_CheckedChanged;
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
      rBtnCheckBox.CheckedChanged += rBtnCheckBox_CheckedChanged;
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
      rBtnText.CheckedChanged += rBtnText_CheckedChanged;
      // 
      // gBoxPos
      // 
      gBoxPos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      gBoxPos.Controls.Add(cboBoxPages);
      gBoxPos.Controls.Add(lblPage);
      gBoxPos.Controls.Add(txtYPos);
      gBoxPos.Controls.Add(txtXPos);
      gBoxPos.Controls.Add(lblY);
      gBoxPos.Controls.Add(lblX);
      gBoxPos.Location = new Point(12, 82);
      gBoxPos.Name = "gBoxPos";
      gBoxPos.Size = new Size(277, 132);
      gBoxPos.TabIndex = 1;
      gBoxPos.TabStop = false;
      gBoxPos.Text = "Position";
      // 
      // cboBoxPages
      // 
      cboBoxPages.FormattingEnabled = true;
      cboBoxPages.Location = new Point(214, 26);
      cboBoxPages.Name = "cboBoxPages";
      cboBoxPages.Size = new Size(55, 28);
      cboBoxPages.TabIndex = 3;
      cboBoxPages.SelectedValueChanged += cboBoxPages_SelectedValueChanged;
      // 
      // lblPage
      // 
      lblPage.AutoSize = true;
      lblPage.Location = new Point(15, 29);
      lblPage.Name = "lblPage";
      lblPage.Size = new Size(48, 20);
      lblPage.TabIndex = 4;
      lblPage.Text = "Page :";
      // 
      // txtYPos
      // 
      txtYPos.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      txtYPos.Location = new Point(214, 93);
      txtYPos.Name = "txtYPos";
      txtYPos.Size = new Size(55, 27);
      txtYPos.TabIndex = 5;
      txtYPos.TextChanged += txtYPos_TextChanged;
      // 
      // txtXPos
      // 
      txtXPos.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      txtXPos.Location = new Point(214, 59);
      txtXPos.Name = "txtXPos";
      txtXPos.Size = new Size(55, 27);
      txtXPos.TabIndex = 4;
      txtXPos.TextChanged += txtXPos_TextChanged;
      // 
      // lblY
      // 
      lblY.AutoSize = true;
      lblY.Location = new Point(15, 96);
      lblY.Name = "lblY";
      lblY.Size = new Size(24, 20);
      lblY.TabIndex = 1;
      lblY.Text = "Y :";
      // 
      // lblX
      // 
      lblX.AutoSize = true;
      lblX.Location = new Point(15, 62);
      lblX.Name = "lblX";
      lblX.Size = new Size(25, 20);
      lblX.TabIndex = 0;
      lblX.Text = "X :";
      // 
      // btnAdd
      // 
      btnAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      btnAdd.Location = new Point(95, 364);
      btnAdd.Name = "btnAdd";
      btnAdd.Size = new Size(94, 29);
      btnAdd.TabIndex = 9;
      btnAdd.Text = "Add";
      btnAdd.UseVisualStyleBackColor = true;
      btnAdd.Click += btnAdd_Click;
      // 
      // btnCancel
      // 
      btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      btnCancel.Location = new Point(195, 364);
      btnCancel.Name = "btnCancel";
      btnCancel.Size = new Size(94, 29);
      btnCancel.TabIndex = 10;
      btnCancel.Text = "Cancel";
      btnCancel.UseVisualStyleBackColor = true;
      btnCancel.Click += btnCancel_Click;
      // 
      // lblFieldName
      // 
      lblFieldName.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
      lblFieldName.AutoSize = true;
      lblFieldName.Location = new Point(12, 333);
      lblFieldName.Name = "lblFieldName";
      lblFieldName.Size = new Size(92, 20);
      lblFieldName.TabIndex = 4;
      lblFieldName.Text = "Field Name :";
      // 
      // txtFieldName
      // 
      txtFieldName.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      txtFieldName.Location = new Point(110, 330);
      txtFieldName.Name = "txtFieldName";
      txtFieldName.Size = new Size(179, 27);
      txtFieldName.TabIndex = 8;
      // 
      // gBoxSize
      // 
      gBoxSize.Controls.Add(txtHeight);
      gBoxSize.Controls.Add(lblWidth);
      gBoxSize.Controls.Add(txtWidth);
      gBoxSize.Controls.Add(lblHeight);
      gBoxSize.Location = new Point(12, 220);
      gBoxSize.Name = "gBoxSize";
      gBoxSize.Size = new Size(277, 104);
      gBoxSize.TabIndex = 6;
      gBoxSize.TabStop = false;
      gBoxSize.Text = "Size";
      // 
      // txtHeight
      // 
      txtHeight.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      txtHeight.Location = new Point(214, 66);
      txtHeight.Name = "txtHeight";
      txtHeight.Size = new Size(55, 27);
      txtHeight.TabIndex = 7;
      // 
      // lblWidth
      // 
      lblWidth.AutoSize = true;
      lblWidth.Location = new Point(15, 35);
      lblWidth.Name = "lblWidth";
      lblWidth.Size = new Size(56, 20);
      lblWidth.TabIndex = 6;
      lblWidth.Text = "Width :";
      // 
      // txtWidth
      // 
      txtWidth.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      txtWidth.Location = new Point(214, 32);
      txtWidth.Name = "txtWidth";
      txtWidth.Size = new Size(55, 27);
      txtWidth.TabIndex = 6;
      // 
      // lblHeight
      // 
      lblHeight.AutoSize = true;
      lblHeight.Location = new Point(15, 69);
      lblHeight.Name = "lblHeight";
      lblHeight.Size = new Size(61, 20);
      lblHeight.TabIndex = 7;
      lblHeight.Text = "Height :";
      // 
      // AddNewFieldForm
      // 
      AutoScaleDimensions = new SizeF(8F, 20F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(305, 406);
      Controls.Add(gBoxSize);
      Controls.Add(txtFieldName);
      Controls.Add(lblFieldName);
      Controls.Add(btnCancel);
      Controls.Add(btnAdd);
      Controls.Add(gBoxPos);
      Controls.Add(gBoxFieldType);
      FormBorderStyle = FormBorderStyle.FixedToolWindow;
      MaximumSize = new Size(323, 453);
      MinimumSize = new Size(323, 453);
      Name = "AddNewFieldForm";
      StartPosition = FormStartPosition.CenterParent;
      Text = "New Field Editor";
      gBoxFieldType.ResumeLayout(false);
      gBoxFieldType.PerformLayout();
      gBoxPos.ResumeLayout(false);
      gBoxPos.PerformLayout();
      gBoxSize.ResumeLayout(false);
      gBoxSize.PerformLayout();
      ResumeLayout(false);
      PerformLayout();
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
    private Label lblPage;
    private Label lblFieldName;
    private TextBox txtFieldName;
    private ComboBox cboBoxPages;
    private GroupBox gBoxSize;
    private TextBox txtHeight;
    private Label lblWidth;
    private TextBox txtWidth;
    private Label lblHeight;
  }
}