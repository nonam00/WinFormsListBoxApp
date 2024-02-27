using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsListBoxApp
{
    public partial class EditForm : Form
    {
        public string cityString { get; set; } = string.Empty;
        public EditForm(string cityEdit)
        {
            InitializeComponent();
            txtEdit.Text = cityEdit;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            cityString = txtEdit.Text;
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
