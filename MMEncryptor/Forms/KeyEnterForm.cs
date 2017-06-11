using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MMEncryptor.Forms
{
    public partial class KeyEnterForm : Form
    {
        public string Key { get; private set; }

        public KeyEnterForm()
        {
            InitializeComponent();
            OKButton.Enabled = false;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            Key = KeyTextBox.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void KeyTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(KeyTextBox.Text))
            {
                OKButton.Enabled = false;
            }
            else {
                OKButton.Enabled = true;
            }
        }
    }
}
