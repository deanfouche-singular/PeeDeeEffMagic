namespace PeeDeeEffMagic.Popup
{
  using System.Windows.Forms;

  public partial class AddNewFieldForm : Form
  {
    public AddNewFieldForm(int pages)
    {
      InitializeComponent();
      this.SetFieldType("Text");
      this.PopulatePageNos(pages);
    }

    public string FieldName { get; private set; }

    public string FieldType { get; private set; }

    public uint PageIndex { get; private set; }

    public (double, double) FieldPos { get; private set; }

    public double FieldWidth { get; private set; }

    public double FieldHeight { get; private set; }

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
        this.txtWidth.Text = "100";
        this.txtHeight.Text = "14.5";
      }
    }

    private void rBtnCheckBox_CheckedChanged(object sender, EventArgs e)
    {
      if (rBtnCheckBox.Checked)
      {
        SetFieldType("CheckBox");
        this.txtWidth.Text = "10";
        this.txtHeight.Text = "10";
      }
    }

    private void rBtnSignature_CheckedChanged(object sender, EventArgs e)
    {
      if (rBtnSignature.Checked)
      {
        SetFieldType("Signature");
        this.txtWidth.Text = "100";
        this.txtHeight.Text = "14.5";
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
