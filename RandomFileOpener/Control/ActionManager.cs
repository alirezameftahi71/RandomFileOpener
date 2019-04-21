using Microsoft.VisualBasic.FileIO;
using System;
using System.IO;
using System.Windows.Forms;

namespace RandomFileOpener.Control
{
    public static class ActionManager
    {
        public static string SelectRandomFile(string path, string type)
        {
            string[] files = Directory.GetFiles(path, type, System.IO.SearchOption.AllDirectories);
            return files[new Random().Next(files.Length)];
        }

        public static void OpenFile(string path) => System.Diagnostics.Process.Start(path);

        public static string GetDirectoryPath(string latestPath)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.ShowNewFolderButton = false;
                folderBrowserDialog.SelectedPath = latestPath;
                DialogResult dialogResult = folderBrowserDialog.ShowDialog();

                return dialogResult == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath)
                    ? folderBrowserDialog.SelectedPath
                    : null;
            }
        }

        public static void DeleteFile(string path)
        {
            if (FileSystem.FileExists(path))
            {
                FileSystem.DeleteFile(path, UIOption.AllDialogs, RecycleOption.SendToRecycleBin);
            }
            else
            {
                throw new FileNotFoundException();
            }

        }

        public static void ShowInExplorer(string path) => System.Diagnostics.Process.Start("explorer.exe", "/select, \"" + path + "\"");
    }
}
