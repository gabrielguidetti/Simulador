using System;
using System.Windows.Forms;

namespace Simulador.Util
{
    public static class MessageHelper
    {
        public static void ConfirmationMessageBox(string text, string title, Action function)
        {
            if (MessageBox.Show(text, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                function();
        }

        public static void ErrorMessageBox(string text, string title)
        {
            MessageBox.Show(text, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void InfoMessageBox(string text, string title)
        {
            MessageBox.Show(text, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
