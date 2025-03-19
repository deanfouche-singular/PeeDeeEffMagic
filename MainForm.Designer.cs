namespace PeeDeeEffMagic
{
  partial class MainForm
  {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      txtFilePath = new TextBox();
      btnProcess = new Button();
      cBoxFlatten = new CheckBox();
      cBoxRevise = new CheckBox();
      cBoxReadonly = new CheckBox();
      cBoxReadFields = new CheckBox();
      btnFilePath = new Button();
      btnOutputPath = new Button();
      txtOutputPath = new TextBox();
      lblFileLocation = new Label();
      lblOutputPath = new Label();
      rTxtOutputDialog = new RichTextBox();
      lblDragAndDrop = new Label();
      splitContainer1 = new SplitContainer();
      groupBox1 = new GroupBox();
      cBoxPreSave = new CheckBox();
      cBoxEdit = new CheckBox();
      cBoxShowRevisions = new CheckBox();
      cBoxExtractSignatures = new CheckBox();
      cBoxFlattenPartial = new CheckBox();
      cBoxSign = new CheckBox();
      splitContainer2 = new SplitContainer();
      groupBox2 = new GroupBox();
      cBoxConvertHtml = new CheckBox();
      cBoxExportFieldsCsv = new CheckBox();
      panel1 = new Panel();
      gBoxLibraries = new GroupBox();
      rBtnIText = new RadioButton();
      rBtnIronPDF = new RadioButton();
      cBoxAddField = new CheckBox();
      ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
      splitContainer1.Panel1.SuspendLayout();
      splitContainer1.Panel2.SuspendLayout();
      splitContainer1.SuspendLayout();
      groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
      splitContainer2.Panel1.SuspendLayout();
      splitContainer2.Panel2.SuspendLayout();
      splitContainer2.SuspendLayout();
      groupBox2.SuspendLayout();
      panel1.SuspendLayout();
      gBoxLibraries.SuspendLayout();
      SuspendLayout();
      // 
      // txtFilePath
      // 
      txtFilePath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      txtFilePath.Location = new Point(132, 20);
      txtFilePath.Name = "txtFilePath";
      txtFilePath.Size = new Size(802, 27);
      txtFilePath.TabIndex = 0;
      txtFilePath.TextChanged += txtFilePath_TextChanged;
      // 
      // btnProcess
      // 
      btnProcess.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      btnProcess.Location = new Point(3, 3);
      btnProcess.MinimumSize = new Size(95, 30);
      btnProcess.Name = "btnProcess";
      btnProcess.Size = new Size(219, 146);
      btnProcess.TabIndex = 1;
      btnProcess.Text = "Process file";
      btnProcess.UseVisualStyleBackColor = true;
      btnProcess.Click += btnProcess_Click;
      // 
      // cBoxFlatten
      // 
      cBoxFlatten.AutoSize = true;
      cBoxFlatten.Location = new Point(12, 113);
      cBoxFlatten.Name = "cBoxFlatten";
      cBoxFlatten.Size = new Size(76, 24);
      cBoxFlatten.TabIndex = 2;
      cBoxFlatten.Text = "Flatten";
      cBoxFlatten.UseVisualStyleBackColor = true;
      // 
      // cBoxRevise
      // 
      cBoxRevise.AutoSize = true;
      cBoxRevise.Location = new Point(12, 56);
      cBoxRevise.Name = "cBoxRevise";
      cBoxRevise.Size = new Size(73, 24);
      cBoxRevise.TabIndex = 5;
      cBoxRevise.Text = "Revise";
      cBoxRevise.UseVisualStyleBackColor = true;
      // 
      // cBoxReadonly
      // 
      cBoxReadonly.AutoSize = true;
      cBoxReadonly.Checked = true;
      cBoxReadonly.CheckState = CheckState.Checked;
      cBoxReadonly.Location = new Point(246, 26);
      cBoxReadonly.Name = "cBoxReadonly";
      cBoxReadonly.Size = new Size(93, 24);
      cBoxReadonly.TabIndex = 4;
      cBoxReadonly.Text = "Readonly";
      cBoxReadonly.UseVisualStyleBackColor = true;
      // 
      // cBoxReadFields
      // 
      cBoxReadFields.AutoSize = true;
      cBoxReadFields.Location = new Point(6, 26);
      cBoxReadFields.Name = "cBoxReadFields";
      cBoxReadFields.Size = new Size(122, 24);
      cBoxReadFields.TabIndex = 3;
      cBoxReadFields.Text = "Display Fields";
      cBoxReadFields.UseVisualStyleBackColor = true;
      // 
      // btnFilePath
      // 
      btnFilePath.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      btnFilePath.Location = new Point(940, 20);
      btnFilePath.Name = "btnFilePath";
      btnFilePath.Size = new Size(30, 30);
      btnFilePath.TabIndex = 5;
      btnFilePath.Text = "...";
      btnFilePath.UseVisualStyleBackColor = true;
      btnFilePath.Click += btnFilePath_Click;
      // 
      // btnOutputPath
      // 
      btnOutputPath.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      btnOutputPath.Location = new Point(940, 119);
      btnOutputPath.Name = "btnOutputPath";
      btnOutputPath.Size = new Size(30, 30);
      btnOutputPath.TabIndex = 6;
      btnOutputPath.Text = "...";
      btnOutputPath.UseVisualStyleBackColor = true;
      btnOutputPath.Click += btnOutputPath_Click;
      // 
      // txtOutputPath
      // 
      txtOutputPath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      txtOutputPath.Location = new Point(132, 121);
      txtOutputPath.Name = "txtOutputPath";
      txtOutputPath.Size = new Size(802, 27);
      txtOutputPath.TabIndex = 7;
      txtOutputPath.TextChanged += txtOutputPath_TextChanged;
      // 
      // lblFileLocation
      // 
      lblFileLocation.AutoSize = true;
      lblFileLocation.Location = new Point(12, 23);
      lblFileLocation.Name = "lblFileLocation";
      lblFileLocation.Size = new Size(90, 20);
      lblFileLocation.TabIndex = 8;
      lblFileLocation.Text = "File location";
      // 
      // lblOutputPath
      // 
      lblOutputPath.AutoSize = true;
      lblOutputPath.Location = new Point(12, 124);
      lblOutputPath.Name = "lblOutputPath";
      lblOutputPath.Size = new Size(120, 20);
      lblOutputPath.TabIndex = 9;
      lblOutputPath.Text = "Output Directory";
      // 
      // rTxtOutputDialog
      // 
      rTxtOutputDialog.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      rTxtOutputDialog.BackColor = SystemColors.InfoText;
      rTxtOutputDialog.ForeColor = Color.LimeGreen;
      rTxtOutputDialog.Location = new Point(19, 375);
      rTxtOutputDialog.Name = "rTxtOutputDialog";
      rTxtOutputDialog.Size = new Size(951, 222);
      rTxtOutputDialog.TabIndex = 10;
      rTxtOutputDialog.Text = "";
      rTxtOutputDialog.TextChanged += rTxtOutputDialog_TextChanged;
      // 
      // lblDragAndDrop
      // 
      lblDragAndDrop.AllowDrop = true;
      lblDragAndDrop.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      lblDragAndDrop.BackColor = SystemColors.ControlLight;
      lblDragAndDrop.BorderStyle = BorderStyle.Fixed3D;
      lblDragAndDrop.Location = new Point(19, 54);
      lblDragAndDrop.Name = "lblDragAndDrop";
      lblDragAndDrop.Size = new Size(951, 64);
      lblDragAndDrop.TabIndex = 11;
      lblDragAndDrop.Text = "Drag and Drop file area";
      lblDragAndDrop.TextAlign = ContentAlignment.MiddleCenter;
      lblDragAndDrop.DragDrop += lblDragAndDrop_DragDrop;
      lblDragAndDrop.DragEnter += lblDragAndDrop_DragEnter;
      // 
      // splitContainer1
      // 
      splitContainer1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      splitContainer1.Location = new Point(19, 220);
      splitContainer1.Name = "splitContainer1";
      // 
      // splitContainer1.Panel1
      // 
      splitContainer1.Panel1.Controls.Add(groupBox1);
      // 
      // splitContainer1.Panel2
      // 
      splitContainer1.Panel2.Controls.Add(splitContainer2);
      splitContainer1.Size = new Size(951, 149);
      splitContainer1.SplitterDistance = 397;
      splitContainer1.TabIndex = 14;
      // 
      // groupBox1
      // 
      groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      groupBox1.Controls.Add(cBoxAddField);
      groupBox1.Controls.Add(cBoxPreSave);
      groupBox1.Controls.Add(cBoxEdit);
      groupBox1.Controls.Add(cBoxShowRevisions);
      groupBox1.Controls.Add(cBoxExtractSignatures);
      groupBox1.Controls.Add(cBoxFlattenPartial);
      groupBox1.Controls.Add(cBoxSign);
      groupBox1.Controls.Add(cBoxReadonly);
      groupBox1.Controls.Add(cBoxFlatten);
      groupBox1.Controls.Add(cBoxRevise);
      groupBox1.Location = new Point(3, 3);
      groupBox1.Name = "groupBox1";
      groupBox1.Size = new Size(391, 143);
      groupBox1.TabIndex = 15;
      groupBox1.TabStop = false;
      groupBox1.Text = "Modifications";
      // 
      // cBoxPreSave
      // 
      cBoxPreSave.AutoSize = true;
      cBoxPreSave.Checked = true;
      cBoxPreSave.CheckState = CheckState.Checked;
      cBoxPreSave.Location = new Point(12, 26);
      cBoxPreSave.Name = "cBoxPreSave";
      cBoxPreSave.Size = new Size(87, 24);
      cBoxPreSave.TabIndex = 12;
      cBoxPreSave.Text = "Pre-save";
      cBoxPreSave.UseVisualStyleBackColor = true;
      // 
      // cBoxEdit
      // 
      cBoxEdit.AutoSize = true;
      cBoxEdit.Checked = true;
      cBoxEdit.CheckState = CheckState.Checked;
      cBoxEdit.Location = new Point(108, 26);
      cBoxEdit.Name = "cBoxEdit";
      cBoxEdit.Size = new Size(57, 24);
      cBoxEdit.TabIndex = 11;
      cBoxEdit.Text = "Edit";
      cBoxEdit.UseVisualStyleBackColor = true;
      // 
      // cBoxShowRevisions
      // 
      cBoxShowRevisions.AutoSize = true;
      cBoxShowRevisions.Location = new Point(108, 56);
      cBoxShowRevisions.Name = "cBoxShowRevisions";
      cBoxShowRevisions.Size = new Size(132, 24);
      cBoxShowRevisions.TabIndex = 10;
      cBoxShowRevisions.Text = "Show Revisions";
      cBoxShowRevisions.UseVisualStyleBackColor = true;
      // 
      // cBoxExtractSignatures
      // 
      cBoxExtractSignatures.AutoSize = true;
      cBoxExtractSignatures.Location = new Point(108, 83);
      cBoxExtractSignatures.Name = "cBoxExtractSignatures";
      cBoxExtractSignatures.Size = new Size(112, 24);
      cBoxExtractSignatures.TabIndex = 9;
      cBoxExtractSignatures.Text = "Extract Sign.";
      cBoxExtractSignatures.UseVisualStyleBackColor = true;
      // 
      // cBoxFlattenPartial
      // 
      cBoxFlattenPartial.AutoSize = true;
      cBoxFlattenPartial.Location = new Point(108, 113);
      cBoxFlattenPartial.Name = "cBoxFlattenPartial";
      cBoxFlattenPartial.Size = new Size(118, 24);
      cBoxFlattenPartial.TabIndex = 8;
      cBoxFlattenPartial.Text = "Flatten (Part.)";
      cBoxFlattenPartial.UseVisualStyleBackColor = true;
      // 
      // cBoxSign
      // 
      cBoxSign.AutoSize = true;
      cBoxSign.Location = new Point(12, 86);
      cBoxSign.Name = "cBoxSign";
      cBoxSign.Size = new Size(60, 24);
      cBoxSign.TabIndex = 7;
      cBoxSign.Text = "Sign";
      cBoxSign.UseVisualStyleBackColor = true;
      // 
      // splitContainer2
      // 
      splitContainer2.Dock = DockStyle.Fill;
      splitContainer2.Location = new Point(0, 0);
      splitContainer2.Name = "splitContainer2";
      // 
      // splitContainer2.Panel1
      // 
      splitContainer2.Panel1.Controls.Add(groupBox2);
      // 
      // splitContainer2.Panel2
      // 
      splitContainer2.Panel2.Controls.Add(btnProcess);
      splitContainer2.Size = new Size(550, 149);
      splitContainer2.SplitterDistance = 321;
      splitContainer2.TabIndex = 0;
      // 
      // groupBox2
      // 
      groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      groupBox2.Controls.Add(cBoxConvertHtml);
      groupBox2.Controls.Add(cBoxExportFieldsCsv);
      groupBox2.Controls.Add(cBoxReadFields);
      groupBox2.Location = new Point(3, 3);
      groupBox2.Name = "groupBox2";
      groupBox2.Size = new Size(315, 143);
      groupBox2.TabIndex = 15;
      groupBox2.TabStop = false;
      groupBox2.Text = "Output Options";
      // 
      // cBoxConvertHtml
      // 
      cBoxConvertHtml.AutoSize = true;
      cBoxConvertHtml.Location = new Point(6, 86);
      cBoxConvertHtml.Name = "cBoxConvertHtml";
      cBoxConvertHtml.Size = new Size(141, 24);
      cBoxConvertHtml.TabIndex = 6;
      cBoxConvertHtml.Text = "Html Conversion";
      cBoxConvertHtml.UseVisualStyleBackColor = true;
      // 
      // cBoxExportFieldsCsv
      // 
      cBoxExportFieldsCsv.AutoSize = true;
      cBoxExportFieldsCsv.Location = new Point(6, 56);
      cBoxExportFieldsCsv.Name = "cBoxExportFieldsCsv";
      cBoxExportFieldsCsv.Size = new Size(150, 24);
      cBoxExportFieldsCsv.TabIndex = 5;
      cBoxExportFieldsCsv.Text = "Export Fields (csv)";
      cBoxExportFieldsCsv.UseVisualStyleBackColor = true;
      // 
      // panel1
      // 
      panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      panel1.Controls.Add(gBoxLibraries);
      panel1.Location = new Point(19, 154);
      panel1.Name = "panel1";
      panel1.Size = new Size(951, 63);
      panel1.TabIndex = 15;
      // 
      // gBoxLibraries
      // 
      gBoxLibraries.Controls.Add(rBtnIText);
      gBoxLibraries.Controls.Add(rBtnIronPDF);
      gBoxLibraries.Location = new Point(3, 3);
      gBoxLibraries.Name = "gBoxLibraries";
      gBoxLibraries.Size = new Size(582, 57);
      gBoxLibraries.TabIndex = 0;
      gBoxLibraries.TabStop = false;
      gBoxLibraries.Text = "Libraries";
      // 
      // rBtnIText
      // 
      rBtnIText.AutoSize = true;
      rBtnIText.Enabled = false;
      rBtnIText.Location = new Point(100, 25);
      rBtnIText.Name = "rBtnIText";
      rBtnIText.Size = new Size(61, 24);
      rBtnIText.TabIndex = 1;
      rBtnIText.Text = "IText";
      rBtnIText.UseVisualStyleBackColor = true;
      // 
      // rBtnIronPDF
      // 
      rBtnIronPDF.AutoSize = true;
      rBtnIronPDF.Checked = true;
      rBtnIronPDF.Location = new Point(12, 25);
      rBtnIronPDF.Name = "rBtnIronPDF";
      rBtnIronPDF.Size = new Size(82, 24);
      rBtnIronPDF.TabIndex = 0;
      rBtnIronPDF.TabStop = true;
      rBtnIronPDF.Text = "IronPDF";
      rBtnIronPDF.UseVisualStyleBackColor = true;
      // 
      // cBoxAddField
      // 
      cBoxAddField.AutoSize = true;
      cBoxAddField.Location = new Point(246, 56);
      cBoxAddField.Name = "cBoxAddField";
      cBoxAddField.Size = new Size(95, 24);
      cBoxAddField.TabIndex = 13;
      cBoxAddField.Text = "Add Field";
      cBoxAddField.UseVisualStyleBackColor = true;
      // 
      // MainForm
      // 
      AllowDrop = true;
      AutoScaleDimensions = new SizeF(8F, 20F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(982, 609);
      Controls.Add(panel1);
      Controls.Add(splitContainer1);
      Controls.Add(lblDragAndDrop);
      Controls.Add(rTxtOutputDialog);
      Controls.Add(lblOutputPath);
      Controls.Add(lblFileLocation);
      Controls.Add(txtOutputPath);
      Controls.Add(btnOutputPath);
      Controls.Add(btnFilePath);
      Controls.Add(txtFilePath);
      MinimumSize = new Size(1000, 500);
      Name = "MainForm";
      StartPosition = FormStartPosition.CenterScreen;
      Text = "PeeDeeEff Magic";
      Load += MainForm_Load;
      splitContainer1.Panel1.ResumeLayout(false);
      splitContainer1.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
      splitContainer1.ResumeLayout(false);
      groupBox1.ResumeLayout(false);
      groupBox1.PerformLayout();
      splitContainer2.Panel1.ResumeLayout(false);
      splitContainer2.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
      splitContainer2.ResumeLayout(false);
      groupBox2.ResumeLayout(false);
      groupBox2.PerformLayout();
      panel1.ResumeLayout(false);
      gBoxLibraries.ResumeLayout(false);
      gBoxLibraries.PerformLayout();
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private TextBox txtFilePath;
    private Button btnProcess;
    private CheckBox cBoxFlatten;
    private Button btnFilePath;
    private Button btnOutputPath;
    private TextBox txtOutputPath;
    private Label lblFileLocation;
    private Label lblOutputPath;
    private RichTextBox rTxtOutputDialog;
    private CheckBox cBoxReadFields;
    private Label lblDragAndDrop;
    private CheckBox cBoxReadonly;
    private CheckBox cBoxRevise;
    private SplitContainer splitContainer1;
    private SplitContainer splitContainer2;
    private CheckBox cBoxExportFieldsCsv;
    private CheckBox cBoxSign;
    private CheckBox cBoxFlattenPartial;
    private GroupBox groupBox1;
    private GroupBox groupBox2;
    private CheckBox cBoxExtractSignatures;
    private CheckBox cBoxShowRevisions;
    private Panel panel1;
    private GroupBox gBoxLibraries;
    private RadioButton rBtnIronPDF;
    private CheckBox cBoxEdit;
    private CheckBox cBoxConvertHtml;
    private RadioButton rBtnIText;
    private CheckBox cBoxPreSave;
    private CheckBox cBoxAddField;
  }
}
