namespace MMEncryptor.Forms
{
    partial class CreateEmptyFolderForem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateEmptyFolderForem));
            this.CancelButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.KeyLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(228, 63);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 5;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(69, 63);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 6;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxName.Location = new System.Drawing.Point(69, 24);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(234, 20);
            this.textBoxName.TabIndex = 4;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // KeyLabel
            // 
            this.KeyLabel.AutoSize = true;
            this.KeyLabel.Location = new System.Drawing.Point(10, 27);
            this.KeyLabel.Name = "KeyLabel";
            this.KeyLabel.Size = new System.Drawing.Size(35, 13);
            this.KeyLabel.TabIndex = 3;
            this.KeyLabel.Text = "Name";
            // 
            // CreateEmptyFolderForem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 103);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.KeyLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateEmptyFolderForem";
            this.Text = "Create Empty Folder Forem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button OKButton;
        public System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label KeyLabel;
    }
}