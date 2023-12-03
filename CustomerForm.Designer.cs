namespace CsharpProject
{
    partial class CustomerForm
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
            firstnameLabel = new Label();
            idLabel = new Label();
            nameTextBox = new TextBox();
            idTextBox = new TextBox();
            saveButton = new Button();
            lastnamelabel = new Label();
            lasatnameTextBox = new TextBox();
            textBox1 = new TextBox();
            emailLabel = new Label();
            SuspendLayout();
            // 
            // firstnameLabel
            // 
            firstnameLabel.AutoSize = true;
            firstnameLabel.Location = new Point(132, 91);
            firstnameLabel.Name = "firstnameLabel";
            firstnameLabel.Size = new Size(76, 20);
            firstnameLabel.TabIndex = 0;
            firstnameLabel.Text = "FirstName";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(132, 48);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(24, 20);
            idLabel.TabIndex = 1;
            idLabel.Text = "ID";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(220, 91);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(182, 27);
            nameTextBox.TabIndex = 2;
            // 
            // idTextBox
            // 
            idTextBox.Location = new Point(220, 45);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(182, 27);
            idTextBox.TabIndex = 3;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(152, 311);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(193, 54);
            saveButton.TabIndex = 4;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // lastnamelabel
            // 
            lastnamelabel.AutoSize = true;
            lastnamelabel.Location = new Point(132, 138);
            lastnamelabel.Name = "lastnamelabel";
            lastnamelabel.Size = new Size(75, 20);
            lastnamelabel.TabIndex = 5;
            lastnamelabel.Text = "LastName";
            // 
            // lasatnameTextBox
            // 
            lasatnameTextBox.Location = new Point(220, 135);
            lasatnameTextBox.Name = "lasatnameTextBox";
            lasatnameTextBox.Size = new Size(182, 27);
            lasatnameTextBox.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(220, 187);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(182, 27);
            textBox1.TabIndex = 7;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(142, 187);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(46, 20);
            emailLabel.TabIndex = 8;
            emailLabel.Text = "Email";
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(emailLabel);
            Controls.Add(textBox1);
            Controls.Add(lasatnameTextBox);
            Controls.Add(lastnamelabel);
            Controls.Add(saveButton);
            Controls.Add(idTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(idLabel);
            Controls.Add(firstnameLabel);
            Name = "CustomerForm";
            Text = "CustomerForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label firstnameLabel;
        private Label idLabel;
        private TextBox nameTextBox;
        private TextBox idTextBox;
        private Button saveButton;
        private Label lastnamelabel;
        private TextBox lasatnameTextBox;
        private TextBox textBox1;
        private Label emailLabel;
    }
}