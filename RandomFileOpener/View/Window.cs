using RandomFileOpener.Control;
using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace RandomFileOpener
{
    public partial class MainWindow:Form
    {
        //Utility.WriteToLog(this.LogLbl, );
        public MainWindow() => this.InitializeComponent();

        private void BrowseBtn_Click(object sender, EventArgs e) => this.PathLbl.Text = ActionManager.GetDirectoryPath(this.PathLbl.Text);

        private void RandomBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string fullPathToFile = ActionManager.SelectRandomFile(this.PathLbl.Text, "*.*");
                this.FilesListBox.Items.Add(fullPathToFile);
                this.FilesListBox.SelectedIndex = this.FilesListBox.Items.Count - 1;
                ActionManager.OpenFile(fullPathToFile);
            }
            catch (UnauthorizedAccessException error)
            {
                Utility.ShowErrorMessage("Access Denied", error.Message);
            }
            catch (FileNotFoundException error)
            {
                Utility.ShowErrorMessage("File Not Found", error.Message);
            }
            catch (DirectoryNotFoundException error)
            {
                Utility.ShowErrorMessage("Directory Not Found", error.Message);
            }
        }

        private void ReOpenBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ActionManager.OpenFile(this.FilesListBox.SelectedItem.ToString());
            }
            catch (FileNotFoundException error)
            {
                Utility.ShowErrorMessage("File Not Found", error.Message);
            }
            catch (NullReferenceException error)
            {
                Utility.ShowErrorMessage(error.Message, "No File is selected to be opened.");
            }
            catch (Win32Exception error)
            {
                Utility.ShowErrorMessage("File Not Found", error.Message);
            }
        }

        private void DeleteItemBtn_Click(object sender, EventArgs e)
        {
            try
            {
                this.FilesListBox.Items.RemoveAt(this.FilesListBox.SelectedIndex);
            }
            catch (ArgumentOutOfRangeException error)
            {
                Utility.ShowErrorMessage(error.Message, "No Item Selected to be removed from the list.");
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ActionManager.DeleteFile(this.FilesListBox.SelectedItem.ToString());
                this.FilesListBox.Items.RemoveAt(this.FilesListBox.SelectedIndex);
            }
            catch (FileNotFoundException error)
            {
                Utility.ShowErrorMessage("File Not Found", error.Message);
            }
            catch (NullReferenceException error)
            {
                Utility.ShowErrorMessage(error.Message, "No File is Selected to be deleted.");
            }
        }

        private void FindTargetBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ActionManager.ShowInExplorer(this.FilesListBox.SelectedItem.ToString());
            }
            catch (NullReferenceException error)
            {
                Utility.ShowErrorMessage(error.Message, "No File Selected to be referenced.");
            }
        }
    }
}
