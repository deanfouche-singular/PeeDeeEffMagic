namespace PeeDeeEffMagic
{
  using IronPdf.Rendering;
  using IronPdf.Signing;
  using IronSoftware.Pdfium;
  using PeeDeeEffMagic.Popup;

  public partial class MainForm : Form
  {
    public MainForm()
    {
      InitializeComponent();

      // Place at the top of your code, prior to running any other IronPdf methods
      IronPdf.Logging.Logger.LogFilePath = "C:\\Clients\\Logs\\PeeDeeEffMagic.log";
      IronPdf.Logging.Logger.LoggingMode = IronPdf.Logging.Logger.LoggingModes.All;
    }

    #region Form Variables

    private string filePath;
    private string outputPath;

    #endregion

    #region Form Events

    private void MainForm_Load(object sender, EventArgs e)
    {
      this.lblDragAndDrop.AllowDrop = true;
      this.filePath = txtFilePath.Text;
      this.outputPath = txtOutputPath.Text;
    }
    private void txtFilePath_TextChanged(object sender, EventArgs e)
    {
      this.filePath = txtFilePath.Text;
    }

    private void txtOutputPath_TextChanged(object sender, EventArgs e)
    {
      this.outputPath = txtOutputPath.Text;
    }

    private void rTxtOutputDialog_TextChanged(object sender, EventArgs e)
    {
      rTxtOutputDialog.SelectionStart = rTxtOutputDialog.Text.Length;
      rTxtOutputDialog.Focus();
    }

    #endregion

    #region Form Controls

    #region Button Click Events
    private void btnFilePath_Click(object sender, EventArgs e)
    {
      OpenFileDialog dialog = new OpenFileDialog();
      dialog.Filter = "PDF Files|*.pdf";
      if (dialog.ShowDialog() == DialogResult.OK)
      {
        txtFilePath.Text = dialog.FileName;

        var fileInfo = new FileInfo(this.filePath);
        if (fileInfo.Exists && string.IsNullOrEmpty(this.outputPath))
        {
          txtOutputPath.Text = Path.GetDirectoryName(dialog.FileName);
        }
      }
    }

    private void btnOutputPath_Click(object sender, EventArgs e)
    {
      FolderBrowserDialog dialog = new FolderBrowserDialog();
      if (dialog.ShowDialog() == DialogResult.OK)
      {
        txtOutputPath.Text = dialog.SelectedPath;
      }
    }

    private void btnProcess_Click(object sender, EventArgs e)
    {
      if (string.IsNullOrEmpty(this.filePath) || string.IsNullOrEmpty(this.outputPath))
      {
        MessageBox.Show("Please select a file and output path.", "Invalid File/Output Path");
        this.WriteSectionBreak();
        this.WriteToOutput("Invalid input file or output path. Ending process...");
        return;
      }

      var fileInfo = new FileInfo(this.filePath);
      if (!fileInfo.Exists)
      {
        MessageBox.Show("File does not exist.", "File Not Found");
        this.WriteSectionBreak();
        this.WriteToOutput("File does not exist. Ending process...");
        return;
      }

      var mods = string.Empty;

      if (cBoxPreSave.Checked)
      {
        PdfDocument preSavedDocument = new PdfDocument(PdfFilePath: this.filePath, TrackChanges: ChangeTrackingModes.EnableChangeTracking);
        var preSaveOutputFilePath = Path.Combine(outputPath, $"{fileInfo.Name.Replace(".pdf", "")}_PreSaved.pdf");

        this.filePath = preSaveOutputFilePath;

        preSavedDocument = preSavedDocument.SaveAsRevision(preSaveOutputFilePath);
        preSavedDocument.SaveAs(preSaveOutputFilePath, SaveAsRevision: false);
        preSavedDocument.Dispose();

        this.WriteToOutput($"File presaved before updates made.");

        var preSavedFileInfo = new FileInfo(this.filePath);
        if (!preSavedFileInfo.Exists)
        {
          MessageBox.Show("File does not exist.", "File Not Found");
          this.WriteSectionBreak();
          this.WriteToOutput("File does not exist. Ending process...");
          return;
        }
      }

      PdfDocument document = new PdfDocument(PdfFilePath: this.filePath, TrackChanges: ChangeTrackingModes.EnableChangeTracking);

      if (cBoxEdit.Checked)
      {
        this.WriteSectionBreak();
        this.WriteToOutput("Editing form fields...");

        List<string> allFieldNames = [];

        foreach (var field in document.Form)
        {
          allFieldNames.Add(field.Name);
        }

        string[] fieldsToEdit = [];

        using (FieldSelectorForm fieldSelector = new FieldSelectorForm("Edit fields", allFieldNames.ToArray()))
        {
          if (fieldSelector.ShowDialog() == DialogResult.OK)
          {
            fieldsToEdit = fieldSelector.SelectedFields;
            this.WriteToOutput($"Fields selected for editing: {string.Join(", ", fieldsToEdit)}");
          }
        }

        foreach (var fieldName in fieldsToEdit)
        {
          var fieldToEdit = document.Form.FindFormField(fieldName);
          if (fieldToEdit != null && fieldToEdit.Type == PdfFormFieldType.Textfield)
          {
            using (TextInputForm textInput = new TextInputForm(fieldName, fieldToEdit.Value))
            {
              if (textInput.ShowDialog() == DialogResult.OK)
              {
                var fieldValue = textInput.FieldValue;
                this.WriteToOutput($"Field: {fieldName} - Value: {fieldValue}");
                var field = document.Form.FindFormField(fieldName);
                field.Value = fieldValue;
              }
            }
          }
        }

        mods = $"{mods}_CustomEditIron";
      }

      if (cBoxFlatten.Checked)
      {
        this.WriteSectionBreak();

        this.WriteToOutput("Flattening form fields...");
        document.Flatten();
        mods = $"{mods}_FlatIron";
      }

      if (cBoxFlattenPartial.Checked)
      {
        // TODO: expand to allow user to select which pages to flatten
        PdfDocument flattenedPages = document.CopyPage(0);
        PdfDocument unchangedPages = document.CopyPages([1, 2, 3]);

        flattenedPages.Flatten();

        document = PdfDocument.Merge(flattenedPages, unchangedPages);
        mods = $"{mods}_PartialFlatIron";
      }

      if (cBoxExportFieldsCsv.Checked)
      {
        this.WriteSectionBreak();
        this.WriteToOutput("Exporting form fields to CSV...");
        this.ExportToCsv(document);
      }

      if (cBoxReadFields.Checked)
      {
        this.WriteSectionBreak();
        this.WriteToOutput("Reading form fields...");
        this.WriteFieldsToOutput(document);
      }

      if (cBoxCustomFlatten.Checked)
      {
        this.WriteSectionBreak();
        this.WriteToOutput("Custom flattening form fields...");

        List<string> allFieldNames = [];

        foreach (var field in document.Form)
        {
          allFieldNames.Add(field.Name);
        }

        string[] fieldsToFlatten = [];

        using (FieldSelectorForm fieldSelector = new FieldSelectorForm("Set as readonly", allFieldNames.ToArray())) // Ensure proper disposal
        {
          if (fieldSelector.ShowDialog() == DialogResult.OK) // Blocks execution until Form2 is closed
          {
            fieldsToFlatten = fieldSelector.SelectedFields; // Retrieve input from Form2
            this.WriteToOutput($"Fields selected for flattening: {string.Join(", ", fieldsToFlatten)}");
          }
        }

        this.FlattenFields(document, fieldsToFlatten);
        mods = $"{mods}_CustomFlatIron";
      }

      if (cBoxRevise.Checked)
      {
        mods = $"{mods}_Revised";
      }

      if (cBoxSign.Checked)
      {
        mods = $"{mods}_Signed";
      }

      if (!string.IsNullOrWhiteSpace(mods))
      {
        var outputFilePath = Path.Combine(outputPath, $"{fileInfo.Name.Replace(".pdf", "")}{mods}.pdf");

        var copyCount = 1;

        var outputFileInfo = new FileInfo(outputFilePath);
        while (outputFileInfo.Exists)
        {
          outputFilePath = Path.Combine(outputPath, $"{outputFilePath.Replace(".pdf", "")} ({copyCount}).pdf");
          outputFileInfo = new FileInfo(outputFilePath);
          copyCount++;
        }

        if (cBoxRevise.Checked)
        {
          //var revisedDocument = document.SaveAsRevision(outputFilePath);
          //document = new PdfDocument(PdfFilePath: outputFilePath, TrackChanges: ChangeTrackingModes.EnableChangeTracking);
          document = document.SaveAsRevision(outputFilePath);

          this.WriteToOutput($"File saved as revision. File is at version: {document}");
        }

        if (cBoxSign.Checked)
        {
          document.SignWithFile($"C:\\Users\\DFouche\\Documents\\Personal Docs\\Coding Exercises and tings\\MySignature.pfx",
                                "bZQBjzHlm77YfhxuF6M2",
                                null,
                                SignaturePermissions.AdditionalSignaturesAndFormFillingAllowed);
        }

        if (cBoxExtractSignatures.Checked)
        {
          var signatures = document.GetVerifiedSignatures();
          var revisedSignatures = document.GetVerifiedSignatures();

          if (signatures != null && signatures.Count > 0)
          {
            this.WriteToOutput("Signatures found in document: ");
            foreach (var signature in signatures)
            {
              this.WriteToOutput($"Signature: {signature.SignatureName} - {signature.SigningContact} - {signature.SigningDate}");
            }
          }
        }

        if (cBoxConvertHtml.Checked)
        {
          var htmlFormatOptions = new HtmlFormatOptions();
          var documentHtmlString = document.ToHtmlString(fullContentWidth: true);
          var renderer = new ChromePdfRenderer();
          var htmlDocument = renderer.RenderHtmlAsPdf(documentHtmlString);

          var htmlPdfOutputPath = Path.Combine(outputFilePath, $"{fileInfo.Name.Replace(".pdf", "")}ConvertedFromHtml.pdf");

          this.WriteToOutput($"Saving html version of file to {outputFilePath}");

          htmlDocument.SaveAs(htmlPdfOutputPath);
          this.WriteToOutput("File saved.");
        }

        this.WriteToOutput($"Saving file to {outputFilePath}");

        document.SaveAs(outputFilePath, SaveAsRevision: false);
        this.WriteToOutput("File saved.");

        document.Dispose();
      }
      else
      {
        this.WriteToOutput("No changes made. No file saved.");
      }

      this.WriteSectionBreak();
      this.WriteToOutput("Process complete.");
    }

    #endregion

    #region Accessibility Events

    private void lblDragAndDrop_DragEnter(object sender, DragEventArgs e)
    {
      e.Effect = DragDropEffects.Copy;
    }

    private void lblDragAndDrop_DragDrop(object sender, DragEventArgs e)
    {
      if (e.Data != null)
      {
        var data = e.Data.GetData(DataFormats.FileDrop);
        if (data != null)
        {
          var fileNames = data as string[];
          if (fileNames != null && fileNames.Length > 0)
          {
            txtFilePath.Text = fileNames[0];
            if (string.IsNullOrEmpty(this.outputPath))
            {
              txtOutputPath.Text = Path.GetDirectoryName(txtFilePath.Text);
            }
          }
        }
      }
    }

    #endregion

    #endregion

    #region User Feedback

    private void WriteToOutput(string message)
    {
      rTxtOutputDialog.AppendText($"{message}{Environment.NewLine}");
    }

    private void WriteSectionBreak()
    {
      rTxtOutputDialog.AppendText($"{Environment.NewLine}----------------------------------------{Environment.NewLine}");
    }

    #endregion

    #region Custom Methods

    private void FlattenFields(PdfDocument document, string[] fieldNames)
    {
      var form = document.Form;
      //var font = document.Fonts.FirstOrDefault(font => font.Name.Contains("Arial") && font.Name.Contains("Bold") && font.Name.Contains("Italic"));
      var font = document.Fonts.FirstOrDefault(font => font.Name.Contains("Arial") && font.Name.Contains("Bold") && font.Name.Contains("Italic"));
      var fontSize = font != null ? font.FontSize : 12;

      if (form.Count > 0)
      {
        if (cBoxReadFields.Checked)
        {
          this.WriteSectionBreak();
          this.WriteToOutput("Reading form fields...");
        }

        foreach (var field in form)
        {
          if (cBoxCustomFlatten.Checked && field.Type == PdfFormFieldType.Textfield && !field.ReadOnly && Array.Exists(fieldNames, f => f == field.Name))
          {
            // Get the field's value
            //string fieldValue = field.Value;
            //string utf8Value = Encoding.UTF8.GetString(Encoding.UTF8.GetBytes(fieldValue));
            //field.Value = string.Empty;

            // Remove the field and replace it with static text
            field.ReadOnly = true;
            this.WriteToOutput($"Flattening field: {field.Name} with value: {field.Value}.");

            // Create a text annotation at the same position (as a workaround)
            //document.DrawText(fieldValue, font, FontSize: fontSize, PageIndex: (int)field.PageIndex, X: field.X, Y: field.Y, Color: Color.Black, Rotation: 0.0);
          }
        }
      }
      else
      {
        this.WriteToOutput("No form fields found.");
      }
    }

    private void WriteFieldsToOutput(PdfDocument document)
    {
      var form = document.Form;
      if (form.Count > 0)
      {
        foreach (var field in form)
        {
          this.WriteToOutput($"Field Name: {field.Name}, Value: {(string.IsNullOrWhiteSpace(field.Value) ? "Empty Value" : field.Value)}");
          this.WriteToOutput($"Type: {field.Type}. Read Only: {field.ReadOnly}");
          this.WriteToOutput($"Page: {field.PageIndex + 1}, Field Position on screen: X-{field.X}, Y-{field.Y}");
          this.WriteToOutput($"----------------------------------------------------------------------------");
        }
      }
      else
      {
        this.WriteToOutput("No form fields found.");
      }
    }

    private void ExportToCsv(PdfDocument document)
    {
      var form = document.Form;
      var csv = $"Field Name,Value,Type,ReadOnly,Page No,X Pos,Y Pos{Environment.NewLine}";
      if (form.Count > 0)
      {
        foreach (var field in form)
        {
          csv += $"{field.Name},{(string.IsNullOrWhiteSpace(field.Value) ? "Empty Value" : field.Value)},{field.Type},{field.ReadOnly},{field.PageIndex + 1},\"X-{field.X}\",\"Y-{field.Y}\"{Environment.NewLine}";
        }

        var csvPath = Path.Combine(this.outputPath, $"{Path.GetFileNameWithoutExtension(this.filePath)}_fields.csv");

        File.WriteAllText(csvPath, csv);
      }
    }

    #endregion
  }
}
