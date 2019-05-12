using RandomFileOpener.Control;
using RandomFileOpener.Model;
using RandomFileOpener.View;
using System;
using System.IO;
using System.Windows.Forms;

namespace RandomFileOpener
{
    public partial class MainWindow:Form
    {
        private static OptionsWindows optionsWindows = new OptionsWindows();
        public MainWindow() => this.InitializeComponent();

        private void BrowseBtn_Click(object sender, EventArgs e)
            => this.PathLbl.Text = ActionManager.GetDirectoryPath(this.PathLbl.Text);

        private void RandomBtn_Click(object sender, EventArgs e)
        {
            string[] validExtentions = Utility.GetValidatedFileFormats(OptionsManager.ValidFileExtentions);
            try
            {
                SearchOption searchOption = OptionsManager.SearchSubDir == true ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;
                bool uniqueSelection = OptionsManager.SearchUnique;
                string directoryPath = this.PathLbl.Text;
                string filePath = ActionManager.SelectRandomFile(directoryPath, validExtentions, searchOption, uniqueSelection);
                string fileName = Path.GetFileNameWithoutExtension(filePath);
                string fileExtention = Path.GetExtension(filePath);
                OptionsManager.StackItems.Add(new FileItem()
                {
                    Name = fileName,
                    Extention = fileExtention,
                    Path = filePath,
                });
                this.FilesListBox.SelectedIndex = this.FilesListBox.Items.Count - 1;
                ActionManager.OpenFile(filePath);
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
            catch (IndexOutOfRangeException error)
            {
                Utility.ShowErrorMessage(error.Message, "Directory is Empty or " +
                    "no file found by specified extention or " +
                    "no unique files found.");
            }
            catch (ArgumentException error)
            {
                Utility.ShowErrorMessage(error.Message, "No Path Selected.");
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                FileItem fileItem = Utility.GetSelectedFileItem((int)this.FilesListBox.SelectedValue);
                ActionManager.DeleteFile(fileItem.Path);
                OptionsManager.StackItems.Remove(fileItem);
            }
            catch (FileNotFoundException error)
            {
                Utility.ShowErrorMessage("File Not Found", error.Message);
            }
            catch (NullReferenceException error)
            {
                Utility.ShowErrorMessage(error.Message, "No File is selected.");
            }
            catch (OperationCanceledException error)
            {
                Utility.ShowInformationMessage(error.Message, "Operation was Canceled.");
            }
        }

        private void DeleteItemBtn_Click(object sender, EventArgs e)
        {
            try
            {
                FileItem fileItem = Utility.GetSelectedFileItem((int)this.FilesListBox.SelectedValue);
                OptionsManager.StackItems.Remove(fileItem);
            }
            catch (NullReferenceException error)
            {
                Utility.ShowErrorMessage(error.Message, "No File is selected.");
            }
        }

        private void FindTargetBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string fileItem = Utility.GetSelectedFileItem((int)this.FilesListBox.SelectedValue).Path;
                ActionManager.ShowInExplorer(fileItem);
            }
            catch (NullReferenceException error)
            {
                Utility.ShowErrorMessage(error.Message, "No File is selected.");
            }
        }

        private void ReOpenBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = Utility.GetSelectedFileItem((int)this.FilesListBox.SelectedValue).Path;
                ActionManager.OpenFile(filePath);
            }
            catch (FileNotFoundException error)
            {
                Utility.ShowErrorMessage("File Not Found", error.Message);
            }
            catch (NullReferenceException error)
            {
                Utility.ShowErrorMessage(error.Message, "No File is selected.");
            }
        }

        private void ClearStackBtn_Click(object sender, EventArgs e) 
            => OptionsManager.StackItems.Clear();

        private void OptionsToolStripMenuItem_Click(object sender, EventArgs e)
            => optionsWindows.ShowDialog();

        private void MovePathBtn1_Click(object sender, EventArgs e)
        {
            try
            {
                FileItem fileItem = Utility.GetSelectedFileItem((int)this.FilesListBox.SelectedValue);
                string srcPath = fileItem.Path;
                string destPath = OptionsManager.MovePath1 + "\\" + fileItem.Name + fileItem.Extention;
                ActionManager.MoveToPath(srcPath, destPath);
                Utility.ShowInformationMessage("Success", $"File {fileItem.Name} Successfully moved to {destPath}.");
            }
            catch (DirectoryNotFoundException error)
            {
                Utility.ShowErrorMessage("Path Not Found", error.Message);
            }
            catch (UnauthorizedAccessException error)
            {
                Utility.ShowErrorMessage("Access Denied", error.Message);
            }
        }

        private void MovePathBtn2_Click(object sender, EventArgs e)
        {
            try
            {
                FileItem fileItem = Utility.GetSelectedFileItem((int)this.FilesListBox.SelectedValue);
                string srcPath = fileItem.Path;
                string destPath = OptionsManager.MovePath2 + "\\" + fileItem.Name + fileItem.Extention;
                ActionManager.MoveToPath(srcPath, destPath);
                Utility.ShowInformationMessage("Success", $"File {fileItem.Name} Successfully moved to {destPath}.");
            }
            catch (DirectoryNotFoundException error)
            {
                Utility.ShowErrorMessage("Path Not Found", error.Message);
            }
            catch (UnauthorizedAccessException error)
            {
                Utility.ShowErrorMessage("Access Denied", error.Message);
            }
        }

        private void FilesListBox_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                string filePath = Utility.GetSelectedFileItem((int)this.FilesListBox.SelectedValue).Path;
                ActionManager.OpenFile(filePath);
            }
            catch (FileNotFoundException error)
            {
                Utility.ShowErrorMessage("File Not Found", error.Message);
            }
            catch (NullReferenceException error)
            {
                Utility.ShowErrorMessage(error.Message, "No File is selected.");
            }
        }
    }
}
