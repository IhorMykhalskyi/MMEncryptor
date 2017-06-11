using System;
using MMEncryptor.Forms;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using MMEncryptor.Utils;
using System.Text;

namespace MMEncryptor
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            //if (args?.Length == 1)
            //{
            //    Regex regex = new Regex(".*\\.mme");
            //    Match match = regex.Match(args[0]);
            //    if (match.Success)
            //    {
            //        KeyConfirmationForm keyConfirmationForm = new KeyConfirmationForm();
            //        Application.Run(keyConfirmationForm);
            //        if (keyConfirmationForm.ShowDialog() == DialogResult.OK)
            //        {
            //            var key = keyConfirmationForm.KeyTextBox.Text;
            //        }
            //    }
            //}
            Application.Run(new MainForm());
        }
    }
}
