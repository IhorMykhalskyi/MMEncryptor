namespace MMEncryptor.Forms
{
    partial class CreateNewMmeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateNewMmeForm));
            this.NewFileNameLabel = new System.Windows.Forms.Label();
            this.NewFileNameTextBox = new System.Windows.Forms.TextBox();
            this.ChooseButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.CreateButton = new System.Windows.Forms.Button();
            this.ChoosenFilesTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonChooseFileToSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NewFileNameLabel
            // 
            this.NewFileNameLabel.AutoSize = true;
            this.NewFileNameLabel.Location = new System.Drawing.Point(12, 13);
            this.NewFileNameLabel.Name = "NewFileNameLabel";
            this.NewFileNameLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NewFileNameLabel.Size = new System.Drawing.Size(102, 13);
            this.NewFileNameLabel.TabIndex = 0;
            this.NewFileNameLabel.Text = "Your MME file name";
            // 
            // NewFileNameTextBox
            // 
            this.NewFileNameTextBox.Location = new System.Drawing.Point(141, 10);
            this.NewFileNameTextBox.Name = "NewFileNameTextBox";
            this.NewFileNameTextBox.ReadOnly = true;
            this.NewFileNameTextBox.Size = new System.Drawing.Size(293, 20);
            this.NewFileNameTextBox.TabIndex = 1;
            // 
            // ChooseButton
            // 
            this.ChooseButton.Location = new System.Drawing.Point(440, 42);
            this.ChooseButton.Name = "ChooseButton";
            this.ChooseButton.Size = new System.Drawing.Size(91, 23);
            this.ChooseButton.TabIndex = 2;
            this.ChooseButton.Text = "Choose";
            this.ChooseButton.UseVisualStyleBackColor = true;
            this.ChooseButton.Click += new System.EventHandler(this.ChooseButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(343, 82);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(91, 23);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(141, 82);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(91, 23);
            this.CreateButton.TabIndex = 3;
            this.CreateButton.Text = "Create";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // ChoosenFilesTextBox
            // 
            this.ChoosenFilesTextBox.Location = new System.Drawing.Point(141, 44);
            this.ChoosenFilesTextBox.Name = "ChoosenFilesTextBox";
            this.ChoosenFilesTextBox.ReadOnly = true;
            this.ChoosenFilesTextBox.Size = new System.Drawing.Size(293, 20);
            this.ChoosenFilesTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Files to add to MME  File";
            // 
            // buttonChooseFileToSave
            // 
            this.buttonChooseFileToSave.Location = new System.Drawing.Point(440, 10);
            this.buttonChooseFileToSave.Name = "buttonChooseFileToSave";
            this.buttonChooseFileToSave.Size = new System.Drawing.Size(91, 23);
            this.buttonChooseFileToSave.TabIndex = 5;
            this.buttonChooseFileToSave.Text = "Choose";
            this.buttonChooseFileToSave.UseVisualStyleBackColor = true;
            this.buttonChooseFileToSave.Click += new System.EventHandler(this.buttonChooseFileToSave_Click);
            // 
            // CreateNewMmeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 116);
            this.Controls.Add(this.buttonChooseFileToSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ChooseButton);
            this.Controls.Add(this.ChoosenFilesTextBox);
            this.Controls.Add(this.NewFileNameTextBox);
            this.Controls.Add(this.NewFileNameLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateNewMmeForm";
            this.Text = "Create New MME File";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NewFileNameLabel;
        private System.Windows.Forms.TextBox NewFileNameTextBox;
        private System.Windows.Forms.Button ChooseButton;
        private new System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.TextBox ChoosenFilesTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonChooseFileToSave;
    }
}