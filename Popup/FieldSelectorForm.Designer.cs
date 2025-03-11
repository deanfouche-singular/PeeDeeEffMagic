namespace PeeDeeEffMagic.Popup
{
  partial class FieldSelectorForm
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
      lBoxExistingFields = new ListBox();
      lBoxSelectedFields = new ListBox();
      btnRight = new Button();
      btnLeft = new Button();
      splitContainer1 = new SplitContainer();
      label1 = new Label();
      splitContainer2 = new SplitContainer();
      label2 = new Label();
      btnContinue = new Button();
      ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
      splitContainer1.Panel1.SuspendLayout();
      splitContainer1.Panel2.SuspendLayout();
      splitContainer1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
      splitContainer2.Panel1.SuspendLayout();
      splitContainer2.Panel2.SuspendLayout();
      splitContainer2.SuspendLayout();
      SuspendLayout();
      // 
      // lBoxExistingFields
      // 
      lBoxExistingFields.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      lBoxExistingFields.FormattingEnabled = true;
      lBoxExistingFields.Location = new Point(4, 23);
      lBoxExistingFields.MinimumSize = new Size(250, 0);
      lBoxExistingFields.Name = "lBoxExistingFields";
      lBoxExistingFields.SelectionMode = SelectionMode.MultiExtended;
      lBoxExistingFields.Size = new Size(252, 344);
      lBoxExistingFields.TabIndex = 0;
      // 
      // lBoxSelectedFields
      // 
      lBoxSelectedFields.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      lBoxSelectedFields.FormattingEnabled = true;
      lBoxSelectedFields.Location = new Point(3, 23);
      lBoxSelectedFields.MinimumSize = new Size(250, 0);
      lBoxSelectedFields.Name = "lBoxSelectedFields";
      lBoxSelectedFields.SelectionMode = SelectionMode.MultiExtended;
      lBoxSelectedFields.Size = new Size(254, 344);
      lBoxSelectedFields.TabIndex = 1;
      // 
      // btnRight
      // 
      btnRight.Anchor = AnchorStyles.Top;
      btnRight.Location = new Point(0, 30);
      btnRight.MaximumSize = new Size(94, 29);
      btnRight.MinimumSize = new Size(60, 29);
      btnRight.Name = "btnRight";
      btnRight.Size = new Size(60, 29);
      btnRight.TabIndex = 2;
      btnRight.Text = ">>";
      btnRight.UseVisualStyleBackColor = true;
      btnRight.Click += btnRight_Click;
      // 
      // btnLeft
      // 
      btnLeft.Anchor = AnchorStyles.Top;
      btnLeft.Location = new Point(0, 65);
      btnLeft.MaximumSize = new Size(94, 29);
      btnLeft.MinimumSize = new Size(60, 29);
      btnLeft.Name = "btnLeft";
      btnLeft.Size = new Size(60, 29);
      btnLeft.TabIndex = 3;
      btnLeft.Text = "<<";
      btnLeft.UseVisualStyleBackColor = true;
      btnLeft.Click += btnLeft_Click;
      // 
      // splitContainer1
      // 
      splitContainer1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      splitContainer1.Location = new Point(4, 41);
      splitContainer1.Name = "splitContainer1";
      // 
      // splitContainer1.Panel1
      // 
      splitContainer1.Panel1.Controls.Add(label1);
      splitContainer1.Panel1.Controls.Add(lBoxExistingFields);
      // 
      // splitContainer1.Panel2
      // 
      splitContainer1.Panel2.Controls.Add(splitContainer2);
      splitContainer1.Size = new Size(586, 372);
      splitContainer1.SplitterDistance = 260;
      splitContainer1.TabIndex = 4;
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.Location = new Point(3, 0);
      label1.Name = "label1";
      label1.Size = new Size(100, 20);
      label1.TabIndex = 5;
      label1.Text = "Existing fields";
      // 
      // splitContainer2
      // 
      splitContainer2.Dock = DockStyle.Fill;
      splitContainer2.Location = new Point(0, 0);
      splitContainer2.Name = "splitContainer2";
      // 
      // splitContainer2.Panel1
      // 
      splitContainer2.Panel1.Controls.Add(btnRight);
      splitContainer2.Panel1.Controls.Add(btnLeft);
      // 
      // splitContainer2.Panel2
      // 
      splitContainer2.Panel2.Controls.Add(label2);
      splitContainer2.Panel2.Controls.Add(lBoxSelectedFields);
      splitContainer2.Size = new Size(322, 372);
      splitContainer2.SplitterDistance = 59;
      splitContainer2.TabIndex = 0;
      // 
      // label2
      // 
      label2.AutoSize = true;
      label2.Location = new Point(3, 0);
      label2.Name = "label2";
      label2.Size = new Size(106, 20);
      label2.TabIndex = 6;
      label2.Text = "Selected fields";
      // 
      // btnContinue
      // 
      btnContinue.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      btnContinue.Location = new Point(491, 419);
      btnContinue.Name = "btnContinue";
      btnContinue.Size = new Size(94, 29);
      btnContinue.TabIndex = 4;
      btnContinue.Text = "Continue";
      btnContinue.UseVisualStyleBackColor = true;
      btnContinue.Click += btnContinue_Click;
      // 
      // FieldSelectorForm
      // 
      AutoScaleDimensions = new SizeF(8F, 20F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(592, 453);
      Controls.Add(btnContinue);
      Controls.Add(splitContainer1);
      MinimumSize = new Size(610, 500);
      Name = "FieldSelectorForm";
      StartPosition = FormStartPosition.CenterParent;
      Text = "Field Selector";
      splitContainer1.Panel1.ResumeLayout(false);
      splitContainer1.Panel1.PerformLayout();
      splitContainer1.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
      splitContainer1.ResumeLayout(false);
      splitContainer2.Panel1.ResumeLayout(false);
      splitContainer2.Panel2.ResumeLayout(false);
      splitContainer2.Panel2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
      splitContainer2.ResumeLayout(false);
      ResumeLayout(false);
    }

    #endregion

    private ListBox lBoxExistingFields;
    private ListBox lBoxSelectedFields;
    private Button btnRight;
    private Button btnLeft;
    private SplitContainer splitContainer1;
    private SplitContainer splitContainer2;
    private Label label1;
    private Label label2;
    private Button btnContinue;
  }
}