using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using constants = MMEncryptor.Constants.Constants;

namespace MMEncryptor.Forms
{
    public partial class CreateNewMmeForm : Form
    {
        public string FullName { get; private set; }
        public IEnumerable<FileInfo> FileInfos { get; private set; }

        public CreateNewMmeForm()
        {
            InitializeComponent();
            CreateButton.Enabled = false;
        }

        private void ChooseButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog fileDialog = new OpenFileDialog())
            {
                fileDialog.Multiselect = true;
                fileDialog.ShowDialog();
                string[] fileNames = fileDialog.FileNames;
                if (fileNames.Count() > 0)
                {
                    FileInfos = from name in fileNames
                                select new FileInfo(name);
                    ChoosenFilesTextBox.Text = ConvertStringArrayToString(fileNames);

                    UpdateCreateButton();               
                }
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            FullName = null;
            FileInfos = null;
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonChooseFileToSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.DefaultExt = constants.MME_FILE_EXTENTION.Remove(0,1);
            sf.AddExtension = true;
            sf.Filter = constants.MME_FILE_FILTER;
            if (sf.ShowDialog() == DialogResult.OK)
            {
                FullName = sf.FileName;
                NewFileNameTextBox.Text = sf.FileName;
                UpdateCreateButton();
            }
        }   

        private void UpdateCreateButton()
        {
            if (!string.IsNullOrWhiteSpace(Name) && FileInfos != null)
            {
                CreateButton.Enabled = true;
            }
            else
            {
                CreateButton.Enabled = false;
            }
        }

        private static string ConvertStringArrayToString(string[] array)
        {
            StringBuilder builder = new StringBuilder();
            foreach (string value in array)
            {
                builder.Append(value);
                builder.Append(", ");
            }
            return builder.ToString();
        }
    }
}
