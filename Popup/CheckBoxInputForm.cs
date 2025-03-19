namespace PeeDeeEffMagic.Popup
{
  using System.Windows.Forms;

  public partial class CheckBoxInputForm : Form
  {
    public CheckBoxInputForm(string fieldName, string fieldValue)
    {
      InitializeComponent();
      this.Text = $"Edit field: {fieldName}";
      this.lblFieldName.Text = fieldName;
      this.SetFieldValue(fieldValue);
      //this.tTipFieldValue.SetToolTip(this.txtBoxFieldValue, this.txtBoxFieldValue.Text); ;
      //this.ActiveControl = this.txtBoxFieldValue;
    }

    public string FieldValue { get; private set; }

    private void SetFieldValue(string value)
    {
      if (string.Equals(value, "Yes"))
      {
        this.cBoxFieldValue.Checked = true;
      }
      else
      {
        this.cBoxFieldValue.Checked = false;
      }
    }

    private void SetReturnValue()
    {
      if (this.cBoxFieldValue.Checked)
      {
        this.FieldValue = "Yes";
      }
      else
      {
        this.FieldValue = "Off";
      }
    }

    private void btnOK_Click(object sender, EventArgs e)
    {
      this.SetReturnValue();
      this.DialogResult = DialogResult.OK;
      this.Close();
    }
  }
}
