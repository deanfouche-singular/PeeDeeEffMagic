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
      this.cBoxFieldValue.Text = fieldValue;
      //this.tTipFieldValue.SetToolTip(this.txtBoxFieldValue, this.txtBoxFieldValue.Text); ;
      //this.ActiveControl = this.txtBoxFieldValue;
    }
  }
}
