using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
namespace WinFormsListBoxApp
{
    public partial class EditForm : Form
    {
        public string countryString { get; set; } = string.Empty;
        public EditForm(string cityEdit)
        {
            InitializeComponent();
            txtEdit.Text = cityEdit;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if(txtEdit.Text.Trim().Length > 0)
            {
                countryString = txtEdit.Text.Trim();
                this.DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
