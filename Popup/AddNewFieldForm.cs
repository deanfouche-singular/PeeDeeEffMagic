namespace PeeDeeEffMagic.Popup
{
  using System.Windows.Forms;

  public partial class AddNewFieldForm : Form
  {
    public AddNewFieldForm(int pages, double? txtHeight = null, double? txtWidth = null, double? cBoxHeight = null, double? cBoxWidth = null, bool alreadySigned = false)
    {
      InitializeComponent();
      this.SetFieldType("Text");
      this.PopulatePageNos(pages);

      this.DefaultTextWidth = txtWidth ?? 100;
      this.DefaultTextHeight = txtHeight ?? 14.5;
      this.DefaultCheckboxWidth = cBoxWidth ?? 10;
      this.DefaultCheckboxHeight = cBoxHeight ?? 10;

      this.rBtnSignature.Enabled = !alreadySigned;
    }

    public string FieldName { get; private set; }

    public string FieldType { get; private set; }

    public uint PageIndex { get; private set; }

    public (double, double) FieldPos { get; private set; }

    public double FieldWidth { get; private set; }

    public double FieldHeight { get; private set; }

    private double DefaultTextWidth { get; set; }

    private double DefaultTextHeight { get; set; }

    private double DefaultCheckboxWidth { get; set; }

    private double DefaultCheckboxHeight { get; set; }

    #region Modifiers

    private void SetFieldType(string fieldType)
    {
      FieldType = fieldType;
    }

    private void PopulatePageNos(int pages)
    {
      for (var i = 1; i <= pages; i++)
      {
        this.cboBoxPages.Items.Add(i);
      }
    }

    #endregion

    #region Event handlers

    private void rBtnText_CheckedChanged(object sender, EventArgs e)
    {
      if (rBtnText.Checked)
      {
        SetFieldType("Text");
        this.txtWidth.Text = $"{this.DefaultTextWidth}";
        this.txtHeight.Text = $"{this.DefaultTextHeight}";
      }
    }

    private void rBtnCheckBox_CheckedChanged(object sender, EventArgs e)
    {
      if (rBtnCheckBox.Checked)
      {
        SetFieldType("CheckBox");
        this.txtWidth.Text = $"{this.DefaultCheckboxWidth}";
        this.txtHeight.Text = $"{this.DefaultCheckboxHeight}";
      }
    }

    private void rBtnSignature_CheckedChanged(object sender, EventArgs e)
    {
      if (rBtnSignature.Checked)
      {
        SetFieldType("Signature");
        this.txtWidth.Text = $"{this.DefaultTextWidth}";
        this.txtHeight.Text = $"{this.DefaultTextHeight}";
      }
    }

    private void txtXPos_TextChanged(object sender, EventArgs e)
    {
      if (double.TryParse(txtXPos.Text, out double x))
      {
        FieldPos = (x, FieldPos.Item2);
      }
    }

    private void txtYPos_TextChanged(object sender, EventArgs e)
    {
      if (double.TryParse(txtYPos.Text, out double y))
      {
        FieldPos = (FieldPos.Item1, y);
      }
    }

    private void cboBoxPages_SelectedValueChanged(object sender, EventArgs e)
    {
      if (cboBoxPages.SelectedItem != null && uint.TryParse(cboBoxPages.SelectedItem.ToString(), out uint page))
      {
        this.PageIndex = page - 1;
      }
    }

    #endregion

    #region Button event handlers

    private void btnAdd_Click(object sender, EventArgs e)
    {
      this.FieldName = txtFieldName.Text;

      if (cboBoxPages.SelectedItem != null && uint.TryParse(cboBoxPages.SelectedItem.ToString(), out uint page))
      {
        this.PageIndex = page - 1;
      }

      if (double.TryParse(txtWidth.Text, out double width) && double.TryParse(txtHeight.Text, out double height))
      {
        this.FieldWidth = width;
        this.FieldHeight = height;
      }
      else
      {
        this.FieldWidth = 100;
        this.FieldHeight = 14.5;
      }
      this.DialogResult = DialogResult.OK;
      this.Close();
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
      using (var dialog = new YesNoConfirmForm("Cancel New Field", "Are you sure you want to cancel adding a new field?", "Yes", "No"))
      {
        if (dialog.ShowDialog() == DialogResult.OK)
        {
          this.DialogResult = DialogResult.Cancel;
          this.Close();
        }
      }
    }

    #endregion
  }
}
