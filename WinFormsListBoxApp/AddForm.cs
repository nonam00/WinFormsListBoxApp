namespace WinFormsListBoxApp
{
	public partial class AddForm : Form
	{
		public string countryString {  get; set; }
		public AddForm()
		{
			InitializeComponent();
		}

		private void saveButton_Click(object sender, EventArgs e)
		{
			if (textBox1.Text.Trim().Length > 0)
			{
				countryString = textBox1.Text.Trim();
				DialogResult = DialogResult.OK;
				Close();
			}
		}

		private void cancelButton_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}
	}
}
