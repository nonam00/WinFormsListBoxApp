namespace WinFormsListBoxApp
{
    partial class EditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			txtEdit = new TextBox();
			saveButton = new Button();
			cancelButton = new Button();
			SuspendLayout();
			// 
			// txtEdit
			// 
			txtEdit.Location = new Point(104, 106);
			txtEdit.Name = "txtEdit";
			txtEdit.Size = new Size(259, 23);
			txtEdit.TabIndex = 0;
			// 
			// saveButton
			// 
			saveButton.Location = new Point(104, 163);
			saveButton.Name = "saveButton";
			saveButton.Size = new Size(102, 37);
			saveButton.TabIndex = 1;
			saveButton.Text = "Save";
			saveButton.UseVisualStyleBackColor = true;
			saveButton.Click += saveButton_Click;
			// 
			// cancelButton
			// 
			cancelButton.Location = new Point(261, 163);
			cancelButton.Name = "cancelButton";
			cancelButton.Size = new Size(102, 37);
			cancelButton.TabIndex = 2;
			cancelButton.Text = "Cancel";
			cancelButton.UseVisualStyleBackColor = true;
			cancelButton.Click += cancelButton_Click;
			// 
			// EditForm
			// 
			AcceptButton = saveButton;
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			CancelButton = cancelButton;
			ClientSize = new Size(478, 308);
			Controls.Add(cancelButton);
			Controls.Add(saveButton);
			Controls.Add(txtEdit);
			Name = "EditForm";
			Text = "EditForm";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox txtEdit;
        private Button saveButton;
        private Button cancelButton;
    }
}