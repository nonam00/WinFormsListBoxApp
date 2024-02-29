namespace WinFormsListBoxApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			listBox1 = new ListBox();
			buttonAdd = new Button();
			removeButton = new Button();
			editButton = new Button();
			SuspendLayout();
			// 
			// listBox1
			// 
			listBox1.FormattingEnabled = true;
			listBox1.ItemHeight = 15;
			listBox1.Location = new Point(101, 75);
			listBox1.Name = "listBox1";
			listBox1.Size = new Size(211, 259);
			listBox1.TabIndex = 0;
			// 
			// buttonAdd
			// 
			buttonAdd.Location = new Point(346, 75);
			buttonAdd.Name = "buttonAdd";
			buttonAdd.Size = new Size(75, 23);
			buttonAdd.TabIndex = 1;
			buttonAdd.Text = "Add";
			buttonAdd.UseVisualStyleBackColor = true;
			buttonAdd.Click += buttonAdd_Click;
			// 
			// removeButton
			// 
			removeButton.Location = new Point(346, 133);
			removeButton.Name = "removeButton";
			removeButton.Size = new Size(75, 23);
			removeButton.TabIndex = 5;
			removeButton.Text = "Remove";
			removeButton.UseVisualStyleBackColor = true;
			removeButton.Click += removeButton_Click;
			// 
			// editButton
			// 
			editButton.Location = new Point(346, 191);
			editButton.Name = "editButton";
			editButton.Size = new Size(75, 23);
			editButton.TabIndex = 6;
			editButton.Text = "Edit";
			editButton.UseVisualStyleBackColor = true;
			editButton.Click += editButton_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(545, 450);
			Controls.Add(editButton);
			Controls.Add(removeButton);
			Controls.Add(buttonAdd);
			Controls.Add(listBox1);
			Name = "Form1";
			Text = "Form1";
			ResumeLayout(false);
		}

		#endregion

		private ListBox listBox1;
        private Button buttonAdd;
        private Button removeButton;
        private Button editButton;
    }
}