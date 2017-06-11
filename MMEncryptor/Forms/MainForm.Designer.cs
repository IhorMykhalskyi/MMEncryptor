namespace MMEncryptor.Forms
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.FullPathLabel = new System.Windows.Forms.Label();
            this.CatalogDataGridView = new System.Windows.Forms.DataGridView();
            this.ExtractAllButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.CatalogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelFileChoose = new System.Windows.Forms.Panel();
            this.buttonChooseMmeFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFilePath = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMMEncrypototToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelCatalog = new System.Windows.Forms.Panel();
            this.buttonExctract = new System.Windows.Forms.Button();
            this.buttonCreateEmptyFolder = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CatalogDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CatalogBindingSource)).BeginInit();
            this.panelFileChoose.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panelCatalog.SuspendLayout();
            this.SuspendLayout();
            // 
            // FullPathLabel
            // 
            this.FullPathLabel.AutoSize = true;
            this.FullPathLabel.Location = new System.Drawing.Point(12, 9);
            this.FullPathLabel.Name = "FullPathLabel";
            this.FullPathLabel.Size = new System.Drawing.Size(0, 13);
            this.FullPathLabel.TabIndex = 0;
            // 
            // CatalogDataGridView
            // 
            this.CatalogDataGridView.AllowUserToAddRows = false;
            this.CatalogDataGridView.AllowUserToDeleteRows = false;
            this.CatalogDataGridView.AllowUserToOrderColumns = true;
            this.CatalogDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CatalogDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.CatalogDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CatalogDataGridView.Location = new System.Drawing.Point(26, 36);
            this.CatalogDataGridView.Name = "CatalogDataGridView";
            this.CatalogDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CatalogDataGridView.Size = new System.Drawing.Size(853, 305);
            this.CatalogDataGridView.TabIndex = 1;
            this.CatalogDataGridView.SelectionChanged += new System.EventHandler(this.CatalogDataGridView_SelectionChanged);
            // 
            // ExtractAllButton
            // 
            this.ExtractAllButton.Location = new System.Drawing.Point(804, 7);
            this.ExtractAllButton.Name = "ExtractAllButton";
            this.ExtractAllButton.Size = new System.Drawing.Size(75, 23);
            this.ExtractAllButton.TabIndex = 2;
            this.ExtractAllButton.Text = "Extract all";
            this.ExtractAllButton.UseVisualStyleBackColor = true;
            this.ExtractAllButton.Click += new System.EventHandler(this.ExtractAllButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(26, 347);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(87, 23);
            this.AddButton.TabIndex = 3;
            this.AddButton.Text = "Add File";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddFileButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(459, 347);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(94, 23);
            this.RemoveButton.TabIndex = 3;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // panelFileChoose
            // 
            this.panelFileChoose.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panelFileChoose.Controls.Add(this.buttonChooseMmeFile);
            this.panelFileChoose.Controls.Add(this.label1);
            this.panelFileChoose.Controls.Add(this.textBoxFilePath);
            this.panelFileChoose.Location = new System.Drawing.Point(12, 27);
            this.panelFileChoose.Name = "panelFileChoose";
            this.panelFileChoose.Size = new System.Drawing.Size(908, 93);
            this.panelFileChoose.TabIndex = 4;
            // 
            // buttonChooseMmeFile
            // 
            this.buttonChooseMmeFile.Location = new System.Drawing.Point(789, 33);
            this.buttonChooseMmeFile.Name = "buttonChooseMmeFile";
            this.buttonChooseMmeFile.Size = new System.Drawing.Size(90, 22);
            this.buttonChooseMmeFile.TabIndex = 2;
            this.buttonChooseMmeFile.Text = "Choose";
            this.buttonChooseMmeFile.UseVisualStyleBackColor = true;
            this.buttonChooseMmeFile.Click += new System.EventHandler(this.buttonChooseMmeFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "MMEncryptor File Path";
            // 
            // textBoxFilePath
            // 
            this.textBoxFilePath.Location = new System.Drawing.Point(146, 35);
            this.textBoxFilePath.Name = "textBoxFilePath";
            this.textBoxFilePath.ReadOnly = true;
            this.textBoxFilePath.Size = new System.Drawing.Size(637, 20);
            this.textBoxFilePath.TabIndex = 0;
            this.textBoxFilePath.TextChanged += new System.EventHandler(this.textBoxFilePath_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(932, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNewToolStripMenuItem,
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // createNewToolStripMenuItem
            // 
            this.createNewToolStripMenuItem.Name = "createNewToolStripMenuItem";
            this.createNewToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.createNewToolStripMenuItem.Text = "Create New";
            this.createNewToolStripMenuItem.Click += new System.EventHandler(this.createNewToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewHelpToolStripMenuItem,
            this.aboutMMEncrypototToolStripMenuItem});
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.infoToolStripMenuItem.Text = "Help";
            // 
            // viewHelpToolStripMenuItem
            // 
            this.viewHelpToolStripMenuItem.Name = "viewHelpToolStripMenuItem";
            this.viewHelpToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.viewHelpToolStripMenuItem.Text = "View Help";
            // 
            // aboutMMEncrypototToolStripMenuItem
            // 
            this.aboutMMEncrypototToolStripMenuItem.Name = "aboutMMEncrypototToolStripMenuItem";
            this.aboutMMEncrypototToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.aboutMMEncrypototToolStripMenuItem.Text = "About MMEncrypotot";
            // 
            // panelCatalog
            // 
            this.panelCatalog.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelCatalog.Controls.Add(this.ExtractAllButton);
            this.panelCatalog.Controls.Add(this.buttonExctract);
            this.panelCatalog.Controls.Add(this.buttonCreateEmptyFolder);
            this.panelCatalog.Controls.Add(this.buttonOpen);
            this.panelCatalog.Controls.Add(this.buttonBack);
            this.panelCatalog.Controls.Add(this.AddButton);
            this.panelCatalog.Controls.Add(this.RemoveButton);
            this.panelCatalog.Controls.Add(this.CatalogDataGridView);
            this.panelCatalog.Location = new System.Drawing.Point(12, 126);
            this.panelCatalog.Name = "panelCatalog";
            this.panelCatalog.Size = new System.Drawing.Size(908, 379);
            this.panelCatalog.TabIndex = 6;
            // 
            // buttonExctract
            // 
            this.buttonExctract.Location = new System.Drawing.Point(353, 347);
            this.buttonExctract.Name = "buttonExctract";
            this.buttonExctract.Size = new System.Drawing.Size(100, 23);
            this.buttonExctract.TabIndex = 6;
            this.buttonExctract.Text = "Extract";
            this.buttonExctract.UseVisualStyleBackColor = true;
            this.buttonExctract.Click += new System.EventHandler(this.buttonExctract_Click);
            // 
            // buttonCreateEmptyFolder
            // 
            this.buttonCreateEmptyFolder.Location = new System.Drawing.Point(119, 347);
            this.buttonCreateEmptyFolder.Name = "buttonCreateEmptyFolder";
            this.buttonCreateEmptyFolder.Size = new System.Drawing.Size(113, 23);
            this.buttonCreateEmptyFolder.TabIndex = 5;
            this.buttonCreateEmptyFolder.Text = "Create Empty Folder";
            this.buttonCreateEmptyFolder.UseVisualStyleBackColor = true;
            this.buttonCreateEmptyFolder.Click += new System.EventHandler(this.buttonCreateEmptyFolder_Click);
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(238, 347);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(109, 23);
            this.buttonOpen.TabIndex = 4;
            this.buttonOpen.Text = "Open";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(26, 7);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 3;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 510);
            this.Controls.Add(this.panelFileChoose);
            this.Controls.Add(this.FullPathLabel);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panelCatalog);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MMEncryptor";
            ((System.ComponentModel.ISupportInitialize)(this.CatalogDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CatalogBindingSource)).EndInit();
            this.panelFileChoose.ResumeLayout(false);
            this.panelFileChoose.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelCatalog.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FullPathLabel;
        private System.Windows.Forms.DataGridView CatalogDataGridView;
        private System.Windows.Forms.Button ExtractAllButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.BindingSource CatalogBindingSource;
        private System.Windows.Forms.Panel panelFileChoose;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMMEncrypototToolStripMenuItem;
        private System.Windows.Forms.Button buttonChooseMmeFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFilePath;
        private System.Windows.Forms.Panel panelCatalog;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonCreateEmptyFolder;
        private System.Windows.Forms.Button buttonExctract;
    }
}