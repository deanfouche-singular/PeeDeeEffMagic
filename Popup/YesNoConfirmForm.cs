namespace PeeDeeEffMagic.Popup
{
  using System.Windows.Forms;

  public partial class YesNoConfirmForm : Form
  {
    public YesNoConfirmForm(string title, string description, string confirm, string cancel)
    {
      InitializeComponent();
      this.Text = title;
      this.lblDescription.Text = description;
      this.btnOK.Text = confirm;
      this.btnCancel.Text = cancel;
    }

    private void btnOK_Click(object sender, EventArgs e)
    {
      this.DialogResult = DialogResult.OK;
      this.Close();
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
      this.DialogResult = DialogResult.Cancel;
      this.Close();
    }
  }
}
