namespace CsharpProject
{
    partial class ProductForm
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
            NameLabel = new Label();
            nameTextBox = new TextBox();
            PriceLable = new Label();
            priceTextBox = new TextBox();
            saveButton = new Button();
            CountLabel = new Label();
            brandLabel = new Label();
            countLextBox = new TextBox();
            brandTextBox = new TextBox();
            IssActiveCheckBox = new CheckBox();
            SuspendLayout();
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(35, 30);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(49, 20);
            NameLabel.TabIndex = 0;
            NameLabel.Text = "Name";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(108, 30);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(162, 27);
            nameTextBox.TabIndex = 1;
            // 
            // PriceLable
            // 
            PriceLable.AutoSize = true;
            PriceLable.Location = new Point(34, 89);
            PriceLable.Name = "PriceLable";
            PriceLable.Size = new Size(41, 20);
            PriceLable.TabIndex = 2;
            PriceLable.Text = "Price";
            // 
            // priceTextBox
            // 
            priceTextBox.Location = new Point(108, 86);
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Size = new Size(162, 27);
            priceTextBox.TabIndex = 3;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(282, 355);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(175, 44);
            saveButton.TabIndex = 4;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // CountLabel
            // 
            CountLabel.AutoSize = true;
            CountLabel.Location = new Point(338, 33);
            CountLabel.Name = "CountLabel";
            CountLabel.Size = new Size(48, 20);
            CountLabel.TabIndex = 5;
            CountLabel.Text = "Count";
            // 
            // brandLabel
            // 
            brandLabel.AutoSize = true;
            brandLabel.Location = new Point(338, 93);
            brandLabel.Name = "brandLabel";
            brandLabel.Size = new Size(88, 20);
            brandLabel.TabIndex = 6;
            brandLabel.Text = "BrandName";
            // 
            // countLextBox
            // 
            countLextBox.Location = new Point(440, 27);
            countLextBox.Name = "countLextBox";
            countLextBox.Size = new Size(178, 27);
            countLextBox.TabIndex = 7;
            // 
            // brandTextBox
            // 
            brandTextBox.Location = new Point(440, 82);
            brandTextBox.Name = "brandTextBox";
            brandTextBox.Size = new Size(178, 27);
            brandTextBox.TabIndex = 8;
            // 
            // IssActiveCheckBox
            // 
            IssActiveCheckBox.AutoSize = true;
            IssActiveCheckBox.Location = new Point(679, 85);
            IssActiveCheckBox.Name = "IssActiveCheckBox";
            IssActiveCheckBox.Size = new Size(82, 24);
            IssActiveCheckBox.TabIndex = 9;
            IssActiveCheckBox.Text = "IsActive";
            IssActiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(IssActiveCheckBox);
            Controls.Add(brandTextBox);
            Controls.Add(countLextBox);
            Controls.Add(brandLabel);
            Controls.Add(CountLabel);
            Controls.Add(saveButton);
            Controls.Add(priceTextBox);
            Controls.Add(PriceLable);
            Controls.Add(nameTextBox);
            Controls.Add(NameLabel);
            Name = "ProductForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NameLabel;
        private TextBox nameTextBox;
        private Label PriceLable;
        private TextBox priceTextBox;
        private Button saveButton;
        private Label CountLabel;
        private Label brandLabel;
        private TextBox countLextBox;
        private TextBox brandTextBox;
        private CheckBox IssActiveCheckBox;
    }
}