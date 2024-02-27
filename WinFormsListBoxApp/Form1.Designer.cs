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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.inputText = new System.Windows.Forms.TextBox();
            this.labelCity = new System.Windows.Forms.Label();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.cmbCities = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(68, 87);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(211, 259);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(346, 75);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // inputText
            // 
            this.inputText.Location = new System.Drawing.Point(68, 35);
            this.inputText.Name = "inputText";
            this.inputText.Size = new System.Drawing.Size(211, 23);
            this.inputText.TabIndex = 2;
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCity.Location = new System.Drawing.Point(346, 238);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(130, 54);
            this.labelCity.TabIndex = 3;
            this.labelCity.Text = "label1";
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(346, 104);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(75, 23);
            this.buttonInsert.TabIndex = 4;
            this.buttonInsert.Text = "Insert";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click_1);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(346, 133);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 5;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(346, 162);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 6;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // cmbCities
            // 
            this.cmbCities.FormattingEnabled = true;
            this.cmbCities.Location = new System.Drawing.Point(571, 35);
            this.cmbCities.Name = "cmbCities";
            this.cmbCities.Size = new System.Drawing.Size(270, 23);
            this.cmbCities.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 450);
            this.Controls.Add(this.cmbCities);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.inputText);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listBox1;
        private Button buttonAdd;
        private TextBox inputText;
        private Label labelCity;
        private Button buttonInsert;
        private Button removeButton;
        private Button editButton;
        private ComboBox cmbCities;
    }
}