namespace MMEncryptor.Forms
{
    partial class KeyEnterForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KeyEnterForm));
            this.KeyLabel = new System.Windows.Forms.Label();
            this.KeyTextBox = new System.Windows.Forms.TextBox();
            this.OKButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // KeyLabel
            // 
            this.KeyLabel.AutoSize = true;
            this.KeyLabel.Location = new System.Drawing.Point(9, 15);
            this.KeyLabel.Name = "KeyLabel";
            this.KeyLabel.Size = new System.Drawing.Size(59, 13);
            this.KeyLabel.TabIndex = 0;
            this.KeyLabel.Text = "Secret Key";
            // 
            // KeyTextBox
            // 
            this.KeyTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KeyTextBox.Location = new System.Drawing.Point(68, 12);
            this.KeyTextBox.Name = "KeyTextBox";
            this.KeyTextBox.Size = new System.Drawing.Size(258, 20);
            this.KeyTextBox.TabIndex = 1;
            this.KeyTextBox.TextChanged += new System.EventHandler(this.KeyTextBox_TextChanged);
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(68, 51);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 2;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(202, 51);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 2;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // KeyEnterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 84);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.KeyTextBox);
            this.Controls.Add(this.KeyLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KeyEnterForm";
            this.Text = "Key Enter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label KeyLabel;
        public System.Windows.Forms.TextBox KeyTextBox;
        private System.Windows.Forms.Button OKButton;
        private new System.Windows.Forms.Button CancelButton;
    }
}

