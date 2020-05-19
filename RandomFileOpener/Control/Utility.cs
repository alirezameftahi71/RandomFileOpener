using RandomFileOpener.Model;
using System.Linq;
using System.Windows.Forms;

namespace RandomFileOpener.Control
{
    public static class Utility
    {
        public static void ShowErrorMessage(string title, string message)
            => MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

        public static void ShowWarningMessage(string title, string message)
            => MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

        public static void ShowInformationMessage(string title, string message)
        {
            if (OptionsManager.Instance.ShowInformationMessages)
            {
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }

        public static string[] GetValidatedFileFormats(string userInput)
            => !string.IsNullOrWhiteSpace(userInput) ? userInput.Split(',') : (new string[] { "*.*" });

        public static FileItem GetSelectedFileItem(int id)
            => OptionsManager.Instance.StackItems.Where(x => x.Id == id).FirstOrDefault();
    }
}
