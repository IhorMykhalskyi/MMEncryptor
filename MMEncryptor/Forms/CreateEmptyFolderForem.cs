using System;
using System.Windows.Forms;

namespace MMEncryptor.Forms
{
    public partial class CreateEmptyFolderForem : Form
    {
        public string Name { get; private set; } 

        public CreateEmptyFolderForem()
        {
            InitializeComponent();
            OKButton.Enabled = false;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            Name = textBoxName.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxName.Text))
            {
                OKButton.Enabled = false;
            }
            else
            {
                OKButton.Enabled = true;
            }
        }
    }
}
