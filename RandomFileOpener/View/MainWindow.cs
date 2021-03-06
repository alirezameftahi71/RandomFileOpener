using RandomFileOpener.Control;
using RandomFileOpener.Enum;
using RandomFileOpener.Model;
using RandomFileOpener.View;
using System;
using System.IO;
using System.Windows.Forms;

namespace RandomFileOpener
{
    public partial class MainWindow : Form
    {
        private Form optionsWindows;
        public MainWindow()
        {
            this.InitializeComponent();
            this.UpdateMoveToPathButtonsLabel();
        }

        private void BrowseBtn_Click(object sender, EventArgs e)
        {
            OptionsManager.Instance().MainPath = ActionManager.GetDirectoryPath(this.PathLbl.Text);
            this.PathLbl.Text = OptionsManager.Instance().MainPath;
        }

        private void RandomBtn_Click(object sender, EventArgs e)
        {
            string[] validExtentions = Utility.GetValidatedFileFormats(OptionsManager.Instance().ValidFileExtentions);
            try
            {
                SearchOption searchOption = OptionsManager.Instance().SearchSubDir == true ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;
                bool uniqueSelection = OptionsManager.Instance().SearchUnique;
                string directoryPath = this.PathLbl.Text;
                string filePath = ActionManager.SelectRandomFile(directoryPath, validExtentions, searchOption, uniqueSelection);
                string fileName = Path.GetFileNameWithoutExtension(filePath);
                string fileExtention = Path.GetExtension(filePath);
                OptionsManager.Instance().StackItems.Add(new FileItem()
                {
                    Name = fileName,
                    Extention = fileExtention,
                    Path = filePath,
                });
                this.FilesListBox.SelectedIndex = this.FilesListBox.Items.Count - 1;
                if (OptionsManager.Instance().InstantOpen)
                {
                    ActionManager.OpenFile(filePath);
                }
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
            catch (System.ComponentModel.Win32Exception error)
            {
                Utility.ShowErrorMessage(error.Message, "Application Not Found.");
            }
        }

        internal void UpdateMoveToPathButtonsLabel()
        {
            this.MovePathBtn1.Text = string.IsNullOrWhiteSpace(OptionsManager.Instance().MovePathName1) ?
                            "Move To Path #1" : OptionsManager.Instance().MovePathName1;
            this.MovePathBtn2.Text = string.IsNullOrWhiteSpace(OptionsManager.Instance().MovePathName2) ?
                            "Move To Path #2" : OptionsManager.Instance().MovePathName2;
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                FileItem fileItem = Utility.GetSelectedFileItem((int)this.FilesListBox.SelectedValue);
                ActionManager.DeleteFile(fileItem.Path);
                OptionsManager.Instance().StackItems.Remove(fileItem);
            }
            catch (FileNotFoundException error)
            {
                Utility.ShowErrorMessage("File Not Found", error.Message);
            }
            catch (NullReferenceException error)
            {
                Utility.ShowErrorMessage(error.Message, "No File is selected.");
            }
            catch (OperationCanceledException)
            {
                // Do nothing
            }
        }

        private void DeleteItemBtn_Click(object sender, EventArgs e)
        {
            try
            {
                FileItem fileItem = Utility.GetSelectedFileItem((int)this.FilesListBox.SelectedValue);
                OptionsManager.Instance().StackItems.Remove(fileItem);
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
            catch (NullReferenceException)
            {
                ActionManager.ShowInExplorer(this.PathLbl.Text, ExplorerProccessMode.Open);
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
            catch (System.ComponentModel.Win32Exception error)
            {
                Utility.ShowErrorMessage(error.Message, "Application Not Found.");
            }
        }

        private void ClearStackBtn_Click(object sender, EventArgs e)
            => OptionsManager.Instance().StackItems.Clear();

        private void OptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.optionsWindows = new OptionsWindows(this);
            this.optionsWindows.ShowDialog();
        }

        private void MovePathBtn1_Click(object sender, EventArgs e)
        {
            try
            {
                FileItem fileItem = Utility.GetSelectedFileItem((int)this.FilesListBox.SelectedValue);
                string srcPath = fileItem.Path;
                string destPath = OptionsManager.Instance().MovePath1 + "\\" + fileItem.Name + fileItem.Extention;
                ActionManager.MoveToPath(srcPath, destPath);
                OptionsManager.Instance().StackItems.Remove(fileItem);
                Utility.ShowInformationMessage("Success", $"File {fileItem.Name} Successfully moved to {OptionsManager.Instance().MovePath1}.");
            }
            catch (DirectoryNotFoundException error)
            {
                Utility.ShowErrorMessage("Path Not Found", error.Message);
            }
            catch (UnauthorizedAccessException error)
            {
                Utility.ShowErrorMessage("Access Denied", error.Message);
            }
            catch (NullReferenceException error)
            {
                Utility.ShowErrorMessage(error.Message, "No Path Selected.");
            }
        }

        private void MovePathBtn2_Click(object sender, EventArgs e)
        {
            try
            {
                FileItem fileItem = Utility.GetSelectedFileItem((int)this.FilesListBox.SelectedValue);
                string srcPath = fileItem.Path;
                string destPath = OptionsManager.Instance().MovePath2 + "\\" + fileItem.Name + fileItem.Extention;
                ActionManager.MoveToPath(srcPath, destPath);
                OptionsManager.Instance().StackItems.Remove(fileItem);
                Utility.ShowInformationMessage("Success", $"File {fileItem.Name} Successfully moved to {OptionsManager.Instance().MovePath2}.");
            }
            catch (DirectoryNotFoundException error)
            {
                Utility.ShowErrorMessage("Path Not Found", error.Message);
            }
            catch (UnauthorizedAccessException error)
            {
                Utility.ShowErrorMessage("Access Denied", error.Message);
            }
            catch (NullReferenceException error)
            {
                Utility.ShowErrorMessage(error.Message, "No Path Selected.");
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
            catch (System.ComponentModel.Win32Exception error)
            {
                Utility.ShowErrorMessage(error.Message, "Application Not Found.");
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            // Binding the listbox to a datasource here instead of .design file to prevent design time issues
            this.FilesListBox.DataSource = OptionsManager.Instance().StackItems;
            this.FilesListBox.DisplayMember = "Name";
            this.FilesListBox.ValueMember = "Id";

            this.PathLbl.Text = OptionsManager.Instance().MainPath;
        }
    }
}
