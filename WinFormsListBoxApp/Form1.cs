namespace WinFormsListBoxApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.AcceptButton = buttonAdd;

            labelCity.Text = String.Empty;

            listBox1.Items.AddRange(new string[] { "Moscow", "Tula" });
            cmbCities.Items.AddRange(new string[] { "Moscow", "Tula" });
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if(inputText.Text.Trim().Length > 0)
            {
                listBox1.Items.Add(inputText.Text.Trim());
                inputText.Text = String.Empty;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelCity.Text = listBox1.SelectedItem.ToString();
        }

        private void buttonInsert_Click_1(object sender, EventArgs e)
        {
            if (inputText.Text.Trim().Length > 0)
            {
                int index = listBox1.SelectedIndex;
                listBox1.Items.Insert(index + 1, inputText.Text.Trim());
                listBox1.SelectedIndex = index + 1;
                inputText.Text = String.Empty;
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedItem is not null)
            {
                int index = listBox1.SelectedIndex;
                listBox1.Items.RemoveAt(index);

                if(index >= listBox1.Items.Count)
                {
                    listBox1.SelectedIndex = listBox1.Items.Count - 1;
                }
                else
                {
                    listBox1.SelectedIndex = index;
                }
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedItem is not null)
            {
                using (EditForm editForm = new EditForm(listBox1.SelectedItem.ToString()!))
                {
                    editForm.cityString = listBox1.SelectedItem.ToString()!;

                    var result = editForm.ShowDialog();
                    if(result == DialogResult.OK)
                    {
                        //listBox1.SelectedItem = editForm.cityString;
                        listBox1.Items[listBox1.SelectedIndex-1] = editForm.cityString;
                    }
                }
            }
        }
    }
}