namespace PeeDeeEffMagic
{
  using System.Text;
  using IronPdf.Rendering;
  using IronPdf.Signing;
  using IronSoftware.Forms;
  using IronSoftware.Pdfium;
  using Newtonsoft.Json;
  using PeeDeeEffMagic.Popup;

  public partial class MainForm : Form
  {
    public MainForm()
    {
      InitializeComponent();

      // Place at the top of your code, prior to running any other IronPdf methods
      //IronPdf.Logging.Logger.LogFilePath = "C:\\Clients\\Logs\\PeeDeeEffMagic.log";
      //IronPdf.Logging.Logger.LoggingMode = IronPdf.Logging.Logger.LoggingModes.All;
    }

    #region Form Variables

    private string filePath;
    private string outputPath;
    private PdfSignature? signature;
    private PdfDocument? document;

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

    /// <summary>
    /// The main process button click event.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btnProcess_Click(object sender, EventArgs e)
    {
      this.filePath = txtFilePath.Text;

      if (string.IsNullOrEmpty(this.filePath) || string.IsNullOrEmpty(this.outputPath))
      {
        MessageBox.Show("Please select a file and output path.", "Invalid File/Output Path");
        this.WriteSectionBreak();
        this.WriteToOutput("Invalid input file or output path. Ending process...");
        return;
      }

      var fileInfo = new FileInfo(this.filePath);

      if (this.filePath.Contains("http"))
      {
        this.document = new PdfDocument(PdfUri: new Uri(this.filePath), TrackChanges: ChangeTrackingModes.EnableChangeTracking);
      }
      else
      {
        if (!fileInfo.Exists)
        {
          MessageBox.Show("File does not exist.", "File Not Found");
          this.WriteSectionBreak();
          this.WriteToOutput("File does not exist. Ending process...");
          return;
        }

        this.document = new PdfDocument(PdfFilePath: this.filePath, TrackChanges: ChangeTrackingModes.EnableChangeTracking);
      }

      var mods = string.Empty;

      if (cBoxPreSave.Checked)
      {
        var preSaveOutputFilePath = Path.Combine(outputPath, $"{Path.GetFileNameWithoutExtension(this.filePath)}_PreSaved.pdf");

        this.filePath = preSaveOutputFilePath;

        this.document = this.document.SaveAsRevision();
        this.document = this.document.SaveAs(preSaveOutputFilePath, SaveAsRevision: false);

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

      if (this.document == null)
      {
        MessageBox.Show("File could not be opened.", "File Not Found");
        this.WriteSectionBreak();
        this.WriteToOutput("File could not be opened. Ending process...");
        return;
      }

      if (cBoxAddField.Checked)
      {
        var fieldsAdded = false;
        var signatureAdded = false;
        var existingCheckbox = this.document.Form.FirstOrDefault(formField => formField.Type == PdfFormFieldType.Checkbox);
        double? cBoxHeight = existingCheckbox != null ? existingCheckbox.Height : null;
        double? cBoxWidth = existingCheckbox != null ? existingCheckbox.Width : null;

        var addMoreFields = true;

        while (addMoreFields)
        {
          using (AddNewFieldForm addFieldForm = new AddNewFieldForm(this.document.PageCount,
                                                                    cBoxHeight: cBoxHeight,
                                                                    cBoxWidth: cBoxWidth,
                                                                    alreadySigned: signatureAdded))
          {
            if (addFieldForm.ShowDialog() == DialogResult.OK)
            {
              var fieldName = addFieldForm.FieldName;
              var fieldValue = "Yes"; // addFieldForm.FieldValue;
              var fieldType = addFieldForm.FieldType;
              var pageIndex = addFieldForm.PageIndex;
              var fieldPos = addFieldForm.FieldPos;
              var height = addFieldForm.FieldHeight;
              var width = addFieldForm.FieldWidth;

              if (fieldType == "Text")
              {
                var textField = new TextFormField(fieldName, fieldValue, pageIndex, fieldPos.Item1, fieldPos.Item2, width, height);
                this.document.Form.Add(textField);
              }
              else if (fieldType == "CheckBox")
              {
                var checkboxField = new CheckboxFormField(fieldName, fieldValue == "Yes" ? fieldValue : "Off", pageIndex, fieldPos.Item1, fieldPos.Item2, width, height);

                checkboxField.DefaultAppearance = existingCheckbox != null ? existingCheckbox.DefaultAppearance : "";
                this.document.Form.Add(checkboxField);
              }
              else if (fieldType == "Signature")
              {
                signatureAdded = true;
                cBoxSign.Checked = true;

                this.signature = new PdfSignature($"C:\\Users\\DFouche\\Documents\\Personal Docs\\Coding Exercises and tings\\MySignature.pfx",
                                           "bZQBjzHlm77YfhxuF6M2");

                // Add granular information
                this.signature.SignatureDate = DateTime.Now;
                this.signature.SigningContact = "Dean Fouche";
                this.signature.SigningLocation = "Johannesburg";
                this.signature.SigningReason = "Liberty Demo";
                this.signature.TimestampHashAlgorithm = TimestampHashAlgorithms.SHA256;
                this.signature.TimeStampUrl = "http://timestamp.digicert.com";
                this.signature.SignatureImage = new PdfSignatureImage($"C:\\Users\\DFouche\\Documents\\Personal Docs\\Coding Exercises and tings\\Signature.png",
                                                                 (int)pageIndex,
                                                                 new Rectangle((int)fieldPos.Item1, (int)fieldPos.Item2, 100, 60));

                //var signatureField = new SignatureFormField(fieldName, pageIndex, fieldPos.Item1, fieldPos.Item2, width, height);
                //this.document1.Form.Add(signatureField);
              }

              fieldsAdded = true;
            }
          }

          using (YesNoConfirmForm confirmForm = new YesNoConfirmForm("Add More Fields", "Do you want to add more fields?", "Yes", "No"))
          {
            if (confirmForm.ShowDialog() == DialogResult.OK)
            {
              addMoreFields = true;
            }
            else
            {
              addMoreFields = false;
            }
          }
        }

        if (fieldsAdded)
        {
          mods = $"{mods}_CustomFieldIron";
        }
      }

      if (cBoxEdit.Checked)
      {
        this.WriteSectionBreak();
        this.WriteToOutput("Editing form fields...");

        List<string> allFieldNames = [];

        foreach (var field in this.document.Form)
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
          var fieldToEdit = this.document.Form.FindFormField(fieldName);
          if (fieldToEdit != null)
          {
            if (fieldToEdit.Type == PdfFormFieldType.Textfield)
            {
              using (TextInputForm textInput = new TextInputForm(fieldName, fieldToEdit.Value))
              {
                if (textInput.ShowDialog() == DialogResult.OK)
                {
                  var fieldValue = textInput.FieldValue;
                  this.WriteToOutput($"Field: {fieldName} - Value: {fieldValue}");
                  var field = this.document.Form.FindFormField(fieldName);
                  field.Value = fieldValue;
                }
              }
            }
            else if (fieldToEdit.Type == PdfFormFieldType.Checkbox)
            {
              using (CheckBoxInputForm checkBoxInput = new CheckBoxInputForm(fieldName, fieldToEdit.Value))
              {
                if (checkBoxInput.ShowDialog() == DialogResult.OK)
                {
                  var fieldValue = checkBoxInput.FieldValue;
                  this.WriteToOutput($"Field: {fieldName} - Value: {fieldValue}");
                  var field = this.document.Form.FindFormField(fieldName);
                  field.Value = fieldValue;
                }
              }
            }
            //else if (fieldToEdit.Type == PdfFormFieldType.Signature)
            //{
            //  using (CheckBoxInputForm checkBoxInput = new CheckBoxInputForm(fieldName, "Off"))
            //  {
            //    if (checkBoxInput.ShowDialog() == DialogResult.OK)
            //    {
            //      var fieldValue = checkBoxInput.FieldValue;
            //      this.WriteToOutput($"Field: {fieldName} - Sign (Y/N): {(fieldValue == "Yes" ? fieldValue : "No")}");
            //      cBoxSign.Checked = fieldValue == "Yes";
            //      //var field = this.document1.Form.FindFormField(fieldName);
            //      //field.Value = fieldValue;
            //    }
            //  }
            //}
          }
        }

        mods = $"{mods}_CustomEditIron";
      }

      if (cBoxFlatten.Checked)
      {
        this.WriteSectionBreak();

        this.WriteToOutput("Flattening form fields...");
        this.document.Flatten();
        mods = $"{mods}_FlatIron";
      }

      if (cBoxFlattenPartial.Checked)
      {
        // TODO: expand to allow user to select which pages to flatten
        PdfDocument flattenedPages = this.document.CopyPage(0);
        PdfDocument unchangedPages = this.document.CopyPages([1, 2, 3]);

        flattenedPages.Flatten();

        this.document = PdfDocument.Merge(flattenedPages, unchangedPages);
        mods = $"{mods}_PartialFlatIron";
      }

      if (cBoxExportFieldsCsv.Checked)
      {
        this.WriteSectionBreak();
        this.WriteToOutput("Exporting form fields to CSV...");
        this.ExportToCsv(this.document);
      }

      if (cBoxReadFields.Checked)
      {
        this.WriteSectionBreak();
        this.WriteToOutput("Reading form fields...");
        this.WriteFieldsToOutput(this.document);
      }

      if (cBoxReadonly.Checked)
      {
        this.WriteSectionBreak();
        this.WriteToOutput("Custom flattening form fields...");

        List<string> allFieldNames = [];

        foreach (var field in this.document.Form)
        {
          allFieldNames.Add(field.Name);
        }

        string[] fieldsToFlatten = [];

        using (FieldSelectorForm fieldSelector = new FieldSelectorForm("Set as readonly", allFieldNames.ToArray()))
        {
          if (fieldSelector.ShowDialog() == DialogResult.OK)
          {
            fieldsToFlatten = fieldSelector.SelectedFields;
            this.WriteToOutput($"Fields selected for readonly: {string.Join(", ", fieldsToFlatten)}");
          }
        }

        this.SetFieldsToReadonly(this.document, fieldsToFlatten);
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

      if (cBoxExtractSignatures.Checked)
      {
        var signatures = this.document.GetVerifiedSignatures();
        var revisedSignatures = this.document.GetVerifiedSignatures();

        if (signatures != null && signatures.Count > 0)
        {
          this.WriteToOutput("Signatures found in document: ");
          foreach (var signature in signatures)
          {
            this.WriteToOutput($"Signature: {signature.SignatureName} - {signature.SigningContact} - {signature.SigningDate}");
            this.WriteToOutput($"Location: {signature.SigningLocation}");
            this.WriteToOutput($"Reason: {signature.SigningReason}");
          }
        }
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
          this.document = this.document.SaveAsRevision(outputFilePath);

          this.WriteToOutput($"File saved as revision. File is at version: {this.document}");
        }

        if (cBoxConvertHtml.Checked)
        {
          var htmlFormatOptions = new HtmlFormatOptions();
          var documentHtmlString = this.document.ToHtmlString(fullContentWidth: true);
          var renderer = new ChromePdfRenderer();
          var htmlDocument = renderer.RenderHtmlAsPdf(documentHtmlString);

          var htmlPdfOutputPath = Path.Combine(outputFilePath, $"{fileInfo.Name.Replace(".pdf", "")}ConvertedFromHtml.pdf");

          this.WriteToOutput($"Saving html version of file to {outputFilePath}");

          htmlDocument.SaveAs(htmlPdfOutputPath);
          this.WriteToOutput("File saved.");
        }

        this.WriteToOutput($"Saving file to {outputFilePath}");

        this.document.SaveAs(outputFilePath, SaveAsRevision: false);
        this.WriteToOutput("File saved.");

        if (cBoxSign.Checked)
        {
          if (this.signature != null)
          {
            // Sign and save PDF document
            var digitalSignatureOutputPath = Path.Combine(outputFilePath, $"{fileInfo.Name.Replace(".pdf", "")}_digitallySigned{this.document}.pdf");

            this.document.SaveAs(digitalSignatureOutputPath, SaveAsRevision: false);

            this.signature.SignPdfFile(digitalSignatureOutputPath);

            this.signature = null;
          }
          else
          {
            this.document.SignWithFile($"C:\\Users\\DFouche\\Documents\\Personal Docs\\Coding Exercises and tings\\MySignature.pfx",
                                  "bZQBjzHlm77YfhxuF6M2",
                                  null,
                                  SignaturePermissions.AdditionalSignaturesAndFormFillingAllowed);

            var revisionOutputPath = Path.Combine(outputFilePath, $"{fileInfo.Name.Replace(".pdf", "")}_revision{this.document}.pdf");

            var signedPdf = this.document.SaveAsRevision(outputFilePath);

            signedPdf.SaveAs(outputFilePath, SaveAsRevision: false);
          }
        }

        this.document.Dispose();
        this.document = null;
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

    private void SetFieldsToReadonly(PdfDocument document, string[] fieldNames)
    {
      var font = this.document.Fonts.FirstOrDefault(font => font.Name.Contains("Arial") && font.Name.Contains("Bold") && font.Name.Contains("Italic"));
      var fontSize = font != null ? font.FontSize : 12;

      if (this.document.Form.Count > 0)
      {
        if (cBoxReadFields.Checked)
        {
          this.WriteSectionBreak();
          this.WriteToOutput("Reading form fields...");
        }

        foreach (var field in this.document.Form)
        {
          if (cBoxReadonly.Checked && Array.Exists(fieldNames, f => f == field.Name))
          {
            if (field.ReadOnly)
            {
              this.WriteToOutput($"Field: {field.Name} with value: {field.Value} is already set to readonly.");
            }
            else
            {
              field.ReadOnly = true;
              this.WriteToOutput($"Field: {field.Name} with value: {field.Value} has now been set to readonly.");
            }
          }
        }
      }
      else
      {
        this.WriteToOutput("No form fields found.");
      }
    }

    private void ReplaceFieldsWithDrawnText(PdfDocument document, string[] fieldNames)
    {
      var font = this.document.Fonts.FirstOrDefault(font => font.Name.Contains("Arial") && font.Name.Contains("Bold") && font.Name.Contains("Italic"));
      var fontSize = font != null ? font.FontSize : 12;

      if (this.document.Form.Count > 0)
      {
        if (cBoxReadFields.Checked)
        {
          this.WriteSectionBreak();
          this.WriteToOutput("Reading form fields...");
        }

        foreach (var fieldName in fieldNames)
        {
          var field = this.document.Form.FindFormField(fieldName);

          if (field != null)
          {
            // Get the field's value
            string fieldValue = field.Value;
            string utf8Value = Encoding.UTF8.GetString(Encoding.UTF8.GetBytes(fieldValue));

            // Create a text annotation at the same position (as a workaround)
            this.document.DrawText(fieldValue, font, FontSize: fontSize, PageIndex: (int)field.PageIndex, X: field.X, Y: field.Y, Color: Color.Black, Rotation: 0.0);
            this.document.Form.Remove(field);

            this.WriteToOutput($"Replacing field: {field.Name} with drawn text value: {field.Value}.");
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
      var form = this.document.Form;
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
      var form = this.document.Form;
      var csv = $"Field Name,Value,Type,ReadOnly,Page No,X Pos,Y Pos{Environment.NewLine}";
      if (form.Count > 0)
      {
        foreach (var field in form)
        {
          csv += $"\"{field.Name}\",{(string.IsNullOrWhiteSpace(field.Value) ? "Empty Value" : $"\"{field.Value}\"")},{field.Type},{field.ReadOnly},{field.PageIndex + 1},\"X-{field.X}\",\"Y-{field.Y}\"{Environment.NewLine}";
        }

        var csvPath = Path.Combine(this.outputPath, $"{Path.GetFileNameWithoutExtension(this.filePath)}_fields.csv");

        File.WriteAllText(csvPath, csv);
      }
    }

    private void ExportUniqueToJson(PdfDocument document)
    {
      var form = this.document.Form;
      var fieldTypes = new List<PdfFormFieldType>();
      var json = $"{{\"UniqueFields\": [";
      if (form.Count > 0)
      {
        foreach (var field in form)
        {
          if (!fieldTypes.Contains(field.Type))
          {
            fieldTypes.Add(field.Type);
            json += $"{JsonConvert.SerializeObject(field)},";
          }
        }

        json += $"]}}";

        var jsonPath = Path.Combine(this.outputPath, $"{Path.GetFileNameWithoutExtension(this.filePath)}_uniqueFields.json");

        File.WriteAllText(jsonPath, json);
      }
    }

    #endregion
  }
}
