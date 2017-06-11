using System.Text;
using System.Windows.Forms;

namespace MMEncryptor.Forms
{
    public partial class KeyShowForm : Form
    {
        public KeyShowForm(string key)
        {
            InitializeComponent();
            textBoxKey.Text = key;
        }

        private void buttonOK_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
