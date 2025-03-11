namespace PeeDeeEffMagic.Popup
{
  using System.Windows.Forms;

  public partial class FieldSelectorForm : Form
  {
    public FieldSelectorForm(string title, string[] existingFields)
    {
      InitializeComponent();
      this.Text = $"Field Selector: {title}";
      this.lBoxExistingFields.Items.AddRange(existingFields);
    }

    public string[] ExistingFields { get; private set; }
    public string[] SelectedFields { get; private set; }

    private void btnContinue_Click(object sender, EventArgs e)
    {
      this.SelectedFields = new string[lBoxSelectedFields.Items.Count];
      lBoxSelectedFields.Items.CopyTo(this.SelectedFields, 0);
      this.DialogResult = DialogResult.OK;
      this.Close();
    }

    private void btnRight_Click(object sender, EventArgs e)
    {
      var fields = lBoxExistingFields.SelectedItems;
      if (fields != null)
      {
        var total = fields.Count;
        for (var i = 0; i < total; total = fields.Count)
        {
          var field = fields[i];

          if (field != null && lBoxExistingFields.Items.Contains(field))
          {
            lBoxSelectedFields.Items.Add(field);

            lBoxExistingFields.Items.Remove(field);
          }
        }
      }
    }

    private void btnLeft_Click(object sender, EventArgs e)
    {
      var fields = lBoxSelectedFields.SelectedItems;
      if (fields != null)
      {
        var total = fields.Count;
        for (var i = 0; i < total; total = fields.Count)
        {
          var field = fields[i];

          if (field != null && lBoxSelectedFields.Items.Contains(field))
          {
            lBoxExistingFields.Items.Add(field);

            lBoxSelectedFields.Items.Remove(field);
          }
        }
      }
    }
  }
}
