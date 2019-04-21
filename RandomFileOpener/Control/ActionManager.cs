using Microsoft.VisualBasic.FileIO;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace RandomFileOpener.Control
{
    public static class ActionManager
    {
        public static string SelectRandomFile(string path, string[] formats)
        {
            string[] files = formats.SelectMany(format => Directory.EnumerateFiles(path, format, System.IO.SearchOption.AllDirectories))
                .ToArray();
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

        public static void DeleteFile(string path) => FileSystem.DeleteFile(path, UIOption.AllDialogs, RecycleOption.SendToRecycleBin);

        public static void ShowInExplorer(string path) => System.Diagnostics.Process.Start("explorer.exe", "/select, \"" + path + "\"");
    }
}
