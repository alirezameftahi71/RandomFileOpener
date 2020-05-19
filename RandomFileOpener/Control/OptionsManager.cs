using RandomFileOpener.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace RandomFileOpener.Control
{
    public class OptionsManager
    {
        public static OptionsManager Instance { get; private set; }
        static OptionsManager()
        {
            OptionsManager.Instance = new OptionsManager();
        }
        ~OptionsManager()
        {
            OptionsManager.StoreLatestSettings();
        }

        public OptionsManager()
        {
            this.SearchSubDir = Properties.Settings.Default.SearchSubDir;
            this.SearchUnique = Properties.Settings.Default.SearchUnique;
            this.InstantOpen = Properties.Settings.Default.InstantOpen;
            this.MainPath = Properties.Settings.Default.MainPath;
            this.MovePath1 = Properties.Settings.Default.MovePath1;
            this.MovePathName1 = Properties.Settings.Default.MovePathBtnLabel1;
            this.MovePathName2 = Properties.Settings.Default.MovePathBtnLabel2;
            this.MovePath2 = Properties.Settings.Default.MovePath2;
            this.ValidFileExtentions = Properties.Settings.Default.ValidFileExtentions;
            this.ShowInformationMessages = Properties.Settings.Default.ShowInformationMessages;
        }

        public BindingList<FileItem> StackItems { get; set; } = new BindingList<FileItem>();
        public bool SearchSubDir { get; set; }
        public bool SearchUnique { get; set; }
        public bool InstantOpen { get; set; }
        public bool ShowInformationMessages { get; set; }
        public string ValidFileExtentions { get; set; }
        public string MainPath { get; set; }
        public string MovePath1 { get; set; }
        public string MovePath2 { get; set; }
        public string MovePathName1 { get; set; }
        public string MovePathName2 { get; set; }

        public static void StoreLatestSettings()
        {
            Properties.Settings.Default.SearchSubDir = OptionsManager.Instance.SearchSubDir;
            Properties.Settings.Default.SearchUnique = OptionsManager.Instance.SearchUnique;
            Properties.Settings.Default.InstantOpen = OptionsManager.Instance.InstantOpen;
            Properties.Settings.Default.MainPath = OptionsManager.Instance.MainPath;
            Properties.Settings.Default.MovePath1 = OptionsManager.Instance.MovePath1;
            Properties.Settings.Default.MovePath2 = OptionsManager.Instance.MovePath2;
            Properties.Settings.Default.ValidFileExtentions = OptionsManager.Instance.ValidFileExtentions;
            Properties.Settings.Default.MovePathBtnLabel1 = OptionsManager.Instance.MovePathName1;
            Properties.Settings.Default.MovePathBtnLabel2 = OptionsManager.Instance.MovePathName2;
            Properties.Settings.Default.ShowInformationMessages = OptionsManager.Instance.ShowInformationMessages;
            Properties.Settings.Default.Save();
        }
    }
}
