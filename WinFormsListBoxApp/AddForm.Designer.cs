namespace WinFormsListBoxApp
{
	partial class AddForm
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
			saveButton = new Button();
			cancelButton = new Button();
			textBox1 = new TextBox();
			SuspendLayout();
			// 
			// saveButton
			// 
			saveButton.Location = new Point(97, 172);
			saveButton.Name = "saveButton";
			saveButton.Size = new Size(123, 36);
			saveButton.TabIndex = 0;
			saveButton.Text = "Save";
			saveButton.UseVisualStyleBackColor = true;
			saveButton.Click += saveButton_Click;
			// 
			// cancelButton
			// 
			cancelButton.Location = new Point(298, 172);
			cancelButton.Name = "cancelButton";
			cancelButton.Size = new Size(125, 36);
			cancelButton.TabIndex = 1;
			cancelButton.Text = "Cancel";
			cancelButton.UseVisualStyleBackColor = true;
			cancelButton.Click += cancelButton_Click;
			// 
			// textBox1
			// 
			textBox1.Location = new Point(97, 111);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(326, 23);
			textBox1.TabIndex = 2;
			// 
			// AddForm
			// 
			AcceptButton = saveButton;
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			CancelButton = cancelButton;
			ClientSize = new Size(527, 326);
			Controls.Add(textBox1);
			Controls.Add(cancelButton);
			Controls.Add(saveButton);
			Name = "AddForm";
			Text = "AddForm";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button saveButton;
		private Button cancelButton;
		private TextBox textBox1;
	}
}