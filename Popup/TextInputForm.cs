namespace PeeDeeEffMagic.Popup
{
  using System.Windows.Forms;

  public partial class TextInputForm : Form
  {
    public TextInputForm(string fieldName, string fieldValue)
    {
      InitializeComponent();
      this.Text = $"Edit field: {fieldName}";
      this.lblFieldName.Text = fieldName;
      this.txtBoxFieldValue.Text = fieldValue;
      this.tTipFieldValue.SetToolTip(this.txtBoxFieldValue, this.txtBoxFieldValue.Text);
      this.ActiveControl = this.txtBoxFieldValue;
    }

    public string FieldValue { get; private set; }

    private void txtBoxFieldValue_MouseHover(object sender, EventArgs e)
    {
      this.tTipFieldValue.SetToolTip(this.txtBoxFieldValue, this.txtBoxFieldValue.Text);
      this.tTipFieldValue.Active = true;
    }

    private void txtBoxFieldValue_MouseLeave(object sender, EventArgs e)
    {
      this.tTipFieldValue.Active = false;
    }

    private void btnOK_Click(object sender, EventArgs e)
    {
      this.FieldValue = this.txtBoxFieldValue.Text;
      this.DialogResult = DialogResult.OK;
      this.Close();
    }

    private void txtBoxFieldValue_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter)
      {
        this.btnOK_Click(sender, e);
      }
    }
  }
}
