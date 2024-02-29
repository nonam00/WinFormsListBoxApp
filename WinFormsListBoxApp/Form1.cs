namespace WinFormsListBoxApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.AcceptButton = buttonAdd;

            listBox1.Items.AddRange(new string[] { "Russia", "China" });
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            using(AddForm addForm = new AddForm())
            {
                var result = addForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    listBox1.Items.Add(addForm.countryString);
                }
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
                    editForm.countryString = listBox1.SelectedItem.ToString()!;

                    var result = editForm.ShowDialog();
                    if(result == DialogResult.OK)
                    {
                        //listBox1.SelectedItem = editForm.cityString;
                        listBox1.Items[listBox1.SelectedIndex] = editForm.countryString;
                    }
                }
            }
        }
    }
}